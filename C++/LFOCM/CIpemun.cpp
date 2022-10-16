#include "pch.h"
#include "Ipemunwrap.h"
#include <cmath>

#define POS_RES     0x01   /* 1st bit */
#define NEG_RES     0x02   /* 2nd bit */
#define VISITED     0x04   /* 3rd bit */
#define ACTIVE      0x08   /* 4th bit */
#define BRANCH_CUT  0x10   /* 5th bit */
#define BORDER      0x20   /* 6th bit */
#define UNWRAPPED   0x40   /* 7th bit */
#define POSTPONED   0x80   /* 8th bit */
#define RESIDUE      (POS_RES | NEG_RES)
#define AVOID        (BRANCH_CUT | BORDER)
#define lambda      0.532



CIpemBase::CIpemBase(void)
{

}


CIpemBase::~CIpemBase(void)
{

}

float Gradient(float p1, float p2)
{
	float  r;
	r = p1 - p2;
	if (r > 0.5) r -= 1.0;
	if (r < -0.5) r += 1.0;
	return r;
}

CIpemunwrap::CIpemunwrap(void)
{
	phase = NULL;
	soln = NULL;
	bitflags = NULL;
	qual_map = NULL;
	index_list = NULL;
	active_list = NULL;
	m_width = 0;
	m_height = 0;
}

CIpemunwrap::~CIpemunwrap(void)
{
	Free();
}

void CIpemunwrap::Free(void)
{
	if (phase != NULL)
	{
		free(phase);
		phase = NULL;
	}
	if (soln != NULL)
	{
		free(soln);
		soln = NULL;
	}
	if (bitflags != NULL)
	{
		free(bitflags);
		bitflags = NULL;
	}
	if (qual_map != NULL)
	{
		free(qual_map);
		qual_map = NULL;
	}
	if (index_list != NULL)
	{
		free(index_list);
		index_list = NULL;
	}
	if (active_list != NULL)
	{
		free(active_list);
		active_list = NULL;
	}
}

void CIpemunwrap::SetSize(int nW, int nH)
{
	if ((nW == m_width) && (nH == m_height))
	{
		return;
	}
	Free();
	m_width = nW;
	m_height = nH;
	m_size = m_width * m_height;
	m_maxsize = m_size;
	phase = (float*)malloc(m_size * sizeof(float));
	soln = (float*)malloc(m_size * sizeof(float));
	bitflags = (unsigned char*)malloc(m_size * sizeof(unsigned char));
	qual_map = (float*)malloc(m_size * sizeof(float));
	index_list = (int*)malloc(m_size * sizeof(int));
	active_list = (int*)malloc(m_size * sizeof(int));
	memset(phase, 0, m_size * sizeof(float));
	memset(soln, 0, m_size * sizeof(float));
	memset(bitflags, 0, m_size * sizeof(unsigned char));
	memset(qual_map, 0, m_size * sizeof(float));
	memset(index_list, 0, m_size * sizeof(int));
	memset(active_list, 0, m_size * sizeof(int));
}

void CIpemunwrap::Unwrap_GoldStein(float* data)
{
	int i, j, pos;
#pragma omp parallel for  private(i,pos)
	for (j = 0; j < m_height; j++)
	{
		for (i = 0; i < m_width; i++)
		{
			pos = j * m_width + i;
			phase[pos] = data[pos] / (2 * PI1);
			bitflags[pos] = 0;
			soln[pos] = 0;
		}
	}

	int   NumRes, MaxCutLen = 0;
	NumRes = Residues(phase, bitflags, POS_RES, NEG_RES, BORDER, m_width, m_height);

	if (MaxCutLen == 0) MaxCutLen = (m_width + m_height) / 2;
	GoldsteinBranchCuts(bitflags, MaxCutLen, NumRes, m_width, m_height,
		BRANCH_CUT);

	UnwrapAroundCuts(phase, bitflags, soln, m_width, m_height, AVOID, 0, NULL);

	//	memcpy(data,soln,m_size * sizeof(float));
#pragma omp parallel for  private(i,pos)
	for (j = 0; j < m_height; j++)
	{
		for (i = 0; i < m_width; i++)
		{
			pos = j * m_width + i;
			data[pos] = soln[pos] * (2 * PI1);
		}
	}
}

void CIpemunwrap::Unwrap_QualityMap(float* data)
{
	int i, j, pos;
#pragma omp parallel for  private(i,pos)
	for (j = 0; j < m_height; j++)
	{
		for (i = 0; i < m_width; i++)
		{
			pos = j * m_width + i;
			phase[pos] = data[pos] / (2 * PI1);
			bitflags[pos] = 0;
			soln[pos] = 0;
			qual_map[pos] = 0;
		}
	}

	QualityGuidedPathFollower(phase, qual_map, bitflags, soln, m_width, m_height, BORDER);

#pragma omp parallel for  private(i,pos)
	for (j = 0; j < m_height; j++)
	{
		for (i = 0; i < m_width; i++)
		{
			pos = j * m_width + i;
			data[pos] = soln[pos] * (2 * PI1);
		}
	}
}

void CIpemunwrap::Unwrapping(float* data, int nType)
{
	switch (nType)
	{
	case 0: break;
	case 1: Unwrap_GoldStein(data); break;
	case 2: Unwrap_QualityMap(data); break;
	default: break;
	}
}

/*************************************
 *  GOLDSTEIN
 *************************************/
int CIpemunwrap::Residues(float* phase, unsigned char* bitflags, int posres_code,
	int negres_code, int avoid_code, int xsize, int ysize)
{
	int  i, j, k, NumRes = 0;
	float  r;

	for (j = 0; j < ysize - 1; j++) {
		for (i = 0; i < xsize - 1; i++) {
			k = j * xsize + i;
			if (bitflags && ((bitflags[k] & avoid_code)
				|| (bitflags[k + 1] & avoid_code)
				|| (bitflags[k + 1 + xsize] & avoid_code)
				|| (bitflags[k + xsize] & avoid_code)))
			{
				continue; /* masked region: don't unwrap */
			}
			r = Gradient(phase[k + 1], phase[k])
				+ Gradient(phase[k + 1 + xsize], phase[k + 1])
				+ Gradient(phase[k + xsize], phase[k + 1 + xsize])
				+ Gradient(phase[k], phase[k + xsize]);
			if (bitflags)
			{
				if (r > 0.01) bitflags[k] |= posres_code;
				else if (r < -0.01) bitflags[k] |= negres_code;
			}
			if (r * r > 0.01) ++NumRes;
		}
	}
	return NumRes;
}

/* Place a branch cut in the bitflags array from pixel (a,b) */
/* to pixel (c,d).  The bit for the branch cut pixels is     */
/* given by the value of "code".                             */
void CIpemunwrap::PlaceCut(unsigned char* array, int a, int b, int c, int d,
	int xsize, int ysize, int code)
{
	int  i, j, m, n, istep, jstep;
	float  r;

	/* residue location is upper-left corner of 4-square */
	if (c > a && a > 0) a++;
	else if (c < a && c > 0) c++;
	if (d > b && b > 0) b++;
	else if (d < b && d > 0) d++;

	if (a == c && b == d)
	{
		array[b * xsize + a] |= code;
		return;
	}
	m = (a < c) ? c - a : a - c;
	n = (b < d) ? d - b : b - d;
	if (m > n)
	{
		istep = (a < c) ? +1 : -1;
		r = ((float)(d - b)) / ((float)(c - a));
		for (i = a; i != c + istep; i += istep) {
			j = b + (i - a) * r + 0.5;
			array[j * xsize + i] |= code;
		}
	}
	else {   /* n < m */
		jstep = (b < d) ? +1 : -1;
		r = ((float)(c - a)) / ((float)(d - b));
		for (j = b; j != d + jstep; j += jstep)
		{
			i = a + (j - b) * r + 0.5;
			array[j * xsize + i] |= code;
		}
	}
	return;
}

/* Return the squared distance between the pixel (a,b) and the */
/* nearest border pixel.  The border pixels are encoded in the */
/* bitflags array by the value of "border_code".               */
int CIpemunwrap::DistToBorder(unsigned char* bitflags, int border_code,
	int a, int b, int* ra, int* rb, int xsize, int ysize)
{
	int  besta, bestb, found, dist2, best_dist2;
	int  i, j, k, bs;
	*ra = *rb = 0;
	for (bs = 0; bs < xsize + ysize; bs++)
	{
		found = 0;
		best_dist2 = 1000000;  /* initialize to large value */
		/* search boxes of increasing size until border pixel found */
		for (j = b - bs; j <= b + bs; j++) {
			for (i = a - bs; i <= a + bs; i++) {
				k = j * xsize + i;
				if (i <= 0 || i >= xsize - 1 || j <= 0 || j >= ysize - 1
					|| (bitflags[k] & border_code)) {
					found = 1;
					dist2 = (j - b) * (j - b) + (i - a) * (i - a);
					if (dist2 < best_dist2) {
						best_dist2 = dist2;
						besta = i;
						bestb = j;
					}
				}
			}
		}
		if (found)
		{
			*ra = besta;
			*rb = bestb;
			break;
		}
	}
	return best_dist2;
}

/* Unwrap the phase data (by Itoh's method) without crossing
 * any branch cuts.  Return number of disconnected pieces.
 */
int CIpemunwrap::UnwrapAroundCuts(float* phase, unsigned char* bitflags,
	float* soln, int xsize, int ysize, int cut_code,
	int debug_flag, char* infile)
{
	int  i, j, k, a, b, c, n, num_pieces = 0;
	float  value;
	float  min_qual, small_val = -1.0E+10;
	int    num_index, max_list_size, bench, benchout;
	// int    *index_list;
	int    unwrapped_code = UNWRAPPED, postponed_code = POSTPONED;
	int    avoid_code;

	bench = xsize * ysize / 100;
	if (bench < 1) bench = 1;
	benchout = 10 * bench;
	min_qual = small_val;
	max_list_size = xsize * ysize; /* this size may be reduced */

	avoid_code = cut_code | unwrapped_code | BORDER;

	/* find starting point */
	n = 0;
	num_index = 0;
	for (j = 0; j < ysize; j++)
	{
		for (i = 0; i < xsize; i++)
		{
			k = j * xsize + i;
			if (!(bitflags[k] & avoid_code))
			{
				bitflags[k] |= unwrapped_code;
				if (bitflags[k] & postponed_code)
					/* soln[k] already stores the unwrapped value */
					value = soln[k];
				else
				{
					++num_pieces;
					value = soln[k] = phase[k];
				}
				UpdateList(NULL, i, j, value, phase, soln, bitflags, xsize,
					ysize, index_list, &num_index, avoid_code,
					unwrapped_code, postponed_code, max_list_size,
					0, &min_qual);
				while (num_index > 0)
				{
					if (!GetNextOneToUnwrap(&a, &b, index_list,
						&num_index, xsize, ysize))
						break;   /* no more to unwrap */
					c = b * xsize + a;
					bitflags[c] |= unwrapped_code;
					value = soln[c];
					UpdateList(NULL, a, b, value, phase, soln, bitflags,
						xsize, ysize, index_list, &num_index,
						avoid_code, unwrapped_code, postponed_code,
						max_list_size, 0, &min_qual);
				}
			}
		}
	}
	/* unwrap branch cut pixels */
	for (j = 1; j < ysize; j++)
	{
		for (i = 1; i < xsize; i++)
		{
			k = j * xsize + i;
			if (bitflags[k] & cut_code)
			{
				if (!(bitflags[k - 1] & cut_code))
					soln[k] = soln[k - 1] + Gradient(phase[k], phase[k - 1]);
				else if (!(bitflags[k - xsize] & cut_code))
					soln[k] = soln[k - xsize] + Gradient(phase[k], phase[k - xsize]);
			}
		}
	}
	return num_pieces;
}

void CIpemunwrap::GoldsteinBranchCuts(unsigned char* bitflags, int MaxCutLen,
	int NumRes, int xsize, int ysize, int branchcut_code)
{
	int            i, j, k, ii, jj, kk, ri, rj;
	int            charge, boxctr_i, boxctr_j, boxsize, bs2;
	int            dist, min_dist, rim_i, rim_j, near_i, near_j;
	int            ka, num_active, max_active;//, *active_list;
	int            bench;

	bench = ysize / 100;
	if (bench < 1) bench = 1;
	if (MaxCutLen < 2) MaxCutLen = 2;
	max_active = NumRes + 10;

	/* branch cuts */
	for (j = 0; j < ysize; j++)
	{
		for (i = 0; i < xsize; i++)
		{
			k = j * xsize + i;
			if ((bitflags[k] & (POS_RES | NEG_RES)) && !(bitflags[k] & VISITED))
			{
				bitflags[k] |= VISITED;  /* turn on visited flag */
				bitflags[k] |= ACTIVE;   /* turn on active flag */
				charge = (bitflags[k] & POS_RES) ? 1 : -1;
				num_active = 0;
				active_list[num_active++] = k;
				if (num_active > max_active) num_active = max_active;
				for (boxsize = 3; boxsize <= 2 * MaxCutLen; boxsize += 2)
				{
					bs2 = boxsize / 2;
					for (ka = 0; ka < num_active; ka++) {
						boxctr_i = active_list[ka] % xsize;
						boxctr_j = active_list[ka] / xsize;
						for (jj = boxctr_j - bs2; jj <= boxctr_j + bs2; jj++)
						{
							for (ii = boxctr_i - bs2; ii <= boxctr_i + bs2; ii++)
							{
								kk = jj * xsize + ii;
								if (ii < 0 || ii >= xsize || jj < 0 || jj >= ysize)
								{
									continue;
								}
								else {
									if (ii == 0 || ii == xsize - 1 || jj == 0 || jj == ysize - 1 || (bitflags[kk] & BORDER))
									{
										charge = 0;
										DistToBorder(bitflags, BORDER, boxctr_i,
											boxctr_j, &ri, &rj, xsize, ysize);
										PlaceCut(bitflags, ri, rj, boxctr_i, boxctr_j,
											xsize, ysize, branchcut_code);
									}
									else if ((bitflags[kk] & (POS_RES | NEG_RES)) && !(bitflags[kk] & ACTIVE))
									{
										if (!(bitflags[kk] & VISITED))
										{
											charge += (bitflags[kk] & POS_RES) ? 1 : -1;
											bitflags[kk] |= VISITED;   /* set flag */
										}
										active_list[num_active++] = kk;
										if (num_active > max_active)
											num_active = max_active;
										bitflags[kk] |= ACTIVE;  /* set active flag */
										PlaceCut(bitflags, ii, jj, boxctr_i, boxctr_j,
											xsize, ysize, branchcut_code);
									}
									if (charge == 0)
										goto continue_scan;
								}  /* else */
							}   /* for (ii ... */
						}   /* for (jj ... */
					}  /* for (ka ... */
				}   /* for (boxsize ... */	

				if (charge != 0)
				{   /* connect branch cuts to rim */
					min_dist = xsize + ysize;  /* large value */
					for (ka = 0; ka < num_active; ka++)
					{
						ii = active_list[ka] % xsize;
						jj = active_list[ka] / xsize;
						if ((dist = DistToBorder(bitflags, BORDER,
							ii, jj, &ri, &rj, xsize, ysize)) < min_dist)
						{
							min_dist = dist;
							near_i = ii;
							near_j = jj;
							rim_i = ri;
							rim_j = rj;
						}
					}
					PlaceCut(bitflags, near_i, near_j, rim_i, rim_j, xsize, ysize, branchcut_code);
				}
			continue_scan:
				/* mark all active pixels inactive */
				for (ka = 0; ka < num_active; ka++)
					bitflags[active_list[ka]] &= ~ACTIVE;  /* turn flag off */
			}  /* if (bitflags ... */
		}  /* for (i ... */
	}  /* for (j ... */
	return;
}


/* Returns 0 if no pixels left, 1 otherwise */
int CIpemunwrap::GetNextOneToUnwrap(int* a, int* b, int* index_list,
	int* num_index, int xsize, int /*ysize*/)
{
	int index;
	if (*num_index < 1)
		return 0;   /* return if list empty */
	index = index_list[*num_index - 1];
	*a = index % xsize;
	*b = index / xsize;
	--(*num_index);
	return 1;
}

/* Insert new pixel into the list.  */
/* Note: qual_map can be NULL       */
void CIpemunwrap::InsertList(float* soln, float val, float* qual_map,
	unsigned char* bitflags, int a, int b, int* index_list,
	int* num_index, int xsize, int /*ysize*/, int processed_code,
	int postponed_code, float* min_qual, int max_list_size)
{
	int i, n, index, top, bot, mid;
	float  quality;

	index = b * xsize + a;
	quality = (qual_map) ? qual_map[index] : 0.0;
	if (~(bitflags[index] & postponed_code))
	{
		/* if not postponed, store new unwrapped value */
		if (soln) soln[index] = val;
	}
	else
	{
		/* if postponed, leave old value */
	}
	/* if quality is too low, postpone it */
	if (qual_map && min_qual && quality < *min_qual)
	{
		bitflags[index] |= postponed_code;
		return;
	}
	/* otherwise, add to list */
	if (!qual_map)
	{   /* don't order if qual_map is NULL */
		index_list[*num_index] = index;
		++(*num_index);
	}
	else {
		/* insert in list in order from lowest to highest quality */
		n = *num_index;
		if (n < 1)
		{
			(*num_index) = 0;   /* will be incremented below */
			index_list[0] = index;
		}
		else
		{
			if (quality <= qual_map[index_list[0]])
			{
				/* insert at top of list */
				for (i = n; i > 0; i--)
					index_list[i] = index_list[i - 1];
				index_list[0] = index;
			}
			else if (quality > qual_map[index_list[n - 1]])
			{
				/* insert at bottom */
				index_list[n] = index;
			}
			else
			{   /* insert in middle */
				top = 0;
				bot = n - 1;
				while (bot - top > 1)
				{
					mid = (top + bot) / 2;
					if (quality <= qual_map[index_list[mid]])  bot = mid;
					else  top = mid;
				}
				for (i = n; i > top + 1; i--)
					index_list[i] = index_list[i - 1];
				index_list[top + 1] = index;
			}
		}
		++(*num_index);
	}
	bitflags[index] |= processed_code;
	bitflags[index] &= (~postponed_code);

	/* trim list if it's too big, and increase the quality */
	if (qual_map && min_qual
		&& max_list_size > 0 && *num_index >= max_list_size)
	{
		n = (*num_index) / 2;  /* discard 50% */
		for (i = 0; i < n; i++)
		{
			bitflags[index_list[i]] |= postponed_code;
			bitflags[index_list[i]] &= (~processed_code);
		}
		for (i = 0; i < *num_index - n; i++)
			index_list[i] = index_list[i + n];
		*num_index -= n;
		*min_qual = qual_map[index_list[0]];
	}
	return;
}

/* Insert the four neighboring pixels of the given pixel */
/* (x,y) into the list.  The quality value of the given  */
/* pixel is "val".                                       */
void CIpemunwrap::UpdateList(float* qual_map, int x, int y, float val,
	float* phase, float* soln, unsigned char* bitflags,
	int xsize, int ysize, int* index_list, int* num_index,
	int ignore_code, int processed_code, int postponed_code,
	int max_list_size, int dxdy_flag, float* min_qual)
{
	int    a, b, k, w;
	float  grad;
	a = x - 1;
	b = y;
	k = b * xsize + a;

	if (a >= 0
		&& !(bitflags[k] & (ignore_code | processed_code)))
	{
		w = y * xsize + x - 1;
		grad = Gradient(phase[w], phase[w + 1]);
		if (dxdy_flag && qual_map)
			qual_map[k] = -fabs(grad);
		InsertList(soln, val + grad, qual_map, bitflags, a, b,
			index_list, num_index, xsize, ysize, processed_code,
			postponed_code, min_qual, max_list_size);
	}

	a = x + 1;
	b = y;
	k = b * xsize + a;
	if (a < xsize
		&& !(bitflags[k] & (ignore_code | processed_code)))
	{
		w = y * xsize + x;
		grad = -Gradient(phase[w], phase[w + 1]);
		if (dxdy_flag && qual_map)
			qual_map[k] = -fabs(grad);
		InsertList(soln, val + grad, qual_map, bitflags, a, b,
			index_list, num_index, xsize, ysize, processed_code,
			postponed_code, min_qual, max_list_size);
	}

	a = x;
	b = y - 1;
	k = b * xsize + a;
	if (b >= 0
		&& !(bitflags[k] & (ignore_code | processed_code)))
	{
		w = (y - 1) * xsize + x;
		grad = Gradient(phase[w], phase[w + xsize]);
		if (dxdy_flag && qual_map)
			qual_map[k] = -fabs(grad);
		InsertList(soln, val + grad, qual_map, bitflags, a, b,
			index_list, num_index, xsize, ysize, processed_code,
			postponed_code, min_qual, max_list_size);
	}

	a = x;
	b = y + 1;
	k = b * xsize + a;
	if (b < ysize
		&& !(bitflags[k] & (ignore_code | processed_code)))
	{
		w = y * xsize + x;
		grad = -Gradient(phase[w], phase[w + xsize]);
		if (dxdy_flag && qual_map) qual_map[k] = -fabs(grad);
		InsertList(soln, val + grad, qual_map, bitflags, a, b,
			index_list, num_index, xsize, ysize, processed_code,
			postponed_code, min_qual, max_list_size);
	}
}

int CIpemunwrap::QualityGuidedPathFollower(float* phase, float* qual_map,
	unsigned char* bitflags, float* soln,
	int xsize, int ysize, int avoid_code)
{
	int  i, j, k, a, b, c, num_pieces = 0;
	float  value;
	float  min_qual, small_val = -1.0E+10;
	int    num_index, max_list_size, bench, benchout;
	//int    *index_list;
	int    postponed_code = POSTPONED, unwrapped_code = UNWRAPPED;

	bench = xsize * ysize / 100;
	if (bench < 1) bench = 1;
	benchout = 10 * bench;
	min_qual = small_val;
	max_list_size = (xsize + ysize);
	avoid_code |= unwrapped_code;
	/* find starting point */

	num_index = 0;
	for (j = 0; j < ysize; j++)
	{
		for (i = 0; i < xsize; i++)
		{
			k = j * xsize + i;
			if (!(bitflags[k] & avoid_code))
			{
				if (bitflags[k] & postponed_code)
					/* soln[k] already stores the unwrapped value */
					value = soln[k];
				else {
					++num_pieces;
					value = soln[k] = phase[k];
				}
				bitflags[k] |= unwrapped_code;
				bitflags[k] &= ~postponed_code;
				UpdateList(qual_map, i, j, value, phase, soln, bitflags,
					xsize, ysize, index_list, &num_index, avoid_code,
					unwrapped_code, postponed_code, max_list_size,
					true, &min_qual);
				while (num_index > 0)
				{

					if (!GetNextOneToUnwrap(&a, &b, index_list, &num_index,
						xsize, ysize)) break;   /* no more to unwrap */
					c = b * xsize + a;
					bitflags[c] |= unwrapped_code;
					bitflags[c] &= ~postponed_code;
					value = soln[c];
					UpdateList(qual_map, a, b, value, phase, soln, bitflags,
						xsize, ysize, index_list, &num_index, avoid_code,
						unwrapped_code, postponed_code, max_list_size,
						true, &min_qual);
					if (num_index <= 0)
					{
						min_qual = small_val;
						for (c = 0; c < xsize * ysize; c++)
						{
							if ((bitflags[c] & postponed_code)
								&& !(bitflags[c] & unwrapped_code))
							{
								a = c % xsize;
								b = c / xsize;
								InsertList(soln, soln[c], qual_map, bitflags, a, b,
									index_list, &num_index, xsize, ysize,
									unwrapped_code, postponed_code,
									&min_qual, max_list_size);
							}
						}
						if (num_index > 0) min_qual = qual_map[index_list[0]];
					}
				}  /* while ... */
			}
		}   /* for (b ...  */
	}   /* for (a ... */
	return num_pieces;
}

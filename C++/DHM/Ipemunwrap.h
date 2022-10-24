//////////////////////////////////////////////////////////////////////////
/*------------------------------------------------------------------------------
//Name：CIpemunwrap
//Description：A class for Phase Unwrapping
//Author：Zhenzhong
//Date: 2011-02-12
//CopyRight:
------------------------------------------------------------------------------*/

#include "IpemBase.h"
class CIpemunwrap :
	public CIpemBase
{
public:
	CIpemunwrap(void);
	~CIpemunwrap(void);
	void Unwrap_GoldStein(float *data);
	void Unwrap_QualityMap(float *data);
	void Unwrapping(float *data, int nType = 0);
private:
	float			*phase;     /* array */
	float			*soln;      /* array */
	float			*qual_map;  /* array */
	unsigned char	*bitflags;
	int				*index_list;
	int				*active_list;

	int				m_width;
	int				m_height;
	int				m_size;
	int				m_maxsize;

	int QualityGuidedPathFollower(float *phase, float *qual_map,
		unsigned char *bitflags, float *soln,
		int xsize, int ysize, int avoid_code);
	int GetNextOneToUnwrap(int *a, int *b, int *index_list,
		int *num_index, int xsize, int ysize);
	void InsertList(float *soln, float val, float *qual_map,
		unsigned char *bitflags, int a, int b, int *index_list,
		int *num_index, int xsize, int ysize, int processed_code,
		int postponed_code, float *min_qual, int max_list_size);
	void UpdateList(float *qual_map, int x, int y, float val,
		float *phase, float *soln, unsigned char *bitflags,
		int xsize, int ysize, int *index_list, int *num_index,
		int ignore_code, int processed_code, int postponed_code,
		int max_list_size, int dxdy_flag, float *min_qual);
	int Residues(float *phase, unsigned char *bitflags, int posres_code,
		int negres_code, int avoid_code, int xsize, int ysize);
	void GoldsteinBranchCuts(unsigned char *bitflags, int MaxCutLen,
		int NumRes, int xsize, int ysize, int branchcut_code);
	void PlaceCut(unsigned char *array, int a, int b, int c, int d,
		int xsize, int ysize, int code);
	int DistToBorder(unsigned char *bitflags, int border_code,
		int a, int b, int *ra, int *rb, int xsize, int ysize);
	int UnwrapAroundCuts(float *phase, unsigned char *bitflags,
		float *soln, int xsize, int ysize, int cut_code,
		int debug_flag, char *infile);

public:
	void Free(void);
	void SetSize(int nW, int nH);
};
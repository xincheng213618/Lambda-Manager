#include "pch.h"
#include "unwrap.h"
#include <csvd.h>
using namespace splab;
#include <matrixmath.h>
#include <opencv2\core\core.hpp>
using namespace cv;
using namespace std;

void circshift(Mat& out, const Point& delta)
{
	Size sz = out.size();

	// 错误检查
	assert(sz.height > 0 && sz.width > 0);
	// 此种情况不需要移动
	if ((sz.height == 1 && sz.width == 1) || (delta.x == 0 && delta.y == 0))
		return;

	// 需要移动参数的变换，这样就能输入各种整数了
	int x = delta.x;
	int y = delta.y;
	
	if (x > 0){ 
		x = x % sz.width;
	}
	else {
		x = x % sz.width + sz.width;
	}
	if (y > 0) {
		y = y % sz.height;
	}
	else {
		y = y % sz.height + sz.height;
	}


	// 多维的Mat也能移动
	vector<Mat> planes;
	split(out, planes);

	int size = planes.size();
	Mat tmp0, tmp1, tmp2, tmp3;

	for (size_t i = 0; i < size; i++)
	{
		// 竖直方向移动
		Mat q0(planes[i], Rect(0, 0, sz.width, sz.height - y));
		Mat q1(planes[i], Rect(0, sz.height - y, sz.width, y));
		q0.copyTo(tmp0);
		q1.copyTo(tmp1);
		tmp0.copyTo(planes[i](Rect(0, y, sz.width, sz.height - y)));
		tmp1.copyTo(planes[i](Rect(0, 0, sz.width, y)));

		// 水平方向移动
		Mat q2(planes[i], Rect(0, 0, sz.width - x, sz.height));
		Mat q3(planes[i], Rect(sz.width - x, 0, x, sz.height));
		q2.copyTo(tmp2);
		q3.copyTo(tmp3);

		tmp2.copyTo(planes[i](Rect(x, 0, sz.width - x, sz.height)));
		tmp3.copyTo(planes[i](Rect(0, 0, x, sz.height)));
	}

	merge(planes, out);
}

void fftshift(Mat& out)
{
	Size sz = out.size();
	Point pt((int)floor(sz.width / 2.0), (int)floor(sz.height / 2.0));
	circshift(out, pt);
}
void ifftshift(Mat& out)
{
	Size sz = out.size();
	Point pt((int)ceil(sz.width / 2.0), (int)ceil(sz.height / 2.0));
	circshift(out, pt);
}




void fft2(InputArray src, OutputArray _dst, OutputArray _dstm)
{
	//得到Mat类型
	Mat InputImage = src.getMat();

	Mat padded;                            //expand input image to optimal size
	int m = getOptimalDFTSize(InputImage.rows);
	int n = getOptimalDFTSize(InputImage.cols); // on the border add zero values
	copyMakeBorder(InputImage, padded, 0, m - InputImage.rows, 0, n - InputImage.cols, BORDER_CONSTANT, Scalar::all(0));
	Mat planes[] = { Mat_<float>(padded), Mat::zeros(padded.size(), CV_32F) };
	Mat complexI;
	merge(planes, 2, complexI);         // Add to the expanded another plane with zeros
	dft(complexI, complexI);            // this way the result may fit in the source matrix
	// compute the magnitude and switch to logarithmic scale
	// => log(1 + sqrt(Re(DFT(I))^2 + Im(DFT(I))^2))
	split(complexI, planes);                   // planes[0] = Re(DFT(I), planes[1] = Im(DFT(I))
	magnitude(planes[0], planes[1], planes[0]);// planes[0] = magnitude
	Mat magI = planes[0];
	magI += Scalar::all(1);                    // switch to logarithmic scale
	log(magI, magI);
	// crop the spectrum, if it has an odd number of rows or columns
	magI = magI(Rect(0, 0, magI.cols & -2, magI.rows & -2));
	// rearrange the quadrants of Fourier image  so that the origin is at the image center
	int cx = magI.cols / 2;
	int cy = magI.rows / 2;
	Mat q0(magI, Rect(0, 0, cx, cy));   // Top-Left - Create a ROI per quadrant
	Mat q1(magI, Rect(cx, 0, cx, cy));  // Top-Right
	Mat q2(magI, Rect(0, cy, cx, cy));  // Bottom-Left
	Mat q3(magI, Rect(cx, cy, cx, cy)); // Bottom-Right
	Mat tmp;                           // swap quadrants (Top-Left with Bottom-Right)
	q0.copyTo(tmp);
	q3.copyTo(q0);
	tmp.copyTo(q3);
	q1.copyTo(tmp);                    // swap quadrant (Top-Right with Bottom-Left)
	q2.copyTo(q1);
	tmp.copyTo(q2);

	complexI.copyTo(_dst);
	magI.copyTo(_dstm);
}

void DIC_matcalculate(Mat& MatPha, Mat& DIC_mat, float rotation, float distance)
{
	int xishu = 2 * (int)distance + 5;
	//cv::GaussianBlur(MatPha, MatPha, Size(xishu, xishu), 0);
	int w = MatPha.size().width, h = MatPha.size().height;
	Mat phasehang = cv::Mat::zeros(cv::Size(w, h + xishu), CV_32FC1);
	Mat phaselie = cv::Mat::zeros(cv::Size(w + xishu, h), CV_32FC1);
	Mat delt_phasehang = cv::Mat::zeros(cv::Size(w, h + xishu), CV_32FC1);
	Mat delt_phaselie = cv::Mat::zeros(cv::Size(w + xishu, h), CV_32FC1);
	MatPha(Rect(0, 0, w, h)).copyTo(phaselie(Rect(xishu, 0, w, h)));
	MatPha(Rect(0, 0, w, h)).copyTo(phasehang(Rect(0, xishu, w, h)));
	Mat phasehang1; Mat Matpha1;
	phasehang1 = phasehang(Rect(0, 0, w, h));
	Matpha1 = MatPha(Rect(0, 0, w, h));
	delt_phasehang = phasehang1 - Matpha1;
	Mat phaselie1 = phaselie(Rect(0, 0, w, h));
	delt_phaselie = phaselie1 - Matpha1;
	delt_phaselie(Rect(0, 0, xishu, h)) = 0;
	delt_phasehang(Rect(0, 0, w, xishu)) = 0;

	Mat DIC_PHASE = cv::Mat(h, w, CV_32FC1);
	DIC_PHASE = cos(rotation)*delt_phaselie + sin(rotation)*delt_phasehang;
	normalize(DIC_PHASE, DIC_PHASE, 0, 255, NORM_MINMAX);
	DIC_PHASE.convertTo(DIC_mat, CV_8UC1);
}

void AutoSpectrumSelection(InputArray input_f, InputArray input_m, OutputArray output, float NA, float pixelsize, float Ma, float lamda)
{

	float m, n;
	Mat input = Mat::zeros(input_f.size(), CV_32F);
	input_f.copyTo(input);
	Mat srcImage = Mat::zeros(input_m.size(), CV_32F);
	input_m.copyTo(srcImage);
	n = (NA * 2 * pixelsize*srcImage.cols) / (lamda*Ma);
	m = (NA * 2 * pixelsize*srcImage.rows) / (lamda*Ma);

	//振幅图剔除0级谱

	for (int i = srcImage.rows / 2 - m / 2; i < srcImage.rows / 2 + m / 2; i++)
	{
		for (int j = srcImage.cols / 2 - n / 2; j < srcImage.cols / 2 + n / 2; j++)
		{
			srcImage.at<float>(i, j) = 0;
		}
	}

	vector<vector<float>> v(4, vector<float>(3, 0));

	for (int i = 0; i < srcImage.rows / 2; i++)
	{
		for (int j = 0; j < srcImage.cols / 2; j++)
		{
			if (srcImage.at<float>(i, j) > v[0][0]) {
				v[0][0] = srcImage.at<float>(i, j);
				v[0][1] = i;
				v[0][2] = j;
			}
		}
	}

	for (int i = 0; i < srcImage.rows / 2; i++)
	{
		for (int j = srcImage.cols / 2; j < srcImage.cols; j++)
		{
			if (srcImage.at<float>(i, j) > v[1][0]) {
				v[1][0] = srcImage.at<float>(i, j);
				v[1][1] = i;
				v[1][2] = j;
			}
		}
	}

	for (int i = srcImage.rows / 2; i < srcImage.rows; i++)
	{
		for (int j = 0; j < srcImage.cols / 2; j++)
		{
			if (srcImage.at<float>(i, j) > v[2][0]) {
				v[2][0] = srcImage.at<float>(i, j);
				v[2][1] = i;
				v[2][2] = j;
			}
		}
	}

	for (int i = srcImage.rows / 2; i < srcImage.rows; i++)
	{
		for (int j = srcImage.cols / 2; j < srcImage.cols; j++)
		{
			if (srcImage.at<float>(i, j) > v[3][0]) {
				v[3][0] = srcImage.at<float>(i, j);
				v[3][1] = i;
				v[3][2] = j;
			}
		}
	}
	sort(v.begin(), v.end(), [](vector<float>& a, vector<float>& b) {
		return a[0] > b[0];
	});
	int maxrow = v[0][1], maxcol = v[0][2], maxrow2 = v[1][1], maxcol2 = v[1][2];

	Mat R0, I0;
	Mat planes[] = { Mat::zeros(input.size(), CV_32F), Mat::zeros(input.size(), CV_32F) };
	split(input, planes);
	planes[0].copyTo(R0);
	planes[1].copyTo(I0);
	float imag;
	//imag = planes[1].at<float>(maxcol, maxrow);
	imag = planes[1].at<float>(maxrow, maxcol);
	int i, j;
	if (imag < 0.0)
	{
		i = maxrow;
		j = maxcol;
	}
	else {
		i = maxrow2;
		j = maxcol2;
	}

	Mat out = input(Rect(Point(j - n / 2, i - m / 2), Point(j + n / 2, i + m / 2)));
	out.copyTo(output);

}


void AutoSpectrumSelection(InputArray input_f, InputArray input_m, int& x1, int& y1, int& nh, int& nw)
{
	float m, n;
	n = 2 * nw / 3;
	m = 2 * nh / 3;
	Mat input = Mat::zeros(input_f.size(), CV_32F);
	input_f.copyTo(input);
	Mat srcImage = Mat::zeros(input_m.size(), CV_32F);
	input_m.copyTo(srcImage);

	//振幅图剔除0级谱
	for (int i = srcImage.rows / 2 - m / 2; i < srcImage.rows / 2 + m / 2; i++)
	{
		for (int j = srcImage.cols / 2 - n / 2; j < srcImage.cols / 2 + n / 2; j++)
		{
			srcImage.at<float>(i, j) = 0;
		}
	}

	vector<vector<float>> v(4, vector<float>(3, 0));

	for (int i = 0; i < srcImage.rows / 2; i++)
	{
		for (int j = 0; j < srcImage.cols / 2; j++)
		{
			if (srcImage.at<float>(i, j) > v[0][0]) {
				v[0][0] = srcImage.at<float>(i, j);
				v[0][1] = i;
				v[0][2] = j;
			}
		}
	}

	for (int i = 0; i < srcImage.rows / 2; i++)
	{
		for (int j = srcImage.cols / 2; j < srcImage.cols; j++)
		{
			if (srcImage.at<float>(i, j) > v[1][0]) {
				v[1][0] = srcImage.at<float>(i, j);
				v[1][1] = i;
				v[1][2] = j;
			}
		}
	}

	for (int i = srcImage.rows / 2; i < srcImage.rows; i++)
	{
		for (int j = 0; j < srcImage.cols / 2; j++)
		{
			if (srcImage.at<float>(i, j) > v[2][0]) {
				v[2][0] = srcImage.at<float>(i, j);
				v[2][1] = i;
				v[2][2] = j;
			}
		}
	}

	for (int i = srcImage.rows / 2; i < srcImage.rows; i++)
	{
		for (int j = srcImage.cols / 2; j < srcImage.cols; j++)
		{
			if (srcImage.at<float>(i, j) > v[3][0]) {
				v[3][0] = srcImage.at<float>(i, j);
				v[3][1] = i;
				v[3][2] = j;
			}
		}
	}
	sort(v.begin(), v.end(), [](vector<float>& a, vector<float>& b) {
		return a[0] > b[0];
		});
	int maxrow = v[0][1], maxcol = v[0][2], maxrow2 = v[1][1], maxcol2 = v[1][2];

	Mat R0, I0;
	Mat planes[] = { Mat::zeros(input.size(), CV_32F), Mat::zeros(input.size(), CV_32F) };
	split(input, planes);
	planes[0].copyTo(R0);
	planes[1].copyTo(I0);
	float imag;
	//imag = planes[1].at<float>(maxcol, maxrow);
	imag = planes[1].at<float>(maxrow, maxcol);
	int i, j;
	if (imag < 0.0)
	{
		i = maxrow;
		j = maxcol;
	}
	else {
		i = maxrow2;
		j = maxcol2;
	}

	x1 = j - (int)(nh / 2);
	y1 = i - (int)(nw / 2);
}

void Rection(InputArray input_f, InputArray input_m, int x1, int y1, int nw, int nh, Mat& output, Mat& am)
{
	Mat input = Mat::zeros(input_f.size(), CV_32F);
	input_f.copyTo(input);
	Mat srcImage = Mat::zeros(input_m.size(), CV_32F);
	input_m.copyTo(srcImage);
	input(Rect(x1, y1, nw, nh)).copyTo(output);
	srcImage(Rect(x1, y1, nw, nh)).copyTo(am);
}



void abslog(InputArray _src, OutputArray _dst)
{
	//得到Mat类型
	Mat src = _src.getMat();

	Mat planes[] = { Mat_<float>(src), Mat::zeros(src.size(),CV_32F) };
	split(src, planes);  //planes[0] = Re(DFT(I)）,planes[1] = Im(DFT(I))
	Mat magI;
	magnitude(planes[0], planes[1], magI);  //planes[0] = magnitude	

	//进行对数尺寸缩放，用对数尺度替换线型尺度M1=log（M+1）
	magI += Scalar::all(1);
	log(magI, magI);

	//如果有奇数行或列，则对频谱进行裁剪
	magI = magI(Rect(0, 0, magI.cols & -2, magI.rows & -2));

	Mat fft2DH;
	normalize(magI, fft2DH, 0, 255, NORM_MINMAX);
	fft2DH.convertTo(fft2DH, CV_8UC1, 255, 0);

	fft2DH.copyTo(_dst);
}



void ifft2(InputArray _src, OutputArray _dst)
{
	Mat src = _src.getMat();

	Mat ifft;
	idft(src, ifft);

	ifft.copyTo(_dst);
}

void phi_angle(InputArray _src, OutputArray _dst)
{
	Mat src = _src.getMat();

	Mat p[] = { Mat::zeros(src.size(),CV_32F),Mat::zeros(src.size(),CV_32F) }, angle;
	split(src, p);
	phase(p[0], p[1], angle);

	//normalize(phi_sam, phi_sam, 0, 1, NORM_MINMAX);
	//phi_sam.convertTo(phi_sam, CV_8UC1, 255, 0);

	angle.copyTo(_dst);




	//Mat planes[] = { Mat_<float>(src), Mat::zeros(src.size(),CV_32F) };
	//Mat p[] = { Mat::zeros(planes[0].size(),CV_32F),Mat::zeros(planes[0].size(),CV_32F) }, phi_sam;
	//split(src, p);
	//phase(p[0], p[1], phi_sam);
	////normalize(phi_sam, phi_sam, 0, 1, NORM_MINMAX);
	////phi_sam.convertTo(phi_sam, CV_8UC1, 255, 0);

	//phi_sam.copyTo(_dst);
}

void Inten(InputArray _src, OutputArray _dst)
{
	Mat src = _src.getMat();

	Mat planes[] = { Mat_<float>(src), Mat::zeros(src.size(),CV_32F) };
	Mat p[] = { Mat::zeros(planes[0].size(),CV_32F),Mat::zeros(planes[0].size(),CV_32F) }, inten_sam;
	split(src, p);
	magnitude(p[0], p[1], inten_sam);

	inten_sam.copyTo(_dst);
}

void get_exp(InputArray _src, OutputArray _dst)
{
	Mat src = _src.getMat();

	splab::Matrix<float> DH_phi(src.rows, src.cols);
	splab::Matrix<complex<float>> E(src.rows, src.cols);
	splab::Matrix<float> psin(src.rows, src.cols), pcos(src.rows, src.cols);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			DH_phi[i][j] = src.at<float>(i, j);
	psin = sin(DH_phi); pcos = cos(DH_phi);
	E = splab::complexMatrix(pcos, psin);
	Mat EE(src.rows, src.cols, CV_32FC2, E);

	EE.copyTo(_dst);
}

Mat polyfit(std::vector<cv::Point2f>& chain, int n)
{
	Mat y(chain.size(), 1, CV_32F, Scalar::all(0));
	/* ********【预声明phy超定矩阵】************************/
	/* 多项式拟合的函数为多项幂函数
	* f(x)=a0+a1*x+a2*x^2+a3*x^3+......+an*x^n
	*a0、a1、a2......an是幂系数，也是拟合所求的未知量。设有m个抽样点，则：
	* 超定矩阵phy=1 x1 x1^2 ... ...  x1^n
	*           1 x2 x2^2 ... ...  x2^n
	*           1 x3 x3^2 ... ...  x3^n
	*              ... ... ... ...
	*              ... ... ... ...
	*           1 xm xm^2 ... ...  xm^n
	*
	* *************************************************/
	cv::Mat phy(chain.size(), n, CV_32F, Scalar::all(0));
	for (int i = 0; i < phy.rows; i++)
	{
		float* pr = phy.ptr<float>(i);
		for (int j = 0; j < phy.cols; j++)
		{
			pr[j] = pow(chain[i].x, j);
		}
		y.at<float>(i) = chain[i].y;
	}
	Mat phy_t = phy.t();
	Mat phyMULphy_t = phy.t() * phy;
	Mat phyMphyInv = phyMULphy_t.inv();
	Mat a = phyMphyInv * phy_t;
	a = a * y;
	return a;
}

void E_SVD(InputArray _src, OutputArray _dst)
{
	Mat src = _src.getMat();
	Mat planes[] = { Mat_<float>(src), Mat::zeros(src.size(),CV_32F) };
	Mat p[] = { Mat::zeros(planes[0].size(),CV_32F),Mat::zeros(planes[0].size(),CV_32F) }, phi_sam;
	split(src, p);
	splab::Matrix<float> re(src.rows, src.cols), im(src.rows, src.cols);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			re[i][j] = p[0].at<float>(i, j);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			im[i][j] = p[1].at<float>(i, j);
	splab::Matrix<complex<float>> E = splab::complexMatrix(re, im);

	//SVD
	CSVD<float> svd;
	svd.dec(E);
	splab::Matrix< complex<float> > U = svd.getU(), V = svd.getV();
	splab::Matrix<float> S = svd.getSM();
	splab::Matrix< complex<float> > CS = splab::complexMatrix(S);
	Mat Umat(src.rows, src.rows, CV_32FC2, U), Vmat(src.cols, src.rows, CV_32FC2, V), Smat(src.rows, src.rows, CV_32FC1, S);


	float k = 0;
	splab::Matrix< complex<float> > SS(src.rows, src.rows, k);
	SS[0][0] = CS[0][0];

	Mat U1 = Umat.colRange(0, 1).clone(), phi_U, Ud;
	Mat V1 = Vmat.colRange(0, 1).clone(), phi_V, Vd;
	phi_angle(U1, phi_U);
	phi_angle(V1, phi_V);
	Ud = phi_U(Rect(0, 1, 1, U1.rows - 1)) - phi_U(Rect(0, 0, 1, U1.rows - 1));
	Vd = phi_V(Rect(0, 1, 1, V1.rows - 1)) - phi_V(Rect(0, 0, 1, V1.rows - 1));
	for (int i = 0; i < phi_U.rows - 1; i++)
	{
		if ((Ud.at<float>(i)) > PI)
			Ud.at<float>(i) = Ud.at<float>(i) - 2 * PI;
		if ((Ud.at<float>(i)) < -PI)
			Ud.at<float>(i) = Ud.at<float>(i) + 2 * PI;
		phi_U.at<float>(i + 1) = phi_U.at<float>(i) + Ud.at<float>(i);
	}
	for (int i = 0; i < phi_V.rows - 1; i++)
	{
		if ((Vd.at<float>(i)) > PI)
			Vd.at<float>(i) = Vd.at<float>(i) - 2 * PI;
		if ((Vd.at<float>(i)) < -PI)
			Vd.at<float>(i) = Vd.at<float>(i) + 2 * PI;
		phi_V.at<float>(i + 1) = phi_V.at<float>(i) + Vd.at<float>(i);
	}

	//Least-squares fit
	Mat yU, yV;
	vector<Point2f> U_unwrap, V_unwrap;
	for (int i = 0; i < phi_U.rows; i++)
	{
		Point2f u;
		u.x = i;
		u.y = phi_U.at<float>(i, 0);
		U_unwrap.push_back(u);
	}
	for (int i = 0; i < phi_V.rows; i++)
	{
		Point2f v;
		v.x = i;
		v.y = phi_V.at<float>(i, 0);
		V_unwrap.push_back(v);
	}
	yU = polyfit(U_unwrap, 3); yV = polyfit(V_unwrap, 3);
	float a, b, c, d, e, f;
	a = yU.at<float>(2, 0); b = yU.at<float>(1, 0); c = yU.at<float>(0, 0);
	d = yV.at<float>(2, 0); e = yV.at<float>(1, 0); f = yV.at<float>(0, 0);
	Mat y_U = Mat::zeros(phi_U.rows, 1, CV_32FC1), E_U;
	Mat y_V = Mat::zeros(phi_V.rows, 1, CV_32FC1), E_V;
	for (int i = 0; i < phi_U.rows; i++)
	{
		y_U.at<float>(i, 0) = a * i * i + b * i + c;
	}
	for (int i = 0; i < phi_V.rows; i++)
	{
		y_V.at<float>(i, 0) = d * i * i + e * i + f;
	}

	get_exp(y_U, E_U);
	get_exp(y_V, E_V);
	for (int i = 0; i < E_U.rows; i++)
	{
		Umat.at<Vec2f>(i, 0)[0] = E_U.at<Vec2f>(i, 0)[0];
		Umat.at<Vec2f>(i, 0)[1] = E_U.at<Vec2f>(i, 0)[1];
	}
	for (int i = 0; i < E_V.rows; i++)
	{
		Vmat.at<Vec2f>(i, 0)[0] = E_V.at<Vec2f>(i, 0)[0];
		Vmat.at<Vec2f>(i, 0)[1] = E_V.at<Vec2f>(i, 0)[1];
	}

	splab::Matrix< complex <float> > UU(E_U.rows, E_U.cols), VV(E_V.rows, E_V.cols);
	for (int i = 0; i < E_U.rows; i++)
		for (int j = 0; j < E_U.cols; j++)
			UU[i][j] = E_U.at<float>(i, j);
	for (int i = 0; i < E_V.rows; i++)
		for (int j = 0; j < E_V.cols; j++)
			VV[i][j] = E_V.at<float>(i, j);
	splab::Matrix< complex <float> > Bx(src.cols, src.rows);
	splab::Matrix< complex <float> > s11(1, 1);
	splab::Matrix<float> B1x(src.cols, src.rows);
	s11[0][0] = CS[0][0];
	Bx = UU * s11 * splab::trT(VV);
	Mat B_x(src.rows, src.cols, CV_32FC2, Bx);
	B1x = splab::arg(Bx);
	Mat B_1x(src.rows, src.cols, CV_32FC1, B1x);
	Mat result = Mat::zeros(src.rows, src.cols, CV_32FC1);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			result.at<float>(i, j) = B1x[i][j] + PI;
	//
	splab::Matrix< complex<float> > EA = U * SS * splab::trH(V);
	splab::Matrix< complex<float> > Econj = splab::trH(EA); Econj = splab::trT(Econj);

	//splab::Matrix<float> Aberration = arg(EA);
	//Mat E_A(src.rows, src.cols, CV_32FC2, EA);
	Mat E_conj(src.rows, src.cols, CV_32FC2, Econj);

	E_conj.copyTo(_dst);
}

void E_SVD(InputArray _src, InputArray _src2, OutputArray _dst, float c1, float c2)
{
	Mat src = _src.getMat();
	Mat src2 = _src2.getMat();
	Mat planes[] = { Mat_<float>(src), Mat::zeros(src.size(),CV_32F) };
	Mat p[] = { Mat::zeros(planes[0].size(),CV_32F),Mat::zeros(planes[0].size(),CV_32F) }, phi_sam;
	split(src, p);
	splab::Matrix<float> re(src.rows, src.cols), im(src.rows, src.cols);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			re[i][j] = p[0].at<float>(i, j);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			im[i][j] = p[1].at<float>(i, j);
	splab::Matrix<complex<float>> E = splab::complexMatrix(re, im);

	//SVD
	CSVD<float> svd;
	svd.dec(E);
	splab::Matrix< complex<float> > U = svd.getU(), V = svd.getV();
	splab::Matrix<float> S = svd.getSM();
	splab::Matrix< complex<float> > CS = splab::complexMatrix(S);
	Mat Umat(src.rows, src.rows, CV_32FC2, U), Vmat(src.cols, src.rows, CV_32FC2, V), Smat(src.rows, src.rows, CV_32FC1, S);

	float k = 0;
	splab::Matrix< complex<float> > SS(1, 1);
	SS[0][0] = CS[0][0];

	Mat U1 = Umat.colRange(0, 1).clone(), phi_U, Ud;
	Mat V1 = Vmat.colRange(0, 1).clone(), phi_V, Vd;
	phi_angle(U1, phi_U);
	phi_angle(V1, phi_V);
	Ud = phi_U(Rect(0, 1, 1, U1.rows - 1)) - phi_U(Rect(0, 0, 1, U1.rows - 1));
	Vd = phi_V(Rect(0, 1, 1, V1.rows - 1)) - phi_V(Rect(0, 0, 1, V1.rows - 1));
	for (int i = 0; i < phi_U.rows - 1; i++)
	{
		if ((Ud.at<float>(i)) > PI)
			Ud.at<float>(i) = Ud.at<float>(i) - 2 * PI;
		if ((Ud.at<float>(i)) < -PI)
			Ud.at<float>(i) = Ud.at<float>(i) + 2 * PI;
		phi_U.at<float>(i + 1) = phi_U.at<float>(i) + Ud.at<float>(i);
	}
	for (int i = 0; i < phi_V.rows - 1; i++)
	{
		if ((Vd.at<float>(i)) > PI)
			Vd.at<float>(i) = Vd.at<float>(i) - 2 * PI;
		if ((Vd.at<float>(i)) < -PI)
			Vd.at<float>(i) = Vd.at<float>(i) + 2 * PI;
		phi_V.at<float>(i + 1) = phi_V.at<float>(i) + Vd.at<float>(i);
	}

	//Least-squares fit
	Mat yU, yV;
	vector<Point2f> U_unwrap, V_unwrap;
	for (int i = 0; i < phi_U.rows; i++)
	{
		Point2f u;
		u.x = i;
		u.y = phi_U.at<float>(i, 0);
		U_unwrap.push_back(u);
	}
	for (int i = 0; i < phi_V.rows; i++)
	{
		Point2f v;
		v.x = i;
		v.y = phi_V.at<float>(i, 0);
		V_unwrap.push_back(v);
	}
	yU = polyfit(U_unwrap, 3); yV = polyfit(V_unwrap, 3);
	float a, b, c, d, e, f;
	a = yU.at<float>(2, 0); b = yU.at<float>(1, 0); c = yU.at<float>(0, 0);
	d = yV.at<float>(2, 0); e = yV.at<float>(1, 0); f = yV.at<float>(0, 0);
	Mat y_U = Mat::zeros(src2.rows, 1, CV_32FC1), E_U;
	Mat y_V = Mat::zeros(src2.cols, 1, CV_32FC1), E_V;
	for (int i = 0; i < src2.rows; i++)
	{
		y_U.at<float>(i, 0) = a * c1 * c1 * i * i + b * c1 * i + c;
	}
	for (int i = 0; i < src2.cols; i++)
	{
		y_V.at<float>(i, 0) = d * c2 * c2 * i * i + e * c2 * i + f;
	}

	Mat phase_u1x, phase_v1x, phase_u2x, phase_v2x;
	splab::Matrix<float> u1Rx(src2.rows, 1), v1Rx(src2.cols, 1), u1Ix(src2.rows, 1), v1Ix(src2.cols, 1), B1x(src2.rows, src2.cols);
	splab::Matrix< complex<float> > u11x(src2.rows, 1), v11x(src2.cols, 1), Bx(src2.rows, src2.cols);
	Cos(y_U, phase_u1x);
	Sin(y_U, phase_u2x);
	Cos(y_V, phase_v1x);
	Sin(-y_V, phase_v2x);
	for (int i = 0; i < src2.rows; i++)
	{
		u1Rx[i][0] = phase_u1x.at<float>(i, 0);
		u1Ix[i][0] = phase_u2x.at<float>(i, 0);
	}
	u11x = splab::complexMatrix(u1Rx, u1Ix);
	for (int j = 0; j < src2.cols; j++)
	{
		v1Rx[j][0] = phase_v1x.at<float>(j, 0);
		v1Ix[j][0] = phase_v2x.at<float>(j, 0);
	}
	v11x = splab::complexMatrix(v1Rx, v1Ix);
	Bx = u11x * SS * splab::trT(v11x);
	/*B1x = splab::arg(Bx);*/
	splab::Matrix< complex<float> > Econj = splab::trH(Bx); Econj = splab::trT(Econj);
	Mat E_conj(src2.rows, src2.cols, CV_32FC2, Econj);

	E_conj.copyTo(_dst);
}

void Multiple(InputArray _src1, InputArray _src2, OutputArray _dst)
{
	Mat src1 = _src1.getMat();
	Mat src2 = _src2.getMat();

	splab::Matrix<float> re1(src1.rows, src1.cols), im1(src1.rows, src1.cols);
	for (int i = 0; i < src1.rows; i++)
		for (int j = 0; j < src1.cols; j++)
			re1[i][j] = src1.at<Vec2f>(i, j)[0];
	for (int i = 0; i < src1.rows; i++)
		for (int j = 0; j < src1.cols; j++)
			im1[i][j] = src1.at<Vec2f>(i, j)[1];
	splab::Matrix<complex<float>> ifft = splab::complexMatrix(re1, im1);

	splab::Matrix<float> re2(src2.rows, src2.cols), im2(src2.rows, src2.cols);
	for (int i = 0; i < src2.rows; i++)
		for (int j = 0; j < src1.cols; j++)
			re2[i][j] = src2.at<Vec2f>(i, j)[0];
	for (int i = 0; i < src2.rows; i++)
		for (int j = 0; j < src2.cols; j++)
			im2[i][j] = src2.at<Vec2f>(i, j)[1];
	splab::Matrix<complex<float>> Econj = splab::complexMatrix(re2, im2);

	splab::Matrix<complex<float>> Mul = ifft *= Econj;
	Mat Multiple(src1.rows, src1.cols, CV_32FC2, Mul);

	Multiple.copyTo(_dst);
}

void phase_PCA(Mat& I_src1, Mat& I_src2, Mat& I_dst1, Mat& I_dst2, Mat& I_dst3)
{
	Mat E, E_conj;
	get_exp(I_src2, E);
	E_SVD(E, E_conj);
	Multiple(I_src1, E_conj, I_dst3);
	phi_angle(I_dst3, I_dst1);
	Inten(I_dst3, I_dst2);
}




//RG
//pixel information
struct PIXEL
{
	//int x;					//x coordinate of the pixel
	//int y;					//y coordinate
	int increment;			//No. of 2*pi to add to the pixel to unwrap it
	int number_of_pixels_in_group;	//No. of pixels in the pixel group
	float value;			//value of the pixel
	float reliability;
	int group;				//group No.
	int new_group;
	struct PIXEL* head;		//pointer to the first pixel in the group in the linked list
	struct PIXEL* last;		//pointer to the last pixel in the group
	struct PIXEL* next;		//pointer to the next pixel in the group
};

//the EDGE is the line that connects two pixels.
//if we have S PIXELs, then we have S horizental edges and S vertical edges
struct EDGE
{
	float reliab;			//reliabilty of the edge and it depends on the two pixels
	PIXEL* pointer_1;		//pointer to the first pixel
	PIXEL* pointer_2;		//pointer to the second pixel
	int increment;			//No. of 2*pi to add to one of the pixels to unwrap it with respect to the second 
};

//another version of Mixtogether but this function should only be use with the sort program
void  Mix(EDGE* Pointer1, int* index1, int* index2, int size)
{
	int counter1 = 0;
	int counter2 = 0;
	int* TemporalPointer = index1;

	int* Result = (int*)calloc(size * 2, sizeof(int));
	int* Follower = Result;

	while ((counter1 < size) && (counter2 < size))
	{
		if ((Pointer1[*(index1 + counter1)].reliab <= Pointer1[*(index2 + counter2)].reliab))
		{
			*Follower = *(index1 + counter1);
			Follower++;
			counter1++;
		}
		else
		{
			*Follower = *(index2 + counter2);
			Follower++;
			counter2++;
		}
	}//while

	if (counter1 == size)
	{
		memcpy(Follower, (index2 + counter2), sizeof(int) * (size - counter2));
	}
	else
	{
		memcpy(Follower, (index1 + counter1), sizeof(int) * (size - counter1));
	}

	Follower = Result;
	index1 = TemporalPointer;

	int i;
	for (i = 0; i < 2 * size; i++)
	{
		*index1 = *Follower;
		index1++;
		Follower++;
	}

	free(Result);
}

//this is may be the fastest sort program; 
//see the explination in quickSort function below
void  sort(EDGE* Pointer, int* index, int size)
{
	if (size == 2)
	{
		if ((Pointer[*index].reliab) > (Pointer[*(index + 1)].reliab))
		{
			int Temp;
			Temp = *index;
			*index = *(index + 1);
			*(index + 1) = Temp;
		}
	}
	else if (size > 2)
	{
		sort(Pointer, index, size / 2);
		sort(Pointer, (index + (size / 2)), size / 2);
		Mix(Pointer, index, (index + (size / 2)), size / 2);
	}
}

//this function tries to implement a nice idea explained below
//we need to sort edge array. Each edge element conisists of 16 bytes.
//In normal sort program we compare two elements in the array and exchange
//their place under some conditions to do the sorting. It is very probable
// that an edge element may change its place hundred of times which makes 
//the sorting a very time consuming operation. The idea in this function 
//is to give each edge element an index and move the index not the edge
//element. The edge need 4 bytes which makes the sorting operation faster.
// After finishingthe sorting of the indexes, we know the position of each index. 
//So we know how to sort edges
void quick_sort(EDGE* Pointer, int size)
{
	int* index = (int*)calloc(size, sizeof(int));
	int i;

	for (i = 0; i < size; ++i)
		index[i] = i;

	sort(Pointer, index, size);

	EDGE* a = (EDGE*)calloc(size, sizeof(EDGE));
	for (i = 0; i < size; ++i)
		a[i] = Pointer[*(index + i)];

	memcpy(Pointer, a, size * sizeof(EDGE));

	free(index);
	free(a);
}

//---------------start quicker_sort algorithm --------------------------------
#define swap(x,y) {EDGE t; t=x; x=y; y=t;}
#define order(x,y) if (x.reliab > y.reliab) swap(x,y)
#define o2(x,y) order(x,y)
#define o3(x,y,z) o2(x,y); o2(x,z); o2(y,z)

typedef enum { yes, no } yes_no;

yes_no find_pivot(EDGE* left, EDGE* right, float* pivot_ptr)
{
	EDGE a, b, c, *p;

	a = *left;
	b = *(left + (right - left) / 2);
	c = *right;
	o3(a, b, c);

	if (a.reliab < b.reliab)
	{
		*pivot_ptr = b.reliab;
		return yes;
	}

	if (b.reliab < c.reliab)
	{
		*pivot_ptr = c.reliab;
		return yes;
	}

	for (p = left + 1; p <= right; ++p)
	{
		if (p->reliab != left->reliab)
		{
			*pivot_ptr = (p->reliab < left->reliab) ? left->reliab : p->reliab;
			return yes;
		}
		return no;
	}
}

EDGE* partition(EDGE* left, EDGE* right, float pivot)
{
	while (left <= right)
	{
		while (left->reliab < pivot)
			++left;
		while (right->reliab >= pivot)
			--right;
		if (left < right)
		{
			swap(*left, *right);
			++left;
			--right;
		}
	}
	return left;
}

void quicker_sort(EDGE* left, EDGE* right)
{
	EDGE* p;
	float pivot;

	if (find_pivot(left, right, &pivot) == yes)
	{
		pivot = 0;
		p = partition(left, right, pivot);
		quicker_sort(left, p - 1);
		quicker_sort(p, right);
	}
}

//--------------end quicker_sort algorithm -----------------------------------

//--------------------start initialse pixels ----------------------------------
//initialse pixels. See the explination of the pixel class above.
//initially every pixel is a gorup by its self
void  initialisePIXELs(float* WrappedImage, PIXEL* pixel, int image_width, int image_height)
{
	PIXEL* pixel_pointer = pixel;
	float* wrapped_image_pointer = WrappedImage;
	int i, j;

	for (i = 0; i < image_height; i++)
	{
		for (j = 0; j < image_width; j++)
		{
			//pixel_pointer->x = j;
			//pixel_pointer->y = i;
			pixel_pointer->increment = 0;
			pixel_pointer->number_of_pixels_in_group = 1;
			pixel_pointer->value = *wrapped_image_pointer;
			pixel_pointer->reliability = 9999999 + rand();
			pixel_pointer->head = pixel_pointer;
			pixel_pointer->last = pixel_pointer;
			pixel_pointer->next = NULL;
			pixel_pointer->new_group = 0;
			pixel_pointer->group = -1;
			pixel_pointer++;
			wrapped_image_pointer++;
		}
	}
}
//-------------------end initialise pixels -----------

//gamma function in the paper
float wrap(float pixel_value)
{
	float wrapped_pixel_value;
	if (pixel_value > PI)	wrapped_pixel_value = pixel_value - TWOPI;
	else if (pixel_value < -PI)	wrapped_pixel_value = pixel_value + TWOPI;
	else wrapped_pixel_value = pixel_value;
	return wrapped_pixel_value;
}

// pixelL_value is the left pixel,	pixelR_value is the right pixel
int find_wrap(float pixelL_value, float pixelR_value)
{
	float difference;
	int wrap_value;
	difference = pixelL_value - pixelR_value;

	if (difference > PI)	wrap_value = -1;
	else if (difference < -PI)	wrap_value = 1;
	else wrap_value = 0;

	return wrap_value;
}

void calculate_reliability(float* wrappedImage, PIXEL* pixel, int image_width, int image_height)
{
	int image_width_plus_one = image_width + 1;
	int image_width_minus_one = image_width - 1;
	PIXEL* pixel_pointer = pixel + image_width_plus_one;
	float* WIP = wrappedImage + image_width_plus_one; //WIP is the wrapped image pointer
	float H, V, D1, D2;
	int i, j;

	for (i = 1; i < image_height - 1; ++i)
	{
		for (j = 1; j < image_width - 1; ++j)
		{
			H = wrap(*(WIP - 1) - *WIP) - wrap(*WIP - *(WIP + 1));
			V = wrap(*(WIP - image_width) - *WIP) - wrap(*WIP - *(WIP + image_width));
			D1 = wrap(*(WIP - image_width_plus_one) - *WIP) - wrap(*WIP - *(WIP + image_width_plus_one));
			D2 = wrap(*(WIP - image_width_minus_one) - *WIP) - wrap(*WIP - *(WIP + image_width_minus_one));
			pixel_pointer->reliability = H * H + V * V + D1 * D1 + D2 * D2;
			pixel_pointer++;
			WIP++;
		}
		pixel_pointer += 2;
		WIP += 2;
	}
}

//calculate the reliability of the horizental edges of the image
//it is calculated by adding the reliability of pixel and the relibility of 
//its right neighbour
//edge is calculated between a pixel and its next neighbour
void horizentalEDGEs(PIXEL* pixel, EDGE* edge, int image_width, int image_height)
{
	int i, j;
	EDGE* edge_pointer = edge;
	PIXEL* pixel_pointer = pixel;

	for (i = 0; i < image_height; i++)
	{
		for (j = 0; j < image_width - 1; j++)
		{
			edge_pointer->pointer_1 = pixel_pointer;
			edge_pointer->pointer_2 = (pixel_pointer + 1);
			edge_pointer->reliab = pixel_pointer->reliability + (pixel_pointer + 1)->reliability;
			edge_pointer->increment = find_wrap(pixel_pointer->value, (pixel_pointer + 1)->value);
			pixel_pointer++;
			edge_pointer++;
		}
		pixel_pointer++;
	}
}

//calculate the reliability of the vertical EDGEs of the image
//it is calculated by adding the reliability of pixel and the relibility of 
//its lower neighbour in the image.
void verticalEDGEs(PIXEL* pixel, EDGE* edge, int image_width, int image_height)
{
	int i, j;

	PIXEL* pixel_pointer = pixel;
	EDGE* edge_pointer = edge + (image_height) * (image_width - 1);

	for (i = 0; i < image_height - 1; i++)
	{
		for (j = 0; j < image_width; j++)
		{
			edge_pointer->pointer_1 = pixel_pointer;
			edge_pointer->pointer_2 = (pixel_pointer + image_width);
			edge_pointer->reliab = pixel_pointer->reliability + (pixel_pointer + image_width)->reliability;
			edge_pointer->increment = find_wrap(pixel_pointer->value, (pixel_pointer + image_width)->value);
			pixel_pointer++;
			edge_pointer++;
		} //j loop
	} // i loop
}

//gather the pixels of the image into groups 
void gatherPIXELs(EDGE* edge, int image_width, int image_height)
{
	int k;

	//Number of rialiable edges (not at the borders of the image)
	int no_EDGEs = (image_width - 1) * (image_height)+(image_width) * (image_height - 1);
	PIXEL* PIXEL1;
	PIXEL* PIXEL2;

	PIXEL* group1;
	PIXEL* group2;
	EDGE* pointer_edge = edge;
	int incremento;

	for (k = 0; k < no_EDGEs; k++)
	{
		PIXEL1 = pointer_edge->pointer_1;
		PIXEL2 = pointer_edge->pointer_2;

		//PIXEL 1 and PIXEL 2 belong to different groups
		//initially each pixel is a group by it self and one pixel can construct a group
		//no else or else if to this if
		if (PIXEL2->head != PIXEL1->head)
		{
			//PIXEL 2 is alone in its group
			//merge this pixel with PIXEL 1 group and find the number of 2 pi to add 
			//to or subtract to unwrap it
			if ((PIXEL2->next == NULL) && (PIXEL2->head == PIXEL2))
			{
				PIXEL1->head->last->next = PIXEL2;
				PIXEL1->head->last = PIXEL2;
				(PIXEL1->head->number_of_pixels_in_group)++;
				PIXEL2->head = PIXEL1->head;
				PIXEL2->increment = PIXEL1->increment - pointer_edge->increment;
			}

			//PIXEL 1 is alone in its group
			//merge this pixel with PIXEL 2 group and find the number of 2 pi to add 
			//to or subtract to unwrap it
			else if ((PIXEL1->next == NULL) && (PIXEL1->head == PIXEL1))
			{
				PIXEL2->head->last->next = PIXEL1;
				PIXEL2->head->last = PIXEL1;
				(PIXEL2->head->number_of_pixels_in_group)++;
				PIXEL1->head = PIXEL2->head;
				PIXEL1->increment = PIXEL2->increment + pointer_edge->increment;
			}

			//PIXEL 1 and PIXEL 2 both have groups
			else
			{
				group1 = PIXEL1->head;
				group2 = PIXEL2->head;
				//the no. of pixels in PIXEL 1 group is large than the no. of PIXELs
				//in PIXEL 2 group.   Merge PIXEL 2 group to PIXEL 1 group
				//and find the number of wraps between PIXEL 2 group and PIXEL 1 group
				//to unwrap PIXEL 2 group with respect to PIXEL 1 group.
				//the no. of wraps will be added to PIXEL 2 grop in the future
				if (group1->number_of_pixels_in_group > group2->number_of_pixels_in_group)
				{
					//merge PIXEL 2 with PIXEL 1 group
					group1->last->next = group2;
					group1->last = group2->last;
					group1->number_of_pixels_in_group = group1->number_of_pixels_in_group + group2->number_of_pixels_in_group;
					incremento = PIXEL1->increment - pointer_edge->increment - PIXEL2->increment;
					//merge the other pixels in PIXEL 2 group to PIXEL 1 group
					while (group2 != NULL)
					{
						group2->head = group1;
						group2->increment += incremento;
						group2 = group2->next;
					}
				}

				//the no. of PIXELs in PIXEL 2 group is large than the no. of PIXELs
				//in PIXEL 1 group.   Merge PIXEL 1 group to PIXEL 2 group
				//and find the number of wraps between PIXEL 2 group and PIXEL 1 group
				//to unwrap PIXEL 1 group with respect to PIXEL 2 group.
				//the no. of wraps will be added to PIXEL 1 grop in the future
				else
				{
					//merge PIXEL 1 with PIXEL 2 group
					group2->last->next = group1;
					group2->last = group1->last;
					group2->number_of_pixels_in_group = group2->number_of_pixels_in_group + group1->number_of_pixels_in_group;
					incremento = PIXEL2->increment + pointer_edge->increment - PIXEL1->increment;
					//merge the other pixels in PIXEL 2 group to PIXEL 1 group
					while (group1 != NULL)
					{
						group1->head = group2;
						group1->increment += incremento;
						group1 = group1->next;
					} // while

				} // else
			} //else
		};//if

		pointer_edge++;
	}
}

//unwrap the image 
void unwrapImage(PIXEL* pixel, int image_width, int image_height)
{
	int i;
	int image_size = image_width * image_height;
	PIXEL* pixel_pointer = pixel;

	for (i = 0; i < image_size; i++)
	{
		pixel_pointer->value += TWOPI * (float)(pixel_pointer->increment);
		pixel_pointer++;
	}
}

//the input to this unwrapper is an array that contains the wrapped phase map. 
//copy the image on the buffer passed to this unwrapper to over write the unwrapped 
//phase map on the buffer of the wrapped phase map.
void returnImage(PIXEL* pixel, float* unwrappedImage, int image_width, int image_height)
{
	int i;
	int image_size = image_width * image_height;
	float* unwrappedImage_pointer = unwrappedImage;
	PIXEL* pixel_pointer = pixel;

	for (i = 0; i < image_size; i++)
	{
		*unwrappedImage_pointer = pixel_pointer->value;
		pixel_pointer++;
		unwrappedImage_pointer++;
	}
}


void unwrap_RG(InputArray _src, OutputArray _dst)
{
	Mat src = _src.getMat();
	splab::Matrix<float> WrappedImage(src.rows, src.cols), UnwrappedImage(src.rows, src.cols);
	for (int i = 0; i < src.rows; i++)
		for (int j = 0; j < src.cols; j++)
			WrappedImage[i][j] = src.at<float>(i, j);

	int image_height = src.rows;
	int image_width = src.cols;
	int i, j;
	int image_size = image_height * image_width;
	int two_image_size = 2 * image_size;

	int No_of_Edges = (image_width) * (image_height - 1) + (image_width - 1) * (image_height);

	PIXEL* pixel = (PIXEL*)calloc(image_size, sizeof(PIXEL));
	EDGE* edge = (EDGE*)calloc(No_of_Edges, sizeof(EDGE));;

	//initialise the pixels
	initialisePIXELs(WrappedImage, pixel, image_width, image_height);

	calculate_reliability(WrappedImage, pixel, image_width, image_height);

	horizentalEDGEs(pixel, edge, image_width, image_height);

	verticalEDGEs(pixel, edge, image_width, image_height);

	//sort the EDGEs depending on their reiability. The PIXELs with higher relibility (small value) first
	//if your code stuck because of the quicker_sort() function, then use the quick_sort() function
	//run only one of the two functions (quick_sort() or quicker_sort() )
	//quick_sort(edge, No_of_Edges);
	quicker_sort(edge, edge + No_of_Edges - 1);

	//gather PIXELs into groups
	gatherPIXELs(edge, image_width, image_height);

	//unwrap the whole image
	unwrapImage(pixel, image_width, image_height);

	//copy the image from PIXEL structure to the wrapped phase array passed to this function
	returnImage(pixel, UnwrappedImage, image_width, image_height);

	free(edge);
	free(pixel);

	//for (int i = 0; i < src.rows; i++)
	//	for (int j = 0; j < src.cols; j++)
	//		UnwrappedImage[i][j] = UnwrappedImage[i][j] - TWOPI;
	Mat dst(src.rows, src.cols, CV_32FC1, UnwrappedImage);

	dst.copyTo(_dst);
	
}



void phase_unwrap(int UnwrapMode, Mat &I_src)
{
	switch (UnwrapMode)
	{
	case 0:
		break;
	case 1: unwrap_DCT(I_src, I_src); 
		break;
	case 2: unwrap_GS(I_src, I_src);
		break;
	case 3: unwrap_QG(I_src, I_src);
		break;
	case 4: unwrap_RG(I_src, I_src);
		break;
	default:
		break;
	}
}



void HistCalc(Mat& MatPha, float lowActive0, float highActive0, double phi_min, double phi_max)
{
	lowActive0 = -11;
	double minv, maxv;
	Point pt_min, pt_max;
	minMaxLoc(MatPha, &minv, &maxv, &pt_min, &pt_max);
	phi_min = minv; 
	phi_max = maxv;

	double hist_max = maxv;
	Mat phaseMat_hist = Mat::zeros(1, 259, CV_32FC1);  //一行259列的float型矩阵
	Mat phase_8u;
	MatPha.convertTo(phase_8u, CV_32FC1, 128 / hist_max, 128);  //缩放函数
	float* ptr_hist = phaseMat_hist.ptr<float>(0);

	for (int i = 0; i < MatPha.rows; i++)
	{
		float* ptr = phase_8u.ptr<float>(i);
		for (int j = 0; j < MatPha.cols; j++)
		{
			int a = int(ptr[j] + 0.5);
			if (a >= 0 && a <= 255)
				ptr_hist[a] += 1;
		}
	}

	ptr_hist[256] = -hist_max;
	ptr_hist[257] = hist_max;



	//值为0的位置
	ptr_hist[258] = 128;  // (abs(ptr_hist[256])) / (ptr_hist[257] - ptr_hist[256]) * 255;




	if (lowActive0 == 0)
		lowActive0 = -hist_max;
	if (highActive0 == 0)
		highActive0 = hist_max;//传入的两个阈值均未手动设置

	for (int j = 0; j < MatPha.rows; j++)
	{
		float* data = MatPha.ptr<float>(j);
		for (int i = 0; i < MatPha.cols; i++)
		{
			if (data[i] < lowActive0)
				data[i] = lowActive0;
			else if (data[i] > highActive0)
				data[i] = highActive0;

			else if (i == 0 && j == 0)
				data[i] = lowActive0;
			else if (i == MatPha.cols - 1 && j == MatPha.rows - 1)
				data[i] = highActive0;
		}
	}
}


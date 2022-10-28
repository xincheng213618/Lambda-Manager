#include "pch.h"
#include "Utility.h"
#include "PhaseAlgorithm.h"

//CUDA
#include <cuda_runtime_api.h>
#include "cuda_runtime.h"
#include "device_launch_parameters.h"
#include <cufft.h>
#include "my_cuda.h"

//相机分辨率
int g_nLiveWidth;
int g_nLiveHight;

int g_nCameraWidth;
int g_nCameraHight;

//Phase去背景使能开关
int g_nPhaseBackGroundEnable;
int g_nQPGroudEnable;
int g_nPCGroudEnable;
int g_nQPGroudEnableReg;
//Phase去背景完成缓存帧
cv::Mat g_mPhaseBackGround;
//Phase参数
float g_dPhasePixelSize;
float g_dPhaseReg;
float g_dPhaseMin;
float g_dPhaseMax;
float g_dPhaseDetail;
float g_dPhaseGamma;
//Contrast参数
float g_dContrastFilter;
float g_dContrastGamma;
float g_dContrastGain;
float g_dContrastWeightBright;
float g_dContrastWeightContrast;
//计算参数
cv::Mat g_mLive_WOTF_LR, g_mLive_WOTF_UD, g_mCamera_WOTF_LR, g_mCamera_WOTF_UD;
//改变模式标志位(0:Phase 1:Contrast)
int g_nChangeMode;
//改变参标志位(0:参数没有改变 1:参数更改需要重新计算)
int g_nChangeParameter;
//正负相衬
bool g_bPCPnEnable;

cv::Mat g_mWorfSquare1, g_mWotfSquare2;

NativeCalculateWOTF g_pfnNativeCalculateWOTF;

cv::Mat g_GRDmFrame[4];

// 创建日志对象
std::shared_ptr<spdlog::logger> my_logger = spdlog::basic_logger_mt("Phase", "Phase.txt");

/*********************我的变量添加*************************/
//旧的行列
int nW_old = 0;
int nH_old = 0;
//全局变量Max_frequency_old(Phase2PC)
float Max_frequency_old = 0.0f;
//全局变量Filter_old(Phase2PC)
float Filter_old = 0.0f;

bool Init_State = false;

int test;

//定义一个全局rho(Phase2PC)
cv::Mat rho_old = cv::Mat::zeros(960 + int(round(0.03f * 960) * 2), 1280 + int(round(0.03f * 1280) * 2), CV_32FC1);
//定义一个全局real(Phase2PC)
cv::Mat real_old = cv::Mat::zeros(960 + int(round(0.03f * 960) * 2), 1280 + int(round(0.03f * 1280) * 2), CV_32FC1);
//定义一个全局imag(Phase2PC)
cv::Mat imag_old = cv::Mat::zeros(960 + int(round(0.03f * 960) * 2), 1280 + int(round(0.03f * 1280) * 2), CV_32FC1);

enum PC_state
{
	no_change,
	size_change,
	filter_change
};

Mycuda cuda_Function;

int num_1 = 0;
int num = 0;
std::mutex mtx;
/*********************我的变量添加*************************/

int InitPhaseAlgorithm(NativeCalculateWOTF pfnNativeCalculateWOTF)
{
	Logger::Log1(Severity::INFO, "Invoke InitPhaseAlgorithm()");

	//相机分辨率
	g_nLiveWidth = 1280;
	g_nLiveHight = 960;

	g_nCameraWidth = 2448;
	g_nCameraHight = 1836;

	//Phase参数
	g_dPhasePixelSize = 0.75; //第一个参数:坐标变换
	g_dPhaseReg = 0.0001; //第二参数:正则化
	g_dPhaseMin = -7.2;
	g_dPhaseMax = 21.3;
	g_dPhaseDetail = 18; //第三个参数:细节增强
	g_dPhaseGamma = 0.0; //0.37

	//Contrast参数
	g_dContrastFilter = 0.07;
	g_dContrastGamma = 1;
	g_dContrastGain = 2;
	g_dContrastWeightBright = 0.7;
	g_dContrastWeightContrast = 1.0;

	//计算参数
	g_mLive_WOTF_LR = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
	g_mLive_WOTF_UD = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
	g_mCamera_WOTF_LR = cv::Mat::zeros(g_nCameraHight, g_nCameraWidth, CV_32FC1);
	g_mCamera_WOTF_UD = cv::Mat::zeros(g_nCameraHight, g_nCameraWidth, CV_32FC1);

	float aaa;
	g_pfnNativeCalculateWOTF = pfnNativeCalculateWOTF;
	g_pfnNativeCalculateWOTF(g_mLive_WOTF_LR, g_mLive_WOTF_UD, g_mCamera_WOTF_LR,
		g_mCamera_WOTF_UD, aaa);

	//改变模式标志位(0:Phase 1:Contrast)
	g_nChangeMode = 0;

	//改变参标志位(0:参数没有改变 1:参数更改需要重新计算)
	g_nChangeParameter = 1;

	g_mWorfSquare1 = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
	g_mWotfSquare2 = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);

	//Phase去背景使能开关
	g_nQPGroudEnable = 1;
	g_nPCGroudEnable = 0;
	g_nQPGroudEnableReg = 0;
	//Phase去背景完成缓存帧
	g_mPhaseBackGround = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);

	for (int i = 0; i < 4; i++)
	{
		g_GRDmFrame[i] = cv::Mat::ones(g_nLiveHight, g_nLiveWidth, CV_8UC3);
	}

	cuda_Function.Init_ALL();

	//正负相衬
	g_bPCPnEnable = false;
	return 0;
}

int QuantitativePhaseRegularization(double regularization)
{
	Logger::Log2(Severity::INFO, L"QuantitativePhaseRegularization() regularization:%f", regularization);
	g_dPhaseReg = regularization;
	g_nQPGroudEnableReg = 1;
	g_nChangeParameter = 1;
	return 0;
}

int QuantitativePhaseDetail(int detail)
{
	Logger::Log2(Severity::INFO, L"QuantitativePhaseDetail() detail:%d", detail);
	g_dPhaseDetail = detail;
	return 0;
}

int QuantitativePhaseMin(double min)
{
	Logger::Log2(Severity::INFO, L"QuantitativePhaseMin() min:%f", min);
	g_dPhaseMin = min;
	return 0;
}

int QuantitativePhaseMax(double max)
{
	Logger::Log2(Severity::INFO, L"QuantitativePhaseMax() max:%f", max);
	g_dPhaseMax = max;
	return 0;
}

int HistogramAutoRange(int Min, int Max)
{
	Logger::Log2(Severity::INFO, L"(HistogramAutoRange min = %d,max = %d)", Min, Max);
	g_dPhaseMin = Min;
	g_dPhaseMax = Max;
	return 0;
}

int QuantitativePhaseGamma(double gamma)
{
	Logger::Log2(Severity::INFO, L"QuantitativePhaseGamma() gamma:%f", gamma);
	g_nChangeParameter = 1;
	g_dPhaseGamma = gamma;
	return 0;
}

int QuantitativePhaseBgCollection()
{
	Logger::Log1(Severity::INFO, "Invoke QuantitativePhaseBgCollection()");
	g_nQPGroudEnable = 1;
	return 0;
}

int PhaseContrastFilter(double filter)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastFilter() filter:%f", filter);
	g_dContrastFilter = filter;

	return 0;
}

int PhaseContrastContrast(double contrast)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastContrast() contrast:%f", contrast);
	return 0;
}

int PhaseContrastGain(double gain)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastContrast() gain:%f", gain);
	g_dContrastGain = gain;
	return 0;
}

int PhaseContrastBfWeight(double weight)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastContrast() weight:%f", weight);
	g_dContrastWeightBright = weight;
	return 0;
}

int PhaseContrastGamma(double gamma)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastGamma() gamma:%f", gamma);
	g_dContrastGamma = gamma;
	return 0;
}

int PhaseContrastPcWeight(double weight)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastPcWeight() weight:%f", weight);
	g_dContrastWeightContrast = weight;
	return 0;
}

int PhaseContrastBgCollection()
{
	Logger::Log1(Severity::INFO, "Invoke PhaseContrastBgCollection()");
	g_nPCGroudEnable = 1;
	return 0;
}

int PhaseContrastPn(bool bauto)
{
	Logger::Log2(Severity::INFO, L"PhaseContrastPn() weight:%d", bauto);
	g_bPCPnEnable = bauto;
	return 0;
}

int NativePhaseAlgorithm(const cv::Mat src[], cv::Mat& dst, int mode)
{
	return 0;
}



//LMCore目前调用的相位算法
int NativePhaseAlgorithm2(const cv::Mat src[], cv::Mat& dst)
{
	cv::Mat mImage[4];

	src[0].copyTo(mImage[0]); //左
	src[1].copyTo(mImage[1]); //右
	src[2].copyTo(mImage[2]); //上
	src[3].copyTo(mImage[3]); //下

	if (g_nQPGroudEnable == 1)
	{
		src[0].copyTo(g_GRDmFrame[0]);
		src[1].copyTo(g_GRDmFrame[1]);
		src[2].copyTo(g_GRDmFrame[2]);
		src[3].copyTo(g_GRDmFrame[3]);

		cv::Mat mFrame[4];
		std::vector<cv::Mat> vSrcFrame;

		for (int i = 0; i < 4; i++)
		{
			g_GRDmFrame[i].convertTo(mFrame[i], CV_32FC1, 1, 0);
			vSrcFrame.emplace_back(mFrame[i]);
		}

		DPC_QPI(vSrcFrame, g_mLive_WOTF_LR, g_mLive_WOTF_UD, g_mPhaseBackGround,
			g_dPhasePixelSize, g_dPhaseReg, 0);

		g_nQPGroudEnable = 0;
	}

	if (g_nQPGroudEnableReg == 1)
	{
		cv::Mat mFrame[4];
		std::vector<cv::Mat> vSrcFrame;

		for (int i = 0; i < 4; i++)
		{
			g_GRDmFrame[i].convertTo(mFrame[i], CV_32FC1, 1, 0);
			vSrcFrame.emplace_back(mFrame[i]);
		}

		DPC_QPI(vSrcFrame, g_mLive_WOTF_LR, g_mLive_WOTF_UD, g_mPhaseBackGround,
			g_dPhasePixelSize, g_dPhaseReg, 0);

		g_nQPGroudEnableReg = 0;
	}

	std::vector<cv::Mat> vSrcImage;

	for (int i = 0; i < 4; i++)
	{
		mImage[i].convertTo(mImage[i], CV_32FC1, 1, 0);
		vSrcImage.emplace_back(mImage[i]);
	}

	cv::Mat mPhi = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
	cv::Mat mPhiNew;

	//clock_t start = clock();  //时间起始
	DPC_QPI(vSrcImage, g_mLive_WOTF_LR, g_mLive_WOTF_UD, mPhi,
		g_dPhasePixelSize, g_dPhaseReg, g_dPhaseDetail);
	//clock_t end = clock(); //时间测试结束
	//Logger::Log2(Severity::INFO, L"DPC_QPI[%d ms]", end - start);
	dst = mPhi - g_mPhaseBackGround;

	//mPhi = Mat2Gray(mPhi, g_dPhaseMin, g_dPhaseMax, 2);
	//cvtColor(mPhi, dst, cv::COLOR_GRAY2RGB);


	return 0;
}

//LMCore目前调用的相差算法
int NativeContrastAlgorithm(const cv::Mat src[], cv::Mat& dst)
{
	//my_logger->info("[PhaseAlgorithm Start]");
	//my_logger->flush();

	cv::Mat mImage[4], mMergeImage1, mMergeImage2;

	src[0].copyTo(mImage[0]);
	src[1].copyTo(mImage[1]);
	src[2].copyTo(mImage[2]);
	src[3].copyTo(mImage[3]);

	src[0].copyTo(mMergeImage1);
	src[1].copyTo(mMergeImage2);

	if (g_nPCGroudEnable == 1)
	{
		g_nPCGroudEnable = 0;

		cv::Mat mFrame[4];

		src[0].copyTo(mFrame[0]);
		src[1].copyTo(mFrame[1]);
		src[2].copyTo(mFrame[2]);
		src[3].copyTo(mFrame[3]);

		std::vector<cv::Mat> vSrcFrame;

		for (int i = 0; i < 4; i++)
		{
			mFrame[i].convertTo(mFrame[i], CV_32FC1, 1, 0);
			vSrcFrame.emplace_back(mFrame[i]);
		}

		cv::Mat mPhi = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
		DPC_QPI(vSrcFrame, g_mLive_WOTF_LR, g_mLive_WOTF_UD, g_mPhaseBackGround,
			g_dPhasePixelSize, g_dPhaseReg, g_dPhaseDetail);
	}

	std::vector<cv::Mat> vSrc;
	for (int i = 0; i < 4; i++)
	{
		mImage[i].convertTo(mImage[i], CV_32FC1, 1, 0);
		vSrc.emplace_back(mImage[i]);
	}

	cv::Mat mPhi = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
	DPC_QPI(vSrc, g_mLive_WOTF_LR, g_mLive_WOTF_UD, mPhi,
		g_dPhasePixelSize, g_dPhaseReg, g_dPhaseDetail);

	mPhi = mPhi - g_mPhaseBackGround;

	float fMaxFrequency = 0.4762;
	float fPixelSize = 0.75;
	float fFilter = g_dContrastFilter;
	float fGamma = g_dContrastGamma;
	float fGain = g_dContrastGain;

	mPhi = Mat2Gray(mPhi, g_dPhaseMin, g_dPhaseMax, 1);

	//clock_t start = clock(); //时间起始
	cv::Mat mShowPC = Phase2PC(mPhi, fMaxFrequency, fPixelSize, fFilter, fGamma, fGain, 0.1);
	//clock_t end = clock(); //时间测试结束
	//Logger::Log2(Severity::INFO, L"NativeContrastAlgorithm[%d ms]", end - start);
	cv::Mat mISum = (mMergeImage1 + mMergeImage2) / 2;
	mISum.convertTo(mISum, CV_32FC3, 1, 0);
	mShowPC.convertTo(mShowPC, CV_32FC1, 1, 0);
	cv::Mat DisplayMat = Merge_image(mISum, mShowPC, 1, 1);
	DisplayMat.convertTo(DisplayMat, CV_8UC3, 1, 0);
	cvtColor(DisplayMat, DisplayMat, cv::COLOR_BGR2RGB);
	DisplayMat.copyTo(dst);

	//my_logger->info("[PhaseAlgorithm End]");
	//my_logger->flush();

	return 0;
}

void PhaseBackGroundRemove()
{
	cv::Mat mSrc[4];

	cv::Mat mImage1 = cv::imread("./Setting/PhaseBackGround1L.bmp");
	cv::Mat mImage2 = cv::imread("./Setting/PhaseBackGround2R.bmp");
	cv::Mat mImage3 = cv::imread("./Setting/PhaseBackGround3U.bmp");
	cv::Mat mImage4 = cv::imread("./Setting/PhaseBackGround4P.bmp");

	mImage1.copyTo(mSrc[0]);
	mImage2.copyTo(mSrc[1]);
	mImage3.copyTo(mSrc[2]);
	mImage4.copyTo(mSrc[3]);

	std::vector<cv::Mat> src;

	for (int i = 0; i < 5; i++)
	{
		mSrc[i].convertTo(mSrc[i], CV_32FC1, 1, 0);
		src.push_back(mSrc[i].clone());
	}

	cv::Mat mPhi = cv::Mat::zeros(g_nLiveHight, g_nLiveWidth, CV_32FC1);
	DPC_QPI(src, g_mLive_WOTF_LR, g_mLive_WOTF_UD, g_mPhaseBackGround,
		g_dPhasePixelSize, g_dPhaseReg, g_dPhaseDetail);
	//cv::Scalar sMeanBack = mean(g_mPhaseBackGround);
	//g_mPhaseBackGround = g_mPhaseBackGround - sMeanBack[0];
}

void DPC_QPI(std::vector<cv::Mat> _I_src, cv::Mat complex_WOTF_LR, cv::Mat complex_WOTF_UD, cv::Mat dst,
	float PixelSize, float Reg, float Detail)
{
	int nW, nH;
	nH = _I_src[0].rows;
	nW = _I_src[0].cols;

	cv::Mat fft_temp = cv::Mat::zeros(nH, nW, CV_32FC2);
	cv::Mat fft_temp1 = cv::Mat::zeros(nH, nW, CV_32FC2);
	cv::Mat fft_temp2 = cv::Mat::zeros(nH, nW, CV_32FC2);
	cv::Mat f_temp = cv::Mat::zeros(nH, nW, CV_32FC2);
	cv::Mat real_temp = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat imag_temp = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat phi = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat phi_base[2];
	cv::Mat phi_detail[2];
	cv::Mat planes[3];
	cv::Mat I_src[4];

	for (int i = 0; i < 4; i++)
	{
		split(_I_src[i], planes);
		planes[1].convertTo(I_src[i], CV_32FC1, 1, 0);
	}

	cv::Mat I_LR, I_UD;
	cv::Mat F_LR;
	cv::Mat F_UD;

	cv::divide((I_src[0] - I_src[1]), (I_src[0] + I_src[1]), I_LR);
	cv::divide((I_src[2] - I_src[3]), (I_src[2] + I_src[3]), I_UD);

	fft2_phi(I_LR, phi, F_LR);
	fft2_phi(I_UD, phi, F_UD);

	if (g_nChangeParameter == 1)
	{
		cv::Mat rho = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat WOTF_square = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat WOTF_square_in;
		cv::Mat WOTF_square_out;
		cv::Mat WOTF_LR_real = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat WOTF_LR_imag = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat WOTF_UD_real = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat WOTF_UD_imag = cv::Mat::zeros(nH, nW, CV_32FC1);

		Complex2mat(complex_WOTF_LR, WOTF_LR_real, WOTF_LR_imag, nW, nH, 1);
		Complex2mat(complex_WOTF_UD, WOTF_UD_real, WOTF_UD_imag, nW, nH, 1);

		cv::Mat fx = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat fy = cv::Mat::zeros(nH, nW, CV_32FC1);

		Meshgird(nH, nW, PixelSize, fx, fy);
		cv::sqrt(fx.mul(fx) + fy.mul(fy), rho);
		WOTF_square = WOTF_LR_real.mul(WOTF_LR_real) + WOTF_UD_real.mul(WOTF_UD_real) + g_dPhaseReg;
		WOTF_square.copyTo(g_mWorfSquare1);
		WOTF_square = Mat2Gray(WOTF_square, 0.1, DBL_MAX, 0);
		WOTF_square.copyTo(g_mWotfSquare2);
		g_nChangeParameter = 0;
	}

	fft_temp1 = complexMultiplication(F_LR, complex_WOTF_LR);
	fft_temp2 = complexMultiplication(F_UD, complex_WOTF_UD);
	fft_temp = fft_temp1 + fft_temp2;
	complexDivison(fft_temp, g_mWorfSquare1, real_temp, imag_temp);
	ifft2_phi(real_temp, imag_temp, f_temp);
	split(f_temp, phi_base);
	phi_base[0] = phi_base[0] / nW / nH;

	complexDivison(fft_temp, g_mWotfSquare2, real_temp, imag_temp);
	ifft2_phi(real_temp, imag_temp, f_temp);
	split(f_temp, phi_detail);
	phi_detail[0] = phi_detail[0] / nW / nH;
	dst = (phi_base[0] + phi_detail[0] * Detail / 10);
}

cv::Mat Mat2Gray(cv::Mat _Ic, float _low, float _high, int out_putmode)
{
	//___________________________________________________________
	//_Ic input CV_32FC1 random data range
	//out_putmode = 0: no change data type
	//out_putmode = 1; normalized to 0 - 1 CV_32FC1
	//out_putmode = 2; normalized to 0 - 255 CV_8UC1
	//___________________________________________________________
	cv::Mat Im_dst, Ic_src;
	_Ic.copyTo(Im_dst);
	_Ic.copyTo(Ic_src);
	for (int row = 0; row < Ic_src.rows; row++)
	{
		float* vptr0 = Im_dst.ptr<float>(row);
		for (int col = 0; col < Ic_src.cols; col++)
		{
			if (vptr0[col] < _low)
			{
				vptr0[col] = _low;
			}
			if (vptr0[col] > _high)
			{
				vptr0[col] = _high;
			}
		}
	}

	if (out_putmode == 1)
	{
		Im_dst = Im_dst - _low;
		Im_dst.convertTo(Im_dst, CV_32FC1, 1 / (_high - _low), 0);
	}
	else if (out_putmode == 2)
	{
		Im_dst = Im_dst - _low;
		Im_dst.convertTo(Im_dst, CV_32FC1, 1 / (_high - _low), 0);
		Im_dst.convertTo(Im_dst, CV_8UC1, 255, 0);
	}
	return Im_dst;
}

cv::Mat Merge_image(cv::Mat _Ic, cv::Mat _Ibw, float _alpha, float _beta)
{
	cv::Mat Im_dst[3];
	cv::Mat Ic_planes[3];
	cv::Mat Ibw_planes;
	cv::Scalar mean_tmp;
	cv::Mat Im;
	split(_Ic, Ic_planes);
	Ic_planes[0] = Ic_planes[0] * _alpha;
	Ic_planes[1] = Ic_planes[1] * _alpha;
	Ic_planes[2] = Ic_planes[2] * _alpha;

	mean_tmp = cv::mean(_Ibw);
	float mean_pxl = mean_tmp.val[0];
	Ibw_planes = (_Ibw - mean_pxl) * _beta;

	Im_dst[2] = Ic_planes[0] + Ibw_planes;
	Im_dst[1] = Ic_planes[1] + Ibw_planes;
	Im_dst[0] = Ic_planes[2] + Ibw_planes;

	Mat2Gray(Im_dst[0], 0, 255, 2);
	Mat2Gray(Im_dst[1], 0, 255, 2);
	Mat2Gray(Im_dst[2], 0, 255, 2);

	merge(Im_dst, 3, Im);
	//Im.convertTo(Im, CV_8UC3, 1, 0);
	return Im;
}

void fft2_phi(cv::Mat& real_src, cv::Mat& imag_src, cv::Mat& complex_dst)
{
	cv::Mat planes[] = {cv::Mat_<float>(real_src), cv::Mat_<float>(imag_src)};
	cv::Mat complexI, complexF;
	merge(planes, 2, complexI); // Add to the expanded another plane with zeros
	dft(complexI, complex_dst); // this way the result may fit in the source matrix
}

void Mat2complex(cv::Mat src_1, cv::Mat src_2, cv::Mat complex_dst, int nW, int nH, bool phase_mode)
{
	if (phase_mode)
	{
		int pos = 0;
		float phi_tmp = 0;
		float amp_tmp = 0;

		int nW;
		int nH;
		nH = src_1.rows;
		nW = src_1.cols;
		cv::Mat planes[2];
		cv::Mat tmp1 = cv::Mat::zeros(nH, nW, CV_32FC1);
		cv::Mat tmp2 = cv::Mat::zeros(nH, nW, CV_32FC1);

		for (int i = 0; i < nH; ++i)
		{
			const float* ptr_amp = src_1.ptr<float>(i);
			const float* ptr_phi = src_2.ptr<float>(i);
			float* ptr_complex_dst0 = tmp1.ptr<float>(i);
			float* ptr_complex_dst1 = tmp2.ptr<float>(i);
			for (int j = 0; j < nW; ++j)
			{
				amp_tmp = ptr_amp[j];
				phi_tmp = ptr_phi[j];
				ptr_complex_dst0[j] = amp_tmp * cos(phi_tmp);
				ptr_complex_dst1[j] = amp_tmp * sin(phi_tmp);
			}
		}

		tmp1.copyTo(planes[0]);
		tmp2.copyTo(planes[1]);
		merge(planes, 2, complex_dst);
	}
	else
	{
		cv::Mat planes[2];
		src_1.copyTo(planes[0]);
		src_2.copyTo(planes[1]);
		merge(planes, 2, complex_dst);
	}
}

void Complex2mat(cv::Mat complex_src, cv::Mat dst_1, cv::Mat dst_2, int nW, int nH, bool phase_mode)
{
	if (phase_mode)
	{
		cv::Mat planes[2];
		split(complex_src, planes);
		planes[0].copyTo(dst_1);
		planes[1].copyTo(dst_2);
		int pos = 0;
		float x_tmp = 0;
		float y_tmp = 0;
		for (int i = 0; i < nH; ++i)
		{
			float* ptr_real = planes[0].ptr<float>(i);
			float* ptr_imag = planes[1].ptr<float>(i);
			float* ptr_dst_1 = dst_1.ptr<float>(i);
			float* ptr_dst_2 = dst_2.ptr<float>(i);
			for (int j = 0; j < nW; ++j)
			{
				pos = i * nW + j;
				x_tmp = ptr_real[j];
				y_tmp = ptr_imag[j];
				ptr_dst_2[j] = atan2(y_tmp, x_tmp);
				ptr_dst_1[j] = sqrt(x_tmp * x_tmp + y_tmp * y_tmp);
			}
		}
	}
	else
	{
		cv::Mat planes[2];
		split(complex_src, planes);
		planes[0].copyTo(dst_1);
		planes[1].copyTo(dst_2);
	}
}

void fftshift(cv::Mat& out)
{
	cv::Size sz = out.size();
	cv::Point pt(0, 0);
	pt.x = (int)floor(sz.width / 2.0);
	pt.y = (int)floor(sz.height / 2.0);
	circshift(out, pt);
}

void ifft2_phi(cv::Mat& real_src, cv::Mat& imag_src, cv::Mat& complex_dst)
{
	cv::Mat planes[] = {cv::Mat_<float>(real_src), cv::Mat_<float>(imag_src)};
	cv::Mat complexI, complexF;
	merge(planes, 2, complexI); // Add to the expanded another plane with zeros
	dft(complexI, complex_dst, cv::DFT_INVERSE);
}

void circshift(cv::Mat& out, const cv::Point& delta)
{
	cv::Size sz = out.size();

	// 错误检查
	assert(sz.height > 0 && sz.width > 0);
	// 此种情况不需要移动
	if ((sz.height == 1 && sz.width == 1) || (delta.x == 0 && delta.y == 0))
		return;

	// 需要移动参数的变换，这样就能输入各种整数了
	int x = delta.x;
	int y = delta.y;
	if (x > 0) x = x % sz.width;
	if (y > 0) y = y % sz.height;
	if (x < 0) x = x % sz.width + sz.width;
	if (y < 0) y = y % sz.height + sz.height;

	// 多维的Mat也能移动
	std::vector<cv::Mat> planes;
	split(out, planes);

	for (size_t i = 0; i < planes.size(); i++)
	{
		// 竖直方向移动
		cv::Mat tmp0, tmp1, tmp2, tmp3;
		cv::Mat q0(planes[i], cv::Rect(0, 0, sz.width, sz.height - y));
		cv::Mat q1(planes[i], cv::Rect(0, sz.height - y, sz.width, y));
		q0.copyTo(tmp0);
		q1.copyTo(tmp1);
		tmp0.copyTo(planes[i](cv::Rect(0, y, sz.width, sz.height - y)));
		tmp1.copyTo(planes[i](cv::Rect(0, 0, sz.width, y)));

		// 水平方向移动
		cv::Mat q2(planes[i], cv::Rect(0, 0, sz.width - x, sz.height));
		cv::Mat q3(planes[i], cv::Rect(sz.width - x, 0, x, sz.height));
		q2.copyTo(tmp2);
		q3.copyTo(tmp3);
		tmp2.copyTo(planes[i](cv::Rect(x, 0, sz.width - x, sz.height)));
		tmp3.copyTo(planes[i](cv::Rect(0, 0, x, sz.height)));
	}

	merge(planes, out);
}

void Meshgird(int nH, int nW, float Pixelsize, cv::Mat fx, cv::Mat fy)
{
	float delta_x = 1.0 / Pixelsize / nW;
	float delta_y = 1.0 / Pixelsize / nH;

	for (int row = 0; row < nH; row++)
	{
		float* xptr = fx.ptr<float>(row);
		for (int col = 0; col < nW; col++)
		{
			xptr[col] = -nW / 2 * delta_x + col * delta_x;
		}
	}

	for (int row = 0; row < nH; row++)
	{
		float* yptr = fy.ptr<float>(row);
		for (int col = 0; col < nW; col++)
		{
			yptr[col] = -nH / 2 * delta_y + row * delta_y;
		}
	}
}

cv::Mat complexMultiplication(cv::Mat a, cv::Mat b)
{
	std::vector<cv::Mat> pa;
	std::vector<cv::Mat> pb;
	cv::split(a, pa);
	cv::split(b, pb);

	std::vector<cv::Mat> pres;
	pres.push_back(pa[0].mul(pb[0]) - pa[1].mul(pb[1]));
	pres.push_back(pa[0].mul(pb[1]) + pa[1].mul(pb[0]));

	cv::Mat res;
	cv::merge(pres, res);

	return res;
}

void complexDivison(cv::Mat src1, cv::Mat src2, cv::Mat dst1, cv::Mat dst2)
{
	cv::Mat planes[2];
	split(src1, planes);
	cv::divide(planes[0], src2, dst1);
	cv::divide(planes[1], src2, dst2);
}

/***********************************我的函数***********************************/
//生成网格并计算平方根
cv::Mat grid_creat(int nH, int nW, float delta_x, float delta_y)
{
	cv::Mat rho = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat fx = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat fy = cv::Mat::zeros(nH, nW, CV_32FC1);

	for (int row = 0; row < nH; row++)
	{
		float* xptr = fx.ptr<float>(row);
		for (int col = 0; col < nW; col++)
		{
			xptr[col] = -nW / 2.0f * delta_x + col * delta_x;
		}
	}

	for (int row = 0; row < nH; row++)
	{
		float* yptr = fy.ptr<float>(row);
		for (int col = 0; col < nW; col++)
		{
			yptr[col] = -nH / 2.0f * delta_y + row * delta_y;
		}
	}
	cv::sqrt(fx.mul(fx) + fy.mul(fy), rho);
	rho_old = rho;
	return rho;
}

//生成filter
void filter_creat(int nH, int nW, cv::Mat rho, float Max_frequency, float Filter)
{
	cv::Mat weight = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat filter2 = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat Amp = cv::Mat::ones(nH, nW, CV_32FC1);
	cv::Mat U0 = cv::Mat::zeros(nH, nW, CV_32FC2);
	cv::Mat real = cv::Mat::zeros(nH, nW, CV_32FC1);
	cv::Mat imag = cv::Mat::zeros(nH, nW, CV_32FC1);
	/*暂定参数*/
	int PS_Gas_Radius = 31; // PS_Gas_Radius为高斯滤波半径（用高斯滤波实现切趾相移）
	int PS_Gas_var = 50; // PS_Gas_var为高斯滤波方差（用高斯滤波实现切趾相移）
	float Denoise_Radius; // Denoise_Radius：去噪半径

	int G_R = 31; // gaussian滤波半径  这里C++只能是奇数，可能要协调下
	int G_V = 300; // gaussian滤波方差

	Denoise_Radius = (1.0f / 3.0f);
	//cout << "Denoise_Radius: " << Denoise_Radius << "\r\n\r\n";

	for (int row = 0; row < nH; row++)
	{
		float* rhoptr0 = rho.ptr<float>(row);
		float* wightptr0 = weight.ptr<float>(row);
		float* filter2ptr0 = filter2.ptr<float>(row);
		for (int col = 0; col < nW; col++)
		{
			if (rhoptr0[col] < Max_frequency * Filter)
			{
				wightptr0[col] = 1;
			}
			if (rhoptr0[col] < Denoise_Radius)
			{
				filter2ptr0[col] = 1;
			}
		}
	}
	//imshow("weight", weight);
	//对weight进行高斯滤波
	cv::GaussianBlur(weight, weight, cv::Size(PS_Gas_Radius, PS_Gas_Radius), PS_Gas_var, PS_Gas_var);
	cv::GaussianBlur(filter2, filter2, cv::Size(G_R, G_R), G_V, G_V);

	if (g_bPCPnEnable)
	{
		weight = weight * PI / 2; //正相衬
	}
	else
	{
		weight = -weight * PI / 2; //负相衬
	}

	Mat2complex(Amp, weight, U0, nW, nH, 1);
	Complex2mat(U0, real, imag, nW, nH, 0);

	//imshow("filter2", filter2);

	real = real.mul(filter2);
	imag = imag.mul(filter2);

	//imshow("real", real);
	//imshow("imag", (imag));
	fftshift(real);
	fftshift(imag);

	real_old = real;
	imag_old = imag;
}

/***********************************我的函数***********************************/

//cv::Mat Phase2PC(cv::Mat _phi, float Max_frequency, float Pixelsize, float Filter, float Gamma, float Gain,
//	float Denoise)
//{
//	int nW;
//	int nH;
//	int nH_extend;
//	int nW_extend;
//	float delta_x;
//	float delta_y;
//	float a = 0.7f; // 决定生成光强均值
//
//	float ee = 0.03f; //图像延拓比例（图像延拓去滤波伪影）
//	nH = _phi.rows + int(round(ee * _phi.rows) * 2); //行
//	nW = _phi.cols + int(round(ee * _phi.cols) * 2); //列
//
//	//网格计算标志位
//	int grid_filter_flag = 0; //1:行列有变化;2:滤波有变化
//
//	delta_x = 1 / Pixelsize / nW; //列像素数
//	delta_y = 1 / Pixelsize / nH; //行像素数
//
//	clock_t start = 0, stop = 0;
//
//	cv::Mat rho, weight, filter2, Ipc, Phi, real_filter, imag_filter;
//	cv::Mat Show_PC;
//
//	//几个判断
//	if (nH != nH_old or nW != nW_old)
//	{
//		nH_old = nH;
//		nW_old = nW;
//		Max_frequency_old = Max_frequency;
//		Filter_old = Filter;
//		grid_filter_flag = 1;
//	}
//	if (grid_filter_flag == 0 and (Max_frequency != Max_frequency_old or Filter != Filter_old))
//	{
//		Max_frequency_old = Max_frequency;
//		Filter_old = Filter;
//		grid_filter_flag = 2;
//	}
//	test = grid_filter_flag;
//
//	_phi.copyTo(Phi);
//
//	Max_frequency = Max_frequency_old;
//	Filter = Filter_old;
//	//初始化，分配内存和句柄
//
//	switch (1)
//	{
//	case size_change: //传图尺寸发生变化
//
//		cuda_Function.Init_ALL();
//		cuda_Function.grid_creat_now(&rho, nH, nW, delta_x, delta_y); //生成网格并计算平方根
//	//filter_creat(nH, nW, rho, Max_frequency, Filter);
//		rho_old = rho;
//		cuda_Function.circ_creat(rho, weight, filter2, Max_frequency, Filter);
//	//cuda_Function.gaussianBlur_gpu(weight, weight, 15, 60);
//	//cuda_Function.gaussianBlur_gpu(filter2, filter2, 31, 300);
//		cv::GaussianBlur(weight, weight, cv::Size(31, 31), 50, 50);
//		cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
//		cuda_Function.filter_creat_now(weight, filter2, real_old, imag_old, g_bPCPnEnable);
//		break;
//	case filter_change: //滤波器发生变化但传图尺寸不变
//		//0.088
//		rho = rho_old;
//	//filter_creat(nH, nW, rho, Max_frequency, Filter);
//		cuda_Function.circ_creat(rho, weight, filter2, Max_frequency, Filter);
//		cv::GaussianBlur(weight, weight, cv::Size(31, 31), 50, 50);
//		cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
//		cuda_Function.filter_creat_now(weight, filter2, real_old, imag_old, g_bPCPnEnable);
//		break;
//	case no_change:
//		//0s
//		rho = rho_old;
//		break;
//	}
//
//	real_filter = real_old;
//	imag_filter = imag_old;
//
//	nH_extend = int(round(ee * _phi.rows));
//	nW_extend = int(round(ee * _phi.cols));
//
//	//copyMakeBorder用OpenCV不划算，速度差不多，主要是一开始不是在Opencv框架下写得程序。
//	copyMakeBorder(Phi, Phi, nH_extend, nH_extend, nW_extend, nW_extend, cv::BORDER_REPLICATE);
//
//	cuda_Function.ALL_calculate(Phi, real_filter, imag_filter, &Ipc, nH_extend, nW_extend);
//
//	cv::Scalar mean1 = cv::mean(Ipc);
//	Ipc = Mat2Gray(Ipc, mean1[0] - 1 / Gain, mean1[0] + 1 / Gain, 2);
//	Ipc.convertTo(Show_PC, CV_8UC1, 1, 0);
//	cuda_Function.Free_ALL();
//	return Show_PC;
//}

cv::Mat Phase2PC(cv::Mat _phi, float Max_frequency, float Pixelsize, float Filter, float Gamma, float Gain,
	float Denoise)
{
	int nW;
	int nH;
	int nH_extend;
	int nW_extend;
	float delta_x;
	float delta_y;
	float a = 0.7f; // 决定生成光强均值

	float ee = 0.03f; //图像延拓比例（图像延拓去滤波伪影）
	nH = _phi.rows + int(round(ee * _phi.rows) * 2); //行
	nW = _phi.cols + int(round(ee * _phi.cols) * 2); //列

	//网格计算标志位
	int grid_filter_flag = 0; //1:行列有变化;2:滤波有变化

	delta_x = 1 / Pixelsize / nW; //列像素数
	delta_y = 1 / Pixelsize / nH; //行像素数

	clock_t start = 0, stop = 0;

	cv::Mat rho, weight, filter2, Ipc, Phi, real_filter, imag_filter;
	cv::Mat Show_PC;

	//int i = 1;
	//num++;
	mtx.lock();
	int i = num;
	num++;
	if (num >= 4) { num = 0; }
	mtx.unlock();

	mtx.lock();
	//几个判断
	if (nH != nH_old || nW != nW_old)
	{
		nH_old = nH;
		nW_old = nW;
		Max_frequency_old = Max_frequency;
		Filter_old = Filter;
		grid_filter_flag = 1;
	}
	if (grid_filter_flag == 0 && (Max_frequency != Max_frequency_old || Filter != Filter_old))
	{
		Max_frequency_old = Max_frequency;
		Filter_old = Filter;
		grid_filter_flag = 2;
	}
	test = grid_filter_flag;
	//std::cout << "\r\ntest=" << test << "\r\n";

	_phi.copyTo(Phi);

	//初始化，分配内存和句柄

	switch (grid_filter_flag)
	{
	case size_change: //传图尺寸发生变化
		Logger::Log1(Severity::INFO, "grid_filter_flag() grid_creat_now");
		cuda_Function.grid_creat_now(&rho, nH, nW, delta_x, delta_y, i); //生成网格并计算平方根
	//filter_creat(nH, nW, rho, Max_frequency, Filter);
		rho_old = rho;
		Logger::Log2(Severity::INFO, L"time() Max_frequency,Filter:%f,%f", Max_frequency, Filter);
		filter_creat(nH, nW, rho, Max_frequency, Filter);
	//cuda_Function.circ_creat(rho, weight, filter2, Max_frequency, Filter, i);
	//cv::GaussianBlur(weight, weight, cv::Size(31, 31), 50, 50);
	//cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
	//cuda_Function.filter_creat_now(weight, filter2, real_old, imag_old, g_bPCPnEnable, i);
		break;
	case filter_change: //滤波器发生变化但传图尺寸不变
		//0.088
		rho = rho_old;
	//filter_creat(nH, nW, rho, Max_frequency, Filter);
		Logger::Log2(Severity::INFO, L"time() i,Filter:%d,%f", i, Filter);
		filter_creat(nH, nW, rho, Max_frequency, Filter);
	//cuda_Function.circ_creat(rho, weight, filter2, Max_frequency, Filter, i);
	//cv::GaussianBlur(weight, weight, cv::Size(15, 15), 60, 60);
	//cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
	//cuda_Function.filter_creat_now(weight, filter2, real_old, imag_old, g_bPCPnEnable, i);
		break;
	case no_change:
		//0s
		rho = rho_old;
		break;
	}
	mtx.unlock();

	real_filter = real_old;
	imag_filter = imag_old;

	nH_extend = int(round(ee * _phi.rows));
	nW_extend = int(round(ee * _phi.cols));

	//copyMakeBorder用OpenCV不划算，速度差不多，主要是一开始不是在Opencv框架下写得程序。
	copyMakeBorder(Phi, Phi, nH_extend, nH_extend, nW_extend, nW_extend, cv::BORDER_REPLICATE);

	cuda_Function.ALL_calculate(Phi, real_filter, imag_filter, &Ipc, nH_extend, nW_extend, i);

	cv::Scalar mean1 = cv::mean(Ipc);
	Ipc = Mat2Gray(Ipc, mean1[0] - 1 / Gain, mean1[0] + 1 / Gain, 2);
	Ipc.convertTo(Show_PC, CV_8UC1, 1, 0);

	return Show_PC;
}

cv::Mat guidedFilter(cv::Mat I, cv::Mat p, int r, double eps)
{
	/*
	% GUIDEDFILTER   O(1) time implementation of guided filter.
	%
	%   - guidance image: I (should be a gray-scale/single channel image)
	%   - filtering input image: p (should be a gray-scale/single channel image)
	%   - local window radius: r
	%   - regularization parameter: eps
	*/

	cv::Mat _I;
	I.convertTo(_I, CV_64FC1);
	I = _I;

	cv::Mat _p;
	p.convertTo(_p, CV_64FC1);
	p = _p;

	//[hei, wid] = size(I);
	int hei = I.rows;
	int wid = I.cols;

	//N = boxfilter(ones(hei, wid), r); % the size of each local patch; N=(2r+1)^2 except for boundary pixels.
	cv::Mat N;
	cv::boxFilter(cv::Mat::ones(hei, wid, I.type()), N, CV_64FC1, cv::Size(r, r));

	//mean_I = boxfilter(I, r) ./ N;
	cv::Mat mean_I;
	cv::boxFilter(I, mean_I, CV_64FC1, cv::Size(r, r));
	mean_I = mean_I / N;

	//mean_p = boxfilter(p, r) ./ N;
	cv::Mat mean_p;
	cv::boxFilter(p, mean_p, CV_64FC1, cv::Size(r, r));
	mean_p = mean_p / N;

	//mean_Ip = boxfilter(I.*p, r) ./ N;
	cv::Mat mean_Ip;
	cv::boxFilter(I.mul(p), mean_Ip, CV_64FC1, cv::Size(r, r));
	mean_Ip = mean_Ip / N;

	//cov_Ip = mean_Ip - mean_I .* mean_p; % this is the covariance of (I, p) in each local patch.
	cv::Mat cov_Ip = mean_Ip - mean_I.mul(mean_p);

	//mean_II = boxfilter(I.*I, r) ./ N;
	cv::Mat mean_II;
	cv::boxFilter(I.mul(I), mean_II, CV_64FC1, cv::Size(r, r));
	mean_II = mean_II / N;

	//var_I = mean_II - mean_I .* mean_I;
	cv::Mat var_I = mean_II - mean_I.mul(mean_I);

	//a = cov_Ip ./ (var_I + eps); % Eqn. (5) in the paper;
	cv::Mat a = cov_Ip / (var_I + eps);

	//b = mean_p - a .* mean_I; % Eqn. (6) in the paper;
	cv::Mat b = mean_p - a.mul(mean_I);

	//mean_a = boxfilter(a, r) ./ N;
	cv::Mat mean_a;
	cv::boxFilter(a, mean_a, CV_64FC1, cv::Size(r, r));
	mean_a = mean_a / N;

	//mean_b = boxfilter(b, r) ./ N;
	cv::Mat mean_b;
	cv::boxFilter(b, mean_b, CV_64FC1, cv::Size(r, r));
	mean_b = mean_b / N;

	//q = mean_a .* I + mean_b; % Eqn. (8) in the paper;
	cv::Mat q = mean_a.mul(I) + mean_b;

	q.convertTo(q, CV_32FC1);
	return q;
}

void GammaTransform(const cv::Mat& srcImage, cv::Mat& dstImage, double gamma)
{
	unsigned char lut[256];

	for (int i = 0; i < 256; i++)
	{
		lut[i] = cv::saturate_cast<uchar>(pow((float)i / 255.0, gamma) * 255.0f);
	}
	dstImage = srcImage.clone();
	int channels = srcImage.channels();
	switch (channels)
	{
	case 1:
		{
			cv::MatIterator_<uchar> it = dstImage.begin<uchar>();
			cv::MatIterator_<uchar> end = dstImage.end<uchar>();
			while (it != end)
		{
			*it = lut[(*it)];
			it++;
		}
			break;
		}
	case 3:
		{
			cv::MatIterator_<cv::Vec3b> it = dstImage.begin<cv::Vec3b>();
			cv::MatIterator_<cv::Vec3b> end = dstImage.end<cv::Vec3b>();
			while (it != end)
		{
			(*it)[0] = lut[(*it)[0]];
			(*it)[1] = lut[(*it)[1]];
			(*it)[2] = lut[(*it)[2]];
			it++;
		}
			break;
		}
	default:
		break;
	}
}

cv::Mat Phase2PC222(cv::Mat _phi, float Max_frequency, float Pixelsize, float Filter)
{
	clock_t start, end;

	int nW;
	int nH;
	int nH_extend;
	int nW_extend;
	float delta_x;
	float delta_y;
	float a = 0.7f; // 决定生成光强均值

	float ee = 0.03f; //图像延拓比例（图像延拓去滤波伪影）
	nH = _phi.rows + int(round(ee * _phi.rows) * 2); //行
	nW = _phi.cols + int(round(ee * _phi.cols) * 2); //列

	//网格计算标志位
	int grid_filter_flag = 0; //1:行列有变化;2:滤波有变化

	delta_x = 1 / Pixelsize / nW; //列像素数
	delta_y = 1 / Pixelsize / nH; //行像素数


	cv::Mat rho, weight, filter2, Ipc, Phi, real_filter, imag_filter;
	cv::Mat Show_PC;

	//int i = 1;
	//num++;
	mtx.lock();
	int i = num;
	num++;
	if (num >= 4) { num = 0; }
	mtx.unlock();

	mtx.lock();
	//几个判断
	if (nH != nH_old || nW != nW_old)
	{
		nH_old = nH;
		nW_old = nW;
		Max_frequency_old = Max_frequency;
		Filter_old = Filter;
		grid_filter_flag = 1;
	}

	if (grid_filter_flag == 0 && (Max_frequency != Max_frequency_old || Filter != Filter_old))
	{
		Max_frequency_old = Max_frequency;
		Filter_old = Filter;
		grid_filter_flag = 2;
	}
	test = grid_filter_flag;
	//cout << "\r\ntest=" << test << "\r\n";

	_phi.copyTo(Phi);

	Max_frequency = Max_frequency_old;
	Filter = Filter_old;
	//初始化，分配内存和句柄

	switch (grid_filter_flag)
	{
	case size_change: //传图尺寸发生变化
		cuda_Function.grid_creat_now(&rho, nH, nW, delta_x, delta_y, i); //生成网格并计算平方根
	//filter_creat(nH, nW, rho, Max_frequency, Filter);
		rho_old = rho;
		cuda_Function.circ_creat(rho, weight, filter2, Max_frequency, Filter, i);
	//cuda_Function.gaussianBlur_gpu(weight, weight, 15, 60);
	//cuda_Function.gaussianBlur_gpu(filter2, filter2, 31, 300);
		cv::GaussianBlur(weight, weight, cv::Size(15, 15), 60, 60);
		cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
		cuda_Function.filter_creat_now(weight, filter2, real_old, imag_old, g_bPCPnEnable, i);
		break;
	case filter_change: //滤波器发生变化但传图尺寸不变
		//0.088
		rho = rho_old;
	//filter_creat(nH, nW, rho, Max_frequency, Filter);
		cuda_Function.circ_creat(rho, weight, filter2, Max_frequency, Filter, i);
		cv::GaussianBlur(weight, weight, cv::Size(15, 15), 60, 60);
		cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
		cuda_Function.filter_creat_now(weight, filter2, real_old, imag_old, g_bPCPnEnable, i);
		break;
	case no_change:
		//0s
		rho = rho_old;
		break;
	}
	mtx.unlock();
	grid_filter_flag = 0;
	real_filter = real_old;
	imag_filter = imag_old;

	nH_extend = int(round(ee * _phi.rows));
	nW_extend = int(round(ee * _phi.cols));

	//copyMakeBorder用OpenCV不划算，速度差不多，主要是一开始不是在Opencv框架下写得程序。
	copyMakeBorder(Phi, Phi, nH_extend, nH_extend, nW_extend, nW_extend, cv::BORDER_REPLICATE);

	start = clock();
	cuda_Function.ALL_calculate(Phi, real_filter, imag_filter, &Ipc, nH_extend, nW_extend, i);
	end = clock();
	std::cout << "tim33333e: " << (double)(end - start) / CLOCKS_PER_SEC << "s" << "\r\n\r\n";
	Logger::Log2(Severity::INFO, L"ALL_calculate:%f", (double)(end - start) / CLOCKS_PER_SEC);

	cv::Scalar mean1 = cv::mean(Ipc);
	Ipc = Mat2Gray(Ipc, 0.25f, 0.9f, 2);
	Ipc.convertTo(Show_PC, CV_8UC1, 1, 0);

	return Show_PC;
}

int NativeTestCudaTime()
{
	cv::Mat image[3];
	cv::Mat image_out;
	float Max_frequency = 1.0f;
	float Filter = sqrt(0.0008f);
	float Pixelsize = 1.0f;
	float Denoise = 1.0f;

	cv::Mat Show_PC;
	clock_t start, start1, end;
	char str[100];

	image[0] = cv::imread("1.tiff");
	cv::cvtColor(image[0], image[0], cv::COLOR_BGR2GRAY);
	image[0].convertTo(image[0], CV_32FC1, 1.0 / 255.0);
	image[1] = cv::imread("ceshi3.bmp");
	cv::cvtColor(image[1], image[1], cv::COLOR_BGR2GRAY);
	image[1].convertTo(image[1], CV_32FC1, 1.0 / 255.0);
	image[2] = cv::imread("ceshi3.bmp");
	cv::cvtColor(image[2], image[2], cv::COLOR_BGR2GRAY);
	image[2].convertTo(image[2], CV_32FC1, 1.0 / 255.0);
	cuda_Function.Init_ALL();
	start1 = clock();
	for (int i = 0; i < 50; i++)
	{
		start = clock();
		int j = i % 3;
		Show_PC = Phase2PC222(image[j], Max_frequency, Pixelsize, Filter);
		end = clock();
		Logger::Log2(Severity::INFO, L"time() detail:%f", (double)(end - start) / CLOCKS_PER_SEC);
	}
	Logger::Log2(Severity::INFO, L"Alltime() detail:%f", (double)(end - start1) / CLOCKS_PER_SEC);
	cv::imshow("Show_PC", Show_PC);
	cv::waitKey(0);
	return 0;
}

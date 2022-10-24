#pragma once

#ifdef PHASEALGORITHM_EXPORTS
#define PHASEALGORITHM_API __declspec(dllexport)
#else
#define PHASEALGORITHM_API __declspec(dllimport)
#endif

typedef int (*NativeCalculateWOTF)(cv::Mat& mLive_WOTF_LR, cv::Mat& mLive_WOTF_UD,
	cv::Mat& mCamera_WOTF_LR, cv::Mat& mCamera_WOTF_UD, float& pixelsize);

extern "C" PHASEALGORITHM_API int InitPhaseAlgorithm(NativeCalculateWOTF pfnNativeCalculateWOTF);

//B3b-3b6£∫œ‡Œª…Ë÷√

extern "C" PHASEALGORITHM_API int QuantitativePhaseRegularization(double regularization);

extern "C" PHASEALGORITHM_API int QuantitativePhaseDetail(int detail);

extern "C" PHASEALGORITHM_API int QuantitativePhaseMin(double min);

extern "C" PHASEALGORITHM_API int QuantitativePhaseMax(double max);

extern "C" PHASEALGORITHM_API int HistogramAutoRange(int Min, int Max);

extern "C" PHASEALGORITHM_API int QuantitativePhaseGamma(double gamma);

extern "C" PHASEALGORITHM_API int QuantitativePhaseBgCollection();

extern "C" PHASEALGORITHM_API int PhaseContrastFilter(double filter);

extern "C" PHASEALGORITHM_API int PhaseContrastContrast(double contrast);

extern "C" PHASEALGORITHM_API int PhaseContrastGain(double gain);

extern "C" PHASEALGORITHM_API int PhaseContrastBfWeight(double weight);

extern "C" PHASEALGORITHM_API int PhaseContrastGamma(double gamma);

extern "C" PHASEALGORITHM_API int PhaseContrastPcWeight(double weight);

extern "C" PHASEALGORITHM_API int PhaseContrastBgCollection();

extern "C" PHASEALGORITHM_API int PhaseContrastPn(bool bauto);

extern "C" PHASEALGORITHM_API int NativePhaseAlgorithm(const cv::Mat src[], cv::Mat & dst, int mode);

extern "C" PHASEALGORITHM_API int NativePhaseAlgorithm2(const cv::Mat src[], cv::Mat & dst);

extern "C" PHASEALGORITHM_API int NativeContrastAlgorithm(const cv::Mat mSrc[], cv::Mat & mDst);

extern "C" PHASEALGORITHM_API int NativeTestCudaTime();

void PhaseBackGroundRemove();

void DPC_QPI(std::vector<cv::Mat> _I_src, cv::Mat complex_WOTF_LR, cv::Mat complex_WOTF_UD,
	cv::Mat dst, float PixelSize, float Reg, float Detail);

cv::Mat Mat2Gray(cv::Mat _Ic, float _low, float _high, int out_putmode);

cv::Mat Merge_image(cv::Mat _Ic, cv::Mat _Ibw, float _alpha, float _beta);

void fft2_phi(cv::Mat& real_src, cv::Mat& imag_src, cv::Mat& complex_dst);

void Mat2complex(cv::Mat src_1, cv::Mat src_2, cv::Mat complex_dst, int nW, int nH, bool phase_mode);

void Complex2mat(cv::Mat complex_src, cv::Mat dst_1, cv::Mat dst_2, int nW, int nH, bool phase_mode);

void fftshift(cv::Mat& out);

void ifft2_phi(cv::Mat& real_src, cv::Mat& imag_src, cv::Mat& complex_dst);

void circshift(cv::Mat& out, const cv::Point& delta);

void Meshgird(int nH, int nW, float Pixelsize, cv::Mat fx, cv::Mat fy);

cv::Mat complexMultiplication(cv::Mat a, cv::Mat b);

void complexDivison(cv::Mat src1, cv::Mat src2, cv::Mat dst1, cv::Mat dst2);

cv::Mat Phase2PC(cv::Mat _phi, float Max_frequency, float Pixelsize, float Filter, float Gamma, float Gain, float Denoise);

cv::Mat guidedFilter(cv::Mat I, cv::Mat p, int r, double eps);

void GammaTransform(const cv::Mat& srcImage, cv::Mat& dstImage, double gamma);

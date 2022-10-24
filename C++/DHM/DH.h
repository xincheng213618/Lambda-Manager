#pragma once
#include <opencv2\core\core.hpp>

using namespace cv;

void circshift(Mat& out, const Point& delta);
void fft2(InputArray _src, OutputArray _dst, OutputArray _dstm);

void fftshift(Mat& out);
void ifftshift(Mat& out);
void ifft2(InputArray _src, OutputArray _dst);

void DIC_matcalculate(Mat& MatPha, Mat& DIC_mat, float rotation, float distance);

void AutoSpectrumSelection(InputArray input_f, InputArray input_m, OutputArray output, float NA, float pixelsize, float Ma, float lamda);

void AutoSpectrumSelection(InputArray input_f, InputArray input_m, int& x1, int& y1, int& nh, int& nw);
void Rection(InputArray input_f, InputArray input_m, int x1, int y1, int nw, int nh, Mat& output, Mat& am);

void abslog(InputArray _src, OutputArray _dst);


void phi_angle(InputArray _src, OutputArray _dst);

void Inten(InputArray _src, OutputArray _dst);
void get_exp(InputArray _src, OutputArray _dst);
Mat polyfit(std::vector<cv::Point2f>& chain, int n);
void E_SVD(InputArray _src, OutputArray _dst);
void E_SVD(InputArray _src, InputArray _src2, OutputArray _dst, float c1, float c2);

void Multiple(InputArray _src1, InputArray _src2, OutputArray _dst);
void phase_PCA(Mat& I_src1, Mat& I_src2, Mat& I_dst1, Mat& I_dst2, Mat& I_dst3);

void phase_unwrap(int UnwrapMode, Mat& I_src);

void HistCalc(Mat& MatPha, float lowActive0, float highActive0, double phi_min, double phi_max);


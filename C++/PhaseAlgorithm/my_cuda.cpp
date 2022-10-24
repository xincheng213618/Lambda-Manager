#include "pch.h"
#include "my_cuda.h"

#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc.hpp>

void Mycuda::Init_ALL()
{
	CUDA_Init_ALL(nH_max, nW_max);
}

void Mycuda::Free_ALL()
{
	CUDA_Free_ALL();
}

void Mycuda::grid_creat_now(cv::Mat* dst, int nH, int nW, float delta_x, float delta_y, int i)
{
	CUDA_grid_creat_now(dst, nH, nW, delta_x, delta_y, i);
	
}

void Mycuda::circ_creat(cv::Mat src, cv::Mat& dst1, cv::Mat& dst2, float Max_frequency, float Filter, int i)
{
	CUDA_circ_creat(src, dst1, dst2, Max_frequency, Filter, i);
}

void Mycuda::filter_creat_now(cv::Mat src1, cv::Mat src2, cv::Mat& dst1, cv::Mat& dst2, bool flag, int i)
{
	CUDA_filter_creat_now(src1, src2, dst1, dst2, flag, i);
	
}

void Mycuda::ALL_calculate(cv::Mat Phi, cv::Mat real_filter, cv::Mat imag_filter, cv::Mat* Ipc, int nH_extend, int nW_extend, int i)
{
	CUDA_ALL_calculate(Phi, real_filter, imag_filter, Ipc, nH_extend, nW_extend, i);
}

//void Mycuda::gaussianBlur_gpu(cv::Mat& src, cv::Mat& dst, int Gas_Radius, int Gas_var)
//{
//	CUDA_gaussianBlur_gpu(src, dst, Gas_Radius, Gas_var);
//}


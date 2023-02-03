#ifndef __CUDA_CUH
#define __CUDA_CUH

#include <iostream>
#include <math.h>
#include<time.h>

//CUDA
#define CUDA_API_PER_THREAD_DEFAULT_STREAM
//#include <cuda_runtime_api.h>
//#include "cuda_runtime.h"
#include "device_launch_parameters.h"
#include <cufft.h>

//OPENCV
#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc.hpp>
//#include <opencv2/cudafilters.hpp>
//#include <opencv2/cudaarithm.hpp>

//void CUDA_Init_ALL(int nH, int nW);
//void CUDA_Free_ALL();
//void CUDA_grid_creat_now(cv::Mat* dst, int nH, int nW, float delta_x, float delta_y, int i);
//void CUDA_circ_creat(cv::Mat src, cv::Mat& dst1, cv::Mat& dst2, float Max_frequency, float Filter, int i);
//void CUDA_filter_creat_now(cv::Mat src1, cv::Mat src2, cv::Mat& dst1, cv::Mat& dst2, bool flag, int i);
//void CUDA_ALL_calculate(cv::Mat Phi, cv::Mat real_filter, cv::Mat imag_filter, cv::Mat* Ipc, int nH_extend, int nW_extend, int i);
//void CUDA_gaussianBlur_gpu(cv::Mat& src, cv::Mat& dst, int Gas_Radius, int Gas_var);



class CUDA_class
{
public:
	CUDA_class();
	~CUDA_class();
protected:
	void CUDA_grid_creat_now(cv::Mat* dst, int nH, int nW, float delta_x, float delta_y, int i);
	void CUDA_circ_creat(cv::Mat src, cv::Mat& dst1, cv::Mat& dst2, float Max_frequency, float Filter, int i);
	void CUDA_filter_creat_now(cv::Mat src1, cv::Mat src2, cv::Mat& dst1, cv::Mat& dst2, bool flag, int i);
	void CUDA_ALL_calculate(cv::Mat Phi, cv::Mat real_filter, cv::Mat imag_filter, cv::Mat* Ipc, int nH_extend, int nW_extend, int i);

private:
	float ee = 0.03f;//ÕºœÒ—”Õÿ±»¿˝£®ÕºœÒ—”Õÿ»•¬À≤®Œ±”∞£©
	int nH_max = 960 + int(round(ee * 960) * 2);//––
	int nW_max = 1280 + int(round(ee * 1280) * 2);//¡–

	float* device1_float_out, * device2_float_out, \
		* device3_float_out, * device4_float_out, \
		* device5_float_out;
	float* Amp_real_out, * Phi_imag_out;
	cufftComplex* U0_device1_out, * U0_device2_out;
	cudaStream_t* stream;
};


#endif // !__CUDA_CUH

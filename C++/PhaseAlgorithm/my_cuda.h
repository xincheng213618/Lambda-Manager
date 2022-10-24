#ifndef __CUDA_H
#define __CUDA_H

#include "my_cuda.cuh"



class Mycuda
{
public:
	void Init_ALL();
	void Free_ALL();
	void grid_creat_now(cv::Mat* dst, int nH, int nW, float delta_x, float delta_y, int i);
	void circ_creat(cv::Mat src, cv::Mat& dst1, cv::Mat& dst2, float Max_frequency, float Filter, int i);
	void filter_creat_now(cv::Mat src1, cv::Mat src2, cv::Mat& dst1, cv::Mat& dst2, bool flag, int i);
	void ALL_calculate(cv::Mat Phi, cv::Mat real_filter, cv::Mat imag_filter, cv::Mat* Ipc, int nH_extend, int nW_extend, int i);
	//void gaussianBlur_gpu(cv::Mat& src, cv::Mat& dst, int Gas_Radius, int Gas_var);

private:
	float ee = 0.03f;//Í¼ÏñÑÓÍØ±ÈÀı£¨Í¼ÏñÑÓÍØÈ¥ÂË²¨Î±Ó°£©
	int nH_max = 960 + int(round(ee * 960) * 2);//ĞĞ
	int nW_max = 1280 + int(round(ee * 1280) * 2);//ÁĞ

};

#endif // !__CUDA_H

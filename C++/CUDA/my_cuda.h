#ifndef __CUDA_H
#define __CUDA_H

#include "my_cuda.cuh"



class Mycuda : public CUDA_class
{
public:
	Mycuda();

public:
	void grid_creat_now(cv::Mat* dst, int nH, int nW, float delta_x, float delta_y, int i);
	void circ_creat(cv::Mat src, cv::Mat& dst1, cv::Mat& dst2, float Max_frequency, float Filter, int i);
	void filter_creat_now(cv::Mat src1, cv::Mat src2, cv::Mat& dst1, cv::Mat& dst2, bool flag, int i);
	void ALL_calculate(cv::Mat Phi, cv::Mat real_filter, cv::Mat imag_filter, cv::Mat* Ipc, int nH_extend, int nW_extend, int i);
	//void gaussianBlur_gpu(cv::Mat& src, cv::Mat& dst, int Gas_Radius, int Gas_var);
	void Set_lock(int i);
	void Set_unlock(int i);
	bool Get_LockState(int i);

public:
	//num变量作调试用，合入程序需屏蔽
	int num = 0;

	//旧的行列
	int nW_old = 0;
	int nH_old = 0;
	//旧的滤波参数
	float Max_frequency_old = 0.0f;
	float Filter_old = 0.0f;
	//定义一个全局rho(Phase2PC)
	cv::Mat rho_old;
	//定义一个全局real(Phase2PC)
	cv::Mat real_old;
	//定义一个全局imag(Phase2PC)
	cv::Mat imag_old;

	std::mutex mtx;

	enum PC_state
	{
		no_change,
		size_change,
		filter_change
	};

private:
	bool Lock_Flag[4];
	
};

#endif // !__CUDA_H

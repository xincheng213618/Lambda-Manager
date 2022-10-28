#include "pch.h"
#include <opencv2/core/core.hpp>
#include <opencv2/highgui/highgui.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/cudafilters.hpp>
#include <iostream>
#include<math.h>
#include<time.h>
#include<future>
#include "thread.h"

//CUDA
#include <cuda_runtime_api.h>
#include "cuda_runtime.h"
#include "device_launch_parameters.h"
#include <cufft.h>
#include "my_cuda.h"
#include "cuda.h"

using namespace cv;
using namespace std;

#define PI 3.14159265358979323846

/*********************我的变量添加*************************/


/*********************我的变量添加*************************/
//正负相衬
bool g_bPCPnEnable = false;

cv::Mat Mat2Gray(cv::Mat _Ic, float _low, float _high, int out_putmode) {
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
			if (vptr0[col] < _low) {
				vptr0[col] = _low;
			}
			if (vptr0[col] > _high) {
				vptr0[col] = _high;
			}
		}
	}

	if (out_putmode == 1) {
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

/***********************************我的函数***********************************/
cv::Mat Phase2PC(cv::Mat _phi, float Max_frequency, float Pixelsize, float Filter, Mycuda* cuda_Function) {//, float Gamma, float Gain, 
	clock_t start, end;
	start = clock();
	int nW;
	int nH;
	int nH_extend;
	int nW_extend;
	float delta_x;
	float delta_y;
	float a = 0.7f; // 决定生成光强均值
	cuda_Function->mtx.lock();
	int i = cuda_Function->num;
	cuda_Function->num++;
	cuda_Function->mtx.unlock();
	int j = i % 4;
	while (1)
	{
		//std::cout << "wait!\r\n";
		if (cuda_Function->Get_LockState(j) == false)
		{
			cuda_Function->Set_lock(j);
			break;
		}
	}
	//std::cout << "run!\r\n";
	
	float ee = 0.03f;//图像延拓比例（图像延拓去滤波伪影）
	nH = _phi.rows + int(round(ee * _phi.rows) * 2);//行
	nW = _phi.cols + int(round(ee * _phi.cols) * 2);//列

	//网格计算标志位
	int grid_filter_flag = 0;//1:行列有变化;2:滤波有变化

	delta_x = 1 / Pixelsize / nW;//列像素数
	delta_y = 1 / Pixelsize / nH;//行像素数

	//clock_t start = 0, stop = 0;

	cv::Mat rho, weight, filter2, Ipc, Phi, real_filter, imag_filter;
	cv::Mat Show_PC;

	char str[100];

	//mtx.lock();
	//int i = num;
	//num++;
	//if (num == 4) { num = 0; }
	//mtx.unlock();

	cuda_Function->mtx.lock();
	//几个判断
	if (nH != cuda_Function->nH_old || nW != cuda_Function->nW_old) {
		cuda_Function->nH_old = nH;
		cuda_Function->nW_old = nW;
		cuda_Function->Max_frequency_old = Max_frequency;
		cuda_Function->Filter_old = Filter;
		grid_filter_flag = 1;
	}
	if (grid_filter_flag == 0 && (Max_frequency != cuda_Function->Max_frequency_old || Filter != cuda_Function->Filter_old)) {
		cuda_Function->Max_frequency_old = Max_frequency;
		cuda_Function->Filter_old = Filter;
		grid_filter_flag = 2;
	}
	//test = grid_filter_flag;
	//cout << "\r\ntest=" << test << "\r\n";

	_phi.copyTo(Phi);

	Max_frequency = cuda_Function->Max_frequency_old;
	Filter = cuda_Function->Filter_old;

	switch (grid_filter_flag)
	{
	case cuda_Function->size_change://传图尺寸发生变化
		cuda_Function->grid_creat_now(&rho, nH, nW, delta_x, delta_y, j);//生成网格并计算平方根
		//filter_creat(nH, nW, rho, Max_frequency, Filter);
		cuda_Function->rho_old = rho;
		cuda_Function->circ_creat(rho, weight, filter2, Max_frequency, Filter, j);
		//cuda_Function.gaussianBlur_gpu(weight, weight, 15, 60);
		//cuda_Function.gaussianBlur_gpu(filter2, filter2, 31, 300);
		cv::GaussianBlur(weight, weight, cv::Size(15, 15), 60, 60);
		cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
		cuda_Function->filter_creat_now(weight, filter2, cuda_Function->real_old, cuda_Function->imag_old, g_bPCPnEnable, j);
		break;
	case cuda_Function->filter_change://滤波器发生变化但传图尺寸不变
		//0.088
		rho = cuda_Function->rho_old;
		//filter_creat(nH, nW, rho, Max_frequency, Filter);
		cuda_Function->circ_creat(rho, weight, filter2, Max_frequency, Filter, j);
		cv::GaussianBlur(weight, weight, cv::Size(15, 15), 60, 60);
		cv::GaussianBlur(filter2, filter2, cv::Size(31, 31), 300, 300);
		cuda_Function->filter_creat_now(weight, filter2, cuda_Function->real_old, cuda_Function->imag_old, g_bPCPnEnable, j);
		break;
	case cuda_Function->no_change:
		//0s
		rho = cuda_Function->rho_old;
		break;
	}
	cuda_Function->mtx.unlock();

	real_filter = cuda_Function->real_old;
	imag_filter = cuda_Function->imag_old;

	nH_extend = int(round(ee * _phi.rows));
	nW_extend = int(round(ee * _phi.cols));

	//copyMakeBorder用OpenCV不划算，速度差不多，主要是一开始不是在Opencv框架下写得程序。
	copyMakeBorder(Phi, Phi, nH_extend, nH_extend, nW_extend, nW_extend, cv::BORDER_REPLICATE);
	clock_t start1, end1;
	start1 = clock();
	//到进来为止都是对的
	cuda_Function->ALL_calculate(Phi, real_filter, imag_filter, &Ipc, nH_extend, nW_extend, j);
	end1 = clock();
	Logger::Log2(Severity::INFO, L"cuda_Function :[%d ms]", end1 - start1);

	cv::Scalar mean1 = cv::mean(Ipc);
	Ipc = Mat2Gray(Ipc, 0.25f, 0.9f, 2);
	Ipc.convertTo(Show_PC, CV_8UC1, 1, 0);

	//sprintf_s(str, sizeof(str), "%d.jpg", i);
	//cv::imwrite(str, Show_PC);
	cuda_Function->Set_unlock(j);
	end = clock();
	Logger::Log2(Severity::INFO, L"cuda_Function :[%d ms]",end - start);

	if (cuda_Function->num >= 100)
	{
		cuda_Function->num = -1;
	}
	return Show_PC;
}


void TestCUDAPhaseToPC()
{
	Mat image[3];
	Mat image_out;
	float Max_frequency = 1.0f;
	float Filter = sqrt(0.0008f);
	float Pixelsize = 1.0f;
	float Denoise = 1.0f;
	clock_t start, end;

	ThreadPool pool;

	std::future<Mat> Show_PC;
	image[0] = imread("1.tiff");
	cv::cvtColor(image[0], image[0], COLOR_BGR2GRAY);
	image[0].convertTo(image[0], CV_32FC1, 1.0 / 255.0);
	image[1] = imread("ceshi3.bmp");
	cv::cvtColor(image[1], image[1], COLOR_BGR2GRAY);
	image[1].convertTo(image[1], CV_32FC1, 1.0 / 255.0);
	image[2] = imread("ceshi3.bmp");
	cv::cvtColor(image[2], image[2], COLOR_BGR2GRAY);
	image[2].convertTo(image[2], CV_32FC1, 1.0 / 255.0);
	pool.start(4);
	start = clock();
	Mycuda cuda_Function;

	for (int i = 0; i < 100; i++) {

		Show_PC = pool.submit(Phase2PC,image[i % 3], Max_frequency, Pixelsize, Filter, &cuda_Function);
	}

	while (1)
	{
		std::this_thread::sleep_for(10ms);
		if (cuda_Function.num ==-1)
		{
			break;
		}
	}
	end = clock();
	Logger::Log2(Severity::INFO, L"ALL100[%d ms]", end - start );
}

// CudaTest.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <opencv2/opencv.hpp>
#include <cufft.h>
#include <cuda_runtime.h>
#include <cuda_runtime_api.h>


void Mat2Complex(cv::Mat src_r, cv::Mat src_i, cufftComplex* dst, int nH, int nW)
{
	int pos;
	for (int i = 0; i < nH; i++)
	{
		float* ptr_r = src_r.ptr<float>(i);
		float* ptr_i = src_i.ptr<float>(i);
		for (int j = 0; j < nW; j++)
		{
			pos = i * nW + j;
			dst[pos].x = ptr_r[j];
			dst[pos].y = ptr_i[j];
		}
	}
}

void Complex2Mat(cv::Mat src_r, cv::Mat src_i, cufftComplex* dst, int nH, int nW)
{
	int pos;
	for (int i = 0; i < nH; i++)
	{
		float* ptr_r = src_r.ptr<float>(i);
		float* ptr_i = src_i.ptr<float>(i);
		for (int j = 0; j < nW; j++)
		{
			pos = i * nW + j;
			ptr_r[j] = dst[pos].x;
			ptr_i[j] = dst[pos].y;
		}
	}
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

void fftshift(cv::Mat& out)
{
	cv::Size sz = out.size();
	cv::Point pt(0, 0);
	pt.x = (int)floor(sz.width / 2.0);
	pt.y = (int)floor(sz.height / 2.0);
	circshift(out, pt);
}
cufftComplex* cu_complexI_h , * cu_complexI_d;

void FFTCUDA_img(cv::Mat test_img)
{
	cv::Mat img_fft, magnitudeImage;
	int nH, nW;
	nH = test_img.rows;
	nW = test_img.cols;


	int deviceCount = 0;
	cudaError_t error_id = cudaGetDeviceCount(&deviceCount);

	cv::Mat planes[] = { cv::Mat_<float>(test_img), cv::Mat::zeros(test_img.size(), CV_32F) };

	cu_complexI_h = (cufftComplex*)malloc(sizeof(cufftComplex) * nW * nH);
	cudaMalloc((void**)&cu_complexI_d, sizeof(cufftComplex) * nW * nW);

	Mat2Complex(planes[0], planes[1], cu_complexI_h, nH, nW);
	cudaMemcpy(cu_complexI_d, cu_complexI_h, sizeof(cufftComplex) * nW * nH, cudaMemcpyHostToDevice);
	cufftHandle plan_forward;
	cufftPlan2d(&plan_forward, nH, nW, CUFFT_C2C);
	cufftExecC2C(plan_forward, cu_complexI_d, cu_complexI_d, CUFFT_FORWARD);
	cudaDeviceSynchronize();

	cudaMemcpy(cu_complexI_h, cu_complexI_d, sizeof(cufftComplex) * nW * nH, cudaMemcpyDeviceToHost);
	Complex2Mat(planes[0], planes[1], cu_complexI_h, nH, nW);
	cufftDestroy(plan_forward);
	free(cu_complexI_h);
	cudaFree(cu_complexI_d);
	merge(planes, 2, img_fft);
	fftshift(img_fft);

	split(img_fft, planes);//多通道分离
	magnitude(planes[0], planes[1], magnitudeImage);
	magnitudeImage += cv::Scalar::all(1);
	log(magnitudeImage, magnitudeImage);
	magnitudeImage = magnitudeImage(cv::Rect(0, 0, magnitudeImage.cols & -2, magnitudeImage.rows & -2));
	normalize(magnitudeImage, magnitudeImage, 0, 1, cv::NORM_MINMAX);
	magnitudeImage.convertTo(magnitudeImage, CV_8UC1, 255, 0);

	//cudaFree(cu_complexI_d);
}

using namespace std;

int main()
{
	int a[10];
	a[2] = 10;
	int b = 2[a];

	clock_t start, end;
	start = clock();
	cv::Mat test_img;
	test_img = cv::imread("C:\\Users\\Chen\\Desktop\\Image\\001.BMP", 0);
	test_img.convertTo(test_img, CV_32FC1);
	int nH, nW;
	nH = test_img.rows;
	nW = test_img.cols;

	for (size_t i = 0; i < 100; i++)
	{
		start = clock();
		FFTCUDA_img(test_img);
		end = clock();
		cout << " read, " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
	}

	end = clock();
	cout << " read, " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    std::cout << "Hello World!\n";
	system("pause");
}


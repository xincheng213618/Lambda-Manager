#include "pch.h"
#include "Ipemunwrap.h"

//PI
#include "constants.h"
using namespace splab;

#include <opencv2\core\core.hpp>
using namespace cv;


void Setdz2(Mat& image, int n)
{
	int k = 0;
	float* inData = image.ptr<float>(k);

	for (k = 0; k < n; k++)
	{
		inData[k] = k + 1;
	}
}

void Setdz4(Mat& image, int n)
{
	int k = 0;
	float* inData = image.ptr<float>(k);

	for (k = 0; k < n; k++)
	{
		inData[k] = k + (-n / 2);
	}
}

void Cos(const Mat& image, Mat& outImage)
{
	// ������ԭͼ��ȳߴ��ͼ��
	outImage.create(image.size(), image.type());
	int nr = image.rows;
	int nl = image.cols;
	for (int k = 0; k < nr; k++)
	{
		// ÿһ��ͼ���ָ��
		const float* inData = image.ptr<float>(k);
		float* outData = outImage.ptr<float>(k);
		for (int i = 0; i < nl; i++)
		{
			outData[i] = cos(inData[i]);
		}
	}
}

void Sin(const Mat& image, Mat& outImage)
{
	// ������ԭͼ��ȳߴ��ͼ��
	outImage.create(image.size(), image.type());
	int nr = image.rows;
	int nl = image.cols;
	for (int k = 0; k < nr; k++)
	{
		// ÿһ��ͼ���ָ��
		const float* inData = image.ptr<float>(k);
		float* outData = outImage.ptr<float>(k);
		for (int i = 0; i < nl; i++)
		{
			outData[i] = sin(inData[i]);
		}
	}
}

void SetOne(const Mat& image, Mat& outImage)
{
	// ������ԭͼ��ȳߴ��ͼ��
	outImage.create(image.size(), image.type());
	int nr = image.rows;
	int nl = image.cols;
	for (int k = 0; k < nr; k++)
	{
		// ÿһ��ͼ���ָ��
		const float* inData = image.ptr<float>(k);
		float* outData = outImage.ptr<float>(k);
		for (int i = 0; i < nl; i++)
		{
			if (k == 0 && i == 0)
				outData[i] = 1;
			else
				outData[i] = inData[i];
		}
	}
}

void angle(Mat& image)
{
	// ������ԭͼ��ȳߴ��ͼ��
	int nr = image.rows;
	int nl = image.cols;
	for (int k = 0; k < nr; k++)
	{
		// ÿһ��ͼ���ָ��
		float* Data = image.ptr<float>(k);
		for (int i = 0; i < nl; i++)
		{
			if (Data[i] > PI)
				Data[i] = Data[i] - 2 * PI;
			if (Data[i] < -PI)
				Data[i] = Data[i] + 2 * PI;
			else
				Data[i] = Data[i];
			//outData[i] = atan(tan(inData[i]));    //����λ���������ٰ���
		}
	}
}


/// <summary>
/// �����DCT����λ�����
/// </summary>
/// <param name="MatPha"></param>
/// <param name="DCTPha"></param>
void unwrap_DCT(Mat& MatPha, Mat& DCTPha)
{
	int w = MatPha.size().width, h = MatPha.size().height;
	Mat delt_phasehang0 = cv::Mat::zeros(cv::Size(w, h + 1), CV_32FC1);
	Mat delt_phaselie0 = cv::Mat::zeros(cv::Size(w + 1, h), CV_32FC1);
	Mat delt_phaselie = delt_phaselie0(Rect(1, 0, w - 1, h));
	Mat delt_phasehang = delt_phasehang0(Rect(0, 1, w, h - 1));
	delt_phaselie = MatPha(Rect(1, 0, w - 1, h)) - MatPha(Rect(0, 0, w - 1, h));
	delt_phasehang = MatPha(Rect(0, 1, w, h - 1)) - MatPha(Rect(0, 0, w, h - 1));
	angle(delt_phaselie);
	angle(delt_phasehang);  //����λ�����ڣ�-�У��У���

	//����LOU
	Mat lou = cv::Mat::zeros(cv::Size(w, h), CV_32FC1);
	Mat loudx = cv::Mat::zeros(cv::Size(w, h), CV_32FC1);
	Mat loudy = cv::Mat::zeros(cv::Size(w, h), CV_32FC1);
	loudy = delt_phaselie0(Rect(1, 0, w, h)) - delt_phaselie0(Rect(0, 0, w, h));
	loudx = delt_phasehang0(Rect(0, 1, w, h)) - delt_phasehang0(Rect(0, 0, w, h));
	lou = loudx + loudy;
	//����LOU�����ұ任
	Mat dct_lou = cv::Mat(w, h, CV_32FC1);
	dct(lou, dct_lou);

	//��DCT������ļ����ĸ
	Mat fenmu = cv::Mat(w, h, CV_32FC1);
	Mat ii0 = cv::Mat::ones(w, 1, CV_32FC1);
	Mat jj0 = cv::Mat::ones(1, h, CV_32FC1);
	Mat ii1 = cv::Mat::ones(w, 1, CV_32FC1);
	Mat jj1 = cv::Mat::ones(1, h, CV_32FC1);
	Mat ii2 = cv::Mat(w, h, CV_32FC1);
	Mat jj2 = cv::Mat(w, h, CV_32FC1);    //֮ǰ���й�ϵ����ˣ��˷��˺ö�ʱ��
	//��õ�������
	Setdz2(ii1, w);
	Setdz2(jj1, h);
	//������������Ե�λ������ii2��jj2
	ii2 = (ii1 * jj0).t();                //�е���
	jj2 = (ii0 * jj1).t();                //�е��� 
	//�����ĸ
	Mat cos_x;
	Cos((PI * (ii2 - 1) / w), cos_x);
	Mat cos_y;
	Cos((PI * (jj2 - 1) / h), cos_y);
	fenmu = 2 * cos_x + 2 * cos_y - 4;
	SetOne(fenmu, fenmu);

	//��DCT�����λ
	Mat PHASE = cv::Mat(h, w, CV_32FC1);
	PHASE = dct_lou / fenmu;
	//����λ�������ұ任
	idct(PHASE, DCTPha);
}


/// <summary>
/// �����GS����λ�����
/// </summary>
/// <param name="MatPha"></param>
/// <param name="DCTPha"></param>
void unwrap_GS(Mat& MatPha, Mat& DCTPha)
{
	int w = MatPha.size().width, h = MatPha.size().height;
	int i, j;
	CIpemunwrap    m_Ipemunwrap;
	float* array = new float[w * h];
	for (j = 0; j < h; j++)
	{
		for (i = 0; i < w; i++)
		{
			array[j * w + i] = MatPha.at<float>(j, i);
		}
	}

	m_Ipemunwrap.SetSize(w, h);
	m_Ipemunwrap.Unwrapping(array, 1);

	for (j = 0; j < h; j++)
	{
		for (i = 0; i < w; i++)
		{
			MatPha.at<float>(j, i) = array[j * w + i];
		}
	}
	delete array;
}
/// <summary>
/// �����QM����λ�����
/// </summary>
/// <param name="MatPha"></param>
/// <param name="DCTPha"></param>
void unwrap_QG(Mat& MatPha, Mat& DCTPha)
{
	int w = MatPha.size().width, h = MatPha.size().height;
	int i, j;
	CIpemunwrap    m_Ipemunwrap;
	float* array = new float[w * h];
	for (j = 0; j < h; j++)
	{
		for (i = 0; i < w; i++)
		{
			array[j * w + i] = MatPha.at<float>(j, i);
		}
	}

	m_Ipemunwrap.SetSize(w, h);
	m_Ipemunwrap.Unwrapping(array, 2);

	for (j = 0; j < h; j++)
	{
		for (i = 0; i < w; i++)
		{
			MatPha.at<float>(j, i) = array[j * w + i];
		}
	}
	delete array;
}






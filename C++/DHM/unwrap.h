#pragma once
#include <opencv2\core\core.hpp>
using namespace cv;

void Cos(const Mat& image, Mat& outImage);
void Sin(const Mat& image, Mat& outImage);

/// <summary>
/// �����DCT����λ�����
/// </summary>
/// <param name="MatPha"></param>
/// <param name="DCTPha"></param>
void unwrap_DCT(Mat& MatPha, Mat& DCTPha);

/// <summary>
/// �����QG����λ�����
/// </summary>
/// <param name="MatPha"></param>
/// <param name="DCTPha"></param>
void unwrap_QG(Mat& MatPha, Mat& DCTPha);

/// <summary>
/// �����GS����λ�����
/// </summary>
/// <param name="MatPha"></param>
/// <param name="DCTPha"></param>
void unwrap_GS(Mat& MatPha, Mat& DCTPha);

#pragma once
#include <opencv2/opencv.hpp>
#include <iostream>

using namespace std;
int WriteFile(cv::Mat WriteMat, string FileName, int compression = 1);
cv::Mat ReadFile(string FileName);
int GrifToMat(std::string path, cv::Mat& src);
int WriteGrifFile(std::string path, std::string name, cv::Mat src, int x, int y, int z);

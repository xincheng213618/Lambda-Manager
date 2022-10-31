#pragma once

#include "common.h"
#include <utility>
#include <vector>
#include <string>
#include <atlstr.h>
#include <windows.h>
#include <wchar.h>
#include <fstream> 
#include <iostream>
#include <string>
#include <cstdio>
#include <sstream>
#include <iomanip>
#include<iostream>
#include<opencv2/opencv.hpp>
#include <string>
#include <direct.h>
#include <io.h>

#ifdef DENOISE_EXPORTS
#define DENOISE_API __declspec(dllexport)
#else
#define DENOISE_API __declspec(dllimport)
#endif


//需要暴漏出来给主控的部分
//extern "C" DENOISE_API int pathname(char* s1);
extern "C" DENOISE_API int Read_img(char* s);
extern "C" DENOISE_API int BM3D(int x);
extern "C" DENOISE_API int DENOISE_FUNCTION(double y);
extern "C" DENOISE_API int Sharpen_FUNCTION(double z);
extern "C" DENOISE_API int Contrast_FUNCTION(double m);
//extern "C" DENOISE_API int solution_sharpen(cv::Mat & img);
//extern "C" DENOISE_API int solution_contrast(cv::Mat & img);
//extern "C" DENOISE_API int solution_cellseg(cv::Mat & img);
//extern "C" DENOISE_API int solution(cv::Mat & img);
extern "C" DENOISE_API int Show_img(cv::Mat & img);
extern "C" DENOISE_API int array_int_receive(void* array_int);
extern "C" DENOISE_API int array_float_receive(void* array_float);
//extern "C" DENOISE_API int CellSeg();
extern "C" DENOISE_API int Center(int a);
extern "C" DENOISE_API int Contour(int b);
extern "C" DENOISE_API int Num(int c);
//extern "C" DENOISE_API int solution_ccn();
//extern "C" DENOISE_API int test();
extern "C" DENOISE_API int Magnification();
extern "C" DENOISE_API int image_phaseMat_hist();
//extern "C" DENOISE_API int testsolution();
//extern "C" DENOISE_API int receivenum(int filenum);
//extern "C" DENOISE_API int savedata(char* file);

//不需要暴漏出来的部分

int SetCellInfos(cv::Mat cellinfos);
int solution_ccn(cv::Mat DrawImage);
void LambdaViewShow(cv::Mat mat);
void LambdaViewShow1(cv::Mat mat);
void LambdaViewShow2(cv::Mat mat);
int CellSeg();
std::string UTF8ToGB(const char* str);
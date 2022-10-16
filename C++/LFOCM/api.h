#pragma once
#define LIB_API  __declspec(dllexport)

#include <opencv2/core.hpp>
#include <opencv2/imgcodecs.hpp>
#include <opencv2\imgproc\imgproc.hpp>
#include <matrix.h>

#include <iostream>
using namespace std;

extern "C" LIB_API  void   imageini(unsigned char* src, int w, int h, int ch);
extern "C" LIB_API  void   imagefft(uchar* ptr, int* len);
extern "C" LIB_API  void   imagesample(uchar* ptr, int* len);
extern "C" LIB_API  void   imagepca(uchar* ptr, int* len);
extern "C" LIB_API  void   imageunwrap(int UnwrapMode,uchar*ptr, int* len);
extern "C" LIB_API  void   imagedic(uchar* ptr, int* len);
extern "C" LIB_API  void  imageHistCalc(uchar*ptr, int* len);

extern "C" LIB_API  void imageall(unsigned char* src, int w, int h, int ch, int UnwrapMode, uchar* ptr, int* len, uchar* ptr1, int* len1, uchar* ptr2, int* len2);


extern "C" LIB_API  void  speedtest(unsigned char* src, int w, int h, int ch, uchar* ptr, int* len);



extern "C" LIB_API double evaluateimage(unsigned char* src, int w, int h, int ch);
















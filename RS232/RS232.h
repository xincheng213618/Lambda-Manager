#pragma once
#include <utility>
#include "common.h"

#ifdef RS232_EXPORTS
#define RS232_API __declspec(dllexport)
#else
#define RS232_API __declspec(dllimport)
#endif

 enum  Direction
{
	LEFT, RIGHT, FRONT, REAR, TOP, DOWN
};

extern "C" RS232_API int OpenLED();

extern "C" RS232_API int CloseLED();

extern "C" RS232_API int OpenLaser();

extern "C" RS232_API int CloseLaser();

extern "C" RS232_API int OpenMotor();

extern "C" RS232_API int MoveStep(int direction, int step);

extern "C" RS232_API int MoveTo(int x,int y);

extern "C" RS232_API int MoveTo2(std::pair<int,double> pair);

extern "C" RS232_API int MoveZ(int step);

extern "C" RS232_API int SendLEDSignal(char* signal);

extern "C" RS232_API int OpenSerial(char* fullPath);

extern "C" RS232_API int OpenSerial2(wchar_t* fullPath);

extern "C" RS232_API  int BilateralDenoise(cv::Mat & imgstr, double* Cdenoise);
extern "C" RS232_API int Phase_Seg(cv::Mat & cell_img, void* array_int, void* array_float, void* array_add);
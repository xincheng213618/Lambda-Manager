#pragma once

#include "common.h"

#ifdef DPC_EXPORTS
#define DPC_API __declspec(dllexport)
#else
#define DPC_API __declspec(dllimport)
#endif

extern "C" DPC_API int LEDBright();

extern "C" DPC_API int LEDDark();

extern "C" DPC_API int ChangeMagnification(int mag);

extern "C" DPC_API int ChangeDPCMode(int dpc);

extern "C" DPC_API int DICImgCalculate(HIMAGE image1, HIMAGE image2, HIMAGE image);

extern "C" DPC_API int DICImgCalculate4(HIMAGE imageU, HIMAGE imageD, HIMAGE imageL, HIMAGE imageR, HIMAGE imageLR, HIMAGE imageUD);

extern "C" DPC_API int CalcPhaseContrast(HIMAGE imageLR, HIMAGE imageUD, HIMAGE imagePC);

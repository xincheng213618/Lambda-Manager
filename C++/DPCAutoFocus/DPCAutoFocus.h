#pragma once

#include "common.h"
#include <utility>
#include <vector>

#ifdef DPCAUTOFOCUS_EXPORTS
#define DPCAUTOFOCUS_API __declspec(dllexport)
#else
#define DPCAUTOFOCUS_API __declspec(dllimport)
#endif


extern "C" DPCAUTOFOCUS_API int Sobel(char** image, void** out);

extern "C" DPCAUTOFOCUS_API int Compare(std::pair<int, double>* pairs[], int count, std::pair<int, double>**out);

#pragma once

#include "common.h"
#include <opencv2/opencv.hpp>
#include <cufft.h>
#include <cuda_runtime.h>
#include <cuda_runtime_api.h>

#ifdef CUDA_EXPORTS
#define CUDA_API __declspec(dllexport)
#else
#define CUDA_API __declspec(dllimport)
#endif

extern "C" CUDA_API void FFTCUDA_img();
/**
 * opencv examples
 * @file Drawing_2.cpp
 * @brief Simple sample code
 */
#pragma once
#include <string>
#include "common.h"
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include <opencv2/highgui.hpp>
#include <iostream>
#include <stdio.h>

using namespace cv;

#ifdef ALGORITHM_EXPORTS
#define ALGORITHM_API __declspec(dllexport)
#else
#define ALGORITHM_API __declspec(dllimport)
#endif

/// Global Variables
const int NUMBER = 10;
const int DELAY = 5;

const int window_width = 900;
const int window_height = 600;
int x_1 = -window_width / 2;
int x_2 = window_width * 3 / 2;
int y_1 = -window_width / 2;
int y_2 = window_width * 3 / 2;

RNG rng(0xFFFFFFFF);

static Scalar randomColor(RNG& rng);
extern "C" ALGORITHM_API int Drawing_Random_Lines(Mat& image);
extern "C" ALGORITHM_API int Drawing_Random_Rectangles(Mat& image);
extern "C" ALGORITHM_API int Drawing_Random_Ellipses(Mat& image);
extern "C" ALGORITHM_API int Drawing_Random_Polylines(Mat& image);
extern "C" ALGORITHM_API int Drawing_Random_Filled_Polygons(Mat& image);
extern "C" ALGORITHM_API int Drawing_Random_Circles(Mat& image);
extern "C" ALGORITHM_API int Displaying_Random_Text(Mat& image);
extern "C" ALGORITHM_API int Displaying_Big_End(Mat& image);

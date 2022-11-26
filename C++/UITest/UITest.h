#pragma once
#include <string>
#include "common.h"
#include <opencv2/opencv.hpp>
#include "Customfile.h"


#define CAMERA_API __declspec(dllexport)

extern "C" CAMERA_API int OpenCamera();

extern "C" CAMERA_API int OpenCinema();

extern "C" CAMERA_API int CloseCamera();

extern "C" CAMERA_API int CaptureImage(int mode, void** image);

extern "C" CAMERA_API int SetProperty(std::string name, std::string value);

extern "C" CAMERA_API int LoadProperty(std::string xmlProperties);

extern "C" CAMERA_API int SaveSettings();

extern "C" CAMERA_API int CameraSettingExposure(int mode,double exposure);

extern "C" CAMERA_API int CameraSettingExposureIni(char** result_data, int len);


extern "C" CAMERA_API int SleepTest();

extern "C" CAMERA_API int VideoTest();

extern "C" CAMERA_API int FloatTest(float num);

extern "C" CAMERA_API int test_double(double exposure);

extern "C" CAMERA_API int MatShow(cv::Mat * Test);
extern "C" CAMERA_API int MatShow1(cv::Mat * Test , int num);
extern "C" CAMERA_API  int ViewWindow(int type, int window, int mode1, int mode2);
extern "C" CAMERA_API int StageSettingReset();
extern "C" CAMERA_API  GrifFile ReadFileInfo(char* FilePath);
extern "C" CAMERA_API  int GrifExportAs(char* GrifExportAsJson);
extern "C" CAMERA_API int HardwareCalibration(char* json);



struct Cam
{
	char ip[16];
	char login[16];
	char pass[16];
	char name[16];
	double a;
};

extern "C" CAMERA_API int CameraSettingCam(Cam &cam);

extern "C" CAMERA_API int OpenSerial(char* FullPath);

extern "C" CAMERA_API int Read_img(char* FilePath);

int Start();

cv::Mat* Filter(cv::Mat& frame);

int ShowImage(void* image);

int PlayFilms(json* eventData);

int PlayFilm(std::string fileName);




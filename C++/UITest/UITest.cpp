
#include "pch.h"
#include "UITest.h"
#include "time.h"
#include <opencv2/core.hpp>
#include <opencv2/videoio.hpp>
#include "thread"
#include "concurrent.h"
#include "threadpool.h"
#include <opencv2/opencv.hpp>

using namespace std;
using namespace cv;
LambdaView* pView = NULL;
ConcurrentQueue<shared_future<cv::Mat*>> pipeline;
ThreadPool pool;

void HistCalc(cv::Mat& MatPha,int i)
{
	int* gray = new int[256];
	for (size_t i = 0; i < 256; i++)
	{
		gray[i] = 0;
	}
	clock_t startTime, endTime;
	startTime = clock();
	for (int i = 0; i < MatPha.rows; i++)
	{
		cv::Vec3b* ptr_hist1 = MatPha.ptr<cv::Vec3b>(i);

		for (int j = 0; j < MatPha.cols; j++)
		{
			int z = round(0.299f * ptr_hist1[j][0] + 0.587f * (float)ptr_hist1[j][1] + 0.114f * ptr_hist1[j][2]);
			gray[z]++;
		}
	}
	endTime = clock();
	double a = (double)(endTime - startTime) / CLOCKS_PER_SEC;

	int size = MatPha.rows * MatPha.cols;
	int* graydense = new int[256];
	for (int i = 0; i < 256; i++)
	{
		double graydense = (gray[i] * 1.0) / size;
		gray[i] = (int)(graydense * 255);
	}

	Event::Trigger("TestDataEvent2", gray, sizeof(char) * i);
}
Mat histnew(Mat& scr, int* maxloc, double sumhist, int* histmax, int* histmin)
{
	Mat hist = Mat::zeros(1, 256, CV_32FC1);
	float* ptr = scr.ptr<float>(0);
	float* hptr = hist.ptr<float>(0);
	hptr[*maxloc] = ptr[*maxloc];
	float th = ptr[*maxloc];

	for (int i = *maxloc; i < scr.cols - 1; i++)
	{
		int minloc = 2 * *maxloc - i - 1;
		float minval;
		if (minloc < 0)
		{
			minloc = 0;
			minval = 0;
		}
		else {
			minval = ptr[2 * *maxloc - i - 1];
		}
		th = th + ptr[i + 1] + minval;
		if (th / sumhist < 0.99)
		{
			hptr[i + 1] = ptr[i + 1];
			hptr[minloc] = ptr[minloc];
		}
		else
		{
			*histmax = i;
			*histmin = minloc + 1;
			break;
		}
	}

	return hist;
}

void Histograme(Mat Im1, LambdaView* pView1) {
	double minVal = 0, maxVal = 0;
	Mat Im;
	cv::cvtColor(Im1, Im, cv::COLOR_RGBA2GRAY);
	minMaxLoc(Im, &minVal, &maxVal, NULL, NULL);

	Mat phase_norm, phase_hist;
	phase_norm = Im;
	//Im.convertTo(phase_norm, CV_8UC1, 255, 0);
	int channel = 0;
	int histSize[] = { 256 };
	float ranges[] = { 0, 256 };
	const float* range[] = { ranges };


	cv::calcHist(&phase_norm, 1, &channel, cv::Mat(), phase_hist, 1, histSize, range, true, false);

	Mat phaseMat_hist = phase_hist.t();
	Scalar numsum = sum(phaseMat_hist);
	double sumhist = numsum[0];

	Point maxLoc;
	double max_val = 0;
	minMaxLoc(phase_hist, NULL, &max_val, NULL, NULL);
	int scale = 2;
	int hist_height = 256;
	Mat hist_img_o = Mat::zeros(hist_height, 256 * scale, CV_8UC3);
	for (int i = 0; i < 256; i++)
	{
		float bin_val = phase_hist.at<float>(i);
		int intensity = cvRound(bin_val * hist_height / max_val);  //要绘制的高度
		rectangle(hist_img_o, Point(i * scale, hist_height - 1),
			Point((i + 1) * scale - 1, hist_height - intensity),
			CV_RGB(255, 255, 255));
	}


	int maxloc = maxLoc.y;
	int histmin = 0, histmax = 0;

	Mat hist = histnew(phaseMat_hist, &maxloc, sumhist, &histmax, &histmin);
	minMaxLoc(hist, 0, &max_val, 0, 0);

	Mat hist_img = Mat::zeros(hist_height, 256 * scale, CV_8UC3);
	for (int i = 0; i < 256; i++)
	{
		float bin_val = hist.at<float>(i);
		int intensity = cvRound(bin_val * hist_height / max_val);  //要绘制的高度
		rectangle(hist_img, Point(i * scale, hist_height - 1),
			Point((i + 1) * scale - 1, hist_height - intensity),
			CV_RGB(255, 255, 255));
	}
	Mat hist_img1;
	resize(hist_img, hist_img1, cv::Size(hist_img.cols*2, hist_img.rows), 0, 0);
	pView1->Show(hist_img1);
}

int OpenCamera()
{
	pView = LambdaView::GetIdleOrNew();
	if (pView->IsState(ViewState::RUNING)) {
		Logger::Log1(Severity::INFO, "ERROR! Camera is running");
		return -1;
	}

	auto f = async(Start);
	for (;;)
	{
		auto result = pipeline.wait_and_pop();
		shared_future<cv::Mat*> sf = *result;
		if (sf.valid()) {
			cv::Mat* image = sf.get();
			pView->Show(*image);
			if (pView->IsState(ViewState::CLOSED)) {
				pool.Stop();
				break;
			}
		}
		else
			break;
	}
	return f.get();
}

int Start() {
	cv::Mat frames[MAX_THREADPOOL_NUM];
	cv::VideoCapture cap;
	int deviceID = 0;             // 0 = open default camera
	int apiID = cv::CAP_ANY;      // 0 = autodetect default API
	cap.open(deviceID, apiID);

	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open camera");
		return -1;
	}

	int index = 0;
	for (;;) {
		cv::Mat& frame = frames[index];
		cap>>frame;
		pipeline.push(pool.Commit(Filter, frame));
		++index;
		if (index == MAX_THREADPOOL_NUM)
			index = 0;
		if (pool.IsStopped())
			break;
	}
	return 0;
}

cv::Mat* Filter(cv::Mat& frame) {
	if (frame.empty()) {
		Logger::Log1(Severity::INFO, "Video is end");
		return nullptr;
	}
	Event::Trigger("FILTER_START", &frame);
	return &frame;
}

int OpenCinema() {
	Event::On("FILE_SELECTED", &PlayFilms, true);
	Event::Trigger("OPEN_FILE_DIALOG");
	return 0;
}

int PlayFilms(json* eventData) {
	json filenames = eventData->at("fileNames");
	if (filenames == NULL)
		return -1;
	for (auto& item : filenames.items()) {
		std::string fileName = item.value().get<std::string>();
		thread task(PlayFilm, fileName);
		task.detach(); //don't block calling thread
	}
	return 0;
}

LambdaView* pView1;

bool ssss = false;
int i = 1;
int x22 = 1;
int y22 = 1;

int PlayFilm(std::string fileName) {
	cv::Mat frame;
	cv::VideoCapture cap = cv::VideoCapture(fileName);

	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open camera");
		return -1;
	}
	LambdaView* pView = LambdaView::GetIdleOrNew();

	pView->SetState(UNINITIALIZED);
	pView->SetState(OCCUPIED);




	LambdaView* pView1 = LambdaView::GetRegistered(-pView->GetIndex()-1);


	std::wstring&& s = StringUtils::string2wstring(fileName);
	int count = 0;

	if (pView->GetIndex() == 3) {
		json j3;
		j3["windowstatus"] = "0,12;1,3;2,4;3,5";
		Event::Trigger("UPDATE_WINDOWSTATUS", &j3);
	}

	if (pView->GetIndex() == 4) {
		Event::Trigger("COLLECTION_COMPLETED");
	}

	Event::Trigger("PREVIEW_CLOSE");

	//auto writer = cv::VideoWriter("C:\\Users\\Chen\\Desktop\\output2_8.mp4", VideoWriter::fourcc('H', '2', '6', '5'), 25, Size((int)cap.get(CAP_PROP_FRAME_WIDTH), (int)cap.get(CAP_PROP_FRAME_HEIGHT)));


	for (;;)
	{
		// wait for a new frame from camera and store it into 'frame'
		if (ssss) {
			ssss = false;
			pView->Close();
			break;

		}
		cap.read(frame);
		// check if we succeeded
		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
		}
		pView->Show(frame);
		//writer.write(frame);

		//for (size_t i = 0; i < 20; i++)
		//{
		//	line(frame, Point(150* i, 0), Point(150 * i, 1920), Scalar(0, 255, 255), 3);
		//	line(frame, Point(0, 90*i), Point(3840, 90 * i), Scalar(0, 255, 255), 3);
		//}
		//i++;
		//x22--;
		//y22--;
		//i = i == 170 ? 1 : i;
		//x22 = x22 < 0 ? 100 : x22;
		//y22 = y22 < 0 ? 100 : y22;

		//x22 = (x22 * 10 + 320 + i * 20) > 3840 ? 0 : x22;
		//y22 = (y22 * 10 + 180 + i * 10) > 1920 ? 0 : y22;


		//cv::Mat frame1(frame,cv::Rect(0+ x22 *10, 0+ y22 *10, 320+i* 20, 160+i*10));

		//cv::Mat Mat2 = frame1.clone();
		//pView->SetState(OCCUPIED);
		//resize(frame, frame, cv::Size(1200, 900), 0, 0);
		//pView->Show(Mat2);
		//Histograme(frame, pView1);
	    //HistCalc(frame, pView->GetIndex());
		Sleep(0);

		if (pView->IsState(ViewState::CLOSED)) {
			delete pView;
			//writer.release();
			break;
		} 
	}
	// the camera will be deinitialized automatically in VideoCapture destructor
	return 0;
}

int CloseCamera()
{
	Logger::Log1(Severity::INFO, "Invoke 'CloseCamera()'");
	return  0;
}

int FloatTest(void* num)
{
	Logger::Log1(Severity::INFO, "Invoke 'CloseCamera()%f'", num);
	return  0;
}

int ViewWindow(int type,int window,int mode1,int mode2)
{
	Logger::Log1(Severity::INFO, "Invoke type=%d,window=%d,mode1=%d,mode2=%d'", type, window, mode1, mode2);
	return  0;
}

int CaptureImage(int mode, void** image)
{

	Logger::Log2(Severity::INFO, L"Invoke 'CaptureImage(mode: %d, <out> image: %p)'", mode, image);
	char* buff = (char*)malloc(20);
	if (buff != NULL) {
		struct tm t;
		time_t now = time(NULL);
		localtime_s(&t, &now);
		sprintf_s(buff, 20, "Image: %d:%d:%d", t.tm_hour, t.tm_min, t.tm_sec);
		*image = buff;
	}

	return  0;
}

int SetProperty(std::string name, std::string value)
{
	
	Logger::Log2(Severity::INFO, L"Invoke 'SetProperty(mode: %s, image: %s)'", name, value);
	return  0;
}

int LoadProperty(std::string xml)
{
	Logger::Log2(Severity::INFO, L"Invoke 'LoadProperty(xml: %s)'", xml);
	return  0;
}

int SaveSettings()
{
	Logger::Log1(Severity::INFO, "Invoke 'SaveSettings()'");
	return  0;
}


string UtfToGbk(string strValue)
{
	int len = MultiByteToWideChar(CP_UTF8, 0, strValue.c_str(), -1, NULL, 0);
	wchar_t* wstr = new wchar_t[len + 1];
	memset(wstr, 0, len + 1);
	MultiByteToWideChar(CP_UTF8, 0, strValue.c_str(), -1, wstr, len);
	len = WideCharToMultiByte(CP_ACP, 0, wstr, -1, NULL, 0, NULL, NULL);
	char* str = new char[len + 1];
	memset(str, 0, len + 1);
	WideCharToMultiByte(CP_ACP, 0, wstr, -1, str, len, NULL, NULL);
	if (wstr) delete[] wstr;
	return string(str);
}


string UtfToString(string strValue)

{
	int nwLen = ::MultiByteToWideChar(CP_ACP, 0, strValue.c_str(), -1, NULL, 0);
	wchar_t* pwBuf = new wchar_t[nwLen + 1];//加上末尾'\0'
	ZeroMemory(pwBuf, nwLen * 2 + 2);
	::MultiByteToWideChar(CP_ACP, 0, strValue.c_str(), strValue.length(), pwBuf, nwLen);
	int nLen = ::WideCharToMultiByte(CP_UTF8, 0, pwBuf, -1, NULL, NULL, NULL, NULL);
	char* pBuf = new char[nLen + 1];
	ZeroMemory(pBuf, nLen + 1);
	::WideCharToMultiByte(CP_UTF8, 0, pwBuf, nwLen, pBuf, nLen, NULL, NULL);
	std::string retStr(pBuf);
	delete[]pwBuf;
	delete[]pBuf;
	pwBuf = NULL;
	pBuf = NULL;
	return retStr;
}
string StringToUtf(string strValue)
{
	int nwLen = MultiByteToWideChar(CP_UTF8, 0, strValue.c_str(), -1, NULL, 0);
	wchar_t* pwBuf = new wchar_t[nwLen + 1];//加上末尾'\0'
	memset(pwBuf, 0, nwLen * 2 + 2);
	MultiByteToWideChar(CP_UTF8, 0, strValue.c_str(), strValue.length(), pwBuf, nwLen);
	int nLen = WideCharToMultiByte(CP_UTF7, 0, pwBuf, -1, NULL, NULL, NULL, NULL);
	char* pBuf = new char[nLen + 1];
	memset(pBuf, 0, nLen + 1);
	WideCharToMultiByte(CP_ACP, 0, pwBuf, nwLen, pBuf, nLen, NULL, NULL);
	std::string retStr = pBuf;
	delete[]pBuf;
	delete[]pwBuf;
	return retStr;
}

int CameraSettingCam(Cam &cam) 
{
	Logger::Log1(Severity::INFO, cam.ip);
	strcpy(cam.ip, "123223");
	cam.a = 100;
	printf(cam.ip);
	printf("\n");
	printf(cam.login);
	printf("\n");
	printf(cam.name);
	printf("\n");
	printf(cam.pass);
	return 0;
}

int a = 0;

int CameraSettingExposureIni(char** result_data, int len)
{
	char* str = new char[len];
	for (size_t i = 0; i < len; i++)
	{
		strcpy(&str[i], "1");
		str[i] = a;
	}
	*result_data = str;

	int b[10] = { 1,2,3,4,5,6,7,7,8,9 };
	std::string sTemp;
	char* cTemp = new char[10];

	for (int i = 0; i < 10; i++)
	{
		*cTemp = 48 + b[i];
		cTemp++; 
	}

	*result_data = cTemp;

	a = 0;
	//name = StringToUtf(name);
	Logger::Log2(Severity::INFO, L"c+++++++++++++++ %d)'", a);
	a++;
	return  0;
}
int getImagePathList(std::string folder, std::vector<cv::String>& imagePathList)
{
	//search all the image in a folder
	cv::glob(folder, imagePathList);
	return 0;
}

string UTF8ToGB(const char* str)
{
	string result;
	WCHAR* strSrc;
	LPSTR szRes;

	int i = MultiByteToWideChar(CP_UTF8, 0, str, -1, NULL, 0);
	strSrc = new WCHAR[i + 1];
	MultiByteToWideChar(CP_UTF8, 0, str, -1, strSrc, i);

	i = WideCharToMultiByte(CP_ACP, 0, strSrc, -1, NULL, 0, NULL, NULL);
	szRes = new CHAR[i + 1];
	WideCharToMultiByte(CP_ACP, 0, strSrc, -1, szRes, i, NULL, NULL);

	result = szRes;
	delete[] strSrc;
	delete[] szRes;
	return result;
}



int OpenSerial(char* FullPath)	
{
	//std::wstring fp = StringUtils::string2wstring(FullPath);
	//std::wstring fp = StringUtils::Multi2Utf8(FullPath);

	//Logger::Log1(Severity::INFO, FullPath);
	std::string str = UTF8ToGB(FullPath);
	const char* bbb = str.c_str();
	Logger::Log1(Severity::INFO, str);

	return  0;
}


std::map<std::string, std::string> CameraCalibrationList = {
	{"HardTrigger","相机触发校准"}
};
std::map<std::string, std::string> StageCalibrationList = {
	{"Integrity","Integrity"},
	{"Magnification","放大倍数"},
	{"Backhaul","回城校准" },
	{"Zero","零点校准"}
};

std::map<std::string, std::string> LightCalibrationList = {
	{"CenterPoint","CenterPoint"},
	{"Integrity","Integrity"},
	{"WhiteBalance","WhiteBalance"},
	{"RadiusOfLightSource","光源明场暗场半径校准"}
};
std::map<std::string, std::string> InitializeCalibrationList = {
	{"BackgroundCorrection","背景矫正"},
	{"TransferFunction","正在计算函数"}
};


int HardwareCalibrationInit(int HardwareCalibrationType) {
	json CalibrationInit;

	json j2;
	switch (HardwareCalibrationType)
	{
	case Wizard:
	case All:
		for (auto& it : CameraCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Camera";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		for (auto &it : StageCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Stage";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		for (auto& it : LightCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Light";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		for (auto& it : InitializeCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Initialize";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		break;
	case Camera:
		for (auto& it : CameraCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Camera";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		break;
	case Stage:
		for (auto& it : StageCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Stage";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		break;
	case Light:
		for (auto& it : LightCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Light";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		break;
	case Initialize:
		for (auto& it : InitializeCalibrationList)
		{
			json j1;
			j1["Hardware"] = "Initialize";
			j1["Type"] = it.first;
			j1["Name"] = it.second;
			j2.push_back(j1);
		}
		break;
	default:
		break;
	}

	CalibrationInit["json"]=j2.dump().c_str();
	Event::Trigger("SetHardwareCalibrationContent", &CalibrationInit);
	return 0;
}

int bbb = 0;
int HardwareCalibration(char* jsonchar) {
	string aa = StringUtils::Multi2Utf8(jsonchar);
	json j1  = json::parse(aa);
	string Hardware = j1["Hardware"];
	string Type = j1["Type"];
	bbb++;
	json j5;
	j5["ResultCode"] = "0";
	j5["Msg"] = Hardware+":" + Type;
	//if (bbb == 10) {
	//	j5["ResultCode"] = "-1";
	//}
	

	Sleep(1000);

	Event::Trigger("HardwareCalibrationState", &j5);



	return 0;
}

CAMERA_API int CameraSettingResolution(char* mode)
{
	Logger::Log1(Severity::INFO, mode);

	return 0;
}

CAMERA_API int Read_img(char* FilePath)
{
	Logger::Log1(Severity::INFO, FilePath);
	cv::Mat  file = cv::imread(FilePath);
	LambdaView* view = LambdaView::GetIdleOrNew();
	view->Show(file);
	return 0;
}


int SleepTest() {
	Sleep(3000);
	//ssss = true;
	return  0;
}
#include <fstream> 
#include <iostream>
#include <string>
#include <imgproc/types_c.h>


struct Cellinfo
{
	int ID;
	double PointX;
	double PointY;
	double Areas;
	double Perimeter;
	double Roundness;
};


int test() {

	Cellinfo Cellinfos{ 1,1,1,2222,4444,5555 };

	Event::Trigger("CellinfoTest", &Cellinfos);
	return 0;
}

CAMERA_API int GrifExportAs(char* GrifExportAsJson)
{
	std::string json = StringUtils::Multi2Utf8(GrifExportAsJson);


	return 0;
}

bool IsCameraConnection = false;
bool IsStageConnection = true;
bool IsLightConnection = false;
int VideoTest() {
	test();
	IsCameraConnection = !IsCameraConnection;
	IsStageConnection = !IsStageConnection;
	IsLightConnection = !IsLightConnection;
	json j3;
	j3["IsCameraConnection"] = (int)IsCameraConnection;
	j3["IsStageConnection"] = (int)IsStageConnection;
	j3["IsLightConnection"] = IsLightConnection;
	Event::Trigger("LambdaNotifyPropertyChanged",&j3);
	//Event::Trigger("STAGE_INI_CLOSE");


	//PlayFilm("C:\\Users\\Chen\\Desktop\\2.webm");


	//std::vector<Cellinfo> Cellinfos;

	//Cellinfos.push_back({ 1,"ssss",2222,4444,5555 });
	//Cellinfos.push_back({ 2,"ssss",2222,4444,5555 });

	//json j2;
	//for (size_t i = 0; i < Cellinfos.size(); i++)
	//{
	//	json cellinfo;
	//	cellinfo["Name"] = Cellinfos[i].Name;

	//	cellinfo["ID"] = Cellinfos[i].ID;
	//	cellinfo["Areas"] = Cellinfos[i].Areas;
	//	cellinfo["Perimere"] = Cellinfos[i].Perimere;
	//	cellinfo["Centroid"] = Cellinfos[i].Centroid;
	//	j2[i] = cellinfo;
	//}
	//json j3;
	//j3["cellinfos"] = j2.dump().c_str();
	//Event::Trigger("SET_CELL_INFOS",&j3);

	//std::ofstream OsWrite("1.txt", std::ofstream::app);
	//OsWrite << j2.dump().c_str();
	//OsWrite << std::endl;
	//OsWrite.close();



	//cv::Mat Input = cv::imread("11");

	//Mat input1;
	//cv::Mat input2;

	//cv::cvtColor(Input, input1, CV_RGB2GRAY);
	//input1.convertTo(input2, CV_32FC1, 1.0 / 255.0);
	// 



	PlayFilm("C:\\Users\\Chen\\Desktop\\1.mp4");


	return 0;
}
int StageSettingReset() {
	Sleep(3000);
	Event::Trigger("STAGE_INI_CLOSE");
	return 0;
}


CAMERA_API int FloatTest(float num)
{
	return 0;
}


int MatShow(cv::Mat* Test) {
	//VideoTest();
	resize(*Test, *Test, cv::Size(300, 300), 0, 0);
	return 0;
}

int MatShow1(cv::Mat* Test ,int num) {
	//resize(*Test, *Test, cv::Size(222, 300), 0, 0);

	return 0;
}

double x = 111.1111;
double y = 111.1111;



int  test_double(double exposure)
{
	Logger::Log2(Severity::INFO, L"测试: Test8(x=%.8lf)", exposure);
	return 0;
}
int CameraSettingFlipV(bool bflip) {
	Logger::Log2(Severity::INFO, L"CameraSettingFlipV bflip =%b", bflip);
	return 0;
}
int CameraSettingFlipH(bool bflip) {
	Logger::Log2(Severity::INFO, L"CameraSettingFlipH bflip =%b", bflip);
	return 0;
}

int CameraSettingExposure(int mode,double exposure)
{
	x++;
	y++;

	json j;
	j["x"] = std::to_string(x);
	j["y"] = std::to_string(y);
	Event::Trigger("UPDATE_STAGE_MOVE", &j);
	a++;
	//std::vector<Cellinfo> Cellinfos;

	//Cellinfos.push_back({ 1,1,1,2222,4444,5555 });
	//Cellinfos.push_back({ 1,2,1,2222,4444,5555 });

	//Event::Trigger("CellinfoTest", &Cellinfos);
	


	////uchar b[] = { 1, 2, 3, 4, 5 };

	Logger::Log2(Severity::INFO, L"Invoke 'CameraSettingExposure(exposure: %f)'", exposure);

	//json j;
	//j["createTime"] = "中文";
	//Event::Trigger("UPDATE_STATUS", &j);


	//HistCalc(img2,0);
	json j1;

	//采集次数
	j1["CollectionTimes"] = "66";
	//采集层数
	j1["CollectionLayers"] = "5";
	//采集点个数
	j1["CollectionPoints"] = "100ddddddddddd";
	//成像模式数
	j1["ViewModeCounts"] = "4";
	//荧光通道数
	j1["FluorescenceChannels"] = "2";
	//图像尺寸
	j1["ImageSize"] = "1280×960ddddddddddd (5.2MB)";
	//图像总数
	j1["ImageNums"] = "66";
	//存储空间
	j1["Storage"] = "1.546G";
	//全部采集耗时
	j1["AllCollectionTime"] = "23h  ddddddddd 0m 0.002s";
	//相机工作时长
	j1["CameraWorkingTime"] = "0h 0m dddddddd0.002s";








	Event::Trigger("UPDATE_MUL_SUMMARY", &j1);
	json j3;
	j3["window"] =0;
	j3["flag"] = 0;
	Event::Trigger("HistogramImageShow", &j3);
	return  0;
}

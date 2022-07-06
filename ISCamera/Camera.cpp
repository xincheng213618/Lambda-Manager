#pragma warning(disable:26812 26495 26451 6294 6201)

#include "pch.h"
#include "Camera.h"
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
Mat histnew(Mat& scr, int maxloc, double sumhist, int histmax, int histmin)
{
	Mat hist = Mat::zeros(1, 256, CV_32FC1);
	float* ptr = scr.ptr<float>(0);
	float* hptr = hist.ptr<float>(0);
	hptr[maxloc] = ptr[maxloc];
	float th = ptr[maxloc];

	for (int i = maxloc; i < scr.cols - 1; i++)
	{
		int minloc = 2 * maxloc - i - 1;
		float minval;
		if (minloc < 0)
		{
			minloc = 0;
			minval = 0;
		}
		else {
			minval = ptr[2 * maxloc - i - 1];
		}
		th = th + ptr[i + 1] + minval;
		if (th / sumhist < 0.99)
		{
			hptr[i + 1] = ptr[i + 1];
			hptr[minloc] = ptr[minloc];
		}
		else
		{
			histmax = i;
			histmin = minloc + 1;
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

	Mat hist = histnew(phaseMat_hist, maxloc, sumhist, histmax, histmin);
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
		cap.read(frame);
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

int PlayFilm(std::string fileName) {
	cv::Mat frame;
	cv::VideoCapture cap = cv::VideoCapture(fileName);

	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open camera");
		return -1;
	}
	LambdaView* pView = LambdaView::GetIdleOrNew();
	LambdaView* pView1 = LambdaView::GetRegistered(-pView->GetIndex()-1);

	std::wstring&& s = StringUtils::string2wstring(fileName);
	int count = 0;

	for (;;)
	{
		// wait for a new frame from camera and store it into 'frame'
		if (ssss) {
			ssss = false;
			pView->Close();
			break;

		}
		 cap >> frame;
		cap.read(frame);
		// check if we succeeded
		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
		}
		pView->Show(frame);
		//Histograme(frame, pView1);
		//HistCalc(frame, pView->GetIndex());
		Sleep(0);

		if (pView->IsState(ViewState::CLOSED)) {
			delete pView;
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

int FloatTest(float num)
{
	Logger::Log1(Severity::INFO, "Invoke 'CloseCamera()%f'", num);
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

int OpenSerial(char* FullPath)	
{
	//std::wstring fp = StringUtils::string2wstring(FullPath);
	Logger::Log1(Severity::INFO, FullPath);
	return  0;
}


int SleepTest() {
	//Sleep(3000);
	ssss = true;
	return  0;
}

int VideoTest() {
	PlayFilm("C:\\Users\\Chen\\Desktop\\1.mp4");
	return 0;
}


int MatShow(cv::Mat* Test) {
	//VideoTest();
	resize(*Test, *Test, cv::Size(300, 300), 0, 0);
	return 0;
}

int MatShow1(cv::Mat* Test ,int num) {
	resize(*Test, *Test, cv::Size(222, 300), 0, 0);

	return 0;
}

double x = 111.1111;
double y = 111.1111;
int CameraSettingExposure(int mode,double exposure)
{
	json j;
	j["x"] = std::to_string(x);
	j["y"] = std::to_string(y);
	Event::Trigger("UPDATE_STAGE_MOVE", &j);

	//int a = OpenLE5(1, 2, 3, 34);
	//Logger::Log2(Severity::INFO, L"C+++++++ %d)'", a);

	a++;
	//std::string name = "a中文";
	//name = StringToUtf(name);
	//Logger::Log2(Severity::INFO, L"c+++++++++++++++ %d)'", a);
	//uchar b[] = { 1,2,3,4,5 };

	//Event::Trigger("TestDataEvent", b, sizeof(b) / sizeof(b[0]));

	cv::Mat img1;
	img1 = cv::imread("cat.jpg");
	//LambdaView* pView = LambdaView::GetIdleOrNew();
	//pView->Show(img1);
	cv::Mat img2;
	resize(img1, img2, cv::Size(300, 300), 0, 0);
	Event::Dispatch("MatShow222",(&img2));

	////uchar b[] = { 1, 2, 3, 4, 5 };

	Logger::Log2(Severity::INFO, L"Invoke 'CameraSettingExposure(exposure: %f)'", exposure);

	//json j;
	//j["createTime"] = "中文";
	//Event::Trigger("UPDATE_STATUS", &j);

	std::thread t([=]() {
		Event::Trigger("TestDataEvent", img2.data, img2.channels() * img2.cols * img2.rows / sizeof(uchar));
		});
	t.detach();
	//



	//HistCalc(img2,0);


	json j1;

	//采集次数
	j1["CollectionTimes"] = "2";
	//采集层数
	j1["CollectionLayers"] = "5";
	//采集点个数
	j1["CollectionPoints"] = "100";
	//成像模式数
	j1["ViewModeCounts"] = "4";
	//荧光通道数
	j1["FluorescenceChannels"] = "2";
	//图像尺寸
	j1["ImageSize"] = "1280×960 (5.2MB)";
	//图像总数
	j1["ImageNums"] = "1260";
	//存储空间
	j1["Storage"] = "1.546G";
	//全部采集耗时
	j1["AllCollectionTime"] = "23h 0m 0.002s";
	//相机工作时长
	j1["CameraWorkingTime"] = "0h 0m 0.002s";

	
	Event::Trigger("UpdateMulSummary", &j1);

	json j3;
	j3["window"] =0;
	j3["flag"] = 0;
	Event::Trigger("HistogramImageShow", &j3);

	
	return  0;
}

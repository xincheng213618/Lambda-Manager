#include "pch.h"
#include "common.h"




LogCallBack1 logCallBack1 = NULL;
LogCallBack2 logCallBack2 = NULL;;
GetArraySize getArraySize = NULL;;
InitialFrame initialFrame = NULL;;
UpdateFrame updateFrame = NULL;;
CloseImageView closeImageView = NULL;;
Services startService = NULL;;
Services StopService = NULL;;
ScheduleEvent scheduleEvent = NULL;;
CallHandlerRaise callHandlerRaise = NULL;;

int PlayFilm(std::string fileName) {
	cv::Mat frame;
	cv::VideoCapture cap = cv::VideoCapture(fileName);

	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open camera");
		return -1;
	}
	LambdaView* pView = LambdaView::GetIdleOrNew();
	int count = 0;

	for (;;)
	{
		// wait for a new frame from camera and store it into 'frame'
		cap.read(frame);
		// check if we succeeded
		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
		}
		pView->Show(frame);
		if (pView->IsState(ViewState::CLOSED)) {
			delete pView;
			break;
		}
	}
	// the camera will be deinitialized automatically in VideoCapture destructor
	return 0;
}

void Initialize() {
	double exposure = 2222322.11111;
	int sss = 222222;
	Logger::Log1(Severity::INFO, "Invoke 'OpenLaser(%f)%d'", exposure, sss);
	//问题1 log2 的写法问题；
	Logger::Log2(Severity::INFO, L"Invoke 'CameraSettingExposure(exposure: %f)%d'", exposure,sss);
	//Service::Start("1111");
	//cv::Mat img1;
	//img1 = cv::imread("D:\\0044.jpg");
	//LambdaView* pView = LambdaView::GetIdleOrNew();
	//pView->Show(img1);

	//PlayFilm("C:\\Users\\Chen\\Desktop\\1.mp4");

}

void SetHandler(void* pRoutineHandler, int handlerType) {

	if (handlerType == 0)
	{
		logCallBack1 = (LogCallBack1)pRoutineHandler;
	}
	else if (handlerType == 1)
	{
		logCallBack2 = (LogCallBack2)pRoutineHandler;
	}
	else if (handlerType == 2)
	{
		getArraySize = (GetArraySize)pRoutineHandler;
	}
	else if (handlerType == 3)
	{
		initialFrame = (InitialFrame)pRoutineHandler;
	}
	else if (handlerType == 4)
	{
		updateFrame = (UpdateFrame)pRoutineHandler;
	}
	else if (handlerType == 9)
	{
		closeImageView = (CloseImageView)pRoutineHandler;
	}
	else if (handlerType == 5)
	{
		startService = (Services)pRoutineHandler;
	}
	else if (handlerType == 6)
	{
		StopService = (Services)pRoutineHandler;
	}
	else if (handlerType == 7)
	{
		scheduleEvent = (ScheduleEvent)pRoutineHandler;
	}
	else if (handlerType == 8)
	{
		callHandlerRaise = (CallHandlerRaise)pRoutineHandler;
	}

}


CallBack1 callBack1 = NULL;
CallBack2 callBack2 = NULL;
CallBack3 callBack3 = NULL;
CallBack4 callBack4 = NULL;
CallBack5 callBack5 = NULL;
CallBack6 callBack6 = NULL;
CallBack7 callBack7 = NULL;
CallBack8 callBack8 = NULL;

void SetRoutineHandler(void* pRoutineHandler, int argType) 
{
	//void 是0
	if (argType == 0)
	{
		callBack1 = (CallBack1)pRoutineHandler;
	}
	//1是主要用的
	else if (argType == 1) 
	{
		callBack3 = (CallBack3)pRoutineHandler;
	}
	else if (argType == 2)
	{
		callBack2 = (CallBack2)pRoutineHandler;
	}
	else if (argType == 3)
	{
		callBack4 = (CallBack3)pRoutineHandler;
	}
	else if (argType == 4)
	{
		callBack5 = (CallBack5)pRoutineHandler;
	}
	else if (argType == 5)
	{
		callBack6 = (CallBack6)pRoutineHandler;
	}
	else if (argType == 6)
	{
		callBack7 = (CallBack7)pRoutineHandler;
	}
	else if (argType == 7)
	{
		callBack8 = (CallBack8)pRoutineHandler;
	}
}










LIB_API void ApplicationExit()
{
}



Service::Service()
{
}

Service::~Service()
{

}

void Service::Start(const char* serviceName)
{
	startService(serviceName);
}
void Service::Stop(const char* serviceName)
{
	startService(serviceName);

}


void Trace(LPCTSTR sFormat, ...)
{

}


//以下内容不在使用
void SetMessageHandler1(LogCallBack1 fn)
{
	logCallBack1 = fn;
}

void SetMessageHandler2(LogCallBack2 fn)
{
	logCallBack2 = fn;
}

SetCppSize setCppSize;

void GetCppSizeInfo(SetCppSize fn)
{
	setCppSize = fn;
}





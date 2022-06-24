#include "pch.h"
#include "common.h"
#include <chrono>
#include <thread>
//#include <libcron/Cron.h>


LogCallBack1 logCallBack1 = NULL;
LogCallBack2 logCallBack2 = NULL;
GetArraySize1 getArraySize = NULL;
InitialFrame initialFrame = NULL;
UpdateFrame updateFrame = NULL;
CloseImageView closeImageView = NULL;
Services startService = NULL;
Services StopService = NULL;
ScheduleEvent scheduleEvent = NULL;
CallHandlerRaise callHandlerRaise = NULL;

SetCppSize setCppSize =NULL;

//extern libcron::Cron<libcron::LocalClock, libcron::NullLock> cron22;


void GetCppSizeInfo(SetCppSize fn)
{
	setCppSize = fn;
}



void Initialize() {

	//const char* buffer = "long:8,unsigned long:8,long double:8";
	const char* buffer = "long:4,unsigned long:4,long int:4,long long:8,long double:8";
	setCppSize((char*)buffer);
}


LIB_API int GetArraySize(void* pArray)
{
	return getArraySize(pArray);
}

 extern std::list<void*> RaiseEventMark_map;

LIB_API int SetHandlerRaise(void* pArray) {

	RaiseEventMark_map.push_back(pArray);
	//callHandlerRaise(pArray);
	return 1;
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
		getArraySize = (GetArraySize1)pRoutineHandler;
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
	//void 转发
	if (argType == 0)
	{
		callBack1 = (CallBack1)pRoutineHandler;
	}
	//Json 转发
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




//以下内容不在使用
void SetMessageHandler1(LogCallBack1 fn)
{
	logCallBack1 = fn;
}

void SetMessageHandler2(LogCallBack2 fn)
{
	logCallBack2 = fn;
}






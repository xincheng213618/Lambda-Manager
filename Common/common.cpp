#include "pch.h"
#include "common.h"
#include "common1.h"
#include <chrono>
#include <thread>
//#include <libcron/Cron.h>


LogCallBack1 logCallBack1 = NULL;
LogCallBack2 logCallBack2 = NULL;
GetArraySize1 getArraySize = NULL;
InitialFrame initialFrame = NULL;
UpdateFrame updateFrame = NULL;
UpdateFrameRect  updateFrameRect = NULL;
CloseImageView closeImageView = NULL;
Services startService = NULL;
Services StopService = NULL;
ScheduleEvent scheduleEvent = NULL;
CallHandlerRaise callHandlerRaise = NULL;

CallbackSchedule callbackSchedule = NULL;
CallbackDelay callbackDelay = NULL;
CallbackSchedule2 callbackSchedule2 = NULL;
CallbackDelay2 callbackDelay2 = NULL;
CallbackStopSchedule callbackStopSchedule = NULL;
SetCppSize setCppSize =NULL;

void GetCppSizeInfo(SetCppSize fn)
{
	setCppSize = fn;
}

void Initialize() {
	const char* buffer = "long:4,unsigned long:4,long int:4,long long:8,long double:8";
	setCppSize((char*)buffer);
}


COMMON_API int GetArraySize(void* pArray)
{
	return getArraySize(pArray);
}

 extern std::list<void*> RaiseEventMark_map;

COMMON_API int SetHandlerRaise(void* pArray) {

	RaiseEventMark_map.push_back(pArray);
	return 1;
}




void SetHandler(void* pRoutineHandler, int handlerType) {

	switch (handlerType)
	{
	case 0:
		logCallBack1 = (LogCallBack1)pRoutineHandler;
		break;
	case 1:
		logCallBack2 = (LogCallBack2)pRoutineHandler;
		break;
	case 2:
		getArraySize = (GetArraySize1)pRoutineHandler;
		break;
	case 3:
		initialFrame = (InitialFrame)pRoutineHandler;
		break;
	case 4:
		updateFrame = (UpdateFrame)pRoutineHandler;
		break;
	case 5:
		updateFrameRect = (UpdateFrameRect)pRoutineHandler;
		break;
	case 10:
		closeImageView = (CloseImageView)pRoutineHandler;
		break;
	case 6:
		startService = (Services)pRoutineHandler;
		break;
	case 7:
		StopService = (Services)pRoutineHandler;
		break;
	case 8:
		scheduleEvent = (ScheduleEvent)pRoutineHandler;
		break;
	case 9:
		callHandlerRaise = (CallHandlerRaise)pRoutineHandler;
		break;
	case 11:
		callbackSchedule = (CallbackSchedule)pRoutineHandler;
		break;
	case 12:
		callbackDelay = (CallbackDelay)pRoutineHandler;
		break;
	case 13:
		callbackSchedule2 = (CallbackSchedule2)pRoutineHandler;
		break;
	case 14:
		callbackDelay2 = (CallbackDelay2)pRoutineHandler;
		break;
	case 15:
		callbackStopSchedule = (CallbackStopSchedule)pRoutineHandler;
		break;
	default:
		break;
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






 void ApplicationExit()
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







COMMON_API const char* Schedule(const char* cron, int times, Callback callback, Callback end)
{
	return callbackSchedule(cron,times, callback);
}
COMMON_API const char* Delay(int seconds, int times,Callback callback, Callback end)
{
	return callbackDelay(seconds, times,callback);
}

std::map<int, std::function<int()>> Schedule2_map;
std::map<int, std::function<int()>> Schedule2_End_map;

int i = 0;

COMMON_API const char* Schedule2(const char* cron, int times, std::function<int()> callback, std::function<int()> end)
{
	i++;
	Schedule2_map.insert(std::make_pair(i, callback));
	Schedule2_End_map.insert(std::make_pair(i, end));
	return callbackSchedule2(cron, times, i);
}



COMMON_API const char* Delay2(int seconds,int times, std::function<int()> callback, std::function<int()> end)
{
	i++;
	Schedule2_map.insert(std::make_pair(i, callback));
	Schedule2_End_map.insert(std::make_pair(i, end));
	return callbackDelay2(seconds, times, i);
}



COMMON_API void StopSchedule(const char* scheduleName)
{
	callbackStopSchedule(scheduleName);
}


COMMON_API void InvokeCallback(void* callback)
{
	((Callback)callback)();
}


COMMON_API void InvokeScheduleCallback(int id)
{
	bool IsDelay = id < 0;
	if (IsDelay)
		id = -id;
	auto it = Schedule2_map.find(id);
	if (it != Schedule2_map.end()) {
		it->second();
		if (IsDelay)
			Schedule2_map.erase(it);
	}
}

COMMON_API void InvokeScheduleEnd(int callBackEnd)
{
	auto it = Schedule2_End_map.find(callBackEnd);
	if (it != Schedule2_End_map.end()) {
			it->second();
	}
}


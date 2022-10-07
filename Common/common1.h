#pragma once

#ifdef COMMON_EXPORTS
#define COMMON_API __declspec(dllexport)
#else
#define COMMON_API __declspec(dllimport)
#endif

#include <string>
#include <map>
#include <wtypes.h>
#include <nlohmann/json.hpp>
#include <opencv2/core.hpp>


typedef void (__cdecl *Callback)();
typedef int (__cdecl *Callback1)();

typedef int (__cdecl *Callback2)(json*);
typedef int (__cdecl *Callback3)(const char*);
typedef int (__cdecl *Callback4)(std::map<std::string, json>*);
typedef int (__cdecl *Callback5)(void*);
typedef int (__cdecl *Callback6)(void*, void*);
typedef int (__cdecl *Callback7)(void*, void*, void*, void*);


typedef int(__cdecl* LogCallBack1)(int, char*);
typedef int(__cdecl* LogCallBack2)(int, wchar_t*);
typedef int(__cdecl* GetArraySize1)(void*);
typedef int(__cdecl* InitialFrame)(int, int, void*, int, int, int);
typedef int(__cdecl* UpdateFrame)(int, int, void*, int, int);
typedef int(__cdecl* UpdateFrameRect)(int, int, void*, int, int, int, int, int, int);

typedef void(__cdecl* CloseImageView)(int);
typedef void(__cdecl* Services)(const char*);

typedef void(__cdecl* ScheduleEvent)(char*, char*, char*);
typedef void(__cdecl* CallHandlerRaise)(void*);


typedef const char* (__cdecl* CallbackSchedule)(const char*, int, Callback);
typedef const char* (__cdecl* CallbackDelay)(int, int,Callback );
typedef const char* (__cdecl* CallbackSchedule2)(const char* , int , int);
typedef const char* (__cdecl* CallbackDelay2)(int, int, int);
typedef void(__cdecl* CallbackStopSchedule)(const char*);




typedef int(__cdecl* CallBack1)(int, void*);
typedef int(__cdecl* CallBack2)(int, void*, void*);
typedef int(__cdecl* CallBack3)(int, void*, void*);
typedef int(__cdecl* CallBack4)(int, void*, void*);
typedef int(__cdecl* CallBack5)(int, void*, void*);
typedef int(__cdecl* CallBack6)(int, void*, void*, void*);
typedef int(__cdecl* CallBack7)(int, void*, void*, void*, void*, void*);
typedef int(__cdecl* CallBack8)(int, void*, int, void*);


extern "C" COMMON_API void Initialize();

extern "C" COMMON_API void SetHandler(void* pRoutineHandler, int handlerType);

extern "C" COMMON_API void SetRoutineHandler(void* pRoutineHandler, int argType);

typedef void(__cdecl* SetCppSize)(void*);

extern "C" COMMON_API void GetCppSizeInfo(SetCppSize fn);

extern "C" COMMON_API void SetMessageHandler1(LogCallBack1 fn);

extern "C" COMMON_API void SetMessageHandler2(LogCallBack2 fn);

extern "C" COMMON_API int CallFunction(char* type, int argType, void* eventObject, void* sender);


extern "C" COMMON_API int GetArraySize(void* pArray);

extern "C" COMMON_API int SetHandlerRaise(void* pArray);



enum ArgumentType
{
	NO_ARGS,
	JSON_STRING,
	JSON_OBJECT,
	STL_MAP,
	POINTER,
	POINTER2,
	POINTER4
};



extern "C" COMMON_API void RegisterRoutineEvent(char * type, int rotineId, ArgumentType handlerType, int once);
extern "C" COMMON_API void RegisterFunctionEvent(char* type, void* fn1, ArgumentType handlerType, int once);





extern "C" COMMON_API void InvokeCallback(void* callBack);
extern "C" COMMON_API void InvokeScheduleCallback(int callBack);
extern "C" COMMON_API void InvokeScheduleEnd(int callBackEnd);



extern "C" COMMON_API const char* Schedule(const char* cron, int times, Callback callback, Callback end); //times<0 means forever
extern "C" COMMON_API const char* Schedule2(const char* cron, int times, std::function<int()> callback, std::function<int()> end); //times<0 means forever
extern "C" COMMON_API const char* Delay(int seconds, int times,Callback callback, Callback end);
extern "C" COMMON_API const char* Delay2(int seconds, int times, std::function<int()> callback, std::function<int()> end);
extern "C" COMMON_API void StopSchedule(const char* scheduleName);




extern "C" COMMON_API void Trace(LPCTSTR sFormat, ...);


extern "C" COMMON_API void ApplicationExit();


std::string ws2s(const std::wstring& input);
std::wstring s2ws(const std::string& input);


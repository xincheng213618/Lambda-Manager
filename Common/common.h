#pragma once

#ifdef COMMON_EXPORTS
#define LIB_API __declspec(dllexport)
#else
#define LIB_API __declspec(dllimport)
#endif

#ifndef LOG_LEVEL
#define LOG_LEVEL 0
#endif

#define MAX_VIEWS 100


#include "pch.h"
#include <string>
#include <map>
#include <wtypes.h>
#include <nlohmann/json.hpp>
#include <opencv2/core.hpp>


using json = nlohmann::json;

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


extern "C" LIB_API void Initialize();

extern "C" LIB_API void SetHandler(void* pRoutineHandler, int handlerType);

extern "C" LIB_API void SetRoutineHandler(void* pRoutineHandler, int argType);

typedef void(__cdecl* SetCppSize)(void*);

extern "C" LIB_API void GetCppSizeInfo(SetCppSize fn);

extern "C" LIB_API void SetMessageHandler1(LogCallBack1 fn);

extern "C" LIB_API void SetMessageHandler2(LogCallBack2 fn);

extern "C" LIB_API int CallFunction(char* type, int argType, void* eventObject, void* sender);


extern "C" LIB_API int GetArraySize(void* pArray);

extern "C" LIB_API int SetHandlerRaise(void* pArray);



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



extern "C" LIB_API void RegisterRoutineEvent(char * type, int rotineId, ArgumentType handlerType, int once);
extern "C" LIB_API void RegisterFunctionEvent(char* type, void* fn1, ArgumentType handlerType, int once);

enum class Severity {
	DEBUG, INFO, WARNING, WRONG, FATAL_ERROR
};

struct Message {
	Severity level;
	std::string message;
};





class LIB_API Logger {
public:
	Logger();
	~Logger();
	static void Log1(Severity severity, std::string message);
	static void Log1(Severity severity, LPCSTR pstrFormat, ...);
	static void Log2(Severity severity, LPCTSTR pstrFormat, ...);
};

class LIB_API Event {
public:
	Event();
	~Event();
	static void Trigger(std::string type);
	static void Trigger(std::string type, const json* event);
	static void Trigger(std::string type, const char* event);
	static void Trigger(std::string type, const std::map<std::string, json>* event);
	static void Trigger(std::string type, void* object);
	static void Trigger(std::string type, void* object1, void* object2);
	static void Trigger(std::string type, void* object1, void* object2, void* object3, void* object4);
	static void Trigger(std::string type, void* data, int size);

	static void Dispatch(std::string type);
	static void Dispatch(std::string type, const json* event);
	static void Dispatch(std::string type, const char* event);
	static void Dispatch(std::string type, const std::map<std::string, json>* event);
	static void Dispatch(std::string type, void* object);
	static void Dispatch(std::string type, void* object1, void* object2);
	static void Dispatch(std::string type, void* object1, void* object2, void* object3, void* object4);

	static void Schedule(std::string type, const char* cron, const char* event);

	static void On(std::string type, Callback1 callback, bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback2 callback, bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback3 callback, bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback4 callback, bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback5 callback, bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback6 callback, bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback7 callback, bool once); //callback return -1 to stop event propogation

};






extern "C" LIB_API void InvokeCallback(void* callBack);
extern "C" LIB_API void InvokeScheduleCallback(int callBack);
extern "C" LIB_API void InvokeScheduleEnd(int callBackEnd);



extern "C" LIB_API const char* Schedule(const char* cron, int times, Callback callback, Callback end); //times<0 means forever
extern "C" LIB_API const char* Schedule2(const char* cron, int times, std::function<int()> callback, std::function<int()> end); //times<0 means forever
extern "C" LIB_API const char* Delay(int seconds, int times,Callback callback, Callback end);
extern "C" LIB_API const char* Delay2(int seconds, int times, std::function<int()> callback, std::function<int()> end);
extern "C" LIB_API void StopSchedule(const char* scheduleName);





enum ViewState {
	UNINITIALIZED, OCCUPIED, RUNING, CLOSED
};


class LIB_API LambdaView {
private:
	int index; //index of visual window
	int index2; //index of registered view
	int flag = 0; //view state

	LambdaView(bool registered);
public:
	~LambdaView();
	void Show(cv::Mat mat);
	void Show(cv::Mat mat, size_t left, size_t right, size_t width, size_t height);

	void Close();
	ViewState GetState();
	void SetState(ViewState state);
	bool IsState(ViewState state);
	int GetIndex();

	static LambdaView* GetIdleOrNew() {
		LambdaView* instance;
		instance = new LambdaView(false);
		return instance;
	}
	static LambdaView* GetRegistered(int index);
};

class LIB_API Service {
public:
	Service();
	~Service();
	static void Start(const char* serviceName);
	static void Stop(const char* serviceName);
};



extern "C" LIB_API void Trace(LPCTSTR sFormat, ...);


class LIB_API StringUtils {
public:
	static std::string wstring2string(const std::wstring& wstr);
	static std::wstring string2wstring(const std::string& str);

	static wchar_t* Multi2WideByte(const char* p);
	static char* Wide2MultiByte(const wchar_t* p);
};



extern "C" LIB_API void ApplicationExit();


std::string ws2s(const std::wstring& input);
std::wstring s2ws(const std::string& input);
std::string Chartostring(char* cha);



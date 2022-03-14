/*
* this library is implemented for Windows platform, if needing to support cross-platform exporting class need to check
* for cross-platform interoperation see also https://blog.csdn.net/weixin_37937630/article/details/80066376
*/
#pragma once
#pragma warning(disable:26812 26495 26451 6294 6201)

#include <string>
#include <map>
#include <wtypes.h>
#include <nlohmann/json.hpp>
#include <opencv2/core.hpp>

using json = nlohmann::json;

#ifdef COMMON_EXPORTS
#define COMMON_API __declspec(dllexport)
#else
#define COMMON_API __declspec(dllimport)
#endif

#ifndef LOG_LEVEL
#define LOG_LEVEL 0
#endif

#define MAX_VIEWS 100

DECLARE_HANDLE(HIMAGE);
typedef int (*Callback1)();
typedef int (*Callback2)(json*);
typedef int (*Callback3)(const char*);
typedef int (*Callback4)(std::map<std::string, json>*);
typedef int (*Callback5)(void*);
typedef int (*Callback6)(void*, void*);
typedef int (*Callback7)(void*, void*, void*, void*);

enum class Severity {
	DEBUG, INFO, WARNING, WRONG, FATAL_ERROR
};

struct Message {
	Severity level;
	std::string message;
};

class COMMON_API Logger {
public:
	Logger();
	~Logger();
	static void Log1(Severity severity, std::string message);
	static void Log2(Severity severity, LPCTSTR pstrFormat, ...);
};

class COMMON_API Event {
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

	static void Dispatch(std::string type);
	static void Dispatch(std::string type, const json* event);
	static void Dispatch(std::string type, const char* event);
	static void Dispatch(std::string type, const std::map<std::string, json>* event);
	static void Dispatch(std::string type, void* object);
	static void Dispatch(std::string type, void* object1, void* object2);
	static void Dispatch(std::string type, void* object1, void* object2, void* object3, void* object4);

	static void Schedule(std::string type, const char* cron, const char* event);

	static void On(std::string type, Callback1 callback,bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback2 callback,bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback3 callback,bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback4 callback,bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback5 callback,bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback6 callback,bool once); //callback return -1 to stop event propogation
	static void On(std::string type, Callback7 callback,bool once); //callback return -1 to stop event propogation

};

enum ViewState {
	UNINITIALIZED, OCCUPIED, RUNING, CLOSED
};

class COMMON_API LambdaView {
private:
	int index; //index of visual window
	int flag = 0; //0: initial, 1: initialized, 2: closed

	LambdaView();

public:
	~LambdaView();
	void Show(cv::Mat mat);
	ViewState GetState();
	void SetState(ViewState state);
	bool IsState(ViewState state);
	int GetIndex();

	static LambdaView* GetIdleOrNew();
};

class COMMON_API Service {
public:
	Service();
	~Service();
	static void Start(const char* serviceName);
	static void Stop(const char* serviceName);
};

extern "C" COMMON_API int GetArraySize(void* pArray);

class COMMON_API StringUtils {
public:
	static std::string wstring2string(const std::wstring& wstr);
	static std::wstring string2wstring(const std::string& str);

	static wchar_t* Multi2WideByte(const char* p);
	static char* Wide2MultiByte(const wchar_t* p);
};

extern "C" COMMON_API void Trace(LPCTSTR sFormat, ...);

#include "pch.h"
#include "common.h"

extern CallBack1 callBack1;
extern CallBack2 callBack2;
extern CallBack3 callBack3;
extern CallBack4 callBack4;
extern CallBack5 callBack5;
extern CallBack6 callBack6;
extern CallBack7 callBack7;
extern CallBack8 callBack8;



std::map<std::string, int> m_map;
std::map<std::string, Callback1> Callback1_map;
std::map<std::string, Callback2> Callback2_map;
std::map<std::string, Callback3> Callback3_map;
std::map<std::string, Callback4> Callback4_map;
std::map<std::string, Callback5> Callback5_map;
std::map<std::string, Callback6> Callback6_map;
std::map<std::string, Callback7> Callback7_map;


LIB_API void RegisterRoutineEvent(char* type, int rotineId, ArgumentType handlerType, int once)
{
	m_map.insert(std::make_pair(Chartostring(type), rotineId));
}

LIB_API void RegisterFunctionEvent(char* type, void* fn1, ArgumentType handlerType, int once)
{
	//m_map.insert(std::make_pair(Chartostring(type), rotineId));
	Callback1_map.insert(std::make_pair(Chartostring(type),(Callback1)fn1));

}


void CallFunction(char* type, int argType, void* eventObject, void* sender)
{
	auto it = m_map.find(Chartostring(type));
	if (it != m_map.end()) {
		if (argType == 0) {
			callBack1(it->second, sender);
		}
		if (argType == 1) {
			callBack3(it->second, eventObject, sender);
		}
	}

	auto it2 = Callback1_map.find(type);
	if (it2 != Callback1_map.end()) {
		(it2->second)();
	}
}

Event::Event()
{

}

Event::~Event()
{
}


void Event::Trigger(std::string type)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack1(it->second, NULL);
	}
	auto it2 = Callback1_map.find(type);
	if (it2 != Callback1_map.end()) {
		(it2->second)();
	}
}

void Event::Trigger(std::string type, const json* event)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack3(it->second, (void*)event, NULL);
	}
	auto it2 = Callback2_map.find(type);
	if (it2 != Callback2_map.end()) {
		(it2->second)((json*)event);
	}
}

void Event::Trigger(std::string type, const char* event)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack2(it->second, (void*)event, NULL);
	}
	auto it2 = Callback3_map.find(type);
	if (it2 != Callback3_map.end()) {
		(it2->second)((char*)event);
	}

}

void Event::Trigger(std::string type, const std::map<std::string, json>* event)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack3(it->second, (void*)event, NULL);
	}
	auto it2 = Callback4_map.find(type);
	if (it2 != Callback4_map.end()) {
		(it2->second)((std::map<std::string, json>*)event);
	}
}

void Event::Trigger(std::string type, void* object)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack5(it->second, object, NULL);
	}

	auto it2 = Callback5_map.find(type);
	if (it2 != Callback5_map.end()) {
		(it2->second)(object);
	}
}

void Event::Trigger(std::string type, void* object1, void* object2)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack6(it->second, object1, object2, NULL);
	}
	auto it2 = Callback6_map.find(type);
	if (it2 != Callback6_map.end()) {
		(it2->second)(object1, object2);
	}
}

void Event::Trigger(std::string type, void* object1, void* object2, void* object3, void* object4)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack7(it->second, object1, object2, object3, object4, NULL);
		return;
	}
	auto it2 = Callback7_map.find(type);
	if (it2 != Callback7_map.end()) {
		(it2->second)(object1, object2, object3, object4);
	}
}

void Event::Trigger(std::string type, void* data, int size)
{
	auto it = m_map.find(type);
	if (it != m_map.end()) {
		callBack8(it->second, data, size, NULL);
	}
}

void Event::Dispatch(std::string type)
{
	std::thread t([=]() {
		Event::Trigger(type);
		});
	t.detach();
}

void Event::Dispatch(std::string type, const json* event)
{
	std::thread t([=]() {
		Event::Trigger(type, event);
		});
	t.detach();
}

void Event::Dispatch(std::string type, const char* event)
{
	std::thread t([=]() {
		Event::Trigger(type, event);
		});
	t.detach();
}

void Event::Dispatch(std::string type, const std::map<std::string, json>* event)
{
	std::thread t([=]() {
		Event::Trigger(type, event);
		});
	t.detach();
}

void Event::Dispatch(std::string type, void* object)
{
	std::thread t([=]() {
		Event::Trigger(type, object);
		});
	t.detach();
}

void Event::Dispatch(std::string type, void* object1, void* object2)
{
	std::thread t([=]() {
		Event::Trigger(type, object1, object2);
		});
	t.detach();
}

void Event::Dispatch(std::string type, void* object1, void* object2, void* object3, void* object4)
{
	std::thread t([=]() {
		Event::Trigger(type, object1, object2, object3, object4);
		});   
	t.detach();
}

void Event::Schedule(std::string type, const char* cron, const char* event)
{

}

void Event::On(std::string type, Callback1 callback, bool once)
{
	Callback1_map.insert(std::make_pair(type, callback));
}

void Event::On(std::string type, Callback2 callback, bool once)
{
	Callback2_map.insert(std::make_pair(type, callback));

}

void Event::On(std::string type, Callback3 callback, bool once)
{
	Callback3_map.insert(std::make_pair(type, callback));
}

void Event::On(std::string type, Callback4 callback, bool once)
{
	Callback4_map.insert(std::make_pair(type, callback));
}

void Event::On(std::string type, Callback5 callback, bool once)
{
	Callback5_map.insert(std::make_pair(type, callback));
}

void Event::On(std::string type, Callback6 callback, bool once)
{
	Callback6_map.insert(std::make_pair(type, callback));
}

void Event::On(std::string type, Callback7 callback, bool once)
{
	Callback7_map.insert(std::make_pair(type, callback));
}
#include "pch.h"
#include "common.h"
#include <iostream>

//#include <libcron/Cron.h>
//#include <libcron/CronData.h>
//#include <libcron/CronSchedule.h>
extern CallBack1 callBack1;
extern CallBack2 callBack2;
extern CallBack3 callBack3;
extern CallBack4 callBack4;
extern CallBack5 callBack5;
extern CallBack6 callBack6;
extern CallBack7 callBack7;
extern CallBack8 callBack8;

extern CallHandlerRaise callHandlerRaise;


std::map<std::string, Callback1> Callback1_map;
std::map<std::string, Callback2> Callback2_map;
std::map<std::string, Callback3> Callback3_map;
std::map<std::string, Callback4> Callback4_map;
std::map<std::string, Callback5> Callback5_map;
std::map<std::string, Callback6> Callback6_map;
std::map<std::string, Callback7> Callback7_map;

std::map<int, std::string> RoutineEvent_map;
std::map<std::string, void*> FunctionEvent_map;

std::map<std::string, ArgumentType> ArgumentType_map;


LIB_API void RegisterRoutineEvent(char* type, int rotineId, ArgumentType handlerType, int once)
{
	std::string RoutineEvent = Chartostring(type);
	RoutineEvent_map.insert(std::make_pair(rotineId, RoutineEvent));
	ArgumentType_map.insert(std::make_pair(Chartostring(type), handlerType));
}

LIB_API void RegisterFunctionEvent(char* type, void* fn1, ArgumentType handlerType, int once)
{
	std::string FunctionEvent = Chartostring(type);

	FunctionEvent_map.insert(std::make_pair(FunctionEvent, fn1));
	ArgumentType_map.insert(std::make_pair(FunctionEvent, handlerType));
}

void CallFunction(char* type, int argType, void* eventObject, void* sender)
{
	std::string Event = Chartostring(type);


	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == Event) {
			auto it2 = ArgumentType_map.find(Event);
			if (it2 != ArgumentType_map.end()) {
				if (it2->second == NO_ARGS) {
					callBack1(it->first, sender);
				}
				else if (it2->second == JSON_STRING) {
					callBack3(it->first, eventObject, sender);
				}
				else if (it2->second == JSON_OBJECT || it2->second == STL_MAP) {
					callBack3(it->first, eventObject, sender);

				}

			}
		}
	}



	auto it11 = FunctionEvent_map.find(Event);
	if (it11 != FunctionEvent_map.end()) {
		auto it12 = ArgumentType_map.find(Event);
		if (it12 != ArgumentType_map.end()) {
			if (it12->second == NO_ARGS) {
				callHandlerRaise(it11->second);
				return;
			}
			else if (it12->second == JSON_STRING) {
				if (eventObject != NULL) {
					((Callback3)(it11->second))((char*)eventObject);
					return;
				}
			}
			else if (it12->second == POINTER || it12->second == POINTER2 || it12->second == POINTER4) {
				((Callback5)(it11->second))(eventObject);
				return;
			}
		}
	}


	auto it2 = Callback1_map.find(Event);
	if (it2 != Callback1_map.end()) {
		(it2->second)();
		return;
	}

	auto it23 = Callback3_map.find(Event);
	if (it23 != Callback3_map.end()) {
		(it23->second)((char*)eventObject);
		return;
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

	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			auto it2 = ArgumentType_map.find(type);
			if (it2 != ArgumentType_map.end()) {
				if (it2->second == NO_ARGS) {
					callBack1(it->first, NULL);
					return;
				}
			}
		}
	}
	auto it2 = Callback1_map.find(type);
	if (it2 != Callback1_map.end()) {
		(it2->second)();
	}
}

void Event::Trigger(std::string type, const json* event)
{

	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			callBack3(it->first, (void*)((json*)event)->dump().c_str(), NULL);
		}
	}


	auto it2 = Callback2_map.find(type);
	if (it2 != Callback2_map.end()) {
		(it2->second)((json*)event);
	}
}

void Event::Trigger(std::string type, const char* event)
{

	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			auto it11 = ArgumentType_map.find(type);
			if (it11 != ArgumentType_map.end()) {
				if (it11->second == NO_ARGS) {
					((Callback1)(it11->second))();
				}
				else if (it11->second == JSON_STRING || it11->second == JSON_OBJECT || it11->second == STL_MAP) {
					if (event != NULL) {
						callBack3(it->first, (char*)event, NULL);
					}
				}
			}
		}
	}

	auto it2 = Callback3_map.find(type);
	if (it2 != Callback3_map.end()) {
		(it2->second)((char*)event);
	}

}

void Event::Trigger(std::string type, const std::map<std::string, json>* event)
{
	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			callBack3(it->first, (void*)event, NULL);
		}
	}

	auto it2 = Callback4_map.find(type);
	if (it2 != Callback4_map.end()) {
		(it2->second)((std::map<std::string, json>*)event);
	}
}

void Event::Trigger(std::string type, void* object)
{
	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			callBack5(it->first, object, NULL);
		}
	}


	auto it2 = Callback5_map.find(type);
	if (it2 != Callback5_map.end()) {
		(it2->second)(object);
	}
}

void Event::Trigger(std::string type, void* object1, void* object2)
{
	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			callBack6(it->first, object1, object2, NULL);
		}
	}

	auto it2 = Callback6_map.find(type);
	if (it2 != Callback6_map.end()) {
		(it2->second)(object1, object2);
	}
}

void Event::Trigger(std::string type, void* object1, void* object2, void* object3, void* object4)
{
	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			callBack7(it->first, object1, object2, object3, object4, NULL);
		}
	}

	auto it2 = Callback7_map.find(type);
	if (it2 != Callback7_map.end()) {
		(it2->second)(object1, object2, object3, object4);
	}
}

void Event::Trigger(std::string type, void* data, int size)
{
	for (std::map<int, std::string>::iterator it = RoutineEvent_map.begin(); it != RoutineEvent_map.end(); it++)
	{
		if (it->second == type) {
			callBack8(it->first, data, size, NULL);
		}
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

//libcron::Cron<libcron::LocalClock, libcron::NullLock> cron22 =  libcron::Cron<libcron::LocalClock, libcron::NullLock>();
//
//time_t now = time(0);

extern ScheduleEvent scheduleEvent;
void Event::Schedule(std::string type, const char* cron, const char* event)
{

	scheduleEvent(const_cast<char*>(type.c_str()), (char*)cron, (char*)event);

	//cron22.add_schedule(type, cron, [=](auto&) {
	//	auto RoutineEvent = RoutineEvent_map.find(type);

	//	if (event == NULL) {
	//		if (RoutineEvent != RoutineEvent_map.end()) {
	//			callBack1(RoutineEvent->second, NULL);
	//		}
	//		else {
	//			auto it2 = Callback1_map.find(type);
	//			if (it2 != Callback1_map.end()) {
	//				(it2->second)();
	//			}
	//		}
	//	}
	//	else {
	//		if (RoutineEvent != RoutineEvent_map.end()) {
	//			callBack2(RoutineEvent->second, (void*)event, NULL);
	//		}
	//		else {
	//			auto it2 = Callback3_map.find(type);
	//			if (it2 != Callback3_map.end()) {
	//				(it2->second)((char*)event);
	//			}
	//		}
	//	}
	//	});







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
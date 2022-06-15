#include "pch.h"
#include "common.h"

 
extern LogCallBack1 logCallBack1;
extern LogCallBack2 logCallBack2;



void Logger::Log1(Severity severity, std::string message)
{
	if (logCallBack1 == NULL) 
		throw "日志指针未被初始化";

	logCallBack1((int)severity, const_cast<char*>(message.c_str()));
}

void Logger::Log1(Severity severity, LPCSTR pstrFormat, ...)
{
	if (logCallBack1 == NULL)
		throw "日志指针未被初始化";

	va_list arg;
	va_start(arg, pstrFormat);
	std::string temp;
	const char* start = const_cast<char*>(pstrFormat);
	while (*start != '\0')
	{
		if (*start == '%') {
			start++;
			switch (*start){
			case 'd':
				temp += std::to_string(va_arg(arg, int));
				break;
			case 'c':
				temp += std::to_string(va_arg(arg, int));//char类型提升,用int类型。 
				break;
			case 's': {
				char* ch = va_arg(arg, char*);
				while (*ch){
					temp += *ch;
					ch++;
				}
				delete ch;
			}
			break;
			case 'f': 	
				temp += std::to_string((float)va_arg(arg, double));		
				break;
			default:
				break;
			}
		}
		else {
			temp += *start;
		}
		start++;
	}
	va_end(arg);   //必须有这一步，结束栈操作

	logCallBack1((int)severity, (char*)temp.c_str());
}


void Logger::Log2(Severity severity, LPCTSTR pstrFormat, ...)
{
	if (logCallBack2 == NULL)
		throw "日志指针未被初始化";

	va_list arg;
	va_start(arg, pstrFormat);
	std::string temp;
	std::string pstr = ws2s(pstrFormat);
	const char* start = pstr.c_str();
	while (*start != '\0')
	{
		if (*start == '%') {
			start++;
			switch (*start)
			{
			case 'd':
				temp += std::to_string(va_arg(arg, int));
				break;
			case 'c':
				temp += std::to_string(va_arg(arg, int));//char类型提升,用int类型。 
				break;
			case 's':
			{ /*puts(va_arg(arg, char*));*/   //字符串可以直接用puts()函数输出  
				char* ch = va_arg(arg, char*);//定义一个指针变量接收获取的字符，用putchar（）一个一个输出  
				while (*ch)
				{
					temp += *ch;
					ch++;
				}
			}
			break;
			case 'f': {
				temp += std::to_string((float)va_arg(arg, double));
				//float a = (float)va_arg(arg, double);  //float类型提升，所以用double （小陷阱）
				//printf("%f", a);  //BUG  要模拟浮点型比较复杂，这里耍个小聪明~ 
			}
					break;
			default:
				break;
			}
		}
		else {
			temp += *start;
			//putchar(*start);
		}
		start++;
	}
	va_end(arg);   //必须有这一步，结束栈操作



	logCallBack2((int)severity, (char*)temp.c_str());
}



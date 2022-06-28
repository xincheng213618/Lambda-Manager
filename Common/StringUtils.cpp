#include "pch.h"
#include "common.h"
#include <locale>         // std::wstring_convert
#include <codecvt>        // std::codecvt_utf8
std::string ws2s(const std::wstring& input)
{
	std::wstring_convert<std::codecvt_utf8<wchar_t>> converter;
	return converter.to_bytes(input);
}

std::wstring s2ws(const std::string& input)
{
	std::wstring_convert<std::codecvt_utf8<wchar_t>> converter;
	return converter.from_bytes(input);
}

std::string StringUtils::wstring2string(const std::wstring& wstr)
{
	return ws2s(wstr);
}

std::wstring StringUtils::string2wstring(const std::string& str)
{
	return s2ws(str);
}

//https://www.cnblogs.com/ranjiewen/p/5770639.html
wchar_t* StringUtils::Multi2WideByte(const char* p)
{
	const size_t cSize = strlen(p) + 1;
	wchar_t* wc = new wchar_t[cSize];
	setlocale(LC_ALL, "chs");
	mbstowcs(wc, p, cSize);
	setlocale(LC_ALL, "C");

	return wc;
}

char* StringUtils::Wide2MultiByte(const wchar_t* p)
{
	DWORD dBufSize = WideCharToMultiByte(CP_OEMCP, 0, p, -1, NULL, 0, NULL, FALSE);

	//分配目标缓存
	char* dBuf = new char[dBufSize];
	memset(dBuf, 0, dBufSize);

	sprintf(dBuf, "%ws", p);
	//转换
	//int nRet = WideCharToMultiByte(CP_OEMCP, 0, p, -1, dBuf, dBufSize, NULL, FALSE);

	return dBuf;
}

std::string Chartostring(char* cha)
{
	std::string str;
	while (*cha)
	{
		str += *cha;
		cha++;
	}
	return str;
}

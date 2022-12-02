﻿#include "pch.h"
#include "common.h"
#include "common1.h"
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
	return dBuf;
}

std::string StringUtils::Multi2Utf8(const char* str)
{
	std::string result;
	WCHAR* strSrc;
	LPSTR szRes;

	int i = MultiByteToWideChar(CP_UTF8, 0, str, -1, NULL, 0);
	strSrc = new WCHAR[i + 1];
	MultiByteToWideChar(CP_UTF8, 0, str, -1, strSrc, i);

	i = WideCharToMultiByte(CP_ACP, 0, strSrc, -1, NULL, 0, NULL, NULL);
	szRes = new CHAR[i + 1];
	WideCharToMultiByte(CP_ACP, 0, strSrc, -1, szRes, i, NULL, NULL);

	result = szRes;
	delete[]strSrc;
	delete[]szRes;
	return result;
}

std::string StringUtils::Wide2Utf8(std::wstring& wide_string)
{
	static std::wstring_convert<std::codecvt_utf8<wchar_t>> converter;
	return converter.to_bytes(wide_string);
}


#pragma once

#include "common.h"
#include <utility>
#include <vector>
#include <string>
#include <atlstr.h>

#ifdef INTEROPTEST_EXPORTS
#define INTEROP_API __declspec(dllexport)
#else
#define INTEROP_API __declspec(dllimport)
#endif

typedef int (*MoveTo)(int x, int y);
typedef int (*CaptureImage)(int mode, char** image);

//void
extern "C" INTEROP_API int Test0();

// basic types
extern "C" INTEROP_API int Test1(char c);

extern "C" INTEROP_API int Test2(unsigned char c);

extern "C" INTEROP_API int Test3(int x);

extern "C" INTEROP_API int Test4(unsigned int x);

extern "C" INTEROP_API int Test5(long x);

extern "C" INTEROP_API int Test6(unsigned long x);

extern "C" INTEROP_API int Test7(float x);

extern "C" INTEROP_API int Test8(double x);

extern "C" INTEROP_API int Test9(long int x);

extern "C" INTEROP_API int Test10(long long x);

extern "C" INTEROP_API int Test11(long double x);

// pointer types
extern "C" INTEROP_API int Test12(char* p);

extern "C" INTEROP_API int Test13(unsigned char* p);

extern "C" INTEROP_API int PrepareStdString(std::string * *out);

extern "C" INTEROP_API int Test14(std::string * s);

extern "C" INTEROP_API int PrepareCString(const wchar_t** out);

extern "C" INTEROP_API int Test15(wchar_t* s);

extern "C" INTEROP_API int PrepareLPSTR(LPSTR * out);

/**
 * LPSTR:
 * long pointer, 1 byte size, ANSI string
 * C++  type: char*, char[], initialize: "ABC", function prefix: str
 * xml  type: LPSTR, char*, char[]
 * C#   type: sbyte*, sbyte[]
 * C# => C++: Marshal.StringToHGlobalAnsi
 */
extern "C" INTEROP_API int Test16a(LPSTR p);

extern "C" INTEROP_API int PrepareLPCSTR(LPCSTR * out);

/**
 * LPCSTR: constant type of LPSTR
 * long pointer, 1 byte size, ANSI string
 * C++  type: const char*, const char[], initialize: "ABC", function prefix: str
 * xml  type: LPCSTR
 * C#   type: sbyte*, sbyte[]
 * C# => C++: Marshal.StringToHGlobalAnsi
 */
extern "C" INTEROP_API int Test16b(LPCSTR p);

extern "C" INTEROP_API int PrepareLPTSTR(LPTSTR * out);

/*
 * LPTSTR: LPSTR or LPWSTR depend on if tchar.h _UNICODE defined
 * long pointer, 1 or 2 bytes size, ANSI or Unicode string
 * C++  type: _TCHAR*, _TCHAR[], initialize: _T("ABC"), function prefix: _tcs
 * xml  type: LPTSTR
 * C#   type: sbyte* or char*, sbyte[] or char[]
 * C# => C++: Marshal.StringToHGlobalAnsi or Marshal.StringToHGlobalUni
 */
extern "C" INTEROP_API int Test16c(LPTSTR p);

extern "C" INTEROP_API int PrepareLPCTSTR(LPCTSTR * out);

/*
 * LPTSTR: constant type of LPTSTR
 * long pointer, 1 or 2 bytes size, ANSI or Unicode string
 * C++  type: const _TCHAR*, const _TCHAR[], initialize: _T("ABC"), function prefix: _tcs
 * xml  type: LPCTSTR
 * C#   type: sbyte* or char*, sbyte[] or char[]
 * C# => C++: Marshal.StringToHGlobalAnsi or Marshal.StringToHGlobalUni
 */
extern "C" INTEROP_API int Test16d(LPCTSTR p);//pointer to constant string where a character could be 1 or 2 chars which depends on if TCHAR is defined

extern "C" INTEROP_API int PrepareLPWSTR(LPWSTR * out);

/**
 * LPWSTR:
 * long pointer, 2 byte size, Unicode string
 * C++  type: wchar_t*, wchar_t[], initialize: L"ABC", function prefix: wcs
 * xml  type: LPWSTR, wchar_t*, wchar_t[], string
 * C#   type: char*, char[], string
 * C# => C++: Marshal.StringToHGlobalUni
 */
extern "C" INTEROP_API int Test16e(LPWSTR p);

extern "C" INTEROP_API int PrepareLPCWSTR(LPCWSTR * out);

/**
 * LPCWSTR: constant type of LPWSTR
 * long pointer, 2 byte size, Unicode string
 * C++  type: const wchar_t*, const wchar_t[], initialize: L"ABC", function prefix: wcs
 * xml  type: LPWSTR, wchar_t*, wchar_t[], string
 * C#   type: char*, char[], string
 * C# => C++: Marshal.StringToHGlobalUni
 */
extern "C" INTEROP_API int Test16f(LPCWSTR p);

extern "C" INTEROP_API int Test17(int* p);

extern "C" INTEROP_API int Test18(unsigned int* p);

extern "C" INTEROP_API int Test19(long* p);

extern "C" INTEROP_API int Test20(unsigned long* p);

extern "C" INTEROP_API int Test21(float* p);

extern "C" INTEROP_API int Test22(double* p);

extern "C" INTEROP_API int Test23(long int* p);

extern "C" INTEROP_API int Test24(long long* p);

extern "C" INTEROP_API int Test25(long double* p);

// array types
extern "C" INTEROP_API int Test26(char a[], int size);
extern "C" INTEROP_API int Test26x(char a[]);

extern "C" INTEROP_API int Test27(int a[], int size);

extern "C" INTEROP_API int Test28(long a[], int size);

extern "C" INTEROP_API int Test29(float a[], int size);

extern "C" INTEROP_API int Test30(double a[], int size);

extern "C" INTEROP_API int Test31(long int a[], int size);

extern "C" INTEROP_API int Test32(long long a[], int size);

extern "C" INTEROP_API int Test33(long double a[], int size);

extern "C" INTEROP_API int Test34(wchar_t* a[], int size);

// 2 arguments
extern "C" INTEROP_API int Test40(char c, int x);

extern "C" INTEROP_API int Test41(long x, char c);

extern "C" INTEROP_API int Test42(int* x, char c);

extern "C" INTEROP_API int Test43(char c, int* x);

extern "C" INTEROP_API int Test44(int* x, long y);

extern "C" INTEROP_API int Test45(long x, int* y);

extern "C" INTEROP_API int Test46(int x[], int size, long* y);

// 3 arguments
extern "C" INTEROP_API int Test50(char c, long x, int y);

extern "C" INTEROP_API int Test51(long x, char c, int y);

extern "C" INTEROP_API int Test52(int* x, long* y, char* c);

extern "C" INTEROP_API int Test53(char a[], int size, char* p1, LPCSTR p2);

// 4 arguments
extern "C" INTEROP_API int Test60(char c, int x, long y, float* f);

extern "C" INTEROP_API int Test61(double d, int x, float f, char c);

extern "C" INTEROP_API int Test62(long double ld, int x, long int lx, long long ll);

// 5 arguments
extern "C" INTEROP_API int Test71(std::string s, int x, long long y, float f, double d);

extern "C" INTEROP_API int Test72(double d, float f, long long x, int y, char* p);

extern "C" INTEROP_API int Test73(wchar_t* s1, char s2[], LPCTSTR s3, wchar_t* s4, LPCWSTR s5);

// 6 arguments
extern "C" INTEROP_API int Test80(int x, long y, float f, double d, long int lx, long double ld);

extern "C" INTEROP_API int Test81(int* x, long* y, float* f, double* d, long int* lx, long double* ld);

extern "C" INTEROP_API int Test101();

extern "C" INTEROP_API int Test102(MoveTo pMoveTo, CaptureImage pCapImg);

// event test
extern "C" INTEROP_API int Test120();
extern "C" INTEROP_API int Test121();
extern "C" INTEROP_API int Test122(json * event);
extern "C" INTEROP_API int Test123(const char* event);
extern "C" INTEROP_API int Test124();
extern "C" INTEROP_API int Test125(int x, wchar_t* y, wchar_t** z);
extern "C" INTEROP_API int Test131();
extern "C" INTEROP_API int Test132(json * event);
extern "C" INTEROP_API int Test133(const char* event);
extern "C" INTEROP_API int Test134();
extern "C" INTEROP_API int Test135();
extern "C" INTEROP_API int Test136(double value);

//scheduler
extern "C" INTEROP_API int Test150();
extern "C" INTEROP_API int Test151();
int Test152(const char* event);
int Test153();

//event async dispatcher
extern "C" INTEROP_API int Test160();
extern "C" INTEROP_API int Test161(const char*);

//command
extern "C" INTEROP_API int Test200();
extern "C" INTEROP_API int CameraSettingReset();
extern "C" INTEROP_API int UpdateDisplayMode();

template <typename T>CString format(T a[]);
template <typename T>CString format(T a[], size_t size);
CString formatStringArray(wchar_t* a[], int size);

//event array
extern "C" INTEROP_API  int Test210();
extern "C" INTEROP_API  int Test211(void* a);
extern "C" INTEROP_API  int Test212(void* a);

extern "C" INTEROP_API int BrightFieldBrightness(void* brightness);
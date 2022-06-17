#include "pch.h"
#include "common.h"
#include <locale>         // std::wstring_convert
#include <codecvt>        // std::codecvt_utf8
#include <atlcore.h>


 
extern LogCallBack1 logCallBack1;
extern LogCallBack2 logCallBack2;



void Logger::Log1(Severity severity, std::string message)
{
	logCallBack1((int)severity, const_cast<char*>(message.c_str()));
}

LPWSTR m_Buffer = NULL;
void Logger::Log1(Severity severity, LPCSTR pstrFormat, ...)
{
	va_list args;
	va_start(args, pstrFormat);

	int nBuf;
	CHAR szBuffer[1024];
	nBuf = _vsnprintf(szBuffer, sizeof(szBuffer), pstrFormat, args);
	if (m_Buffer)
		free(m_Buffer);
	m_Buffer = (LPWSTR)malloc((nBuf + 1) * sizeof(WCHAR));
	MultiByteToWideChar(CP_ACP, 0, szBuffer, nBuf, m_Buffer, nBuf);
	m_Buffer[nBuf] = L'\0';
	va_end(args);
	char buffer[500];
	wcstombs(buffer, m_Buffer, 500);

	logCallBack1((int)severity, buffer);
}

enum { MAX_LOCAL_STRING_LEN = 63 };

LPTSTR m_pstr = nullptr;
TCHAR m_szBuffer[MAX_LOCAL_STRING_LEN + 1];

void Assign(LPCTSTR pstr, int cchMax)
{

	if (pstr == NULL) pstr = _T("");
	cchMax = (cchMax < 0 ? (int)_tcslen(pstr) : cchMax);
	if (cchMax < MAX_LOCAL_STRING_LEN) {
		if (m_pstr != m_szBuffer) {
			free(m_pstr);
			m_pstr = m_szBuffer;
		}
	}
	else if (cchMax > (int) _tcslen(m_pstr) || m_pstr == m_szBuffer) {
		if (m_pstr == m_szBuffer) m_pstr = NULL;
		m_pstr = static_cast<LPTSTR>(realloc(m_pstr, (static_cast<unsigned long long>(cchMax) + 1) * sizeof(TCHAR)));
	}
	_tcsncpy(m_pstr, pstr, cchMax);
	m_pstr[cchMax] = _T('\0');
}

void Logger::Log2(Severity severity, LPCTSTR pstrFormat, ...)
{
	LPTSTR szSprintf = NULL;
	va_list argList;
	int nLen;
	va_start(argList, pstrFormat);
	nLen = _vsntprintf(NULL, 0, pstrFormat, argList);
	szSprintf = (TCHAR*)malloc((nLen + 1) * sizeof(TCHAR));
	ZeroMemory(szSprintf, (nLen + 1) * sizeof(TCHAR));
	int iRet = _vsntprintf(szSprintf, nLen + 1, pstrFormat, argList);
	va_end(argList);
	Assign(szSprintf,-1);
	free(szSprintf);

	//const char* start = StringUtils::Wide2MultiByte(szSprintf);

	logCallBack2((int)severity, szSprintf);
}



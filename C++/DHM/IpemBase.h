//////////////////////////////////////////////////////////////////////////
/*------------------------------------------------------------------------------
//Name£ºCIpemBase
//Description£º	
//Author£ºZhenzhong
//Date: 2011-01-23
//CopyRight: 
------------------------------------------------------------------------------*/

#pragma once
#include <time.h>
#include <omp.h>
#include <Windows.h>

using namespace std;

#define PI1 3.1415926535897932384626
#define EPS1  pow(2.0f,-52)

class CIpemBase
{
public:
	CIpemBase(void);
	~CIpemBase(void);
private:
	clock_t m_nStartTime;
	clock_t m_nEndTime;
public:
	//long StartClock(void);
	//long ShowTimeClock(bool bShowMsg=false);
};



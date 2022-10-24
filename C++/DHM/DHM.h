#pragma once

#ifdef LFOCM_EXPORTS
#define LFOCM_API __declspec(dllexport)
#else
#define LFOCM_API __declspec(dllimport)
#endif


extern "C" LFOCM_API  int OpenVideo(char* FullPath);






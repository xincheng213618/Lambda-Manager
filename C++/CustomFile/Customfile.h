#pragma once

#include "common.h"
#include "CustomFileManage.h"

#ifdef CUSTOMFILE_EXPORTS
#define CUSTOMFILE_API __declspec(dllexport)
#else
#define CUSTOMFILE_API __declspec(dllimport)
#endif

extern "C" CUSTOMFILE_API int NativeWriteFile(std::string, cv::Mat);

extern "C" CUSTOMFILE_API int NativeReadFile(std::string, cv::Mat&);

extern "C" CUSTOMFILE_API int GrifExportAs(char* GrifExportAsJson);

extern "C" CUSTOMFILE_API int SeriesProjectExportAs(char* GrifExportAsJson);

extern "C" CUSTOMFILE_API GrifFile ReadFileInfo(char* FilePath);

extern "C" CUSTOMFILE_API int NativeIsGrifFile(std::string);

extern "C" CUSTOMFILE_API int DrawingVisual(char* data);

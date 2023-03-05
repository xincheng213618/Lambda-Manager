#include "pch.h"
#include "CustomFile.h"
#include "zip.h"
#include "unzip.h"
#include "ExportManage.h"

CExportManage g_cExportManage;

int NativeWriteFile(std::string path, cv::Mat src)
{
	Logger::Log1(Severity::INFO, "NativeWriteFile");
	CustomFile::WriteFile(path, src, 0);
	return 0;
}

int NativeReadFile(std::string path, cv::Mat& image)
{
	Logger::Log1(Severity::INFO, "NativeReadFile");
	image = CustomFile::ReadFile(path);
	return 0;
}

int GrifExportAs(char* GrifExportAsJson)
{
	g_cExportManage.GrifToFile(GrifExportAsJson);
	return 0;
}

int SeriesProjectExportAs(char* GrifExportAsJson)
{
	g_cExportManage.SerialToFile(GrifExportAsJson);
	return 0;
}

GrifFile ReadFileInfo(char* FilePath)
{
	return CustomFile::ReadFileHeader(FilePath);
}

int NativeIsGrifFile(std::string path)
{
	if (CustomFile::IsGrifFile(path) == 0)
	{
		return 0;
	}

	return -1;
}

int DrawingVisual(char* data)
{
	g_cExportManage.DrawingToFile(data);
	return 0;
}

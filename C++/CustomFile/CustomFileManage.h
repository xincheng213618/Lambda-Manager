#pragma once
#include <opencv2/opencv.hpp>
#include <iostream>






typedef struct GrifFile
{
	char Name[20]; //样片种类
	char OperatingMode[20]; //操作模式  xyztp-edof
	char Lighting[20]; //长度
	int x; //x
	int y; //y
	int z; //z
	int rows; //宽度
	int cols; //高度
	int depth; //位深度
	int jsonoffset; //json的相对文件头的数据量，可以直接通过这里去读取json的内存，(如果不使用元数据，可以把这个合并在头文件中，并取消Griffile的元数据类型)
} GrifFile;

typedef struct GrifMatFile
{
	int rows;
	int cols;
	int type;
	int compression; //0,不压缩; 1,Zlib; 2,gz
	long long srcLen; //Mat.data 的长度
	long long destLen; //无压缩时，destLen =0;
} GrifMatFile;

typedef struct GrifFileHeader
{
	char Name[4] = {0x67, 0x72, 0x69, 0x66};
	int Verison; //0
	int Matoffset; //直接读取Mat数据的偏移量 int 限制了2G大小，如果需要更多，则需要float or double d但是这回让内存对齐比较麻烦
} GrifFileHeader;

int WriteFileCache(std::string path, GrifFile grifFileInfo, cv::Mat src);
int WriteFileCache(std::string path, cv::Mat src);


class CustomFile {
public:
	static int WriteFile(std::string path, cv::Mat src, int compression = 1);
	static int WriteFile(std::string path, GrifFile grifFileInfo, cv::Mat src, int compression = 1);
	static GrifFile ReadFileHeader(std::string path);
	static cv::Mat ReadFile(std::string FileName);
	static int GrifToMat(std::string path, cv::Mat& src);
	static int WriteGrifFile(std::string path, std::string name, cv::Mat src, int x, int y, int z);
	static int GrifToMatGz(std::string path, cv::Mat& src);
	static int WriteGrifFileGz(std::string path, std::string name, cv::Mat src, int x, int y, int z);
	static void OsWrite(std::string path, cv::Mat src);
	static void OsWrite1(std::string path, cv::Mat src);
	static int IsGrifFile(std::string);
};

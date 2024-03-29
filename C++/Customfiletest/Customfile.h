#pragma once
#include <opencv2/opencv.hpp>
#include <iostream>

typedef struct GrifFileMeta
{
    int x; //x
    int y; //y
    int z; //z
    int rows; //宽度
    int cols; //高度
    int depth; //位深度
    int jsonoffset;//json的相对文件头的数据量，可以直接通过这里去读取json的内存，(如果不使用元数据，可以把这个合并在头文件中，并取消Griffile的元数据类型)
    int jsonoffsetlength;//char*的长度
    int MatCalloutoff;//标尺的信息
}GrifFileMeta;

typedef struct GrifMatFile
{
    int rows;
    int cols;
    int type;
    int compression;  //0,不压缩; 1,Zlib; 2,gz
    long long srcLen; //Mat.data 的长度
    long long destLen; //无压缩时，destLen =0;
}GrifMatFile;

typedef struct GrifFileHeader
{
    char Name[4] = { 0x67,0x72,0x69,0x66 };
    int Version; //0
    int Matoffset; //直接读取Mat数据的偏移量 int 限制了2G大小，如果需要更多，则需要float or double 但是这回让内存对齐比较麻烦
}GrifFileHeader;


//typedef struct GrifFileHeader
//{
//    char Name[4] = { 0x67,0x72,0x69,0x66 };
//    char Version[4] ={0x00,0x00,0x00,0x00}; //0
//    int Matoffset; //直接读取Mat数据的偏移量 int 限制了2G大小，如果需要更多，则需要float or double 但是这回让内存对齐比较麻烦
//}GrifFileHeader;

int compressToGzip(const char* input, int inputSize, char* output, int outputSize);

int WriteFile(std::string path, cv::Mat src, int compression = 1);
int WriteFile(std::string path, cv::Mat src, cv::Mat src1, int compression = 1);
int WriteFile(std::string path, GrifFileMeta grifFileInfo, cv::Mat src, int compression = 1);
int WriteFile(std::string path, GrifFileMeta grifFileInfo, cv::Mat src, cv::Mat src1, int compression = 1);

GrifFileMeta ReadFileHeader(std::string path);
cv::Mat ReadFile(std::string FileName);
int GrifToMat(std::string path, cv::Mat& src);
int WriteGrifFile(std::string path, std::string name, cv::Mat src, int x, int y, int z);
//int GrifToMatGz(std::string path, cv::Mat& src);
//int WriteGrifFileGz(std::string path, std::string name, cv::Mat src, int x, int y, int z);
//void OsWrite(std::string path, cv::Mat src);
//void OsWrite1(std::string path, cv::Mat src);
int WriteFileCache(std::string path, GrifFileMeta grifFileInfo, cv::Mat src);
int WriteFileCache(std::string path, cv::Mat src);

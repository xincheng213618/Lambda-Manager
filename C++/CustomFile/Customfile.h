#pragma once
#include <opencv2/opencv.hpp>
#include <iostream>

typedef struct GrifFile
{
    char Name[20]; //��Ƭ����
    char OperatingMode[20]; //����ģʽ  xyztp-edof
    char Lighting[20]; //����
    int x; //x
    int y; //y
    int z; //z
    int rows; //���
    int cols; //�߶�
    int depth; //λ���
    int jsonoffset;//json������ļ�ͷ��������������ֱ��ͨ������ȥ��ȡjson���ڴ棬(�����ʹ��Ԫ���ݣ����԰�����ϲ���ͷ�ļ��У���ȡ��Griffile��Ԫ��������)
}GrifFile;

typedef struct GrifMatFile
{
    int rows;
    int cols;
    int type;
    int compression;  //0,��ѹ��; 1,Zlib; 2,gz
    long long srcLen; //Mat.data �ĳ���
    long long destLen; //��ѹ��ʱ��destLen =0;
}GrifMatFile;

typedef struct GrifFileHeader
{
    char Name[4] = { 0x67,0x72,0x69,0x66 };
    int Version; //0
    int Matoffset; //ֱ�Ӷ�ȡMat���ݵ�ƫ���� int ������2G��С�������Ҫ���࣬����Ҫfloat or double d����������ڴ����Ƚ��鷳
}GrifFileHeader;


//
//typedef struct GrifFile
//{
//    unsigned long int time;//����ʱ���  time(NULL)  
//    double DefocusDistance;//�뽹����
//    int Matoffset632;//632������Matͼ������ָ��λ��
//    int Matoffset521;
//    int Matoffset466;
//    int Matoffset588;
//    int Matoffset607;
//}GrifFile;






int WriteFile(std::string path, cv::Mat src, int compression = 1);
int WriteFile(std::string path, GrifFile grifFileInfo, cv::Mat src, int compression = 1);
GrifFile ReadFileHeader(std::string path);
cv::Mat ReadFile(std::string FileName);
int GrifToMat(std::string path, cv::Mat& src);
int WriteGrifFile(std::string path, std::string name, cv::Mat src, int x, int y, int z);
int GrifToMatGz(std::string path, cv::Mat& src);
int WriteGrifFileGz(std::string path, std::string name, cv::Mat src, int x, int y, int z);
void OsWrite(std::string path, cv::Mat src);
void OsWrite1(std::string path, cv::Mat src);
int WriteFileCache(std::string path, GrifFile grifFileInfo, cv::Mat src);
int WriteFileCache(std::string path, cv::Mat src);


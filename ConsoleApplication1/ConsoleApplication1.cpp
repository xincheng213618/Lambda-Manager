// ConsoleApplication1.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <fstream>
#include <opencv2/opencv.hpp>
#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include "zlib.h"

using namespace std;
struct GridFile
{
    char Name[20];
    int rows;
    int cols;
    int type;
    double srcLen;
    double destLen;
};


void WriteFile(cv::Mat WriteMat,string FileName) {
    const char* istream = (char*)WriteMat.data;
    uLongf srcLen = WriteMat.total() * WriteMat.elemSize();      // +1 for the trailing `\0`
    uLongf destLen = compressBound(srcLen); // this is how you should estimate size 
    char* ostream = (char*)malloc(destLen);
    int res = compress((Bytef*)ostream, &destLen, (Bytef*)istream, srcLen);
    if (res == Z_BUF_ERROR) {
        printf("Buffer was too small!\n");
    }
    if (res == Z_MEM_ERROR) {
        printf("Not enough memory for compression!\n");
    }

    GridFile grid;
    strcpy(grid.Name, "陈新城");
    grid.rows = WriteMat.rows;
    grid.cols = WriteMat.cols;
    grid.type = WriteMat.type();
    grid.srcLen = srcLen;
    grid.destLen = destLen;

    ofstream outFile(FileName, ios::out | ios::binary);

    outFile.write((char*)&grid, sizeof(grid));
    outFile.write(ostream, grid.destLen);
    outFile.close();
}

cv::Mat ReadFile(string FileName) {
    ifstream inFile(FileName, ios::in | ios::binary); //二进制读方式打开
    if (!inFile) {
        cout << "error" << endl;
        return cv::Mat::zeros(0, 0, CV_8UC3);
    }
    GridFile gridFile;
    inFile.read((char*)&gridFile, sizeof(gridFile));
    char* i2stream = new char[gridFile.destLen];
    // Read the pixels from the stringstream
    inFile.read(i2stream, gridFile.destLen);

    char* o2stream = (char*)malloc(gridFile.srcLen);
    uLongf destLen2 = gridFile.destLen;
    uLongf srcLen = gridFile.srcLen;

    int des = uncompress((Bytef*)o2stream, &srcLen, (Bytef*)i2stream, destLen2);
    cv::Mat mat1 = cv::Mat(gridFile.rows, gridFile.cols, gridFile.type, o2stream);
    return mat1;
}

GridFile ReadFileHeader(string FileName) {
    GridFile gridFile{};

    ifstream inFile(FileName, ios::in | ios::binary); //二进制读方式打开
    if (!inFile) {
        cout << "error" << endl;
        return gridFile;
    }
    inFile.read((char*)&gridFile, sizeof(gridFile));
    return gridFile;
}





int main()
{
    //cv::Mat TestMat = cv::imread("D:\\PNT1A.tif", CV_64FC1);
    //WriteFile(TestMat,"PNT1A.grid");

    cv::Mat Mat1 = ReadFile("PNT1A.grid");
    GridFile gridfile = ReadFileHeader("students.grid");
    cv::imshow("22", Mat1);
    cv::waitKey(0);


    //const char* istream = (char*)TestMat.data;
    //uLongf srcLen = TestMat.total() * TestMat.elemSize();      // +1 for the trailing `\0`
    //uLongf destLen = compressBound(srcLen); // this is how you should estimate size 
    //// needed for the buffer
    //char* ostream = (char*)malloc(destLen);
    //int res = compress2((Bytef*)ostream, &destLen, (Bytef*)istream, srcLen,9);
    //// destLen is now the size of actuall buffer needed for compression
    //// you don't want to uncompress whole buffer later, just the used part
    //if (res == Z_BUF_ERROR) {
    //    printf("Buffer was too small!\n");
    //    return 1;
    //}
    //if (res == Z_MEM_ERROR) {
    //    printf("Not enough memory for compression!\n");
    //    return 2;
    //}

    //const char* i2stream = ostream;
    //char* o2stream = (char*)malloc(srcLen);
    //uLongf destLen2 = destLen; //destLen is the actual size of the compressed buffer
    //int des = uncompress((Bytef*)o2stream, &srcLen, (Bytef*)i2stream, destLen2);
    //printf("%s\n", o2stream);

    //cv::Mat TestMat1 = cv::Mat(TestMat.rows, TestMat.cols, TestMat.type(), o2stream);


    


}

// 运行程序: Ctrl + F5 或调试 >“开始执行(不调试)”菜单
// 调试程序: F5 或调试 >“开始调试”菜单

// 入门使用技巧: 
//   1. 使用解决方案资源管理器窗口添加/管理文件
//   2. 使用团队资源管理器窗口连接到源代码管理
//   3. 使用输出窗口查看生成输出和其他消息
//   4. 使用错误列表窗口查看错误
//   5. 转到“项目”>“添加新项”以创建新的代码文件，或转到“项目”>“添加现有项”以将现有代码文件添加到项目
//   6. 将来，若要再次打开此项目，请转到“文件”>“打开”>“项目”并选择 .sln 文件

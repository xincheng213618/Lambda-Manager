// ConsoleApplication1.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//
#include <Windows.h>
#include <iostream>
#include <fstream>
#include <opencv2/opencv.hpp>
#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include "zlib.h"
#include "Customfile.h"

using namespace std;
int main()
{
    clock_t start, end;

    //cv::Mat src1 = cv::Mat(1280, 720, CV_8UC3);
    //GrifToMat("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\Image 1.grif", src1);

    //for (size_t i = 0; i < 10; i++)
    //{
    //    WriteFileCache("C:\\Users\\Chen\\Desktop\\WriteCacheTest\\"+ std::to_string(i) + "src.grif", src1);
    //}
    //Sleep(100);
    //for (size_t i = 0; i < 10; i++)
    //{
    //    WriteFileCache("C:\\Users\\Chen\\Desktop\\WriteCacheTest\\a" + std::to_string(i) + "src.grif", src1);
    //}
    //Sleep(30000);
    //for (size_t i = 0; i < 10; i++)
    //{
    //    WriteFileCache("C:\\Users\\Chen\\Desktop\\WriteCacheTest\\b" + std::to_string(i) + "src.grif", src1);
    //}
    //Sleep(100000);

    cv::Mat TestMat = cv::imread("D:\\PNT1A.tif", CV_64FC1);

    int i = sizeof(TestMat);

    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A.grif", TestMat);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A0.grif", TestMat,0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "PNT1A2.grif", TestMat,1,1,1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "PNT1A2.grif.gz", TestMat, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A3.grif",TestMat);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A4.grif", TestMat);




    cv::Mat TestMat0 = ReadFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A0.grif");
    cv::Mat TestMat1 = ReadFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A.grif");


    cv::Mat PNT1B = cv::imread("D:\\PNT1B.tif", CV_64FC1);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1B.grif", PNT1B);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1B0.grif", PNT1B, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "PNT1B2.grif", PNT1B, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "PNT1B2.grif.gz", PNT1B, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1B3.grif", PNT1B);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1B4.grif", PNT1B);
    //cv::imshow("TestMat0", TestMat0);
    //cv::imshow("TestMat", TestMat1)

    cv::Mat src = cv::Mat(1280, 720, CV_8UC3);
    GrifToMat("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\Image 1.grif", src);
    
    //WriteGrifFileGz("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "src2.grif", src, 1, 1, 1);
    //GrifToMatGz("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\FsGzTest.grif", src);


    WriteFile( "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src.grif", src);
    WriteFile( "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src0.grif", src, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "src2.grif", src, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "src2.grif.gz", src, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src3.grif", src);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src4.grif", src);

    cv::Mat  srcdouble;
    src.convertTo(srcdouble, CV_64FC3, 1.0 / 255.0);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble.grif", srcdouble);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble0.grif", srcdouble, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "srcdouble2.grif", srcdouble, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "srcdouble2.grif.gz", srcdouble, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble3.grif", srcdouble);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble4.grif", srcdouble);

    cv::Mat test = cv::imread("D:\\test.bmp");
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test.grif", test);
    WriteFile( "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test0.grif", test, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "test2.grif", test, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "test2.grif.gz", test, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test3.grif", test);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test4.grif", test);

    cv::Mat  ZeroTest = cv::Mat::zeros(2448,2048,CV_8UC3);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest.grif", ZeroTest);
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest0.grif", ZeroTest, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "ZeroTest2.grif", ZeroTest, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "ZeroTest.grif.gz", ZeroTest, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest3.grif", ZeroTest);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest4.grif", ZeroTest);


    start = clock();
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\testWrite.grif", src);
    end = clock();   //结束时间
    cout << "WriteFile = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    cv::Mat Mat1 = ReadFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\testWrite.grif");
    end = clock();   //结束时间
    cout << "ReadFile = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    GrifFile gridfile = ReadFileHeader("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\testWrite.grif");
    end = clock();   //结束时间
    cout << "ReadFileHeader = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\","Image 111.grif", Mat1,1,1,1);
    end = clock();   //结束时间
    cout << "WriteGrifFile = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    cv::Mat src11 = cv::Mat(1280, 720, CV_8UC3);
    start = clock();
    GrifToMat("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\Image 2.grif", src11);
    end = clock();   //结束时间
    cout << "GrifToMat = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    cv::imshow("1111", src);
    cv::Mat  mat22;
    src.convertTo(mat22,CV_64FC3);
    start = clock();
    WriteFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\doubletest.grif", mat22);
    end = clock();   //结束时间
    cout << "WriteFile doubletest = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "Image doubletest.grif", mat22, 1, 1, 1);
    end = clock();   //结束时间
    cout << "WriteGrifFile doubletest = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "Image doubletest.grif.gz", mat22, 1, 1, 1);
    end = clock();   //结束时间
    cout << "WriteGrifFile doubletestgz = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();





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

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
    //GrifToMat("C:\\Users\\Chen\\Desktop\\GrifTest\\Image 1.grif", src1);

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


    cv::Mat Callout= cv::imread("C:\\Users\\Chen\\Desktop\\GrifTest\\image1.tif");
    cv::Mat image22 = cv::imread("C:\\Users\\Chen\\Desktop\\GrifTest\\image2.tif");

    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test0.grif", image22, 0);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test1.grif", image22, 1);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test000.grif", Callout, 0);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test001.grif", Callout, 1);

    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test01.grif", image22, Callout,0);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test11.grif", image22, Callout, 1);


    start = clock();
    cv::Mat TestMat000 = ReadFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test000.grif");
    end = clock();   //结束时间
    cout << "TestMat000 = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    cv::Mat TestMat001 = ReadFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test001.grif");
    end = clock();   //结束时间
    cout << "TestMat001 = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;






    cv::Mat TestMat = cv::imread("D:\\PNT1A.tif", CV_64FC1);

    int i = sizeof(TestMat);

    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\PNT1A.grif", TestMat);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\PNT1A0.grif", TestMat,0);
    




    start = clock();
    cv::Mat TestMat0 = ReadFile("C:\\Users\\Chen\\Desktop\\GrifTest\\PNT1A0.grif");
    end = clock();   //结束时间
    cout << "TestMat0 = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    cv::Mat TestMat1 = ReadFile("C:\\Users\\Chen\\Desktop\\GrifTest\\PNT1A.grif");
    end = clock();   //结束时间
    cout << "TestMat1 = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    cv::imshow("TestMat0", TestMat0);
    cv::imshow("TestMat", TestMat1);

    cv::Mat PNT1B = cv::imread("D:\\PNT1B.tif", CV_64FC1);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\PNT1B.grif", PNT1B);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\PNT1B0.grif", PNT1B, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "PNT1B2.grif", PNT1B, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "PNT1B2.grif.gz", PNT1B, 1, 1, 1);



    cv::Mat src = cv::Mat(1280, 720, CV_8UC3);
    GrifToMat("C:\\Users\\Chen\\Desktop\\GrifTest\\Image 1.grif", src);
    
    //WriteGrifFileGz("C:\\Users\\Chen\\Desktop\\GrifTest\\", "src2.grif", src, 1, 1, 1);
    //GrifToMatGz("C:\\Users\\Chen\\Desktop\\GrifTest\\FsGzTest.grif", src);


    WriteFile( "C:\\Users\\Chen\\Desktop\\GrifTest\\src.grif", src);
    WriteFile( "C:\\Users\\Chen\\Desktop\\GrifTest\\src0.grif", src, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "src2.grif", src, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "src2.grif.gz", src, 1, 1, 1);


    cv::Mat  srcdouble;
    src.convertTo(srcdouble, CV_64FC3, 1.0 / 255.0);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\srcdouble.grif", srcdouble);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\srcdouble0.grif", srcdouble, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "srcdouble2.grif", srcdouble, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "srcdouble2.grif.gz", srcdouble, 1, 1, 1);


    cv::Mat test = cv::imread("D:\\test.bmp");
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\test.grif", test);
    WriteFile( "C:\\Users\\Chen\\Desktop\\GrifTest\\test0.grif", test, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "test2.grif", test, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "test2.grif.gz", test, 1, 1, 1);


    cv::Mat  ZeroTest = cv::Mat::zeros(2448,2048,CV_8UC3);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\ZeroTest.grif", ZeroTest);
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\ZeroTest0.grif", ZeroTest, 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "ZeroTest2.grif", ZeroTest, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "ZeroTest.grif.gz", ZeroTest, 1, 1, 1);
    //OsWrite("C:\\Users\\Chen\\Desktop\\GrifTest\\ZeroTest3.grif", ZeroTest);
    //OsWrite1("C:\\Users\\Chen\\Desktop\\GrifTest\\ZeroTest4.grif", ZeroTest);


    start = clock();
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\testWrite.grif", src);
    end = clock();   //结束时间
    cout << "WriteFile = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    cv::Mat Mat1 = ReadFile("C:\\Users\\Chen\\Desktop\\GrifTest\\testWrite.grif");
    end = clock();   //结束时间
    cout << "ReadFile = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    GrifFileMeta gridfile = ReadFileHeader("C:\\Users\\Chen\\Desktop\\GrifTest\\testWrite.grif");

    end = clock();   //结束时间
    cout << "ReadFileHeader = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\","Image 111.grif", Mat1,1,1,1);
    end = clock();   //结束时间
    cout << "WriteGrifFile = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    cv::Mat src11 = cv::Mat(1280, 720, CV_8UC3);
    start = clock();
    GrifToMat("C:\\Users\\Chen\\Desktop\\GrifTest\\Image 2.grif", src11);
    end = clock();   //结束时间
    cout << "GrifToMat = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    cv::imshow("1111", src);
    cv::Mat  mat22;
    src.convertTo(mat22,CV_64FC3);
    start = clock();
    WriteFile("C:\\Users\\Chen\\Desktop\\GrifTest\\doubletest.grif", mat22);
    end = clock();   //结束时间
    cout << "WriteFile doubletest = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "Image doubletest.grif", mat22, 1, 1, 1);
    end = clock();   //结束时间
    cout << "WriteGrifFile doubletest = " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
    start = clock();
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\GrifTest\\", "Image doubletest.grif.gz", mat22, 1, 1, 1);
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

// ConsoleApplication1.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <fstream>
#include <opencv2/opencv.hpp>
#include<stdlib.h>
#include<stdio.h>
#include<string.h>


using namespace std;
struct GridFile
{
    char Name[20];
    cv::Mat Content;
    size_t size;
    int type;
};

int main()
{
    GridFile grid;
    strcpy(grid.Name, "陈新城");
    grid.Content = cv::imread("D:\\PNT1A.tif",CV_64FC1);

    ofstream outFile("students.grid", ios::out | ios::binary);
    cv::Mat input = grid.Content;
    grid.size = input.total() * input.elemSize();
    grid.type = input.type();

    outFile.write((char*)&grid, sizeof(grid));
    outFile.write((char*)input.data, grid.size);
    outFile << input;
    outFile.close();

    GridFile grid1;
    ifstream inFile("students.grid", ios::in | ios::binary); //二进制读方式打开
    if (!inFile) {
        cout << "error" << endl;
        return 0;
    }
    inFile.read((char*)&grid1, sizeof(grid1));
    char* data = new char[grid1.size];
    // Read the pixels from the stringstream
    inFile.read(data, grid1.size);
    cv::Mat mat1 = cv::Mat(grid1.Content.rows, grid1.Content.cols,grid1.type,data);
    cv::imshow("22", mat1);
    cv::waitKey(0);
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

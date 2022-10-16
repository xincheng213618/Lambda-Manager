// CacheFileTest.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
#include <fstream>
#include <opencv.hpp>
using namespace std;


//使用读写同时操作时，需要用seekp(写) Seekg(读)来确定位置
int main()
{
    cv::String folder = "C:\\Users\\Chen\\Desktop\\cell000";
    std::vector<cv::String> imagePathList;
    cv::glob(folder, imagePathList);
    std::map<int,int> ChacheLen;
    std::map<int, int> ChacheLen1;

    int chache[100];
    fstream cacheFile("1.cache", ios_base::in | ios_base::out | ios::binary);
    cacheFile.seekp(ios::beg);
    for (size_t i = 0; i < imagePathList.size(); i++)
    {
        cv::Mat src = cv::imread(imagePathList[i]);

        int start = cacheFile.tellp();
        ChacheLen.insert(std::make_pair(i, start));

        ChacheLen1.insert(std::make_pair(start, src.total() * src.elemSize()));
        cacheFile.write((char*)src.data, src.total() * src.elemSize());
    }

    //cacheFile.close();
    //fstream cacheFile1("1.cache", ios::in | ios::binary);
    char* i2stream =NULL;
    clock_t start, end;
    int n=0;
    while (1)
    {
        n++;
        //start = clock();
        //cv::Mat src = cv::imread(imagePathList[n]);
        //end = clock();
        //cout << " read, " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;

        start = clock();
        //fstream cacheFile1("1.cache", ios::in | ios::binary);
        cacheFile.seekg(ChacheLen[n], ios::beg);
        if (i2stream ==NULL)
            i2stream = (char*)malloc(ChacheLen1[ChacheLen[n]]);
        
        if (!cacheFile.read(i2stream, ChacheLen1[ChacheLen[n]])) {
            throw "read failed";
        }
        ;
        //cacheFile1.close();

        cv::Mat src1(1024,1024,CV_8UC3, i2stream);
        end = clock();
        cout << "cache , " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
        cv::imshow("cache", src1);
        //cv::imshow("read", src);
        cv::waitKey(1);
        if (n == imagePathList.size() - 2) {
            n = 0;
        }
    }
    cacheFile.close();   
    //cacheFile1.close();






    std::cout << "Hello World!\n";
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

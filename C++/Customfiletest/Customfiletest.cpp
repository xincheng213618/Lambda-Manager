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
    int jsonoffset;//json的相对文件头的数据量，可以直接通过这里去读取json的内存，(如果不使用元数据，可以把这个合并在头文件中，并取消Griffile的元数据类型)

}GrifFile;

typedef struct GrifMatFile
{
    int rows;
    int cols;
    int type;
    int compression;  //0,不压缩; 1,Zlib; 2,gz
    double srcLen; //Mat.data 的长度
    double destLen; //无压缩时，destLen =0;
}GrifMatFile;

typedef struct GrifFileHeader
{
    char Name[4] = {0x67,0x72,0x69,0x66};
    int Verison; //0
    int Matoffset; //直接读取Mat数据的偏移量 int 限制了2G大小，如果需要更多，则需要float or double d但是这回让内存对齐比较麻烦
}GrifFileHeader;


int gzip_inflate(char* compr, int comprLen, char* uncompr, int uncomprLen)
{
    int err;
    z_stream d_stream; /* decompression stream */

    d_stream.zalloc = (alloc_func)0;
    d_stream.zfree = (free_func)0;
    d_stream.opaque = (voidpf)0;

    d_stream.next_in = (unsigned char*)compr;
    d_stream.avail_in = comprLen;

    d_stream.next_out = (unsigned char*)uncompr;
    d_stream.avail_out = uncomprLen;

    err = inflateInit2(&d_stream, 16 + MAX_WBITS);
    if (err != Z_OK) return err;

    while (err != Z_STREAM_END) err = inflate(&d_stream, Z_NO_FLUSH);

    err = inflateEnd(&d_stream);
    return err;
}
#define CHUNK 16384

int compressToGzip(const char* input, int inputSize, char* output, int outputSize)
{
    z_stream zs;
    zs.zalloc = Z_NULL;
    zs.zfree = Z_NULL;
    zs.opaque = Z_NULL;
    zs.avail_in = (uInt)inputSize;
    zs.next_in = (Bytef*)input;
    zs.avail_out = (uInt)outputSize;
    zs.next_out = (Bytef*)output;

    // hard to believe they don't have a macro for gzip encoding, "Add 16" is the best thing zlib can do:
    // "Add 16 to windowBits to write a simple gzip header and trailer around the compressed data instead of a zlib wrapper"
    deflateInit2(&zs, Z_DEFAULT_COMPRESSION, Z_DEFLATED, 15 | 16, 8, Z_DEFAULT_STRATEGY);
    deflate(&zs, Z_FINISH);
    deflateEnd(&zs);
    return zs.total_out;
}

int WriteFile(cv::Mat WriteMat,string FileName ,int compression = 1) {
    clock_t start, end;
    start = clock();
    ofstream outFile(FileName, ios::out | ios::binary);

    GrifFileHeader fileHeader;
    fileHeader.Verison = 0;
    int a = sizeof(GrifFileHeader);
    int b = sizeof(GrifFile);
    fileHeader.Matoffset = sizeof(GrifFileHeader) + sizeof(GrifFile);
    outFile.write((char*)&fileHeader, sizeof(GrifFileHeader));


    GrifFile grif;
    strcpy(grif.Name, "海拉");
    grif.x = 0;
    grif.y = 0;
    grif.z = 0;
    grif.rows = WriteMat.rows;
    grif.cols = WriteMat.cols;
    grif.depth = WriteMat.depth();
    outFile.write((char*)&grif, sizeof(GrifFile));


    GrifMatFile grifMat;
    grifMat.rows = WriteMat.rows;
    grifMat.cols = WriteMat.cols;
    grifMat.type = WriteMat.type();
    grifMat.srcLen = WriteMat.total() * WriteMat.elemSize();
    grifMat.compression = compression;

    if (grifMat.compression == 1) {


        const char* istream = (char*)WriteMat.data;
        uLongf srcLen = grifMat.srcLen;      // +1 for the trailing `\0`
        uLongf destLen = compressBound(srcLen); // this is how you should estimate size 
        char* ostream = (char*)malloc(destLen);
        int res = compress((Bytef*)ostream, &destLen, (Bytef*)istream, srcLen);
        if (res == Z_BUF_ERROR) {
            printf("Buffer was too small!\n");
            return -1;
        }
        if (res == Z_MEM_ERROR) {
            printf("Not enough memory for compression!\n");
            return -2;
        }
        //char* ostream1 = (char*)malloc(destLen);
        //uLongf destLen1 = compressBound(srcLen); // this is how you should estimate size 

        //int b = compressToGzip(istream, srcLen, ostream1, destLen1);

        grifMat.destLen = destLen;
        outFile.write((char*)&grifMat, sizeof(GrifMatFile));
        outFile.write(ostream, grifMat.destLen);
    }
    else if (grifMat.compression == 0)
    {
        outFile.write((char*)&grifMat, sizeof(GrifMatFile));
        outFile.write((char*)WriteMat.data, grifMat.srcLen);
    }

    std::streampos sp = outFile.tellp();      //获取文件大小
    cout<< FileName <<":  " << sp / 1024 << "KB" ;
    end = clock();
    cout << " , " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;

    outFile.close();
    return 0;

}


cv::Mat ReadFile(string FileName) {
    ifstream inFile(FileName, ios::in | ios::binary); //二进制读方式打开
    if (!inFile) {
        return cv::Mat::zeros(0, 0, CV_8UC3);
    }
    GrifFileHeader grifheader;
    inFile.read((char*)&grifheader, sizeof(GrifFileHeader));
    if (std::string("grif").compare(grifheader.Name))
    {
        return cv::Mat::zeros(0, 0, CV_8UC3);
    }
    inFile.seekg(grifheader.Matoffset, ios::beg);
    GrifMatFile grifMat;
    inFile.read((char*)&grifMat, sizeof(GrifMatFile));
    if (grifMat.compression == 1)
    {
        char* i2stream = new char[grifMat.destLen];
        // Read the pixels from the stringstream
        inFile.read(i2stream, grifMat.destLen);

        char* o2stream = (char*)malloc(grifMat.srcLen);
        uLongf destLen2 = grifMat.destLen;
        uLongf srcLen = grifMat.srcLen;

        int des = uncompress((Bytef*)o2stream, &srcLen, (Bytef*)i2stream, destLen2);
        return cv::Mat(grifMat.rows, grifMat.cols, grifMat.type, o2stream);
    }
    else if (grifMat.compression == 0)
    {
        char* data = new char[grifMat.srcLen];
        // Read the pixels from the stringstream
        inFile.read(data, grifMat.srcLen);
        cv::Mat mat1 = cv::Mat(grifMat.rows, grifMat.cols, grifMat.type, data);
        return mat1;
    }
    return cv::Mat::zeros(0, 0, CV_8UC3);
}

GrifFile ReadFileHeader(string FileName) {
    GrifFile gridFile{};

    ifstream inFile(FileName, ios::in | ios::binary); //二进制读方式打开
    if (!inFile) {
        cout << "error" << endl;
        return gridFile;
    }
    GrifFileHeader grifheader;
    inFile.read((char*)&grifheader, sizeof(GrifFileHeader));
    if (std::string("grif").compare(grifheader.Name))
    {
        return gridFile;
    }
    inFile.read((char*)&gridFile, sizeof(gridFile));
    return gridFile;
}


int GrifToMat(std::string path, cv::Mat& src)
{


    cv::FileStorage hFs;
    //打开需要读取的路径和文件，将data写入到Mat中
    if (hFs.open(path, cv::FileStorage::READ))
    {
        std::vector<uchar> vData;
        int x = 0;
        hFs["x"] >> x;

        hFs["data"] >> src;
        hFs.release();
        return x;
    }
    return -1;
}

int WriteGrifFile(std::string path, std::string name, cv::Mat src, int x, int y, int z)
{
    clock_t start, end;
    start = clock();
    cv::FileStorage hFs;
    //打开需要创建的路径和文件,将xyz位移台信息和Mat数据写入到文件中
    if (hFs.open((path + name), cv::FileStorage::WRITE_BASE64))
    {
        hFs << "x" << x;
        hFs << "y" << y;
        hFs << "z" << z;
        hFs << "data" << src;
        hFs.release();
        end = clock();
        cout << path + name <<":  " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
        return 0;
    }
    return -1;
}
int GrifToMatGz(std::string path, cv::Mat& src)
{
    string newName = path + ".gz";
    GrifToMat(newName,src);
    return 0;
}

int WriteGrifFileGz(std::string path, std::string name, cv::Mat src, int x, int y, int z)
{
    WriteGrifFile(path,name +".gz",src,x,y,z);
    return 0;
}

void OsWrite(std::string path, cv::Mat src) {
    ofstream outFile1(path, ios::out | ios::binary);
    outFile1.write((char*)src.data, src.total() * src.elemSize());
    outFile1.close();
}
void OsWrite1(std::string path, cv::Mat src) {
    ofstream outFile1(path, ios::out | ios::binary);
    outFile1 << src;
    outFile1.close();
}

int main()
{
    clock_t start, end;

    cv::Mat TestMat = cv::imread("D:\\PNT1A.tif", CV_64FC1);
    int i = sizeof(TestMat);

    WriteFile(TestMat, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A.grif");
    WriteFile(TestMat, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A0.grif",0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "PNT1A2.grif", TestMat,1,1,1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "PNT1A2.grif.gz", TestMat, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A3.grif",TestMat);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A4.grif", TestMat);

    cv::Mat TestMat0 = ReadFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A0.grif");
    cv::Mat TestMat1 = ReadFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1A.grif");


    cv::Mat PNT1B = cv::imread("D:\\PNT1B.tif", CV_64FC1);
    WriteFile(PNT1B, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1B.grif");
    WriteFile(PNT1B, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\PNT1B0.grif", 0);
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


    WriteFile(src, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src.grif");
    WriteFile(src, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src0.grif", 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "src2.grif", src, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "src2.grif.gz", src, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src3.grif", src);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\src4.grif", src);

    cv::Mat  srcdouble;
    src.convertTo(srcdouble, CV_64FC3, 1.0 / 255.0);
    WriteFile(srcdouble, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble.grif");
    WriteFile(srcdouble, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble0.grif", 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "srcdouble2.grif", srcdouble, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "srcdouble2.grif.gz", srcdouble, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble3.grif", srcdouble);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\srcdouble4.grif", srcdouble);

    cv::Mat test = cv::imread("D:\\test.bmp");
    WriteFile(test, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test.grif");
    WriteFile(test, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test0.grif", 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "test2.grif", test, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "test2.grif.gz", test, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test3.grif", test);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\test4.grif", test);

    cv::Mat  ZeroTest = cv::Mat::zeros(2448,2048,CV_8UC3);
    WriteFile(ZeroTest, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest.grif");
    WriteFile(ZeroTest, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest0.grif", 0);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "ZeroTest2.grif", ZeroTest, 1, 1, 1);
    WriteGrifFile("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\", "ZeroTest.grif.gz", ZeroTest, 1, 1, 1);
    OsWrite("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest3.grif", ZeroTest);
    OsWrite1("C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\ZeroTest4.grif", ZeroTest);


    start = clock();
    WriteFile(src, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\testWrite.grif");
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
    WriteFile(mat22, "C:\\Users\\Chen\\Desktop\\lamda 备份\\lambda\\doubletest.grif");
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

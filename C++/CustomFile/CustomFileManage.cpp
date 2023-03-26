// ConsoleApplication1.cpp : ���ļ����� "main" ����������ִ�н��ڴ˴���ʼ��������
//
#include "pch.h"
#include "CustomFileManage.h"

#include <Windows.h>
#include <iostream>
#include <fstream>
#include <opencv2/opencv.hpp>
#include<stdlib.h>
#include<stdio.h>
#include<string.h>
#include "zlib.h"

using namespace std;

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

int CustomFile::WriteFile(string path, GrifFile grifFileInfo, cv::Mat src, int compression)
{
	ofstream outFile(path, ios::out | ios::binary);

	GrifFileHeader fileHeader;
	fileHeader.Verison = 0;
	int a = sizeof(GrifFileHeader);
	int b = sizeof(GrifFile);
	fileHeader.Matoffset = sizeof(GrifFileHeader) + sizeof(GrifFile);
	outFile.write((char*)&fileHeader, sizeof(GrifFileHeader));

	GrifFile grif;
	strcpy_s(grif.Name, "����");
	grif.x = 0;
	grif.y = 0;
	grif.z = 0;
	grif.rows = src.rows;
	grif.cols = src.cols;
	grif.depth = src.depth();
	outFile.write((char*)&grif, sizeof(GrifFile));

	GrifMatFile grifMat;
	grifMat.rows = src.rows;
	grifMat.cols = src.cols;
	grifMat.type = src.type();
	grifMat.srcLen = src.total() * src.elemSize();
	grifMat.compression = compression;

	if (grifMat.compression == 1)
	{
		const char* istream = (char*)src.data;
		uLongf srcLen = (uLongf)grifMat.srcLen; // +1 for the trailing `\0`
		uLongf destLen = compressBound(srcLen); // this is how you should estimate size 
		char* ostream = (char*)malloc(destLen);
		int res = compress((Bytef*)ostream, &destLen, (Bytef*)istream, srcLen);
		if (res == Z_BUF_ERROR)
		{
			printf("Buffer was too small!\n");
			return -1;
		}
		if (res == Z_MEM_ERROR)
		{
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
		outFile.write((char*)src.data, grifMat.srcLen);
	}
	outFile.close();
	return 0;
}

int CustomFile::WriteFile(string path, cv::Mat src, int compression)
{
	GrifFile gridFile{};
	return WriteFile(path, gridFile, src, compression);
}

cv::Mat CustomFile::ReadFile(string path)
{
	ifstream inFile(path, ios::in | ios::binary); //�����ƶ���ʽ��
	if (!inFile)
	{
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
		char* i2stream = (char*)malloc(grifMat.srcLen);
		// Read the pixels from the stringstream
		inFile.read(i2stream, grifMat.destLen);

		char* o2stream = (char*)malloc(grifMat.srcLen);
		uLongf destLen2 = (uLongf)grifMat.destLen;
		uLongf srcLen = (uLongf)grifMat.srcLen;


		int des = uncompress((Bytef*)o2stream, &srcLen, (Bytef*)i2stream, destLen2);
		return cv::Mat(grifMat.rows, grifMat.cols, grifMat.type, o2stream);
		cv::Mat mat1 = cv::Mat(grifMat.rows, grifMat.cols, grifMat.type, o2stream);
		free(o2stream);
		free(i2stream);
		return mat1;
	}
	else if (grifMat.compression == 0)
	{
		char* data = (char*)malloc(grifMat.srcLen);
		// Read the pixels from the stringstream
		inFile.read(data, grifMat.srcLen);
		cv::Mat mat1 = cv::Mat(grifMat.rows, grifMat.cols, grifMat.type, data);
		free(data);
		return mat1;
	}
	return cv::Mat::zeros(0, 0, CV_8UC3);
}

GrifFile CustomFile::ReadFileHeader(string path)
{
	GrifFile gridFile{};

	ifstream inFile(path, ios::in | ios::binary); //�����ƶ���ʽ��
	if (!inFile)
	{
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

int CustomFile::GrifToMat(std::string path, cv::Mat& src)
{
	cv::FileStorage hFs;
	//����Ҫ��ȡ��·�����ļ�����dataд�뵽Mat��
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

int CustomFile::WriteGrifFile(std::string path, std::string name, cv::Mat src, int x, int y, int z)
{
	clock_t start, end;
	start = clock();
	cv::FileStorage hFs;
	//����Ҫ������·�����ļ�,��xyzλ��̨��Ϣ��Mat����д�뵽�ļ���
	if (hFs.open((path + name), cv::FileStorage::WRITE_BASE64))
	{
		hFs << "x" << x;
		hFs << "y" << y;
		hFs << "z" << z;
		hFs << "data" << src;
		hFs.release();
		end = clock();
		cout << path + name << ":  " << double(end - start) / CLOCKS_PER_SEC << "s" << endl;
		return 0;
	}
	return -1;
}

int CustomFile::GrifToMatGz(std::string path, cv::Mat& src)
{
	string newName = path + ".gz";
	GrifToMat(newName, src);
	return 0;
}

int CustomFile::WriteGrifFileGz(std::string path, std::string name, cv::Mat src, int x, int y, int z)
{
	WriteGrifFile(path, name + ".gz", src, x, y, z);
	return 0;
}

void CustomFile::OsWrite(std::string path, cv::Mat src)
{
	ofstream outFile1(path, ios::out | ios::binary);
	outFile1.write((char*)src.data, src.total() * src.elemSize());
	outFile1.close();
}

void CustomFile::OsWrite1(std::string path, cv::Mat src)
{
	ofstream outFile1(path, ios::out | ios::binary);
	outFile1 << src;
	outFile1.close();
}

int WriteFileCache(std::string path, cv::Mat src)
{
	GrifFile gridFile{};
	return WriteFileCache(path, gridFile, src);
}

std::mutex mtx;
std::queue <std::string> FilePathCache;

void WriteFileThread()
{
	int SleepTime = 5000;
	while (true)
	{
		Sleep(SleepTime);
		std::unique_lock<std::mutex> lock(mtx);
		if (FilePathCache.size() == 0)
		{
			SleepTime = 5000;
			lock.unlock();
			continue;
		}
		SleepTime = 1;
		std::string path = FilePathCache.front();
		FilePathCache.pop();
		lock.unlock();
		cv::Mat Temp = CustomFile::ReadFile(path);
		CustomFile::WriteFile(path + ".tmp", Temp);

		if (remove(path.c_str()) == 0)
		{
			cout << "ɾ���ɹ�" << endl;
			if (rename((path + ".tmp").c_str(), path.c_str()) != 0)
			{
				cout << "�������ɹ�" << endl;
			}
		}
		else
		{
			cout << "ɾ��ʧ��" << endl;
		}
	}
}

std::thread writethread(WriteFileThread);
bool iswritethreadini = false;
int WriteFileCache(std::string path, GrifFile grifFileInfo, cv::Mat src)
{
	if (!iswritethreadini)
	{
		writethread.detach();
		iswritethreadini = true;
	}
	CustomFile::WriteFile(path, grifFileInfo, src, 0);
	std::unique_lock<std::mutex> lock(mtx);
	FilePathCache.push(path);
	lock.unlock();
	return 0;
}

int CustomFile::IsGrifFile(std::string path)
{
	ifstream inFile(path, ios::in | ios::binary); //�����ƶ���ʽ��

	if (!inFile)
	{
		return -2;
	}

	GrifFileHeader grifheader;
	inFile.read((char*)&grifheader, sizeof(GrifFileHeader));

	if (std::string("grif").compare(grifheader.Name))
	{
		return 0;
	}

	return -1;
}

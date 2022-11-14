#include "GrifCustomFile.h"
#include <fstream>
#include <zlib.h>

GrifCustomFile::GrifCustomFile(std::string FilePath) {
	this->FilePath = FilePath;
}

GrifCustomFile::~GrifCustomFile()
{

}

int GrifCustomFile::WriteMat(std::fstream* oswrite, cv::Mat src, int compression)
{
    GrifMatFile grifMat;
    grifMat.rows = src.rows;
    grifMat.cols = src.cols;
    grifMat.type = src.type();
    grifMat.srcLen = src.total() * src.elemSize();
    grifMat.compression = compression;

    if (grifMat.compression == 1) {
        const char* istream = (char*)src.data;
        uLongf srcLen = (uLongf)grifMat.srcLen;      // +1 for the trailing `\0`
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

        grifMat.destLen = destLen;
        oswrite->write((char*)&grifMat, sizeof(GrifMatFile));
        oswrite->write(ostream, grifMat.destLen);
    }
    else if (grifMat.compression == 0)
    {
        oswrite->write((char*)&grifMat, sizeof(GrifMatFile));
        oswrite->write((char*)src.data, grifMat.srcLen);
    }
    else if (grifMat.compression == 2) {
        const char* istream = (char*)src.data;
        uLongf srcLen = (uLongf)grifMat.srcLen;      // +1 for the trailing `\0`
        uLongf destLen = compressBound(srcLen); // this is how you should estimate size 
        char* ostream1 = (char*)malloc(destLen);
        uLongf destLen1 = compressBound(srcLen); // this is how you should estimate size 
        int b = compressToGzip(istream, srcLen, ostream1, destLen1);
        oswrite->write((char*)&grifMat, sizeof(GrifMatFile));
        oswrite->write((char*)ostream1, grifMat.srcLen);
    }
    return 0;
}

int GrifCustomFile::WriteGrifFileHeader(std::fstream* oswrite)
{
    oswrite->seekp(std::ios::beg);
    oswrite->write((char*)&grifFileHeader, sizeof(GrifFileHeader));
    return 0;
}


bool GrifCustomFile::IsGrif()
{
    std::fstream inFile(FilePath, std::ios_base::in | std::ios_base::out | std::ios::binary); //二进制读方式打开
    if (!inFile) {
        return false;
    }
    inFile.read((char*)&grifFileHeader, sizeof(GrifFileHeader));
    if (std::string("grif").compare(grifFileHeader.Name))
    {
        return true;
    }
	return false;
}



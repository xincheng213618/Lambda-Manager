#pragma once
#include <iostream>
#include <opencv2/opencv.hpp>
#include "Customfile.h"




class GrifCustomFile
{
private:
	std::string FilePath;
	bool IsGrif = false;
	GrifFileHeader grifFileHeader;
	GrifCustomFile(std::string FilePath);
public:
	~GrifCustomFile();
	int WriteMat(std::fstream* oswrite, cv::Mat src, int compression);
	bool IsGrif();

};


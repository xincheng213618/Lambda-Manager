#include "pch.h"
#include "DPC.h"

int LEDBright()
{
	Logger::Log1(Severity::INFO, "Invoke LEDBright()");
	return 0;
}

int LEDDark()
{
	Logger::Log1(Severity::INFO, "Invoke LEDBright()");
	return 0;
}

int ChangeMagnification(int mag)
{
	Logger::Log2(Severity::INFO, L"Invoke ChangeMagnification(mag=%d)",mag);
	return 0;
}

int ChangeDPCMode(int dpc) {
	Logger::Log2(Severity::INFO, L"Invoke ChangeDPCMode(dpc=%d)", dpc);
	return 0;
}

int DICImgCalculate(HIMAGE image1, HIMAGE image2, HIMAGE image)
{
	Logger::Log2(Severity::INFO, L"Invoke DICImgCalculate(image1: %p, image2:%p, <out> image: %p)", image1, image2, image);
	return 0;
}

int DICImgCalculate4(HIMAGE imageU, HIMAGE imageD, HIMAGE imageL, HIMAGE imageR, HIMAGE imageLR, HIMAGE imageUD)
{
	Logger::Log2(Severity::INFO, L"Invoke DICImgCalculate(imageU: %p, imageD:%p, imageL: %p, imageR:%p, <out> imageLR: %p, <out> imageUD: %p)", \
		imageU, imageD, imageL, imageR, imageLR, imageUD);
	return 0;
}

int CalcPhaseContrast(HIMAGE imageLR, HIMAGE imageUD, HIMAGE imagePC)
{
	Logger::Log2(Severity::INFO, L"Invoke CalcPhaseContrast(imageLR: %p, imagePC:%p, <out> imagePC: %p)", imageLR, imageUD, imagePC);
	return 0;
}

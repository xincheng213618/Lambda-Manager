#include "pch.h"
#include <common.h>
#include "ExportManage.h"
#include "CustomFileManage.h"
#include "zip.h"
#include "unzip.h"

int CExportManage::GrifToFile(const char* json)
{
	const auto jData = json::parse(json);
	_m_cConfig.ExportGrifJson(jData);

	const cv::Mat mTemp = CustomFile::ReadFile(_m_cConfig.m_sFullName);

	//if (_m_cConfig.m_bSavedCalloutContent == true)
	//{
	//	for (auto& it : _m_vGeometry)
	//	{
	//		if (it.Type == "Line")
	//		{
	//			cv::line(mTemp, cv::Point(it.PointList.at(0).X, it.PointList.at(0).Y),
	//				cv::Point(it.PointList.at(1).X, it.PointList.at(1).Y),
	//				cv::Scalar(it.Color.B, it.Color.G, it.Color.R, it.Color.A),
	//				it.LineWidth, cv::LINE_AA, 0);
	//		}
	//	}
	//}

	std::string sPath = StringUtils::Multi2Utf8(_m_cConfig.m_sExportFullName.c_str());
	cv::imwrite(sPath, mTemp);
	//std::string path = "C:\\Users\\admin\\Desktop\\中文.bmp";
	//cv::Mat mTemp = cv::Mat::zeros(960, 1280, CV_8UC3);
	//cv::imwrite(path, mTemp);
	return 0;
}

int CExportManage::SerialToFile(const char* json)
{
	std::string sTmp = StringUtils::Multi2Utf8(json);
	const auto jData = json::parse(sTmp);
	_m_cConfig.ExportSerialJson(jData);
	//Logger::Log1(Severity::INFO, sTmp);

	switch (_m_cConfig.m_nKinds)
	{
	case 0:
		SerialToMp4();
		break;
	case 1:
		SerialToAvi();
		break;
	case 2:
	case 3:
	case 4:
	case 5:
		SerialToImageFormat(_m_sSeriesKinds[_m_cConfig.m_nKinds]);
		break;
	}

	return 0;
}

int CExportManage::DrawingToFile(const char* data)
{
	Logger::Log1(Severity::INFO, "DrawingToFile");
	std::string sTmp = StringUtils::Multi2Utf8(data);
	const auto jData = json::parse(sTmp);
	_m_vGeometry = jData.get<std::vector<tpt::GEOMETRY>>();

	return 0;
}

int CExportManage::SerialToMp4()
{
	//比如：.avi格式可以使用“DIVX”、“MPEG”、“MJPG”等fourcc；*.mp4可以使用“mp4v” …。
	cv::VideoWriter hWriter;
	hWriter.open(_m_cConfig.m_sExportFullName, cv::VideoWriter::fourcc('M', 'P', '4', 'V'),
		10, cv::Size(1280, 960));

	for (int i = 0; i < _m_cConfig.m_vFrameList.size(); i++)
	{
		const cv::Mat mFrame = CustomFile::ReadFile(_m_cConfig.m_vFrameList[i]);
		hWriter.write(mFrame);
	}

	hWriter.release();
	return 0;
}

int CExportManage::SerialToAvi()
{
	cv::VideoWriter hWriter;
	hWriter.open(_m_cConfig.m_sExportFullName, cv::VideoWriter::fourcc('M', 'J', 'P', 'G'),
		10, cv::Size(1280, 960));

	for (int i = 0; i < _m_cConfig.m_vFrameList.size(); i++)
	{
		const cv::Mat mFrame = CustomFile::ReadFile(_m_cConfig.m_vFrameList[i]);
		hWriter.write(mFrame);
	}

	hWriter.release();
	return 0;
}

int CExportManage::SerialToImageFormat(std::string format)
{
	HZIP hz = CreateZip(StringUtils::string2wstring(_m_cConfig.m_sExportFullName).c_str(), nullptr);

	for (int i = 0; i < _m_cConfig.m_vFrameList.size(); i++)
	{
		cv::Mat mFrame = CustomFile::ReadFile(_m_cConfig.m_vFrameList[i]);
		std::string sPath;

		if (_m_cConfig.m_bUseDirectory)
		{
			size_t nS = _m_cConfig.m_vFrameList[i].rfind("\\Serial") + 1;
			size_t nE = _m_cConfig.m_vFrameList[i].rfind(".");
			sPath = _m_cConfig.m_vFrameList[i].substr(nS, nE - nS);
		}
		else
		{
			size_t nS = _m_cConfig.m_vFrameList[i].rfind("\\") + 1;
			size_t nE = _m_cConfig.m_vFrameList[i].rfind(".");
			sPath = _m_cConfig.m_vFrameList[i].substr(nS, nE - nS);
		}

		//Logger::Log1(Severity::INFO, sPath);
		std::vector<uchar> vImage;
		cv::imencode(format, mFrame, vImage);
		ZipAdd(hz, StringUtils::string2wstring(sPath + format).c_str(), vImage.data(), vImage.size());
	}

	CloseZip(hz);
	return 0;
}

int CExportManage::ImageExportZip(std::string path, std::string format, std::vector<cv::Mat>& src)
{
	HZIP hz = CreateZip(StringUtils::string2wstring(path).c_str(), nullptr);

	for (int i = 0; i < src.size(); i++)
	{
		std::vector<uchar> vImage;
		cv::imencode(format, src[i], vImage);
		ZipAdd(hz, StringUtils::string2wstring("Image" + std::to_string(i) + format).c_str(),
			vImage.data(), vImage.size());
	}

	CloseZip(hz);

	return 0;
}

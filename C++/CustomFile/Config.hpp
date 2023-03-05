#pragma once

#include <common.h>

class CConfig
{
public:
	void ExportGrifJson(const json& j)
	{
		m_sExportFullName = j.at("ExportFullName").get<std::string>(); //保存目录
		m_bOutputOverlayImage = j.at("OutputOverlayImage").get<bool>(); //输出叠加图像
		m_bUseDirectory = j.at("UseDirectory").get<bool>(); //使用目录
		m_bSavedCalloutContent = j.at("SavedCalloutContent").get<bool>(); //使用保存的标注内容
		m_bSaveOriginalImage = j.at("SaveOriginalImage").get<bool>(); //保存原始图像
		m_bExportView = j.at("ExportView").get<bool>(); //导出视图
		m_bExportViewROI = j.at("ExportViewROI").get<bool>(); //导出兴趣区域(ROI)
		m_bExportAllImages = j.at("ExportAllImages").get<bool>(); //导出全部图像
		m_bPhotoTime = j.at("PhotoTime").get<bool>(); //拍照时间
		m_bRelativeInterval = j.at("RelativeInterval").get<bool>(); //相对开始采集时间间隔
		m_bRulerInformation = j.at("RulerInformation").get<bool>(); //标尺信息
		m_bDimensionInformation = j.at("DimensionInformation").get<bool>(); //维度信息
		m_sFullName = j.at("FullName").get<std::string>(); //图像路径
		m_nKinds = j.at("Kinds").get<int>(); //图像格式类型
	}

	void ExportSerialJson(const json& j)
	{
		m_sExportFullName = j.at("ExportFullName").get<std::string>();
		m_bOutputOverlayImage = j.at("OutputOverlayImage").get<bool>();
		m_bUseDirectory = j.at("UseDirectory").get<bool>();
		m_bSavedCalloutContent = j.at("SavedCalloutContent").get<bool>();
		m_bSaveOriginalImage = j.at("SaveOriginalImage").get<bool>();
		m_bExportView = j.at("ExportView").get<bool>();
		m_bExportViewROI = j.at("ExportViewROI").get<bool>();
		m_bExportAllImages = j.at("ExportAllImages").get<bool>();
		m_bPhotoTime = j.at("PhotoTime").get<bool>();
		m_bRelativeInterval = j.at("RelativeInterval").get<bool>();
		m_bRulerInformation = j.at("RulerInformation").get<bool>();
		m_bDimensionInformation = j.at("DimensionInformation").get<bool>();
		m_sFullName = j.at("FullName").get<std::string>();
		m_nKinds = j.at("Kinds").get<int>();
		m_vMode = j.at("Mode").get<std::vector<std::string>>();
		m_vFrameList = j.at("FrameList").get<std::vector<std::string>>();
	}

	//导出系列
	std::string m_sExportFullName;
	bool m_bOutputOverlayImage{};
	bool m_bUseDirectory{};
	bool m_bSavedCalloutContent{};
	bool m_bSaveOriginalImage{};
	bool m_bExportView{};
	bool m_bExportViewROI{};
	bool m_bExportAllImages{};
	bool m_bPhotoTime{};
	bool m_bRelativeInterval{};
	bool m_bRulerInformation{};
	bool m_bDimensionInformation{};
	std::string m_sFullName;
	int m_nKinds{};
	std::vector<std::string> m_vMode;
	std::vector<std::string> m_vFrameList;
};

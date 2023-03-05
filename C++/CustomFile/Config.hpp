#pragma once

#include <common.h>

class CConfig
{
public:
	void ExportGrifJson(const json& j)
	{
		m_sExportFullName = j.at("ExportFullName").get<std::string>(); //����Ŀ¼
		m_bOutputOverlayImage = j.at("OutputOverlayImage").get<bool>(); //�������ͼ��
		m_bUseDirectory = j.at("UseDirectory").get<bool>(); //ʹ��Ŀ¼
		m_bSavedCalloutContent = j.at("SavedCalloutContent").get<bool>(); //ʹ�ñ���ı�ע����
		m_bSaveOriginalImage = j.at("SaveOriginalImage").get<bool>(); //����ԭʼͼ��
		m_bExportView = j.at("ExportView").get<bool>(); //������ͼ
		m_bExportViewROI = j.at("ExportViewROI").get<bool>(); //������Ȥ����(ROI)
		m_bExportAllImages = j.at("ExportAllImages").get<bool>(); //����ȫ��ͼ��
		m_bPhotoTime = j.at("PhotoTime").get<bool>(); //����ʱ��
		m_bRelativeInterval = j.at("RelativeInterval").get<bool>(); //��Կ�ʼ�ɼ�ʱ����
		m_bRulerInformation = j.at("RulerInformation").get<bool>(); //�����Ϣ
		m_bDimensionInformation = j.at("DimensionInformation").get<bool>(); //ά����Ϣ
		m_sFullName = j.at("FullName").get<std::string>(); //ͼ��·��
		m_nKinds = j.at("Kinds").get<int>(); //ͼ���ʽ����
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

	//����ϵ��
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

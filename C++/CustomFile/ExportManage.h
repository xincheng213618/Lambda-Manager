#pragma once

#include "Config.hpp"

namespace tpt
{
	struct COLOR
	{
		std::string ColorContext{};
		int A{};
		int R{};
		int G{};
		int B{};
		double ScA{};
		double ScR{};
		double ScG{};
		double ScB{};
	};

	struct WINPROPERTY
	{
		int ActiveWin{};
		double Ratio{};
		int AcWidth{};
		int AcHight{};
	};

	struct POINT
	{
		double X{};
		double Y{};
	};

	struct TEXT
	{
		std::string Content{};
		COLOR TextColor{};
		int FontSize{};
		std::string FontFamily{};
		bool Bold{};
		bool Italic{};
		bool UnderLine{};
		POINT Point1{};
		bool ShowText{};
		std::string TextPos{};
	};

	struct GEOMETRY
	{
		std::string Type{};
		int LineWidth{};
		int LineType{};
		COLOR Color{};
		WINPROPERTY WinProperty{};
		std::vector<POINT> PointList{};
		TEXT Text{};
	};

	inline void from_json(const json& j, COLOR& a)
	{
		a.R = j["R"].get<int>();
		a.G = j["G"].get<int>();
		a.B = j["B"].get<int>();
		a.A = j["A"].get<int>();
	}

	inline void from_json(const json& j, WINPROPERTY& b)
	{
		b.ActiveWin = j["ActiveWin"].get<int>();
		b.Ratio = j["ratio"].get<double>();
		b.AcWidth = j["acWidth"].get<int>();
		b.AcHight = j["acHeight"].get<int>();
	}

	inline void from_json(const json& j, POINT& c)
	{
		c.X = j["X"].get<double>();
		c.Y = j["Y"].get<double>();
	}

	inline void from_json(const json& j, TEXT& d)
	{
		d.Content = j["Content"].get<std::string>();
		d.TextColor = j["TextColor"].get<COLOR>();
		d.FontSize = j["Fontsize"].get<int>();
		d.FontFamily = j["FontFamily"].get<std::string>();
		d.Bold = j["Bold"].get<bool>();
		d.Italic = j["Italic"].get<bool>();
		d.UnderLine = j["UnderLine"].get<bool>();
		d.Point1 = j["Point1"].get<POINT>();
		d.ShowText = j["ShowText"].get<bool>();
		d.TextPos = j["TextPos"].get<std::string>();
	}

	inline void from_json(const json& j, GEOMETRY& e)
	{
		e.Type = j["Type"].get<std::string>();
		e.LineWidth = j["LineWidth"].get<int>();
		e.LineType = j["LineType"].get<int>();
		e.Color = j["Color"].get<COLOR>();
		e.WinProperty = j["winProperty"].get<WINPROPERTY>();
		e.PointList = j["PointList"].get<std::vector<POINT>>();
		e.Text = j["TexT"].get<TEXT>();
	}
}

class CExportManage
{
public:
	int GrifToFile(const char* json);
	int SerialToFile(const char* json);
	int DrawingToFile(const char* data);
	int ImageExportZip(std::string path, std::string format, std::vector<cv::Mat>& src);

private:
	const std::string _m_sGrifKinds[4] = {"png", "jpeg", "tiff", "bmp"};
	const std::string _m_sSeriesKinds[7] = {".mp4", ".avi", ".png", ".jpeg", ".tiff", ".bmp", "rar"};

	CConfig _m_cConfig;

	std::vector<tpt::GEOMETRY> _m_vGeometry;

	int SerialToMp4();
	int SerialToAvi();

	int SerialToImageFormat(std::string format);
};

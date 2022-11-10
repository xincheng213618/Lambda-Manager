#include "pch.h"
#include "denoise.h"
#include <opencv.hpp>

using namespace std;

//线程锁
std::mutex mtx;

//BM3Dmode
int BM3Dmode;

double Cdenoise=100;
double sharpen=10;
double contrast = 100;
int IsFirst1 = 10;


cv::Mat img_o;
cv::Mat img_show;
cv::Mat img_denoise;
cv::Mat img_sharpen;
cv::Mat img_postprocess;
cv::Mat image;
cv::Mat imgnew1;
cv::Mat imgnew2;
cv::Mat imgnew3;

int* q;

int AreaLimit_EGT = 2000;
int HoloLimit_EGT = 0;
int AreaLimit_DT = 0;
int HoloLimit_DT = 0;
float EGT_Finetune = 0;
float H_Index = 0;
float DT_Treshold = 0;
float a, b, c;



LambdaView* pView;
LambdaView* pView1;
LambdaView* pView2;
void LambdaViewShow(cv::Mat mat) {
	if (pView == nullptr) {
		pView = LambdaView::GetIdleOrNew();
	}
	pView->SetState(OCCUPIED);
	pView->Show(mat);
}
void LambdaViewShow1(cv::Mat mat) {
	if (pView1 == nullptr) {
		pView1 = LambdaView::GetIdleOrNew();
	}
	pView1->SetState(OCCUPIED);
	pView1->Show(mat);
}
void LambdaViewShow2(cv::Mat mat) {
	if (pView2 == nullptr) {
		pView2 = LambdaView::GetIdleOrNew();
	}
	pView2->SetState(OCCUPIED);
	pView2->Show(mat);
}


int Read_img(char* s)
{
	std::string filename = StringUtils::Multi2Utf8(s);
	img_o=cv::imread(filename);

	LambdaViewShow(img_o);
	return 0;
}





//// 预处理模块
//去噪
int BM3D(int x)
{
	BM3Dmode = x;
	Logger::Log2(Severity::INFO, L"测试: Test_BM3DMode(x=%d)", BM3Dmode);
	return  0;
}


int DENOISE_FUNCTION(double y)
{
	Cdenoise = y;
	if (BM3Dmode == 0)
	{
		Event::Trigger("BM3D_IMG", &img_o,&imgnew1,&Cdenoise, q);

	}
	else if (BM3Dmode == 1)
	{
		Event::Trigger("BILATERAL_IMG", &img_o, &imgnew1, &Cdenoise, q);
	}
	LambdaViewShow(imgnew1);
	Logger::Log1(Severity::INFO, "Invoke BM3D()");
	img_denoise = imgnew1;
	img_sharpen = imgnew1;
	img_postprocess = imgnew1;
	CellSeg();
    return  0;
}

//锐化
int Sharpen_FUNCTION(double z)
{
	if (Cdenoise == 100)
	{
		img_denoise = img_o;
	}
	sharpen = z;
	Event::Trigger("SHARPEN_IMG", &img_denoise, &imgnew2, &sharpen, q);
	LambdaViewShow(imgnew2);

	Logger::Log2(Severity::INFO, L"测试: Test_Sharpen(z=%.8lf)", sharpen);
	img_sharpen = imgnew2;
	img_postprocess = imgnew2;
	CellSeg();
	return  0;
}

//对比度
int Contrast_FUNCTION(double m)
{
	if (Cdenoise == 100)
	{
		if (sharpen==10)
		{ 
			img_sharpen = img_o;
		}
		
	}
	contrast = m;
	Event::Trigger("CONTRAST_IMG", &img_sharpen, &imgnew3, &contrast,q);
	LambdaViewShow(imgnew3);

	Logger::Log2(Severity::INFO, L"测试: Test_contrast(z=%.8lf)", contrast);

	img_postprocess = imgnew3;
	Logger::Log1(Severity::INFO, "img_postprocess = imgnew");
	CellSeg();
	return  0;
}
////


int* p1 = (int*)malloc(sizeof(int)*4);
float* k1= (float*)malloc(sizeof(float) * 3);

//// 分割模块
//分割
int array_int_receive(void* array_int)
{
	memcpy(p1, array_int, GetArraySize(array_int)*sizeof(int));
	int* p = (int*)array_int;
	AreaLimit_EGT = *p;
	HoloLimit_EGT = *(p + 1);
	AreaLimit_DT = *(p + 2);
	HoloLimit_DT = *(p + 3);
	Logger::Log2(Severity::INFO, L"array_int_receive event array: [%d, %d,%d,%d,...], size: %d", *p, *(p + 1), *(p + 2),*(p +3), GetArraySize(array_int));
	return 0;
}



int array_float_receive(void* array_float)
{
	memcpy(k1, array_float, GetArraySize(array_float) * sizeof(float));
	float* k = (float*)array_float;
	EGT_Finetune = *k;
	H_Index = *(k + 1);
	DT_Treshold = *(k + 2);
	Logger::Log2(Severity::INFO, L"array_float_receive event array: [%f, %f, %f,...], size: %d", *k, *(k + 1), *(k + 2), GetArraySize(array_float));
	CellSeg();
	return 0;
}

int CellCountDrawParameter[3] = { 1,1,1 };
bool IsCellCount = false;
cv::Mat CellCountDrawTemp;

bool IsCellSeg = false;

int CellSeg()
{
	if (IsCellSeg) {
		Logger::Log1(Severity::INFO, "未完成计算不允许重复计算");
		return 0;
	}

	IsCellSeg = true;
	if (Cdenoise == 100)
	{
		if (sharpen == 10)
		{
			if (contrast == 100)
			{
				img_postprocess = img_o;
				Logger::Log1(Severity::INFO, "Invoke cellseg_o()");
			}
		}
	}
	image = img_postprocess.clone();
	p1[0] = AreaLimit_EGT;
	p1[1] = HoloLimit_EGT;
	p1[2] = AreaLimit_DT;
	p1[3] = HoloLimit_DT;

	k1[0] = EGT_Finetune;
	k1[1] = H_Index;
	k1[2] = DT_Treshold;

	cv::Mat cellInfos;
	try {
		Event::Trigger("CELLSEG_IMG", &image, p1, k1, &cellInfos);
		Logger::Log1(Severity::INFO, "CellSegSucess");

	}
	catch(...) {
		Logger::Log1(Severity::INFO, "CellSeg 参数异常");
		IsCellSeg = false;
	}


	IsCellCount = true;
	CellCountDrawTemp = img_postprocess.clone();

	//绘制图像
	solution_ccn(image);
	//统计数据
	SetCellInfos(cellInfos);
	IsCellSeg = false;
	return 0;
}


//中心、轮廓、标号分离
int Center(int a)
{
	CellCountDrawParameter[0] = a;
	if (IsCellCount)
		solution_ccn(CellCountDrawTemp);
	return 0;
}

int Contour(int b)
{
	CellCountDrawParameter[1] = b;
	if (IsCellCount)
		solution_ccn(CellCountDrawTemp);
	return 0;
}

int Num(int c)
{
	CellCountDrawParameter[2] = c;
	if (IsCellCount)
		solution_ccn(CellCountDrawTemp);
	return 0;
}

int solution_ccn(cv::Mat DrawImage)
{
	Event::Trigger("SEPARATE", &DrawImage,&CellCountDrawParameter[0], &CellCountDrawParameter[1], &CellCountDrawParameter[2]);
	LambdaViewShow1(DrawImage);
	Logger::Log1(Severity::INFO, "Invoke DrawImage()");
	return 0;
}

int Magnification()
{
	int Mag=20;
	int mag_judge;
	if(Mag==10)
	{
		mag_judge = 0;
	}
	else if (Mag == 20)
	{
		mag_judge = 1;
	}
	Event::Trigger("Magnification", &mag_judge);
	return 0;
}

int SetCellInfos(cv::Mat cellinfos)
{
	int fixed = 1;
	int fixed1 = 2;
	json j2;
	for (size_t i = 0; i < cellinfos.rows; i++)
	{
		float area = cellinfos.ptr<float>(i)[0];
		float per = cellinfos.ptr<float>(i)[1];
		int xdot = cellinfos.ptr<float>(i)[2];
		int ydot = cellinfos.ptr<float>(i)[3];
		json cellinfo;
		cellinfo["ID"] = std::to_string(i+1);
		auto area_str= std::to_string(area);
		area_str =area_str.substr(0, area_str.find(".") + fixed + 1);
		cellinfo["Areas"] = area_str;
		auto per_str = std::to_string(per);
		per_str = per_str.substr(0, per_str.find(".") + fixed1 + 1);
		cellinfo["Perimere"] = per_str;
		cellinfo["Xdot"] = std::to_string(xdot);
		cellinfo["Ydot"] = std::to_string(ydot);
		cellinfo["Centroid"] = "[" + std::to_string(xdot) + "," + std::to_string(ydot) + "]";
		j2[i] = cellinfo;
	}
	json j3;
	j3["cellinfos"] = j2.dump().c_str();
	Event::Trigger("SET_CELL_INFOS", &j3);
	return 0;
}



//展示图
int Show_img(cv::Mat& imgnew)
{
	img_show = imgnew;
	if (IsFirst1 == 10)
	{
		pView1 = LambdaView::GetIdleOrNew();
		pView1->Show(img_show);
		Logger::Log1(Severity::INFO, "pView1 new show");
		IsFirst1 = 100;
	}
	else
	{
		pView1->SetState(UNINITIALIZED);
		pView1->SetState(OCCUPIED);
		pView1->Show(img_show);
		Logger::Log1(Severity::INFO, "pView1 show");
	}
	return 0;
}


int image_phaseMat_hist()
{
	cv::Mat phase_rescontruction;
	img_postprocess.convertTo(phase_rescontruction, CV_8UC1, 0, 255);
	int numbins_low = 0;
	int numbins_high = 255;
	int width = 800;
	int height = 600;
	int numbins = 150;
	float bin_range[2] = { 0,255 };
	const float* ranges[1] = { bin_range };
	const int bin = 256;
	int binStep = cvRound((float)width / (float)(numbins_high - numbins_low));
	cv::Mat phaseMat_hist;
	cv::Mat hist_canvas(height, width, CV_8UC3, cv::Scalar(89, 89, 89));
	cv::Mat phase_rescontruction_normalize;
	normalize(phase_rescontruction, phase_rescontruction_normalize, 0, 255, cv::NORM_MINMAX);
	calcHist(&phase_rescontruction_normalize, 1, 0, cv::Mat(), phaseMat_hist, 1, &bin, ranges, true, false);
	//cv::randu(phaseMat_hist, Scalar::all(0), Scalar::all(255));
	normalize(phaseMat_hist, phaseMat_hist, 0, height, cv::NORM_MINMAX);
	Logger::Log2(Severity::INFO, L"测试: phaseMat_hist.cols = %d rows = %d", phaseMat_hist.cols, phaseMat_hist.rows);
	for (int i = numbins_low; i < numbins_high; i++)
	{
		int j = i - numbins_low + 1;
		line(hist_canvas, cv::Point((binStep * (j)+binStep * (j - 1)) / 2, height),
			cv::Point((binStep * (j)+binStep * (j - 1)) / 2, height - cvRound(phaseMat_hist.at<float>(i - 1))), cv::Scalar(255, 255, 255), binStep, 8, 0);
	}
	hist_canvas += cv::Scalar::all(1);
	log(hist_canvas, hist_canvas);
	cv::imshow("histImage", hist_canvas);
	cv::waitKey(0);
	return 0;
}

// 可以使用 StringUtils::Multi2Utf8替换
std::string UTF8ToGB(const char* str)
{
	string result;
	WCHAR* strSrc;
	LPSTR szRes;
	int i = MultiByteToWideChar(CP_UTF8, 0, str, -1, NULL, 0);
	strSrc = new WCHAR[i + 1];
	MultiByteToWideChar(CP_UTF8, 0, str, -1, strSrc, i);

	i = WideCharToMultiByte(CP_ACP, 0, strSrc, -1, NULL, 0, NULL, NULL);
	szRes = new CHAR[i + 1];
	WideCharToMultiByte(CP_ACP, 0, strSrc, -1, szRes, i, NULL, NULL);

	result = szRes;
	delete[]strSrc;
	delete[]szRes;
	return result;
}

#include "pch.h"
#include "LFOCM.h"
#include <common.h>
#include <string>
#include <opencv.hpp>
#include "DH.h"




int PlayFilm(std::string fileName);
void ConsumerTask();
int OpenVideo(char* FullPath)
{
	//std::wstring fp = StringUtils::string2wstring(FullPath);
	std::string FullPath1 = StringUtils::Multi2Utf8(FullPath);
	std::thread producer(PlayFilm, FullPath1);
	std::thread consumer1(ConsumerTask);
	std::thread consumer2(ConsumerTask);
	std::thread consumer3(ConsumerTask);
	std::thread consumer4(ConsumerTask);

	producer.detach();
	consumer1.detach();
	consumer2.detach();
	consumer3.detach();
	consumer4.detach();
	return  0;
}
std::mutex mtx; // 互斥量,保护产品缓冲区
std::condition_variable not_full;
std::condition_variable not_empty;

std::queue <cv::Mat> MatCache;
LambdaView* pView = LambdaView::GetIdleOrNew();
LambdaView* pView1 = LambdaView::GetIdleOrNew();


void ConsumerTask() // 消费者任务
{
	while (1) {
		Mat frame;
		if (MatCache.size() == 0) {
			continue;

		}
		else {
			frame = MatCache.front();
			MatCache.pop();
			Logger::Log2(Severity::INFO, L"id[%d]", std::this_thread::get_id());
		}

		pView->Show(frame);
		cvtColor(frame, frame, COLOR_BGR2GRAY);

		Mat fft_DH, fft_magnitude;
		fft2(frame, fft_DH, fft_magnitude);
		fftshift(fft_DH);
		normalize(fft_magnitude, fft_magnitude, 0, 255, NORM_MINMAX);
		Mat fft_magnitude1;
		fft_magnitude.convertTo(fft_magnitude1, CV_8UC1);
		pView1->Show(fft_magnitude1);
		//cv::imshow("fft_DH", fft_DH);

		Mat sample, ifft_DH, sample_phi, sample_norm;
		AutoSpectrumSelection(fft_DH, fft_magnitude, sample, 0.5, 4.4, 20.0, 0.532);
		ifftshift(sample);
		ifft2(sample, ifft_DH);
		phi_angle(ifft_DH, sample_phi);
		normalize(sample_phi, sample_norm, 0, 1, NORM_MINMAX);

		Mat DH_phi, DH_Inten, DH;
		phase_PCA(ifft_DH, sample_phi, DH_phi, DH_Inten, DH);
		//cv::imshow("phase_PCA", DH_phi);
		phase_unwrap(1, DH_phi);
		//cv::imshow("phase_unwrap", DH_phi);

		Mat phi;
		resize(DH_phi, phi, Size(1600, 1200), 0, 0, INTER_CUBIC);
		resize(DH_Inten, DH_Inten, Size(1600, 1200), 0, 0, INTER_LINEAR);

		Mat phi_mean, phi_std;

		meanStdDev(phi, phi_mean, phi_std);
		phi = phi - phi_mean;

		Mat phi_DIC;
		//DIC
		float rotation = 0.75;
		float distance = 2.00;
		DIC_matcalculate(phi, phi_DIC, rotation, distance);
		//cv::imshow("phi_DIC", phi_DIC);

		float lowActive = -10;
		float highActive = 20;
		double pha_min = 0;
		double pha_max = 0;

		HistCalc(phi, lowActive, highActive, pha_min, pha_max);
	}


}

int PlayFilm(std::string fileName) {

	Logger::Log2(Severity::INFO, L"id[%d]", std::this_thread::get_id());

	cv::VideoCapture cap = cv::VideoCapture(fileName);
	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open "+ fileName);
		return -1;
	}
	while (true)
	{	
		if (MatCache.size() > 10) {
			continue;
		}
		cv::Mat frame;
		cap >> frame;
		MatCache.push(frame);

		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
		}


		if (pView->IsState(ViewState::CLOSED)) {
			delete pView;
			break;
		}
	}
	return 0;
}



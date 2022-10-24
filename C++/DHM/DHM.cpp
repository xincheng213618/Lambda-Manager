#include "pch.h"
#include "DHM.h"
#include <common.h>
#include <string>
#include <opencv.hpp>
#include "DH.h"


int PlayFilmAll(std::string fileName);


int PlayFilm(std::string fileName);
void ConsumerTask();
int OpenVideo(char* FullPath)
{
	//std::wstring fp = StringUtils::string2wstring(FullPath);
	std::string FullPath1 = StringUtils::Multi2Utf8(FullPath);
	PlayFilmAll(FullPath1);
	//std::thread producer(PlayFilm, FullPath1);
	//std::thread consumer1(ConsumerTask);
	//std::thread consumer2(ConsumerTask);
	//std::thread consumer3(ConsumerTask);
	//std::thread consumer4(ConsumerTask);
	//std::thread consumer5(ConsumerTask);
	//std::thread consumer6(ConsumerTask);
	//std::thread consumer7(ConsumerTask);
	//std::thread consumer8(ConsumerTask);
	//std::thread consumer9(ConsumerTask);
	//std::thread consumer10(ConsumerTask);
	//std::thread consumer11(ConsumerTask);

	//producer.detach();
	//consumer1.detach();
	//consumer2.detach();
	//consumer3.detach();
	//consumer4.detach();
	//consumer5.detach();
	//consumer6.detach();
	//consumer7.detach();
	//consumer8.detach();
	//consumer9.detach();
	//consumer10.detach();
	//consumer11.detach();

	return  0;
}
std::mutex mtx; // ������,������Ʒ������
std::condition_variable not_full;
std::condition_variable not_empty;

std::queue <cv::Mat> MatCache;
LambdaView* pView = LambdaView::GetIdleOrNew();
LambdaView* pView1 = LambdaView::GetIdleOrNew();


void ConsumerTask() // ����������
{
	clock_t start, end;
	while (1) {
		Sleep(1);
		Mat frame;
		start = clock();
		std::unique_lock<std::mutex> lock(mtx);
		if (MatCache.size() <= 0 || MatCache.size() >= 100) {
			lock.unlock();
			continue;
		}
		else {
			frame = MatCache.front();
			MatCache.pop();
			Logger::Log2(Severity::INFO, L"id[%d]", std::this_thread::get_id());
		}
		lock.unlock();
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
		end = clock();
		Logger::Log2(Severity::INFO, L"LFOCM[%d ms]", end - start);

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
		Sleep(1);
		std::unique_lock<std::mutex> lock(mtx);
		if (MatCache.size()<100&&MatCache.size() > 10) {
			lock.unlock();
			continue;
		}
		cv::Mat frame;
		cap >> frame;
		MatCache.push(frame);
		lock.unlock();
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

int PlayFilmAll(std::string fileName) {
	cv::VideoCapture cap = cv::VideoCapture(fileName);
	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open " + fileName);
		return -1;
	}
	clock_t start, end;
	while (true)
	{
		Sleep(1);
		start = clock();
		cv::Mat frame;
		cap >> frame;
		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
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
		end = clock();
		Logger::Log2(Severity::INFO, L"LFOCM[%d ms]", end - start);



		if (pView->IsState(ViewState::CLOSED)) {
			delete pView;
			break;
		}
	}
	return 0;
}





#pragma warning(disable:26812 26495 26451 6294 6201)

#include "pch.h"
#include "Camera.h"
#include "time.h"
#include <opencv2/core.hpp>
#include <opencv2/videoio.hpp>
#include "thread"

using namespace std;

int OpenCamera()
{
	LambdaView* pView = LambdaView::GetIdleOrNew();
	if (pView->IsState(ViewState::RUNING)) {
		Logger::Log1(Severity::INFO, "ERROR! Camera is running");
		return -1;
	}

	cv::Mat frame;
	cv::VideoCapture cap;
	int deviceID = 0;             // 0 = open default camera
	int apiID = cv::CAP_ANY;      // 0 = autodetect default API
	cap.open(deviceID, apiID);

	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open camera");
		return -1;
	}
	int count = 0;

	for (;;)
	{
		cap.read(frame);

		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
		}
		pView->Show(frame);
		if (pView->IsState(ViewState::CLOSED))
			break;
	}
	// the camera will be deinitialized automatically in VideoCapture destructor
	return 0;
}

int OpenCinema() {
	Event::Once("FILE_SELECTED", &PlayFilms);
	Event::Trigger("OPEN_FILE_DIALOG");
	return 0;
}

int PlayFilms(json* eventData) {
	json filenames = eventData->at("fileNames");
	if (filenames == NULL)
		return -1;
	for (auto& item : filenames.items()) {
		std::string fileName = item.value().get<std::string>();
		thread task(PlayFilm, fileName);
		task.detach();

	}
	return 0;
}

int PlayFilm(std::string fileName) {
	cv::Mat frame;
	cv::VideoCapture cap = cv::VideoCapture(fileName);

	if (!cap.isOpened()) {
		Logger::Log1(Severity::INFO, "ERROR! Unable to open camera");
		return -1;
	}
	LambdaView* pView = LambdaView::GetIdleOrNew();
	std::wstring&& s = StringUtils::string2wstring(&fileName);
	int count = 0;

	for (;;)
	{
		// wait for a new frame from camera and store it into 'frame'
		cap.read(frame);

		// check if we succeeded
		if (frame.empty()) {
			Logger::Log1(Severity::INFO, "Video is end");
			break;
		}
		pView->Show(frame);
		if (pView->IsState(ViewState::CLOSED))
			break;
	}
	// the camera will be deinitialized automatically in VideoCapture destructor
	return 0;
}

int CloseCamera()
{
	Logger::Log1(Severity::INFO, "Invoke 'CloseCamera()'");
	return  0;
}

int CaptureImage(int mode, void** image)
{
	Logger::Log2(Severity::INFO, L"Invoke 'CaptureImage(mode: %d, <out> image: %p)'", mode, image);
	char* buff = (char*)malloc(20);
	if (buff != NULL) {
		struct tm t;
		time_t now = time(NULL);
		localtime_s(&t, &now);
		sprintf_s(buff, 20, "Image: %d:%d:%d", t.tm_hour, t.tm_min, t.tm_sec);
		*image = buff;
	}

	return  0;
}

int SetProperty(std::string name, std::string value)
{
	Logger::Log2(Severity::INFO, L"Invoke 'SetProperty(mode: %s, image: %s)'", name, value);
	return  0;
}

int LoadProperty(std::string xml)
{
	Logger::Log2(Severity::INFO, L"Invoke 'LoadProperty(xml: %s)'", xml);
	return  0;
}

int SaveSettings()
{
	Logger::Log1(Severity::INFO, "Invoke 'SaveSettings()'");
	return  0;
}

#include "pch.h"
#include "RS232.h"
#include "common.h"

int OpenLED()
{
    Logger::Log1(Severity::INFO, "Invoke 'OpenLED()'");
    return 0;
}

int CloseLED()
{
    Logger::Log1(Severity::INFO, "Invoke 'CloseLED()'");
    return 0;
}

int OpenLaser()
{
    Logger::Log1(Severity::INFO, "Invoke 'OpenLaser()'");
    return 0;
}

int CloseLaser()
{
    Logger::Log1(Severity::INFO, "Invoke 'CloseLaser()'");
    return 0;
}

int OpenMotor()
{
    Logger::Log1(Severity::INFO, "Invoke 'OpenMotor()'");
    return 0;
}

int MoveStep(int direction, int step)
{
    switch (static_cast<Direction>(direction)) {
    case LEFT:
        Logger::Log2(Severity::INFO, L"Invoke 'MoveLeft(step: %d)'", step);
        break;
    case RIGHT:
        Logger::Log2(Severity::INFO, L"Invoke 'MoveRight(step: %d)'", step);
        break;
    case FRONT:
        Logger::Log2(Severity::INFO, L"Invoke 'MoveFrom(step: %d)'", step);
        break;
    case REAR:
        Logger::Log2(Severity::INFO, L"Invoke 'MoveRear(step: %d)'", step);
        break;
    case TOP:
        Logger::Log2(Severity::INFO, L"Invoke 'MoveTop(step: %d)'", step);
        break;
    case DOWN:
        Logger::Log2(Severity::INFO, L"Invoke 'MoveDown(step: %d)'", step);
        break;
    }
    return 0;
}

int MoveTo(int x, int y)
{
    Logger::Log2(Severity::INFO, L"Invoke 'MoveTo(x: %d,y: %d)'", x, y);
    return 0;
}

int MoveTo2(std::pair<int, double> pair)
{
    Logger::Log2(Severity::INFO, L"Invoke 'MoveTo2(x: %d,y: %.3f)'", pair.first, pair.second);
    return 0;
}

int MoveZ(int step)
{
    Logger::Log2(Severity::INFO, L"Invoke 'MoveZ(step: %d)'", step);
    return 0;
}

int SendLEDSignal(char* signal)
{
    Logger::Log2(Severity::INFO, L"Invoke 'SendLEDSignal(signal: %s)'", signal);
    return 0;
}

int OpenSerial(char* fullPath)
{
    Logger::Log1(Severity::INFO, "Invoke 'OpenSerial(fullPath: %s)'", fullPath);
    return 0;
}

int OpenSerial2(wchar_t* fullPath)
{
    Logger::Log2(Severity::INFO, L"Invoke 'OpenSerial(fullPath: %s)'", fullPath);
    return 0;
}   

int Phase_Seg1(void* cell_img, void* array_int, void* array_float, void* array_add)
{

    //Event::Trigger("SHOW_img", &cell_img);
    Logger::Log1(Severity::INFO, "Invoke Phase Seg");

    return 0;
}

int BilateralDenoise(cv::Mat& imgstr, double* Cdenoise)
{
    double a = *Cdenoise;
    Logger::Log2(Severity::INFO, L"Invoke 'OpenSerial(fullPath: %s)'");
    return 0;
}




int Phase_Seg(cv::Mat& cell_img, void* array_int, void* array_float, void* array_add)
{
    cell_img.convertTo(cell_img, CV_8UC1, 255, 0);

    //Event::Trigger("SHOW_img", &cell_img);
    Logger::Log1(Severity::INFO, "Invoke Phase Seg");
    return 0;
}


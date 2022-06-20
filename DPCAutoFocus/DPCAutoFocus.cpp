#include "pch.h"
#include "DPCAutoFocus.h"
#include "time.h"
#include <iostream>
#include <sstream>

using namespace std;

int Sobel(char** image, void** out)
{
    SYSTEMTIME t;
    GetSystemTime(&t);
    double x = 1000;
    pair<int, double>* p = new pair<int, double>(t.wSecond, t.wMilliseconds / x);
    char buff[100];
    sprintf_s(buff, 100, "Invoke 'Solbel(image: , <out> pair: {%d, %.3f})'", p->first, p->second);
    Logger::Log1(Severity::INFO, buff);
    *out = p;
    return 0;
}

int Compare(std::pair<int, double>* pairs[], int count, std::pair<int, double>** out)
{
    stringstream ss;
    for (int i = 0; i < count; i++) {
        char buff[30];;
        sprintf_s(buff, 30, "{%d, %.3f}", pairs[i]->first, pairs[i]->second);
        ss << buff;
        if (i != count - 1)
            ss << ',';
    }
    Logger::Log1(Severity::INFO, "Invoke 'Compare(pairs: [" + ss.str() + "])'");
    *out = pairs[0];
    return 0;
}

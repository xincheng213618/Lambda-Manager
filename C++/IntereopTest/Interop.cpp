#include "pch.h"
#include "Interop.h"
#include "locale.h"

//void
int Test0() {
	Logger::Log1(Severity::INFO, "≤‚ ‘: Test0()");
	return  0;
}

// basic types
int Test1(char c) {
	if (c > 0 && c < 128)
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test1(c='%c')", c);
	else
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test1(c=%d)", c);
	return  0;
}

int Test2(unsigned char c) {
	if (c > 0 && c < 128)
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test2(c='%c')", c);
	else
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test2(c=%d)", c);
	return  0;
}

int Test3(int x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test3(x=%d)", x);
	return  0;
}

int Test4(unsigned int x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test4(x=%u)", x);
	return  0;
}

int Test5(long x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test5(x=%d)", x);
	return  0;
}

int Test6(unsigned long x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test6(x=%u)", x);
	return  0;
}

int Test7(float x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test7(x=%f)", x);
	return  0;
}

int Test8(double x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test8(x=%.8lf)", x);
	return  0;
}

int Test9(long int x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test9(x=%ld)", x);
	return  0;
}

int Test10(long long x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test10(x=%lld)", x);
	return  0;
}

int Test11(long double x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test11(x=%.18Lf)", x);
	return  0;
}

// pointer types
int Test12(char* p) {
	char c = *p;
	if (c > 0 && c < 128)
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test12(*p='%c')", c);
	else
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test12(*p='%d')", c);
	return  0;
}

int Test13(unsigned char* p) {
	unsigned char c = *p;
	if (c > 0 && c < 128)
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test13(*p='%c')", c);
	else
		Logger::Log2(Severity::INFO, L"≤‚ ‘: Test13(*p='%d')", c);
	return  0;
}

int PrepareStdString(std::string** out) {
	static std::string s = std::string("≤‚ ‘ ˝æ›std::string");
	*out = &s;
	return 0;
}

int Test14(std::string* s) {
	wchar_t* p = StringUtils::Multi2WideByte(s->c_str());
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test14(s=\"%s\")", p);
	delete[] p;
	return  0;
}

int PrepareCString(const wchar_t** out) {
	static CString s = "≤‚ ‘ ˝æ›CString";
	*out = s.GetBuffer();
	return 0;
}

int Test15(wchar_t* s) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test15(s=\"%s\")", s);
	return  0;
}

int PrepareLPSTR(LPSTR* out) {
	static std::string s = std::string("test data LPSTR");
	char* buff = new char[30];
	strcpy_s(buff, 30, s.c_str());
	*out = buff;
	return 0;
}

int Test16a(LPSTR p) {
	char* buff = new char[40];
	sprintf_s(buff, 40, "TEST: Test16a(s=\"%s\")", p);
	Logger::Log1(Severity::INFO, buff);
	free(p);
	return  0;
}

int PrepareLPCSTR(LPCSTR* out) {
	static std::string s = std::string("≤‚ ‘ ˝æ›LPCSTR");
	*out = s.c_str();
	return 0;
}

int Test16b(LPCSTR p) {
	wchar_t* s = StringUtils::Multi2WideByte(p);
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test16b(s=\"%s\")", s);
	delete[] s;
	return  0;
}

int PrepareLPTSTR(LPTSTR* out) {
	static std::string s = std::string("≤‚ ‘ ˝æ›LPTSTR");
	LPTSTR p = StringUtils::Multi2WideByte(s.c_str());
	*out = p;
	return 0;
}

int Test16c(LPTSTR p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test16c(s=\"%s\")", p);
	free(p);
	return  0;
}

int PrepareLPCTSTR(LPCTSTR* out) {
	static LPCTSTR p = L"≤‚ ‘ ˝æ›LPCTSTR";
	*out = p;
	return 0;
}

int Test16d(LPCTSTR p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test16d(s=\"%s\")", p);
	return  0;
}

int PrepareLPWSTR(LPWSTR* out) {
	static CString s = "≤‚ ‘ ˝æ›LPWSTR";
	*out = s.GetBuffer();
	return 0;
}

int Test16e(LPWSTR p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test16e(s=\"%s\")", p);
	return  0;
}

int PrepareLPCWSTR(LPCWSTR* out) {
	static CString s = L"≤‚ ‘ ˝æ›LPCWSTR";
	*out = s;
	return 0;
}

int Test16f(LPCWSTR p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test16f(s=\"%s\")", p);
	return  0;
}

int Test17(int* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test17(*p=%d)", *p);
	return  0;
}

int Test18(unsigned int* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test18(*p=%u)", *p);
	return  0;
}

int Test19(long* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test19(*p=%d)", *p);
	return  0;
}

int Test20(unsigned long* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test20(*p=%u)", *p);
	return  0;
}

int Test21(float* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test21(*p=%f)", *p);
	return  0;
}

int Test22(double* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test22(*p=%.8lf)", *p);
	return  0;
}

int Test23(long int* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test23(*p=%ld)", *p);
	return  0;
}

int Test24(long long* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test24(*p=%lld)", *p);
	return  0;
}

int Test25(long double* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test25(*p=%.18Lf)", *p);
	return  0;
}

// array types
int Test26(char a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test26(a[]=\"%s\")"), format<char>(a, size));
	return  0;
}

int Test26x(char a[]) {
	int size = GetArraySize(a);
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test26(a[]=\"%s\")"), format<char>(a, size));
	return  0;
}

int Test27(int a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test27(a[]=\"%s\")"), format<int>(a, size));
	return  0;
}

int Test28(long a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test28(a[]=\"%s\")"), format<long>(a, size));
	return  0;
}

int Test29(float a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test29(a[]=\"%s\")"), format<float>(a, size));
	return  0;
}

int Test30(double a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test30(a[]=\"%s\")"), format<double>(a, size));
	return  0;
}

int Test31(long int a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test31(a[]=\"%s\")"), format<long int>(a, size));
	return  0;
}

int Test32(long long a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test32(a[]=\"%s\")"), format<long long>(a, size));
	return  0;
}

int Test33(long double a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test33(a[]=\"%s\")"), format<long double>(a, size));
	return  0;
}

int Test34(wchar_t* a[], int size) {
	Logger::Log2(Severity::INFO, _T("≤‚ ‘: Test34(a[]=\"%s\")"), formatStringArray(a, size));
	return  0;
}

// 2 arguments
int Test40(char c, int x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test40(c='%c', x=%d)", c, x);
	return  0;
}

int Test41(long x, char c) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test41(x=%d, c='%c')", x, c);
	return  0;
}

int Test42(int* x, char c) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test42(*x=%d, c='%c')", *x, c);
	return  0;
}

int Test43(char c, int* x) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test43(c='%c', *x=%d)", c, *x);
	return  0;
}

int Test44(int* x, long y) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test44(*x=%d, y=%d)", *x, y);
	return  0;
}

int Test45(long x, int* y) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test45(x=%d, *y=%d)", x, *y);
	return  0;
}

int Test46(int x[], int size, long* y) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test46(x[]=\"%s\", *y=%d)", format(x, size), *y);
	return  0;
}

// 3 arguments
int Test50(char c, long x, int y) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test50(x='%c', x=%d, y=%d)", c, x, y);
	return  0;
}

int Test51(long x, char c, int y) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test51(x=%d, c='%c', y=%d)", x, c, y);
	return  0;
}

int Test52(int* x, long* y, char* c) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test52(*x=%d, *y=%d, *c='%c')", *x, *y, *c);
	return  0;
}

int Test53(char a[], int size, char* p1, LPCSTR p2) {
	wchar_t* s = StringUtils::Multi2WideByte(p2);
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test53(a[]=\"%s\", *p1=\"%c\", *p2=\"%s\")", format(a, size), *p1, s);
	delete[] s;
	return  0;
}

// 4 arguments
int Test60(char c, int x, long y, float* f) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test60(c='%c', x=%d, y=%d, *f=%f)", c, x, y, *f);
	return  0;
}

int Test61(double d, int x, float f, char c) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test61(d=%.8lf, x=%d, f=%f, c='%c')", d, x, f, c);
	return  0;
}

int Test62(long double ld, int x, long int lx, long long ll) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test62(ld=%.18Lf, x=%d, lx=%ld, ll=%lld)", ld, x, lx, ll);
	return  0;
}

// 5 arguments
int Test71(std::string s, int x, long long ll, float f, double d) {
	wchar_t* p = StringUtils::Multi2WideByte(s.c_str());
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test71(*p=\"%s\", x=%d, ll=%lld, f=%f, d=%.8lf)", p, x, ll, f, d);
	delete[] p;
	return  0; //s is survive from Test14 but released here
}

int Test72(double d, float f, long long ll, int y, char* p) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test72(d=%.8lf, f=%f, ll=%lld, y=%d, *p='%c')", d, f, ll, y, *p);
	return  0;
}

int Test73(wchar_t* s1, char a2[], LPCTSTR s3, wchar_t* s4, LPCWSTR s5) {
	CString s2 = format<char>(a2, 4);
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test73(*s1=\"%s\", *s2=\"%s\", *s3=\"%s\", *s4=\"%s\", *s5=\"%s\")", s1, s2, s3, s4, s5);
	return  0;
}

// 6 arguments
int Test80(int x, long y, float f, double d, long int lx, long double ld) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test80(x=%d, y=%d, f=%f, d=%.8lf, lx=%ld, ld=%.18Lf)", x, y, f, d, lx, ld);
	return  0;
}

int Test81(int* x, long* y, float* f, double* d, long int* lx, long double* ld) {
	Logger::Log2(Severity::INFO, L"≤‚ ‘: Test81(*x=%d, *y=%d, *f=%f, *d=%.8lf, *lx=%ld, *ld=%.18Lf)", *x, *y, *f, *d, *lx, *ld);
	return  0;
}

int Test101() {
	std::string data = "{\"X\":[1,2,3,4,5,6,7,8,9,10],\"Y\":[-1,-2,-3,-4,-5,-6,-7,-8,-9,-10],\"CamMode\":1001}";
	Event::Trigger("AUTOFOCUS", data.c_str());
	return 0;
}

int Test102(MoveTo pMoveTo, CaptureImage pCapImg)
{
	pMoveTo(102, -102);
	char* pImage = NULL;
	pCapImg(1003, &pImage);
	Logger::Log1(Severity::INFO, pImage);
	return 0;
}

int Test120() {
	json event = R"(
      {
        "a": [1,2,3],
        "b": {"c":"hello","d":1.234}
      }
    )"_json;

	Event::On("TEST_EVENT_1", &Test121, false);
	Event::Trigger("TEST_EVENT_1");

	Event::On("TEST_EVENT_2", &Test122, false);
	Event::Trigger("TEST_EVENT_2", &event);

	Event::On("TEST_EVENT_3", &Test123, false);
	Event::Trigger("TEST_EVENT_3", event.dump().c_str());
	return 0;
}

int Test121() {
	Logger::Log1(Severity::INFO, "Invoke 'Test121()'");
	return 0;
}

int Test122(json* event) {
	std::wstring&& p = StringUtils::string2wstring(event->dump());
	Logger::Log2(Severity::INFO, L"Invoke 'Test122(%s)'", p.c_str());
	return 0;
}

int Test123(const char* event) {
	wchar_t* p = StringUtils::Multi2WideByte(event);
	Logger::Log2(Severity::INFO, L"Invoke 'Test123(%s)'", p);
	delete[] p;
	return 0;
}

int Test124() {
	return 0;
}

int Test125(int x, wchar_t* y, wchar_t** z) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test125(x=%d, y=\"%s\")'", x, y);
	*z = y;
	return 0;
}

int Test131() {
	Logger::Log1(Severity::INFO, "Invoke 'Test131()'");
	return 0;
}

int Test132(json* event) {
	if (event == NULL)
		Logger::Log1(Severity::INFO, "Invoke 'Test132()'");
	else {
		std::wstring&& ws = StringUtils::string2wstring(event->dump());
		Logger::Log2(Severity::INFO, L"Invoke 'Test132(%s)'", ws.c_str());
	}
	return 0;
}

int Test133(const char* event) {
	wchar_t* p = StringUtils::Multi2WideByte(event);
	Logger::Log2(Severity::INFO, L"Invoke 'Test133(%s)'", p);
	delete[] p;
	return 0;
}

int Test134() {
	Logger::Log1(Severity::INFO, "Invoke 'Test134()'");
	return 0;
}

int Test135() {
	Logger::Log1(Severity::INFO, "Invoke 'Test135()'");
	json event = R"(
      {
        "value": 1.2345678
      }
    )"_json;
	Event::Trigger("TEST_EVENT_DOUBLE", &event);
	double x = 1.23345678;
	json event2;
	event2["value"] = 3.0;
	Event::Trigger("TEST_EVENT_DOUBLE", &event2);
	return 0;
}

int Test136(double value) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test136(%f)'", value);
	return 0;
}

int Test137(float value1, double value2) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test137(%f, %f)'", value1, value2);
	return 0;
}

int Test138(double value1, double value2) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test138(%f,%f)'", value1, value2);
	return 0;
}

int Test139(float value1, float value2) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test139(%f, %f)'", value1, value2);
	return 0;
}

int Test140(double value1, float value2) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test140(%f, %f)'", value1, value2);
	return 0;
}

int Test150() {
	Logger::Log1(Severity::INFO, "Invoke 'Test150()'");
	return 0;
}

int Test151() {
	Event::On("SCHEDULE_EVENT1", Test152, false);
	Event::On("SCHEDULE_EVENT2", Test153, false);
	Event::Schedule("SCHEDULE_EVENT1", "0 0/1 * * * ?", "schedule event");
	Event::Schedule("SCHEDULE_EVENT2", "0 0/1 * * * ?", NULL);
	return 0;
}

int Test152(const char* event) {
	wchar_t* p = StringUtils::Multi2WideByte(event);
	Logger::Log2(Severity::INFO, L"Invoke 'Test152(%s)'", p);
	delete[] p;
	return 0;
}

int Test153() {
	Logger::Log1(Severity::INFO, "Invoke 'Test153()'");
	return 0;
}

int Test160() {
	Event::On("DISPATCH_EVENT", Test161, false);
	Event::Dispatch("DISPATCH_EVENT", "A");
	Event::Dispatch("DISPATCH_EVENT", "B");
	Event::Dispatch("DISPATCH_EVENT", "C");
	Event::Dispatch("DISPATCH_EVENT", "D");
	Event::Dispatch("DISPATCH_EVENT", "E");
	Event::Dispatch("DISPATCH_EVENT", "F");
	return 0;
}

int Test161(const char* str) {
	Logger::Log2(Severity::INFO, L"Invoke 'Test161(%s)'", str);
	return 0;
}

int Test200() {
	Logger::Log1(Severity::INFO, "Invoke 'Test200()'");
	return 0;
}

int CameraSettingReset()
{
	Logger::Log1(Severity::INFO, "Invoke 'CameraSettingReset()'");
	return 0;
}

int UpdateDisplayMode()
{
	Logger::Log2(Severity::INFO, L"UpdateDisplayMode(mode)");
	return 0;
}

template <typename T>
CString format(T a[]) {
	int size = sizeof(a) / sizeof(a[0]);
	int last = size - 1;

	return format<T>(a, size);
}

template <typename T>
CString format(T a[], size_t size) {
	CString s = "[";
	for (int i = 0; i < size; i++) {
		std::string x = std::to_string(a[i]);
		std::wstring&& y = StringUtils::string2wstring(x);
		s.Append(y.c_str());
		if (i == size - 1)
			s.AppendChar(']');
		else
			s.AppendChar(',');
	}
	return s;
}

CString formatStringArray(wchar_t* a[], int size) {
	int last = size - 1;

	CString s = "[";
	for (int i = 0; i < size; i++) {
		s.Append(L"\"");
		s.Append(a[i]);
		s.Append(L"\"");
		if (i == last)
			s.AppendChar(']');
		else
			s.AppendChar(',');
	}
	return s;
}


int Test210() {
	Event::On("TEST211", Test211, false);
	Event::On("TEST212", Test212, false);
	return 0;
}

int Test211(void* a) {
	int* p = (int*)a;
	int size = GetArraySize(p);
	Logger::Log2(Severity::INFO, L"event array: [%d, %d, %d,...], size: %d", *p, *(p + 1), *(p + 2), size);

	int b[] = { 1, 2, 3, 4, 5 };
	Event::Trigger("TEST221", b, sizeof(b) / sizeof(b[0]));
	return 0;
}

int Test212(void* a) {
	double* p = (double*)a;
	int size = GetArraySize(p);
	Logger::Log2(Severity::INFO, L"event array: [%f, %f, %f,...], size: %d", *p, *(p + 1), *(p + 2), size);

	double b[] = { 1.23, 2.34, 3.45 };
	Event::Trigger("TEST222", b, sizeof(b) / sizeof(b[0]));
	return 0;
}


 int CellinfoTest(Cellinfo* Cellinfos)
 {
	 //Cellinfos->push_back({ 5,1,1,2222,4444,5555 });
	 //Cellinfos->push_back({ 6,2,1,2222,4444,5555 });
	 Cellinfos->Areas = 13;
	 Logger::Log2(Severity::INFO, L" SDT event array: [%d,...], size: %d", Cellinfos->Areas);

	 return 0;
 }

int BrightFieldBrightness(void* brightness)
{
	int* p = (int*)brightness;
	int size = GetArraySize(p);
	Logger::Log2(Severity::INFO, L" SDT event array: [%d, %d, %d,...], size: %d", *p, *(p + 1), *(p + 2), size);
	return 0;
}

void ScheduleEnd() {
	Logger::Log1(Severity::INFO, "Test300 end");
}

int Test300() {
	Logger::Log1(Severity::INFO, "Test300 start");
	Schedule(timer, 3, []() ->void {
		Logger::Log1(Severity::INFO, "Test300 reached");
		}, ScheduleEnd);

	return 0;
}

int Test301() {
	Logger::Log1(Severity::INFO, "Test301 start");
	for (int i = 0; i < 2; i++) {
		Schedule2(timer, 3, [=]() ->int {
			Logger::Log1(Severity::INFO, "Test301[%d] reached", i);
			return 0;
			}, [=]()->int {
				Logger::Log1(Severity::INFO, "Test301[%d] end", i);
				return 0;
			});
	}
	return 0;
}

int Test302() {
	std::string text[] = { "text1","text2" };
	Logger::Log1(Severity::INFO, "Test302 start[%p]", text);
	for (int i = 0; i < 2; i++) {
		Schedule2(timer, 1, [=, &text]() ->int {
			Logger::Log1(Severity::INFO, "Test302[%d] reached: %s[%p]", i, text[i].c_str(), text);
			return 0;
			}, [=]()->int {
				Logger::Log1(Severity::INFO, "Test302[%d] end", i);
				return 0;
			});
	}
	Sleep(5 * 3000); //ensure 'text' is still exist when lambda accesing it by reference
	return 0;
}

void DelayEnd() {
	Logger::Log1(Severity::INFO, "Test303 end");
}

int Test303() {
	Logger::Log1(Severity::INFO, "Test303 start");
	const char* name = Delay(3, 3, []() ->void {
		Logger::Log1(Severity::INFO, "Test303 reached");
		}, DelayEnd);
	Sleep(5 * 3000);
	StopSchedule(name);
	return 0;
}

int Test304() {
	Logger::Log1(Severity::INFO, "Test304 start");
	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 2; j++) {
			Delay2(3, 2, [=]() ->int {
				Logger::Log1(Severity::INFO, "Test304[%d][%d] reached", i, j);
				return 0;
				}, [=]()->int {
					Logger::Log1(Severity::INFO, "Test304[%d][%d] end", i, j);
					return 0;
				});
		}
	}
	return 0;
}

int Test305() {
	std::string text[] = { "text1","text2" ,"text3" ,"text4" };
	Logger::Log1(Severity::INFO, "Test305 start[%p]", text);
	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 2; j++) {
			Delay2(3, 1, [=, &text]() ->int {
				Logger::Log1(Severity::INFO, "Test305[%d][%d] reached: %s[%p]", i, j, text[i * 2 + j].c_str(), text);
				return 0;
				}, [=]()->int {
					Logger::Log1(Severity::INFO, "Test305[%d][%d] end", i, j);
					return 0;
				});
		}
	}
	Sleep(5 * 3000); //ensure 'text' is still exist when lambda accesing it by reference
	return 0;
}



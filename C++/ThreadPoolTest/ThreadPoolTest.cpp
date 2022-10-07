#include <iostream>
#include "concurrent.h"
#include "threadpool.h"
#include <random>
using namespace std;

class Wrap {
private:
	int index1 = 0;
	double index2 = 0;

public:
	Wrap() {};
	Wrap(int x, double y) :index1(x), index2(y) {};
	~Wrap() {};

	//Wrap(const Wrap&) = delete;
	//Wrap& operator=(const Wrap&) = delete;
	//
	//Wrap& operator=(Wrap&& from) {
	//	index1 = from.index1;
	//	index2 = from.index2;
	//	return *this;
	//}

	void SetIndex1(int x) {
		index1 = x;
	}

	int GetIndex1() {
		return index1;
	}

	void SetIndex2(double y) {
		index2 = y;
	}

	double GetIndex2() {
		return index2;
	}

};

default_random_engine r;
uniform_int_distribution<unsigned int>  dist(0, 500);
ConcurrentQueue<shared_future<Wrap>> results;

//Wrap&& foo(int index) {
Wrap foo(int index) {
	int n = dist(r);
	this_thread::sleep_for(chrono::microseconds(n));
	cout << "call index: " << index << ", ellapsed: " << n << "ms" << endl;
	Wrap wrap(index, -index);
	//return std::move(wrap);
	return wrap;
}

void start() {
	ThreadPool pool;
	int index = 0;
	for (;;) {
		results.push(pool.Commit(foo, index));
		index++;
	}
}

int main()
{
	auto f = async(start);
	for (;;) {
		auto result = results.try_pop();
		if (result != NULL) {
			shared_future<Wrap> ff = *result;
			if (ff.valid()) {
				Wrap wrap = ff.get();
				cout << "return index:" << result.get() << endl;
				cout << "return GetIndex1:" << wrap.GetIndex1() << endl;
				cout << "return GetIndex2:" << wrap.GetIndex2() << endl;
			}
		}
	}

	std::cout << "Hello World!\n";
}

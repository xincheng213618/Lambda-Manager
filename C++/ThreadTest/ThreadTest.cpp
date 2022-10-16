#include <Windows.h>
#include <cstdlib>
#include <condition_variable>
#include <iostream>
#include <mutex>
#include <thread>



std::mutex mux;


std::mutex mtx; // 互斥量,保护产品缓冲区
std::condition_variable not_full;
std::condition_variable not_empty;

using namespace std;

void ConsumerTask() // 消费者任务
{
	while (1) {
		clock_t start, end;
		start = clock();
		cout << std::this_thread::get_id() << endl;
		Sleep(1000);
	}


}

void ProducerTask() {

	while (1)
	{
		Sleep(100);
		cout << std::this_thread::get_id() << endl;
		not_empty.notify_all(); // 通知消费者产品库不为空.
	}
}




int main()
{
	std::thread producer1(ProducerTask);
	std::thread producer2(ProducerTask);
	std::thread producer3(ProducerTask);
	std::thread producer4(ProducerTask);

	std::thread consumer1(ConsumerTask);
	std::thread consumer2(ConsumerTask);
	std::thread consumer3(ConsumerTask);
	std::thread consumer4(ConsumerTask);

	producer1.join();
	producer2.join();
	producer3.join();
	producer4.join();

	consumer1.join();
	consumer2.join();
	consumer3.join();
	consumer4.join();
	system("pause");
    return 0;
}

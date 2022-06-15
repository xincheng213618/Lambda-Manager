#pragma once
#include <future>
#include <stdexcept>
#include <vector>
#include <queue>
#include <atomic>
using Task = std::function<void()>;

#define MAX_THREADPOOL_NUM 10

class ThreadPool {
private:
	std::vector<std::thread> threads;
	std::queue<Task> tasks;
	std::mutex mx;
	std::condition_variable taskCondition;
	std::atomic<bool> running{ true };
	std::atomic<int>  idleCount{ 0 };

	void AddThread(unsigned short count) {
		for (; threads.size() < MAX_THREADPOOL_NUM && count > 0; --count)
		{
			threads.emplace_back([this] {
				while (running)
				{
					Task task; // 获取一个待执行的 task
					{
						// unique_lock 相比 lock_guard 的好处是：可以随时 unlock() 和 lock()
						std::unique_lock<std::mutex> lock{ mx };
						taskCondition.wait(lock, [this] {
							return !running || !tasks.empty();
						}); // wait 直到有 task
						if (!running && tasks.empty())
							return;
						task = std::move(tasks.front()); // 按先进先出从队列取一个 task
						tasks.pop();
					}
					idleCount--;
					task();//执行任务
					idleCount++;
				}
			});
			idleCount++;
		}
	};

public:
	inline ThreadPool(unsigned short size = 4) {
		AddThread(size);
	};

	inline ~ThreadPool() {
		running = false;
		taskCondition.notify_all(); // 唤醒所有线程执行
		for (std::thread& thread : threads) {
			if (thread.joinable())
				thread.join(); // 等待任务结束， 前提：线程一定会执行完
		}
	};

	template<class F, class... Args>
	auto Commit(F&& f, Args&&... args)->std::future<decltype(f(args...))> {
		if (!running)
			throw std::runtime_error("committing ThreadPool is stopped.");

		using RetType = decltype(f(args...));
		auto task = std::make_shared<std::packaged_task<RetType()>>(std::bind(std::forward<F>(f), std::forward<Args>(args)...)); // 把函数入口及参数,打包(绑定)
		std::future<RetType> future = task->get_future();
		{
			std::lock_guard<std::mutex> lock{ mx };
			tasks.emplace([task]() {
				(*task)();
			});
		}
		if (idleCount < 1 && threads.size() < MAX_THREADPOOL_NUM)
			AddThread(1);
		taskCondition.notify_one(); // 唤醒一个线程执行

		return future;
	};

	size_t IdleCount() { return idleCount; };
	size_t Size() { return threads.size(); };
	void Stop() { running = false; };
	bool IsStopped() { return !running; };
};

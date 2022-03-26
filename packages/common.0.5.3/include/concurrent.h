#pragma once
#include <iostream>
#include <string>
#include <condition_variable>
#include <mutex>
#include <queue>
#include <memory>

template<class T, class Container = std::queue<T>>
class ConcurrentQueue {
public:
	ConcurrentQueue() = default;

	template <class Element>
	void push(Element&& element) {
		std::lock_guard<std::mutex> lock(mutex_);
		queue_.push(std::forward<Element>(element));
		not_empty_cv_.notify_one();
	}

	void wait_and_pop(T& t) {
		std::unique_lock<std::mutex> lock(mutex_);
		not_empty_cv_.wait(lock, []() {
			return !queue_.empty();
		});

		t = std::move(queue_.front());
		queue_.pop();
	}

	std::shared_ptr<T> wait_and_pop() {
		std::unique_lock<std::mutex> lock(mutex_);
		not_empty_cv_.wait(lock, [this]() {
			return !queue_.empty();
		});

		std::shared_ptr<T> t_ptr = std::make_shared<T>(queue_.front());
		queue_.pop();

		return t_ptr;
	}

	bool try_pop(T& t) {
		std::lock_guard<std::mutex> lock(mutex_);
		if (queue_.empty()) {
			return false;
		}

		t = std::move(queue_.front());
		queue_.pop();

		return true;
	}

	std::shared_ptr<T> try_pop() {
		std::lock_guard<std::mutex> lock(mutex_);
		if (queue_.empty()) {
			return std::shared_ptr<T>();
		}

		std::shared_ptr<T> t_ptr = std::make_shared<T>(queue_.front());
		queue_.pop();

		return t_ptr;
	}

	bool empty() const {
		std::lock_guard<std::mutex> lock(mutex_);
		return queue_.empty();
	}

private:
	ConcurrentQueue(const ConcurrentQueue&) = delete;
	ConcurrentQueue(ConcurrentQueue&&) = delete;
	ConcurrentQueue& operator=(const ConcurrentQueue&) = delete;
	ConcurrentQueue& operator=(ConcurrentQueue&&) = delete;

private:
	Container queue_;
	std::condition_variable not_empty_cv_;
	mutable std::mutex mutex_;
};

template<class T, class Container = std::vector<T>, class Allocator = std::allocator<T>>
class ConcurrentVector {
public:
	ConcurrentVector() = default;
	typedef typename std::vector<T, Allocator>::iterator iterator;
	typedef typename std::vector<T, Allocator>::const_iterator const_iterator;
	typedef typename std::vector<T, Allocator>::size_type size_type;

	template <class Element>
	void push_back(Element&& element) {
		std::lock_guard<std::mutex> lock(mutex_);
		vector_.push_back(std::forward<Element>(element));
		not_empty_cv_.notify_one();
	}

	void wait_at(T& t, int index) {
		std::unique_lock<std::mutex> lock(mutex_);
		not_empty_cv_.wait(lock, []() {
			return vector_.size() > index;
		});

		t = std::move(vector_.at(index));
	}

	std::shared_ptr<T> wait_at(int index) {
		std::unique_lock<std::mutex> lock(mutex_);
		not_empty_cv_.wait(lock, [this]() {
			return vector_.size() > index;
		});

		std::shared_ptr<T> t_ptr = std::make_shared<T>(vector_.at(index));
		return t_ptr;
	}

	bool try_at(T& t, int index) {
		std::lock_guard<std::mutex> lock(mutex_);
		if (vector_.size() > index) {
			return false;
		}

		t = std::move(vector_.at(index));
		return true;
	}

	std::shared_ptr<T> try_at(int index) {
		std::lock_guard<std::mutex> lock(mutex_);
		if (vector_.empty()) {
			return std::shared_ptr<T>();
		}

		std::shared_ptr<T> t_ptr = std::make_shared<T>(vector_.at(index));
		return t_ptr;
	}

	T& at(size_type index) {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.at(index);
	}

	const T& at(size_type index) const {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.at(index);
	}

	iterator begin(void) {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.begin();
	}

	const_iterator begin(void) const {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.begin();
	}

	iterator end(void) {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.end();
	}

	const_iterator end(void) const {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.end();
	}

	size_type size() const {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.size();
	}

	bool empty() const {
		std::lock_guard<std::mutex> lock(mutex_);
		return vector_.empty();
	}

private:
	ConcurrentVector(const ConcurrentVector&) = delete;
	ConcurrentVector(ConcurrentVector&&) = delete;
	ConcurrentVector& operator=(const ConcurrentVector&) = delete;
	ConcurrentVector& operator=(ConcurrentVector&&) = delete;

private:
	Container vector_;
	std::condition_variable not_empty_cv_;
	mutable std::mutex mutex_;
};
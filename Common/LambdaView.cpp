#include "pch.h"
#include "common.h"

extern InitialFrame initialFrame;
extern UpdateFrame updateFrame;
extern CloseImageView closeImageView;

static int viewindex = 0;

std::mutex mut;
LambdaView::LambdaView(bool registered)
{
	index = viewindex;
	viewindex++;
	if (registered) {
		index2 = 0;
		flag = 0;
	}
	else
	{
		index2 = 1;
		flag = 1;
	}
}
LambdaView::~LambdaView()
{

}
void LambdaView::Show(cv::Mat mat)
{
	if (flag == UNINITIALIZED || flag == OCCUPIED)
	{
		if (initialFrame == NULL)
			throw "initialFrame";

		int i = initialFrame(index, index2, mat.data, mat.rows, mat.cols, 3);
		flag = RUNING;
	}
	else if (flag == RUNING)
	{
		if (updateFrame == NULL)
			throw "updateFrame";
		updateFrame(index, index2, mat.data, static_cast<int>(mat.total() * mat.elemSize()), static_cast<int>(mat.step));
	}
}

void LambdaView::Close()
{
	closeImageView(index);
}

ViewState LambdaView::GetState()
{
	return (ViewState)flag;
}
void LambdaView::SetState(ViewState state)
{
	if (state == CLOSED)
		closeImageView(index);

	flag = state;
}
bool LambdaView::IsState(ViewState state)
{
	if (flag == state)
		return true;
	else
		return false;
}

int LambdaView::GetIndex()
{
	return index;
}


LambdaView* LambdaView::GetRegistered(int index)
{
	static LambdaView instance = new LambdaView(true);
	return &instance;
}

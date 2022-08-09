#include "pch.h"
#include "common.h"

extern InitialFrame initialFrame;
extern UpdateFrame updateFrame;
extern CloseImageView closeImageView;

static int viewindex = 0;

std::mutex mut;
LambdaView::LambdaView(bool registered)
{
	if (registered) {
		flag = 0;
		index = 0;
		index2 = 0;
	}
	else
	{
		index = viewindex;
		viewindex++;
		index2 = 0;
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

		int i = initialFrame(index, index2, mat.data, mat.rows, mat.cols, mat.channels());
		flag = RUNING;
	}
	else if (flag == RUNING)
	{
		if (updateFrame == NULL)
			throw "updateFrame";
		flag = updateFrame(index, index2, mat.data, mat.total() * mat.elemSize(), (int)mat.step);
		if (flag == CLOSED)
			closeImageView(index);
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
	LambdaView* instance;
	instance = new LambdaView(true);
	if (index < 0) {
		instance->index2 = index;
	}else{
		instance->index = index;
	}
	return instance;
}

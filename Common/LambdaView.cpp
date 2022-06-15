#include "pch.h"
#include "common.h"

extern InitialFrame initialFrame;
extern UpdateFrame updateFrame;
extern CloseImageView closeImageView;

static int viewindex = 0;

LambdaView::LambdaView(bool registered)
{
	index = viewindex;
	index2 = 0;
	viewindex++;
	if (registered) {
		flag = 0;
	}
	else
	{
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
			throw "initialFrame指针未被初始化";

		int i = initialFrame(index, 0, mat.data, mat.rows, mat.cols, 3);
		flag = RUNING;
	}
	else if (flag == RUNING)
	{
		if (updateFrame == NULL)
			throw "updateFrame指针未被初始化";
		updateFrame(index, 0, mat.data, strlen((char*)mat.data), (int)mat.step);
	}
}

void LambdaView::Close()
{

}

ViewState LambdaView::GetState()
{
	return (ViewState)flag;
}
void LambdaView::SetState(ViewState state)
{
	if (state == CLOSED)
		CloseImageView();

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

LambdaView* LambdaView::GetIdleOrNew()
{
	LambdaView* lambdaView = NULL;
	lambdaView = new LambdaView(false);
	return lambdaView;
}

LambdaView* LambdaView::GetRegistered(int index)
{
	LambdaView* lambdaView = NULL;
	lambdaView = new LambdaView(false);	
	return lambdaView;
}

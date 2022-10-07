#include "pch.h"
#include "algorithm.h"

/**
 * @function randomColor
 * @brief Produces a random color given a random object
 */
Scalar randomColor(RNG& rng)
{
	int icolor = (unsigned)rng;
	return Scalar(icolor & 255, (icolor >> 8) & 255, (icolor >> 16) & 255);
}

/**
 * @function Drawing_Random_Lines
 */
int Drawing_Random_Lines(Mat& image)
{
	Point pt1, pt2;

	for (int i = 0; i < NUMBER; i++)
	{
		pt1.x = rng.uniform(x_1, x_2);
		pt1.y = rng.uniform(y_1, y_2);
		pt2.x = rng.uniform(x_1, x_2);
		pt2.y = rng.uniform(y_1, y_2);

		line(image, pt1, pt2, randomColor(rng), rng.uniform(1, 10), 8);
	}
	return 0;
}

/**
 * @function Drawing_Rectangles
 */
int Drawing_Random_Rectangles(Mat& image)
{
	Point pt1, pt2;
	int lineType = 8;
	int thickness = rng.uniform(-3, 10);

	for (int i = 0; i < NUMBER; i++)
	{
		pt1.x = rng.uniform(x_1, x_2);
		pt1.y = rng.uniform(y_1, y_2);
		pt2.x = rng.uniform(x_1, x_2);
		pt2.y = rng.uniform(y_1, y_2);

		rectangle(image, pt1, pt2, randomColor(rng), MAX(thickness, -1), lineType);
	}

	return 0;
}

/**
 * @function Drawing_Random_Ellipses
 */
int Drawing_Random_Ellipses(Mat& image)
{
	int lineType = 8;

	for (int i = 0; i < NUMBER; i++)
	{
		Point center;
		center.x = rng.uniform(x_1, x_2);
		center.y = rng.uniform(y_1, y_2);

		Size axes;
		axes.width = rng.uniform(0, 200);
		axes.height = rng.uniform(0, 200);

		double angle = rng.uniform(0, 180);

		ellipse(image, center, axes, angle, angle - 100, angle + 200,
			randomColor(rng), rng.uniform(-1, 9), lineType);
	}

	return 0;
}

/**
 * @function Drawing_Random_Polylines
 */
int Drawing_Random_Polylines(Mat& image)
{
	int lineType = 8;

	for (int i = 0; i < NUMBER; i++)
	{
		Point pt[2][3];
		pt[0][0].x = rng.uniform(x_1, x_2);
		pt[0][0].y = rng.uniform(y_1, y_2);
		pt[0][1].x = rng.uniform(x_1, x_2);
		pt[0][1].y = rng.uniform(y_1, y_2);
		pt[0][2].x = rng.uniform(x_1, x_2);
		pt[0][2].y = rng.uniform(y_1, y_2);
		pt[1][0].x = rng.uniform(x_1, x_2);
		pt[1][0].y = rng.uniform(y_1, y_2);
		pt[1][1].x = rng.uniform(x_1, x_2);
		pt[1][1].y = rng.uniform(y_1, y_2);
		pt[1][2].x = rng.uniform(x_1, x_2);
		pt[1][2].y = rng.uniform(y_1, y_2);

		const Point* ppt[2] = { pt[0], pt[1] };
		int npt[] = { 3, 3 };

		polylines(image, ppt, npt, 2, true, randomColor(rng), rng.uniform(1, 10), lineType);
	}
	return 0;
}

/**
 * @function Drawing_Random_Filled_Polygons
 */
int Drawing_Random_Filled_Polygons(Mat& image)
{
	int lineType = 8;

	for (int i = 0; i < NUMBER; i++)
	{
		Point pt[2][3];
		pt[0][0].x = rng.uniform(x_1, x_2);
		pt[0][0].y = rng.uniform(y_1, y_2);
		pt[0][1].x = rng.uniform(x_1, x_2);
		pt[0][1].y = rng.uniform(y_1, y_2);
		pt[0][2].x = rng.uniform(x_1, x_2);
		pt[0][2].y = rng.uniform(y_1, y_2);
		pt[1][0].x = rng.uniform(x_1, x_2);
		pt[1][0].y = rng.uniform(y_1, y_2);
		pt[1][1].x = rng.uniform(x_1, x_2);
		pt[1][1].y = rng.uniform(y_1, y_2);
		pt[1][2].x = rng.uniform(x_1, x_2);
		pt[1][2].y = rng.uniform(y_1, y_2);

		const Point* ppt[2] = { pt[0], pt[1] };
		int npt[] = { 3, 3 };

		fillPoly(image, ppt, npt, 2, randomColor(rng), lineType);
	}
	return 0;
}

/**
 * @function Drawing_Random_Circles
 */
int Drawing_Random_Circles(Mat& image)
{
	int lineType = 8;

	for (int i = 0; i < NUMBER; i++)
	{
		Point center;
		center.x = rng.uniform(x_1, x_2);
		center.y = rng.uniform(y_1, y_2);

		circle(image, center, rng.uniform(0, 300), randomColor(rng),
			rng.uniform(-1, 9), lineType);
	}

	return 0;
}

/**
 * @function Displaying_Random_Text
 */
int Displaying_Random_Text(Mat& image)
{
	int lineType = 8;

	for (int i = 1; i < NUMBER; i++)
	{
		Point org;
		org.x = rng.uniform(x_1, x_2);
		org.y = rng.uniform(y_1, y_2);

		putText(image, "Testing text rendering", org, rng.uniform(0, 8),
			rng.uniform(0, 100) * 0.05 + 0.1, randomColor(rng), rng.uniform(1, 10), lineType);
	}

	return 0;
}

/**
 * @function Displaying_Big_End
 */
int Displaying_Big_End(Mat& image)
{
	Size textsize = getTextSize("OpenCV forever!", FONT_HERSHEY_COMPLEX, 3, 5, 0);
	Point org((window_width - textsize.width) / 2, (window_height - textsize.height) / 2);
	int lineType = 8;

	Mat image2;

	for (int i = 0; i < 255; i += 2)
	{
		image2 = image - Scalar::all(i);
		putText(image2, "OpenCV forever!", org, FONT_HERSHEY_COMPLEX, 3,
			Scalar(i, i, 255), 5, lineType);
	}

	return 0;
}
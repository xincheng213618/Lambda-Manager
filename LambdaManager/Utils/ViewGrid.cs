using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Lambda;

namespace LambdaManager.Utils;

internal class ViewGrid
{
	private static readonly int[] defaultViewIndexMap = new int[100]
	{
		0, 1, 4, 9, 16, 25, 36, 49, 64, 81,
		2, 3, 5, 10, 17, 26, 37, 50, 65, 82,
		6, 7, 8, 11, 18, 27, 38, 51, 66, 83,
		12, 13, 14, 15, 19, 28, 39, 52, 67, 84,
		20, 21, 22, 23, 24, 29, 40, 53, 68, 85,
		30, 31, 32, 33, 34, 35, 41, 54, 69, 86,
		42, 43, 44, 45, 46, 47, 48, 55, 70, 87,
		56, 57, 58, 59, 60, 61, 62, 63, 71, 88,
		72, 73, 74, 75, 76, 77, 78, 79, 80, 89,
		90, 91, 92, 93, 94, 95, 96, 97, 98, 99
	};

	private static int[] viewIndexMap = defaultViewIndexMap;

	private static readonly int[] splits = new int[19]
	{
		0, 1, 3, 5, 8, 11, 15, 19, 24, 29,
		35, 41, 48, 55, 63, 71, 80, 89, 99
	};

	private static int split = 0;

	private static readonly List<int> ClosingViewIndex = ((MainWindow)Application.Current.MainWindow).ClosingViewIndex;

	private static View?[] Views { get; set; } = ((MainWindow)Application.Current.MainWindow).Views;
	
	public static Grid[] gridsList=new Grid[100];

	public static View? GetIdleOrNewView(int index)
	{
		//PrepareGrid(index);
		if (Views[index] != null)
        {
			return Views[index];
		}
		return AddView(index);
	}

	private static Grid GetNewGrid(Image image)
    {
		Grid grid = new Grid()
		{
			Margin = new Thickness(2, 2, 2, 2),
		};
		Canvas canvas = new Canvas()
		{
			Background = new SolidColorBrush(Color.FromRgb(195, 195, 195)),
			ClipToBounds = true
		};

		TransformGroup transformGroup = new();
		TranslateTransform tlt = new();
		ScaleTransform sfr = new();
		transformGroup.Children.Add(sfr);
		transformGroup.Children.Add(tlt);
		image.RenderTransform = transformGroup;
		image.MouseWheel += delegate (object sender, MouseWheelEventArgs e)
		{
			Point centerPoint = e.GetPosition(canvas);
			if (sfr.ScaleX < 0.2 && sfr.ScaleY < 0.2 && e.Delta < 0)
			{
				return;
			}
			sfr.CenterX = centerPoint.X;
			sfr.CenterY = centerPoint.Y;
			sfr.ScaleX += (double)e.Delta / 3500;
			sfr.ScaleY += (double)e.Delta / 3500;
		};
		bool isMouseLeftButtonDown = false;
		Point mouseXY;
		image.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
		{
			isMouseLeftButtonDown = true;
			mouseXY = e.GetPosition(image);
		};
		image.MouseLeftButtonUp += delegate (object sender, MouseButtonEventArgs e)
		{
			isMouseLeftButtonDown = false;
		};
		image.MouseMove += delegate (object sender, MouseEventArgs e)
		{
			if (isMouseLeftButtonDown == true)
			{
				Point position = e.GetPosition(image);
				tlt.X += position.X - mouseXY.X;
				tlt.Y += position.Y - mouseXY.Y;
			}
		};


		canvas.Children.Add(image);
		grid.Children.Add(canvas);
		return grid;
	}
	private static void GridSort(Grid[] GridLists)
    {
		Grid mainView = ((MainWindow)Application.Current.MainWindow).mainView;

		mainView.Children.Clear();
		mainView.ColumnDefinitions.Clear();
		mainView.RowDefinitions.Clear();
		int newlist = 0;
		for (int i = 0; i < GridLists.Length; i++)
		{
			if (GridLists[i] != null)
			{
				Grid grid = GridLists[i];
				int location = Array.IndexOf(defaultViewIndexMap, newlist);
				int row = (location / 10);
				int col = (location % 10);
				if (mainView.ColumnDefinitions.Count <= col)
				{
					ColumnDefinition columnDefinition = new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") };
					mainView.ColumnDefinitions.Add(columnDefinition);
				}
				if (mainView.RowDefinitions.Count <= row)
				{
					RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
					mainView.RowDefinitions.Add(rowDefinition);
				}

				grid.SetValue(Grid.RowProperty, row);
				grid.SetValue(Grid.ColumnProperty, col);
				mainView.Children.Add(grid);
				newlist++;
			}
		}
	}

	static GridLengthConverter gridLengthConverter = new GridLengthConverter();

	private static View AddView(int index)
	{
		Image image = new Image
		{
			Stretch = Stretch.Uniform
		};
		Grid grid = GetNewGrid(image);

        gridsList[index] = grid;
		GridSort(gridsList);

		View view = new View(image, index);
		Views[index] = view;
		return view;
	}

	

	public static void CloseVieW(int index)
	{
		View view = Views[index];
		if (view == null)
			return;

		ClosingViewIndex.Add(index);

		gridsList[index] = null;
		GridSort(gridsList);

		Views[index] = view;
		Views[index] = null;
		view.Image.Source = null;
	}

}

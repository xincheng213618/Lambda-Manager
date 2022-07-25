using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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

	private static readonly List<int> ClosingViewIndex = ((MainWindow)Application.Current.MainWindow).ClosingViewIndex;
	private static View?[] Views { get; set; } = ((MainWindow)Application.Current.MainWindow).Views;

	public static Grid[] gridsList=new Grid[100];

	public static View? GetIdleOrNewView(int index)
	{
		return AddView(index);
	}

	private static Grid GetNewGrid(Image image)
    {
		Grid grid = new Grid(){
			Margin = new Thickness(2, 2, 2, 2),
		};

        grid.Children.Add(image);
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

	public static View AddView(Image image)
    {
		Grid grid = GetNewGrid(image);
		int index = 0;
        for (int i = 0; i < gridsList.Length; i++)
        {
			if (gridsList[i] == null)
            {
				index =i;
				break;
			}
		}
		gridsList[index] = grid;
		GridSort(gridsList);
		View view = new View(image, index);
		Views[index] = view;
		return view;
	}


	private static View AddView(int index)
	{
		Image image = new Image{
			Stretch = Stretch.Uniform
		};

		Grid grid = GetNewGrid(image);
		gridsList[index] = grid;
		GridSort(gridsList);

		View view = new View(image, index);
		Views[index] = view;
        LambdaControl.Trigger("IMAGE_VIEW_CREATED", null, new Dictionary<string, object> { { "view", index } });
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

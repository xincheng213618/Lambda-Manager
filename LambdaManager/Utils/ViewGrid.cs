using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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


	public static View? GetIdleOrNewView(int index)
	{
		//PrepareGrid(index);
		return AddView(index);
	}

	static GridLengthConverter gridLengthConverter = new GridLengthConverter();

	private static View AddView(int index)
	{
		Grid mainView = ((MainWindow)Application.Current.MainWindow).mainView;
		Grid grid = new Grid()
		{
			Margin = new Thickness(2, 2, 2, 2),
		};
		Image image = new Image
		{
			Stretch = Stretch.Uniform
		};
		Canvas canvas = new Canvas()
		{
			Background = new SolidColorBrush(Color.FromRgb(195, 195, 195)),
			ClipToBounds = true
		};
		canvas.Children.Add(image);

		grid.Children.Add(canvas);

		int location = Array.IndexOf( defaultViewIndexMap, index);
		int row =  (location / 10);
		if (mainView.RowDefinitions.Count  <= row)
		{
			RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
			mainView.RowDefinitions.Add(rowDefinition);
		}

		int col =  (location % 10);
		if (mainView.ColumnDefinitions.Count <= row)
		{
			ColumnDefinition rowDefinition = new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") };
			mainView.ColumnDefinitions.Add(rowDefinition);
		}
		grid.SetValue(Grid.RowProperty, row);
		grid.SetValue(Grid.ColumnProperty, col);


		mainView.Children.Add(grid);

		View view = new View(image, index);
		Views[index] = view;
		return view;
	}

	public static void CloseVieW(int index)
	{
		View view = Views[index];
		if (view == null)
		{
			return;
		}
		ClosingViewIndex.Add(index);
		Views[index] = null;
		view.Image.Source = null;
		List<FrameworkElement> list = new List<FrameworkElement>();
		FrameworkElement grid = GetMainViewChild("grid" + index);
		if (grid != null)
		{
			list.Add(grid);
		}
		list.AddRange(GetUselessSplitter(index));
		UIElementCollection children = GetMainView().Children;
		foreach (FrameworkElement element in list)
		{
			children.Remove(element);
		}
		split = CalcSplit();
	}

	private static FrameworkElement? GetMainViewChild(string name)
	{
		UIElementCollection list = GetMainView().Children;
		for (int i = 0; i < list.Count; i++)
		{
			FrameworkElement child = list[i] as FrameworkElement;
			if (child?.Name == name)
			{
				return child;
			}
		}
		return null;
	}


	private static List<FrameworkElement> GetUselessSplitter(int index)
	{
		int num = Array.IndexOf(viewIndexMap, index);
		int rowIndex = num / 10;
		int colIndex = num % 10;
		Grid mainView = GetMainView();
		List<FrameworkElement> list = new List<FrameworkElement>();
		bool num2 = IsRowColEmpty(rowIndex, checkRow: true);
		bool isColEmpty = IsRowColEmpty(colIndex, checkRow: false);
		if (num2)
		{
			if (CleanGridDefinition(mainView, mainView.RowDefinitions, rowIndex, mainView.ColumnDefinitions.Count, isRow: true))
			{
				UpdateViewLayout(rowIndex, mainView.RowDefinitions, checkRow: true);
			}
			FrameworkElement splitter2 = GetMainViewChild("row" + rowIndex);
			if (splitter2 != null)
			{
				list.Add(splitter2);
			}
		}
		if (isColEmpty)
		{
			if (CleanGridDefinition(mainView, mainView.ColumnDefinitions, colIndex, mainView.RowDefinitions.Count, isRow: false))
			{
				UpdateViewLayout(colIndex, mainView.RowDefinitions, checkRow: false);
			}
			FrameworkElement splitter = GetMainViewChild("col" + colIndex);
			if (splitter != null)
			{
				list.Add(splitter);
			}
		}
		return list;
	}

	private static bool IsRowColEmpty(int rowColIndex, bool checkRow)
	{
		Grid mainView = GetMainView();
		IList list2;
		if (!checkRow)
		{
			IList rowDefinitions = mainView.RowDefinitions;
			list2 = rowDefinitions;
		}
		else
		{
			IList rowDefinitions = mainView.ColumnDefinitions;
			list2 = rowDefinitions;
		}
		IList list = list2;
		for (int i = 0; i < (list.Count + 1) / 2; i++)
		{
			int index = (checkRow ? (rowColIndex * 10 + i) : (i * 10 + rowColIndex));
			if (Views[viewIndexMap[index]] != null)
			{
				return false;
			}
		}
		return true;
	}

	private static bool CleanGridDefinition(Grid mainGrid, IList rowsOrCols, int rowOrColIndex, int colsOrRowsCount, bool isRow)
	{
		switch (rowsOrCols.Count)
		{
		case 0:
			return false;
		case 1:
			rowsOrCols.RemoveAt(0);
			return false;
		default:
			rowsOrCols.RemoveAt((rowOrColIndex == 0) ? 1 : (2 * rowOrColIndex));
			rowsOrCols.RemoveAt((rowOrColIndex != 0) ? (2 * rowOrColIndex - 1) : 0);
			return true;
		}
	}

	private static void UpdateViewLayout(int rowColIndex, IList rowsOrCols, bool checkRow)
	{
		UpdateRemainSplitter(rowColIndex, rowsOrCols, checkRow);
	}

	private static void UpdateRemainSplitter(int rowColIndex, IList rowsOrCols, bool checkRow)
	{
		for (int i = rowColIndex; i < rowsOrCols.Count; i++)
		{
			if (checkRow)
			{
				FrameworkElement splitter = GetMainViewChild((checkRow ? "row" : "col") + i);
				if (splitter != null)
				{
					splitter.Name = (checkRow ? "row" : "col") + (i - 1);
					DependencyProperty type = (checkRow ? Grid.RowProperty : Grid.ColumnProperty);
					int location = (int)splitter.GetValue(type);
					splitter.SetValue(type, location - 2);
				}
			}
		}
	}

	private static Image CreateView(int index)
	{
		Grid grid = new Grid();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler.AppendLiteral("grid");
		defaultInterpolatedStringHandler.AppendFormatted(index);
		grid.Name = defaultInterpolatedStringHandler.ToStringAndClear();
		grid.HorizontalAlignment = HorizontalAlignment.Center;
		grid.VerticalAlignment = VerticalAlignment.Center;
		Image image = new Image
		{
			Stretch = Stretch.Uniform
		};
		grid.Children.Add(image);
		StackPanel ruler = new StackPanel
		{
			HorizontalAlignment = HorizontalAlignment.Right,
			VerticalAlignment = VerticalAlignment.Bottom,
			Margin = new Thickness(0.0, 0.0, 20.0, 20.0)
		};
		BuildRuler(ruler);
		grid.Children.Add(ruler);
		return image;
	}

	private static void BuildRuler(StackPanel ruler)
	{
		TextBlock textblock = new TextBlock
		{
			HorizontalAlignment = HorizontalAlignment.Center,
			Foreground = SystemColors.HighlightTextBrush,
			Text = (Application.Current.Resources["Unit"] as string)
		};
		ruler.Children.Add(textblock);
		Path path = new Path
		{
			StrokeThickness = 1.0,
			Stroke = SystemColors.HighlightTextBrush
		};
		ruler.Children.Add(path);
		Binding b = new Binding
		{
			Source = (Application.Current.Resources["Figures"] as string)
		};
		BindingOperations.SetBinding(path, Path.DataProperty, b);
	}

	private static Grid GetMainView()
	{
		return ((MainWindow)Application.Current.MainWindow).mainView;
	}

	private static void SetViewPosition(UIElement el, int index)
	{
		int location = Array.IndexOf(viewIndexMap, index);
		int row = 2 * (location / 10);
		int col = 2 * (location % 10);
		el.SetValue(Grid.RowProperty, row);
		el.SetValue(Grid.ColumnProperty, col);
	}

	private static int CalcSplit()
	{
		Grid mainView = GetMainView();
		int rows = (mainView.RowDefinitions.Count + 1) / 2;
		int cols = (mainView.ColumnDefinitions.Count + 1) / 2;
		int count = rows * cols;
		for (int i = 0; i < splits.Length; i++)
		{
			if (splits[i] > count)
			{
				return splits[i - 1];
			}
		}
		return 0;
	}
}

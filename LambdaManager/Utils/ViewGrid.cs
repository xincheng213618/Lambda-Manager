using Lambda;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LambdaManager.Utils;

internal class ViewGrid
{
	private static readonly int[] grids = new int[100]
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

	private static readonly int[] splits = new int[19]
	{
		0, 1, 3, 5, 8, 11, 15, 19, 24, 29,
		35, 41, 48, 55, 63, 71, 80, 89, 99
	};

	private static int split = 0;

	private static View[] Views { get; } = ((MainWindow)Application.Current.MainWindow).Views;


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
			Margin = new Thickness(2,2,2,2),	
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

		int location = Array.IndexOf(grids, index);
		int row =  (location / 10);
		if (mainView.RowDefinitions.Count<= row)
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


	private static void BuildToolbar(Border toolbar)
	{
		StackPanel pannel = (StackPanel)(toolbar.Child = new StackPanel
		{
			Orientation = Orientation.Horizontal,
			Opacity = 0.5,
			Margin = new Thickness(5.0)
		});
		Style style = ((MainWindow)Application.Current.MainWindow).Resources["InImageButton"] as Style;
		TextBlock textblock1 = new TextBlock
		{
			Text = (Application.Current.Resources["Shot"] as string),
			Style = style
		};
		TextBlock textblock2 = new TextBlock
		{
			Text = (Application.Current.Resources["Video"] as string),
			Style = style
		};
		TextBlock textblock3 = new TextBlock
		{
			Text = (Application.Current.Resources["NShot"] as string),
			Style = style
		};
		pannel.Children.Add(textblock1);
		pannel.Children.Add(textblock2);
		pannel.Children.Add(textblock3);
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
}

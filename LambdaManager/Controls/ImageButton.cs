using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LambdaManager.Controls;

public class ImageButton : Button
{
	public static readonly DependencyProperty ImageWidthProperty;

	public static readonly DependencyProperty ImageHeightProperty;

	public static readonly DependencyProperty ImageLocationProperty;

	public static readonly DependencyProperty ImageSourceProperty;

	public static readonly DependencyProperty RowIndexProperty;

	public static readonly DependencyProperty ColumnIndexProperty;

	public int ImageWidth
	{
		get
		{
			return (int)GetValue(ImageWidthProperty);
		}
		set
		{
			SetValue(ImageWidthProperty, value);
		}
	}

	public int ImageHeight
	{
		get
		{
			return (int)GetValue(ImageHeightProperty);
		}
		set
		{
			SetValue(ImageHeightProperty, value);
		}
	}

	public ImageLocation? ImageLocation
	{
		get
		{
			return (ImageLocation)GetValue(ImageLocationProperty);
		}
		set
		{
			SetValue(ImageLocationProperty, value);
		}
	}

	public ImageSource ImageSource
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceProperty);
		}
		set
		{
			SetValue(ImageSourceProperty, value);
		}
	}

	public int RowIndex
	{
		get
		{
			return (int)GetValue(RowIndexProperty);
		}
		set
		{
			SetValue(RowIndexProperty, value);
		}
	}

	public int ColumnIndex
	{
		get
		{
			return (int)GetValue(ColumnIndexProperty);
		}
		set
		{
			SetValue(ColumnIndexProperty, value);
		}
	}

	static ImageButton()
	{
		ImageWidthProperty = DependencyProperty.Register("ImageWidth", typeof(int), typeof(ImageButton), new PropertyMetadata(30));
		ImageHeightProperty = DependencyProperty.Register("ImageHeight", typeof(int), typeof(ImageButton), new PropertyMetadata(30));
		ImageLocationProperty = DependencyProperty.Register("ImageLocation", typeof(ImageLocation?), typeof(ImageButton), new PropertyMetadata(null, PropertyChangedCallback));
		ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(null));
		RowIndexProperty = DependencyProperty.Register("RowIndex", typeof(int), typeof(ImageButton), new PropertyMetadata(0));
		ColumnIndexProperty = DependencyProperty.Register("ColumnIndex", typeof(int), typeof(ImageButton), new PropertyMetadata(0));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
	}

	public ImageButton()
	{
		SetCurrentValue(ImageLocationProperty, LambdaManager.Controls.ImageLocation.Left);
	}

	private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		ImageButton imageButton = (ImageButton)d;
		switch (((ImageLocation?)e.NewValue).GetValueOrDefault())
		{
		case LambdaManager.Controls.ImageLocation.Left:
			imageButton.SetCurrentValue(RowIndexProperty, 1);
			imageButton.SetCurrentValue(ColumnIndexProperty, 0);
			break;
		case LambdaManager.Controls.ImageLocation.Top:
			imageButton.SetCurrentValue(RowIndexProperty, 0);
			imageButton.SetCurrentValue(ColumnIndexProperty, 1);
			break;
		case LambdaManager.Controls.ImageLocation.Right:
			imageButton.SetCurrentValue(RowIndexProperty, 1);
			imageButton.SetCurrentValue(ColumnIndexProperty, 2);
			break;
		case LambdaManager.Controls.ImageLocation.Bottom:
			imageButton.SetCurrentValue(RowIndexProperty, 2);
			imageButton.SetCurrentValue(ColumnIndexProperty, 1);
			break;
		case LambdaManager.Controls.ImageLocation.Center:
			imageButton.SetCurrentValue(RowIndexProperty, 1);
			imageButton.SetCurrentValue(ColumnIndexProperty, 1);
			break;
		default:
			throw new ArgumentOutOfRangeException();
		}
	}
}

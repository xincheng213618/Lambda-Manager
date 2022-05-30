using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using LambdaManager.Features;
using LambdaManager.Properties;
using LambdaManager.Utils;
using ThemeManager.Controls;

namespace LambdaManager;

partial class MainWindow : BaseWindow 
{ 
	private readonly StreamWriter logger = InitLogger();
	private readonly Severity logLevel = (Severity)Enum.Parse(typeof(Severity), Settings.Default.LogLevel, ignoreCase: true);

	private bool multiMode;
	private bool multiChannel;
	internal View[] Views { get; } = new View[100];


	internal List<int> ClosingViewIndex { get; } = new List<int>();


	internal string? Notice { get; set; }

	internal bool Maximize { get; set; }

	internal bool IsLeftViewHidden { get; set; }

	internal bool IsMiddleViewHidden { get; set; }

	internal double LeftViewWidth { get; set; }

	internal double MiddleViewWidth { get; set; }


	public MainWindow()
	{
		InitializeComponent();
		ChangeMiddleViewVisibility(false);

    }


	private async void Update()
    {
        await Task.Delay(99);
        UIEvents.Initialze();
        AddMessage(new Message
        {
            Severity = Severity.INFO,
            Text = LambdaManager.Properties.Resources.ConfigLoading
        });
        bool num = new ConfigLibrary().Load("application.xml");
        if (msgList.Items.Count > 1)
        {
            msgList.Items.RemoveAt(0);
        }
        if (num)
        {
            AddMessage(new Message
            {
                Severity = Severity.INFO,
                Text = Properties.Resources.ConfigLoaded
            });
        }
        else if (Settings.Default.ExitIfLoadFatalError)
        {
            MessageBox.Show(LambdaManager.Properties.Resources.StartFatalError + GetLogDir() + "\\lambda.log", Severity.FATAL_ERROR.Description(), MessageBoxButton.OK, MessageBoxImage.Hand);
            Application.Current.Shutdown();
        }
        InitViewer();
    }

    private void Window_Initialized(object sender, EventArgs e)
    {
        SliderAll1.Value = 1920;
        SliderAll1.ValueChanged += Slider_ValueChanged;
        Update();

    }




    internal void AddMessage(Severity severity, string obj, string? name, string attr, string? value, string err)
	{
		string pleaseCheck = LambdaManager.Properties.Resources.PleaseCheck;
		if (name != null)
		{
			obj = obj + "[" + name + "]";
		}
		if (value != null)
		{
			attr = attr + "[" + value + "]";
		}
		string of = LambdaManager.Properties.Resources.of;
		Message obj2 = new Message
		{
			Severity = severity
		};
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 5);
		defaultInterpolatedStringHandler.AppendFormatted(obj);
		defaultInterpolatedStringHandler.AppendFormatted(of);
		defaultInterpolatedStringHandler.AppendFormatted(attr);
		defaultInterpolatedStringHandler.AppendFormatted(err);
		defaultInterpolatedStringHandler.AppendLiteral(", ");
		defaultInterpolatedStringHandler.AppendFormatted(pleaseCheck);
		obj2.Text = defaultInterpolatedStringHandler.ToStringAndClear();
		AddMessage(obj2);
	}

	internal void AddMessage(Message message)
	{
		//日志监听的级别不对
		//LambdaControl.Log(message);
		if (message.Severity < logLevel)
		{
			return;
		}

		StackPanel panel = new StackPanel();
		panel.Orientation = Orientation.Horizontal;
		TextBlock textBlock = new TextBlock();
		Image image = new Image();
		image.BeginInit();
		image.Source = Application.Current.Resources[message.Severity.ToString()] as BitmapImage;
		image.Height = textBlock.FontSize;
		image.Width = textBlock.FontSize;
		image.EndInit();
		panel.Children.Add(image);
		string text = message.Text;
		if (text != null)
		{
			textBlock.Text = text;
			textBlock.Style = base.Resources["MessageBlock"] as Style;
			panel.Children.Add(textBlock);
			ItemCollection items = msgList.Items;
			items.Add(panel);
			msgList.SelectedIndex = items.Count - 1;
			if (items.Count > 500)
			{
				items.RemoveAt(0);
			}
			logger.WriteLine(message.Severity.Description() + text);
		}
	}

	internal MenuItem? AddMenuItem(string path)
	{
		ItemCollection items = menu.Items;
		if (items == null)
		{
			return null;
		}
		MenuItem last = null;
		string[] array = path.Split("/");
		foreach (string name in array)
		{
			bool found = false;
			foreach (MenuItem item in (IEnumerable)items)
			{
				if (item.Header.ToString() == name)
				{
					found = true;
					items = item.Items;
					break;
				}
			}
			if (!found)
			{
				MenuItem menuItem = new MenuItem();
				menuItem.Header = name;
				items.Add(menuItem);
				last = menuItem;
			}
		}
		return last;
	}

	private static StreamWriter InitLogger()
	{
		string dir = GetLogDir();
		if (!Directory.Exists(dir))
		{
			Directory.CreateDirectory(dir);
		}
		string fileName = dir + "\\lambda";
		string fileExtension = "log";
		string logPath = fileName + "." + fileExtension;
		FileInfo fileInfo = new FileInfo(logPath);

		StreamWriter writer;
        if (fileInfo.Exists)
        {
            if (fileInfo.Length > 10485760)
            {
                DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
                defaultInterpolatedStringHandler.AppendFormatted(fileName);
                defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now, "yyyyMMdd");
                defaultInterpolatedStringHandler.AppendLiteral(".");
                defaultInterpolatedStringHandler.AppendFormatted(fileExtension);
                File.Move(logPath, defaultInterpolatedStringHandler.ToStringAndClear());
            }
            writer = File.AppendText(logPath);
            writer.WriteLine("");
        }
        else
        {
            writer = new StreamWriter(File.Open(logPath, FileMode.OpenOrCreate), Encoding.UTF8);
        }
        writer.WriteLine(Severity.INFO.Description() + LambdaManager.Properties.Resources.StartUp + DateTime.Now);
        FunctionExecutor.Solution.Writer = writer;

        return writer;
	}

	private static string GetLogDir()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\LambdaManager";
	}
	

	private void InitViewer()
	{
		//Views[0] = new View(view0, 0);
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("APPLICATION_LOADED", sender, e);
	}

	private void Window_Closing(object sender, CancelEventArgs e)
	{
		for (int i = 0; i < Views.Length; i++)
		{
			View view = Views[i];
			if (view != null)
			{
				view.State = ViewState.CLOSED;
			}
		}
		Thread.Sleep(1000);
	}

	private void Window_ContentRendered(object sender, EventArgs e)
	{
		LambdaControl.Trigger("APPLICATION_DISPLAYED", sender, e);
		if (Maximize)
		{
			base.WindowState = WindowState.Maximized;
		}
		if (Notice != null)
		{
			MessageBox.Show(Notice, LambdaManager.Properties.Resources.Notice, MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	internal Panel GetConfigPanel(Side side)
	{
		return side switch
		{
			Side.MIDDLE => materialView, 
			Side.BOTTOM => bottomView, 
			Side.ACQUIRE => acquireView, 
			Side.PROJECT => projectView, 
			_ => throw new Exception("top view not supported"), 
		};
	}

	private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
	{
        stageAcquisition.Width = SliderAll1.Value;
        stageAcquisition.Height = SliderAll1.Value * (this.Height - 48) / (this.Width);
    }

	

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		LambdaControl.Trigger("GLOBAL_ZOOM", sender, e);
		try
		{
			stageAcquisition.Width = SliderAll1.Value;
			stageAcquisition.Height = SliderAll1.Value * (this.Height - 47) / (this.Width);
		}
		catch
		{

		}
	}

	private void RadioButton_Checked(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("PHASE_CHECKED", sender, e);
	}

	private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("PHASE_CHECKED", sender, e);
	}

	private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("PHASE_CHECKED", sender, e);
	}

	private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("PHASE_CHECKED", sender, e);
	}

	private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("PHASE_CHECKED", sender, e);
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		if (sender is ToggleButton btn)
		{
			LambdaControl.Trigger(btn.IsChecked.GetValueOrDefault() ? "STOP_ALIVE" : "START_ALIVE", sender, e);
			btn.Content = (btn.IsChecked.GetValueOrDefault() ? "停止预览" : "预览");
		}
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		if (sender is ToggleButton btn)
		{
			LambdaControl.Trigger(btn.IsChecked.GetValueOrDefault() ? "STOP_ACQUIRE" : "START_ACQUIRE", sender, e);
			btn.Content = (btn.IsChecked.GetValueOrDefault() ? "停止采集" : "开始采集");
		}
	}

	private void Button_Click_2(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("SNAPSHOT", sender, e);
	}

	private void Button_Click_3(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger(multiMode ? "START_MULTI_MODE" : "STOP_MULTI_MODE", sender, e);
		multiMode = !multiMode;
	}

	private void Button_Click_4(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger(multiChannel ? "START_MULTI_CHANNEL" : "START_MULTI_CHANNEL", sender, e);
		multiChannel = !multiChannel;
	}

	private void Button_Click_5(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("START_CLICKED", sender, e);
	}

	private void Button_Click_6(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("STOP_CLICKED", sender, e);
	}

	private void Button_Click_7(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("FORWARD_CLICKED", sender, e);
	}

	private void Button_Click_8(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("BACKWARD_CLICKED", sender, e);
	}

	private void fpsState_TextChanged(object sender, TextChangedEventArgs e)
	{
		LambdaControl.Trigger("FPS_CHANGED", sender, e);
	}

	private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		Slider slider = sender as Slider;
		LambdaControl.Trigger("TSERIES_CHANGED", sender, new Dictionary<string, object>() { { "num", (int)slider.Value -1} });
	}
	private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		Slider slider = sender as Slider;
		LambdaControl.Trigger("ZINDEX_CHANGED", sender, new Dictionary<string, object>() { { "num", (int)slider.Value - 1 } });
	}

	private void Button_Click_9(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("QUATER_CLICKED", sender, e);
	}

	private void Button_Click_10(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("DUAL_CLICKED", sender, e);
	}

	private void Button_Click_11(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("BF_CLICKED", sender, e);
	}

	private void Button_Click_12(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("DF_CLICKED", sender, e);
	}

	private void Button_Click_13(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("RI_CLICKED", sender, e);
	}

	private void Button_Click_14(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("DP_CLICKED", sender, e);
	}

	private void Button_Click_15(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("PHI_RESETED", sender, e);
	}

	private void Button_Click_16(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("FL_CLICKED", sender, e);
	}

	private void Button_Click_17(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("3D_CLICKED", sender, e);
	}

	private void Button_Click_18(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("CUBE_CLICKED", sender, e);
	}

	private void Button_Click_19(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("REPO_CLICKED", sender, e);
	}

	private void Button_Click_20(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("POINTER_CLICKED", sender, e);
	}

	private void Button_Click_21(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("SELECT_CLICKED", sender, e);
	}

	private void Button_Click_22(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("MOVE_CLICKED", sender, e);
	}

	private void Button_Click_23(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("SEARCH_CLICKED", sender, e);
	}

	private void Button_Click_24(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("ZOOM_IN_CLICKED", sender, e);
	}

	private void Button_Click_25(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("ZOME_OUT_CLICKED", sender, e);
	}

	private void Button_Click_26(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("SCALE_RESETED", sender, e);
	}

	private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
	{
		LambdaControl.Trigger("SCALE_CHANGED", sender, e);
	}

	private void Button_Click_27(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("DIMENSION_CLICKED", sender, e);
	}

	private void Button_Click_28(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("FOCUS_CLICKED", sender, e);
	}

	private void Button_Click_29(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("RULER_CLICKED", sender, e);
	}

	private void Button_Click_30(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("ERASER_CLICKED", sender, e);
	}

	private void Button_Click_31(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("TEXT_CLICKED", sender, e);
	}

	private void Button_Click_32(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("ARROW_CLICKED", sender, e);
	}

	private void Button_Click_33(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("LINE_CLICKED", sender, e);
	}

	private void Button_Click_34(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("CURVE_CLICKED", sender, e);
	}

	private void Button_Click_35(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("CIRCLE_CLICKED", sender, e);
	}

	private void Button_Click_36(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("RECTANGLE_CLICKED", sender, e);
	}

	private void Button_Click_37(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("POLYGON_CLICKED", sender, e);
	}

	private void Button_Click_38(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("COLORBAR_CLICKED", sender, e);
	}

	private void Button_Click_39(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("MONO_CLICKED", sender, e);
	}

	private void Button_Click_40(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("DIVIDER_CLICKED", sender, e);
	}

	private void Button_Click_41(object sender, RoutedEventArgs e)
	{
		LambdaControl.Trigger("HISTOGRAM_CLICKED", sender, e);
	}

	private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		if (IsLeftViewHidden)
		{
			ChangeLeftViewVisibility(visible: true);
		}
		if (IsMiddleViewHidden)
		{
			ChangeMiddleViewVisibility(visible: true);
		}
	}

	private void LeftSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		if (IsMiddleViewHidden)
		{
			ChangeMiddleViewVisibility(visible: true);
		}
		else
		{
			ChangeLeftViewVisibility(visible: false);
		}
	}

	private void MiddleSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
	{
		ChangeMiddleViewVisibility(visible: false);
	}

	public void ChangeLeftViewVisibility(bool visible)
	{
		if (visible)
		{
			if (LeftViewWidth > 0.0)
			{
				leftView.Width = new GridLength(LeftViewWidth, GridUnitType.Pixel);
			}
		}
		else
		{
			LeftViewWidth = leftView.ActualWidth;
			leftView.Width = new GridLength(0.0, GridUnitType.Auto);
		}
		ChangeColumnVisibility(0, visible);
		ChangeColumnVisibility(1, visible);
		IsLeftViewHidden = !visible;
	}

	public void ChangeMiddleViewVisibility(bool visible)
	{
		if (visible)
		{
			if (MiddleViewWidth > 0.0)
			{
				middleView.Width = new GridLength(MiddleViewWidth, GridUnitType.Pixel);
			}
		}
		else if (middleView.Width.GridUnitType == GridUnitType.Pixel)
		{
			MiddleViewWidth = middleView.ActualWidth;
			middleView.Width = new GridLength(0.0, GridUnitType.Auto);
		}
		ChangeColumnVisibility(2, visible);
		ChangeColumnVisibility(3, visible);
		IsMiddleViewHidden = !visible;
	}

	private void ChangeColumnVisibility(int col, bool visible)
	{
		foreach (UIElement item in from UIElement i in stageAcquisition.Children
			where Grid.GetColumn(i) == col
			select i)
		{
			item.Visibility = ((!visible) ? Visibility.Collapsed : Visibility.Visible);
		}
	}

	private void LeftSplitter_DragCompleted(object sender, DragCompletedEventArgs e)
	{
        //LeftViewWidth = leftView.ActualWidth;
    }

	private void MiddleSplitter_DragCompleted(object sender, DragCompletedEventArgs e)
	{
		MiddleViewWidth = middleView.ActualWidth;
	}





}

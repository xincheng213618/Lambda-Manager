using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using LambdaManager.Features;
using LambdaManager.Properties;
using LambdaManager.Utils;

namespace LambdaManager;

partial class MainWindow : Window, IComponentConnector
{
	private readonly StreamWriter logger = InitLogger();

	private readonly Severity logLevel = (Severity)Enum.Parse(typeof(Severity), Settings.Default.LogLevel, ignoreCase: true);


	internal View[] Views { get; } = new View[100];


	internal string? Notice { get; set; }

	internal bool Maximize { get; set; }

	public MainWindow()
	{
		InitializeComponent();
		if (DateTime.Now > Convert.ToDateTime("2022/3/31"))
		{
			AddMessage(new Message
			{
				Severity = Severity.INFO,
				Text = LambdaManager.Properties.Resources.Expired
			});
			MessageBox.Show(LambdaManager.Properties.Resources.Expired, Severity.FATAL_ERROR.Description(), MessageBoxButton.OK, MessageBoxImage.Hand);
			Application.Current.Shutdown();
			return;
		}
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
				Text = LambdaManager.Properties.Resources.ConfigLoaded
			});
		}
		else if (Settings.Default.ExitIfLoadFatalError)
		{
			MessageBox.Show(LambdaManager.Properties.Resources.StartFatalError + GetLogDir() + "\\lambda.log", Severity.FATAL_ERROR.Description(), MessageBoxButton.OK, MessageBoxImage.Hand);
			Application.Current.Shutdown();
		}
		UIEvents.Initialze();
		InitViewer();
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
			textBlock.Style = base.Resources["msgBlock"] as Style;
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
		Views[0] = new View(view0, 0);
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

}

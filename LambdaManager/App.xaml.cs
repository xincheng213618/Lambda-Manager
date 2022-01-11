using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using Quartz;

namespace LambdaManager;

partial class App : Application
{

	internal static Dictionary<string, Event>? GetResolvedEvents()
	{
		return FunctionExecutor.Solution?.Events;
	}

	internal static void Report(Message message)
	{
		Message message2 = message;
		if (Application.Current.Dispatcher.CheckAccess())
		{
			((MainWindow)Application.Current.MainWindow)?.AddMessage(message2);
		}
		else
		{
			Application.Current.Dispatcher.Invoke(act);
		}
		void act()
		{
			((MainWindow)Application.Current.MainWindow)?.AddMessage(message2);
		}
	}

	internal static void Report2(Message message)
	{
		message.Text = DateTime.Now.ToString("mm.ss.fff") + ": " + message.Text;
		Report(message);
	}

	internal static void Report(Severity severity, string obj, string? name, string attr, string? value, string err)
	{
		string obj2 = obj;
		string name2 = name;
		string attr2 = attr;
		string value2 = value;
		string err2 = err;
		if (Application.Current.Dispatcher.CheckAccess())
		{
			((MainWindow)Application.Current.MainWindow)?.AddMessage(severity, obj2, name2, attr2, value2, err2);
		}
		else
		{
			Application.Current.Dispatcher.Invoke(act);
		}
		void act()
		{
			((MainWindow)Application.Current.MainWindow)?.AddMessage(severity, obj2, name2, attr2, value2, err2);
		}
	}

	private async void Application_Exit(object sender, ExitEventArgs e)
	{
		foreach (Lib lib in FunctionExecutor.Solution.Libs)
		{
			NativeLibrary.Free(lib.Addr);
		}
		StreamWriter writer = FunctionExecutor.Solution.Writer;
		if (writer != null)
		{
			writer.Flush();
			writer.Close();
		}
		IScheduler scheduler = FunctionExecutor.Solution.Scheduler;
		if (scheduler != null)
		{
			await scheduler.Shutdown();
		}
		Environment.Exit(-1);
	}

}

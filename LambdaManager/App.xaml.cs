using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using Quartz;

namespace LambdaManager;

partial class App : Application
{

    private App()
    {
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

        Startup += (s, e) => App_Startup(s, e);
        Startup += (s, e) => Application_Startup(s, e);

        //Startup += new StartupEventHandler(Taskbar_Initialized);
        //Startup += new StartupEventHandler(jumpList_Initialized);


        Exit += new ExitEventHandler(Application_Exit);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        //Log.WriteException(e.ExceptionObject as Exception, "UnhandledException");
    }

    private Mutex mutex;
    /// <summary>
    /// 软件是否多次打开判定
    /// </summary>
    private void App_Startup(object sender, StartupEventArgs e)
    {
        bool ret;
        mutex = new Mutex(true, "ElectronicNeedleTherapySystem", out ret);
        if (!ret)
        {
            //MessageBox.Show("程序重复打开");
            Shutdown();
        }
        else
        {

        }
    }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
		MainWindow mainWindow = new MainWindow();

        StartWindow startWindow = new StartWindow();
        startWindow.Closed += delegate
        {
            mainWindow.Show();
        };
        startWindow.Show();
    }


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



	private  void Application_Exit(object sender, ExitEventArgs e)
	{
		foreach (Lib lib in FunctionExecutor.Solution.Libs)
		{
			NativeLibrary.Free(lib.Addr);
		}
		Common.Exit();
		StreamWriter writer = FunctionExecutor.Solution.Writer;
		if (writer != null)
		{
			writer.Flush();
			writer.Close();
		}
		IScheduler scheduler = FunctionExecutor.Solution.Scheduler;
		if (scheduler != null)
		{
			 scheduler.Shutdown();
		}
		Environment.Exit(-1);
	}

}

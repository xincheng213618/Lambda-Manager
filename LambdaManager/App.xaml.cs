using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using Lambda;
using LambdaManager.Config;
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
        Exit += new ExitEventHandler(Application_Exit);
    }

    public static string GetExpireDate()
    {
        var assembly = System.Reflection.Assembly.LoadFile($"{Directory.GetCurrentDirectory()}/ACE.dll");
        if (assembly == null)
            return String.Empty;
        var type = assembly.GetType("ACE.AES");
        string? s = type.InvokeMember("GetExpireDate", System.Reflection.BindingFlags.InvokeMethod, null, null, null)?.ToString();
        return s;
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
        mutex = new Mutex(true, "ElectronicNeedleTherapySystem", out bool ret);
        if (!ret)
        {
            Shutdown();
        }
        else
        {

        }
    }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        var configUILibrary = ConfigUILibrary.GetInstance();
        configUILibrary.Main = mainWindow;

        StartWindow startWindow = new StartWindow();
        startWindow.Closed += delegate
        {
            mainWindow.Show();
        };
        startWindow.Show();

    }

    /// <summary>
    /// Application Close
    /// </summary>
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

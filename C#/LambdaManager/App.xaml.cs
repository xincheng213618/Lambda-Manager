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
        //Startup += (s, e) => App_Startup(s, e);
        Startup += (s, e) => Application_Startup(s, e);
        Exit += new ExitEventHandler(Application_Exit);
    }

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        //Log.WriteException(e.ExceptionObject as Exception, "UnhandledException");
    }

    private Mutex mutex;

    /// <summary>
    /// �����Ƿ��δ��ж�
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
        StartWindow startWindow = new StartWindow();
        startWindow.Show();

    }

    /// <summary>
    /// Application Close
    /// </summary>
	private  void Application_Exit(object sender, ExitEventArgs e)
	{
		Common.CommonExit();
		Environment.Exit(-1);
	}

}
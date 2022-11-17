using System;
using System.Threading;
using System.Windows;
using LambdaManager.Core;

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
        //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");
        StartWindow startWindow = new StartWindow();
        startWindow.Show();
    }

    /// <summary>
    /// Application Close
    /// </summary>
	private  void Application_Exit(object sender, ExitEventArgs e)
	{
		Common.CommonExit();
		Environment.Exit(0);
	}

}

using ColorVision.Themes;
using ColorVision.UI;
using ColorVision.UI.Languages;
using LambdaManager.Core;
using log4net.Config;
using System;
using System.Text;
using System.Threading;
using System.Windows;

[assembly: XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]
namespace LambdaManager
{
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

        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ConfigHandler.GetInstance();
            LogConfig.Instance.SetLog();
            this.ApplyTheme(ThemeConfig.Instance.Theme);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(LanguageConfig.Instance.UICulture);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance); // 确保 .NET Core 及以上支持 GBK

            StartWindow startWindow = new StartWindow();
            startWindow.Show();
        }

        /// <summary>
        /// Application Close
        /// </summary>
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            Common.CommonExit();
            Environment.Exit(0);
        }

    }

}

using Global.Common.Util;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace Grid
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        
        [STAThread]
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public static void Main(string[] args)
        {

            if (args.Length >= 1)
            {
                if (args[0] == "ini")
                {
                    Reg.WriteValue("Software\\Grid","IsIniWizard",false);

                    Process process = new Process();
                    process.StartInfo.FileName = @"LambdaManager.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.WorkingDirectory = System.Windows.Forms.Application.StartupPath;
                    process.Start();
                    
                }
                else
                {
                    App app;
                    app = new App(args[0]);
                    app.InitializeComponent();
                    app.Run();
                }
            }
            else
            {
                App app;
                app = new App();
                app.InitializeComponent();
                app.Run();
            }

        }
        

        private App()
        {
            MainWindow window = new MainWindow();
            window.Show();
        }
        private App(string SolutionName)
        {
            MainWindow window = new MainWindow(SolutionName);
            window.Show();
        }

    }
}

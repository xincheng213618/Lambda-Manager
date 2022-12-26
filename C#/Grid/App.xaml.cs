using Global.Common.Util;
using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;
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
            Uri uri = new Uri("/Grid;component/default.gprj", UriKind.Relative);
            StreamResourceInfo info = Application.GetResourceStream(uri);
            string DirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default";
            string FullPath = DirectoryPath + "\\default.gprj";
            if (!Directory.Exists(DirectoryPath))
                Directory.CreateDirectory(DirectoryPath);

            if (!File.Exists(FullPath))
            {
                using (var fileStream = File.Create(FullPath))
                {
                    info.Stream.Seek(0, SeekOrigin.Begin);
                    info.Stream.CopyTo(fileStream);
                }
            }

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

using Global.Common.Util;
using Global.RecentFile;
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

namespace Grid {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        [STAThread]
        [DebuggerNonUserCode]
        [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
        public static void Main(string[] args) {
            IniDefault();
            if (args.Length >= 1) {
                if (args[0] == "ini") {
                    Reg.WriteValue("Software\\Grid", "IsIniWizard", false);

                    Process process = new Process();
                    process.StartInfo.FileName = @"LambdaManager.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.WorkingDirectory = System.Windows.Forms.Application.StartupPath;
                    process.Start();

                }
                else {
                    App app;
                    app = new App(args[0]);
                    app.InitializeComponent();
                    app.Run();
                }
            }
            else {
                App app;
                app = new App();
                app.InitializeComponent();
                app.Run();
            }

        }
        public static void IniDefault() {
            string ConfigDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default";
            if (!Directory.Exists(ConfigDirectoryPath)) {
                Directory.CreateDirectory(ConfigDirectoryPath);
            }
            string ConfigGridPath = ConfigDirectoryPath + "\\default.gprj";

            if (File.Exists(ConfigGridPath)) {
                FileInfo fileInfo = new FileInfo(ConfigGridPath);
                if (fileInfo.LastWriteTime < Convert.ToDateTime("2023/03/23"))
                    File.Delete(ConfigGridPath);
            }


            if (File.Exists(ConfigGridPath)) {
                if (File.GetAttributes(ConfigGridPath) != FileAttributes.Normal) {
                    File.SetAttributes(ConfigGridPath, FileAttributes.Normal);  //这里引起过BUG
                }
            }
            else {
                using (var fileStream = File.Create(ConfigGridPath)) {
                    StreamResourceInfo info = Application.GetResourceStream(new Uri("/Grid;component/config.gprj", UriKind.Relative));
                    info.Stream.Seek(0, SeekOrigin.Begin);
                    info.Stream.CopyTo(fileStream);
                }
                File.SetAttributes(ConfigGridPath, FileAttributes.Normal);
            }

            string DefultDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default1";

            if (Directory.Exists(DefultDirectoryPath))
                Directory.Delete(DefultDirectoryPath, true);


            Directory.CreateDirectory(DefultDirectoryPath);
            Directory.CreateDirectory(DefultDirectoryPath + "\\Image");
            Directory.CreateDirectory(DefultDirectoryPath + "\\Video");

            string DefaultGridPath = DefultDirectoryPath + "\\default.gprj";
            using (var fileStream = File.Create(DefaultGridPath)) {
                StreamResourceInfo info = Application.GetResourceStream(new Uri("/Grid;component/default.gprj", UriKind.Relative));
                info.Stream.Seek(0, SeekOrigin.Begin);
                info.Stream.CopyTo(fileStream);
            }

            RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\Grid\\SolutionHistory") };
            recentFileList.Clear();
            if (recentFileList.RecentFiles.Count == 0) {
                recentFileList.InsertFile(DefaultGridPath);
            }
        }



        private App() {
            MainWindow window = new MainWindow();
            window.Show();
        }
        private App(string SolutionName) {
            MainWindow window = new MainWindow(SolutionName);
            window.Show();
        }

    }
}

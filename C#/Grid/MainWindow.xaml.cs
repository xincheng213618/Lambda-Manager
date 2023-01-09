using Global.Common.Util;
using Global.RecentFile;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;

namespace Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public MainWindow(string SolutionName)
        {
            InitializeComponent();
            TextBox2.Text = SolutionName;
            recentFileList.InsertFile(SolutionName);
        }


        RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\NLG\\Grid\\SolutionHistory") };

        readonly string StatusBarRegPath = "Software\\Grid";

        private void Window_Initialized(object sender, EventArgs e)
        {
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\config\\default.gcfg";

            if (recentFileList.RecentFiles.Count ==0)
            {
                Uri uri = new Uri("/Grid;component/default.gprj", UriKind.Relative);
                //获取资源文件
                StreamResourceInfo info = Application.GetResourceStream(uri);

                string DirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default";

                if (!Directory.Exists(DirectoryPath))
                    Directory.CreateDirectory(DirectoryPath);
                else
                {
                    Directory.Delete(DirectoryPath, true);
                    Directory.CreateDirectory(DirectoryPath);
                }

                Directory.CreateDirectory(DirectoryPath + "\\" + "Video");
                Directory.CreateDirectory(DirectoryPath + "\\" + "Image");

                string FullPath = DirectoryPath +"\\default.gprj";
                using (var fileStream = File.Create(FullPath))
                {
                    info.Stream.Seek(0, SeekOrigin.Begin);
                    info.Stream.CopyTo(fileStream);
                }


                string DirectoryPath1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default1";
                if (!Directory.Exists(DirectoryPath1))
                    Directory.CreateDirectory(DirectoryPath1);
                else
                {
                    Directory.Delete(DirectoryPath1, true);
                    Directory.CreateDirectory(DirectoryPath1);
                }

                Directory.CreateDirectory(DirectoryPath + "\\" + "Video");
                Directory.CreateDirectory(DirectoryPath + "\\" + "Image");

                string FullPath1 = DirectoryPath + "\\默认.gprj";
                using (var fileStream = File.Create(FullPath1))
                {
                    info.Stream.Seek(0, SeekOrigin.Begin);
                    info.Stream.CopyTo(fileStream);
                }

                recentFileList.InsertFile(FullPath1);
                TextBox2.Text = recentFileList.RecentFiles[0];
            }
            else
            {
                TextBox2.Text = recentFileList.RecentFiles[0];
            }
            CheckBox1.IsChecked = Reg.ReadValue(StatusBarRegPath, "InitializeStage");
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gcfg";
            labelVersion.Text = string.Format("V3.0 - {0}", File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath).ToString("yyyy/MM/dd"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists($"{System.Windows.Forms.Application.StartupPath}\\LambdaCore.dll"))
            {
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = @"LambdaManager.exe";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.WorkingDirectory = System.Windows.Forms.Application.StartupPath;
                    process.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
            else if (File.Exists($"{System.Windows.Forms.Application.StartupPath}\\LambdaManager.dll"))
            {
                StartWindow startWindow = new StartWindow();
                startWindow.Show();
                startWindow.Closed += delegate
                {
                    this.Close();
                };
            }
            else
            {
                MessageBox.Show("找不到核心软件，启动失败", "Grid", MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(0);
            }
        }



        private void Set_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择配置文件",
                RestoreDirectory = true,
                Filter = "显微镜配置 | *.* ",
            };
            if (dialog.ShowDialog() == true)
            {
                TextBox1.Text = dialog.FileName;
            }
        }

        private void Set_Click1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择工程",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.gprj)|*.gprj",
            };
            if (dialog.ShowDialog() == true)
            {
                TextBox2.Text = dialog.FileName;
                recentFileList.InsertFile(dialog.FileName);
            }
        }

        private void CheckBox1_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox!=null)
                Reg.WriteValue(StatusBarRegPath, "InitializeStage", checkBox.IsChecked??false);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

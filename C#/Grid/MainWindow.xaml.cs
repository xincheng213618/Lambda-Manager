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


        RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\Zircon\\Grid\\SolutionHistory") };

        readonly string StatusBarRegPath = "Software\\Grid";

        private void Window_Initialized(object sender, EventArgs e)
        {
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\config\\default.gcfg";

            string DirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default";
            string DirectoryPath1 = DirectoryPath + "1";

            if (recentFileList.RecentFiles.Count ==0|| !Directory.Exists(DirectoryPath) ||!Directory.Exists(DirectoryPath1))
            {
                if (!Directory.Exists(DirectoryPath))
                    Directory.CreateDirectory(DirectoryPath);

                string FullPath = DirectoryPath +"\\default.gprj";
                StreamResourceInfo info = Application.GetResourceStream(new Uri("/Grid;component/default.gprj", UriKind.Relative));
                using (var fileStream = File.Create(FullPath))
                {
                    info.Stream.Seek(0, SeekOrigin.Begin);
                    info.Stream.CopyTo(fileStream);
                }

                if (Directory.Exists(DirectoryPath1))
                    Directory.Delete(DirectoryPath1, true);

                Directory.CreateDirectory(DirectoryPath1);
                Directory.CreateDirectory(DirectoryPath1 + "\\" + "Video");
                Directory.CreateDirectory(DirectoryPath1 + "\\" + "Image");

                StreamResourceInfo info1 = Application.GetResourceStream(new Uri("/Grid;component/default1.gprj", UriKind.Relative));
                string FullPath1 = DirectoryPath1 + "\\默认.gprj";
                using (FileStream fileStream = File.Create(FullPath1))
                {
                    info1.Stream.Seek(0, SeekOrigin.Begin);
                    info1.Stream.CopyTo(fileStream);
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
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            startWindow.Closed += delegate
            {
                this.Close();
            };
            return;
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

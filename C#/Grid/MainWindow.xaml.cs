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


        RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\Grid\\SolutionHistory") };

        readonly string StatusBarRegPath = "Software\\Grid";

        private void Window_Initialized(object sender, EventArgs e)
        {
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\config\\default.gcfg";
            TextBox2.Text = recentFileList.RecentFiles[0];
            CheckBox1.IsChecked = Reg.ReadValue(StatusBarRegPath, "InitializeStage");
            TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid\\Default\\default.gcfg";
            labelVersion.Text = string.Format("V3.0 - {0}", File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath).ToString("yyyy/MM/dd"));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window windows1 = new Window() { Topmost = true };
            windows1.Show();
            Window windows = new Window() { Topmost =true};
            windows.ShowDialog();

            //StartWindow startWindow = new StartWindow();
            //startWindow.Show();
            //startWindow.Closed += delegate
            //{
            //    this.Close();
            //};
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
            if (sender is CheckBox checkBox)
                Reg.WriteValue(StatusBarRegPath, "InitializeStage", checkBox.IsChecked ?? false);
        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }


        private void TextBlock_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
            CheckBox1.IsChecked = !CheckBox1.IsChecked;
            Reg.WriteValue(StatusBarRegPath, "InitializeStage", CheckBox1.IsChecked ?? false);
        }
    }
}

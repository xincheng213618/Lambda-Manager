using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Grid
{
    /// <summary>
    /// StartWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(async () => await DetectionhardwareAsync()));
        }
        private async Task DetectionhardwareAsync()
        {
            await Task.Delay(1);

            //StartLabel.Content = "初始化性能计数器";
            _ = Dispatcher.BeginInvoke(new Action(async () => await InitializedOver()));
        }

        private async Task InitializedOver()
        {
            StartLabel.Content = "检测硬件连接";
            await Task.Delay(500);
            StartLabel.Content = "初始化配置信息";  
            await Task.Delay(300);
            StartLabel.Content = "初始化控件";
            await Task.Delay(300);
            StartLabel.Content = "正在打开主窗口";
            Process process = new Process();
            process.StartInfo.FileName = @"LambdaManager.exe";
            process.Start();
            await Task.Delay(500);
            Close();
        }
    }
}

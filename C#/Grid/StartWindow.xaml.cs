using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            //WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
            Left = SystemParameters.WorkArea.Right - this.Width;
            Top = SystemParameters.WorkArea.Bottom - this.Height;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            labelVersion.Content = string.Format("V3.0 - {0}", File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath).ToString("yyyy/MM/dd"));
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
            TexoBoxMsg.Text += Environment.NewLine + "检测硬件连接";
            await Task.Delay(500);
            TexoBoxMsg.Text += Environment.NewLine + "初始化配置信息";  
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "初始化主控";
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "初始化相机";
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "初始化位移台";
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "正在打开主窗口";


            App.Current.MainWindow.Close();
            await Task.Delay(500);
            Close();
        }

        private void TexoBoxMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TexoBoxMsg.SelectionStart = TexoBoxMsg.;
            //将控件内容滚动到当前插入符号位置
            TexoBoxMsg.ScrollToEnd();
        }
    }
}

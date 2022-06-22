using LambdaManager.Features;
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

namespace LambdaManager
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
            //Left = SystemParameters.WorkArea.Right - this.Width;
            //Top = SystemParameters.WorkArea.Bottom - this.Height;
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            _ = Dispatcher.BeginInvoke(new Action(async () => await InitializedOver()));
        }

        private async void Update()
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                try
                {
                    UIEvents.Initialze();
                    bool num = new ConfigLibrary().Load("application.xml");
                    if (num)
                    {
                    }
                    else
                    {
                        MessageBox.Show("StartFatalError ");
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                finally
                {
                }
            });

        }



        private async Task InitializedOver()
        {
            TexoBoxMsg.Text += Environment.NewLine + "检测硬件连接";
            await Task.Delay(300);
            Task.Run(Update);
            TexoBoxMsg.Text += Environment.NewLine + "初始化配置信息";  
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "初始化主控";
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "初始化相机";
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "初始化位移台";
            await Task.Delay(300);
            TexoBoxMsg.Text += Environment.NewLine + "正在打开主窗口";
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

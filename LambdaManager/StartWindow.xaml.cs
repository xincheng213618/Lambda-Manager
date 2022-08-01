﻿using System;

using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LambdaManager
{
    /// <summary>
    /// StartWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StartWindow : Window
    {
        public bool IsRunning { get; set; } = false;
        public StartWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        ConfigLibrary ConfigLibrary;
        private void Window_Initialized(object sender, EventArgs e)
        {

            ConfigLibrary = new ConfigLibrary();
            Thread thread = new Thread(Load);
            thread.Start();
            _ = Dispatcher.BeginInvoke(new Action(async () => await InitializedOver()));
        }
        public void Load()
        {
            bool num = ConfigLibrary.Load("application.xml");
            ConfigLibrary.InitializeLibrary();
            Application.Current.Dispatcher.Invoke(delegate
            {
                if (IsRunning)
                {
                    Close();
                }
                else
                {
                    IsRunning = true;
                }
            });
        }





        private async Task InitializedOver()
        {
            TexoBoxMsg.Text += Environment.NewLine + "检测硬件连接";
            await Task.Delay(100);
            TexoBoxMsg.Text += Environment.NewLine + "初始化配置信息";  
            await Task.Delay(100);
            TexoBoxMsg.Text += Environment.NewLine + "初始化主控";
            await Task.Delay(100);
            TexoBoxMsg.Text += Environment.NewLine + "初始化设定函数";
            await Task.Delay(100);
            TexoBoxMsg.Text += Environment.NewLine + "正在打开主窗口";
            await Task.Delay(100);
            if (IsRunning)
            {
                Close();
            }
            else
            {
                IsRunning = true;
            }
        }

        private void TexoBoxMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TexoBoxMsg.SelectionStart = TexoBoxMsg.;
            //将控件内容滚动到当前插入符号位置
            TexoBoxMsg.ScrollToEnd();
        }
    }
}

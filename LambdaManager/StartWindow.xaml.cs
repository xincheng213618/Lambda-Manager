﻿using LambdaManager.Config;
using System;

using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace LambdaManager
{
    /// <summary>
    /// StartWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StartWindow : Window
    {
        public bool IsRunning { get; set; } = false;
        MainWindow mainWindow;
        public StartWindow( MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        private readonly string dllAce = "ACE.dll";
        ConfigLibrary ConfigLibrary;
        private void Window_Initialized(object sender, EventArgs e)
        {



            ConfigLibrary = new ConfigLibrary();
            ConfigLibrary.lambdaUI = new ConfigUILibrary(mainWindow);
            Thread thread = new Thread(Load);
            thread.Start();
            _ = Dispatcher.BeginInvoke(new Action(async () => await InitializedOver()));


        }
        public XElement loadxml()
        {
            XElement root = null; ;
            string path = "application.xml";
            if (File.Exists(path))
            {
                root = XDocument.Load(path).Root;
            }
            else if (File.Exists(dllAce))
            {
                var assembly = System.Reflection.Assembly.LoadFile($"{Directory.GetCurrentDirectory()}/{dllAce}");
                if (assembly == null)
                    return null;
                var type = assembly.GetType("ACE.AES");
                if (type == null)
                    return null;
                string? s = type.InvokeMember("GetSysConfig", System.Reflection.BindingFlags.InvokeMethod, null, null, null)?.ToString();
                if (s == null)
                    return null;
                if (Regex.IsMatch(s, "\\s*<\\?\\s*xml"))
                    s = s.Substring(s.IndexOf(Environment.NewLine) + 2);
                root = XDocument.Parse(s).Root;
            }
            return root;
        }

        public void Load()
        {
            bool num = ConfigLibrary.Load(loadxml());
            if (num == true)
            {
                ConfigLibrary.InitializeLibrary();
            }
            else
            {
                MessageBox.Show("主控初始化失败");
            }
            Application.Current.Dispatcher.Invoke(delegate
            {
                if (IsRunning)
                {
                    Closedd();
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
            TexoBoxMsg.Text += Environment.NewLine + "初始化其他配置";
            await Task.Delay(100);
            if (IsRunning)
            {
                Closedd();
            }
            else
            {
                IsRunning = true;
            }
        }

        public async Task Closedd()
        {
            TexoBoxMsg.Text += Environment.NewLine + "正在打开主窗口";
            await Task.Delay(100);
            this.Close();
        }

        private void TexoBoxMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            //TexoBoxMsg.SelectionStart = TexoBoxMsg.;
            //将控件内容滚动到当前插入符号位置
            TexoBoxMsg.ScrollToEnd();
        }
    }
}

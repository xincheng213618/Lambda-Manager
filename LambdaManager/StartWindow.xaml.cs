using LambdaManager.Config;
using System;

using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            if (DateTime.Now > Convert.ToDateTime(GetExpireDate() ?? "2025/1/1"))
            {
                MessageBox.Show("过期了");
                this.Close();
            }
            else
            {
                labelVersion.Content = string.Format("V8.0 - {0}", File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath).ToString("yyyy/MM/dd"));
                ConfigLibrary = new ConfigLibrary();
                ConfigLibrary.lambdaUI = new ConfigUILibrary(mainWindow);
                Thread thread = new Thread(Load);
                thread.Start();
                _ = Dispatcher.BeginInvoke(new Action(async () => await InitializedOver()));
            }


        }

        public static string GetExpireDate()
        {
            var assembly = System.Reflection.Assembly.LoadFile($"{Directory.GetCurrentDirectory()}/ACE.dll");
            if (assembly == null)
                return null;
            var type = assembly.GetType("ACE.AES");
            string? s = type.InvokeMember("GetExpireDate", System.Reflection.BindingFlags.InvokeMethod, null, null, null)?.ToString();
            return s;
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
                ConfigLibrary.LoadUIComponents();
            }
            else
            {
                MessageBox.Show("主控初始化失败");
                Environment.Exit(0);
            }
            Application.Current.Dispatcher.Invoke(delegate
            {
                if (IsRunning)
                {
                    _ = Dispatcher.BeginInvoke(new Action(async () => await StartMainWindow()));
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
               await  StartMainWindow();
            }
            else
            {
                IsRunning = true;
            }
        }

        public async Task StartMainWindow()
        {
            TexoBoxMsg.Text += Environment.NewLine + "正在打开主窗口";
            await Task.Delay(100);
            mainWindow.Show();
            this.Close();
        }

        private void TexoBoxMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            TexoBoxMsg.ScrollToEnd();
        }
    }
}

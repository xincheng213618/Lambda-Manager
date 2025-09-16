using Lambda;
using LambdaManager.Config;
using LambdaManager.Core;
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
        //2022.8.20 主窗口显示需要后置，前置在沈茜的电脑上会出现DLL 第二次无法加载的情况，原因未知
        public bool IsRunning { get; set; } = false;

        public ConfigUILibrary ConfigUILibrary;
        public ConfigLibrary ConfigLibrary;

        public MainWindow mainWindow;
        public StartWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        private readonly string dllAce = "ACE.dll";
        private void Window_Initialized(object sender, EventArgs e)
        {
            ConfigLibrary = new ConfigLibrary();
            Log.LogWrite += AddMessage;

            labelVersion.Content = string.Format("V3.0 - {0}", File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath).ToString("yyyy/MM/dd"));
            Thread thread = new Thread(Load);
            thread.Start();
            _ = Dispatcher.BeginInvoke(new Action(async () => await InitializedOver()));
        }

        public void AddMessage(Message message)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                TexoBoxMsg.Text += Environment.NewLine + message.Text;
            });

        }

        public XElement loadxml()
        {
            try
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
            catch (Exception ex)
            {
                Log.LogWrite(new Message() { Severity =Severity.INFO,Text = ex.Message});
                return null;
            }

        }
        /// 初始化用线程打开，这样能缩短展示页面的时间，初始化C++事件需要先初始化主窗口，ui控件最后初始化，加载c++ dll 需要在主窗口初始化之前(沈茜)。
        public void Load()
        {
            bool num = ConfigLibrary.Load(loadxml());
            Application.Current.Dispatcher.Invoke(delegate
            {
                mainWindow = new MainWindow();
                Application.Current.MainWindow = mainWindow;
                ConfigUILibrary = new ConfigUILibrary(mainWindow);
                ConfigLibrary.lambdaUI = ConfigUILibrary;
            });

            if (num == true)
            {
                Log.LogWrite -= AddMessage;

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
            ConfigLibrary.LoadUIComponents();
            mainWindow.Show();
            await Task.Delay(100);
            this.Close();
        }

        private void TexoBoxMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            TexoBoxMsg.ScrollToEnd();
        }
    }
}

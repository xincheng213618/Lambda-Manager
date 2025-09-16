using Lambda;
using LambdaManager.Config;
using LambdaManager.Core;
using System;

using System.IO;
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

        public ConfigUILibrary ConfigUILibrary;
        public ConfigLibrary ConfigLibrary;

        public StartWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            ConfigLibrary = new ConfigLibrary();
            Log.LogWrite += AddMessage;

            labelVersion.Content = string.Format("V3.0 - {0}", File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath).ToString("yyyy/MM/dd"));
            Application.Current.Dispatcher.BeginInvoke(() =>
            {
                Load();
            });
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
                root = XDocument.Load(path).Root;
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

            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            ConfigUILibrary = new ConfigUILibrary(mainWindow);
            ConfigLibrary.lambdaUI = ConfigUILibrary;
            Log.LogWrite -= AddMessage;

            ConfigLibrary.InitializeLibrary();
            TexoBoxMsg.Text += Environment.NewLine + "正在打开主窗口";
            ConfigLibrary.LoadUIComponents();
            mainWindow.Show();
            this.Close();
        }


        private void TexoBoxMsg_TextChanged(object sender, TextChangedEventArgs e)
        {
            TexoBoxMsg.ScrollToEnd();
        }
    }
}

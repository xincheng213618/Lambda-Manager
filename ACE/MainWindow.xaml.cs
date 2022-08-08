using Global;
using Global.Mode;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThemeManager.Controls;

namespace ACE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : BaseWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        RegisterInfo registerInfo;
        private void Window_Initialized(object sender, System.EventArgs e)
        {
            registerInfo = WindowData.GetInstance().RegisterInfo;
            this.DataContext = registerInfo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AES.SetRegisterCode(registerInfo.GetSha512());
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            byte[] trest= AES_EnorDecrypt.AESEncrypt(File.ReadAllBytes("application.xml"), registerInfo.GetSha512(), "111");
            using (FileStream fs = new FileStream("application.sys", FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.Write(trest, 0, trest.Length);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            byte[] trest1 = AES_EnorDecrypt.AESDecrypt(File.ReadAllBytes("application.sys"), AES.GetRegisterCode(), "111");

            if (trest1 ==null)
            {
                MessageBox.Show("软件注册信息损坏，请联系厂家修复。");
            }
            else
            {
                MessageBox.Show(Encoding.UTF8.GetString(trest1));
            }
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            AboutMsg aboutMsg = new AboutMsg();
            aboutMsg.Show();
        }
    }
}

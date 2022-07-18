using ACE;
using Global;
using Global.Mode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Register
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

        int mode = 1;
        RegisterInfo registerInfo;
        AESHelper AESHelper;
        private void Window_Initialized(object sender, System.EventArgs e)
        {
            registerInfo = WindowData.GetInstance().RegisterInfo;
            this.DataContext = registerInfo;

            AESHelper = new AESHelper();
            switch (mode)
            {
                case 0:
                    AESHelper.registerCode = new RegRegisterCode();
                    break;
                case 1:
                    AESHelper.registerCode = new FileRegisterCode();
                    break;
                default:
                    AESHelper.registerCode = new RegRegisterCode();
                    break;                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AESHelper.registerCode.SetRegisterCode(registerInfo.GetSha512());
            AESHelper.Encrypt();
            MessageBox.Show(Encoding.UTF8.GetString(AESHelper.Decrypt())); 
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);

        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        private void BaseWindow_MouseMove(object sender, MouseEventArgs e)
        {


            Dictionary<int, int> map = new Dictionary<int, int>();  

            Point p = PointToScreen(e.GetPosition(this));
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int c = (int)GetPixel(dc, (int)p.X, (int)p.Y);
            int r = (c & 0xFF);//转换R 
            int g = (c & 0xFF00) / 256;//转换G 
            int b = (c & 0xFF0000) / 65536;//转换B 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _timer.Interval = TimeSpan.FromSeconds(0.2); //wait for the other click for 200ms
            _timer.Tick += Timer_Tick;
        }

        int num = 0;

        private readonly System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer();
        private void Button_Click(object sender, RoutedEventArgs e)
        {

       }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            TextBox1.Text = num.ToString();
            num = num + 1;
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                _timer.Stop();
                TextBox2.Text = num.ToString();
                num = num + 1;

            }
            else
            {
                _timer.Start();
            }

        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                _timer.Stop();
                TextBox2.Text = num.ToString();
                num = num + 1;

            }
            else
            {
                _timer.Start();
            }
        }
    }

    public class Box
    {
        public int length;
        public string name;
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            return box;
        }
    }
}

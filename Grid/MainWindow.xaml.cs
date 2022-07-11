using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            this.Close();
        }



        private void Set_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择配置文件",
                RestoreDirectory = true,
                Filter = "显微镜配置 | *.* ",
            };
            if (dialog.ShowDialog() == true)
            {
                TextBox1.Text = dialog.FileName;
            }
        }

        private void Set_Click1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择工文件",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.lmp)|*.lmp",
            };
            if (dialog.ShowDialog() == true)
            {
                TextBox2.Text = dialog.FileName;
            }
        }
    }
}

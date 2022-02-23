using Microsoft.Win32;
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void Set_Click(object sender, RoutedEventArgs e)
        {
            string FileName;
            if (FileHelper.OpenFileDialog(out FileName, "显微镜配置|*.*"))
            {
                TextBox1.Text = FileName;
            }
            
        }

        private void Set_Click1(object sender, RoutedEventArgs e)
        {
            string FileName;
            if (FileHelper.OpenFileDialog(out FileName, "显微镜工程(*.lmp)|*.lmp"))
            {
                TextBox2.Text = FileName;
            }
        }
    }
    public static class FileHelper
    {
        public static bool OpenFileDialog(out string FileName,string Filter)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = Filter,
            };
            bool? result = dialog.ShowDialog();

            FileName = result == true ? dialog.FileName : "";
            return (bool)result;
        }
    }
}

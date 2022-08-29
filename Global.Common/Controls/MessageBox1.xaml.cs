using System.Windows;
using ThemeManager.Controls;

namespace Global.Common.Controls
{
    /// <summary>
    /// MessageBox1.xaml 的交互逻辑
    /// </summary>


    public partial class MessageBox1 : BaseWindow
    {

        public MessageBoxResult MessageBoxResult = MessageBoxResult.OK;

        public MessageBox1(string messageBoxText)
        {
            InitializeComponent();
            messageText.Text = messageBoxText;
        }


        private void No_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MessageBoxResult = MessageBoxResult.No;
        }

        private void Yes_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MessageBoxResult = MessageBoxResult.Yes;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult = MessageBoxResult.Cancel;
        }
    }
}

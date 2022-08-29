using System.Windows;
using System.Windows.Controls;
using ThemeManager.Controls;

namespace Global.Common.Controls
{
    /// <summary>
    /// MessageBox1.xaml 的交互逻辑
    /// </summary>


    public partial class MessageBox1 : BaseWindow
    {

        public MessageBoxResult MessageBoxResult = MessageBoxResult.No;
        private void Initialize(string messageBoxText, string caption = "提示", MessageBoxButton button = MessageBoxButton.OK)
        {
            InitializeComponent();
            this.messageBoxText.Text = messageBoxText;
            this.caption.Text = caption;
            switch (button)
            {
                case MessageBoxButton.OK:
                    ButtonOK.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.OKCancel:
                    ButtonOK.Visibility = Visibility.Visible;
                    ButtonCancel.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNoCancel:
                    ButtonYes.Visibility = Visibility.Visible;
                    ButtonNo.Visibility = Visibility.Visible;
                    ButtonCancel.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNo:
                    ButtonYes.Visibility = Visibility.Visible;
                    ButtonNo.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }


        public MessageBox1(string messageBoxText)
        {
            Initialize(messageBoxText);

        }
        public MessageBox1(string messageBoxText,string caption)
        {
            Initialize(messageBoxText, caption);
        }
        public MessageBox1(string messageBoxText, string caption, MessageBoxButton button)
        {
            Initialize(messageBoxText, caption, button);
        }


        private void Yes_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult = MessageBoxResult.Yes;
            Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult = MessageBoxResult.Cancel;
            Close();
        }

        private void ButtonNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult = MessageBoxResult.No;
            Close();
        }

        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            Close();
            MessageBoxResult = MessageBoxResult.Yes;
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult = MessageBoxResult.OK;
            Close();
        }
    }
}

using Global.Common.Extensions;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows;
using ThemeManager.Controls;

namespace Global.Common.Controls
{
    /// <summary>
    /// MessageBox1.xaml 的交互逻辑
    /// </summary>


    public partial class MessageBox1 : BaseWindow
    {

        public MessageBoxResult MessageBoxResult;
        private void Initialize(string messageBoxText, string caption = "提示", MessageBoxButton button = MessageBoxButton.OK , MessageBoxImage icon = MessageBoxImage.None ,MessageBoxResult defaultResult = MessageBoxResult.None)
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
            //MessageBoxImage 中存在重复项和重复样式，所以这几项就可以了
            switch (icon)
            {
                case MessageBoxImage.None:
                    Imageicon.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxImage.Error:
                    Imageicon.Source = SystemIcons.Error.ToImageSource();
                    break;
                case MessageBoxImage.Question:
                    Imageicon.Source = SystemIcons.Question.ToImageSource();
                    break;
                case MessageBoxImage.Warning:
                    Imageicon.Source = SystemIcons.Warning.ToImageSource();
                    break;
                case MessageBoxImage.Information:
                    Imageicon.Source = SystemIcons.Information.ToImageSource();
                    break;
                default:
                    break;
            }
            MessageBoxResult = defaultResult;
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

        public MessageBox1(string messageBoxText, string caption, MessageBoxButton button,MessageBoxImage icon)
        {
            Initialize(messageBoxText, caption, button, icon);
        }
        public MessageBox1(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon,MessageBoxResult defaultResult)
        {
            Initialize(messageBoxText, caption, button, icon, defaultResult);
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

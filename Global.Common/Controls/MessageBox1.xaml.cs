using Microsoft.VisualBasic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThemeManager.Controls;
using static System.Net.Mime.MediaTypeNames;

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
            switch (icon)
            {
                case MessageBoxImage.None:
                    Imageicon.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxImage.Error:
                    Imageicon.Source = ToImageSource(SystemIcons.Error);
                    break;
                case MessageBoxImage.Question:
                    Imageicon.Source = ToImageSource(SystemIcons.Question);
                    break;
                case MessageBoxImage.Warning:
                    Imageicon.Source = ToImageSource(SystemIcons.Warning);
                    break;
                case MessageBoxImage.Information:
                    Imageicon.Source = ToImageSource(SystemIcons.Information);
                    break;
                default:
                    break;
            }
            MessageBoxResult = defaultResult;
        }
        public static ImageSource ToImageSource(Icon icon)
        {
            ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
                icon.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return imageSource;
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

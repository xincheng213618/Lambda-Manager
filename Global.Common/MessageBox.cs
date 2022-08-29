using System.Windows;
using System.Windows.Controls;

namespace Global.Common
{

    //
    // 摘要:
    //     Displays a message box.
    public sealed class MessageBox1
    {
        public static MessageBoxResult Show(string messageBoxText)
        {
            Controls.MessageBox1 messageBox1 = new Controls.MessageBox1(messageBoxText);
            messageBox1.ShowDialog();
            return messageBox1.MessageBoxResult;
            //return MessageBox.Show(messageBoxText);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            return MessageBox.Show(messageBoxText, caption);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            return MessageBox.Show(messageBoxText, caption, button);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText)
        {
            return MessageBox.Show(owner, messageBoxText);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            return MessageBox.Show(owner, messageBoxText, caption);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult);
        }
    }
}

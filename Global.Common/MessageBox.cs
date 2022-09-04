using System.Windows;
using System.Windows.Controls;

namespace Global.Common
{

    //
    // 摘要:
    //     Displays a message box.
    public sealed class MessageBox1
    {
        //icon 的部分建议移除，目前采用了已经淘汰的system.drawing.Common,如果放在其他地方，需要重置图像
        //参考了一些代码，并不是显示上的最优解，这里可以做一些调整

        private static MessageBoxResult Initialize(string messageBoxText, string caption ="提示", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None)
        {
            Controls.MessageBox1 messageBox1 = new Controls.MessageBox1(messageBoxText, caption, button, icon, defaultResult);
            messageBox1.ShowDialog();
            return messageBox1.MessageBoxResult;
        }

        public static MessageBoxResult Show(string messageBoxText)
        {
            return Initialize(messageBoxText);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption)
        {
            return Initialize(messageBoxText, caption);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button)
        {
            return Initialize(messageBoxText, caption, button);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return Initialize(messageBoxText, caption, button, icon);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return Initialize(messageBoxText, caption, button, icon, defaultResult);
        }

        public static MessageBoxResult Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
        }

        private static MessageBoxResult Initialize(Window owner, string messageBoxText, string caption = "提示", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.None, MessageBoxResult defaultResult = MessageBoxResult.None)
        {
            Controls.MessageBox1 messageBox1 = new Controls.MessageBox1(messageBoxText, caption, button, icon, defaultResult);
            messageBox1.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            messageBox1.Owner = owner;
            messageBox1.ShowDialog();
            return messageBox1.MessageBoxResult;
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText)
        {
            return Initialize(owner,messageBoxText);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption)
        {
            return Initialize(owner, messageBoxText, caption);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button)
        {
            return Initialize(owner, messageBoxText, caption, button);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
        {
            return Initialize(owner, messageBoxText, caption, button, icon);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult)
        {
            return Initialize(owner, messageBoxText, caption, button, icon, defaultResult);
        }

        public static MessageBoxResult Show(Window owner, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon, MessageBoxResult defaultResult, MessageBoxOptions options)
        {
            return MessageBox.Show(owner, messageBoxText, caption, button, icon, defaultResult);
        }
    }
}

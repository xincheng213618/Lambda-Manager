using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Global.UserControls
{
    /// <summary>
    /// MessageBox.xaml 的交互逻辑
    /// </summary>
    public class MessageResult
    {
        /// <summary>
        /// 结果，Yes为true，No为false
        /// </summary>
        public bool IsYes { get; set; }
    }
    public class MessageBoxEventArgs : EventArgs
    {
        /// <summary>
        /// 结果，Yes为true，No为false
        /// </summary>
        public MessageResult Result { get; set; }
    }
    /// <summary>
    /// MessageBox.xaml 的交互逻辑
    /// </summary>
    public partial class MessageBox : Window
    {
        public event EventHandler<MessageBoxEventArgs> Result;

        public string Context
        {
            get { return TB_Context.Text; }
            set { TB_Context.Text = value; }
        }
        bool _isLegal = false;
        public MessageBox()
        {
            InitializeComponent();
        }
        public static void Show(string context, EventHandler<MessageBoxEventArgs> result)
        {
            var mb = new MessageBox();
            mb.Context = context;
            mb.Result += result;
            mb.Show();
        }
        public static MessageResult ShowDialog(string context)
        {
            var mb = new MessageBox();
            mb.Context = context;
            MessageResult r = null;
            mb.Result += (s, e) =>
            {
                r = e.Result;
            };
            mb.ShowDialog();
            return r;
        }
        private void No_Button_Click(object sender, RoutedEventArgs e)
        {
            _isLegal = true;
            Close();
            Result?.Invoke(this, new MessageBoxEventArgs() { Result = new MessageResult() { IsYes = false } });
        }
        private void Yes_Button_Click(object sender, RoutedEventArgs e)
        {
            _isLegal = true;
            Close();
            Result?.Invoke(this, new MessageBoxEventArgs() { Result = new MessageResult() { IsYes = true } });
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !_isLegal;
        }
    }

}

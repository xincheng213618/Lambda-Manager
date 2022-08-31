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
using ThemeManager.Controls;

namespace Global.UserControls
{
    /// <summary>
    /// MessageBox1.xaml 的交互逻辑
    /// </summary>


    public partial class MessageBox1 : BaseWindow
    {
        public event EventHandler<MessageBoxEventArgs> Result;

        public string Context
        {
            get { return messageText.Text; }
            set { messageText.Text = value; }
        }



        public MessageBox1()
        {
            InitializeComponent();
        }


        public static void Show(string context, EventHandler<MessageBoxEventArgs> result)
        {
            var mb = new MessageBox1();
            mb.Context = context;
            mb.Result += result;
            mb.Show();
        }
        public static MessageResult ShowDialog(string context)
        {
            var mb = new MessageBox1();
            mb.Context = context;
            MessageResult r = new MessageResult() { IsYes = false};
            mb.Result += (s, e) =>
            {
                r = e.Result;
            };
            mb.ShowDialog();
            return r;
        }
        private void No_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Result?.Invoke(this, new MessageBoxEventArgs() { Result = new MessageResult() { IsYes = false } });
          
        }
        private void Yes_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Result?.Invoke(this, new MessageBoxEventArgs() { Result = new MessageResult() { IsYes = true } });
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
    }
}

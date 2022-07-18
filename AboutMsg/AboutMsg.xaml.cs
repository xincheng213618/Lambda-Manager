using Global;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ThemeManager.Controls;

namespace AboutMsg
{
    /// <summary>
    /// AboutMsg.xaml 的交互逻辑
    /// </summary>
    public partial class AboutMsgWindow : BaseWindow
    {
        public AboutMsgWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            this.DataContext = WindowData.GetInstance().RegisterInfo;
        }
    }
}

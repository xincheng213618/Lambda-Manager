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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wizard
{
    /// <summary>
    /// Page.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        WizardWindow Window;
        public Page1(WizardWindow window)
        {
            InitializeComponent();
            Window = window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page2(Window);
            Pages();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Window.Close();
        }

        private void Pages()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));
        }

        private void Page_Initialized(object sender, EventArgs e)
        {

        }
    }
}

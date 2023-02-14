using Global.Common;
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

    public class Page2ViewMode : Global.Common.ViewModelBase
    {
        public bool IsSelect { get => _IsSelect; set { _IsSelect = value; NotifyPropertyChanged(); } }
        private bool _IsSelect { get; set; }
    }



        /// <summary>
        /// Page2.xaml 的交互逻辑
        /// </summary>
     public partial class Page2 : Page
    {
        Page2ViewMode page2ViewMode = new Page2ViewMode();

        WizardWindow Window;
        public Page2(WizardWindow window)
        {
            InitializeComponent();
            Window = window;
        }
        private void Pages()
        {
            Dispatcher.BeginInvoke(new Action(() => Window.frame.Navigate(Content)));
        }

        private void Page_Initialized(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Content = new Page3(Window);
            Pages();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Content = new Page3(Window);
            Pages();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                button.BorderThickness = new Thickness(2, 2, 2, 2);
                page2ViewMode.IsSelect = true;
            }
        }
    }
}

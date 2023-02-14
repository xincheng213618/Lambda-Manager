using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Global.UserControls
{
    /// <summary>
    /// SplitButtonSelect.xaml 的交互逻辑
    /// </summary>
    public partial class SplitButtonSelect : UserControl
    {
        public SplitButtonSelect()
        {
            InitializeComponent();
            SelectAllBUtton = selectAllButton;
            SelectToggle = singleSelToggle;
        }

        public Button SelectAllBUtton;
        public ToggleButton SelectToggle;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            popUp.IsOpen = true;
        }

        private void selectAllButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void selectAllButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void selectAllButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
           
        }

        private void selectAllButton_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            popUp.IsOpen = false;
        }
    }
}

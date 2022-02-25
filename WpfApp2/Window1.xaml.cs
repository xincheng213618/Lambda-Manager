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

namespace WpfApp2
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void xxxxx1_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Grid1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Grid grid = sender as Grid;
            x22222.Width = grid.ActualWidth;

        }

        private void leftView_Initialized(object sender, EventArgs e)
        {

        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Grid grid =sender as Grid;
            xxx1.Height = 300 * (grid.ActualHeight / grid.ActualWidth);
        }
    }
}

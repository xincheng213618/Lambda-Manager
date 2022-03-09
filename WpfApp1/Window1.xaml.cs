using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1
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
            if (sender is Grid grid)
                x22222.Width = grid.ActualWidth;

        }

        private void Window_Initialized(object sender, EventArgs e)
        {
                      //this.leftView.Children.Clear();
            List<UICofig> list = new List<UICofig>();
            list.Add(new UICofig() { path = "ConfigDPCMode.dll", name = "DPCMode" });
            list.Add(new UICofig() { path = "ConfigDeck.dll", name = "BaseDeck" });
            list.Add(new UICofig() { path = "ConfigSpot.dll", name = "SampleSpot" });
            list.Add(new UICofig() { path = "ConfigDOFMode.dll", name = "DOFMode" });
            list.Add(new UICofig() { path = "ConfigCollectInterval.dll", name = "CollectInterval" });

            foreach (var item in list)
            {
                Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + item.path);
                if (assembly.CreateInstance($"{item.path.Replace(".dll", "")}.{item.name}") is Control control)
                    leftView.Children.Add(control);
            }
        }

        private void x111_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Viewbox viewbox = (Viewbox)sender;
            ssss1.Height = 420*viewbox.GetScaleFactor();

        }

        private void Grid2_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (sender is Grid grid)
                ssss1.Height = 300 * (grid.ActualHeight / grid.ActualWidth);
        }





    }
    public static class ViewBoxExtensions
    {
        public static double GetScaleFactor(this Viewbox viewbox)
        {
            if (viewbox.Child is FrameworkElement child)
                return viewbox.ActualWidth / child.ActualWidth;
            else
                return double.NaN;
        }
    }
}

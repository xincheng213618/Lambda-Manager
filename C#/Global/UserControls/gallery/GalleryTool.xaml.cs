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
using WpfApp5;

namespace Global.UserControls.gallery
{
    /// <summary>
    /// GallyTool.xaml 的交互逻辑
    /// </summary>
    public partial class GalleryTool : UserControl
    {
        public GalleryTool()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            foreach(Product item in WpfApp5.gallery.products)
            {
                item.SizeLevel = (int)sizeSlider.Value;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GalleryView
{
    /// <summary>
    /// Gallery.xaml 的交互逻辑
    /// </summary>
    public partial class Gallery : UserControl
    {
        public Gallery()
        {
            InitializeComponent();

            product11.Add(product1);
            product11.Add(product2);
            product11.Add(product3);
            product11.Add(product4);
            product11.Add(product5);
            product11.Add(product6);
            product11.Add(product7);
            product11.Add(product8);

            list.ItemsSource = product11;

        }
      public static  ObservableCollection<Product> product11 = new ObservableCollection<Product>();

        Product product1 = new Product("1", "1.png");
        Product product2 = new Product("2", "2.png");
        Product product3 = new Product("3", "3.png");
        Product product4 = new Product("4", "4.png");
        Product product5 = new Product("5", "5.png");
        Product product6 = new Product("6", "6.png");
        Product product7 = new Product("7", "7.png");
        Product product8 = new Product("8", "8.png");

    }
}

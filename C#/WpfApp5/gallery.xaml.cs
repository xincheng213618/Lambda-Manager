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

namespace WpfApp5
{
    /// <summary>
    /// gallery.xaml 的交互逻辑
    /// </summary>
    public partial class gallery : UserControl
    {
        public gallery()
        {
            InitializeComponent();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            products.Add(product6);
            products.Add(product7);
            products.Add(product8);

            Lis.ItemsSource = products;
        }

      public static  ObservableCollection<Product> products = new ObservableCollection<Product>();

        Product product1 = new Product("1", "1.png");
        Product product2 = new Product("2", "2.png");
        Product product3 = new Product("3", "3.png");
        Product product4 = new Product("4", "4.png");
        Product product5 = new Product("5", "5.png");
        Product product6 = new Product("6", "6.png");
        Product product7 = new Product("7", "7.png");
        Product product8 = new Product("8", "8.png");

        private void StackPanel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           

        }

        private void StackPanel_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
           // StackPanel stackPanel = (StackPanel)sender;
           
            
            
        }

        private void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            Product product = (Product)listViewItem.DataContext;

            MessageBox.Show(product.ModelName.ToString());

        }
    }
}

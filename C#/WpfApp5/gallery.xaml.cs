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

            Lis.ItemsSource = products;
        }

      public static  ObservableCollection<Product> products = new ObservableCollection<Product>();


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

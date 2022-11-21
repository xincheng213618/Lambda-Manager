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
    /// GalleryTool.xaml 的交互逻辑
    /// </summary>
    public partial class GalleryTool : UserControl
    {
        public GalleryTool()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
           foreach (Product item in Gallery.products)
            {
                item.SizeLevel = (int)sizeSlider.Value;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


       
          
            if (Gallery.List.SelectedItems.Count == 1)
            {
                Gallery.products.Remove((Product)Gallery.List.SelectedItem);

            }
            if (Gallery.List.SelectedItems.Count > 1)
            {
                deleteItems();
            }
           



        }

        private void deleteItems()
        {
            MessageBoxResult result = MessageBox.Show("是否删除原始图片", "信息提示", MessageBoxButton.YesNoCancel,MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    break;
                case MessageBoxResult.No:
                    int selectedCount = Gallery.List.SelectedItems.Count;
                    for (int i = 0; i < selectedCount; i++)
                    {
                     Gallery.products.Remove((Product)Gallery.List.SelectedItems[0]);
                    }

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Gallery.products.Remove(Gallery.products[0]);
        }
    }
}

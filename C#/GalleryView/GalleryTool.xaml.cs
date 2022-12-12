using Lambda;
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
                deleteItem();
                //Gallery.products.Remove((Product)Gallery.List.SelectedItem);

            }
            if (Gallery.List.SelectedItems.Count > 1)
            {
                deleteItems();
            }
           



        }

        private void deleteItems()
        {
            int selectedCount = Gallery.List.SelectedItems.Count;
            string label="";
            for (int i = 0; i < selectedCount; i++)
            {
                if (i < 7)
                {
                    Product product = Gallery.List.SelectedItems[i] as Product;
                    label += product.ModelName;
                    label += ", ";
                }
                
            }
            if(selectedCount>=7)
            {
                label += ". . .  ";
            }


            MessageBoxResult result = MessageBox.Show("是否删除原始图片" + " " + label, "信息提示", MessageBoxButton.YesNoCancel,MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    for (int i = 0; i < selectedCount; i++)
                    {
                        Product product = Gallery.List.SelectedItems[0] as Product;
                        int Index = product.ModelNumber;
                        Gallery.products.Remove((Product)Gallery.List.SelectedItems[0]);

                        LambdaControl.Trigger("ZSTACK_GALLERY_REMOVE_ORI", this, new Dictionary<string, object> { { "index", Index } });

                    }
                    break;
                case MessageBoxResult.No:
                    
                    for (int i = 0; i < selectedCount; i++)

                    {
                        Product product = Gallery.List.SelectedItems[0] as Product;
                        int Index = product.ModelNumber;
                        Gallery.products.Remove((Product)Gallery.List.SelectedItems[0]);
                        LambdaControl.Trigger("ZSTACK_GALLERY_REMOVE", this, new Dictionary<string, object> { { "index", Index } });

                    }

                    break;
                case MessageBoxResult.Cancel:

                    break;
            }
        }
        private void deleteItem()
        {
          
           
            Product product = Gallery.List.SelectedItem as Product;
            string label = product.ModelName.ToString();
            int Index = product.ModelNumber;
            MessageBoxResult result = MessageBox.Show("是否删除原始图片 "+" "+ label, "信息提示", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Gallery.products.Remove((Product)Gallery.List.SelectedItem);
                    
                    LambdaControl.Trigger("ZSTACK_GALLERY_REMOVE_ORI", this, new Dictionary<string, object> { { "index", Index} });
                    break;
                case MessageBoxResult.No:

                    Gallery.products.Remove((Product)Gallery.List.SelectedItem);
                    LambdaControl.Trigger("ZSTACK_GALLERY_REMOVE", this, new Dictionary<string, object> { { "index", Index } });
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

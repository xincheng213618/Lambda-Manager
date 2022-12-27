using Lambda;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
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
    public partial class GalleryTool : System.Windows.Controls.UserControl
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


            MessageBoxResult result = System.Windows.MessageBox.Show("是否删除原始图片" + " " + label, "信息提示", MessageBoxButton.YesNoCancel,MessageBoxImage.Question);
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
            MessageBoxResult result = System.Windows.MessageBox.Show("是否删除原始图片 "+" "+ label, "信息提示", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
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


        private void SaveAsDialog(string fileName)
        {
            System.Windows.Forms.SaveFileDialog SaveFile = new System.Windows.Forms.SaveFileDialog();
            SaveFile.Filter = "Jpg 图片|*.jpg|Bmp 图片|*.bmp|Tiff 图片|*.tiff|Png 图片|*.png";
   
            SaveFile.FilterIndex = 1;//文本筛选器索引，选择第一项就是1
            SaveFile.RestoreDirectory = true;
            SaveFile.FileName = fileName;
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                Product product = Gallery.List.SelectedItems[0] as Product;
                int Index = product.ModelNumber;

                string path = SaveFile.FileName.ToString();
                LambdaControl.Trigger("ZSTACK_GALLERY_SAVE_SINGLE", this, new Dictionary<string, object> { { "index", Index }, { "path", path }});
            }


        }

        private void SaveAsFileDialog(string fileName)
        {
            System.Windows.Forms.SaveFileDialog SaveFile = new System.Windows.Forms.SaveFileDialog();
            SaveFile.Filter = "Zip|*.zip";
            SaveFile.RestoreDirectory = true;
            SaveFile.FileName = fileName;
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                int selectedCount = Gallery.List.SelectedItems.Count;
                Dictionary<string, object> keyValues = new Dictionary<string, object>();
                List<int> ints = new List<int>(); 
                for (int i = 0; i < selectedCount; i++)

                {
                    Product product = Gallery.List.SelectedItems[i] as Product;
                    int Index = product.ModelNumber;
                    ints.Add(Index);

                }
                string path = SaveFile.FileName.ToString();
                string indexs = JsonSerializer.Serialize<List<int>>(ints);
                ;
                LambdaControl.Trigger("ZSTACK_GALLERY_SAVE_MULTI", this, new Dictionary<string, object> { { "indexs", indexs }, { "path", path } });




            }


        }


        string folderBrowserpath = "";
        private void FolderBrowserDialog(int count)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog() { };
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (folderBrowserpath != "")
            {
                dialog.SelectedPath = folderBrowserpath;
            }
            else
            {
                dialog.SelectedPath = dir;
            }

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            // dialog.SelectedPath = "";
            folderBrowserpath= dialog.SelectedPath;
            string foldername = dialog.SelectedPath.Trim();
            
           // Dictionary<string, object> keyValues = new Dictionary<string, object>();
            List<int> ints = new List<int>();
            for (int i = 0; i < count; i++)

            {
                Product product = Gallery.List.SelectedItems[i] as Product;
                int Index = product.ModelNumber;
                ints.Add(Index);

            }
            string path = foldername;
            string indexs = JsonSerializer.Serialize<List<int>>(ints);
            LambdaControl.Trigger("ZSTACK_GALLERY_SAVE", this, new Dictionary<string, object> { { "indexs", indexs }, { "path", path } });
            
        }

       


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int selectedCount = Gallery.List.SelectedItems.Count;
            if (selectedCount > 0)
            {
                FolderBrowserDialog(selectedCount);
            }
          
            //if (selectedCount == 1)
            //{
            //    //Product product = Gallery.List.SelectedItem as Product;
            //    //string label = product.ModelName.ToString();
            //    //SaveAsDialog(label);

            //}
            //else if (selectedCount > 1)
            //{
            //    //SaveAsFileDialog("Images");

            //}

        }
    }
}

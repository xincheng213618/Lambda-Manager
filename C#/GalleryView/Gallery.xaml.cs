using Global.Common.Extensions;
using Lambda;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
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
            List = Lis;
            Lis.ItemsSource = products;
        }

        public class Thumbnail
        {
            private string thumbnailAdd;
            public string ThumbnailAdd
            {
                get { return thumbnailAdd; }
                set { thumbnailAdd = value; }
            } 
            private string describe;
            public string Describe
            {
                get { return describe; }
                set { describe = value; }
            }
            private string status;
            public string Status
            {
                get { return status; }
                set { status = value; }
            }
        }

        public class GalleryPath
        {
            public List<string> Paths { get; set; } = new List<string>();
        }


        public static ObservableCollection<Product> products = new ObservableCollection<Product>();
       // public static ObservableCollection<Thumbnail> ThumbnailList = new ObservableCollection<Thumbnail>();

        public static ListView List = new ListView();
        public static GalleryTool galleryTool = new GalleryTool();
        private List<string> SlicePaths = new List<string>();
        int index = 0;
       
        private void HandleDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListViewItem listViewItem = (ListViewItem)sender;
            Product product = (Product)listViewItem.DataContext;
            string path = product.ProductImagePath;
            LambdaControl.Trigger("ZSTACK_GALLERY_CURRENT", this, path);

            
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            LambdaControl.AddLambdaEventHandler("ZSTACK_GALLERY_BACK", GalleryImageAddress, false);
            LambdaControl.AddLambdaEventHandler("ZSTACK_GALLERY_PATH", GalleryPathConverter, false);
            products.CollectionChanged += delegate
            {


            };
            
        }

        private bool GalleryPathConverter(object sender, EventArgs e)     // receive current mode All slice paths
        {

            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            string multiSliceJson = eventData.GetString("Slice");
           // MessageBox.Show(multiSliceJson.ToString());
            GalleryPath galleryPath = JsonSerializer.Deserialize<GalleryPath>(multiSliceJson);
            if (galleryPath != null)
            {
                SlicePaths = galleryPath.Paths;
            }
           
            products.Clear();
            index = 0;
            foreach (string path in SlicePaths)
            {
                LambdaControl.Trigger("ZSTACK_GALLERY_SLICE", this, path);
            }
            
            galleryTool.sizeSlider.Value = 5;

            return true;

        }
        private bool GalleryImageAddress(object sender, EventArgs e)
        {

            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            WriteableBitmap writeable = GetWriteableBitmap(eventData);
            string fullPath = SlicePaths[index];
            string path1 = fullPath.Substring(fullPath.Length-21);
            string path2 = path1.Substring(0,15);
            Product product = new Product(index,path2, fullPath,writeable);
            products.Add(product);
            index++;
            return true;

        }





        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        public static extern void RtlMoveMemory(IntPtr Destination, IntPtr Source, uint Length);
        private WriteableBitmap GetWriteableBitmap(Dictionary<string, object> eventData)
        {
            int size = (int)eventData["size"];

            IntPtr intPtr = (IntPtr)eventData["data"];

            WriteableBitmap writeableBitmap = new WriteableBitmap(320, 240, 96.0, 96.0, PixelFormats.Bgr24, null);
            RtlMoveMemory(writeableBitmap.BackBuffer, intPtr, (uint)size);
            writeableBitmap.Lock();
            writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
            writeableBitmap.Unlock();
            return writeableBitmap;


        }


     


       









    }
}

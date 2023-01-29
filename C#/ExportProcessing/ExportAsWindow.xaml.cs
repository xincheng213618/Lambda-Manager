using Lambda;
using System;
using System.Collections.Generic;
using System.IO;
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
using ThemeManager.Controls;
using System.Text.Json;
using Microsoft.Win32;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Nodes;

namespace ExportProcessing
{
    /// <summary>
    /// ExportAsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ExportAsWindow : BaseWindow
    {
        
        public GrifExportViewModel grifExportAs= new GrifExportViewModel();
        public String ImageName;
        public int exportKinds = 0;
        //0 单图 1多图 2 合成图
        
        public int NameIndex = 1;
        public int NameIndex1= 1;
        public int NameIndex2 = 1;
        public string ExportFullName;
        public List<string> strings = new List<string>();
        public string VisualJson = "null";
        List<JsonNode> VisualNodes { get; set; } = new List<JsonNode>();
        //public string VisualJson
        //{
        //    get;
        //    set

        //}
        // public string VisualJson { get};
        public ExportAsWindow(string filePath,int window,string type,string exportFullName,string visualJson)
        {
            grifExportAs.ExportWindow = window;
            ImageName = System.IO.Path.GetFileNameWithoutExtension(filePath);
            exportKinds = 0;
            ExportType(type);
            this.ExportFullName = exportFullName;
            InitializeComponent();
            DockKind.Visibility = Visibility.Collapsed;
            WindowTitleText.Text = type.Remove(type.Length - 3, 3);
            grifExportAs.FullName = filePath;
            singleExportVisualToJson(VisualNodes, visualJson);


        }
        //预览 单图（含多窗口单图）
        public ExportAsWindow(int index,int win, string type, string exportFullName, string visualJson)
        {
            exportKinds = 0; 
            grifExportAs.ExportWindow = win;
            ImageName = "图像" + index.ToString();
            ExportType(type);
            this.ExportFullName = exportFullName;
            InitializeComponent();
            DockKind.Visibility = Visibility.Collapsed;
            WindowTitleText.Text = type.Remove(type.Length - 3, 3);
            singleExportVisualToJson(VisualNodes, visualJson);

        }
       private void singleExportVisualToJson(List<JsonNode> jsonNodes, string jsonIn )
        {
            JsonObject visual = (JsonObject)JsonObject.Parse(jsonIn);
            jsonNodes.Clear();
            jsonNodes.Add(visual??new JsonObject());
            string json1 = JsonSerializer.Serialize(jsonNodes, new JsonSerializerOptions());
            VisualJson = JsonToJson(json1);


        }





        public ExportAsWindow(string type, int num, int index,string exportFullName, string visualJson)
        {
            exportKinds = num;
            if (num == 1)
            {
                ImageName = "新建文件" + index.ToString();
                NameIndex = index;
            }
            else
            {
                ImageName = "合成图像" + index.ToString();
                NameIndex1 = index;
            }
            ExportType(type);
            this.ExportFullName = exportFullName;
            InitializeComponent();
            DockKind.Visibility = Visibility.Collapsed;
            WindowTitleText.Text = type.Remove(type.Length - 3, 3);
            VisualJson = JsonToJson(visualJson);

        }





        private string JsonToJson(string json)
        {
            List<WindowVisual> windowList = JsonSerializer.Deserialize<List<WindowVisual>>(json);
            foreach(WindowVisual visual in windowList??new List<WindowVisual>())
            {
                foreach(var item in visual.VisualsList)
                {
                    item.PointList = ZoomParList(item.PointList, visual.AcWidth, visual.AcHeight);
                    

                }

                visual.DefaultDim.PointList = ZoomParList(visual.DefaultDim.PointList, visual.AcWidth, visual.AcHeight);
               
            }
            string JSON = JsonSerializer.Serialize(windowList, new JsonSerializerOptions());
            return JSON;

        }



        private void ExportType(string type)
        {
           
                switch (type)
                {
                    case "导出PNG...":
                        grifExportAs.Kinds = ExportAsKinds.png;
                        break;
                    case "导出JPEG...":
                        grifExportAs.Kinds = ExportAsKinds.jpeg;
                        break;
                    case "导出BMP...":
                        grifExportAs.Kinds = ExportAsKinds.bmp;
                        break;
                    case "导出TIFF...":
                        grifExportAs.Kinds = ExportAsKinds.tiff;
                        break;
                    default:
                        grifExportAs.Kinds = ExportAsKinds.png;
                        break;
                }

        }




        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
           
            combobox.ItemsSource = Enum.GetValues(typeof(ExportAsKinds)).Cast<ExportAsKinds>();

            for (int i = 0; i < combobox.Items.Count; i++)
            {
                if ((ExportAsKinds)combobox.Items[i] == grifExportAs.Kinds)
                {
                    combobox.SelectedIndex = i;
                    break;
                }
            }
            this.DataContext = grifExportAs;
           
            if(exportKinds == 0|| exportKinds==2)
            {
                grifExportAs.ExportFullName = System.IO.Path.GetDirectoryName(this.ExportFullName) + "\\" + ImageName + "." + grifExportAs.Kinds;
            }
            else
            {
                grifExportAs.ExportFullName = System.IO.Path.GetDirectoryName(this.ExportFullName) + "\\" + ImageName + ".rar";
            }
            

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(grifExportAs.ExportFullName))
            {
                if (MessageBox.Show("此目标已经存在该文件，是否覆盖", "信息提示", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                {
                    return;
                }
            }
            if (grifExportAs.SavedCalloutContent)
            {
               
                LambdaControl.Trigger("DRAWING_VISUAL1", this, VisualJson);
            }
           
            switch (exportKinds)
            {
                case 0:
                    if(grifExportAs.FullName!= string.Empty)
                    {
                        JsontoExport();
                    }
                    else
                    {
                        NameIndex2++;
                        grifExportAs.ExportType = exportKinds;
                        JsontoExport();
                    }
                  
                    break;
                case 1:
                    NameIndex++;
                    grifExportAs.ExportType = exportKinds;
                    JsontoExport();
                    break;
                case 2:
                    NameIndex1++;
                    grifExportAs.ExportType = exportKinds;
                    JsontoExport();
                    break;
               
                default:
                    break;      
            }

           
            this.Close();
           
           

        }


        private void JsontoExport()
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
            string json = JsonSerializer.Serialize(grifExportAs, jsonSerializerOptions);
            LambdaControl.Trigger("QUICK_EXPORT_AS", this, json);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Filter;
            if(exportKinds == 0)
            {
                switch (grifExportAs.Kinds)
                {
                    case ExportAsKinds.png:
                        Filter = "(*.png) | *.png";
                        break;
                    case ExportAsKinds.jpeg:
                        Filter = "(*.jpeg) | *.jpeg";
                        break;
                    case ExportAsKinds.tiff:
                        Filter = "(*.tiff) | *.tiff";
                        break;
                    case ExportAsKinds.bmp:
                        Filter = "(*.bmp) | *.bmp";
                        break;
                    default:
                        Filter = "(*.png) | *.png";
                        break;
                }

            }
            else
            {
                Filter = "(*.rar) | *.rar";
            }
            

            SaveFileDialog dialog = new()
            {
                Title = "另存为",
                RestoreDirectory = true,
                Filter = Filter,
            };
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                grifExportAs.ExportFullName = dialog.FileName;
                ExportFullName = dialog.FileName;


            };
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBoxItem comboBoxItem)
            {
                grifExportAs.Kinds = (ExportAsKinds)comboBoxItem.Content;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private static Point ZoomPar(Point point, double width, double height)
        {
            Matrix matrix = new Matrix();
            matrix.Scale(1280/width , 960/height);
            point = point * matrix;
            return point;
        }
        private static List<Point> ZoomParList(List<Point> points, double width, double height)
        {
            for (int i = 0; i < points.Count; i++)
            {

                points[i] = ZoomPar(points[i], width, height);
            }

            return points;
        }
    }

   
}

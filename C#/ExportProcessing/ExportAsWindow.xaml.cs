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

namespace ExportProcessing
{
    /// <summary>
    /// ExportAsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ExportAsWindow : BaseWindow
    {
        
        public GrifExportViewModel grifExportAs= new GrifExportViewModel();
        public String ImageName;
        public ExportAsWindow(string filePath,string type)
        {
            ImageName = System.IO.Path.GetFileNameWithoutExtension(filePath);
            //WindowTitleText.Text = type.Remove(type.Length - 3, 3);
        
            ExportType(type);
            InitializeComponent();
            DockKind.Visibility = Visibility.Collapsed;
            WindowTitleText.Text = type.Remove(type.Length - 3, 3);
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
            grifExportAs.ExportFullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + ImageName + "." + grifExportAs.Kinds;
            

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

            LambdaControl.Trigger("GrifExportAs", this, JsonSerializer.Serialize(grifExportAs));
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Filter;
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
            };
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBoxItem comboBoxItem)
            {
                grifExportAs.Kinds = (ExportAsKinds)comboBoxItem.Content;
            }
        }
    }

   
}

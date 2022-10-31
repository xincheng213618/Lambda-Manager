using XSolution;
using System.Windows;
using ThemeManager.Controls;
using Global.Common;
using Global.Common.Extensions;
using System.Collections.Generic;
using Lambda;
using Microsoft.Win32;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Solution
{
    public class ProjectExportAs : ViewModelBase
    {
        public string Kinds { get; set; }

        public string FullName { get; set; }

        public string ExportFullName { get; set; }


        //拍照时间
        public bool PhotoTime { get; set; }

        public bool Dimension { get; set; }

        public bool Ruler { get; set; }

        public List<string> Mode { get; set; }


        public string ToJson()
        {
            var mode = new StringBuilder();
            foreach (var item in Mode)
            {
                mode.Append(item);
                mode.Append(',');
            }
            return $"{{\"FullName\":\"{FullName.Replace("\\", "\\\\")}\",\"ExportFullName\":\"{ExportFullName.Replace("\\", "\\\\")}\",\"Kinds\":\"{Kinds.Replace("\\", "\\\\")}\",\"Mode\":\"{mode.ToString().Replace("\\", "\\\\")}\"}}";
        }
    }

    /// <summary>
    /// GrifExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsWindow : BaseWindow
    {
        public SeriesProjectManager seriesProjectManager;

        public ObservableCollection<SeriesProjectManager> SeriesProjectManagers = new ObservableCollection<SeriesProjectManager>();

        public ProjectExportAs ProjectExportAs;
        public SeriesExportAsWindow(SeriesProjectManager seriesProjectManager)
        {
            this.seriesProjectManager = new SeriesProjectManager(seriesProjectManager.FullName);
            this.seriesProjectManager.ExportIni();
            SeriesProjectManagers.Add(this.seriesProjectManager);
            InitializeComponent();

            SeriesExportTreeView1.ItemsSource = SeriesProjectManagers;

            ProjectExportAs = new ProjectExportAs() { Kinds = "mp4", FullName = seriesProjectManager.FullName, PhotoTime = false };
            this.DataContext = ProjectExportAs;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
             List<string>Mode = new();
            if (checkbox51.IsChecked == true)
                Mode.Add("bright-field");
            if (checkbox52.IsChecked == true)
                Mode.Add("dark-field");
            if (checkbox53.IsChecked == true)
                Mode.Add("rheinberg");
            if (checkbox54.IsChecked == true)
                Mode.Add("relief-contrast");
            if (checkbox55.IsChecked == true)
                Mode.Add("quantitative-phase");
            if (checkbox56.IsChecked == true)
                Mode.Add("phase-contrast");

            ProjectExportAs.Mode = Mode;





            LambdaControl.Trigger("SeriesProjectExportAs", this, ProjectExportAs.ToJson());

            this.Close();
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is XSolution.BaseObject baseObject)
            {
                baseObject.IsEditMode = false;
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is XSolution.BaseObject baseObject)
            {
                baseObject.Name = tb.Text;
                if (e.Key == Key.Escape || e.Key == Key.Enter)
                {
                    baseObject.IsEditMode = false;
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Filter;
            switch (ProjectExportAs.Kinds)
            {
                case "mp4":
                    Filter = "(*.mp4) | *.mp4";
                    break;
                case "avi":
                    Filter = "(*.avi) | *.avi";
                    break;
                case "rar":
                    Filter = "(*.rar) | *.rar";
                    break;
                case "dicom":
                    Filter = "(*.dicom) | *.dicom";
                    break;
                default:
                    return;
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
                ProjectExportAs.ExportFullName = dialog.FileName;
            };
        }
    }
}

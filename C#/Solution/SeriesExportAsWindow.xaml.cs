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
        public BaseObject BaseObject;

        public ProjectExportAs ProjectExportAs;
        public SeriesExportAsWindow(BaseObject BaseObject)
        {
            this.BaseObject = BaseObject;
            ProjectExportAs = new ProjectExportAs() { Kinds = "mp4", FullName = BaseObject.FullName, PhotoTime = false };
            InitializeComponent();
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
                LambdaControl.Trigger("SeriesProjectExportAs", this, ProjectExportAs.ToJson());
            };
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

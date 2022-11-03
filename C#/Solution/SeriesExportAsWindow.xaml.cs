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
using System.Windows.Documents;
using System;
using System.Linq;

namespace Solution
{
    public class ProjectExportAs : ViewModelBase
    {

        public string FullName { get; set; } = "";


        private string exportFullName = string.Empty;

        public string ExportFullName
        {
            get { return exportFullName; }
            set
            {
                if (value != null && value != exportFullName)
                    exportFullName = value; NotifyPropertyChanged();
            }
        }
        private SeriesExportKinds kinds = SeriesExportKinds.mp4;
        public SeriesExportKinds Kinds
        {
            get { return kinds; }
            set
            {
                if (value != kinds)
                    kinds = value; NotifyPropertyChanged();
            }
        }

        //拍照时间
        public bool PhotoTime { get; set; }

        public bool Dimension { get; set; }

        public bool Ruler { get; set; }

        public List<string> Mode { get; set; } = new List<string>();
        public List<string> FrameList { get; set; } = new List<string>();

    }

    public enum SeriesExportKinds
    {
        mp4,
        avi,
        rar,
        dicom,
    }

    /// <summary>
    /// GrifExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsWindow : BaseWindow
    {
        public SeriesProjectManager seriesProjectManager;

        public ProjectExportAs ProjectExportAs;
        public SeriesExportAsWindow(SeriesProjectManager seriesProjectManager)
        {
            this.seriesProjectManager = new SeriesProjectManager(seriesProjectManager.FullName);
            this.seriesProjectManager.ExportIni();

            ProjectExportAs = new ProjectExportAs() { Kinds = SeriesExportKinds.mp4, FullName = seriesProjectManager.FullName, PhotoTime = false };
            this.DataContext = ProjectExportAs;
            InitializeComponent();

            SeriesExportTreeView1.ItemsSource = this.seriesProjectManager.VisualChildren;
            SeriesExportTreeView2.ItemsSource = this.seriesProjectManager.ExportChildren;
        }
        public SeriesExportAsWindow(SeriesProjectManager seriesProjectManager,SeriesExportKinds seriesExportKinds)
        {
            this.seriesProjectManager = new SeriesProjectManager(seriesProjectManager.FullName);
            this.seriesProjectManager.ExportIni();

            ProjectExportAs = new ProjectExportAs() { Kinds = seriesExportKinds, FullName = seriesProjectManager.FullName, PhotoTime = false };
            this.DataContext = ProjectExportAs;
            InitializeComponent();

            SeriesExportTreeView1.ItemsSource = this.seriesProjectManager.VisualChildren;
            SeriesExportTreeView2.ItemsSource = this.seriesProjectManager.ExportChildren;
        }

        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            combobox.ItemsSource = Enum.GetValues(typeof(SeriesExportKinds)).Cast<SeriesExportKinds>();

            for (int i = 0; i < combobox.Items.Count; i++)
            {
                if ((SeriesExportKinds)combobox.Items[i] == ProjectExportAs.Kinds)
                {
                    combobox.SelectedIndex = i;
                    break;
                }
            }
            this.DataContext = ProjectExportAs;
            ProjectExportAs.ExportFullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + seriesProjectManager.Name + "." + ProjectExportAs.Kinds;

        }


        private void OK_Click(object sender, RoutedEventArgs e)
        {
            List<string> Mode = new();
            //if (checkbox51.IsChecked == true)
            //    Mode.Add("bright-field");
            //if (checkbox52.IsChecked == true)
            //    Mode.Add("dark-field");
            //if (checkbox53.IsChecked == true)
            //    Mode.Add("rheinberg");
            //if (checkbox54.IsChecked == true)
            //    Mode.Add("relief-contrast");
            //if (checkbox55.IsChecked == true)
            //    Mode.Add("quantitative-phase");
            //if (checkbox56.IsChecked == true)
            //    Mode.Add("phase-contrast");

            ProjectExportAs.Mode = Mode;
            foreach (var item in seriesProjectManager.ExportChildren)
            {
                if (item is GrifFile grifFile)
                    ProjectExportAs.FrameList.Add(grifFile.FullName);
            }

            LambdaControl.Trigger("SeriesProjectExportAs", this, ProjectExportAs.ToJson());
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBoxItem comboBoxItem)
            {
                ProjectExportAs.Kinds = (SeriesExportKinds)comboBoxItem.Content;
                ProjectExportAs.ExportFullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + seriesProjectManager.Name + ProjectExportAs.Kinds;

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
                case SeriesExportKinds.mp4:
                    Filter = "(*.mp4) | *.mp4";
                    break;
                case SeriesExportKinds.avi:
                    Filter = "(*.avi) | *.avi";
                    break;
                case SeriesExportKinds.rar:
                    Filter = "(*.rar) | *.rar";
                    break;
                case SeriesExportKinds.dicom:
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

        int Indexof = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Indexof <= 0)
                return;

            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof - 1];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Insert(Indexof, baseObject);
            Indexof--;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BaseObject baseObject = seriesProjectManager.ExportChildren[Indexof + 1];
            seriesProjectManager.ExportChildren.Remove(baseObject);
            seriesProjectManager.ExportChildren.Insert(Indexof, baseObject);
            Indexof++;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.Insert(Indexof, new SeriesProjectExportLine());
            Indexof--;

        }

        private void StackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is BaseObject baseObject)
                Indexof = seriesProjectManager.ExportChildren.IndexOf(baseObject);
        }

        private void Button_Click_01(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.Add(baseObject1);
        }

        private void Button_Click_02(object sender, RoutedEventArgs e)
        {
            seriesProjectManager.ExportChildren.RemoveAt(Indexof);
        }


        int Indexof1 = 0;
        BaseObject baseObject1 = null;
        private void StackPanel1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel.Tag is BaseObject baseObject)
            {
                baseObject1 = baseObject;
                Indexof1 = seriesProjectManager.ExportChildren.IndexOf(baseObject);
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            SeriesExportAsSettingWindow baseWindow = new SeriesExportAsSettingWindow();
            baseWindow.ShowDialog();
        }
    }
}

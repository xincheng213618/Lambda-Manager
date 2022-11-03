using XSolution;
using System.Windows;
using ThemeManager.Controls;
using System.IO;
using System.Text.Json;
using System.Text;
using Global.Common;
using Global.Common.Extensions;
using System.Windows.Controls;
using Microsoft.Win32;
using Lambda;
using static System.Net.WebRequestMethods;
using ThemeManager;
using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace Solution
{

    public class GrifExportAs : ViewModelBase
    {

        private string fullName =string.Empty;
        public string FullName 
        {
            get { return fullName; }
            set {
                if (value != null && value != fullName)
                    fullName = value; NotifyPropertyChanged();
            }
        }
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

        private GrifExportKinds kinds = GrifExportKinds.png;
        public GrifExportKinds Kinds
        {
            get { return kinds; }
            set
            {
                if (value != kinds)
                    kinds = value; NotifyPropertyChanged();
            }
        }
    }

    public enum GrifExportKinds
    {
        png,
        jpeg,
        tiff,
        bmp
    }

    /// <summary>
    /// GrifExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class GrifExportAsWindow : BaseWindow
    {
        public BaseObject BaseObject;

        public GrifExportAs  grifExportAs;
        public GrifExportAsWindow(BaseObject BaseObject)
        {
            this.BaseObject = BaseObject;
            grifExportAs = new GrifExportAs() { FullName = BaseObject.FullName,Kinds = GrifExportKinds.png};
            InitializeComponent();
        }
        public GrifExportAsWindow(BaseObject BaseObject, GrifExportKinds grifExportKinds)
        {
            this.BaseObject = BaseObject;
            grifExportAs = new GrifExportAs() { FullName = BaseObject.FullName, Kinds = grifExportKinds };
            InitializeComponent();

        }

        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            combobox.ItemsSource = Enum.GetValues(typeof(GrifExportKinds)).Cast<GrifExportKinds>();

            for (int i = 0; i < combobox.Items.Count; i++)
            {
                if ((GrifExportKinds)combobox.Items[i] == grifExportAs.Kinds)
                {
                    combobox.SelectedIndex = i;
                    break;
                }
            }
            this.DataContext = grifExportAs;
            grifExportAs.ExportFullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + BaseObject.Name +"."+ grifExportAs.Kinds;

        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("GrifExportAs", this, grifExportAs.ToJson());
            this.Close();
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (sender is ComboBoxItem comboBoxItem)
            {
                grifExportAs.Kinds = (GrifExportKinds)comboBoxItem.Content;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Filter;
            switch (grifExportAs.Kinds)
            {
                case GrifExportKinds.png:
                    Filter = "(*.png) | *.png";
                    break;
                case GrifExportKinds.jpeg:
                    Filter = "(*.jpeg) | *.jpeg";
                    break;
                case GrifExportKinds.tiff:
                    Filter = "(*.tiff) | *.tiff";
                    break;
                case GrifExportKinds.bmp:
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


    }



}

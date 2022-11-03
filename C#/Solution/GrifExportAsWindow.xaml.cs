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
                if (value != null && value != fullName)
                    exportFullName = value; NotifyPropertyChanged();
            }
        }

        private string kinds = string.Empty;
        public string Kinds
        {
            get { return kinds; }
            set
            {
                if (value != null && value != kinds)
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
        public GrifExportAs  grifExportAs;
        public GrifExportAsWindow(BaseObject BaseObject)
        {
            grifExportAs = new GrifExportAs() { FullName = BaseObject.FullName,Kinds ="png"};
            InitializeComponent();
        }
        public GrifExportAsWindow(BaseObject BaseObject, GrifExportKinds grifExportKinds)
        {
            grifExportAs = new GrifExportAs() { FullName = BaseObject.FullName, Kinds = grifExportKinds.ToString() };
            InitializeComponent();

        }

        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            combobox.ItemsSource = Enum.GetValues(typeof(GrifExportKinds)).Cast<GrifExportKinds>();

            for (int i = 0; i < combobox.Items.Count; i++)
            {
                MessageBox.Show(combobox.Items[i].ToString());
                if (combobox.Items[i].ToString().Contains(grifExportAs.Kinds))
                    combobox.SelectedIndex = i;

            }
            combobox.SelectedIndex = 0;
            this.DataContext = grifExportAs;
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
                grifExportAs.Kinds = comboBoxItem.Content.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Filter;
            switch (grifExportAs.Kinds)
            {
                case "png":
                    Filter = "(*.png) | *.png";
                    break;
                case "jpeg":
                    Filter = "(*.jpeg) | *.jpeg";
                    break;
                case "tiff":
                    Filter = "(*.tiff) | *.tiff";
                    break;
                case "bmp":
                    Filter = "(*.bmp) | *.bmp";
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
                grifExportAs.ExportFullName = dialog.FileName;
            };
        }


    }



}

using Global.Common.MVVM;
using Lambda;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using XSolution;

namespace Solution
{

    /// <summary>
    /// GrifExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class GrifExportAsWindow : Window
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
            DockKind.Visibility = Visibility.Collapsed;
            WindowTitleText.Text += Enum.GetName(grifExportKinds) ;
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
            if (File.Exists(grifExportAs.ExportFullName))
            {
                if (MessageBox.Show("\n\r此目标已经存在该文件，是否覆盖\n\r", "Grid", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                {
                    return;
                }
            }


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

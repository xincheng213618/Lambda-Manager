using XSolution;
using System.Windows;
using ThemeManager.Controls;
using System.IO;
using System.Text.Json;
using System.Text;
using Global.Common;
using Global.Common.Extensions;
using System.Windows.Controls;

namespace Solution
{
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
            grifExportAs = new GrifExportAs() { FullName = BaseObject.FullName,Kinds ="png"};
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (BaseObject is ProjectFile projectFile)
            {
                projectFile.ExportAs(projectFile, grifExportAs.Kinds);
            }
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
    }



}

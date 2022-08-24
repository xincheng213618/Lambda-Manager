using XSolution;
using System.Windows;
using ThemeManager.Controls;

namespace Solution
{
    /// <summary>
    /// ExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class ExportAsWindow : BaseWindow
    {
        public BaseObject BaseObject;
        public ExportAsWindow(BaseObject BaseObject)
        {
            this.BaseObject = BaseObject;   
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (Tool.Utils.OpenFileDialog(out string FilePath))
            {
                Lambda.LambdaControl.Trigger("ProjectExportAs", this, BaseObject.FullName);
            };
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

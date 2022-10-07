using XSolution;
using System.Windows;
using ThemeManager.Controls;
using System.IO;
using System.Text.Json;
using System.Text;
using Global.Common;
using Global.Common.Extensions;

namespace Solution
{
    /// <summary>
    /// ExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class ExportAsWindow : BaseWindow
    {
        public BaseObject BaseObject;

        public ProjectExportAs ProjectExportAs;
        public ExportAsWindow(BaseObject BaseObject)
        {
            this.BaseObject = BaseObject;
            ProjectExportAs = new ProjectExportAs() { Kind = 0, FullPath = BaseObject.FullName, PhotoTime = false };
            InitializeComponent();
        }



        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Lambda.LambdaControl.Trigger("ProjectExportAs", this, ProjectExportAs.ToJson());

            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }


    public class ProjectExportAs:ViewModelBase
    {
        public int Kind { get; set; } = 0;

        public string FullPath { get; set; } = string.Empty;

        //拍照时间
        public bool PhotoTime { get; set; }
        //相对开始采集时间间隔






    }
}

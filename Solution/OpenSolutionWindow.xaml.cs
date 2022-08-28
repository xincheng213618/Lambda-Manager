using Solution.RecentFile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Solution
{
    /// <summary>
    /// NewCreatWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OpenSolutionWindow : BaseWindow
    {
        public OpenSolutionWindow()
        {
            InitializeComponent();
        }
        public string FullName = string.Empty;

        RecentFileList recentFileList = new RecentFileList();
        public ObservableCollection<SoulutionInfo> SoulutionInfos = new ObservableCollection<SoulutionInfo>();

        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            
            foreach (var item in recentFileList.RecentFiles)
            {
                FileInfo fileInfo = new FileInfo(item);
                if (fileInfo.Exists)
                {
                    SoulutionInfos.Add(new SoulutionInfo() { Name = fileInfo.Name, FullName = fileInfo.FullName, CreationTime = fileInfo.CreationTime.ToString("yyyy/MM/dd H:mm") });
                }
            }
            ListView1.ItemsSource = SoulutionInfos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Tool.Utils.OpenFileDialog(out string FullName))
            {
                this.FullName = FullName;
                this.Close();
            };
        }

        private void SCManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;

        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListView listView)
            {
                if (listView.SelectedIndex > -1)
                {
                    FullName = SoulutionInfos[listView.SelectedIndex].FullName;
                    this.Close();
                }


            }
        }
    }

    public class SoulutionInfo
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string CreationTime { get; set; }
    }
}

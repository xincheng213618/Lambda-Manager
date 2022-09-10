using Global.Common.Extensions;
using Lambda;
using Solution.RecentFile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
using static Global.Common.Util.JsonHelper;

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

            //LambdaControl.AddLambdaEventHandler("SET_CELL_INFOS", SET_CELL_INFOS, false);
        }
        //private bool SET_CELL_INFOS(object sender, EventArgs e)
        //{
        //    Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
        //    if (eventData == null)
        //        return false;

        //    Application.Current.Dispatcher.Invoke(delegate
        //    {
        //        string json = eventData.GetString("cellinfos");
        //        var CellInfos = JsonSerializer.Deserialize<ObservableCollection<SoulutionInfo>>(json);
        //        ListView1.ItemsSource = CellInfos;
        //    });
        //    return true;
        //}


        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //LambdaControl.Dispatch("VideoTest", this, new Dictionary<string, object>());

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

                    //JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                    //string value = JsonSerializer.Serialize(SoulutionInfos, jsonSerializerOptions);

                    //File.WriteAllText("1.text", value);
                    //string value1 = File.ReadAllText("1.txt");
                    //var a = JsonSerializer.Deserialize<ObservableCollection<SoulutionInfo>>(value1);

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

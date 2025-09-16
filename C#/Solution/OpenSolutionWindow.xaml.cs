using Global.RecentFile;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

        RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\Zircon\\Grid\\SolutionHistory") };

        public ObservableCollection<SoulutionInfo> SoulutionInfos { get; set; }= new ObservableCollection<SoulutionInfo>();
        public ObservableCollection<SoulutionInfo> SoulutionInfosShow { get; set; }

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
            SoulutionInfosShow = new ObservableCollection<SoulutionInfo>(SoulutionInfos);
            ListView1.ItemsSource = SoulutionInfosShow;

        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Tool.Utils.OpenFileDialog(out var FullName))
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender is Button button&& button.Tag is SoulutionInfo soulutioninfo)
            {
                SoulutionInfos.Remove(soulutioninfo);
                SoulutionInfosShow.Remove(soulutioninfo);
                recentFileList.RemoveFile(soulutioninfo.FullName);

                if (!string.IsNullOrEmpty(Searchbox.Text)&&SoulutionInfosShow.Count == 0)
                {
                    SearchNoneText.Visibility = Visibility.Visible;
                    SearchNoneText.Text = "未找到" + Searchbox.Text + "相关项目";
                }
            }
        }


        private void SearchBar_OnSearchStarted(object sender, HandyControl.Data.FunctionEventArgs<string> e)
        {

        }

        private void Searchbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (SearchNoneText.Visibility == Visibility.Visible)
                SearchNoneText.Visibility = Visibility.Hidden;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                ListView1.ItemsSource = SoulutionInfos;

            }
            else
            {
                SoulutionInfosShow = new ObservableCollection<SoulutionInfo>();
                foreach (var item in SoulutionInfos)
                {
                    if (item.FullName.Contains(textBox.Text))
                        SoulutionInfosShow.Add(item);
                }
                ListView1.ItemsSource = SoulutionInfosShow;
                if (SoulutionInfosShow.Count == 0)
                {
                    SearchNoneText.Visibility = Visibility.Visible;
                    SearchNoneText.Text = "未找到" + textBox.Text + "相关项目";
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

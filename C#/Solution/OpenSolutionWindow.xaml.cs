﻿using Solution.RecentFile;
using System;
using System.Collections.ObjectModel;
using System.IO;
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

        RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\NLG\\Grid\\SolutionHistory") };

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
                recentFileList.RemoveFile(soulutioninfo.FullName);
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

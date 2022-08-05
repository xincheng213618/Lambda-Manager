﻿using Solution.RecentFile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class NewCreatWindow : BaseWindow
    {
        public NewCreatWindow()
        {
            InitializeComponent();
        }

        RecentFileList recentFileList = new RecentFileList();
        public ObservableCollection<SoulutionInfo> SoulutionInfos = new ObservableCollection<SoulutionInfo>();

        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            foreach (var item in recentFileList.RecentFiles)
            {
                SoulutionInfos.Add(new SoulutionInfo() { Name =item ,Path =item});
            }
            ListView1.ItemsSource = SoulutionInfos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class SoulutionInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }

    }
}
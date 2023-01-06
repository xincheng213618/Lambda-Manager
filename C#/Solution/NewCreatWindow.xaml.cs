using Global.Common;
using HandyControl.Properties.Langs;
using Solution.RecentFile;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Input;
using ThemeManager.Controls;
using Tool;

namespace Solution
{
    public class NewCreatViewMode : ViewModelBase
    {
        public RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\NLG\\Grid\\RecentNewCreatCache") };

        public NewCreatViewMode()
        {
            if (recentFileList.RecentFiles.Count == 0)
                recentFileList.InsertFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Grid");

            foreach (var item in recentFileList.RecentFiles)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                if (directoryInfo.Exists)
                {
                    RecentNewCreatCacheList.Add(directoryInfo.FullName);
                }
            }

            this.DirectoryPath = recentFileList.RecentFiles[0];
            this.Name = NewCreateFileName("新建工程");
        }

        public string NewCreateFileName(string FileName)
        {
            if (!Directory.Exists($"{this.DirectoryPath}\\{FileName}"))
                return FileName;
            for (int i = 1; i < 999; i++)
            {
                if (!Directory.Exists($"{this.DirectoryPath}\\{FileName}{i}"))
                    return $"{FileName}{i}";
            }
            return FileName;
        }

        /// <summary>
        /// 工程名称
        /// </summary>
        public string Name { get => _Name; set { _Name = value; NotifyPropertyChanged(); } }
        private string _Name = string.Empty;

        /// <summary>
        /// 工程位置
        /// </summary>
        public string DirectoryPath { get => _DirectoryPath; set { _DirectoryPath = value; NotifyPropertyChanged(); } }
        private string _DirectoryPath = string.Empty;

        public ObservableCollection<string> RecentNewCreatCacheList { get; set; } = new ObservableCollection<string>();


    }

    /// <summary>
    /// NewCreatWindow.xaml 的交互逻辑
    /// </summary>
    public partial class NewCreatWindow : BaseWindow
    {
        public NewCreatWindow()
        {
            InitializeComponent();
        }

        public bool IsCreate =false;

        public NewCreatViewMode newCreatViewMode;
        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            newCreatViewMode = new NewCreatViewMode();

            this.DataContext = newCreatViewMode;
        }






        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "为新项目选择位置";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox1.Show( "文件夹路径不能为空", "提示");
                    return;
                }
                newCreatViewMode.DirectoryPath = dialog.SelectedPath;
                newCreatViewMode.recentFileList.InsertFile(newCreatViewMode.DirectoryPath);
            }
        }

        private void SCManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            string SolutionDirectoryPath = newCreatViewMode.DirectoryPath + "\\" + newCreatViewMode.Name;

            if (Directory.Exists(SolutionDirectoryPath))
            {
                var result = MessageBox1.Show("文件夹不为空，是否清空文件夹", "Grid", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        Directory.Delete(SolutionDirectoryPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox1.Show(ex.Message, "Grid");
                    }
                }
            }
            Directory.CreateDirectory(SolutionDirectoryPath);
            newCreatViewMode.recentFileList.InsertFile(newCreatViewMode.DirectoryPath);

            IsCreate = true;
            this.Close();
        }
    }



}

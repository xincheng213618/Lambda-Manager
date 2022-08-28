using Global.Common;
using Solution.RecentFile;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using ThemeManager.Controls;
using Tool;

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

        public bool IsCreate =false;

        RecentFileList recentFileList;

        public NewCreatViewMode newCreatViewMode;
        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            recentFileList = new RecentFileList();
            string regiserkey = "Software\\" + System.Windows.Forms.Application.CompanyName + "\\" + System.Windows.Forms.Application.ProductName + "\\" + "RecentNewCreatCache";
            recentFileList.Persister = new RegistryPersister(regiserkey);

            if (recentFileList.RecentFiles.Count==0)
                recentFileList.InsertFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +"\\Grid");

            newCreatViewMode = new NewCreatViewMode();
            newCreatViewMode.DirectoryPath = recentFileList.RecentFiles[0];
            newCreatViewMode.Name = NewCreateFileName("新建工程");
            this.DataContext = newCreatViewMode;
        }

        public string NewCreateFileName(string FileName)
        {
            if (!Directory.Exists($"{newCreatViewMode.DirectoryPath}\\{FileName}"))
                return FileName;
            for (int i = 1; i < 999; i++)
            {
                if (!Directory.Exists($"{newCreatViewMode.DirectoryPath}\\{FileName}{i}"))
                    return $"{FileName}{i}";
            }
            return FileName ;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "项目位置";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    System.Windows.MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                newCreatViewMode.DirectoryPath = dialog.SelectedPath;
                recentFileList.InsertFile(newCreatViewMode.DirectoryPath);
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
                var result = MessageBox.Show("文件夹不为空，是否清空文件夹", "Grid", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        Directory.Delete(SolutionDirectoryPath, true);
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Grid");
                    }
                }
            }
            Directory.CreateDirectory(SolutionDirectoryPath);

            IsCreate = true;
            this.Close();
        }
    }

    public class NewCreatViewMode:ViewModelBase
    {
        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged();  } 
        }
        private string directoryPath = string.Empty;

        public string DirectoryPath
        {
            get { return directoryPath; }
            set { directoryPath = value; NotifyPropertyChanged(); } 
        }
    }

}

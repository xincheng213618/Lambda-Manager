using XSolution;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Lambda;
using System.Text.Json;
using Tool;
using Solution.RecentFile;
using Global.Common;
using System.Diagnostics;

namespace Solution
{

    public class TreeViewSetting : ViewModelBase
    {

        public bool isSupportMultiProject = false;
        public bool IsSupportMultiProject
        {
            get { return isSupportMultiProject; }
            set { isSupportMultiProject = value;NotifyPropertyChanged(); } 
        }


    }


    /// <summary>
    /// TreeViewControl.xaml 的交互逻辑
    /// </summary>
    public partial class TreeViewControl : UserControl
    {
        TreeViewSetting treeViewSetting = new TreeViewSetting();
        public TreeViewControl()
        {
            Window window = Application.Current.MainWindow;
            if (window != null)
                window.Closing += Window_Closed;
            InitializeComponent();
            IniCommand();
            this.DataContext = treeViewSetting;
        }

        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel1 && stackPanel1.Parent is Viewbox viewbox1 && viewbox1.Parent is ScrollViewer scrollViewer1)
            {
                stackPanel1.Children.Remove(this);

                StackPanel stackPanel = new StackPanel() { Name = "projectView", Margin = new Thickness(2, 2, 2, 0) };
                stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                stackPanel.Children.Add(this);
                Viewbox viewbox = new Viewbox() { VerticalAlignment = VerticalAlignment.Top };
                viewbox.Child = stackPanel;
                scrollViewer1.Content = viewbox;
                IsFirstLoad = false;
                //追加在显示的时候显示出发
                LambdaControl.Trigger("UpdateSolutionPath", this, ToStrings(SolutionDir));
            }
        }

        public ObservableCollection<SolutionExplorer> SolutionExplorers = new ObservableCollection<SolutionExplorer>();
        private Point SelectPoint;

        private BaseObject LastReNameObject;
        private TreeViewItem SelectedTreeViewItem;
        private TreeViewItem LastSelectedTreeViewItem;

        private string solutionDir;

        public string SolutionDir
        {
            get { return solutionDir; }
            set { solutionDir = value; LambdaControl.Trigger("UpdateSolutionPath", this, ToStrings(SolutionDir)); }
        }

        private string solutionFullName;

        public string SolutionFullName 
        {
            get { return solutionFullName; }
            set { solutionFullName = value;}
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            if (treeViewSetting.IsSupportMultiProject && SolutionExplorers.Count > 1)
            {
                MessageBox1.Show(Application.Current.MainWindow,"多工程情况下参数自动保存");
            }
            if (!string.IsNullOrEmpty(SolutionFullName))
            {
                Config.ConfigWrite(SolutionFullName);
            }
        }
        private static string ToStrings(string value)
        {
            using MemoryStream memoryStream = new();
            using (Utf8JsonWriter writer = new((Stream)memoryStream, default))
            {
                writer.WriteStringValue(value);
            }
            return Encoding.UTF8.GetString(memoryStream.ToArray())[1..^1];
        }

        //第一次的点击逻辑
        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);

            SelectPoint = e.GetPosition(SolutionTreeView);
            HitTestResult result = VisualTreeHelper.HitTest(SolutionTreeView, SelectPoint);
            if (result != null)
            {
                TreeViewItem item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);
                if (item == null)
                    return;

                if (SelectedTreeViewItem != null && SelectedTreeViewItem != item && SelectedTreeViewItem.DataContext is XSolution.BaseObject viewModeBase)
                {
                    viewModeBase.IsEditMode = false;
                }
                SelectedTreeViewItem = item;
                LastSelectedTreeViewItem = item;
                if (SolutionExplorers.Count != 1&&item.DataContext is SolutionExplorer solutionExplorer)
                {
                    ///判断当前工程配置不是现在的，不重复读取
                    if (SolutionFullName != solutionExplorer.FullName)
                    {
                        if (Config.ConfigRead(solutionExplorer.FullName) == 0)
                        {
                            SolutionFullName = solutionExplorer.FullName;
                            recentFileList.InsertFile(SolutionFullName);
                        }
                        else
                        {
                            MessageBox.Show("配置更新异常");
                        }
                    }
                }

                if (e.ClickCount == 2)
                {
                    if (item.DataContext is ProjectFile projectFile1)
                    {
                        LambdaControl.Trigger("projectFile", this, ToStrings(projectFile1.FullName));
                    }
                    if (item.DataContext is ProjectFolder projectFolder1)
                    {
                        LambdaControl.Trigger("projectFolder", this, ToStrings(projectFolder1.FullName));
                    }
                    if (item.DataContext is ProjectManager projectMannager1)
                    {
                        //LambdaControl.Trigger("projectManager", this, new Dictionary<string, object> { { "FullPath", ToStrings(projectMannager1.FullPath) } });
                        LambdaControl.Trigger("projectManager", this, projectMannager1.FullName);

                    }
                    if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                    {
                        LambdaControl.Trigger("seriesProjectManager", this, ToStrings(seriesProjectManager1.FullName));
                        LambdaControl.Trigger("PREVIEW_CLOSE", this, new Dictionary<string, object>() { });
                    }


                }

            }
            else
            {
                SelectedTreeViewItem = null;
            }
            //if (e.RightButton == MouseButtonState.Pressed)
            //{
            //    HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
            //}
        }


        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is XSolution.BaseObject baseObject)
            {
                baseObject.IsEditMode = false;
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is XSolution.BaseObject baseObject)
            {
                baseObject.Name = tb.Text;
                if (e.Key == Key.Escape || e.Key == Key.Enter)
                {
                    baseObject.IsEditMode = false;
                }
            }
        }

        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            OpenSolutionWindow openSolutionWindow = new OpenSolutionWindow();
            openSolutionWindow.Closed += (s, e) =>
            {
                if (treeViewSetting.isSupportMultiProject)
                {
                    string FullName = openSolutionWindow.FullName;

                    for (int i = 0; i < SolutionExplorers.Count; i++)
                    {
                        if (SolutionExplorers[i].FullName == FullName)
                        {
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(FullName) && Config.ConfigRead(FullName) == 0)
                    {
                        SolutionFullName = FullName;
                        recentFileList.InsertFile(FullName);
                        TreeViewInitialized(FullName, false);
                    }
                }
                else
                {
                    string FullName = openSolutionWindow.FullName;
                    if (!string.IsNullOrEmpty(FullName) && Config.ConfigRead(FullName) == 0)
                    {
                        SolutionFullName = FullName;
                        recentFileList.InsertFile(FullName);
                        TreeViewInitialized(FullName);
                    }
                }

            };
            openSolutionWindow.ShowDialog();
        }
         


        public BaseObject GetFile(BaseObject projectFolder, string FullPath)
        {
            var root = new DirectoryInfo(FullPath);
            foreach (var item in root.GetDirectories())
            {
                ProjectFolder projectFolder1 = new ProjectFolder(item.FullName);
                projectFolder.AddChild(GetFile(projectFolder1, item.FullName));
            }
            foreach (var item in root.GetFiles())
            {
                ProjectFile projectFile = new ProjectFile(item.FullName);
                string Extension = Path.GetExtension(projectFile.FullName);
                projectFolder.AddChild(projectFile);
                if (Extension == "png" || Extension == "jpg" || Extension == "tiff")
                {
                    projectFile.Visibility = Visibility.Visible;
                };
            }
            return projectFolder;
        }

        SolutionExplorer solutionExplorer;

        private void TreeViewInitialized(string FilePath, bool init = true)
        {
            solutionExplorer = new SolutionExplorer(FilePath)
            {
                SolutionName = System.IO.Path.GetFileNameWithoutExtension(FilePath),
            };


            SolutionDir = System.IO.Path.GetDirectoryName(FilePath);

            DirectoryInfo root = new DirectoryInfo(SolutionDir);
            var dics = root.GetDirectories();
            foreach (var dic in dics)
            {
                if (dic.Name == "Video" || dic.Name == "Image")
                {
                    ProjectManager projectMannager = new ProjectManager(dic.FullName) { CanDelete = false, CanReName = false, Visibility = Visibility.Hidden };
                    foreach (var item in dic.GetDirectories())
                    {
                        ProjectFolder projectFolder = new ProjectFolder(item.FullName);
                        projectMannager.AddChild(GetFile(projectFolder, item.FullName));
                    }
                    foreach (var item in dic.GetFiles())
                    {
                        ProjectFile projectFile = new ProjectFile(item.FullName);
                        string Extension = Path.GetExtension(projectFile.FullName);

                        projectMannager.AddChild(projectFile);

                        if (Extension == ".png" || Extension == ".jpg" || Extension == ".tiff" || Extension == ".bmp" || Extension == ".txt")
                        {
                            solutionExplorer.AddChild(projectFile);
                        };
                    }
                    solutionExplorer.AddChild(projectMannager);
                    projectMannager.Visibility = Visibility.Hidden;
                }
                else
                {
                    SeriesProjectManager seriesProjectManager = new SeriesProjectManager(dic.FullName);
                    solutionExplorer.AddChild(ADDDerivativeSeriesFile(seriesProjectManager, dic.FullName));

                    //foreach (var item in dic.GetDirectories())
                    //{
                    //    if (item.Name == "derives")
                    //    {
                    //        var root1 = new DirectoryInfo(item.FullName);
                    //        foreach (var item1 in root1.GetDirectories())
                    //        {
                    //            DerivativeSeriesFile derivativeSeriesFile = new DerivativeSeriesFile(item1.FullName);
                    //            seriesProjectManager.AddChild(derivativeSeriesFile);
                    //        }
                    //    }
                    //}
                    //solutionExplorer.AddChild(seriesProjectManager);
                }

            }
            if (init)
                SolutionExplorers.Clear();
            SolutionExplorers.Add(solutionExplorer);
            SolutionTreeView.ItemsSource = SolutionExplorers;
        }


        private BaseObject ADDDerivativeSeriesFile(BaseObject baseObject, string FullName)
        {
            var root = new DirectoryInfo(FullName);
            foreach (var directoryInfo in root.GetDirectories())
            {
                if (directoryInfo.Name == "derives")
                {
                    var directoryInfo1 = new DirectoryInfo(directoryInfo.FullName);
                    foreach (var item1 in directoryInfo1.GetDirectories())
                    {
                        DerivativeSeriesFile derivativeSeriesFile = new DerivativeSeriesFile(item1.FullName);
                        baseObject.AddChild(ADDDerivativeSeriesFile(derivativeSeriesFile, item1.FullName));
                    }
                }
            }
            return baseObject;
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(SolutionFullName))
            {
                Config.ConfigWrite(SolutionFullName);

                recentFileList.InsertFile(SolutionFullName);
            }
            else
            {
                if (Utils.SaveFileDialog(out string FileName))
                {
                    SolutionFullName = FileName;
                    recentFileList.InsertFile(SolutionFullName);
                    Config.ConfigWrite(SolutionFullName);

                    if (Config.ConfigRead(SolutionFullName)==0){
                        TreeViewInitialized(SolutionFullName);
                    }
                }
                else
                {
                    SolutionFullName = null;
                }
            }
        }


        private void Config_Set_Click(object sender, RoutedEventArgs e)
        {
            Config.ConfigSet();
        }


        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MenuItem4_Click(object sender, RoutedEventArgs e)
        {


        }
        RecentFileList recentFileList = new RecentFileList();

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            if (recentFileList.RecentFiles.Count > 0)
            {
                string FullName = recentFileList.RecentFiles[0];
                if (File.Exists(FullName))
                {
                    if (Config.ConfigRead(FullName) == 0)
                    {
                        SolutionFullName = FullName;

                        TreeViewInitialized(FullName);
                        Config.ConfigSet();
                    }
                    else
                    {
                        MessageBox.Show("上次打开的项目无效");
                        recentFileList.RemoveFile(FullName);
                    }
                }
                else
                {
                    MessageBox.Show($"找不到{FullName}");
                    recentFileList.RemoveFile(FullName);
                }
            }

        }


        private unsafe void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LambdaControl.Dispatch("VideoTest", this, new Dictionary<string, object>());

            //Process p = new Process();
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //p.StartInfo.FileName = "Global.Reg.exe";
            //p.StartInfo.UseShellExecute = true;
            //p.StartInfo.Verb = "runas";
            //p.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewCreatWindow newCreatWindow = new NewCreatWindow();
            newCreatWindow.Closed += delegate
            {
                if (newCreatWindow.IsCreate)
                {
                    string SolutionDirectoryPath = newCreatWindow.newCreatViewMode.DirectoryPath + "\\" + newCreatWindow.newCreatViewMode.Name;
                    SolutionFullName = SolutionDirectoryPath + "\\" + newCreatWindow.newCreatViewMode.Name + ".gprj";

                    Directory.CreateDirectory(SolutionDirectoryPath + "\\" + "Video");
                    Directory.CreateDirectory(SolutionDirectoryPath + "\\" + "Image");

                    recentFileList.InsertFile(SolutionFullName);
                    Config.ConfigWrite(SolutionFullName);
                    TreeViewInitialized(SolutionFullName,!treeViewSetting.isSupportMultiProject);


                }
            };
            newCreatWindow.ShowDialog();


        }




        private void Close_Click(object sender, RoutedEventArgs e)
        {

            if (treeViewSetting.isSupportMultiProject&&LastSelectedTreeViewItem != null&& LastSelectedTreeViewItem.DataContext is SolutionExplorer solutionExplorer)
            {
                SolutionExplorers.Remove(solutionExplorer);
            }
            else
            {
                if (string.IsNullOrEmpty(SolutionFullName))
                {
                    Config.ConfigWrite(SolutionFullName);
                }
                SolutionFullName = null;
                SolutionExplorers.Clear();
                SolutionTreeView.ItemsSource = null;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            recentFileList.Clear();
        }
    }



}

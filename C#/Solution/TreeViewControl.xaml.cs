using XSolution;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Lambda;
using Tool;
using Solution.RecentFile;
using Global.Common;
using System.Threading.Tasks;
using Microsoft.Win32;
using HotKey;

namespace Solution
{

    /// <summary>
    /// TreeViewControl.xaml 的交互逻辑
    /// </summary>
    public partial class TreeViewControl : UserControl
    {

        public TreeViewControl()
        {
            Window window = Application.Current.MainWindow;
            if (window != null)
                window.Closing += Window_Closed;
            InitializeComponent();
            IniCommand();
            this.DataContext = SolutionConfig.treeViewSetting;
        }

        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel && stackPanel.Parent is Viewbox viewbox)
            {
                IsFirstLoad = false;
                stackPanel.Margin = new Thickness(2, 2, 2, 0);
                viewbox.Width = double.NaN;

               
                //追加在显示的时候显示触发
                LambdaControl.Trigger("UpdateSolutionPath", this, SolutionDir);
                Config.ConfigSet();

                //添加热键
                Application.Current.MainWindow.AddHotKeys(new HotKeys() { FunctionName = "打开", Hotkey = new Hotkey(Key.O, ModifierKeys.Control), hotKeyHandler = OpenSolution });
                Application.Current.MainWindow.AddHotKeys(new HotKeys() { FunctionName = "新建", Hotkey = new Hotkey(Key.N, ModifierKeys.Control), hotKeyHandler = NewCreat });
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
            set { 
                if (value!=null && value!= solutionDir)
                {
                    solutionDir = value;
                    LambdaControl.Trigger("UpdateSolutionPath", this, SolutionDir);
                }
            }
        }

        private string solutionFullName;

        public string SolutionFullName 
        {
            get { return solutionFullName; }
            set {
                if (solutionFullName != value) 
                {
                    solutionFullName = value;
                    SolutionDir =Path.GetDirectoryName(solutionFullName);
                }
                }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (SolutionConfig.treeViewSetting.IsSupportMultiProject && SolutionExplorers.Count > 1)
            {
                MessageBox1.Show(Application.Current.MainWindow,"多工程情况下参数自动保存");
            }
            if (!string.IsNullOrEmpty(SolutionFullName))
            {
                Config.ConfigWrite(SolutionFullName);
            }
        }

        //第一次的点击逻辑
        protected async override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);
            

            SelectPoint = e.GetPosition(SolutionTreeView);
            HitTestResult result = VisualTreeHelper.HitTest(SolutionTreeView, SelectPoint);
            if (result != null)
            {
                TreeViewItem item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);
                if (item == null)
                    return;

                if (SelectedTreeViewItem != null && SelectedTreeViewItem != item && SelectedTreeViewItem.DataContext is BaseObject viewModeBase)
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
                    //这里因为考虑到和lambda接轨，所以暂时不拆出来，合并类和基类的扩展中
                    if (item.DataContext is ProjectFile projectFile1)
                    {
                        LambdaControl.Trigger("projectFile", this, projectFile1.FullName);
                        LambdaControl.Trigger("projectFile1", null);
                    }
                    if (item.DataContext is ProjectFolder projectFolder1)
                    {
                        LambdaControl.Trigger("projectFolder", this, projectFolder1.FullName);
                    }
                    if (item.DataContext is ProjectManager projectMannager1)
                    {
                        LambdaControl.Trigger("projectManager", this, projectMannager1.FullName);
                    }
                    if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                    {
                        LambdaControl.Trigger("CLOSE_OPEN_SERIAL", this, new Dictionary<string, object>() { });
                        await Task.Delay(300);
                        LambdaControl.Trigger("seriesProjectManager", this, seriesProjectManager1.FullName);
                        LambdaControl.Trigger("PREVIEW_CLOSE", this, new Dictionary<string, object>() { });
                        LambdaControl.Trigger("projectFile1", null);
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




        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenSolution();
        }


        private void OpenSolution()
        {
            OpenSolutionWindow openSolutionWindow = new OpenSolutionWindow();
            openSolutionWindow.Closed += (s, e) =>
            {
                if (SolutionConfig.treeViewSetting.IsSupportMultiProject)
                {
                    string FullName = openSolutionWindow.FullName;

                    for (int i = 0; i < SolutionExplorers.Count; i++)
                    {
                        if (SolutionExplorers[i].FullName == FullName)
                        {
                            SolutionExplorers[i].IsExpanded = true;
                            SolutionExplorers[i].IsSelected = true;
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(FullName) && Config.ConfigRead(FullName) == 0)
                    {
                        SolutionFullName = FullName;
                        recentFileList.InsertFile(FullName);
                        TreeViewInitialized(FullName, false);
                        SolutionExplorers[^1].IsExpanded = true;
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
                        SolutionExplorers[0].IsExpanded = true;
                    }
                }

            };
            openSolutionWindow.ShowDialog();
        }



        SolutionExplorer solutionExplorer;

        private void TreeViewInitialized(string FilePath, bool init = true)
        {
            solutionExplorer = new SolutionExplorer(FilePath)
            {
                SolutionName = Path.GetFileNameWithoutExtension(FilePath),
            };
            SolutionDir = Path.GetDirectoryName(FilePath);

            DirectoryInfo root = new DirectoryInfo(SolutionDir);
            var dics = root.GetDirectories();

            foreach (var item in root.GetFiles())
            {
                solutionExplorer.AddChild(SolutionGlobal.GetInstance().GetProjectFile(item.FullName));
            }

            foreach (var dic in dics)
            {
                if (dic.Name == "Video" || dic.Name == "Image")
                {
                    ProjectManager projectMannager = new ProjectManager(dic.FullName) { CanDelete = false, CanReName = false, Visibility = Visibility.Hidden };
                    foreach (var item in dic.GetDirectories())
                    {
                        projectMannager.AddChild(SolutionGlobal.FromDirectories(new ProjectFolder(item.FullName), item));
                    }
                    foreach (var item in dic.GetFiles())
                    {
                        projectMannager.AddChild(SolutionGlobal.GetInstance().GetProjectFile(item.FullName));
                        solutionExplorer.AddChild(SolutionGlobal.GetInstance().GetProjectFile(item.FullName));
                    }
                    solutionExplorer.AddChild(projectMannager);
                }
                else
                {
                    SeriesProjectManager seriesProjectManager = new SeriesProjectManager(dic.FullName);
                    solutionExplorer.AddChild(ADDDerivativeSeriesFile(seriesProjectManager, dic.FullName));
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
                        SolutionExplorers[0].IsExpanded = true;
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
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NewCreat();
        }

        private void NewCreat()
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
                    TreeViewInitialized(SolutionFullName, !SolutionConfig.treeViewSetting.IsSupportMultiProject);
                }
            };
            newCreatWindow.ShowDialog();

        }




        private void Close_Click(object sender, RoutedEventArgs e)
        {

            if (SolutionConfig.treeViewSetting.IsSupportMultiProject && LastSelectedTreeViewItem != null&& LastSelectedTreeViewItem.DataContext is SolutionExplorer solutionExplorer)
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





        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog dialog = new()
            //{
            //    Multiselect = false,//该值确定是否可以选择多个文件
            //    Title = "请选择文件",
            //    RestoreDirectory = true,
            //};
            //if (dialog.ShowDialog() == true)
            //{
            //    string Filename = dialog.FileName;
            //    LambdaControl.Dispatch("LFOCMOpenVideo", this, Filename);
            //}
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }


    }



}

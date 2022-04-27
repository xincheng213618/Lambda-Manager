using Mode;
using NLGSolution;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tool;
using Global;
using Lambda;

namespace WpfApp1
{
    /// <summary>
    /// TreeViewControl.xaml 的交互逻辑
    /// </summary>
    public partial class TreeViewControl : UserControl
    {
        public TreeViewControl()
        {
            Window window = Window.GetWindow(this);
            if (window != null)
                window.Closing += Window_Closed;
            InitializeComponent();
            IniCommand();
        }
        public ObservableCollection<SolutionExplorer> SolutionExplorers = new ObservableCollection<SolutionExplorer>();
        private Point SelectPoint;
        private BaseObject LastReNameObject;

        private void Window_Closed(object sender, EventArgs e)
        {
            if (windowData.FilePath != null)
            {
                windowData.SaveConfig();
            }
        }

        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);

            SelectPoint = e.GetPosition(TreeView1);
            HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
            if (result != null)
            {
                TreeViewItem item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);
                if (item == null)
                    return;

                if (LastReNameObject != null&& LastReNameObject!= item.DataContext)
                {
                    LastReNameObject.IsEditMode = false;
                    LastReNameObject = null;
                }

                if (item.DataContext is ProjectFile projectFile1)
                {
                    LambdaControl.Trigger("projectFile", this, new Dictionary<string, object>() { { "FullPath", projectFile1.FullPath } });
                }
                if (item.DataContext is ProjectFolder projectFolder1)
                {
                    LambdaControl.Trigger("projectFolder", this, new Dictionary<string, object>() { { "FullPath", projectFolder1.FullPath } });
                }
                if (item.DataContext is ProjectMannager projectMannager1)
                {
                    LambdaControl.Trigger("projectMannager", this, new Dictionary<string, object>() { { "FullPath", projectMannager1.FullPath } });
                }
                if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                {
                    LambdaControl.Trigger("seriesProjectManager", this, new Dictionary<string, object>() { { "FullPath", seriesProjectManager1.FullPath } });
                }
            }

            //if (e.ClickCount == 2)
            //{
            //    if (item != null && item.DataContext is ProjectMannager)
            //    {

            //    }

            //    return;
            //}

            //if (e.RightButton == MouseButtonState.Pressed)
            //{
            //    HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
            //}
        }

        private void TreeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeView treeView = sender as TreeView;
            if (treeView.SelectedItem is SolutionLog solutionLog)
            {
                TextBox textBox = new TextBox();
                textBox.Text = File.ReadAllText(solutionLog.FilePath);
                ScrollViewer scrollViewer = new ScrollViewer();
                scrollViewer.Content = textBox;
                scrollViewer.ScrollToEnd();
                Grid grid = new Grid();
                grid.Children.Add(scrollViewer);
                Window window = new Window();
                window.Content = grid;
                window.ShowDialog();
            }
        }


        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is BaseObject baseObject )
            {
                baseObject.IsEditMode = false;
            }



        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is BaseObject baseObject)
            {
                baseObject.Name = tb.Text;
                if (e.Key == Key.Escape)
                {
                    baseObject.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {
                    baseObject.IsEditMode = false;
                }
            }


        }


        WindowData windowData = Global.WindowData.GetInstance();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Tool.Utils.OpenFileDialog(out string FilePath))
            {
                if (windowData.ReadConfig(FilePath) == 0)
                {
                    windowData.FilePath = FilePath;
                    TreeViewInitialized(FilePath, windowData.Config);
                    TreeView1.ItemsSource = SolutionExplorers;
                }

            };
        }


        public ProjectFolder GetFile(ProjectFolder projectFolder, string Path)
        {
            var root = new DirectoryInfo(Path);
            foreach (var item in root.GetDirectories())
            {
                ProjectFolder projectFolder1 = new ProjectFolder(item.FullName);
                projectFolder.AddChild(GetFile(projectFolder1, item.FullName));
            }
            foreach (var item in root.GetFiles())
            {
                ProjectFile projectFile = new ProjectFile(item.FullName);
                projectFolder.AddChild(projectFile);
            }
            return projectFolder;
        }




        private void TreeViewInitialized(string FilePath, Config config)
        {
            SolutionExplorer solutionExplorer = new SolutionExplorer(FilePath)
            {
                SolutionGuid = Guid.NewGuid(),
                SolutionName = System.IO.Path.GetFileNameWithoutExtension(FilePath),
                //SolutionConfig = new SolutionConfig
                //{
                //    FileName = "工程文件.gprj",
                //    FilePath = FilePath
                //},
                //SolutionLog = new SolutionLog
                //{
                //    FileName = "日志.log",
                //    FilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\LambdaManager\\lambda.log"
                //},
            };
            string rootPath = System.IO.Path.GetDirectoryName(FilePath);

            DirectoryInfo root = new DirectoryInfo(rootPath);
            var dics = root.GetDirectories();
            foreach (var dic in dics)
            {
                if (dic.Name == "Video" || dic.Name == "Image")
                {
                    ProjectMannager projectMannager = new ProjectMannager(dic.FullName);
                    foreach (var item in dic.GetDirectories())
                    {
                        ProjectFolder projectFolder = new ProjectFolder(item.FullName);
                        projectMannager.AddChild(GetFile(projectFolder, item.FullName));
                    }
                    foreach (var item in dic.GetFiles())
                    {
                        ProjectFile projectFile = new ProjectFile(item.FullName);
                        projectMannager.AddChild(projectFile);
                    }
                    solutionExplorer.AddChild(projectMannager);
                }
                else
                {
                    SeriesProjectManager seriesProjectManager = new SeriesProjectManager(dic.FullName);
                    solutionExplorer.AddChild(seriesProjectManager);
                }

            }
            SolutionExplorers.Clear();

            SolutionExplorers.Add(solutionExplorer);

            TreeView1.ItemsSource = SolutionExplorers;
        }



        private void UserControl_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (windowData.FilePath != null)
            {
                windowData.SaveConfig();
            }
            else
            {
                if (Tool.Utils.SelectFileDialog(out windowData.FilePath))
                {
                    windowData.SaveConfig();
                    TreeViewInitialized(windowData.FilePath, windowData.Config);
                    TreeView1.ItemsSource = SolutionExplorers;
                }
                else
                {
                    windowData.FilePath = null;
                }


            }
        }


        private void Config_Set_Click(object sender, RoutedEventArgs e)
        {
            windowData.SetValue();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(WindowData.GetInstance().MulDimensional.ToJson());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Global.WindowData.GetInstance().Stage.ToJson());
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(WindowData.GetInstance().ViewMode.ToJson());
        }

        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem4_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

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
using LambdaUtils;
using System.Text.Json;
using System.Windows.Controls.Primitives;
using Global.Extensions;

namespace Solution
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

        private ViewModeBase LastReNameObject;
        private TreeViewItem SelectedTreeViewItem;


        private void Window_Closed(object sender, EventArgs e)
        {
            if (windowData.FilePath != null)
            {
                windowData.SaveConfig();
            }
        }
        private string ToStrings(string value)
        {
            using MemoryStream memoryStream = new MemoryStream();
            using (Utf8JsonWriter writer = new Utf8JsonWriter((Stream)memoryStream, default(JsonWriterOptions)))
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

                if (SelectedTreeViewItem!=null && SelectedTreeViewItem!=item&& SelectedTreeViewItem.DataContext is ViewModeBase viewModeBase)
                {
                    viewModeBase.IsEditMode = false;
                }

                SelectedTreeViewItem = item;


                if (item.DataContext is ProjectFile projectFile1)
                {
                    LambdaControl.Trigger("projectFile", this, ToStrings(projectFile1.FullPath));
                }
                if (item.DataContext is ProjectFolder projectFolder1)
                {                 
                    LambdaControl.Trigger("projectFolder", this, ToStrings(projectFolder1.FullPath));
                }
                if (item.DataContext is ProjectManager projectMannager1)
                {
                    LambdaControl.Trigger("projectManager", this, projectMannager1.FullPath);
                }
                if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                {
                    LambdaControl.Trigger("seriesProjectManager", this, seriesProjectManager1.FullPath);
                }
            }
            else
            {
                SelectedTreeViewItem = null;
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
                textBox.Text = File.ReadAllText(solutionLog.FullPath);
                ScrollViewer scrollViewer = new ScrollViewer();
                scrollViewer.Content = textBox;
                scrollViewer.ScrollToEnd();
                Grid grid = new();
                grid.Children.Add(scrollViewer);
                Window window = new Window();
                window.Content = grid;
                window.ShowDialog();
            }
        }


        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is ViewModeBase baseObject )
            {
                baseObject.IsEditMode = false;
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is ViewModeBase baseObject)
            {
                baseObject.Name = tb.Text;
                if (e.Key == Key.Escape || e.Key == Key.Enter)
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
                SolutionName = System.IO.Path.GetFileNameWithoutExtension(FilePath),
            };
            string rootPath = System.IO.Path.GetDirectoryName(FilePath);

            DirectoryInfo root = new DirectoryInfo(rootPath);
            var dics = root.GetDirectories();
            foreach (var dic in dics)
            {
                if (dic.Name == "Video" || dic.Name == "Image")
                {
                    ProjectManager projectMannager = new ProjectManager(dic.FullName) { CanDelete = false,CanReName = false};
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
            SolutionTreeView.ItemsSource = SolutionExplorers;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (windowData.FilePath != null)
            {
                windowData.SaveConfig();
            }
            else
            {
                if (Tool.Utils.SaveAsDialog(out windowData.FilePath))
                {
                    windowData.SaveConfig();

                    string ImageDiectory = windowData.SolutionDir + "\\Image";
                    string VideoDiectory = windowData.SolutionDir + "\\Video";

                    if (!Directory.Exists(ImageDiectory))
                        Directory.CreateDirectory(ImageDiectory);

                    if (!Directory.Exists(VideoDiectory))
                        Directory.CreateDirectory(VideoDiectory);


                    TreeViewInitialized(windowData.FilePath, windowData.Config);
                    SolutionTreeView.ItemsSource = SolutionExplorers;
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


        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem4_Click(object sender, RoutedEventArgs e)
        {

        }


        private void UserControl_Initialized(object sender, EventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Image image = new Image();
            //View View = new View(image,99);
            //LambdaControl.Trigger("IMAGE_VIEW_CREATED", this, new Dictionary<string, object> { { "view", View.Index } });

            Dictionary<string, object> data = new() { { "exposure", 111.111 } };
            LambdaControl.Dispatch("CAMERA_SETTING_EXPOSURE", this, data);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }
    }

}

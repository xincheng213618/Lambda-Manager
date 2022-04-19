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
            //UniformGrid.DataContext = WindowStatus.GetInstance().MulDimensional;
            //var stage = WindowStatus.GetInstance().STAGE;
        }
        public ObservableCollection<SolutionExplorer> SolutionExplorers = new ObservableCollection<SolutionExplorer>();
        private Point SelectPoint;
        private TreeViewItem LastSelectItem;

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
            if (LastSelectItem != null)
            {
                HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
                if (result != null)
                {
                    TreeViewItem item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);
                    if (item != null)
                    {
                        if (LastSelectItem != item)
                        {
                            if (LastSelectItem.DataContext is ProjectFile projectFile)
                                projectFile.IsEditMode = false;
                            else if (LastSelectItem.DataContext is ProjectFolder projectFolder)
                                projectFolder.IsEditMode = false;
                            else if (LastSelectItem.DataContext is ProjectMannager projectMannager)
                                projectMannager.IsEditMode = false;
                            LastSelectItem = null;
                        }

                    }
                }
            }

            //if (e.RightButton == MouseButtonState.Pressed)
            //{
            //    if (item != null)
            //        item.IsSelected = true;
            //}

            //if (e.ClickCount == 2)
            //{

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
            if (tb.Tag is ProjectFile projectFile)
            {
                projectFile.IsEditMode = false;
            }
            else if (tb.Tag is ProjectFolder projectFolder)
            {
                projectFolder.IsEditMode = false;
            }
            else if (tb.Tag is ProjectMannager projectMannager)
            {
                projectMannager.IsEditMode = true;
            }


        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Tag is ProjectFile projectFile)
            {
                projectFile.Name = tb.Text;
                if (e.Key == Key.Escape)
                {
                    projectFile.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {

                    projectFile.IsEditMode = false;
                }
            }
            else if (tb.Tag is ProjectFolder projectFolder)
            {
                projectFolder.Name = tb.Text;
                if (e.Key == Key.Escape)
                {
                    projectFolder.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {

                    projectFolder.IsEditMode = false;
                }
            }
            else if (tb.Tag is ProjectMannager projectMannager)
            {
                projectMannager.Name = tb.Text;
                if (e.Key == Key.Escape)
                {
                    projectMannager.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {

                    projectMannager.IsEditMode = false;
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
                ProjectFolder projectFolder1 = new ProjectFolder()
                {
                    Name = item.Name,
                    FilePath = item.FullName,
                };
                projectFolder.AddChild(GetFile(projectFolder1, item.FullName));
            }
            foreach (var item in root.GetFiles())
            {
                ProjectFile projectFile = new ProjectFile()
                {
                    Name = item.Name,
                    FilePath = item.FullName,
                };
                projectFolder.AddChild(projectFile);
            }
            return projectFolder;
        }




        private void TreeViewInitialized(string FilePath, Config config)
        {
            SolutionExplorer solutionExplorer = new SolutionExplorer()
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
                ProjectMannager projectMannager = new ProjectMannager()
                {
                    Name = dic.Name,
                    FilePath = dic.FullName,
                };
                foreach (var item in dic.GetDirectories())
                {
                    ProjectFolder projectFolder = new ProjectFolder()
                    {
                        Name = item.Name,
                        FilePath = item.FullName,
                    };
                    projectMannager.AddChild(GetFile(projectFolder, item.FullName));
                }
                foreach (var item in dic.GetFiles())
                {
                    ProjectFile projectFile = new ProjectFile()
                    {
                        Name = item.Name,
                        FilePath = item.FullName,
                    };
                    projectMannager.AddChilds(projectFile);
                }
                projectMannager.AddChildsEnd();
                solutionExplorer.AddChild(projectMannager);
            }
            SolutionExplorers.Clear();
            SolutionExplorers.Add(solutionExplorer);
            TreeView1.ItemsSource = SolutionExplorers;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowData windowStatus = Global.WindowData.GetInstance();

            MessageBox.Show(windowStatus.MulDimensional.ToJson());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Global.WindowData.GetInstance().Stage.ToJson());
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

        private void UpdateMul_Click(object sender, RoutedEventArgs e)
        {
            Update.UpdateMulDimensional(Global.WindowData.GetInstance().MulDimensional);
        }

        private void Config_Set_Click(object sender, RoutedEventArgs e)
        {
            windowData.SetValue();
        }
    }
}

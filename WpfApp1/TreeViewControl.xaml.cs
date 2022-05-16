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
        private BaseObject LastReNameObject;
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
                SelectedTreeViewItem = item;
                if (item == null)
                    return;

                if (LastReNameObject != null&& LastReNameObject!= item.DataContext)
                {
                    LastReNameObject.IsEditMode = false;
                    LastReNameObject = null;
                }

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
                    LambdaControl.Trigger("projectManager", this, ToStrings(projectMannager1.FullPath));
                }
                if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                {
                    LambdaControl.Trigger("seriesProjectManager", this, ToStrings(seriesProjectManager1.FullPath));
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
                    ProjectManager projectMannager = new ProjectManager(dic.FullName) { CanDelete =false,CanReName=false};
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
                if (Tool.Utils.SelectFileDialog(out windowData.FilePath))
                {
                    windowData.SaveConfig();
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



        private void Test_Click(object sender, RoutedEventArgs e)
        {

        }


        private MenuItem MenuItemAdd(MenuItem MenuItem,int a)
        {
            EventArgs e =new EventArgs();
            MenuItem1 menuItem1 = new MenuItem1() { Header = "明场" };
            menuItem1.IsChecked = true;

            menuItem1.Click += delegate
            {
                menuItem1.IsChecked = true;
                LambdaControl.Trigger($"QUATER_CLICKED{a}1", this, e);
            };
            MenuItem1 menuItem2 = new MenuItem1() { Header = "暗场" };
            menuItem2.Click += delegate
            {
                menuItem2.IsChecked = true;
                LambdaControl.Trigger($"QUATER_CLICKED{a}2", this, e);
            };

            MenuItem1 menuItem3 = new MenuItem1() { Header = "莱茵伯格" };
            menuItem3.Click += delegate
            {
                menuItem3.IsChecked = true;
                LambdaControl.Trigger($"QUATER_CLICKED{a}3", this, e);
            };
            MenuItem1 menuItem4 = new MenuItem1() { Header = "相差" };
            menuItem4.Click += delegate
            {
                menuItem4.IsChecked = true;
                LambdaControl.Trigger($"QUATER_CLICKED{a}4", this, e);
            };
            MenuItem1 menuItem5 = new MenuItem1() { Header = "差分" };
            menuItem5.Click += delegate
            {
                menuItem5.IsChecked = true;
                LambdaControl.Trigger($"QUATER_CLICKED{a}5", this, e);
            };
            MenuItem1 menuItem6 = new MenuItem1() { Header = "定量相位" };
            menuItem6.Click += delegate
            {
                menuItem6.IsChecked = true;
                LambdaControl.Trigger($"QUATER_CLICKED{a}6", this, e);
            };
            MenuItem.Items.Add(menuItem1);
            MenuItem.Items.Add(menuItem2);
            MenuItem.Items.Add(menuItem3);
            MenuItem.Items.Add(menuItem4);
            MenuItem.Items.Add(menuItem5);
            MenuItem.Items.Add(menuItem6);
            return MenuItem;
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
           
            Window mainwin = Application.Current.MainWindow;
            try
            {
                WrapPanel WrapPanel1 = (WrapPanel)mainwin.FindName("eval_aj");
                if (WrapPanel1 ==null)
                    WrapPanel1 = (WrapPanel)mainwin.FindName("rightToolbar");
                ToggleButton buttton1 = (ToggleButton)WrapPanel1.Children[0];

                ContextMenu contextMenu = new ContextMenu();
                contextMenu.DataContext = windowData.ViewWindow;
                MenuItem menuItem1 = new MenuItem() { Header = "左上窗口" };
                menuItem1.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED1", sender, e);
                };
                MenuItem menuItem2 = new MenuItem() { Header = "左下窗口" };
                menuItem2.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED2", sender, e);
                };

                MenuItem menuItem3 = new MenuItem() { Header = "右上窗口" };
                menuItem3.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED3", sender, e);
                };
                MenuItem menuItem4 = new MenuItem() { Header = "右下窗口" };
                menuItem4.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED4", sender, e);
                };
                MenuItem menuItem5 = new MenuItem() { Header = "右上扩展窗口" };
                menuItem5.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED5", sender, e);
                };
                MenuItem menuItem6 = new MenuItem() { Header = "右下扩展窗口" };
                menuItem6.Click += delegate
                {
                    LambdaControl.Trigger("QUATER_CLICKED6", sender, e);
                };
                contextMenu.Items.Add(MenuItemAdd(menuItem1, 1));
                contextMenu.Items.Add(MenuItemAdd(menuItem2, 2));
                contextMenu.Items.Add(MenuItemAdd(menuItem3, 3));
                contextMenu.Items.Add(MenuItemAdd(menuItem4, 4));
                contextMenu.Items.Add(MenuItemAdd(menuItem5, 5));
                contextMenu.Items.Add(MenuItemAdd(menuItem6, 6));
                Binding myBinding = new Binding("IsFourWindowVisibility");
                menuItem6.SetBinding(VisibilityProperty, myBinding);
                menuItem5.SetBinding(VisibilityProperty, myBinding);
                buttton1.ContextMenu = contextMenu;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            windowData.ViewWindow.IsFourWindow = !windowData.ViewWindow.IsFourWindow;
            if (windowData.ViewWindow.IsFourWindowVisibility == Visibility.Visible)
            {
                windowData.ViewWindow.IsFourWindowVisibility = Visibility.Collapsed;
                button.Content = "六";
            }
            else
            {
                windowData.ViewWindow.IsFourWindowVisibility = Visibility.Visible;
                button.Content = "四";

            }


        }
    }
    public class MenuItem1 : MenuItem
    {
        public MenuItem1()
        {
            this.Checked += Checked1;
        }
        private void Checked1(object sender, RoutedEventArgs e)
        {
            if ( this.Parent is MenuItem menuItem)
            {
                foreach (var item in menuItem.Items)
                {
                    if (item!=this && item is MenuItem menu)
                    {
                        if (menu.IsChecked ==true)
                            menu.IsChecked = false;

                    }
                }
            }
        }
    }
}

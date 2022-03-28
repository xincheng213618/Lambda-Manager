using MenuISCameraSetting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Solution;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //AddNewProject.InputGestures.Add(gesture);
            IniCommand();
        }
        private void IniCommand()
        {
            //Commands.ReName.InputGestures.Add(new KeyGesture(Key.M, (ModifierKeys.Control), "F2"));
            CommandBindings.Add(new CommandBinding(AddNewProject, this.AddNewProject_Executed, this.AddNewProject_CanExecute));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Copy, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Delete, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Delete, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(Commands.ReName, this.ExecutedCommand, this.CanExecuteCommand));
        }

        #region 通用命令执行函数

        private void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {

            if (e.Command == ApplicationCommands.SelectAll)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Copy)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Cut)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Paste)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Delete)
            {
                e.CanExecute = true;
            }
            else if (e.Command == Commands.ReName)
            {
                e.CanExecute = true;
            }
        }



        private void ExecutedCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Copy)
            {
                //this.DoCopy();
            }
            else if (e.Command == ApplicationCommands.Cut)
            {
                //this.DoCut();
            }
            else if (e.Command == ApplicationCommands.Paste)
            {
                //this.DoPaste();
            }
            else if (e.Command == ApplicationCommands.Delete)
            {

            }
            else if (e.Command == Commands.ReName)
            {
                if (e.Parameter != null)
                {
                    if (e.Parameter is ProjectFile projectFile)
                        projectFile.IsEditMode = true;
                    else if (e.Parameter is ProjectFolder projectFolder)
                        projectFolder.IsEditMode = true;
                    else if (e.Parameter is ProjectMannager projectMannager)
                        projectMannager.IsEditMode = true;  
                }
                else
                {
                    HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
                    if (result != null)
                    {
                        TreeViewItem item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);
                        if (item.DataContext is ProjectFile projectFile)
                            projectFile.IsEditMode = true;
                        else if (item.DataContext is ProjectFolder projectFolder)
                            projectFolder.IsEditMode = true;
                        else if (item.DataContext is ProjectMannager projectMannager)
                            projectMannager.IsEditMode = true;
                    }

                }
            }
            else
            {

            }

        }



        #endregion

        public bool DoDelete(bool alert)
        {
            if (alert)
            {
                if (MessageBox.Show("dddddddd","2222222" ,MessageBoxButton.OKCancel, MessageBoxImage.Asterisk) != MessageBoxResult.OK)
                    return false;
            }

            //if (!(this.Parent as ProjectFolder).RemoveChild(this))
            //    return false;

            //if (File.Exists(this.FullName))
            //{
            //    return FileName.DeleteToRecycleBin(this.FullName);
            //}

            return false;
        }



        private void AddNewProject_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AddNewProject_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ProjectMannager projectMannager = new ProjectMannager()
            {
                Name = "新建工程1"
            };
            SolutionExplorers[0].AddChild(projectMannager);
        }

        public static RoutedCommand NewProject = new RoutedCommand();
        KeyGesture gesture = new KeyGesture(Key.N, ModifierKeys.Control, "Control+N");
        public static RoutedCommand OpenProject = new RoutedCommand();
        public static RoutedCommand AddNewProject = new RoutedCommand();
        public static RoutedCommand AddExistingProject = new RoutedCommand();
        public static RoutedCommand CloseSolution = new RoutedCommand();
        public static RoutedCommand Exit = new RoutedCommand();
        public static RoutedCommand OpenLocalFolder = new RoutedCommand();




        private void Window_Initialized(object sender, EventArgs e)
        {
            this.leftView.Children.Clear();
            List<UICofig> list = new List<UICofig>();

            list.Add(new UICofig() { path = "ConfigObjective.dll", name = "Magnification" });
            ////list.Add(new UICofig() { path = "ConfigFocus.dll", name = "FocusMode" });
            //list.Add(new UICofig() { path = "ConfigDPCMode.dll", name = "DPCMode" });
            //list.Add(new UICofig() { path = "ConfigDeck.dll", name = "BaseDeck" });
            //list.Add(new UICofig() { path = "ConfigSpot.dll", name = "SampleSpot" });
            //list.Add(new UICofig() { path = "ConfigDOFMode.dll", name = "DOFMode" });
            //list.Add(new UICofig() { path = "ConfigCollectInterval.dll", name = "CollectInterval" });

            foreach (var item in list)
            {
                Assembly assembly = Assembly.LoadFile(Environment.CurrentDirectory + "\\" + item.path);
                Control control = (Control)assembly.CreateInstance($"{item.path.Replace(".dll", "")}.{item.name}");
                leftView.Children.Add(control);
            }

            SolutionExplorers = new ObservableCollection<SolutionExplorer>()
                {
                    new SolutionExplorer()
                    {
                        SolutionGuid = Guid.NewGuid(),
                        SolutionName ="人体细胞工程",
                        SolutionConfig =  new SolutionConfig
                        {
                            FileName ="工程文件.gprj",
                            FilePath ="dddddddd"
                        },
                        SolutionLog = new SolutionLog
                        {
                            FileName ="工程文件.log",
                            FilePath =Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\LambdaManager\\lambda.log"
                        },
                        ProjectMannagers = new ObservableCollection<ProjectMannager>
                        {
                            new ProjectMannager()
                            {
                                Name ="Image",
                                ProjectFiles = new ObservableCollection<ProjectFile>
                                {
                                    new ProjectFile()
                                    {
                                        Name ="1.png",
                                        FilePath =@"C:\Users\Chen\Documents\NLG\",
                                    },
                                    new ProjectFile()
                                    {
                                        Name ="2.png",
                                        FilePath ="22222",
                                    },
                                }

                            },

                            new ProjectMannager()
                            {
                                Name ="Serial",

                                ProjectFiles = new ObservableCollection<ProjectFile>
                                {
                                    new ProjectFile()
                                    {
                                        Name ="1.png",
                                        FilePath =@"C:\Users\Chen\Documents\NLG\",
                                    },
                                },
                                ProjectFolders = new ObservableCollection<ProjectFolder>
                                {
                                    new ProjectFolder()
                                    {
                                        Name ="测试1",
                                        ProjectFolders = new ObservableCollection<ProjectFolder>()
                                        {
                                            new ProjectFolder()
                                            {
                                              Name ="测试2",
                                              ProjectFiles = new ObservableCollection<ProjectFile>()
                                              {
                                                  new ProjectFile()
                                                  {
                                                      Name ="2222ssdsadsad.png",
                                                      FilePath =@"C:\Users\Chen\Documents\NLG\",
                                                  },
                                              }
                                            }
                                        },
                                        ProjectFiles = new ObservableCollection<ProjectFile>
                                        {
                                            new ProjectFile()
                                            {
                                                Name ="asdsadsadas.ssss",
                                                FilePath =@"C:\Users\Chen\Documents\NLG\",
                                            },
                                            new ProjectFile()
                                            {
                                                Name ="sadasdasd.jpg",
                                                FilePath =@"C:\Users\Chen\Documents\NLG\",
                                            },
                                        },
                                    }
                                }


                            }


                        }
                    },
                };

            TreeView1.ItemsSource = SolutionExplorers;
        }
        public ObservableCollection<SolutionExplorer> SolutionExplorers =new ObservableCollection<SolutionExplorer>();

        private Point SelectPoint;
        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);

            SelectPoint = e.GetPosition(TreeView1);
            HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
            TreeViewItem item = null;
            if (result != null)
                item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);

            if (e.RightButton == MouseButtonState.Pressed)
            {
                if (item != null)
                    item.IsSelected = true;
            }

            if (e.ClickCount == 2)
            {
                if (item != null && item.DataContext is ProjectMannager)
                {

                }

                return;
            }
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
            //if (treeView.SelectedItem is ProjectFile projectFile)
            //{
            //    MessageBox.Show(projectFile.FilePath);
            //}
            //if (treeView.SelectedItem is ProjectFolder projectFolder)
            //{
            //    //MessageBox.Show(projectFolder.FolderName);
            //}

        }


        private void MenuItem1_Click(object sender, RoutedEventArgs e)
        {
            if (TreeView1.SelectedItem is ProjectMannager projectMannager)
            {
                ProjectFile projectFile = new ProjectFile()
                {
                    Name = "新建文件"
                };
                projectMannager.AddChild(projectFile);
            }
        }

        private void MenuItem2_Click(object sender, RoutedEventArgs e)
        {
            if (TreeView1.SelectedItem is ProjectMannager projectMannager)
            {
                ProjectFolder projectFolder = new ProjectFolder()
                {
                    Name = "新建文件夹"
                };
                projectMannager.AddChild(projectFolder);
            }
        }

        private void MenuItem3_Click(object sender, RoutedEventArgs e)
        {
            if (TreeView1.SelectedItem is ProjectFolder projectFolder)
            {
                ProjectFile projectFile = new ProjectFile()
                {
                    Name = "新建文件"
                };
                projectFolder.AddChild(projectFile);
            }
        }

        private void MenuItem4_Click(object sender, RoutedEventArgs e)
        {
            if (TreeView1.SelectedItem is ProjectFolder projectFolder)
            {
                ProjectFolder projectFolder1 = new ProjectFolder()
                {
                    Name = "新建文件夹"
                };
                projectFolder.AddChild(projectFolder1);
            }

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Tag is ProjectFile projectFile)
            {
                projectFile.Name = tb.Text;
                projectFile.IsEditMode = false;
            }else if (tb.Tag is ProjectFolder projectFolder)
            {
                projectFolder.Name = tb.Text;
                projectFolder.IsEditMode = false;
            }
            else if (tb.Tag is ProjectMannager projectMannager)
            {
                projectMannager.Name = tb.Text;

                projectMannager.IsEditMode = true;

            }


        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (tb.Tag is ProjectFile projectFile)
            {
                if (e.Key == Key.Escape)
                {
                    projectFile.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {

                    projectFile.Name = tb.Text;
                    projectFile.IsEditMode = false;
                }
            }
            else if (tb.Tag is ProjectFolder projectFolder)
            {
                if (e.Key == Key.Escape)
                {
                    projectFolder.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {

                    projectFolder.Name = tb.Text;
                    projectFolder.IsEditMode = false;
                }
            }
            else if (tb.Tag is ProjectMannager projectMannager)
            {
                if (e.Key == Key.Escape)
                {
                    projectMannager.IsEditMode = false;
                }
                else if (e.Key == Key.Enter)
                {

                    projectMannager.Name = tb.Text;
                    projectMannager.IsEditMode = false;
                }

            }

        }

    }

    public class ViewHelper
    {
        /// <summary>
        /// 通过给定的依赖对象，在控件树中向上查找指定类型的控件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T FindVisualParent<T>(DependencyObject obj) where T : class
        {
            while (obj != null)
            {
                if (obj is T)
                    return obj as T;

                obj = VisualTreeHelper.GetParent(obj);
            }

            return null;
        }

        /// <summary>
        /// 在给定的空间中，查找给定坐标点的给定类型的控件
        /// </summary>
        public static T HitTestView<T>(Visual visual, Point pos) where T : class
        {
            HitTestResult result = VisualTreeHelper.HitTest(visual, pos);
            if (result == null)
                return null;
            DependencyObject obj = result.VisualHit;

            return FindVisualParent<T>(obj);
        }
    }

    public class UICofig
    {
        public string path = "";
        public string name = "";   
    }
}

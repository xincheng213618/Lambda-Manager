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
            WindowStatus windowStatus = WindowStatus.GetInstance();
            if (windowStatus.FilePath != null)
            {
                Global.Utils.ToJsonFile(windowStatus.Config, windowStatus.FilePath);
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

        public int LoadConfig(string ConfigFileName, ref Config config)
        {
            Window window = Window.GetWindow(this);
            if (window != null)
                window.Closing += Window_Closed;

            //载入配置文件 
            string result = Global.Utils.LoadResource(ConfigFileName);
            if (!Global.Utils.IsNullOrEmpty(result))
            {
                if (File.Exists(ConfigFileName))
                {
                    config = Global.Utils.FromJson<Config>(result);
                    if (config == null)
                    {
                        MessageBox.Show("配置文件加载失败");
                        return 0;
                    }
                    
                }
            }
            if (config == null)
            {
                config = ConfigInitialized();
            }
            return 0;
        }


        private Config ConfigInitialized()
        {
            return new Config
            {
                Hotkey = new Hotkey(Key.K, ModifierKeys.Shift | ModifierKeys.Windows),
                Version = "1.0",
                Modules = new Modules
                {
                    LambdaManager = "1.0",
                    ConfigDpcMode = "1.0",
                    ConfigStage = "1.0",
                    ConfigSpot = "1.0",
                    ConfigDof = "1.0",
                    ConfigMultiDimensional = "1.0",
                    DpcAlgorithm = "1.0",
                },
                LambdaManager = new LambdaManager
                {
                    LatestClosed = new List<string>()
                        {
                            "C:\\Program Files\\NJUST-SCIL\\Lambda Manager\\Data\\上皮细胞观察组1.lmp",
                            "D:\\Data\\Images\\picture2.jpg"
                        },
                    DefaultDirectory = "D:\\Data\\",
                },

                FirmwareSetting = new FirmwareSetting
                {
                    ObjectiveSetting = new Mode.ObjectiveSetting
                    {
                        Magnitude = 20,
                        NA = 1.23
                    },
                    CameraSetting = new CameraSetting
                    {
                        VideoFormat = "RGB (1280*960)",
                        Fps = 15,
                        Brightness = 0,
                        Contrast = 0,
                        Hue = 0,
                        Saturation = 0,
                        Sharpness = 0,
                        Gamma = 1,
                        WhiteBalance = new WhiteBalance
                        {
                            Auto = false,
                            Mode = 0,
                            WhiteBalanceGreen = 64,
                            WhiteBalanceBlue = 77,
                            WhiteBalanceRed = 91,
                        },
                        gain = new Gain
                        {
                            Auto = false,
                            Value = 0.0,
                        },
                        Exposure = new Exposure
                        {
                            Auto = false,
                            Value = 0.0667,
                            AutoMax = 1,
                            AutoReference = 128,
                        },
                        Trigger = new Mode.Trigger
                        {
                            Enable = true,
                            Polarity = false,
                            Delay = 15.0
                        },
                        Denoise = false,
                        Strobe = false,
                        Source = new Source
                        {
                            FpgaVersion = 0.1,
                            MaxBright = 32,
                        }
                    }
                },
                LogFile = "D:\\Data\\上皮细胞观察组1.log",
            };

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var global = WindowStatus.GetInstance();
            if (Tool.Utils.OpenFileDialog(out string FilePath))
            {
                if (LoadConfig(FilePath, ref global.Config) == 0)
                {
                    global.FilePath = FilePath;
                    TreeViewInitialized(FilePath, global.Config);
                }
            };
            TreeView1.ItemsSource = SolutionExplorers;
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
            WindowStatus windowStatus = WindowStatus.GetInstance();

            MessageBox.Show(windowStatus.MulDimensional.ToJson());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(WindowStatus.GetInstance().STAGE.ToJson());
        }

        private void UserControl_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            WindowStatus windowStatus = WindowStatus.GetInstance();
            if (windowStatus.FilePath != null)
            {
                Global.Utils.ToJsonFile(windowStatus.Config, windowStatus.FilePath);
            }
        }

        private void UpdateMul_Click(object sender, RoutedEventArgs e)
        {
            Update.UpdateMulDimensional(WindowStatus.GetInstance().MulDimensional);
        }
    }
}

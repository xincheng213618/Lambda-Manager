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
using Global.Common;
using System.Threading.Tasks;
using HotKey;
using Global.SettingUp;
using System.Windows.Data;
using System.Linq;
using Global.RecentFile;
using ThemeManager.Controls;
using System.Net.Http;
using System.Net.NetworkInformation;
using Microsoft.Win32;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;
using System.Text;

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
            this.DataContext = SoftwareConfig.SolutionSetting;
        }

        private void AddMenu()
        {
            if (Application.Current.MainWindow.FindName("menu") is Menu menu)
            {
                MenuItem FileMenuItem = null;
                foreach (var item in menu.Items.Cast<MenuItem>().ToList())
                {
                    if (item.Header.ToString().Contains("文件"))
                    {
                        FileMenuItem = item;
                        menu.Items.Remove(item);
                        break;
                    }
                };
                FileMenuItem ??= new MenuItem();
                FileMenuItem.Header = "文件(_F)";
                menu.Items.Insert(0, FileMenuItem);

                MenuItem CloseMenuItem = new MenuItem() { Header = "退出(_X)" };
                CloseMenuItem.InputGestureText = "Alt + F4";
                CloseMenuItem.Click += (s, e) =>
                {
                    Application.Current.MainWindow.Close();
                };
                FileMenuItem.Items.Insert(FileMenuItem.Items.Count, CloseMenuItem);

                MenuItem RecentListMenuItem = null;

                foreach (var item in FileMenuItem.Items.Cast<MenuItem>().ToList())
                {
                    if (item.Header.ToString().Contains("最近使用过的工程文件"))
                    {
                        RecentListMenuItem = item;
                        FileMenuItem.Items.Remove(item);
                        break;
                    }
                };


                RecentListMenuItem ??= new MenuItem();
                RecentListMenuItem.Header = "最近使用过的文件(_F)";
                FileMenuItem.Items.Insert(FileMenuItem.Items.Count - 1, RecentListMenuItem);

                RecentListMenuItem.SubmenuOpened += (s, e) =>
                {
                    RecentListMenuItem.Items.Clear();
                    foreach (var item in recentFileList.RecentFiles)
                    {
                        MenuItem menuItem = new MenuItem();
                        menuItem.Header = item;
                        menuItem.Click += (sender, e) =>
                        {
                            this.OpenSolution(item);
                        };
                        RecentListMenuItem.Items.Add(menuItem);
                    }
                };

                RecentListMenuItem.Items.Clear();
                foreach (var item in recentFileList.RecentFiles)
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.Header = item;
                    menuItem.Click += (sender, e) =>
                    {
                        this.OpenSolution(item);
                    };
                    RecentListMenuItem.Items.Add(menuItem);
                }
            }

        }


        private void TreeViewControl_Drop(object sender, DragEventArgs e)
        {
            var b = e.Data.GetDataPresent(DataFormats.FileDrop);

            if (b)
            {
                var sarr = e.Data.GetData(DataFormats.FileDrop);
                var a = sarr as string[];
                var fn = a.First();

                if (File.Exists(fn))
                {
                    if (fn.Contains(".gprj"))
                    {
                        OpenSolution(fn);
                    }
                    else
                    {
                        MessageBox.Show("文件的格式不受支持");
                    }
                }
                else if (Directory.Exists(fn))
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(fn);
                    foreach (var item in directoryInfo.GetFiles())
                    {
                        if (item.Extension==".gprj")
                        {
                            OpenSolution(item.FullName);
                            break;
                        }
                    }
                }
            }
        }


        private bool OpenSolution(string FullName)
        {
            bool sucess = false;
            if (SoftwareConfig.SolutionSetting.IsSupportMultiProject)
            {
                for (int i = 0; i < SolutionExplorers.Count; i++)
                {
                    if (SolutionExplorers[i].FullName == FullName)
                    {
                        SolutionExplorers[i].IsExpanded = true;
                        SolutionExplorers[i].IsSelected = true;
                        return true;
                    }
                }

                if (!string.IsNullOrEmpty(FullName) && Config.ConfigRead(FullName) == 0)
                {
                    SolutionFullName = FullName;
                    recentFileList.InsertFile(FullName);
                    TreeViewInitialized(FullName, false);
                    SolutionExplorers[^1].IsExpanded = true;
                    sucess = true;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(FullName) && Config.ConfigRead(FullName) == 0)
                {
                    SolutionFullName = FullName;
                    recentFileList.InsertFile(FullName);
                    TreeViewInitialized(FullName);
                    SolutionExplorers[0].IsExpanded = true;
                    sucess = true;
                }
            }
            return sucess;
        }



        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel && stackPanel.Parent is Viewbox viewbox && viewbox.Parent is ScrollViewer scrollViewer &&scrollViewer.Parent is TabItem tabItem)
            {
                AddMenu();
                tabItem.AllowDrop = true;
                tabItem.Drop += TreeViewControl_Drop;

                HeaderStackPanel.Children.Remove(SoulutionButtonPanel1);
                Grid grid = new Grid();
                tabItem.Content = grid;
                grid.Children.Add(scrollViewer);


                Viewbox viewbox1 = new Viewbox() { Child = SoulutionButtonPanel1,VerticalAlignment =VerticalAlignment.Top,HorizontalAlignment =HorizontalAlignment.Left };
                viewbox1.SetBinding(Viewbox.HeightProperty, new Binding() { Source = viewbox, Path = new PropertyPath("ActualHeight") });
                viewbox1.SetBinding(Viewbox.WidthProperty, new Binding() { Source = viewbox, Path = new PropertyPath("ActualWidth") });

                grid.Children.Add(viewbox1);

                IsFirstLoad = false;
                stackPanel.Margin = new Thickness(2, 2, 2, 0);
                viewbox.Width = double.NaN;

                //追加在显示的时候显示触发
                LambdaControl.Trigger("UpdateSolutionPath", this, SolutionDir);
                Config.ConfigSet();

                //添加热键
                Application.Current.MainWindow.AddHotKeys(new HotKeys() { FunctionName = "打开当前工程", Hotkey = new Hotkey(Key.O, ModifierKeys.Control), Kinds = HotKeyKinds.Windows, hotKeyHandler = OpenSolution });
                Application.Current.MainWindow.AddHotKeys(new HotKeys() { FunctionName = "新建工程", Hotkey = new Hotkey(Key.N, ModifierKeys.Control), Kinds = HotKeyKinds.Windows, hotKeyHandler = NewCreat });
                Application.Current.MainWindow.AddHotKeys(new HotKeys() { FunctionName = "关闭当前工程", Hotkey = new Hotkey(Key.W, ModifierKeys.Control), Kinds =HotKeyKinds.Windows,hotKeyHandler = SolutionClose });
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
            if (SoftwareConfig.SolutionSetting.IsSupportMultiProject && SolutionExplorers.Count > 1)
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
                    if (item.DataContext is GrifFile grifFile)
                    {
                        grifFile.OpenFileCommand.Execute(grifFile);
                    }
                    else if (item.DataContext is ProjectFile projectFile1)
                    {
                        LambdaControl.Trigger("SolutionpProjectFileOpen", this, projectFile1.FullName);
                    }
                    if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                    {
                        LambdaControl.Trigger("CLOSE_OPEN_SERIAL", this, new Dictionary<string, object>() { });
                        await Task.Delay(300);
                        LambdaControl.Trigger("seriesProjectManager", this, seriesProjectManager1.FullName);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenSolution();
        }


        private void OpenSolution()
        {
            OpenSolutionWindow openSolutionWindow = new OpenSolutionWindow();
            openSolutionWindow.Closed += (s, e) =>
            {
                if (SoftwareConfig.SolutionSetting.IsSupportMultiProject)
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




        private void TreeViewInitialized(string FilePath, bool init = true)
        {
            SolutionExplorer solutionExplorer = new SolutionExplorer(FilePath);
           
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

        RecentFileList recentFileList = new RecentFileList() { Persister = new RegistryPersister("Software\\Grid\\SolutionHistory") };

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
                TreeViewInitialized(SolutionFullName, !SoftwareConfig.SolutionSetting.IsSupportMultiProject);
                }
            };
            newCreatWindow.ShowDialog();

        }


        private void Close_Click(object sender, RoutedEventArgs e)
        {
            SolutionClose();
        }
        private void SolutionClose()
        {
            if (SoftwareConfig.SolutionSetting.IsSupportMultiProject && LastSelectedTreeViewItem != null && LastSelectedTreeViewItem.DataContext is SolutionExplorer solutionExplorer)
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

        private unsafe void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.Growl.Info("此功能在测试中");
            LambdaControl.Dispatch("VideoTest", this, new Dictionary<string, object>());
        }
        int zzz = 0;

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.Growl.Info("此功能还在开发中，暂停使用");

            HotKeyManger hotKeyManger = new HotKeyManger();
            hotKeyManger.Show();


            //int port = 53618;
            //IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, port);
            //Socket sssss = new Socket(IPAddress.Loopback.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //zzz++;
            //try
            //{
            //    sssss.Connect(localEndPoint);
            //    string aaa = zzz%2==0?"0":"1";
            //    sssss.Send(Encoding.UTF8.GetBytes(aaa));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //sssss.Close();
            //string Arguments = string.Empty;
            //if (Environment.OSVersion.Version.Major == 6)
            //{
            //    Arguments = "/c gpupdate /force /wait:0 && ie4uinit.exe -ClearIconCache";
            //    Arguments = "/c gpupdate /force /wait:0 && ie4uinit.exe -ClearIconCache";


            //}
            //else if (Environment.OSVersion.Version.Major > 6)
            //{
            //    Arguments = "/c ie4uinit.exe -show";
            //}
            //ProcessStartInfo info = new ProcessStartInfo
            //{
            //    WindowStyle = ProcessWindowStyle.Hidden,
            //    UseShellExecute = false,
            //    FileName = "cmd.exe",
            //    CreateNoWindow = true,
            //    RedirectStandardOutput = true,
            //    Arguments = Arguments
            //};
            //Process process = Process.Start(info);
            //process.WaitForExit();

        }

        private void  Button_Click_5(object sender, RoutedEventArgs e)
        {
            HandyControl.Controls.Growl.Info("此功能在测试中");
        }



    }



}

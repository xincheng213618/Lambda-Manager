using Mode;
using NLGSolution;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Global;
using Lambda;
using System.Text.Json;
using Tool;
using System.Windows.Controls.Primitives;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;

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

        public string SolutionDir = null;

        private void Window_Closed(object sender, EventArgs e)
        {
            if (windowData.FilePath != null)
            {
                windowData.SaveConfig();
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

                if (SelectedTreeViewItem != null && SelectedTreeViewItem != item && SelectedTreeViewItem.DataContext is NLGSolution.BaseObject viewModeBase)
                {
                    viewModeBase.IsEditMode = false;
                }
                SelectedTreeViewItem = item;

                if (e.ClickCount == 2)
                {
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
                        LambdaControl.Trigger("projectManager", this, new Dictionary<string, object> { { "FullPath", ToStrings(projectMannager1.FullPath) } });
                    }
                    if (item.DataContext is SeriesProjectManager seriesProjectManager1)
                    {
                        LambdaControl.Trigger("seriesProjectManager", this, ToStrings(seriesProjectManager1.FullPath));
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
            if (tb.Tag is NLGSolution.BaseObject baseObject )
            {
                baseObject.IsEditMode = false;
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Tag is NLGSolution.BaseObject baseObject)
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
                string Extension = Path.GetExtension(projectFile.FullPath);
                projectFolder.AddChild(projectFile);
                if (Extension == "png" || Extension == "jpg" || Extension == "tiff")
                {
                    projectFile.Visibility = Visibility.Visible;
                };
            }
            return projectFolder;
        }

        SolutionExplorer solutionExplorer;

        private void TreeViewInitialized(string FilePath, Config config)
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
                    ProjectManager projectMannager = new ProjectManager(dic.FullName) { CanDelete = false,CanReName = false ,Visibility =Visibility.Hidden};
                    foreach (var item in dic.GetDirectories())
                    {
                        ProjectFolder projectFolder = new ProjectFolder(item.FullName);
                        projectMannager.AddChild(GetFile(projectFolder, item.FullName));
                    }
                    foreach (var item in dic.GetFiles())
                    {
                        ProjectFile projectFile = new ProjectFile(item.FullName);
                        string Extension = Path.GetExtension(projectFile.FullPath);

                        projectMannager.AddChild(projectFile);

                        if (Extension == ".png" || Extension == ".jpg" || Extension == ".tiff" || Extension == ".bmp"|| Extension == ".txt")
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

                    //solutionExplorer.AddChild(seriesProjectManager);l
                }

            }
            SolutionExplorers.Clear();
            SolutionExplorers.Add(solutionExplorer);
            SolutionTreeView.ItemsSource = SolutionExplorers;
        }

        private BaseObject ADDDerivativeSeriesFile(BaseObject baseObject,string FullName)
        {
            var root = new DirectoryInfo(FullName);
            bool IsNotExit = true;
            foreach (var directoryInfo in root.GetDirectories())
            {
                if (directoryInfo.Name == "derives")
                {
                    var directoryInfo1 = new DirectoryInfo(directoryInfo.FullName);
                    foreach (var item1 in directoryInfo1.GetDirectories())
                    {
                        IsNotExit = false;
                        DerivativeSeriesFile derivativeSeriesFile = new DerivativeSeriesFile(item1.FullName);
                        baseObject.AddChild(ADDDerivativeSeriesFile(derivativeSeriesFile, item1.FullName));
                    }
                }
            }
            //if (IsNotExit)
            //    Directory.CreateDirectory($"{FullName}\\derives");
            return baseObject;
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
            if (this.Parent is StackPanel stackPanel)
            {
                stackPanel.Width = 420;
            }

        }

        private unsafe void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LambdaControl.Dispatch("VideoTest", this, new Dictionary<string, object>());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //LambdaControl.Dispatch("SleepTest", this, new Dictionary<string, object>());
            Image image = new Image();
            HeaderStackPanel.Children.Add(image);
            MessageBox.Show(LambdaControl.RegisterImageView(image).ToString());
        }
        GridLengthConverter gridLengthConverter = new GridLengthConverter();
        private void testt22_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            testt22.Children.Clear();
            testt22.RowDefinitions.Clear();
            int lendgth = (int)(testt22.ActualHeight / 26.66);
            if (lendgth > 0)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri("/Solution;component/images/图片2.png", UriKind.Relative));

                RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
                testt22.RowDefinitions.Add(rowDefinition);
                image.SetValue(Grid.RowProperty, 0);
                image.SetValue(Grid.ColumnProperty, 0);
                image.MouseLeftButtonDown += Image_MouseLeftButtonDown;
                testt22.Children.Add(image);
            }




            for (int i = 1; i < lendgth; i++)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri("/Solution;component/images/filer.png", UriKind.Relative));

                RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
                testt22.RowDefinitions.Add(rowDefinition);
                image.MouseLeftButtonDown += Image_MouseLeftButtonDown;
                image.SetValue(Grid.RowProperty, i);
                image.SetValue(Grid.ColumnProperty, 0);
                testt22.Children.Add(image);

            }


        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("这里添加命令");
        }

        bool fisrt = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //执行一次
            if (fisrt)
            {
                View view = LambdaControl.GetImageView(0);
                if (view != null)
                {
                    view.Image = null;
                }
                fisrt = false;
            }

        }
    }

}

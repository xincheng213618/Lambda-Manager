using Global.SettingUp;
using Global.SettingUp.Configure;
using Global.SettingUp.PC;
using Lambda;
using NvAPIWrapper.GPU;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThemeManager;


namespace ConfigSetting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ToolSetting : UserControl
    {
        public ToolSetting()
        {
            InitializeComponent();
        }

        public ObservableCollection<FirmwareUpdate> firmwareUpdates;

        bool IsFirstLoad = true;
        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel1 && stackPanel1.Parent is Viewbox viewbox1 && viewbox1.Parent is ScrollViewer scrollViewer1)
            {
                IsFirstLoad = false;

                //GPU信息
                PhysicalGPU[] physicalGPUs;
                try
                {
                    physicalGPUs = PhysicalGPU.GetPhysicalGPUs();
                }
                catch(Exception ex)
                {
                    physicalGPUs = new PhysicalGPU[0];
                }
                GPUInfo GPUInfo = SoftwareConfig.HardwareSetting.GPUInfo;
                GPUInfoStackPanel.DataContext = GPUInfo;
                if (physicalGPUs.Count() > 0)
                {
                    GPUInfo.IsGPUCapable = true;
                    GPUInfo.GPUName = physicalGPUs[0].FullName;
                    GPUInfo.GPUaccessibleRAM = physicalGPUs[0].MemoryInformation.AvailableDedicatedVideoMemoryInkB;
                }
                LambdaControl.Trigger("IsGPUCapable", this,new Dictionary<string, object>() { { "Value", GPUInfo.IsGPUCapable } });


                if (!SoftwareConfig.HardwareSetting.IsIniWizard)
                {
                    //这里让窗口最小化
                    await Task.Delay(100);
                    SystemCommands.MinimizeWindow(Application.Current.MainWindow);
                    await Task.Delay(50);
                    Wizard.MainWindow mainWindow = new Wizard.MainWindow("1");
                    mainWindow.ShowDialog();

                    if (SoftwareConfig.HardwareSetting.IsIniWizard)
                    {
                        SystemCommands.RestoreWindow(Application.Current.MainWindow);
                    }
                }
                if (Application.Current.MainWindow.FindName("msgList") is ComboBox combobox)
                {
                    combobox.Visibility = SoftwareConfig.SolutionSetting.IsShowLog ? Visibility.Visible : Visibility.Hidden;
                    UniformGridSetting.DataContext = SoftwareConfig.SolutionSetting;
                }
                var array = Enum.GetValues(typeof(Theme)).Cast<Theme>();
                ComboBox1.ItemsSource = array;
                ComboBox1.SelectedItem = ThemeManagers.CurrentUITheme;
                ThemeManagers.ThemeChanged += delegate
                {
                    ComboBox1.SelectedItem = ThemeManagers.CurrentUITheme;
                };
                firmwareUpdates = new ObservableCollection<FirmwareUpdate>
                        {
                            new FirmwareUpdate() { Name = "stageModule", Version = "5.00", UpdateSize = "55 MB", UpdateTime = "20220809" ,UpdateUrl ="https://github.com/xincheng213618" },
                            new FirmwareUpdate() { Name = "CamerModudle", Version = "1.00", UpdateSize = "155 MB", UpdateTime = "20220509" ,UpdateUrl ="https://github.com/2222222" },
                            new FirmwareUpdate() { Name = "Serial port Mode", Version = "2.10", UpdateSize = "255 MB", UpdateTime = "20220109" ,UpdateUrl ="https://github.com/xincheng213618222222" },
                            new FirmwareUpdate() { Name = "Led", Version = "1.45", UpdateSize = "124 KB", UpdateTime = "20220909" ,UpdateUrl ="https://github.com/xincheng213618888888888888" },
                            new FirmwareUpdate() { Name = "差分算法", Version = "3.20", UpdateSize = "1.5 GB", UpdateTime = "20220809" ,UpdateUrl ="https://github.com/xincheng213618" },
                            new FirmwareUpdate() { Name = "相位算法", Version = "0.00", UpdateSize = "22222", UpdateTime = "20220809" ,UpdateUrl ="https://github.com/2222222" },
                            new FirmwareUpdate() { Name = "等差算法", Version = "0.00", UpdateSize = "22222", UpdateTime = "20220809" ,UpdateUrl ="https://github.com/xincheng213618222222" },
                            new FirmwareUpdate() { Name = "采集", Version = "0.00", UpdateSize = "22222", UpdateTime = "20220809" ,UpdateUrl ="https://github.com/xincheng213618888888888888" },
                            new FirmwareUpdate() { Name = "多模态", Version = "0.00", UpdateSize = "22222", UpdateTime = "20220809" ,UpdateUrl ="https://github.com/xincheng213618" },
                        };
                ListView1.ItemsSource = firmwareUpdates;

                CheckBox1.DataContext = SoftwareConfig.SolutionSetting;

                stackPanel1.Children.Remove(this);
                if (Application.Current.MainWindow.FindName("stageConfig") is Grid stageConfig && Application.Current.MainWindow.FindName("stageAcquisition") is Grid stageAcquisition)
                {
                    stageConfig.Children.Add(this);

                    Application.Current.ApplyTheme(ThemeManagers.CurrentUITheme);

                    stageConfig.SetResourceReference(Grid.BackgroundProperty, "WindowBackgroundBrush");
                    
                    if (Application.Current.MainWindow.Content is Grid mainGrid&& mainGrid.Children[0] is Grid grid2 && grid2.Children[1] is StackPanel stackPanelMode)
                    {
                        if (grid2.Children[0] is StackPanel stackPanel && stackPanel.Children[0] is Button button && button.Content is Image image)
                        {
                            image.Source = new BitmapImage(new Uri("/ConfigSetting;component/image/application-logo-3.0.png", UriKind.Relative));
                        }

                        foreach (var item in stackPanelMode.Children)
                        {
                            if (item is RadioButton radioButton1)
                            {
                                radioButton1.SetResourceReference(RadioButton.StyleProperty, "PhaseButton");
                            }
                        }

                        if (Application.Current.MainWindow.FindName("menu") is Menu menu)
                        {
                            menu.Background = Brushes.Transparent;
                        }

                        if (stackPanelMode.Children[0] is RadioButton radioButton)
                        {
                            stageConfig.Visibility = radioButton.IsChecked ==true ? Visibility.Visible : Visibility.Collapsed;
                            stageAcquisition.Visibility = radioButton.IsChecked != true ? Visibility.Visible : Visibility.Collapsed;

                            radioButton.Checked += delegate
                            {
                                stageConfig.Visibility = Visibility.Visible;
                                stageAcquisition.Visibility = Visibility.Collapsed;
                            };
                            radioButton.Unchecked += delegate
                            {
                                stageConfig.Visibility = Visibility.Hidden;
                                stageAcquisition.Visibility = Visibility.Visible;
                            };
                        }
                    }

                }

                if (Application.Current.MainWindow.FindName("statusBar") is StatusBar statusBar)
                {
                    string xaml = @"<ItemsPanelTemplate   xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                        <DockPanel/>
                    </ItemsPanelTemplate>";
                    statusBar.ItemsPanel = XamlReader.Parse(xaml) as ItemsPanelTemplate;

                    Dictionary<string, string> properties = new Dictionary<string, string>() 
                    {
                        { "相机:","IsCameraConnection"},
                        { "位移台:","IsStageConnection"},
                        { "灯光模块:","IsLightConnection"},
                    };

                    DockPanel dockPanel = new DockPanel();
                    foreach (var property in properties) 
                    {
                        BulletDecorator bulletDecorator = new BulletDecorator() { Bullet = new TextBlock() { Text = property.Key} ,Margin = new Thickness(2,0,2,0)};
                        TextBlock textBlock = new TextBlock() { DataContext = SoftwareConfig.HardwareSetting };
                        textBlock.SetBinding(TextBlock.TextProperty, new Binding() { Path = new PropertyPath(property.Value) });
                        bulletDecorator.Child = textBlock;
                        dockPanel.Children.Add(bulletDecorator);
                    }
                    StatusBarItem statusBarItem = new StatusBarItem() { Content = dockPanel };
                    DockPanel.SetDock(statusBarItem, Dock.Right);

                    statusBar.Items.Add(statusBarItem);


                    statusBar.Items.Add(new StatusBarItem());
                }



            }
        }
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem is Theme theme)
            {
                Application.Current.ApplyTheme(theme);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Wizard.MainWindow mainWindow = new Wizard.MainWindow("1");
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CalibrationWindow calibrationWindow = new CalibrationWindow();
            calibrationWindow.ShowDialog();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            HardwareSettingConnectionStackPanel.DataContext = SoftwareConfig.HardwareSetting;

            //ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");

            //foreach (ManagementObject obj in objvide.Get())
            //{
            //    CUDAInfoTextBlock.Text += "Name - " + obj["Name"] + "</br>";
            //    CUDAInfoTextBlock.Text += "DeviceID - " + obj["DeviceID"] + "</br>";
            //    CUDAInfoTextBlock.Text += "AdapterRAM - " + obj["AdapterRAM"] + "</br>";
            //    CUDAInfoTextBlock.Text += "AdapterDACType - " + obj["AdapterDACType"] + "</br>";
            //    CUDAInfoTextBlock.Text += "Monochrome - " + obj["Monochrome"] + "</br>";
            //    CUDAInfoTextBlock.Text += "InstalledDisplayDrivers - " + obj["InstalledDisplayDrivers"] + "</br>";
            //    CUDAInfoTextBlock.Text += "DriverVersion - " + obj["DriverVersion"] + "</br>";
            //    CUDAInfoTextBlock.Text += "VideoProcessor - " + obj["VideoProcessor"] + "</br>";
            //    CUDAInfoTextBlock.Text += "VideoArchitecture - " + obj["VideoArchitecture"] + "</br>";
            //    CUDAInfoTextBlock.Text += "VideoMemoryType - " + obj["VideoMemoryType"] + "</br>";
            //}

        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            if (sender is TreeViewItem treeViewItem)
            {
                if (treeViewItem.Tag is GroupBox groupBox)
                {
                    var currentScrollPosition = ScrollViewer1.VerticalOffset;
                    var point = new Point(0, currentScrollPosition);

                    var targetPosition = groupBox.TransformToVisual(ScrollViewer1).Transform(point);
                    ScrollViewer1.ScrollToVerticalOffset(targetPosition.Y);
                }
            }
        }

        private void TreeViewItem_Selected1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("DECORATIVE_LIGHTS_CONTROL", this, new Dictionary<string, object> { { "mode", 0 }});
        }
        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("DECORATIVE_LIGHTS_CONTROL", this, new Dictionary<string, object> { { "mode", 1 } });
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            var targetPosition = GroupBox2.TransformToVisual(ScrollViewer1).Transform(new Point());
            ScrollViewer1.ScrollToVerticalOffset(targetPosition.Y);

        }


        public void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("实验内容，点击后请确认给予权限");
            Process p = new Process();
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "Global.Reg.exe";
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.Verb = "runas";
            p.Start();
        }

        private void TreeViewItem1_Selected(object sender, RoutedEventArgs e)
        {



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is FirmwareUpdate firmwareUpdate)
            {
                MessageBox.Show(firmwareUpdate.UpdateUrl);
            }
        }

        private void ClearIniWizard(object sender, RoutedEventArgs e)
        {
            SoftwareConfig.HardwareSetting.IsIniWizard = false;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SoftwareConfig.SolutionSetting.IsShowLog = !SoftwareConfig.SolutionSetting.IsShowLog;
            if (Application.Current.MainWindow.FindName("msgList") is ComboBox combobox)
            {
                combobox.Visibility =SoftwareConfig.SolutionSetting.IsShowLog? Visibility.Visible:Visibility.Hidden;
            }
            
        }
    }
}

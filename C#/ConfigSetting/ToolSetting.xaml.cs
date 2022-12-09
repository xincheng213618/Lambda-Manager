using Global.Common;
using Global.Common.Extensions;
using Global.Mode;
using Global.Mode.Config;
using Global.SettingUp;
using Global.SettingUp.Configure;
using Global.SettingUp.PC;
using HotKey;
using Lambda;
using NvAPIWrapper.GPU;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThemeManager;
using System.IO;

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

                SystemSettingGrid.DataContext = SoftwareConfig.HardwareSetting.PerformanceSetting;
                OutOfMemorySign.Source = System.Drawing.SystemIcons.Warning.ToImageSource();

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
                GPUGrid.DataContext = GPUInfo;
                if (physicalGPUs.Count() > 0)
                {
                    GPUInfo.IsGPUCapable = true;
                    GPUInfo.GPUName = physicalGPUs[0].FullName;
                    GPUInfo.GPUaccessibleRAM = physicalGPUs[0].MemoryInformation.AvailableDedicatedVideoMemoryInkB / 1024/1024;
                }
                LambdaControl.Trigger("IsGPUCapable", this,new Dictionary<string, object>() { { "Value", GPUInfo.IsOpenGPUAccelerate } });

                if (SoftwareConfig.HardwareSetting.CameraStatus != Global.SettingUp.Hardware.CameraStatus.Ok ||
                    SoftwareConfig.HardwareSetting.LightStatus != Global.SettingUp.Hardware.SerialPortStatus.NoError ||
                    SoftwareConfig.HardwareSetting.StageStatus != Global.SettingUp.Hardware.SerialPortStatus.NoError)
                {
                    if (!SoftwareConfig.HardwareSetting.IsIniWizard)
                    {
                        MessageBox1.Show($"硬件连接异常:\n\r相机状态:{SoftwareConfig.HardwareSetting.CameraStatus}\n\r光源状态:{SoftwareConfig.HardwareSetting.LightStatus}\n\r位移台状态:{SoftwareConfig.HardwareSetting.StageStatus}", "Grid");
                        if (MessageBox1.Show("您是否要继续完成初始化\n\r ", "Grid", MessageBoxButton.YesNo) == MessageBoxResult.No)
                        {
                            Environment.Exit(0);
                        }
                    }
                    }

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

                if (SoftwareConfig.PerformanceSetting.IsDiskLackWarning)
                {
                    MessageBox1.Show("硬件不足预警", "Grid", button: MessageBoxButton.OK, icon: MessageBoxImage.Warning);
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
                firmwareUpdates = new ObservableCollection<FirmwareUpdate> {  };
                ListView1.ItemsSource = firmwareUpdates;


                SolutionGrid.DataContext = SoftwareConfig.SolutionSetting;
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


                    Dictionary<string, string> properties1 = new Dictionary<string, string>()
                    {
                        { "IsCameraConnection","CameraControlTemplate"},
                        { "IsStageConnection","StageControlTemplate"},
                        { "IsLightConnection","LightSourceControlTemplate"},
                    };
                    Dictionary<string, string> propertiesTag = new Dictionary<string, string>()
                    {
                        { "IsCameraConnection","相机连接情况"},
                        { "IsStageConnection","位移台连接情况"},
                        { "IsLightConnection","光源连接情况"},
                    };
                    Dictionary<string, double> propertiesHeight = new Dictionary<string, double>()
                    {
                        { "IsCameraConnection",15},
                        { "IsStageConnection",15},
                        { "IsLightConnection",18},
                    };

                    ResourceDictionary resourceDictionary = new ResourceDictionary() { Source = new Uri("/ConfigSetting;component/themes/Button.xaml", UriKind.Relative)};
                    DockPanel dockPanel = new DockPanel();
                    foreach (var property in properties1) 
                    {
                        Button button = new Button() { Height = propertiesHeight[property.Key], Width = propertiesHeight[property.Key], Background = Brushes.Transparent,DataContext = SoftwareConfig.HardwareSetting ,Tag = propertiesTag[property.Key] ,Margin= new Thickness(4,0,2,0)} ;
                        if (resourceDictionary.Contains(property.Value) && resourceDictionary[property.Value] is ControlTemplate controlTemplate)
                        {
                            button.Template = controlTemplate;
                            button.SetBinding(Button.IsEnabledProperty, new Binding() { Path = new PropertyPath(property.Key) });
                        }
                        button.Click += (s, e) =>
                        {
                            MessageBox.Show(property.Key + button.IsEnabled.ToString());
                        };
                        dockPanel.Children.Add(button);
                    }
                    StatusBarItem statusBarItem = new StatusBarItem() { Content = dockPanel };
                    DockPanel.SetDock(statusBarItem, Dock.Right);
                    statusBar.Items.Add(statusBarItem);
                    statusBar.Items.Add(new StatusBarItem());
                }

                StageConnectionText.DataContext = SoftwareConfig.HardwareSetting;
                CameraConnectionText.DataContext = SoftwareConfig.HardwareSetting;
                LightConnectionText.DataContext= SoftwareConfig.HardwareSetting;
                foreach (var item in HotKeyHelper.HotKeysList)
                {

                    TextBlock textBlock = new TextBlock() { Text =item.Value.FunctionName};
                    TextBlock textBlock1 = new TextBlock() { Text = item.Value.Hotkey.ToString() };

                    DockPanel dockPanel = new DockPanel();

                    dockPanel.Children.Add(textBlock);
                    dockPanel.Children.Add(textBlock1);
                    UniformGrifHotKey.Children.Add(dockPanel);
                }

                //一个针对主控不开放主窗口权限的解决方案 
                if (!File.Exists($"{System.Windows.Forms.Application.StartupPath}\\LambdaCore.dll"))
                {
                    int port = 52100;
                    IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Loopback, port);
                    Socket sssss = new Socket(IPAddress.Loopback.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        sssss.Connect(localEndPoint);
                    }
                    catch { }
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



        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {


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
            LambdaControl.Trigger("DECORATIVE_LIGHTS_CONTROL", this, new Dictionary<string, object> { { "mode", 0 } });



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

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SoftwareConfig.SolutionSetting.IsShowLog = !SoftwareConfig.SolutionSetting.IsShowLog;
            if (Application.Current.MainWindow.FindName("msgList") is ComboBox combobox)
            {
                combobox.Visibility =SoftwareConfig.SolutionSetting.IsShowLog? Visibility.Visible:Visibility.Hidden;
            }
            
        }

        private void Calibration_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string value)
            {
                Dictionary<int, HardwareCalibration> HardwareCalibrationDic = new Dictionary<int, HardwareCalibration>();
                Dictionary<int, string> HardwareCalibrationDicString = new Dictionary<int, string>();
                //硬触发
                HardwareCalibrationDic.Add(0, new HardwareCalibration() { Hardware = "Camera", Type = "HardTrigger" });
                HardwareCalibrationDicString.Add(0, "相机触发校准");
                //位移台移动完整性
                HardwareCalibrationDic.Add(10, new HardwareCalibration() { Hardware = "Stage", Type = "Integrity" });
                HardwareCalibrationDicString.Add(10, "位移台移动完整性");
                //放大倍数
                HardwareCalibrationDic.Add(11, new HardwareCalibration() { Hardware = "Stage", Type = "Magnification" });
                HardwareCalibrationDicString.Add(11, "放大倍数");

                //回城校准
                HardwareCalibrationDic.Add(12, new HardwareCalibration() { Hardware = "Stage", Type = "Backhaul" });
                HardwareCalibrationDicString.Add(12, "回程校准");

                //零点
                HardwareCalibrationDic.Add(13, new HardwareCalibration() { Hardware = "Stage", Type = "Zero" });
                HardwareCalibrationDicString.Add(13, "零点校准");


                //中心点
                HardwareCalibrationDic.Add(20, new HardwareCalibration() { Hardware = "Light", Type = "CenterPoint" });
                HardwareCalibrationDicString.Add(20, "灯光中心点校准");

                //光源完整性
                HardwareCalibrationDic.Add(21, new HardwareCalibration() { Hardware = "Light", Type = "Integrity" });
                HardwareCalibrationDicString.Add(21, "光源完整性校准");

                //白平衡
                HardwareCalibrationDic.Add(22, new HardwareCalibration() { Hardware = "Light", Type = "WhiteBalance" });
                HardwareCalibrationDicString.Add(22, "白平衡校准");

                //光源明场暗场半径
                HardwareCalibrationDic.Add(23, new HardwareCalibration() { Hardware = "Light", Type = "RadiusOfLightSource" });
                HardwareCalibrationDicString.Add(23, "光源明场暗场半径校准");


                // 背景校正
                HardwareCalibrationDic.Add(30, new HardwareCalibration() { Hardware = "Initialize", Type = "BackgroundCorrection" });
                HardwareCalibrationDicString.Add(30, "初始化背景矫正");
                HardwareCalibrationDic.Add(31, new HardwareCalibration() { Hardware = "Initialize", Type = "TransferFunction" });
                HardwareCalibrationDicString.Add(31, "初始化传递函数");

                switch (value)
                {
                    case "All":
                        break;
                    default:
                        List<int> list = new List<int>();
                        foreach (var item in HardwareCalibrationDic)
                        {
                            if (item.Value.Hardware != value)
                            {
                                list.Add(item.Key);
                            }
                        }
                        foreach (var item in list)
                        {
                            HardwareCalibrationDic.Remove(item);
                            HardwareCalibrationDicString.Remove(item);
                        }
                        break;
                }
                CalibrationWindow calibrationWindow = new CalibrationWindow(HardwareCalibrationDic, HardwareCalibrationDicString);
                calibrationWindow.ShowDialog();


            }
        }

        private void GPU_Click(object sender, RoutedEventArgs e)
        {
            SoftwareConfig.HardwareSetting.GPUInfo.IsOpenGPUAccelerate = !SoftwareConfig.HardwareSetting.GPUInfo.IsOpenGPUAccelerate;
            LambdaControl.Trigger("IsGPUCapable", this, new Dictionary<string, object>() { { "Value", SoftwareConfig.HardwareSetting.GPUInfo.IsOpenGPUAccelerate } });
        }
    }
}

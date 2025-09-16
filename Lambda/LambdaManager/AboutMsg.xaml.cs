using ColorVision.Themes;
using ColorVision.UI.HotKey;
using ColorVision.UI.Menus;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LambdaManager
{
    public class AboutMsgExport : MenuItemBase, IMenuItem
    {

        public override string OwnerGuid => "Help";
        public override string GuidId => "AboutMsg";

        public override int Order => 100000;
        public override string Header => "MenuAbout";

        public override void Execute()
        {
            new AboutMsgWindow() { Owner = Application.Current.GetActiveWindow(), WindowStartupLocation = WindowStartupLocation.CenterOwner }.ShowDialog();
        }
    }


    /// <summary>
    /// AboutMsg.xaml 的交互逻辑
    /// </summary>
    public partial class AboutMsgWindow : Window
    {
        public AboutMsgWindow()
        {
            InitializeComponent();
            this.ApplyCaption();

        }

        public ObservableCollection<ProduceInfo> produceInfos = new ObservableCollection<ProduceInfo>();

        private void Window_Initialized(object sender, EventArgs e)
        {
            produceInfos.Add(new ProduceInfo() { Name = "Register", Version = "1.0", Description = "注册" });
            produceInfos.Add(new ProduceInfo() { Name = "AboutMsg", Version = "1.0", Description = "关于" });
            produceInfos.Add(new ProduceInfo() { Name = "Solution", Version = "1.0", Description = "工程管理模块" });
            produceInfos.Add(new ProduceInfo() { Name = "ConfigObjective", Version = "1.0", Description = "采集配置模块" });
            produceInfos.Add(new ProduceInfo() { Name = "RS232", Version = "1.0", Description = "RS232" });
            produceInfos.Add(new ProduceInfo() { Name = "ISCamera", Version = "1.0", Description = "ISCamera" });
            produceInfos.Add(new ProduceInfo() { Name = "DPC", Version = "1.0", Description = "DPC" });
            produceInfos.Add(new ProduceInfo() { Name = "InteropTest", Version = "1.0", Description = "测试" });
            ListView1.ItemsSource = produceInfos;
        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListView1.SelectedIndex > -1)
            {
                TextBlock1.DataContext = produceInfos[ListView1.SelectedIndex];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("msinfo32.exe");
           
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("dxdiag.exe");
        }

    }


    public class ProduceInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
    }
}

using Global.Common;
using Lambda;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using ThemeManager.Controls;
using Global.Common.Extensions;
using Global.Common.Controls;


namespace ConfigSetting
{
    public class HardwareCalibration : ViewModelBase
    {
        public string Hardware { get; set; }
        public string Type { get; set; }
    }



    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class CalibrationWindow : BaseWindow
    {
        public static bool IsRegister = false;
        Dictionary<int, HardwareCalibration> HardwareCalibrationDic = new Dictionary<int, HardwareCalibration>();
        Dictionary<int, string> HardwareCalibrationDicString = new Dictionary<int, string>();


        public CalibrationWindow()
        {
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
            HardwareCalibrationDicString.Add(12, "回城校准");

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
            HardwareCalibrationDicString.Add(30, "背景矫正");

            InitializeComponent();
            if (!IsRegister)
            {
                IsRegister = true;
                LambdaControl.AddLambdaEventHandler("HardwareCalibrationState", HardwareCalibrationState, false);
            }
        }

        public CalibrationWindow(Dictionary<int, HardwareCalibration> HardwareCalibrationDic , Dictionary<int, string> HardwareCalibrationDicString)
        {
            this.HardwareCalibrationDic = HardwareCalibrationDic;
            this.HardwareCalibrationDicString = HardwareCalibrationDicString;
            InitializeComponent();
            if (!IsRegister)
            {
                IsRegister = true;
                LambdaControl.AddLambdaEventHandler("HardwareCalibrationState", HardwareCalibrationState, false);
            }
        }


        private void AdddHardwareCalibration(string Text)
        {
            DockPanel dockPanel = new DockPanel();
            TextBlock textBlock = new TextBlock() { Text = Text, FontSize = 15 };
            dockPanel.Children.Add(textBlock);
            ProgressRing progressRing1 = new ProgressRing() { Height = 16, Width = 16, HorizontalAlignment = HorizontalAlignment.Right };
            dockPanel.Children.Add(progressRing1);
            if (ShowStackPanel.Children.Count > 0 && ShowStackPanel.Children[ShowStackPanel.Children.Count - 1] is DockPanel dockPanel1 && dockPanel1.Children[1] is ProgressRing progressRing)
            {
                dockPanel1.Children.Remove(progressRing);
                Path path = new Path() { HorizontalAlignment = HorizontalAlignment.Right, Data = Geometry.Parse("M 1,3 C1,3 1,6 1,6 1,6 4,9 4,9 4,9 9,3 9,3 9,3 9,0 9,0 9,0 4,6 4,6 4,6 1,3 1,3 z"), Stretch = Stretch.Uniform, Fill = Brushes.Green, Margin = new Thickness(0) };
                dockPanel1.Children.Add(path);
            }
            ShowStackPanel.Children.Add(dockPanel);
            ScrollViewer1.ScrollToEnd();
        }

        private async void BaseWindow_Initialized(object sender, EventArgs e)
        {
            AdddHardwareCalibration("正在准备校准环境");
            await Task.Delay(2000);
            ProgressBar.Maximum = HardwareCalibrationDicString.Keys.Count;
            ProgressBar.Value = 0;
            int i = 0;
            foreach (var item in HardwareCalibrationDicString.Keys)
            {
                if (Closeing) break;
                i++;
                AdddHardwareCalibration($"({i}/{HardwareCalibrationDicString.Keys.Count}){HardwareCalibrationDicString[item]}");
                LambdaControl.Trigger("HardwareCalibration", this, HardwareCalibrationDic[item].ToJson());
                await Task.Delay(2000);
                ProgressBar.Value = i;
            }
            this.BaseClose();
        }


        public static bool HardwareCalibrationState(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;


            return true;
        }



        bool Closeing = false;
        public override async void BaseClose()
        {
            if (Closeing) return;
            Closeing = true;
            AdddHardwareCalibration("正在还原默认工作环境");
            await Task.Delay(2000);
            base.BaseClose();
        }

        private void BaseWindow_Closed(object sender, EventArgs e)
        {

        }
    }
}

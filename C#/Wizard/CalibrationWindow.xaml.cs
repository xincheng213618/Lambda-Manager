﻿using Global.Common;
using Lambda;
using System;
using System.Collections.Generic;
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




            LambdaControl.AddLambdaEventHandler("HardwareCalibrationState", HardwareCalibrationState, false);
        }


        private async void BaseWindow_Initialized(object sender, EventArgs e)
        {
            foreach (var item in HardwareCalibrationDicString.Keys)
            {
                await Task.Delay(5000);
                DockPanel dockPanel = new DockPanel();
                TextBlock textBlock = new TextBlock() { Text = HardwareCalibrationDicString[item] };
                dockPanel.Children.Add(textBlock);
                dockPanel.Children.Add(new ProgressRing() { Height=15,Width=15});
                if (ShowStackPanel.Children.Count>0&& ShowStackPanel.Children[ShowStackPanel.Children.Count -1] is DockPanel dockPanel1 && dockPanel1.Children[1] is ProgressRing progressRing)
                {
                    dockPanel1.Children.Remove(progressRing);
                }
                ShowStackPanel.Children.Add(dockPanel);
            }
        }


        public bool HardwareCalibrationState(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;


            return true;
        }


        Dictionary<int, HardwareCalibration> HardwareCalibrationDic = new Dictionary<int, HardwareCalibration>();
        Dictionary<int, string> HardwareCalibrationDicString = new Dictionary<int, string>();




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = (string)button.Content });
            LambdaControl.Trigger("HardwareCalibration", this, HardwareCalibrationDic[int.Parse(button.Tag.ToString()??"0")].ToJson());

            if (button.Tag.ToString() == "30")
                this.Close();
        }


    }
}

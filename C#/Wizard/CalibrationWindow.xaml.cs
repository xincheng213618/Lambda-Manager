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

namespace ConfigSetting
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class CalibrationWindow : BaseWindow
    {
        public CalibrationWindow()
        {
            InitializeComponent();


            //硬触发
            HardwareCalibrationDic.Add(0, new Dictionary<string, object>() { { "Hardware", "Camera" }, { "Type", "HardTrigger" } });

            //位移台移动完整性
            HardwareCalibrationDic.Add(10, new Dictionary<string, object>() { { "Hardware", "Stage" }, { "Type", "Integrity" } });
            //放大倍数
            HardwareCalibrationDic.Add(11, new Dictionary<string, object>() { { "Hardware", "Stage" }, { "Type", "Magnification" } });
            //回城校准
            HardwareCalibrationDic.Add(12, new Dictionary<string, object>() { { "Hardware", "Stage" }, { "Type", "Backhaul" } });
            //零点
            HardwareCalibrationDic.Add(13, new Dictionary<string, object>() { { "Hardware", "Stage" }, { "Type", "Zero" } });

            //中心点
            HardwareCalibrationDic.Add(20, new Dictionary<string, object>() { { "Hardware", "Light" }, { "Type", "CenterPoint" } });
            //光源完整性
            HardwareCalibrationDic.Add(21, new Dictionary<string, object>() { { "Hardware", "Light" }, { "Type", "Integrity" } });
            //白平衡
            HardwareCalibrationDic.Add(22, new Dictionary<string, object>() { { "Hardware", "Light" }, { "Type", "WhiteBalance" } });
            //光源明场暗场半径
            HardwareCalibrationDic.Add(23, new Dictionary<string, object>() { { "Hardware", "Light" }, { "Type", "RadiusOfLightSource" } });

            // 背景校正
            HardwareCalibrationDic.Add(30, new Dictionary<string, object>() { { "Hardware", "Initialize" }, { "Type", "BackgroundCorrection" } });
        }
        Dictionary<int, Dictionary<string, object>> HardwareCalibrationDic = new Dictionary<int, Dictionary<string, object>>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            LambdaControl.Log(new Message() { Severity = Severity.INFO, Text = (string)button.Content });
            LambdaControl.Trigger("HardwareCalibration", this, HardwareCalibrationDic[int.Parse(button.Tag.ToString())]);

            if (button.Tag.ToString() == "30")
                this.Close();
        }

    }
}

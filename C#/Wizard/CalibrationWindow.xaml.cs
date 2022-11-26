using Global.Common;
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
            InitializeComponent();


            //硬触发
            HardwareCalibrationDic.Add(0, new HardwareCalibration() { Hardware="Camera",Type="HardTrigger" } );

            //位移台移动完整性
            HardwareCalibrationDic.Add(10, new HardwareCalibration() { Hardware= "Stage" ,Type="Integrity" } );
            //放大倍数
            HardwareCalibrationDic.Add(11, new HardwareCalibration() { Hardware= "Stage" ,Type="Magnification" } );
            //回城校准
            HardwareCalibrationDic.Add(12, new HardwareCalibration() { Hardware= "Stage" ,Type="Backhaul" } );
            //零点
            HardwareCalibrationDic.Add(13, new HardwareCalibration() { Hardware= "Stage" ,Type="Zero" } );

            //中心点
            HardwareCalibrationDic.Add(20, new HardwareCalibration() { Hardware= "Light" ,Type="CenterPoint" } );
            //光源完整性
            HardwareCalibrationDic.Add(21, new HardwareCalibration() { Hardware= "Light" ,Type="Integrity" } );
            //白平衡
            HardwareCalibrationDic.Add(22, new HardwareCalibration() { Hardware= "Light" ,Type="WhiteBalance" } );
            //光源明场暗场半径
            HardwareCalibrationDic.Add(23, new HardwareCalibration() { Hardware= "Light" ,Type="RadiusOfLightSource" } );

            // 背景校正
            HardwareCalibrationDic.Add(30, new HardwareCalibration() { Hardware= "Initialize" ,Type="BackgroundCorrection" } );

            LambdaControl.AddLambdaEventHandler("HardwareCalibrationState", HardwareCalibrationState, false);
        }
        public bool HardwareCalibrationState(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;


            return true;
        }


        Dictionary<int, HardwareCalibration> HardwareCalibrationDic = new Dictionary<int, HardwareCalibration>();



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

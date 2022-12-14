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
using System.Linq;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.Threading;

namespace ConfigSetting
{
    public class HardwareCalibration : ViewModelBase
    {
        public string Name { internal get;  set; }

        public string Hardware { get; set; }
        public string Type { get; set; }

    }

    public delegate bool HardwareCalibrationStateEventHandler(object sender, EventArgs e);


    public class Calibration
    {

        private static Calibration _instance;
        private static readonly object _locker = new();

        public static Calibration GetInstance()
        {
            lock (_locker) { _instance ??= new Calibration(); }
            return _instance;
        }

        public Calibration()
        {
            LambdaControl.AddLambdaEventHandler("HardwareCalibrationState", HardwareCalibrationState, false);
            LambdaControl.AddLambdaEventHandler("SetHardwareCalibrationContent", SetHardwareCalibrationContent, false);

        }
        private bool HardwareCalibrationState(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                HardwareCalibrationStateInvoke(sender, e);
            });
            return true;
        }

        private bool SetHardwareCalibrationContent(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                GetHardwareCalibrationContentInvoke(sender, e);
            });
            return true;
        }


        public static event HardwareCalibrationStateEventHandler HardwareCalibrationStateEvent;
        public static event HardwareCalibrationStateEventHandler GetHardwareCalibrationContentEvent;


        public static void HardwareCalibrationStateInvoke(object sender, EventArgs e)
        {
            HardwareCalibrationStateEvent?.Invoke(sender, e);
        }
        public static void GetHardwareCalibrationContentInvoke(object sender, EventArgs e)
        {
            GetHardwareCalibrationContentEvent?.Invoke(sender, e);
        }
    }

    public enum HardwareCalibrationType
    {
        /// <summary>
        /// 向导
        /// </summary>
        Wizard,
       /// <summary>
       /// 设置中第一个按钮
       /// </summary>
        All,
        /// <summary>
        /// 相机
        /// </summary>
        Camera,
        /// <summary>
        /// 位移台
        /// </summary>
        Stage,
        /// <summary>
        /// 光源
        /// </summary>
        Light,
        /// <summary>
        /// 初始化
        /// </summary>
        Initialize,
    }

    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class CalibrationWindow : BaseWindow
    {
        public List<HardwareCalibration> HardwareCalibrations = new List<HardwareCalibration>();

        public CalibrationWindow()
        {
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Camera", Type = "HardTrigger", Name = "相机触发校准", });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Stage", Type = "Integrity", Name = "位移台移动完整性", });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Stage", Type = "Magnification", Name = "放大倍数", });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Stage", Type = "Backhaul", Name = "回城校准" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Stage", Type = "Zero", Name = "零点校准" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Light", Type = "CenterPoint", Name = "灯光中心点校准" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Light", Type = "Integrity", Name = "光源完整性校准" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Light", Type = "WhiteBalance", Name = "白平衡校准" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Light", Type = "RadiusOfLightSource", Name = "光源明场暗场半径校准" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Initialize", Type = "BackgroundCorrection", Name = "背景矫正" });
            //HardwareCalibrations.Add(new HardwareCalibration() { Hardware = "Initialize", Type = "TransferFunction", Name = "初始化传递函数" });
            //string value= JsonSerializer.Serialize(HardwareCalibrations,new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) });

            InitializeComponent();

        }

        public CalibrationWindow(HardwareCalibrationType HardwareCalibrationType, Dictionary<int, HardwareCalibration> HardwareCalibrationDic , Dictionary<int, string> HardwareCalibrationDicString)
        {
            foreach (var item in HardwareCalibrationDicString)
            {
                HardwareCalibrations.Add(new HardwareCalibration() { Hardware = HardwareCalibrationDic[item.Key].Hardware,Type = HardwareCalibrationDic[item.Key].Type,Name = item.Value });
            }
            Calibration.GetHardwareCalibrationContentEvent += GetHardwareCalibrationContent;
            LambdaControl.Trigger("HardwareCalibrationInit", this, new Dictionary<string, object>() { { "HardwareCalibrationType", (int)HardwareCalibrationType } });

            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterOwner;
            Calibration.HardwareCalibrationStateEvent += HardwareCalibrationState;
        }


        public CalibrationWindow(HardwareCalibrationType HardwareCalibrationType)
        {
            Calibration.GetHardwareCalibrationContentEvent += GetHardwareCalibrationContent;

            LambdaControl.Trigger("HardwareCalibrationInit", this, new Dictionary<string, object>() { { "HardwareCalibrationType", (int)HardwareCalibrationType } });
            InitializeComponent();
            Calibration.HardwareCalibrationStateEvent += HardwareCalibrationState;
        }

        public bool GetHardwareCalibrationContent(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            string json = eventData.GetString("json");

            var HardwareCalibrationaaa = JsonSerializer.Deserialize<List<HardwareCalibration>>(json, new JsonSerializerOptions());
            if (HardwareCalibrationaaa != null)
            {
                HardwareCalibrations = HardwareCalibrationaaa;
            }
            return true;
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
        Thread thread;
        private void Dispath(string type, object sender, string? json)
        {
            thread = new Thread(() => { try { LambdaControl.Trigger(type, sender, json); } catch  { } } );
            thread.Start();
        }

        int Current = 0;
        private async void BaseWindow_Initialized(object sender, EventArgs e)
        {
            AdddHardwareCalibration("正在准备校准环境");
            
            await Task.Delay(1000);
            if (Closeing||HardwareCalibrations.Count <= 0)
            {
                BaseClosed = true;
                this.Close();
                return;
            }
            ProgressBar.Maximum = HardwareCalibrations.Count;
            ProgressBar.Value = 0;
            Current++;
            Dispath("HardwareCalibration", this, HardwareCalibrations[Current - 1].ToJson());
            AdddHardwareCalibration($"({Current}/{HardwareCalibrations.Count}){HardwareCalibrations[Current-1].Name}");
            ProgressBar.Value = Current;
        }


        public bool HardwareCalibrationState(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            if (Closeing1) base.BaseClose();
            if (int.TryParse(eventData.GetString("ResultCode"),out int temp))
            {
                switch (temp)
                {
                    case 0:
                        if (Closeing) break;
                        Current++;
                        if (Current> HardwareCalibrations.Count)
                        {
                            if (Closeing1)
                            {
                                base.BaseClose();
                            }
                            else
                            {
                                Closeing1 = true;
                                base.Close();
                            }
                            break;
                        }
                        AdddHardwareCalibration($"({Current}/{HardwareCalibrations.Count}){HardwareCalibrations[Current - 1].Name}");
                        Dispath("HardwareCalibration", this, HardwareCalibrations[Current - 1].ToJson());
                        ProgressBar.Value = Current;
                        break;
                    case -1:
                        Environment.Exit(-1);
                        break;
                    case 1:
                        Global.Common.MessageBox1.Show(eventData.GetString("Msg"));
                        break;
                    default:
                        break;
                }
            }
            return true;
        }


        /// <summary>
        /// 强行关闭
        /// </summary>
        bool Closeing = false;
        /// <summary>
        /// 等待返回关闭
        /// </summary>
        bool Closeing1 = false;

        public override async void BaseClose()
        {
            if (Closeing)
                return;
            Closeing = true;
            thread?.Interrupt();
            AdddHardwareCalibration("正在还原默认工作环境");
            LambdaControl.Dispatch("HardwareCalibrationClose", this, new Dictionary<string, object>() { });
            if (Closeing1)
            {
                await Task.Delay(1000);
                base.BaseClose();
            }
            else
            {
                Closeing1 = true;
            }

        }

        private void BaseWindow_Closed(object sender, EventArgs e)
        {
            Calibration.HardwareCalibrationStateEvent -= HardwareCalibrationState;
            Calibration.GetHardwareCalibrationContentEvent -= GetHardwareCalibrationContent;
        }
    }
}

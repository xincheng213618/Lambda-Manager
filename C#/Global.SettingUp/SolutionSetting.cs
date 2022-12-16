using Global.Common;
using Global.Common.Util;
using Lambda;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ThemeManager;

namespace Global.SettingUp
{
    /// <summary>
    /// Solution环境
    /// </summary>
    public class SolutionSetting : ViewModelReg
    {
        //是否支持多项目
        public bool IsSupportMultiProject { get => _IsSupportMultiProject; set { _IsSupportMultiProject = value;  WriteRegValue(value); NotifyPropertyChanged(); } }
        private bool _IsSupportMultiProject = ReadRegValue(nameof(IsSupportMultiProject));
    }

    /// <summary>
    /// 拍照选项
    /// </summary>
    public enum PhotoOptions
    {
        /// <summary>
        /// 拍照后回看
        /// </summary>
        Display,
        /// <summary>
        /// 拍照后浏览
        /// </summary>
        Browse,
    }
    public delegate void PhotoOptionsHandler(PhotoOptions photoOptions);


    /// <summary>
    /// 标注选项
    /// </summary>
    public enum DrawGraphicsOptions
    {
        /// <summary>
        /// 应用于图像文件
        /// </summary>
        File,
        /// <summary>
        /// 应用于窗口
        /// </summary>
        Window,
        /// <summary>
        /// 应用于工程
        /// </summary>
        Solution,
    }
    public delegate void DrawGraphicsOptionsHandler(DrawGraphicsOptions drawGraphicsOptions);




    public static class EnumExtension
    {
        public static string ToString1(this PhotoOptions This)
        {
            return This switch
            {
                PhotoOptions.Display => "拍照后回看",
                PhotoOptions.Browse => "拍照后浏览",
                _ => string.Empty,
            };
        }
        public static string ToString1(this DrawGraphicsOptions This)
        {
            return This switch
            {
                DrawGraphicsOptions.File => "应用于图像文件",
                DrawGraphicsOptions.Window => "应用于窗口",
                DrawGraphicsOptions.Solution => "应用于工程",
                _ => string.Empty,
            };
        }

    }





    /// <summary>
    /// 窗口配置
    /// </summary>
    public class WindowSetting : ViewModelReg
    {
        /// <summary>
        /// 是否显示日志
        /// </summary>
        public bool IsShowLog { get => _IsShowLog; set { _IsShowLog = value; WriteRegValue(value); NotifyPropertyChanged(); } }
        private bool _IsShowLog = ReadRegValue(nameof(IsShowLog));

        /// <summary>
        /// Left长度
        /// </summary>
        public double LeftViewWidth { get => _LeftViewWidth; set {  _LeftViewWidth = value;  WriteRegValue(value); NotifyPropertyChanged(); } }
        private double _LeftViewWidth = Convert.ToDouble(ReadRegValue("400",nameof(LeftViewWidth)));

        /// <summary>
        /// 拍照更改事件触发
        /// </summary>
        public event PhotoOptionsHandler PhotoOptionsChanged;
        
        public PhotoOptions PhotoOptions { get => _PhotoOptions; set { if (_PhotoOptions == value) return; _PhotoOptions = value; LambdaControl.Trigger("PhotoOptionsChanged",this,new Dictionary<string, object>() { { "Type",(int)value} }); PhotoOptionsChanged?.Invoke(value); WriteRegValue((int)value); NotifyPropertyChanged(); } }
        private PhotoOptions _PhotoOptions = (PhotoOptions)ReadRegValue(0, nameof(PhotoOptions));


        /// <summary>
        /// 标注更改事件触发
        /// </summary>
        public event DrawGraphicsOptionsHandler DrawGraphicsOptionsChanged;

        public DrawGraphicsOptions DrawGraphicsOptions { get => _DrawGraphicsOptions; set { if (_DrawGraphicsOptions == value) return; _DrawGraphicsOptions = value; LambdaControl.Trigger("DrawGraphicsOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)value } }); DrawGraphicsOptionsChanged?.Invoke(value); WriteRegValue((int)value); NotifyPropertyChanged(); } }
        private DrawGraphicsOptions _DrawGraphicsOptions = (DrawGraphicsOptions)ReadRegValue(1, nameof(DrawGraphicsOptions));


    }

}

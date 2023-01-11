using Global.Common;
using Global.Common.Util;
using Lambda;
using System.ComponentModel;
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
        [Description("拍照后回看")]
        Display,
        /// <summary>
        /// 拍照后预览
        /// </summary>
        [Description("拍照后预览")]
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
        [Description("应用于图像文件")]
        File,
        /// <summary>
        /// 应用于窗口
        /// </summary>
        [Description("应用于窗口")]
        Window,
        /// <summary>
        /// 应用于工程
        /// </summary>
        [Description("应用于工程")]
        Solution,
    }
    public delegate void DrawGraphicsOptionsHandler(DrawGraphicsOptions drawGraphicsOptions);

    /// <summary>
    /// 图像分辨率
    /// </summary>
    public enum ImageResolutionOptions
    {
        /// <summary>
        /// 自动
        /// </summary>
        [Description("适应屏幕")]
        Auto,
        /// <summary>
        /// 最大分辨率
        /// </summary>
        [Description("最大分辨率")]
        Max,
    }
    public delegate void ImageResolutionOptionsHandler(ImageResolutionOptions imageResolutionOptions);




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
        
        public PhotoOptions PhotoOptions { get => _PhotoOptions; set { if (_PhotoOptions == value) return; _PhotoOptions = value; LambdaControl.Trigger("PhotoOptionsChanged",this,new Dictionary<string, object>() { { "Type",(int)value} }); WriteRegValue((int)value); NotifyPropertyChanged(); PhotoOptionsChanged?.Invoke(value); } }
        private PhotoOptions _PhotoOptions = (PhotoOptions)ReadRegValue(0, nameof(PhotoOptions));


        /// <summary>
        /// 标注更改事件触发
        /// </summary>
        public event DrawGraphicsOptionsHandler DrawGraphicsOptionsChanged;

        public DrawGraphicsOptions DrawGraphicsOptions { get => _DrawGraphicsOptions; set { if (_DrawGraphicsOptions == value) return; _DrawGraphicsOptions = value; LambdaControl.Trigger("DrawGraphicsOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)value } });  WriteRegValue((int)value); NotifyPropertyChanged(); DrawGraphicsOptionsChanged?.Invoke(value); } }
        private DrawGraphicsOptions _DrawGraphicsOptions = (DrawGraphicsOptions)ReadRegValue(1, nameof(DrawGraphicsOptions));

        /// <summary>
        /// 图像显示分辨率更改事件
        /// </summary>
        public event ImageResolutionOptionsHandler ImageResolutionShowOptionsChanged;

        public ImageResolutionOptions ImageResolutionShowOptions { get => _ImageResolutionShowOptions; set { if (_ImageResolutionShowOptions == value) return; _ImageResolutionShowOptions = value; LambdaControl.Trigger("ImageResolutionShowOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)value } }); WriteRegValue((int)value); NotifyPropertyChanged(); ImageResolutionShowOptionsChanged?.Invoke(value); } }
        private ImageResolutionOptions _ImageResolutionShowOptions = (ImageResolutionOptions)ReadRegValue(1, nameof(ImageResolutionShowOptions));

        /// <summary>
        /// 图像保存分辨率更改事件
        /// </summary>
        public event ImageResolutionOptionsHandler ImageResolutionSaveOptionsChanged;

        public ImageResolutionOptions ImageResolutionSaveOptions { get => _ImageResolutionSaveOptions; set { if (_ImageResolutionSaveOptions == value) return; _ImageResolutionSaveOptions = value; LambdaControl.Trigger("ImageResolutionSaveOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)value } }); WriteRegValue((int)value); NotifyPropertyChanged(); ImageResolutionSaveOptionsChanged?.Invoke(value); } }
        private ImageResolutionOptions _ImageResolutionSaveOptions = (ImageResolutionOptions)ReadRegValue(1, nameof(ImageResolutionSaveOptions));

    }

}

using Global.Common;
using Global.Common.Extensions;
using Lambda;
using Solution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace XSolution
{
    /// <summary>
    /// GRIF模态
    /// </summary>
    public enum GrifFileOperatingMode
    {
        /// <summary>
        /// 明场
        /// </summary>
        [Description("明场")] BF,
        /// <summary>
        /// 暗场
        /// </summary>
        [Description("暗场")] DF,
        /// <summary>
        /// 差分相衬
        /// </summary>
        [Description("差分相衬")] DP,
        /// <summary>
        /// 莱茵伯格
        /// </summary>
        [Description("莱茵伯格")] RI,
        /// <summary>
        /// 定量相位
        /// </summary>
        [Description("定量相位")] QP,
        /// <summary>
        /// 相差
        /// </summary>
        [Description("相差")] PC,
        /// <summary>
        /// 荧光
        /// </summary>
        [Description("荧光")] FL,
        /// <summary>
        /// 未定模态
        /// </summary>
       [Description("未定模态")] NULL
    }


    public class GrifFile : ProjectFile, IProjectFile
    {
        #region Field
        public ContextMenu ContextMenu { get; set; }
        /// <summary>
        /// 拍摄模态
        /// </summary>
        public GrifFileOperatingMode OperatingMode { get; set; }
        public string OperatingModeString { get => OperatingMode.ToDescription(); }
        public GrifFileMeta GrifFileMeta { get; private set; }

        public RelayCommand GrifExportAsCommand { get; set; }

        public RelayCommand ExportAsTiffCommand { get; set; }
        public RelayCommand ExportAsJPEGCommand { get; set; }

        public RelayCommand ExportAsPNGCommand { get; set; }
        public RelayCommand ExportAsBMPCommand { get; set; }

        #endregion

        public new string[] SupportExtensions()
        {
            return new string[] { ".grif" };
        }


        public GrifFile(string FullName) : base(FullName)
        {
            Icon = new BitmapImage(new Uri(ThemeManager.ThemeManagers.CurrentUITheme == ThemeManager.Theme.Dark ? $"/Solution;component/images/grif1.png": $"/Solution;component/images/grif.png", UriKind.Relative));
            ThemeManager.ThemeManagers.ThemeChanged += (s) =>
            {
                Icon = new BitmapImage(new Uri(s == ThemeManager.Theme.Dark ? $"/Solution;component/images/grif1.png" : $"/Solution;component/images/grif.png", UriKind.Relative));
            };
            GrifFileMeta = GrifFileManger.GetInstance().ReadGrifFileInfo(FullName);
            AttributesCommand = new RelayCommand(OpenAttributes, (value) => { return true; });
            ExportAsTiffCommand = new RelayCommand((o) => { new GrifExportAsWindow(this, GrifExportKinds.tiff).ShowDialog(); }, (object value) => { return true; });
            ExportAsJPEGCommand = new RelayCommand((o) => { new GrifExportAsWindow(this, GrifExportKinds.jpeg).ShowDialog(); }, (object value) => { return true; });
            ExportAsPNGCommand = new RelayCommand((o) => { new GrifExportAsWindow(this, GrifExportKinds.png).ShowDialog(); }, (object value) => { return true; });
            ExportAsBMPCommand = new RelayCommand((o) => { new GrifExportAsWindow(this, GrifExportKinds.bmp).ShowDialog(); }, (object value) => { return true; });
            GrifExportAsCommand = new RelayCommand((o) => { new GrifExportAsWindow(this).ShowDialog(); }, (object value) => { return true; });
            OpenFileCommand = new RelayCommand((o) => {
                LambdaControl.Trigger("SolutionGrifFileOpen", this, FullName);
            }, (object value) => { return true; });
            var OMstring = Path.GetFileNameWithoutExtension(Name).Split('-');
            if (OMstring.Length>1&& OMstring[0] is string str)
            {
                this.OperatingMode = ConverOperatingMode(str);
            }
            ContextMenu = new ContextMenu();
            ContextMenu.Items.Add(new MenuItem() { Header = "打开(_O)", Command = OpenFileCommand, CommandParameter = this });
            ContextMenu.Items.Add(new MenuItem() { Header = "删除(_D)", Command = DeleteCommand, CommandParameter = this });
            ContextMenu.Items.Add(new MenuItem() { Header = "重命名(_M)", Command = Commands.ReName, CommandParameter = this });
            ContextMenu.Items.Add(new MenuItem() { Header = "复制(_M)", Command = ApplicationCommands.Copy, CommandParameter = this });
            ContextMenu.Items.Add(new Separator());

            MenuItem menuExport = new MenuItem() { Header = "导出(_E)" };
            menuExport.Items.Add(new MenuItem() { Header = "导出为", Command = GrifExportAsCommand, CommandParameter = this });
            menuExport.Items.Add(new Separator());
            menuExport.Items.Add(new MenuItem() { Header = "导出BMP..", Command = ExportAsBMPCommand, CommandParameter = this });
            menuExport.Items.Add(new MenuItem() { Header = "导出Tiff...", Command = ExportAsTiffCommand, CommandParameter = this });
            menuExport.Items.Add(new MenuItem() { Header = "导出JPEG...", Command = ExportAsJPEGCommand, CommandParameter = this });
            menuExport.Items.Add(new MenuItem() { Header = "导出PNG...", Command = ExportAsPNGCommand, CommandParameter = this });
            ContextMenu.Items.Add(menuExport);
            ContextMenu.Items.Add(new Separator());
            ContextMenu.Items.Add(new MenuItem() { Header = "取消隐藏", Command = VisibilityUnHidden, CommandParameter = this });
            ContextMenu.Items.Add(new MenuItem() { Header = "属性(_R)" , Command = AttributesCommand ,CommandParameter =this});
        }



        #region Public Properties
        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsCheck { get => _IsCheck; set { _IsCheck = value; NotifyPropertyChanged(); } }
        private bool _IsCheck = false;
        #endregion

        private void OpenAttributes(object value)
        {
            GrifFileMeta grifFile = GrifFileMeta;
            MessageBox1.Show($"Name:{grifFile.Name}\n\rx:{grifFile.x}\n\ry:{grifFile.y}\n\rz:{grifFile.z}", this.Name + "属性");
        }

        public static GrifFileOperatingMode ConverOperatingMode(string OperatingMode)
        {
            return OperatingMode.ToUpper() switch
            {
                "BF" => GrifFileOperatingMode.BF,
                "DF" => GrifFileOperatingMode.DF,
                "DP" => GrifFileOperatingMode.DP,
                "RI" => GrifFileOperatingMode.RI,
                "QP" => GrifFileOperatingMode.QP,
                "PC" => GrifFileOperatingMode.PC,
                "FL" => GrifFileOperatingMode.FL,
                _ => GrifFileOperatingMode.NULL,
            };
        }

    }
}

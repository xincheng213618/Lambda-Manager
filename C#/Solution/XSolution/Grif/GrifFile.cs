using Global.Common;
using Solution;
using System;
using System.Drawing;
using System.IO;
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
        BF,
        /// <summary>
        /// 暗场
        /// </summary>
        DF,
        /// <summary>
        /// 差分相衬
        /// </summary>
        DP,
        /// <summary>
        /// 莱茵伯格
        /// </summary>
        RI,
        /// <summary>
        /// 定量相位
        /// </summary>
        QP,
        /// <summary>
        /// 相差
        /// </summary>
        PC,
        /// <summary>
        /// 荧光
        /// </summary>
        FL,
        /// <summary>
        /// 未定模态
        /// </summary>
        NULL
    }

    public class GrifFile : ProjectFile, IProjectFile
    {
        
        public new string[] SupportExtensions()
        {
            return new string[] { ".grif" };
        }
        
        /// <summary>
        /// 拍摄模态
        /// </summary>
        public GrifFileOperatingMode OperatingMode { get; set; }

        public GrifFileMeta GrifFileMeta { get; private set; }

        public RelayCommand GrifExportAsCommand { get; set; }

        public RelayCommand ExportAsTiffCommand { get; set; }
        public RelayCommand ExportAsJPEGCommand { get; set; }

        public RelayCommand ExportAsPNGCommand { get; set; }
        public RelayCommand ExportAsBMPCommand { get; set; }

        public GrifFile(string FullName) : base(FullName)
        {

            Icon = new BitmapImage(new Uri(ThemeManager.ThemeManagers.CurrentUITheme == ThemeManager.Theme.Dark ? $"/Solution;component/images/grif1.png": $"/Solution;component/images/grif.png", UriKind.Relative));

            GrifExportAsCommand = new RelayCommand(GrifExportAsWindow, (value) => { return true; });
            GrifFileMeta = GrifFileManger.GetInstance().ReadGrifFileInfo(FullName);
            AttributesCommand = new RelayCommand(OpenAttributes, (value) => { return true; });
            ExportAsTiffCommand = new RelayCommand(ExportAsTiff, (object value) => { return true; });
            ExportAsJPEGCommand = new RelayCommand(ExportAsJPEG, (object value) => { return true; });
            ExportAsPNGCommand = new RelayCommand(ExportAsPNG, (object value) => { return true; });
            ExportAsBMPCommand = new RelayCommand(ExportAsBMP, (object value) => { return true; });

            var OperatingMode = Path.GetFileNameWithoutExtension(FullName).Split('-');
            if (OperatingMode.Length>1&& OperatingMode[0] is string str)
            {
                switch (str.ToUpper())
                {
                    case "BF":
                        this.OperatingMode = GrifFileOperatingMode.BF;
                        break;
                    case "DF":
                        this.OperatingMode = GrifFileOperatingMode.DF;
                        break;
                    case "DP":
                        this.OperatingMode = GrifFileOperatingMode.DP;
                        break;
                    case "RI":
                        this.OperatingMode = GrifFileOperatingMode.RI;
                        break;
                    case "QP":
                        this.OperatingMode = GrifFileOperatingMode.QP;
                        break;
                    case "PC":
                        this.OperatingMode = GrifFileOperatingMode.PC;
                        break;
                    case "FL":
                        this.OperatingMode = GrifFileOperatingMode.FL;
                        break;
                    default:
                        this.OperatingMode = GrifFileOperatingMode.NULL;
                        break;
                }
            }
        }

        private bool isCheck = false;
        public bool IsCheck
        {
            get { return isCheck; }
            set { isCheck = value;  NotifyPropertyChanged(); }
        }




        private void ExportAsBMP(object value)
        {
            GrifExportAsWindow grifExportAsWindow = new GrifExportAsWindow(this, GrifExportKinds.bmp);
            grifExportAsWindow.ShowDialog();
        }
        private void ExportAsTiff(object value)
        {
            GrifExportAsWindow grifExportAsWindow = new GrifExportAsWindow(this, GrifExportKinds.tiff);
            grifExportAsWindow.ShowDialog();
        }
        private void ExportAsJPEG(object value)
        {
            GrifExportAsWindow grifExportAsWindow = new GrifExportAsWindow(this, GrifExportKinds.jpeg);
            grifExportAsWindow.ShowDialog();
        }
        private void ExportAsPNG(object value)
        {
            GrifExportAsWindow grifExportAsWindow = new GrifExportAsWindow(this, GrifExportKinds.png);
            grifExportAsWindow.ShowDialog();
        }

        private void GrifExportAsWindow(object value)
        {
            GrifExportAsWindow grifExportAsWindow = new GrifExportAsWindow(this);
            grifExportAsWindow.ShowDialog();
        }
        private void OpenAttributes(object value)
        {
            GrifFileMeta grifFile;
            if (value is GrifFile grifFile1)
            {
                grifFile = grifFile1.GrifFileMeta;
                MessageBox1.Show($"Name:{grifFile.Name}\n\rx:{grifFile.x}\n\ry:{grifFile.y}\n\rz:{grifFile.z}", "GRIF");
            }
        }

    }
}

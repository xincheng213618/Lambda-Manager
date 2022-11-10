using Global.Common;
using Solution;

namespace XSolution
{

    public class GrifFile : ProjectFile, IProjectFile
    {
        public new string[] SupportExtensions()
        {
            return new string[] { ".grif" };
        }

        public GrifFileMeta GrifFileMeta { get; private set; }

        public RelayCommand GrifExportAsCommand { get; set; }


        public RelayCommand ExportAsTiffCommand { get; set; }
        public RelayCommand ExportAsJPEGCommand { get; set; }

        public RelayCommand ExportAsPNGCommand { get; set; }
        public RelayCommand ExportAsBMPCommand { get; set; }

        public GrifFile(string FullName) : base(FullName)
        {
            GrifExportAsCommand = new RelayCommand(GrifExportAsWindow, (value) => { return true; });
            GrifFileMeta = GrifFileManger.GetInstance().ReadGrifFileInfo(FullName);
            AttributesCommand = new RelayCommand(OpenAttributes, (value) => { return true; });
            ExportAsTiffCommand = new RelayCommand(ExportAsTiff, (object value) => { return true; });
            ExportAsJPEGCommand = new RelayCommand(ExportAsJPEG, (object value) => { return true; });
            ExportAsPNGCommand = new RelayCommand(ExportAsPNG, (object value) => { return true; });
            ExportAsBMPCommand = new RelayCommand(ExportAsBMP, (object value) => { return true; });
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
                MessageBox1.Show($"Name:{grifFile.Name}\n\rx:{grifFile.x}\n\ry:{grifFile.y}\n\rz:{grifFile.z}", "grif");
            }
        }

    }
}

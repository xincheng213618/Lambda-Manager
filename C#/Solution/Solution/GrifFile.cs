using Global.Common;
using Solution;
using System.Runtime.InteropServices;

namespace XSolution
{

    public class GrifFile : ProjectFile
    {
        [DllImport("lib\\CustomFile.dll")]
        public static extern GrifFileMeta ReadFileInfo(string filepath);

        public GrifFileMeta GrifFileMeta {  get; private set; }

        public RelayCommand GrifExportAsCommand { get; set; }


        public GrifFile(string FullName) : base(FullName)
        {
            GrifExportAsCommand = new RelayCommand(GrifExportAsWindow, (value) => { return true; });
            GrifFileMeta =  ReadFileInfo(FullName);
            AttributesCommand = new RelayCommand(OpenAttributes, (object value) => { return true; });

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

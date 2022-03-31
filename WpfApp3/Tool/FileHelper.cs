using Microsoft.Win32;

namespace WpfApp3
{
    public class FileHelper
    {
        public static bool OpenFileDialog(out string FileName)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.lmp)|*.lmp",
            };
            bool? result = dialog.ShowDialog();
            FileName = dialog.FileName;
            return result == true;
        }
    }



}

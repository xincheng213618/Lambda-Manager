using Microsoft.Win32;
using System;
using System.IO;

namespace Tool
{
    public static class Utils
    {
        public static bool OpenFileDialog(out string FileName)
        {
            OpenFileDialog dialog = new()
            {
                Multiselect = false,//该值确定是否可以选择多个文件
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.gprj)|*.gprj",
            };
            bool? result = dialog.ShowDialog();
            FileName = dialog.FileName;
            return result == true;
        }

        public static bool SaveFileDialog(out string FileName)
        {
            SaveFileDialog dialog = new()
            {
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.gprj)|*.gprj",
            };
            bool? result = dialog.ShowDialog();
            FileName = dialog.FileName;
            return result == true;
        }

        /// <summary>
        /// 另存为
        /// </summary>
        /// <returns></returns>
        public static bool SaveAsDialog(out string FileName)
        {
            SaveFileDialog dialog = new()
            {
                Title = "另存为",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.lmp)|*.lmp",
                FileName ="新建工程1.lmp"
            };
            bool? result = dialog.ShowDialog();
            FileName = dialog.FileName;
            return result == true;
        }
    }
}

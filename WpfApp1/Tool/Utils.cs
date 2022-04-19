using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                Filter = "显微镜工程(*.lmp)|*.lmp",
            };
            bool? result = dialog.ShowDialog();
            FileName = dialog.FileName;
            return result == true;
        }

        public static bool SelectFileDialog(out string FileName)
        {
            SaveFileDialog dialog = new()
            {
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "显微镜工程(*.lmp)|*.lmp",
            };
            bool? result = dialog.ShowDialog();
            FileName = dialog.FileName;
            return result == true;
        }


        /// <summary>s
        /// 文本
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return true;
            }
            if (text.Equals("null"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 取得存储资源
        /// </summary>
        /// <returns></returns>
        public static string LoadResource(string res)
        {
            string result = string.Empty;

            try
            {
                using (StreamReader reader = new StreamReader(res))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using UserRegister.ViewModel;
using UserRegister.Helpers;

namespace UserRegister
{
    public class OffLineRegister
    {
        public static void Registering(string path, string path0,string path1)
        {
            if (!File.Exists(path0))
            {
                MessageBox.Show("请将离线注册包register.pkg文件，放入软件运行目录");
                return;
            }
            if (System.IO.Directory.Exists(path1))
            {
                DeleteFolder(path1);//存在就删除
            }
            //ZipFile.ExtractToDirectory(path0, path);
            string msg;
            Zips.ExtractFile(path0, path1, "123456", out msg);
            string json = File.ReadAllText(path1 + "/register.json");
            OffLineViewModel offlineRegister = JsonSerializer.Deserialize<OffLineViewModel>(json);
            if (offlineRegister != null)
            {
                foreach (var item in offlineRegister.FeatureList)
                {
                    CopyToFile(path1, path, item.Code);
                }
            }

            if (System.IO.Directory.Exists(path1))
            {
                DeleteFolder(path1);//存在就删除
            }

        }

        private static void DeleteFolder(String path)
        {

            if (Directory.Exists(path))
            {
                var dirs = Directory.GetDirectories(path);
                for (int index = 0; index < dirs.Length; ++index)
                {
                    Directory.Delete(dirs[index], true);
                }
                var files = Directory.GetFiles(path);
                for (int index = 0; index < files.Length; ++index)
                {
                    File.Delete(files[index]);
                }
                Directory.Delete(path, true);
            }
           
        }
        public static string ReadOfflineRegister(string path)
        {
            string jsonString = File.ReadAllText(path);
            return jsonString;
        }
        private static void CopyToFile(string srcFolder, string destFolder, string fileName)
        {

            if (Directory.Exists(destFolder) == false)
            {
                Directory.CreateDirectory(destFolder);
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(srcFolder);
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (FileInfo file in files) // Directory.GetFiles(srcFolder)
            {
                if (file.Name == fileName)
                {
                    file.CopyTo(System.IO.Path.Combine(destFolder, file.Name), true); //复制 ，剪切的话file.MoveTo();file.CopyTo是拷贝到另外一个文件夹
                                                                                      //file.Delete();
                }
            }
        }





    }
}

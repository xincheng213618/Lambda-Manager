using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;
using System.IO;

namespace UserRegister.Helpers
{
    public class Zips
    {
        /// <summary>
        /// 压缩文件/文件夹
        /// </summary>
        /// <param name="filePath">需要压缩的文件/文件夹路径</param>
        /// <param name="zipPath">压缩文件路径（zip后缀）</param>
        /// <param name="password">密码</param>
        /// <param name="filterExtenList">需要过滤的文件后缀名</param>
        public static void CompressionFile(string filePath, string zipPath, string password = "", List<string> filterExtenList = null)
        {
            try
            {
                using (ZipFile zip = new ZipFile(Encoding.UTF8))
                {
                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        zip.Password = password;
                    }
                    if (Directory.Exists(filePath))
                    {
                        if (filterExtenList == null)
                            zip.AddDirectory(filePath);
                        else
                            AddDirectory(zip, filePath, filePath, filterExtenList);
                    }
                    else if (File.Exists(filePath))
                    {
                        zip.AddFile(filePath, "");
                    }
                    zip.Save(zipPath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 添加文件夹
        /// </summary>
        /// <param name="zip">ZipFile对象</param>
        /// <param name="dirPath">需要压缩的文件夹路径</param>
        /// <param name="rootPath">根目录路径</param>
        /// <param name="filterExtenList">需要过滤的文件后缀名</param>
        public static void AddDirectory(ZipFile zip, string dirPath, string rootPath, List<string> filterExtenList)
        {
            var files = Directory.GetFiles(dirPath);
            for (int i = 0; i < files.Length; i++)
            {
                //如果Contains不支持第二个参数，就用.ToLower()
                if (filterExtenList == null || (filterExtenList != null && !filterExtenList.Any(d => Path.GetExtension(files[i]).Contains(d, StringComparison.OrdinalIgnoreCase))))
                {
                    //获取相对路径作为zip文件中目录路径
                    zip.AddFile(files[i], Path.GetRelativePath(rootPath, dirPath));

                    //如果没有Path.GetRelativePath方法，可以用下面代码替换
                    //string relativePath = Path.GetFullPath(dirPath).Replace(Path.GetFullPath(rootPath), "");
                    //zip.AddFile(files[i], relativePath);
                }
            }
            var dirs = Directory.GetDirectories(dirPath);
            for (int i = 0; i < dirs.Length; i++)
            {
                AddDirectory(zip, dirs[i], rootPath, filterExtenList);
            }
        }

        public static bool ExtractFile(String sourceFileFullPath, String targetFolderPath, string password, out String errMessage)
        {
            try
            {
                Encoding encoding = Encoding.UTF8;
                errMessage = String.Empty;
                var options = new ReadOptions { StatusMessageWriter = System.Console.Out, Encoding = encoding };
                using (ZipFile zip = ZipFile.Read(sourceFileFullPath, options))
                {
                    zip.Password = password;
                    zip.AlternateEncoding = encoding;
                    zip.ExtractAll(targetFolderPath, ExtractExistingFileAction.OverwriteSilently);//一次批量解压
                    return true;
                }
            }
            catch (Exception ex)
            { errMessage = ex.Message;
                return false;
            }
        }




        //public static bool ExtractFile(String sourceFileFullPath, String targetFolderPath)
        //{
        //    try
        //    {
        //        Encoding encoding = Encoding.UTF8;

        //        var options = new ReadOptions { StatusMessageWriter = System.Console.Out, Encoding = encoding };
        //        using (ZipFile zip = ZipFile.Read(sourceFileFullPath, options))
        //        {
        //            zip.AlternateEncoding = encoding;
        //            foreach (var f in zip.Entries)
        //            {//一个个解压
        //                f.Extract(targetFolderPath, ExtractExistingFileAction.OverwriteSilently);
        //            }

        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }

        //    /// <summary>
        //    /// 解压文件
        //    /// </summary>
        //    /// <param name="zipPath">压缩文件路径</param>
        //    /// <param name="dirPath">解压到文件夹路径</param>
        //    /// <param name="password">密码</param>
        //    public static void DeCompressionFile(string zipPath, string dirPath, string password = "")
        //{
        //    if (!File.Exists(zipPath))
        //    {
        //        throw new ArgumentNullException("zipPath压缩文件不存在");
        //    }
        //    Directory.CreateDirectory(dirPath);
        //    try
        //    {
        //        using (Stream stream = File.OpenRead(zipPath))
        //        {
        //            var option = new ReaderOptions()
        //            {
        //                ArchiveEncoding = new SharpCompress.Common.ArchiveEncoding()
        //                {
        //                    Default = Encoding.UTF8
        //                }
        //            };
        //            if (!string.IsNullOrWhiteSpace(password))
        //            {
        //                option.Password = password;
        //            }

        //            var reader = ReaderFactory.Open(stream, option);
        //            while (reader.MoveToNextEntry())
        //            {
        //                if (reader.Entry.IsDirectory)
        //                {
        //                    Directory.CreateDirectory(Path.Combine(dirPath, reader.Entry.Key));
        //                }
        //                else
        //                {
        //                    //创建父级目录，防止Entry文件,解压时由于目录不存在报异常
        //                    var file = Path.Combine(dirPath, reader.Entry.Key);
        //                    Directory.CreateDirectory(Path.GetDirectoryName(file));
        //                    reader.WriteEntryToFile(file);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool
{
    public class MemorySize
    {

        //所给路径中所对应的文件大小
        public static long FileSize(string filePath)
        {
            //定义一个FileInfo对象，是指与filePath所指向的文件相关联，以获取其大小
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        /// <summary>
        /// 获取指定路径的大小
        /// </summary>
        /// <param name="dirPath">路径</param>
        /// <returns></returns>
        public static long GetDirectoryLength(string dirPath)
        {
            long len = 0;
            //判断该路径是否存在（是否为文件夹）
            if (!Directory.Exists(dirPath))
            {
                //查询文件的大小
                len = FileSize(dirPath);
            }
            else
            {
                //定义一个DirectoryInfo对象
                DirectoryInfo di = new DirectoryInfo(dirPath);

                //通过GetFiles方法，获取di目录中的所有文件的大小
                foreach (FileInfo fi in di.GetFiles())
                {
                    len += fi.Length;
                }
                //获取di中所有的文件夹，并存到一个新的对象数组中，以进行递归
                DirectoryInfo[] dis = di.GetDirectories();
                if (dis.Length > 0)
                {
                    for (int i = 0; i < dis.Length; i++)
                    {
                        len += GetDirectoryLength(dis[i].FullName);
                    }
                }
            }
            return len;
        }


        /// <summary>
        /// 内存大小转文本
        /// </summary>
        /// <returns></returns>
        public static string MemorySizeText(long memorySize)
        {
            if (memorySize < 1024)
            {
                return memorySize + " Byte";
            }
            if (memorySize < 10240)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0) + " kB";
            }
            if (memorySize < 1048576)
            {
                return memorySize / 1024u + " kB";
            }
            if (memorySize < 10485760)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0 / 1024.0) + " MB";
            }
            if (memorySize < 1073741824)
            {
                return memorySize / 1024u / 1024u + " MB";
            }
            if (memorySize < 10737418240L)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0 / 1024.0 / 1024.0) + " GB";
            }
            if (memorySize < 1099511627776L)
            {
                return memorySize / 1024u / 1024u / 1024u + " GB";
            }
            if (memorySize < 10995116277760L)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0 / 1024.0 / 1024.0 / 1024.0) + " TB";
            }
            return memorySize / 1024u / 1024u / 1024u / 1024u + " TB";
        }
    }
}

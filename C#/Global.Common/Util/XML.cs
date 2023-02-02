using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Global.Common.Util
{
    public static class XML
    {
        /// <summary>
        /// 对象序列化成XML文件
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="fileName">序列化的XML文件路径</param>
        public static int ToXMLFile(object obj, string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                //创建流
                using var fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                //创建XML序列化器，需要指定对象的类型
                var serializer = new XmlSerializer(obj.GetType());
                //序列化执行
                serializer.Serialize(fs, obj);
                return 0;
            }
            catch(Exception ex)
            {
                Trace.WriteLine("### [" + ex.Source + "] Exception: " + ex.Message);
                Trace.WriteLine("### " + ex.StackTrace);
                return -1;
            }
        }
    }
}

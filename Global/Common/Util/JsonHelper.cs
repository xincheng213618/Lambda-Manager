using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace Global.Common.Util
{
    /// <summary>
    /// Json辅助类
    /// </summary>
    public static class JsonHelper
    {

        /// <summary>
        /// 序列化成Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(Object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// 保存成json文件
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static int ToJsonFile(Object obj, string filePath, bool nullValue = true)
        {
            int result;
            try
            {
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer;
                    if (nullValue)
                    {
                        serializer = new JsonSerializer() { Formatting = Formatting.Indented };
                    }
                    else
                    {
                        serializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
                    }
                    serializer.Serialize(file, obj);
                }
                result = 0;
            }
            catch(Exception ex)
            {
                Trace.WriteLine("### [" + ex.Source + "] Exception: " + ex.Message);
                Trace.WriteLine("### " + ex.StackTrace);
                result = -1;
            }
            return result;
        }



    }
}

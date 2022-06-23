using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;


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
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions());
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
                string jsonString = JsonSerializer.Serialize(obj);
                File.WriteAllText(filePath, jsonString);
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

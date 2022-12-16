using Global.Common.Util;
using System;

namespace Global.Common.Extensions
{
    /// <summary>
    /// 对ViewMode的扩展
    /// </summary>
    public static class ViewModeBaseExtensions
    {
        /// <summary>
        /// 导出Json
        /// </summary>
        public static string ToJson(this ViewModelBase This) => This.SerializeJson();

        /// <summary>
        /// 导出Json文件
        /// </summary>
        public static int ToJsonFile(this ViewModelBase This, string filePath, bool nullValue = false) => Json.ToJsonFile(This, filePath, nullValue);

        /// <summary>
        /// 导出XML
        /// </summary>

        public static string ToXML(this ViewModelBase This) => This.SerializeXml();
        /// <summary>
        /// 导出XML文件
        /// </summary>

        public static int ToXMLFile(this ViewModelBase This, string filePath) => XML.ToXMLFile(This, filePath);
    }
}

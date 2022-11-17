using Global.Common.Util;
using System;

namespace Global.Common.Extensions
{
    /// <summary>
    /// 对ViewMode的扩展，可以不这么写
    /// </summary>
    public static class ViewModeBaseExtensions
    {
        /// <summary>
        /// 导出json
        /// </summary>
        public static string ToJson(this ViewModelBase This)
        {
            return JsonHelper.ToJson(This);
        }

        public static int ToJsonFile(this ViewModelBase This, string filePath)
        {
            return JsonHelper.ToJsonFile(This, filePath, false);
        }

        public static string ToXML(this ViewModelBase This)
        {
            return This.SerializeXml();
        }

        public static int ToXMLFile(this ViewModelBase This, string filePath)
        {
            return XMLHelpr.ToXMLFile(This, filePath);
        }
    }
}

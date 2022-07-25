using Global.Common.Util;
using System;

namespace Global.Common.Extensions
{
    public static class ViewModeBaseExtensions
    {
        /// <summary>
        /// 导出json
        /// </summary>
        public static string ToJson(this ViewModelBase viewModeBase)
        {
            if (viewModeBase == null)   
                throw new ArgumentNullException(nameof(viewModeBase));
            return JsonHelper.ToJson(viewModeBase);
        }

        public static int ToJsonFile(this ViewModelBase viewModeBase, string filePath)
        {
            if (viewModeBase == null)
                throw new ArgumentNullException(nameof(viewModeBase));
            return JsonHelper.ToJsonFile(viewModeBase, filePath, false);
        }

        public static string ToXML(this ViewModelBase viewModeBase)
        {
            if (viewModeBase == null)
                throw new ArgumentNullException(nameof(viewModeBase));
            return viewModeBase.SerializeXml();
        }

        public static int ToXMLFile(this ViewModelBase viewModeBase, string filePath)
        {
            if (viewModeBase == null)
                throw new ArgumentNullException(nameof(viewModeBase));
            return XMLHelpr.ToXMLFile(viewModeBase, filePath);
        }
    }
}

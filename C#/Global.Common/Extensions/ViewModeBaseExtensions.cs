using Global.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Common.Extensions
{
    public static class ViewModeBaseExtensions
    {
        /// <summary>
        /// 导出json
        /// </summary>
        public static string ToJson(this ViewModelBase This)
        {
            return Json.ToJson(This);
        }

        public static int ToJsonFile(this ViewModelBase This, string filePath)
        {
            return Json.ToJsonFile(This, filePath, false);
        }

        public static string ToXML(this ViewModelBase This)
        {
            return This.SerializeXml();
        }

        public static int ToXMLFile(this ViewModelBase This, string filePath)
        {
            return XML.ToXMLFile(This, filePath);
        }
    }
}

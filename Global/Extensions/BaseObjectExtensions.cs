using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Extensions
{
    public static class BaseObjectExtensions
    {
        public static string ToJson(this ModeBaseObject modeBaseObject)
        {
            return Utils.ToJson(modeBaseObject);
        }

        public static int ToJsonFile(this ModeBaseObject modeBaseObject , string filePath)
        {
            return Utils.ToJsonFile(modeBaseObject, filePath, false);
        }
    }
}

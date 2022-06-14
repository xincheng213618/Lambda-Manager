using Global.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NLGSolution.JsonHelper
{
    public static class ViewModeBaseExtension
    {
        public static int ToJsonFile(this ViewModeBase viewModeBase, string filePath)
        {
            if (viewModeBase == null)
                throw new ArgumentNullException(nameof(viewModeBase));

            int result;
            try
            {
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer;
                    string[] props = { "FullPath", "Children" }; //排除掉，不能让前端看到的字段。为true的话就是只保留这些字段
                    serializer = JsonSerializer.Create(new JsonSerializerSettings() { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
                    //serializer.ContractResolver = new LimitPropsContractResolver(props, true);
                    serializer.Serialize(file, viewModeBase);

            }
                result = 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("### [" + ex.Source + "] Exception: " + ex.Message);
                Trace.WriteLine("### " + ex.StackTrace);
                result = -1;
            }
            return result;
        }
    }
}

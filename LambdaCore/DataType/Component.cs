using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LambdaManager.DataType
{
    public class Component
    {
        public string? Name { get; set; }

        public string? Lib { get; set; }

        public List<string>? Init { get; set; }

        public string? Mount { get; set; }

        public List<string>? Depend { get; set; }

        public List<Procedure>? Procedures { get; set; }

        public string? GetLibShortName()
        {
            if (Lib == null)
            {
                return null;
            }
            return Regex.Replace(Regex.Split(Lib, "[/\\\\]+")[^1], "\\.dll", "", RegexOptions.IgnoreCase);
        }

        public bool IsGUIComponent()
        {
            return Mount != null;
        }
    }
}

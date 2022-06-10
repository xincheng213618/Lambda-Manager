using Global.Common.Util;

namespace Global.Common.Extensions
{
    public static class ViewModeBaseExtensions
    {
        public static string ToJson(this ViewModeBase viewModeBase)
        {
            return JsonHelper.ToJson(viewModeBase);
        }

        public static int ToJsonFile(this ViewModeBase viewModeBase, string filePath)
        {
            return JsonHelper.ToJsonFile(viewModeBase, filePath, false);
        }
    }
}

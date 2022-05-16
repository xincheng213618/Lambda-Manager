using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global
{
    public static class Global
    {
        #region 常量
        public const string AboutUrl = @"http://www.njust-sci.com/";
        public const string UpdateUrl = @"http://www.njust-sci.com/";
        #endregion
        public const string ConfigFileName = "Config.json";

        public static string HardwareDeviceInformationSheet = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\LambdaManager\\ " + "HardwareDeviceInformationSheet";

        public static List<double> expose = new List<double> { 40000, 35714, 31250, 27778, 25000, 21739, 19608, 17241, 15385, 13514, 12048, 10753, 10000, 8403, 7463, 6623, 5882, 5208, 4630, 4000, 3636, 3226, 2865, 2545, 2252, 2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        public static List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000, 2.197, 2.477, 2.792, 3.148, 3.548, 4.000 };
    }
}

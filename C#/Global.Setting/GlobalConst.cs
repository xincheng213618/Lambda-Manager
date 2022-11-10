using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global.Setting
{
    public static class GlobalConst
    {
        public static List<double> expose = new List<double> {2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        public static List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000 };
       
        /// <summary>
        /// 相机分辨率
        /// </summary>
        public static List<string> CameraResolution = new() { "RGB32 (640x480)", "RGB32 (1280x960)", "RGB64 (2448x2048)" };


    }
}

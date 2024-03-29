﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Global.SettingUp
{
    /// <summary>
    /// 静态变量
    /// </summary>
    public static class Const
    {
        private const string AESKey = "U2FsdGVkX1+uzVdQ9o3dBluy9j7zRI0Gx3knpsLMmEY=";

        public static List<double> expose = new List<double> {2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        public static List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000 };
       
        /// <summary>
        /// 相机分辨率
        /// </summary>
        public static List<string> CameraResolution = new() { "RGB32 (1280x960)", "RGB32 (2448x1836)" };


    }
}

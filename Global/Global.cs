using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global
{
    public static class Global
    {
        public const string AboutUrl = @"http://www.njust-sci.com/";
        public const string UpdateUrl = @"http://www.njust-sci.com/";
        public const string ConfigFileName = "Config.json";
        
        /// <summary>
        ///  成像模式默认值
        /// </summary>
        public static class DefaultViewMode
        {
            /// <summary>
            /// 明场
            /// </summary>
            public static class BrightField
            {
                /// <summary>
                /// 孔径
                /// </summary>
                public const int Aperture = 10;
                /// <summary>
                /// 颜色
                /// </summary>
                public const int Color = 4095;
            };
            /// <summary>
            /// 暗场
            /// </summary>
            public static class DarkField
            {
                public const int InnerAperture = 10;
                public const int OutAperture = 32;
                public const int Color = 4095;
                public const double Gamma = 1.67;
            };
            /// <summary>
            /// 莱茵  
            /// </summary>
            public static class Reinberg
            {
                public const int InnerAperture = 10;
                public const int OutAperture = 32;
                public const int Mode = 0;
                public const int BrightColor = 4095;
                public const int DarkColor = 4095;
                public const int DarkColor1 = 4095;
            };

            public static class ReliefContrast
            {
                public const int InnerAperture = 10;
                public const int OutAperture = 32;
                public const double Gamma = 1.67;
                public const double Gain = 2.0;

                public const int Contrast = 5;
                public const double BFWeight = 1;
                public const double DPWeight = 1;
            }
            /// <summary>
            /// 相差
            /// </summary>
            public static class PhaseContrast
            {
                /// <summary>
                /// 相差滤波
                /// </summary>
                public const double Filter = 0.07;
                /// <summary>
                /// 对比度
                /// </summary>
                public const int Contrast = -1;
                /// <summary>
                /// 增益
                /// </summary>
                public const double Gain = 2.0;
                /// <summary>
                /// 背景抑制
                /// </summary>
                public const double Gamma = 1.67;
                /// <summary>
                /// 明场权重
                /// </summary>
                public const double BFWeight = 1;
                /// <summary>
                /// 相差权重
                /// </summary>
                public const double PCWeight = 1;
            }

            /// <summary>
            /// 相位
            /// </summary>
            public static class QuantitativePhase
            {
                /// <summary>
                /// 正则化参数
                /// </summary>
                public const double Regularization = 0.0001;
                /// <summary>
                /// 细节增强
                /// </summary>
                public const int Detail = 18;
                /// <summary>
                /// Min
                /// </summary>
                public const double Min = -7.2;
                /// <summary>
                ///  Max
                /// </summary>
                public const double Max = 21.3;
                /// <summary>
                /// 背景抑制
                /// </summary>
                public const double Gamma = 0.37;
            }






        };

        public static  List<double> expose = new List<double> { 40000, 35714, 31250, 27778, 25000, 21739, 19608, 17241, 15385, 13514, 12048, 10753, 10000, 8403, 7463, 6623, 5882, 5208, 4630, 4000, 3636, 3226, 2865, 2545, 2252, 2000, 1773, 1575, 1397, 1239, 1099, 1000, 864, 767, 680, 604, 535, 500, 421, 374, 331, 294, 250, 231, 205, 182, 161, 143, 120, 113, 100, 89, 79, 70, 60, 55, 49, 43, 38, 34, 30, 27, 24, 21, 19, 17, 15, 13, 12, 10, 9, 8, 7, 6, 5, 4 };
        public static List<double> expose1 = new List<double> { 0.287, 0.323, 0.364, 0.410, 0.463, 0.500, 0.588, 0.663, 0.747, 0.842, 1, 1.071, 1.207, 1.360, 1.534, 1.729, 2.000, 2.197, 2.477, 2.792, 3.148, 3.548, 4.000 };
    }
}

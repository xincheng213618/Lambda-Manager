using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Global.Common;

namespace Global.Mode
{
    public class HistogramModel : ViewModelBase
    {
        private string min = "0";
        /// <summary>
        /// 最小值
        /// </summary>
        public string Min
        {
            get { return min; }
            set { min = value; NotifyPropertyChanged(); }
        }

        private string max = "255";
        /// <summary>
        /// 最大值
        /// </summary>
        public string Max
        {
            get { return max; }
            set { max = value; NotifyPropertyChanged(); }
        }

        private string mean= "140";
        /// <summary>
        /// 平均值
        /// </summary>
        public string Mean
        {
            get { return mean; }
            set { mean = value; NotifyPropertyChanged(); }
        }

        private string variance = "128";
        /// <summary>
        /// 方差
        /// </summary>
        public string Variance
        {
            get { return variance; }
            set { variance = value; NotifyPropertyChanged(); }
        }

        private string gamma = "10";
        /// <summary>
        /// 伽马值
        /// </summary>
        public string Gamma
        {
            get { return gamma; }
            set { gamma = value; NotifyPropertyChanged(); }
        }

        private string outlier = "15%";
        /// <summary>
        /// 离群率
        /// </summary>
        public string Outlier
        {
            get { return outlier; }
            set { outlier = value; NotifyPropertyChanged(); }
        }

        private int rangeMin = 0;
        /// <summary>
        /// l离群率
        /// </summary>
        public int RangeMin
        {
            get { return rangeMin; }
            set { rangeMin = value; NotifyPropertyChanged(); }
        }
        private int rangeMax = 255;
        /// <summary>
        /// l离群率
        /// </summary>
        public int RangeMax
        {
            get { return rangeMax; }
            set { rangeMax = value; NotifyPropertyChanged(); }
        }





    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private string max = "14400";
        /// <summary>
        /// 最大值
        /// </summary>
        public string Max
        {
            get { return max; }
            set { max = value; NotifyPropertyChanged(); }
        }

        private int halfmax = 7200;
        /// <summary>
        /// 最大值
        /// </summary>
        public int HalfMax
        {
            get { return halfmax; }
            set { halfmax = value; NotifyPropertyChanged(); }
        }



        private string mean = "140";
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

        private double gamma = 1.00;
        /// <summary>
        /// 伽马值
        /// </summary>
        public double Gamma
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

        private bool phase = false;
        public bool Phase
        {
            get { return phase; }
            set { phase = value; NotifyPropertyChanged(); }

        }
        private int xAxisMin = 0;
        public int XAxisMin
        {
            get { return xAxisMin; }
            set { xAxisMin = value; NotifyPropertyChanged(); }
        }
        private int xAxisMax = 255;
        public int XAxisMax
        {
            get { return xAxisMax; }
            set { xAxisMax = value; NotifyPropertyChanged(); }
        }


        // phase 
        private double xAxisMinP = -10;
        public double XAxisMinP
        {
            get { return xAxisMinP; }
            set { xAxisMinP = value; NotifyPropertyChanged(); }
        }
        private double xAxisMaxP = 10;
        public double XAxisMaxP
        {
            get { return xAxisMaxP; }
            set { xAxisMaxP = value; NotifyPropertyChanged(); }
        }


        private double sliderMinP = -10;
        public double SliderMinP
        {
            get { return sliderMinP; }
            set { sliderMinP = value; NotifyPropertyChanged(); }
        }
        private double sliderMaxP = 10;
        public double SliderMaxP
        {
            get { return sliderMaxP; }
            set { sliderMaxP = value; NotifyPropertyChanged(); }
        }



        public ObservableCollection<string> RangList{ get; set; } = new ObservableCollection<string>() {"-5,5","-10,10","-20,20" };

        private string rangeSelectedItem = "-10,10";
        public string RangeSelectedItem
        {
            get { return rangeSelectedItem; }   
            set { rangeSelectedItem = value; NotifyPropertyChanged(); }
        }
        private double rangeMinP = -10;
        /// <summary>
        /// l离群率
        /// </summary>
        public double RangeMinP
        {
            get { return rangeMinP; }
            set { rangeMinP = value; NotifyPropertyChanged(); }
        }
        private double rangeMaxP = 10;
        /// <summary>
        /// l离群率
        /// </summary>
        public double RangeMaxP
        {
            get { return rangeMaxP; }
            set { rangeMaxP = value; NotifyPropertyChanged(); }
        }


        private bool moveEnable = false;
        public bool MoveEnable
        {
            get { return moveEnable; }
            set { moveEnable = value; NotifyPropertyChanged(); }
        }



    }
}

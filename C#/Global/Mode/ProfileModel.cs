using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using Global.Common;
using Global.UserControls.DrawVisual;
using OxyPlot;
using OxyPlot.Axes;

namespace Global.Mode
{
    public  class ProfileModel: ViewModelBase
    {
        private double ratio1 = 0.3;
        /// <summary>
        /// 最小值
        /// </summary>
        public double Ratio1
        {
            get { return ratio1; }
            set { ratio1 = value; NotifyPropertyChanged(); }
        }

        private double ratio2 = 0.7;
        /// <summary>
        /// 最小值
        /// </summary>
        public double Ratio2
        {
            get { return ratio2; }
            set { ratio2 = value; NotifyPropertyChanged(); }
        }


        private string max = "10";
        /// <summary>
        /// 最大值
        /// </summary>
        public string Max
        {
            get { return max; }
            set { max = value; NotifyPropertyChanged(); }
        }

        private int halfmax = 5;
        /// <summary>
        /// 最大值
        /// </summary>
        public int HalfMax
        {
            get { return halfmax; }
            set { halfmax = value; NotifyPropertyChanged(); }

        
        }

        private bool marker1Show = false;
        public bool Marker1Show
        {
            get { return marker1Show; }
            set { marker1Show = value; NotifyPropertyChanged(); }
        }

        private bool marker2Show = false;
        public bool Marker2Show
        {
            get { return marker2Show; }
            set { marker2Show = value; NotifyPropertyChanged(); }
        }
        }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkManager.ViewModels
{
    public class ProfileModel: ViewModelBase
    {
        private double ratio1 = 0.3;
        /// <summary>
        /// 最小值
        /// </summary>
        public double Ratio1
        {
            get { return ratio1; }
            set { ratio1 = value; NotifyPropertyChanged(nameof(Ratio1)); }
        }

        private double ratio2 = 0.7;
        /// <summary>
        /// 最小值
        /// </summary>
        public double Ratio2
        {
            get { return ratio2; }
            set { ratio2 = value; NotifyPropertyChanged(nameof(Ratio2)); }
        }


        private string max = "10";
        /// <summary>
        /// 最大值
        /// </summary>
        public string Max
        {
            get { return max; }
            set { max = value; NotifyPropertyChanged(nameof(Max)); }
        }

        private int halfmax = 5;
        /// <summary>
        /// 最大值
        /// </summary>
        public int HalfMax
        {
            get { return halfmax; }
            set { halfmax = value; NotifyPropertyChanged(nameof(HalfMax)); }


        }

        private bool marker1Show = false;
        public bool Marker1Show
        {
            get { return marker1Show; }
            set { marker1Show = value; NotifyPropertyChanged(nameof(Marker1Show)); }
        }

        private bool marker2Show = false;
        public bool Marker2Show
        {
            get { return marker2Show; }
            set { marker2Show = value; NotifyPropertyChanged(nameof(Marker2Show)); }
        }
    }

}


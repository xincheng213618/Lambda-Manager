using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode
{
    public class ImageParameter: ViewModelBase
    {
        private double scaleTransformCenterX = 0;
        public double ScaleTransformCenterX
        {
            get { return scaleTransformCenterX; }
            set { scaleTransformCenterX = value; NotifyPropertyChanged(); }
        }
        private double scaleTransformCenterY = 0;
        public double ScaleTransformCenterY
        {
            get { return scaleTransformCenterY; }
            set { scaleTransformCenterY = value; NotifyPropertyChanged(); }
        }
        private double scaleTransformScaleX = 1;
        public double ScaleTransformScaleX
        {
            get { return scaleTransformScaleX; }
            set { scaleTransformScaleX = value; NotifyPropertyChanged(); }
        }
        private double scaleTransformScaleY = 1;
        public double ScaleTransformScaleY
        {
            get { return scaleTransformScaleY; }
            set { scaleTransformScaleY = value; NotifyPropertyChanged(); }
        }



    }
}

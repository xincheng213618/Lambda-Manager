using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    public class ViewMode : ModeBaseObject
    {
        private int selectViewMode = 0;
        public int SelectViewMode
        {
            get { return selectViewMode; }
            set
            {
                selectViewMode = value;
                NotifyPropertyChanged();
            }
        }

        public BrightField BrightField { get; set; } = new();
        public DarkField DarkField { get; set; } = new();
        public Reinberg Reinberg { get; set; } = new();
        public ReliefContrast ReliefContrast { get; set; } = new();
        public PhaseContrast PhaseContrast { get; set; } = new();
        public QuantitativePhase QuantitativePhase { get; set; } = new();

        public void SetValue(ViewMode ViewMode)
        {
            this.SelectViewMode = ViewMode.SelectViewMode;
            this.BrightField.SetValue(ViewMode.BrightField);
            this.DarkField.SetValue(ViewMode.DarkField);
            this.ReliefContrast.SetValue(ViewMode.ReliefContrast);
            this.QuantitativePhase.SetValue(ViewMode.QuantitativePhase);
            this.Reinberg.SetValue(ViewMode.Reinberg);
            this.PhaseContrast.SetValue (ViewMode.PhaseContrast);
        }

    }

    public class BrightField : ModeBaseObject
    {
        private int aperture = 10;

        public int Aperture
        {
            get {return aperture; }
            set
            {
                aperture = value;
                NotifyPropertyChanged();
            }
        }

        private int color = 4095;
        public int Color
        {
            get { return color; }
            set
            {
                color = value;
                NotifyPropertyChanged();
            }
        }
        public void SetValue(BrightField brightField)
        {
            this.Aperture = brightField.aperture;
            this.color = brightField.color;
        }
    };

    public class DarkField : ModeBaseObject
    {
        private int innerAperture = 10;
        public int InnerAperture
        {
            get { return innerAperture; }
            set
            {
                innerAperture = value;
                NotifyPropertyChanged();
            }
        }


        private int outAperture = 32;

        public int OutAperture
        {
            get { return outAperture; }
            set
            {
                outAperture = value;
                NotifyPropertyChanged();
            }
        }

        private int color = 4095;
        public int Color
        {
            get { return color; }
            set
            {
                color = value;
                NotifyPropertyChanged();
            }
        }


        public double gamma = 1.67;

        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                NotifyPropertyChanged();
            }
        }

        public bool auto = false;

        public bool Auto
        {
            get { return auto; }
            set
            {
                auto = value;
                NotifyPropertyChanged();
            }
        }

        public bool bgCollection = false;

        public bool BgCollection
        {
            get { return bgCollection; }
            set
            {
                bgCollection = value;
                NotifyPropertyChanged();
            }
        }


        public void SetValue(DarkField  darkField)
        {
            this.InnerAperture = darkField.InnerAperture;
            this.OutAperture = darkField.OutAperture;
            this.Color = darkField.Color;   
            this.Gamma = darkField.Gamma;   
            this.Auto = darkField.Auto;
            this.BgCollection = darkField.BgCollection;
        }
    };

    public class Reinberg : ModeBaseObject
    {
        private int innerAperture = 10;
        public int InnerAperture
        {
            get { return innerAperture; }
            set
            {
                innerAperture = value;
                NotifyPropertyChanged();
            }
        }


        private int outAperture = 32;

        public int OutAperture
        {
            get { return outAperture; }
            set
            {
                outAperture = value;
                NotifyPropertyChanged();
            }
        }
        private int mode = 0;

        public int Mode
        {
            get { return mode; }
            set
            {
                mode = value;
                NotifyPropertyChanged();
            }
        }

        public int BrightColor = 4095;
        public int DarkColor = 4095;
        public int DarkColor1 = 4095;

        public void SetValue(Reinberg reinberg)
        {
            this.InnerAperture = reinberg.InnerAperture;
            this.OutAperture = reinberg.OutAperture;
            this.Mode = reinberg.Mode;
        }

    };

    public class ReliefContrast : ModeBaseObject
    {
        private int innerAperture = 10;
        public int InnerAperture
        {
            get { return innerAperture; }
            set
            {
                innerAperture = value;
                NotifyPropertyChanged();
            }
        }


        private int outAperture = 32;

        public int OutAperture
        {
            get { return outAperture; }
            set
            {
                outAperture = value;
                NotifyPropertyChanged();
            }
        }

        public double Gamma = 1.67;
        public double Gain = 2.0;

        public int Contrast = 5;
        public double BFWeight = 1;
        public double DPWeight = 1;

        public void SetValue(ReliefContrast  reliefContrast)
        {
            this.InnerAperture = reliefContrast.InnerAperture;
            this.OutAperture = reliefContrast.OutAperture;
        }
    }

    public class PhaseContrast : ModeBaseObject
    {

        private double filter = 0.07;
        public double Filter
        {
            get { return filter; }
            set
            {
                filter = value;
                NotifyPropertyChanged();
            }
        }


        private int contrast = -1;
        public int Contrast
        {
            get { return contrast; }
            set
            {
                contrast = value;
                NotifyPropertyChanged();
            }
        }



        private double gain = 2.0;

        public double Gain
        {
            get { return gain; }
            set
            {
                gain = value;
                NotifyPropertyChanged();
            }
        }



        private double gamma = 1.67;

        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                NotifyPropertyChanged();
            }
        }
        public double BFWeight = 1;

        public double PCWeight = 1;

        public void SetValue(PhaseContrast phaseContrast)
        {
            this.Filter = phaseContrast.Filter;
            this.Gamma = phaseContrast.Gamma;
        }
    }


    public class QuantitativePhase : ModeBaseObject
    {

        public double regularization = 0.0001;

        public double Regularization
        {
            get { return regularization; }
            set
            {
                regularization = value;
                NotifyPropertyChanged();
            }
        }

        private int detail = 18;
        public int Detail
        {
            get { return detail; }
            set
            {
                detail = value;
                NotifyPropertyChanged();
            }
        }

        private double min = -7.2;
        public double Min
        {
            get { return min; }
            set
            {
                min = value;
                NotifyPropertyChanged();
            }
        }


        public double max = 21.3;
        public double Max
        {
            get { return max; }
            set
            {
                max = value;
                NotifyPropertyChanged();
            }
        }

        private double gamma = 0.37;
        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                NotifyPropertyChanged();
            }
        }

        public void SetValue(QuantitativePhase  quantitativePhase)
        {
            this.Regularization = quantitativePhase.Regularization;
            this.Detail = quantitativePhase.Detail;
            this.Gamma = quantitativePhase.Gamma;
            this.Min = quantitativePhase.Min;
            this.max = quantitativePhase.Max;

        }
    }

}

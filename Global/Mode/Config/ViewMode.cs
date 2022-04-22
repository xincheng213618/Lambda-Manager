using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    public class ViewMode : ModeBaseObject
    {
        //private int selectViewMode = 0;
        //public int SelectViewMode
        //{
        //    get => selectViewMode; 
        //    set
        //    {
        //        selectViewMode = value;
        //        NotifyPropertyChanged();
        //    }
        //}
        public int SelectViewMode = 0;


        [JsonProperty("bright-field")]
        public BrightField BrightField { get; set; } = new();

        [JsonProperty("dark-field")]    
        public DarkField DarkField { get; set; } = new();

        [JsonProperty("rheinberg")]
        public Reinberg Reinberg { get; set; } = new();

        [JsonProperty("relief-contrast")]
        public ReliefContrast ReliefContrast { get; set; } = new();

        [JsonProperty("phase-contrast")]
        public PhaseContrast PhaseContrast { get; set; } = new();

        [JsonProperty("quantitative-phase")]
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
        public Camera CameraSetting { get; set; } = new Camera();
        private int aperture = 9;

        [JsonProperty("led-diameter")]
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
            CameraSetting.SetValue(brightField.CameraSetting);
            this.Aperture = brightField.aperture;
            this.color = brightField.color;
        }
    };

    public class DarkField : ModeBaseObject
    {
        public Camera CameraSetting { get; set; } = new Camera();

        private int innerAperture = 13;

        [JsonProperty("led-diameter-inner")]
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
        [JsonProperty("led-diameter-outer")]
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

        private bool auto = false;

        public bool Auto
        {
            get => auto;
            set
            {
                auto = value;
                NotifyPropertyChanged();
            }
        }

        private bool bgCollection = true;

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
            CameraSetting.SetValue(darkField.CameraSetting);

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

        public Camera CameraSetting { get; set; } = new Camera();

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
            CameraSetting.SetValue(reinberg.CameraSetting);

            this.InnerAperture = reinberg.InnerAperture;
            this.OutAperture = reinberg.OutAperture;
            this.Mode = reinberg.Mode;
        }

    };

    public class ReliefContrast : ModeBaseObject
    {
        public Camera CameraSetting { get; set; } = new Camera();

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


        private int outAperture = 31;

        public int OutAperture
        {
            get { return outAperture; }
            set
            {
                outAperture = value;
                NotifyPropertyChanged();
            }
        }

        private double gamma = 1;
        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
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


        private int contrast = 5;
        public int Contrast
        {
            get { return contrast; }
            set
            {
                contrast = value;
                NotifyPropertyChanged();
            }
        }

        private double bFWeight = 1;
        public double BFWeight
        {
            get { return bFWeight; }
            set
            {
                bFWeight = value;
                NotifyPropertyChanged();
            }
        }


        private double dPWeight = 1;
        public double DPWeight
        {
            get { return dPWeight; }
            set
            {
                dPWeight = value;
                NotifyPropertyChanged();
            }
        }
        private bool bgCollection = true;

        public bool BgCollection
        {
            get { return bgCollection; }
            set
            {
                bgCollection = value;
                NotifyPropertyChanged();
            }
        }



        public void SetValue(ReliefContrast  reliefContrast)
        {
            CameraSetting.SetValue(reliefContrast.CameraSetting);

            this.InnerAperture = reliefContrast.InnerAperture;
            this.OutAperture = reliefContrast.OutAperture;
            this.Gamma = reliefContrast.Gamma;
            this.Gain = reliefContrast.Gain;
            this.Contrast = reliefContrast.Contrast;
            this.BFWeight = reliefContrast.BFWeight;
            this.DPWeight = reliefContrast.DPWeight;
            this.BgCollection = reliefContrast.BgCollection;
        }
    }

    public class PhaseContrast : ModeBaseObject
    {
        public Camera CameraSetting { get; set; } = new Camera();

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



        private double gamma = 1    ;

        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                NotifyPropertyChanged();
            }
        }
        private double bFWeight = 1;
        public double BFWeight
        {
            get { return bFWeight; }
            set
            {
                bFWeight = value;
                NotifyPropertyChanged();
            }
        }

        private double pCWeight = 1;

        public double PCWeight
        {
            get { return pCWeight; }
            set
            {
                pCWeight = value;
                NotifyPropertyChanged();
            }
        }

        private bool bgCollection = true;

        public bool BgCollection
        {
            get { return bgCollection; }
            set
            {
                bgCollection = value;
                NotifyPropertyChanged();
            }
        }
        public void SetValue(PhaseContrast phaseContrast)
        {
            CameraSetting.SetValue(phaseContrast.CameraSetting);

            this.Filter = phaseContrast.Filter;
            this.Gamma = phaseContrast.Gamma;
            this.Contrast = phaseContrast.Contrast;
            this.Gain = phaseContrast.Gain;
            this.BFWeight = phaseContrast.BFWeight;
            this.PCWeight = phaseContrast.PCWeight;
            this.BgCollection = phaseContrast.BgCollection;
        }
    }


    public class QuantitativePhase : ModeBaseObject
    {
        public Camera CameraSetting { get; set; } = new Camera();

        private double regularization = 0.0001;

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


        private double max = 21.3;
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
        private bool bgCollection = true;

        public bool BgCollection
        {
            get { return bgCollection; }
            set
            {
                bgCollection = value;
                NotifyPropertyChanged();
            }
        }

        public void SetValue(QuantitativePhase  quantitativePhase)
        {
            CameraSetting.SetValue(quantitativePhase.CameraSetting);

            this.Regularization = quantitativePhase.Regularization;
            this.Detail = quantitativePhase.Detail;
            this.Gamma = quantitativePhase.Gamma;
            this.Min = quantitativePhase.Min;
            this.max = quantitativePhase.Max;
            this.BgCollection = quantitativePhase.BgCollection;

        }
    }

}

using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Global.Mode.Config
{
    public class OperatingMode : ViewModelBase
    {
        private int selectViewMode = 0;
        public int SelectViewMode
        {
            get { return selectViewMode; }
            set { selectViewMode = value;  NotifyPropertyChanged(); }
        }


        [JsonPropertyName("bright-field")]
        public BrightField BrightField { get; set; } = new();

        [JsonPropertyName("dark-field")]    
        public DarkField DarkField { get; set; } = new();

        [JsonPropertyName("rheinberg")]
        public Reinberg Reinberg { get; set; } = new();

        [JsonPropertyName("relief-contrast")]
        public ReliefContrast ReliefContrast { get; set; } = new();

        [JsonPropertyName("phase-contrast")]
        public PhaseContrast PhaseContrast { get; set; } = new();

        [JsonPropertyName("quantitative-phase")]
        public QuantitativePhase QuantitativePhase { get; set; } = new();




        public void SetValue(OperatingMode OperatingMode)
        {
           
                SelectViewMode = OperatingMode.SelectViewMode;
                BrightField.SetValue(OperatingMode.BrightField);
                DarkField.SetValue(OperatingMode.DarkField);
                ReliefContrast.SetValue(OperatingMode.ReliefContrast);
                QuantitativePhase.SetValue(OperatingMode.QuantitativePhase);
                Reinberg.SetValue(OperatingMode.Reinberg);
                PhaseContrast.SetValue(OperatingMode.PhaseContrast);
          

        }

    }

    //[Serializable]
    public class Outer : ViewModelBase
    {
        private int outer1 = 9;
        [JsonPropertyName("10x")]
        public int Outer1
        {
            get { return outer1; }
            set
            {
                outer1 = value;
                NotifyPropertyChanged();
            }
        }

        private int outer2 = 5;
        [JsonPropertyName("20x")]
        public int Outer2
        {
            get { return outer2; }
            set
            {
                outer2 = value;
                NotifyPropertyChanged();
            }
        }

        private int outer3 = 2;
        [JsonPropertyName("40x")]
        public int Outer3
        {
            get { return outer3; }
            set
            {
                outer3 = value;
                NotifyPropertyChanged();
            }
        }

      


    }

    public class Inner : ViewModelBase
    {
        private int inner1 = 9;
        [JsonPropertyName("10x")]
        public int Iinner1
        {
            get { return inner1; }
            set
            {
                inner1 = value;
                NotifyPropertyChanged();
            }
        }

        private int inner2 = 5;
        [JsonPropertyName("20x")]
        public int Iinner2
        {
            get { return inner2; }
            set
            {
                inner2 = value;
                NotifyPropertyChanged();
            }
        }

        private int inner3 = 2;
        [JsonPropertyName("40x")]
        public int Iinner3
        {
            get { return inner3; }
            set
            {
                inner3 = value;
                NotifyPropertyChanged();
            }
        }


    }



    public class BrightField : ViewModelBase
    {
        [JsonPropertyOrderAttribute(-2)]
        public Camera CameraSetting { get; set; } = new Camera() { SelectViewMode = 0 ,Gain = 0,Gamma = 1 };

        private int aperture = 9;
        [JsonPropertyName("led-diameter")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Aperture
        {
            get { return aperture; }
            set
            {
                aperture = value;
                NotifyPropertyChanged();
            }
        }
        [JsonPropertyName("led-diameter_")]
        public Outer MultiAperture { get; set; } = new Outer();

        private List<int> color = new List<int>() {255,255,255};

        public List<int> Color
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
            Aperture = brightField.aperture;
            MultiAperture = brightField.MultiAperture;
            color = brightField.color;
        }
    };

   








    public class DarkField : ViewModelBase
    {
        public Camera CameraSetting { get; set; } = new Camera() { SelectViewMode = 1 , Gamma =  1.67,Gain=17};

        private int innerAperture = 12;

        [JsonPropertyName("led-diameter-inner")]
        public int InnerAperture
        {
            get { return innerAperture; }
            set
            {
                innerAperture = value;
                NotifyPropertyChanged();
            }
        }
        private Inner multiAmperture = new Inner();
        [JsonPropertyName("led-diameter-outer_")]
        public Inner MultiAperture
        {
            get { return multiAmperture; }
            set
            {
                multiAmperture = value;
                NotifyPropertyChanged();
            }
        }

        private int outAperture = 32;
        [JsonPropertyName("led-diameter-outer")]
       // [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int OutAperture
        {
            get { return outAperture; }
            set
            {
                outAperture = value;
                NotifyPropertyChanged();
            }
        }

        private List<int> color = new List<int>() { 255, 255, 255 };
        public List<int> Color
        {
            get { return color; }
            set
            {
                color = value;
                NotifyPropertyChanged();
            }
        }


        private double gamma = 0.67;
        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                CameraSetting.Gamma = gamma+1;    
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

            InnerAperture = darkField.InnerAperture;
            OutAperture = darkField.OutAperture;
            Color = darkField.Color;   
            Gamma = darkField.Gamma;   
            Auto = darkField.Auto;
            BgCollection = darkField.BgCollection;
        }
    };

    public class RheinbergPattern: ViewModelBase
    {
        public void SetValue(RheinbergPattern rheinbergPattern)
        {
            Rheinberg0 = rheinbergPattern.Rheinberg0;
            Rheinberg1 = rheinbergPattern.Rheinberg1;
            Rheinberg2 = rheinbergPattern.Rheinberg2;

        }
        public SolidColorBrush Rheinberg0 { get; set; }
        public SolidColorBrush Rheinberg1 { get; set; }
        public SolidColorBrush Rheinberg2 { get; set; }
    }


    public class Reinberg : ViewModelBase
    {

        public Camera CameraSetting { get; set; } = new Camera() { SelectViewMode = 2 , Gamma = 1.67,Gain =15 };

        private int innerAperture = 0;
        [JsonPropertyName("led-diameter-inner")]
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
        [JsonPropertyName("led-diameter-outer")]
        public int OutAperture
        {
            get { return outAperture; }
            set
            {
                outAperture = value;
                NotifyPropertyChanged();
            }
        }


        private double gamma = 0.67;
        public double Gamma
        {
            get { return gamma; }
            set
            {
                gamma = value;
                CameraSetting.Gamma = gamma + 1;
                NotifyPropertyChanged();
            }
        }

        private Inner multiAmperture = new Inner();
        [JsonPropertyName("led-diameter-outer_")]
        public Inner MultiAperture
        {
            get { return multiAmperture; }
            set
            {
                multiAmperture = value;
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

        public int rheinbergSelectMode = 0;

        public int RheinbergSelectMode
        {
            get { return rheinbergSelectMode; }
            set { rheinbergSelectMode = value; NotifyPropertyChanged(); }
        }
        public List<RheinbergPattern> RheinbergPatterns { get; set; } = new List<RheinbergPattern>();


        public int BrightColor { get; set; } = 1;
        public int DarkColor { get; set; } = 4080;
        public int DarkColor1 { get; set; } = 4080;


        public void SetValue(Reinberg reinberg)
        {
            CameraSetting.SetValue(reinberg.CameraSetting);
            Gamma = reinberg.Gamma;
            InnerAperture = reinberg.InnerAperture;
            OutAperture = reinberg.OutAperture;
            Mode = reinberg.Mode;
            BrightColor = reinberg.BrightColor;
            DarkColor = reinberg.DarkColor;
            DarkColor1 = reinberg.DarkColor1;

            RheinbergSelectMode = reinberg.RheinbergSelectMode;
            if (reinberg.RheinbergPatterns!=null)
            {
                RheinbergPatterns.Clear();
                foreach (var item in reinberg.RheinbergPatterns)
                {
                    RheinbergPattern rheinbergPattern = new RheinbergPattern();
                    rheinbergPattern.SetValue(item);
                    RheinbergPatterns.Add(rheinbergPattern);
                }
            }


        }

    };

    //差分
    public class ReliefContrast : ViewModelBase
    {
        public Camera CameraSetting { get; set; } = new Camera() { SelectViewMode = 3 , Gamma = 1 } ;

        public int rotationangle = 0;
        public int Rotationangle
        {
            get { return rotationangle; }
            set
            {
                rotationangle = value;
                NotifyPropertyChanged();
            }
        }


        private int innerAperture = 0;
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


        private double gain = 0;
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
            Rotationangle = reliefContrast.Rotationangle;
            InnerAperture = reliefContrast.InnerAperture;
            OutAperture = reliefContrast.OutAperture;
            Gamma = reliefContrast.Gamma;
            Gain = reliefContrast.Gain;
            Contrast = reliefContrast.Contrast;
            BFWeight = reliefContrast.BFWeight;
            DPWeight = reliefContrast.DPWeight;
            BgCollection = reliefContrast.BgCollection;
        }
    }
    //相位
    public class PhaseContrast : ViewModelBase
    {
        public Camera CameraSetting { get; set; } = new Camera() { SelectViewMode = 5, Gamma = 1};

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



        private double gain = 0;

        public double Gain
        {
            get { return gain; }
            set
            {
                gain = value;
                NotifyPropertyChanged();
            }
        }



        private double gamma = 0    ;

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

            Filter = phaseContrast.Filter;
            Gamma = phaseContrast.Gamma;
            Contrast = phaseContrast.Contrast;
            Gain = phaseContrast.Gain;
            BFWeight = phaseContrast.BFWeight;
            PCWeight = phaseContrast.PCWeight;
            BgCollection = phaseContrast.BgCollection;
        }
    }


    public class QuantitativePhase : ViewModelBase
    {
        public Camera CameraSetting { get; set; } = new Camera() { SelectViewMode = 4 ,Gamma =1};

        private double regularization = 0.1;

        public double Regularization
        {
            get { return regularization; }
            set
            {
                regularization = value;
                NotifyPropertyChanged();
            }
        }

        private double detail = 2.5;
        public double Detail
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

        private double gamma = 0;
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

            Regularization = quantitativePhase.Regularization;
            Detail = quantitativePhase.Detail;
            Gamma = quantitativePhase.Gamma;
            Min = quantitativePhase.Min;
            max = quantitativePhase.Max;
            BgCollection = quantitativePhase.BgCollection;

        }
    }

}

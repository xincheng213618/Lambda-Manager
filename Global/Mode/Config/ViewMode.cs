using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    public class ViewMode
    {
        public BrightField BrightField { get; set; } = new();

        public DarkField DarkField { get; set; } = new();

        public Reinberg Reinberg { get; set; } = new();

        public ReliefContrast ReliefContrast { get; set; } = new();

        public PhaseContrast PhaseContrast { get; set; } = new();

        public QuantitativePhase QuantitativePhase { get; set; } = new();   


    }

    public class BrightField
    {

        public int Aperture = 10;

        public int Color = 4095;
    };

    public class DarkField
    {
        public int InnerAperture = 10;
        public int OutAperture = 32;
        public int Color = 4095;
        public double Gamma = 1.67;
    };

    public class Reinberg
    {
        public int InnerAperture = 10;
        public int OutAperture = 32;
        public int Mode = 0;
        public int BrightColor = 4095;
        public int DarkColor = 4095;
        public int DarkColor1 = 4095;
    };

    public class ReliefContrast
    {
        public int InnerAperture = 10;
        public int OutAperture = 32;
        public double Gamma = 1.67;
        public double Gain = 2.0;

        public int Contrast = 5;
        public double BFWeight = 1;
        public double DPWeight = 1;
    }

    public class PhaseContrast
    {

        public double Filter = 0.07;

        public int Contrast = -1;

        public double Gain = 2.0;

        public double Gamma = 1.67;

        public double BFWeight = 1;

        public double PCWeight = 1;
    }


    public class QuantitativePhase
    {

        public double Regularization = 0.0001;

        public int Detail = 18;

        public double Min = -7.2;

        public double Max = 21.3;

        public double Gamma = 0.37;
    }

}

using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class Stage : ViewModelBase
    {
        [JsonPropertyName("moving-step")]
        public MoveStep MoveStep { get; set; }= new MoveStep();

        private bool coarsefocus = true;
        [JsonPropertyName("coarse-focus")]
        public bool CoarseFocus
        {
            get { return coarsefocus; }
            set 
            { 
                coarsefocus = value;
                NotifyPropertyChanged(); 
            }
        }

        private bool finefocus =false;
        [JsonPropertyName("fine-focus")]
        public bool FineFocus
        {
            get { return finefocus; }
            set 
            { 
                finefocus = value; 
                NotifyPropertyChanged(); 
            }
        }
        
        private int focusingscope;
        [JsonPropertyName("focusing-scope")]
        public int FocusingScope
        {
            get { return focusingscope; }
            set 
            { 
                focusingscope = value;
                NotifyPropertyChanged(); 
            }
        }

        public void SetValue(Stage stage)
        {
            this.MoveStep.SetValue(stage.MoveStep);
            this.CoarseFocus=stage.CoarseFocus;
            this.FineFocus=stage.FineFocus; 
            this.FocusingScope =stage.FocusingScope;
        }

    }
    public class MultiStep : ViewModelBase
    {

        private int step1 = 200;
        [JsonPropertyName("10x")]
        public int Step1
        {
            get { return step1; }
            set
            {
                step1 = value;
                NotifyPropertyChanged();
            }
        }

        private int step2 =100;
        [JsonPropertyName("20x")]
        public int Step2
        {
            get { return step2; }
            set
            {
                step2 = value;
                NotifyPropertyChanged();
            }
        }

        private int step3 =50;
        [JsonPropertyName("40x")]
        public int Step3
        {
            get { return step3; }
            set
            {
                step3 = value;
                NotifyPropertyChanged();
            }
        }

      

    }





    [Serializable]
    public class MoveStep : ViewModelBase
    {
        private int xstep = 200 ;
        [JsonPropertyName("x-step")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int XStep
        {
            get { return xstep; }
            set
            {
                xstep = value;
                NotifyPropertyChanged();
            }
        }
        MultiStep xStep_ = new MultiStep();
        [JsonPropertyName("x-step_")]
        public MultiStep XStep_ 
        { 

            get { return xStep_; }
            set
            {
                xStep_ = value;
                NotifyPropertyChanged();
            }

        }



        private int ystep = 200;
        [JsonPropertyName("y-step")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int YStep
        {
            get { return ystep; }
            set
            {
                ystep = value;
                NotifyPropertyChanged();
            }
        }
        MultiStep yStep_ = new MultiStep();
        [JsonPropertyName("y-step_")]
        public MultiStep YStep_
        {

            get { return yStep_; }
            set
            {
                yStep_ = value;
                NotifyPropertyChanged();
            }

        }





        private int zStep = 200;
        [JsonPropertyName("z-step")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int ZStep
        {
            get { return zStep; }
            set
            {
                zStep = value;
                NotifyPropertyChanged();
            }
        }
        MultiStep zStep_ = new MultiStep();
        [JsonPropertyName("z-step_")]

        public MultiStep ZStep_
        {

            get { return zStep_; }
            set
            {
                zStep_ = value;
                NotifyPropertyChanged();
            }

        }
        public void SetValue(MoveStep  moveStep)
        {
            this.XStep = moveStep.XStep;
            this.YStep = moveStep.YStep;
            this.ZStep = moveStep.ZStep;
            this.XStep_ = moveStep.XStep_;
            this.YStep_ = moveStep.YStep_;
            this.ZStep_ = moveStep.ZStep_;

        }


    }


}

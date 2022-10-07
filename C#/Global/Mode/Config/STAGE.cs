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

    [Serializable]
    public class MoveStep : ViewModelBase
    {
        private int xstep = 200 ;
        [JsonPropertyName("x-step")]
        public int XStep
        {
            get { return xstep; }
            set
            {
                xstep = value;
                NotifyPropertyChanged();
            }
        }

        private int ystep = 200;
        [JsonPropertyName("y-step")]
        public int YStep
        {
            get { return ystep; }
            set
            {
                ystep = value;
                NotifyPropertyChanged();
            }
        }

        private int zStep = 200;
        [JsonPropertyName("z-step")]
        public int ZStep
        {
            get { return zStep; }
            set
            {
                zStep = value;
                NotifyPropertyChanged();
            }
        }

        public void SetValue(MoveStep  moveStep)
        {
            this.XStep = moveStep.XStep;
            this.YStep = moveStep.YStep;
            this.ZStep = moveStep.ZStep;
        }


    }


}

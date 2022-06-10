using Global.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class Stage : ViewModeBase
    {
        [JsonProperty("moving-step")]
        public MoveStep MoveStep { get; set; }= new MoveStep();

        private bool coarsefocus = true;
        [JsonProperty("coarse-focus")]
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
        [JsonProperty("fine-focus")]
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
        [JsonProperty("focusing-scope")]
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
    public class MoveStep : ViewModeBase
    {
        private int xstep = 200 ;
        [JsonProperty("x-step")]
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
        [JsonProperty("y-step")]
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
        [JsonProperty("z-step")]
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

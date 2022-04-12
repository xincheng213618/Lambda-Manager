using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Mode.Config
{
    [Serializable]
    public class STAGE : ModeBaseObject
    {
        [JsonProperty("moving-step")]
        public MoveStep MoveStep { get; set; }

        private bool coarsefocus = true;
        [JsonProperty("coarse-focus")]
        public bool CoarseFocus
        {
            get { return coarsefocus; }
            set { coarsefocus = value; NotifyPropertyChanged(); }
        }

        private bool finefocus =false;
        [JsonProperty("fine-focus")]
        public bool FineFocus
        {
            get { return finefocus; }
            set { finefocus = value; NotifyPropertyChanged(); }
        }
        
        private int focusingscope;
        [JsonProperty("focusing-scope")]
        public int FocusingScope
        {
            get { return focusingscope; }
            set { focusingscope = value; NotifyPropertyChanged(); }
        }



    }

    [Serializable]
    public class MoveStep : ModeBaseObject
    {
        private int xstep;
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

        private int ystep;
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

        private int zStep;
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
    }


}

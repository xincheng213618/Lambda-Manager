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
        private int xyStep;
        [JsonProperty("XYStep")]
        public int XYStep
        {
            get { return xyStep; }
            set {
                xyStep = value;
                NotifyPropertyChanged();
            }
        }

        private int zStep;
        [JsonProperty("ZStep")]
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

using Global.Common;
using Global.Mode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Global.SettingUp.PC
{
    public class GPUInfo:ViewModelBase
    {
        public GPUInfo() { }

        private bool isGPUCapable = false;

        public bool IsGPUCapable
        {
            get { return isGPUCapable; }
            set { isGPUCapable = value; NotifyPropertyChanged(); }
        }


        public string GPUName { get; set; }
        public string GPUVersion { get; set; }
        public string GPUDescription { get; set; }

        private uint gPUaccessibleRAM = 0;
        public uint GPUaccessibleRAM     
        {
            get { return gPUaccessibleRAM; }
            set { gPUaccessibleRAM = value; NotifyPropertyChanged(); }
        }


    }
}

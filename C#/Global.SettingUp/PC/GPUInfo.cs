using Global.Common;
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
            set { isGPUCapable = value; NotifyPropertyChanged(); if (isGPUCapable) isOpenGPUAccelerate = IsGPUCapable; }
        }

        private bool isOpenGPUAccelerate = false;
        public bool IsOpenGPUAccelerate
        {
            get { return isOpenGPUAccelerate; }
            set {
                 if (IsGPUCapable)
                {
                    isOpenGPUAccelerate = value; NotifyPropertyChanged();
                }
            }
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

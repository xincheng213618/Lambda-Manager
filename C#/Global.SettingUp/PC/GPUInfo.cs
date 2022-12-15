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
        /// <summary>
        /// 是否支持GPU
        /// </summary>
        public bool IsGPUCapable { get => _IsGPUCapable; set { _IsGPUCapable = value; NotifyPropertyChanged(); if (_IsGPUCapable) _IsOpenGPUAccelerate = IsGPUCapable; } }
        private bool _IsGPUCapable = false;

        /// <summary>
        /// 是否开启CUDA加速
        /// </summary>
        public bool IsOpenGPUAccelerate { get => _IsOpenGPUAccelerate; set { _IsOpenGPUAccelerate = value; NotifyPropertyChanged(); } }
        private bool _IsOpenGPUAccelerate = false;

        /// <summary>
        /// 是否支持CUDA
        /// </summary>
        public bool IsCUDACapable { get => _IsCUDACapable; set { _IsCUDACapable = value; NotifyPropertyChanged(); } }
        private bool _IsCUDACapable = false;


        public string GPUName { get; set; }
        public string GPUVersion { get; set; }
        public string GPUDescription { get; set; }

        /// <summary>
        /// GPURAM容量
        /// </summary>
        public uint GPUaccessibleRAM { get => _GPUaccessibleRAM; set { _GPUaccessibleRAM = value; NotifyPropertyChanged(); } } 
        private uint _GPUaccessibleRAM = 0;
    }
}

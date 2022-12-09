
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ThemeManager.NativeMethods
{
    public static class MsCms
    {
        [DllImport("mscms.dll", CharSet = CharSet.Auto)]
        public static extern bool GetColorDirectory(
            [MarshalAs(UnmanagedType.LPWStr)] string pMachineName,
            StringBuilder pBuffer,
            ref uint pdwSize);

        [DllImport("mscms.dll", CharSet = CharSet.Auto)]
        public static extern bool WcsGetUsePerUserProfiles(
            [MarshalAs(UnmanagedType.LPTStr)] string deviceName,
            uint deviceClass,
            out bool usePerUserProfiles);

        [DllImport("mscms.dll", CharSet = CharSet.Auto)]
        public static extern bool WcsGetDefaultColorProfileSize(
            WcsProfileManagementScope scope,
            [MarshalAs(UnmanagedType.LPTStr)] string deviceName,
            ColorProfileType colorProfileType,
            ColorProfileSubtype colorProfileSubType,
            uint dwProfileID,
            out uint cbProfileName);

        [DllImport("mscms.dll", CharSet = CharSet.Auto)]
        public static extern bool WcsGetDefaultColorProfile(
            WcsProfileManagementScope scope,
            [MarshalAs(UnmanagedType.LPTStr)] string deviceName,
            ColorProfileType colorProfileType,
            ColorProfileSubtype colorProfileSubType,
            uint dwProfileID,
            uint cbProfileName,
            StringBuilder pProfileName);

        public enum WcsProfileManagementScope
        {
            SYSTEM_WIDE,
            CURRENT_USER
        }
        public enum ColorProfileType
        {
            ICC,
            DMP,
            CAMP,
            GMMP
        };

        public enum ColorProfileSubtype
        {
            PERCEPTUAL,
            RELATIVE_COLORIMETRIC,
            SATURATION,
            ABSOLUTE_COLORIMETRIC,
            NONE,
            RGB_WORKING_SPACE,
            CUSTOM_WORKING_SPACE,
            STANDARD_DISPLAY_COLOR_MODE,
            EXTENDED_DISPLAY_COLOR_MODE
        };

        public const uint CLASS_MONITOR = 0x6d6e7472; //'mntr'
        public const uint CLASS_PRINTER = 0x70727472; //'prtr'
        public const uint CLASS_SCANNER = 0x73636e72; //'scnr'
    }
}

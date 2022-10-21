using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Solution.TreeViewControl;

namespace XSolution
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GrifFile
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]   //ByValTStr           ByValArray     CertVol
        public string Name;      //姓名   
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string OperatingMode;       //性别
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
        public string Lighting;    //民族
        [MarshalAs(UnmanagedType.I4)]
        public int x; //x
        [MarshalAs(UnmanagedType.I4)]
        public int y; //y
        [MarshalAs(UnmanagedType.I4)]
        public int z; //z
        [MarshalAs(UnmanagedType.I4)]
        public int rows; //宽度
        [MarshalAs(UnmanagedType.I4)]
        public int cols; //高度
        [MarshalAs(UnmanagedType.I4)]
        public int depth; //位深度
        [MarshalAs(UnmanagedType.I4)]
        public int jsonoffset;
    }

    public static class CustomFileManger
    {
        [DllImport("lib\\CustomFile.dll")]
        public static extern GrifFile ReadFileInfo(string filepath);
    }
}

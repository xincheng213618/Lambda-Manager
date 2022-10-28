using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Solution.TreeViewControl;

namespace XSolution
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public struct GrifFileMeta
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

        public static IntPtr intPtr = IntPtr.Zero;

        public unsafe static GrifFileMeta ReadFileInfo(string filepath)
        {
            if (intPtr == IntPtr.Zero)
            {
                try
                {
                    IntPtr dll = NativeLibrary.Load("lib\\CustomFile.dll");
                    if (dll == IntPtr.Zero)
                    {
                        MessageBox.Show("lib\\CustomFile.dll Not Exit");
                    }
                    intPtr = NativeLibrary.GetExport(dll, "ReadFileInfo");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return ((delegate* unmanaged[Cdecl]<string, GrifFileMeta>)(void*)intPtr)(filepath);
        }
    }
}

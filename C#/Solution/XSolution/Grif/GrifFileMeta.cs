using System.Runtime.InteropServices;

namespace XSolution
{
    //在C++中定义的结构体，在C#中需要顶一个一个一样的，这样方便指针直接传参
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
}

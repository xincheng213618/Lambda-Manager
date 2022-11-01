using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace XSolution
{

    //花活，NativeLibrary + Trace + 结构体 +Goto
    public static class GrifFileManger
    {

        public static IntPtr intPtr = IntPtr.Zero;

        //如果找不到CustomFile，则提示报错，然后该接口之反馈空的信息状态
        private static bool IsLoad = false;
        public unsafe static GrifFileMeta ReadFileInfo(string filepath)
        {
            if (intPtr == IntPtr.Zero && !IsLoad)
            {
                IsLoad = true;
                try
                {
                    IntPtr dll = NativeLibrary.Load("lib\\CustomFile.dll");
                    if (dll == IntPtr.Zero)
                    {
                        goto ERROR1;
                    }
                    intPtr = NativeLibrary.GetExport(dll, "ReadFileInfo");
                }
                catch (Exception e)
                {
                    Trace.WriteLine("### [" + e.Source + "] Exception: " + e.Message);
                    Trace.WriteLine("### " + e.StackTrace);
                    goto ERROR1;
                }
            }
            if (intPtr != IntPtr.Zero && IsLoad)
            {
                return ((delegate* unmanaged[Cdecl]<string, GrifFileMeta>)(void*)intPtr)(filepath);
            }

            ERROR1:
            return new GrifFileMeta();
        }
    }
}

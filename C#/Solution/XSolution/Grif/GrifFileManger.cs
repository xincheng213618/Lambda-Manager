using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace XSolution
{

    //花活，NativeLibrary + Trace + 结构体 + Goto
    public static class GrifFileManger
    {
        public static string libraryPath = "lib\\CustomFile.dll";

        public static Dictionary<string, IntPtr> libraryExport = new Dictionary<string, IntPtr>()
        {
            {"ReadFileInfo",IntPtr.Zero},
            {"NativeIsGrifFile",IntPtr.Zero}
        };



        //如果找不到CustomFile，则提示报错，然后该接口之反馈空的信息状态
        private static bool IsLoad = false;
        public unsafe static GrifFileMeta ReadGrifFileInfo(string filepath)
        {
            if (libraryExport["ReadFileInfo"] == IntPtr.Zero && !IsLoad)
            {
                IsLoad = true;
                try
                {
                    IntPtr dll = NativeLibrary.Load(libraryPath);
                    if (dll == IntPtr.Zero)
                    {
                        goto ERROR1;
                    }
                    libraryExport["ReadFileInfo"] = NativeLibrary.GetExport(dll, "ReadFileInfo");
                }
                catch (Exception e)
                {
                    Trace.WriteLine("### [" + e.Source + "] Exception: " + e.Message);
                    Trace.WriteLine("### " + e.StackTrace);
                    goto ERROR1;
                }
            }
            if (libraryExport["ReadFileInfo"] != IntPtr.Zero && IsLoad)
            {
                return ((delegate* unmanaged[Cdecl]<string, GrifFileMeta>)(void*)libraryExport["ReadFileInfo"])(filepath);
            }
            ERROR1:
            return new GrifFileMeta();
        }


        private static bool IsLoad1 = false;

        public unsafe static int IsGrifFile(string filepath)
        {
            if (libraryExport["NativeIsGrifFile"] == IntPtr.Zero && !IsLoad1)
            {
                IsLoad1 = true;
                try
                {
                    IntPtr dll = NativeLibrary.Load(libraryPath);
                    if (dll == IntPtr.Zero)
                    {
                        goto ERROR1;
                    }
                    libraryExport["NativeIsGrifFile"] = NativeLibrary.GetExport(dll, "NativeIsGrifFile");
                }
                catch (Exception e)
                {
                    Trace.WriteLine("### [" + e.Source + "] Exception: " + e.Message);
                    Trace.WriteLine("### " + e.StackTrace);
                    goto ERROR1;
                }
            }
            if (libraryExport["NativeIsGrifFile"] != IntPtr.Zero && IsLoad)
            {
                return ((delegate* unmanaged[Cdecl]<string, int>)(void*)libraryExport["NativeIsGrifFile"])(filepath);
            }
            ERROR1:
            return -3;
        }


    }
}

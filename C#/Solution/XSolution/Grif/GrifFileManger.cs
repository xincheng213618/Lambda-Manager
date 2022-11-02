using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace XSolution
{

    public class GrifFileManger
    {
        private static GrifFileManger _instance;
        private static readonly object _locker = new();
        public static GrifFileManger GetInstance()
        {
            lock (_locker) { _instance ??= new GrifFileManger(); }
            return _instance;
        }

        private string libraryPath;
        private List<string> libraryExport;
        private Dictionary<string, IntPtr> libraryExportDic;
        private GrifFileManger()
        {
            libraryPath = "lib\\CustomFile.dll";
            libraryExport = new List<string>() { "ReadFileInfo", "NativeIsGrifFile" };
            libraryExportDic = new Dictionary<string, IntPtr>();
            IntPtr dll = NativeLibrary.Load(libraryPath);

            foreach (var item in libraryExport)
            {
                try
                {
                    if (dll != IntPtr.Zero)
                    {
                        libraryExportDic.Add(item, NativeLibrary.GetExport(dll, "item"));
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Trace.WriteLine("### [" + e.Source + "] Exception: " + e.Message);
                    Trace.WriteLine("### " + e.StackTrace);
                }
                libraryExportDic.Add(item, IntPtr.Zero);
            }
        }

        //如果找不到CustomFile，则提示报错，然后该接口之反馈空的信息状态
        public unsafe GrifFileMeta ReadGrifFileInfo(string filepath)
        {
            IntPtr intPtr = libraryExportDic["ReadFileInfo"];
            if (intPtr != IntPtr.Zero )
            {
                return ((delegate* unmanaged[Cdecl]<string, GrifFileMeta>)(void*)intPtr)(filepath);
            }
            return new GrifFileMeta();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns>0,-1,-2,-3</returns>
        public unsafe int IsGrifFile(string filepath)
        {
            IntPtr intPtr = libraryExportDic["NativeIsGrifFile"];
            if (intPtr != IntPtr.Zero)
            {
                return ((delegate* unmanaged[Cdecl]<string, int>)(void*)intPtr)(filepath);
            }
            return -3;
        }


    }
}

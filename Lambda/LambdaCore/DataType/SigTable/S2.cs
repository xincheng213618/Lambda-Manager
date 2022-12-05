//这个是生成代码
using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable
{
    public class S2
    {
        public unsafe static int Invoke(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
             return code switch
             {        
               "00"=> ((delegate* unmanaged[Cdecl]<byte, byte, int>)(void*)p)((byte)args![0],(byte)args![1]),
               "01"=> ((delegate* unmanaged[Cdecl]<byte, short, int>)(void*)p)((byte)args![0],(short)args![1]),
               "02"=> ((delegate* unmanaged[Cdecl]<byte, int, int>)(void*)p)((byte)args![0],(int)args![1]),
               "03"=> ((delegate* unmanaged[Cdecl]<byte, long, int>)(void*)p)((byte)args![0],(long)args![1]),
               "04"=> ((delegate* unmanaged[Cdecl]<byte, decimal, int>)(void*)p)((byte)args![0],(decimal)args![1]),
               "05"=> ((delegate* unmanaged[Cdecl]<byte, double, int>)(void*)p)((byte)args![0],(double)args![1]),
               "06"=> ((delegate* unmanaged[Cdecl]<byte, float, int>)(void*)p)((byte)args![0],(float)args![1]),
               "07"=> ((delegate* unmanaged[Cdecl]<byte, IntPtr, int>)(void*)p)((byte)args![0],(IntPtr)args![1]),
               "10"=> ((delegate* unmanaged[Cdecl]<short, byte, int>)(void*)p)((short)args![0],(byte)args![1]),
               "11"=> ((delegate* unmanaged[Cdecl]<short, short, int>)(void*)p)((short)args![0],(short)args![1]),
               "12"=> ((delegate* unmanaged[Cdecl]<short, int, int>)(void*)p)((short)args![0],(int)args![1]),
               "13"=> ((delegate* unmanaged[Cdecl]<short, long, int>)(void*)p)((short)args![0],(long)args![1]),
               "14"=> ((delegate* unmanaged[Cdecl]<short, decimal, int>)(void*)p)((short)args![0],(decimal)args![1]),
               "15"=> ((delegate* unmanaged[Cdecl]<short, double, int>)(void*)p)((short)args![0],(double)args![1]),
               "16"=> ((delegate* unmanaged[Cdecl]<short, float, int>)(void*)p)((short)args![0],(float)args![1]),
               "17"=> ((delegate* unmanaged[Cdecl]<short, IntPtr, int>)(void*)p)((short)args![0],(IntPtr)args![1]),
               "20"=> ((delegate* unmanaged[Cdecl]<int, byte, int>)(void*)p)((int)args![0],(byte)args![1]),
               "21"=> ((delegate* unmanaged[Cdecl]<int, short, int>)(void*)p)((int)args![0],(short)args![1]),
               "22"=> ((delegate* unmanaged[Cdecl]<int, int, int>)(void*)p)((int)args![0],(int)args![1]),
               "23"=> ((delegate* unmanaged[Cdecl]<int, long, int>)(void*)p)((int)args![0],(long)args![1]),
               "24"=> ((delegate* unmanaged[Cdecl]<int, decimal, int>)(void*)p)((int)args![0],(decimal)args![1]),
               "25"=> ((delegate* unmanaged[Cdecl]<int, double, int>)(void*)p)((int)args![0],(double)args![1]),
               "26"=> ((delegate* unmanaged[Cdecl]<int, float, int>)(void*)p)((int)args![0],(float)args![1]),
               "27"=> ((delegate* unmanaged[Cdecl]<int, IntPtr, int>)(void*)p)((int)args![0],(IntPtr)args![1]),
               "30"=> ((delegate* unmanaged[Cdecl]<long, byte, int>)(void*)p)((long)args![0],(byte)args![1]),
               "31"=> ((delegate* unmanaged[Cdecl]<long, short, int>)(void*)p)((long)args![0],(short)args![1]),
               "32"=> ((delegate* unmanaged[Cdecl]<long, int, int>)(void*)p)((long)args![0],(int)args![1]),
               "33"=> ((delegate* unmanaged[Cdecl]<long, long, int>)(void*)p)((long)args![0],(long)args![1]),
               "34"=> ((delegate* unmanaged[Cdecl]<long, decimal, int>)(void*)p)((long)args![0],(decimal)args![1]),
               "35"=> ((delegate* unmanaged[Cdecl]<long, double, int>)(void*)p)((long)args![0],(double)args![1]),
               "36"=> ((delegate* unmanaged[Cdecl]<long, float, int>)(void*)p)((long)args![0],(float)args![1]),
               "37"=> ((delegate* unmanaged[Cdecl]<long, IntPtr, int>)(void*)p)((long)args![0],(IntPtr)args![1]),
               "40"=> ((delegate* unmanaged[Cdecl]<decimal, byte, int>)(void*)p)((decimal)args![0],(byte)args![1]),
               "41"=> ((delegate* unmanaged[Cdecl]<decimal, short, int>)(void*)p)((decimal)args![0],(short)args![1]),
               "42"=> ((delegate* unmanaged[Cdecl]<decimal, int, int>)(void*)p)((decimal)args![0],(int)args![1]),
               "43"=> ((delegate* unmanaged[Cdecl]<decimal, long, int>)(void*)p)((decimal)args![0],(long)args![1]),
               "44"=> ((delegate* unmanaged[Cdecl]<decimal, decimal, int>)(void*)p)((decimal)args![0],(decimal)args![1]),
               "45"=> ((delegate* unmanaged[Cdecl]<decimal, double, int>)(void*)p)((decimal)args![0],(double)args![1]),
               "46"=> ((delegate* unmanaged[Cdecl]<decimal, float, int>)(void*)p)((decimal)args![0],(float)args![1]),
               "47"=> ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int>)(void*)p)((decimal)args![0],(IntPtr)args![1]),
               "50"=> ((delegate* unmanaged[Cdecl]<double, byte, int>)(void*)p)((double)args![0],(byte)args![1]),
               "51"=> ((delegate* unmanaged[Cdecl]<double, short, int>)(void*)p)((double)args![0],(short)args![1]),
               "52"=> ((delegate* unmanaged[Cdecl]<double, int, int>)(void*)p)((double)args![0],(int)args![1]),
               "53"=> ((delegate* unmanaged[Cdecl]<double, long, int>)(void*)p)((double)args![0],(long)args![1]),
               "54"=> ((delegate* unmanaged[Cdecl]<double, decimal, int>)(void*)p)((double)args![0],(decimal)args![1]),
               "55"=> ((delegate* unmanaged[Cdecl]<double, double, int>)(void*)p)((double)args![0],(double)args![1]),
               "56"=> ((delegate* unmanaged[Cdecl]<double, float, int>)(void*)p)((double)args![0],(float)args![1]),
               "57"=> ((delegate* unmanaged[Cdecl]<double, IntPtr, int>)(void*)p)((double)args![0],(IntPtr)args![1]),
               "60"=> ((delegate* unmanaged[Cdecl]<float, byte, int>)(void*)p)((float)args![0],(byte)args![1]),
               "61"=> ((delegate* unmanaged[Cdecl]<float, short, int>)(void*)p)((float)args![0],(short)args![1]),
               "62"=> ((delegate* unmanaged[Cdecl]<float, int, int>)(void*)p)((float)args![0],(int)args![1]),
               "63"=> ((delegate* unmanaged[Cdecl]<float, long, int>)(void*)p)((float)args![0],(long)args![1]),
               "64"=> ((delegate* unmanaged[Cdecl]<float, decimal, int>)(void*)p)((float)args![0],(decimal)args![1]),
               "65"=> ((delegate* unmanaged[Cdecl]<float, double, int>)(void*)p)((float)args![0],(double)args![1]),
               "66"=> ((delegate* unmanaged[Cdecl]<float, float, int>)(void*)p)((float)args![0],(float)args![1]),
               "67"=> ((delegate* unmanaged[Cdecl]<float, IntPtr, int>)(void*)p)((float)args![0],(IntPtr)args![1]),
               "70"=> ((delegate* unmanaged[Cdecl]<IntPtr, byte, int>)(void*)p)((IntPtr)args![0],(byte)args![1]),
               "71"=> ((delegate* unmanaged[Cdecl]<IntPtr, short, int>)(void*)p)((IntPtr)args![0],(short)args![1]),
               "72"=> ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)(void*)p)((IntPtr)args![0],(int)args![1]),
               "73"=> ((delegate* unmanaged[Cdecl]<IntPtr, long, int>)(void*)p)((IntPtr)args![0],(long)args![1]),
               "74"=> ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int>)(void*)p)((IntPtr)args![0],(decimal)args![1]),
               "75"=> ((delegate* unmanaged[Cdecl]<IntPtr, double, int>)(void*)p)((IntPtr)args![0],(double)args![1]),
               "76"=> ((delegate* unmanaged[Cdecl]<IntPtr, float, int>)(void*)p)((IntPtr)args![0],(float)args![1]),
               "77"=> ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0],(IntPtr)args![1]),
 
                _ => -1,
            };
        }
    }
}
using System;
using System.Collections.Generic;

namespace LambdaManager.DataType.SigTable
{
    public class S3
    {
        public static int Invoke(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[0] switch
            {
                '0' => Invoke0XX(code, p, args),
                '1' => Invoke1XX(code, p, args),
                '2' => Invoke2XX(code, p, args),
                '6' => Invoke6XX(code, p, args),
                '3' => Invoke3XX(code, p, args),
                '5' => Invoke5XX(code, p, args),
                '4' => Invoke4XX(code, p, args),
                '7' => Invoke7XX(code, p, args),
                _ => -1,
            };
        }

        private static int Invoke0XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke00X(code, p, args),
                '1' => Invoke01X(code, p, args),
                '2' => Invoke02X(code, p, args),
                '6' => Invoke06X(code, p, args),
                '3' => Invoke03X(code, p, args),
                '4' => Invoke04X(code, p, args),
                '5' => Invoke05X(code, p, args),
                '7' => Invoke07X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke00X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, byte, byte, int>)(void*)p)((byte)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, byte, short, int>)(void*)p)((byte)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, byte, int, int>)(void*)p)((byte)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, byte, float, int>)(void*)p)((byte)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, byte, long, int>)(void*)p)((byte)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, byte, double, int>)(void*)p)((byte)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, byte, decimal, int>)(void*)p)((byte)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, byte, IntPtr, int>)(void*)p)((byte)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke01X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, short, byte, int>)(void*)p)((byte)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, short, short, int>)(void*)p)((byte)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, short, int, int>)(void*)p)((byte)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, short, float, int>)(void*)p)((byte)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, short, long, int>)(void*)p)((byte)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, short, double, int>)(void*)p)((byte)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, short, decimal, int>)(void*)p)((byte)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, short, IntPtr, int>)(void*)p)((byte)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke02X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, int, byte, int>)(void*)p)((byte)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, int, short, int>)(void*)p)((byte)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, int, int, int>)(void*)p)((byte)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, int, float, int>)(void*)p)((byte)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, int, long, int>)(void*)p)((byte)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, int, double, int>)(void*)p)((byte)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, int, decimal, int>)(void*)p)((byte)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, int, IntPtr, int>)(void*)p)((byte)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke06X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, float, byte, int>)(void*)p)((byte)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, float, short, int>)(void*)p)((byte)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, float, int, int>)(void*)p)((byte)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, float, float, int>)(void*)p)((byte)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, float, long, int>)(void*)p)((byte)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, float, double, int>)(void*)p)((byte)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, float, decimal, int>)(void*)p)((byte)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, float, IntPtr, int>)(void*)p)((byte)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke03X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, long, byte, int>)(void*)p)((byte)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, long, short, int>)(void*)p)((byte)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, long, int, int>)(void*)p)((byte)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, long, float, int>)(void*)p)((byte)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, long, long, int>)(void*)p)((byte)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, long, double, int>)(void*)p)((byte)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, long, decimal, int>)(void*)p)((byte)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, long, IntPtr, int>)(void*)p)((byte)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke05X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, double, byte, int>)(void*)p)((byte)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, double, short, int>)(void*)p)((byte)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, double, int, int>)(void*)p)((byte)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, double, float, int>)(void*)p)((byte)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, double, long, int>)(void*)p)((byte)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, double, double, int>)(void*)p)((byte)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, double, decimal, int>)(void*)p)((byte)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, double, IntPtr, int>)(void*)p)((byte)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke04X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, decimal, byte, int>)(void*)p)((byte)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, decimal, short, int>)(void*)p)((byte)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, decimal, int, int>)(void*)p)((byte)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, decimal, float, int>)(void*)p)((byte)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, decimal, long, int>)(void*)p)((byte)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, decimal, double, int>)(void*)p)((byte)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, decimal, decimal, int>)(void*)p)((byte)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, decimal, IntPtr, int>)(void*)p)((byte)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke07X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, byte, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, short, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, int, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, float, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, long, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, double, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, decimal, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<byte, IntPtr, IntPtr, int>)(void*)p)((byte)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke1XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke10X(code, p, args),
                '1' => Invoke11X(code, p, args),
                '2' => Invoke12X(code, p, args),
                '6' => Invoke16X(code, p, args),
                '3' => Invoke13X(code, p, args),
                '5' => Invoke15X(code, p, args),
                '4' => Invoke14X(code, p, args),
                '7' => Invoke17X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke10X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, byte, byte, int>)(void*)p)((short)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, byte, short, int>)(void*)p)((short)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, byte, int, int>)(void*)p)((short)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, byte, float, int>)(void*)p)((short)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, byte, long, int>)(void*)p)((short)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, byte, double, int>)(void*)p)((short)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, byte, decimal, int>)(void*)p)((short)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, byte, IntPtr, int>)(void*)p)((short)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke11X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, short, byte, int>)(void*)p)((short)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, short, short, int>)(void*)p)((short)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, short, int, int>)(void*)p)((short)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, short, float, int>)(void*)p)((short)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, short, long, int>)(void*)p)((short)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, short, double, int>)(void*)p)((short)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, short, decimal, int>)(void*)p)((short)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, short, IntPtr, int>)(void*)p)((short)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke12X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, int, byte, int>)(void*)p)((short)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, int, short, int>)(void*)p)((short)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, int, int, int>)(void*)p)((short)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, int, float, int>)(void*)p)((short)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, int, long, int>)(void*)p)((short)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, int, double, int>)(void*)p)((short)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, int, decimal, int>)(void*)p)((short)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, int, IntPtr, int>)(void*)p)((short)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke16X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, float, byte, int>)(void*)p)((short)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, float, short, int>)(void*)p)((short)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, float, int, int>)(void*)p)((short)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, float, float, int>)(void*)p)((short)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, float, long, int>)(void*)p)((short)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, float, double, int>)(void*)p)((short)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, float, decimal, int>)(void*)p)((short)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, float, IntPtr, int>)(void*)p)((short)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke13X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, long, byte, int>)(void*)p)((short)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, long, short, int>)(void*)p)((short)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, long, int, int>)(void*)p)((short)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, long, float, int>)(void*)p)((short)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, long, long, int>)(void*)p)((short)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, long, double, int>)(void*)p)((short)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, long, decimal, int>)(void*)p)((short)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, long, IntPtr, int>)(void*)p)((short)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke15X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, double, byte, int>)(void*)p)((short)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, double, short, int>)(void*)p)((short)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, double, int, int>)(void*)p)((short)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, double, float, int>)(void*)p)((short)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, double, long, int>)(void*)p)((short)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, double, double, int>)(void*)p)((short)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, double, decimal, int>)(void*)p)((short)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, double, IntPtr, int>)(void*)p)((short)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke14X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, decimal, byte, int>)(void*)p)((short)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, decimal, short, int>)(void*)p)((short)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, decimal, int, int>)(void*)p)((short)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, decimal, float, int>)(void*)p)((short)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, decimal, long, int>)(void*)p)((short)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, decimal, double, int>)(void*)p)((short)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, decimal, decimal, int>)(void*)p)((short)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, decimal, IntPtr, int>)(void*)p)((short)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke17X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<short, IntPtr, byte, int>)(void*)p)((short)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<short, IntPtr, short, int>)(void*)p)((short)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<short, IntPtr, int, int>)(void*)p)((short)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<short, IntPtr, float, int>)(void*)p)((short)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<short, IntPtr, long, int>)(void*)p)((short)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<short, IntPtr, double, int>)(void*)p)((short)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<short, IntPtr, decimal, int>)(void*)p)((short)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<short, IntPtr, IntPtr, int>)(void*)p)((short)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke2XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke20X(code, p, args),
                '1' => Invoke21X(code, p, args),
                '2' => Invoke22X(code, p, args),
                '6' => Invoke26X(code, p, args),
                '3' => Invoke23X(code, p, args),
                '5' => Invoke25X(code, p, args),
                '4' => Invoke24X(code, p, args),
                '7' => Invoke27X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke20X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, byte, byte, int>)(void*)p)((int)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, byte, short, int>)(void*)p)((int)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, byte, int, int>)(void*)p)((int)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, byte, float, int>)(void*)p)((int)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, byte, long, int>)(void*)p)((int)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, byte, double, int>)(void*)p)((int)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, byte, decimal, int>)(void*)p)((int)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, byte, IntPtr, int>)(void*)p)((int)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke21X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, short, byte, int>)(void*)p)((int)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, short, short, int>)(void*)p)((int)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, short, int, int>)(void*)p)((int)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, short, float, int>)(void*)p)((int)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, short, long, int>)(void*)p)((int)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, short, double, int>)(void*)p)((int)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, short, decimal, int>)(void*)p)((int)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, short, IntPtr, int>)(void*)p)((int)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke22X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, int, byte, int>)(void*)p)((int)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, int, short, int>)(void*)p)((int)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, int, int, int>)(void*)p)((int)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, int, float, int>)(void*)p)((int)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, int, long, int>)(void*)p)((int)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, int, double, int>)(void*)p)((int)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, int, decimal, int>)(void*)p)((int)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, int, IntPtr, int>)(void*)p)((int)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke26X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, float, byte, int>)(void*)p)((int)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, float, short, int>)(void*)p)((int)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, float, int, int>)(void*)p)((int)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, float, float, int>)(void*)p)((int)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, float, long, int>)(void*)p)((int)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, float, double, int>)(void*)p)((int)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, float, decimal, int>)(void*)p)((int)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, float, IntPtr, int>)(void*)p)((int)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke23X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, long, byte, int>)(void*)p)((int)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, long, short, int>)(void*)p)((int)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, long, int, int>)(void*)p)((int)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, long, float, int>)(void*)p)((int)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, long, long, int>)(void*)p)((int)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, long, double, int>)(void*)p)((int)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, long, decimal, int>)(void*)p)((int)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, long, IntPtr, int>)(void*)p)((int)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke25X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, double, byte, int>)(void*)p)((int)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, double, short, int>)(void*)p)((int)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, double, int, int>)(void*)p)((int)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, double, float, int>)(void*)p)((int)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, double, long, int>)(void*)p)((int)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, double, double, int>)(void*)p)((int)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, double, decimal, int>)(void*)p)((int)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, double, IntPtr, int>)(void*)p)((int)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke24X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, decimal, byte, int>)(void*)p)((int)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, decimal, short, int>)(void*)p)((int)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, decimal, int, int>)(void*)p)((int)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, decimal, float, int>)(void*)p)((int)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, decimal, long, int>)(void*)p)((int)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, decimal, double, int>)(void*)p)((int)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, decimal, decimal, int>)(void*)p)((int)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, decimal, IntPtr, int>)(void*)p)((int)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke27X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<int, IntPtr, byte, int>)(void*)p)((int)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<int, IntPtr, short, int>)(void*)p)((int)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<int, IntPtr, int, int>)(void*)p)((int)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<int, IntPtr, float, int>)(void*)p)((int)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<int, IntPtr, long, int>)(void*)p)((int)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<int, IntPtr, double, int>)(void*)p)((int)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<int, IntPtr, decimal, int>)(void*)p)((int)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<int, IntPtr, IntPtr, int>)(void*)p)((int)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke6XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke60X(code, p, args),
                '1' => Invoke61X(code, p, args),
                '2' => Invoke62X(code, p, args),
                '6' => Invoke66X(code, p, args),
                '3' => Invoke63X(code, p, args),
                '5' => Invoke65X(code, p, args),
                '4' => Invoke64X(code, p, args),
                '7' => Invoke67X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke60X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, byte, byte, int>)(void*)p)((float)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, byte, short, int>)(void*)p)((float)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, byte, int, int>)(void*)p)((float)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, byte, float, int>)(void*)p)((float)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, byte, long, int>)(void*)p)((float)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, byte, double, int>)(void*)p)((float)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, byte, decimal, int>)(void*)p)((float)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, byte, IntPtr, int>)(void*)p)((float)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke61X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, short, byte, int>)(void*)p)((float)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, short, short, int>)(void*)p)((float)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, short, int, int>)(void*)p)((float)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, short, float, int>)(void*)p)((float)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, short, long, int>)(void*)p)((float)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, short, double, int>)(void*)p)((float)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, short, decimal, int>)(void*)p)((float)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, short, IntPtr, int>)(void*)p)((float)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke62X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, int, byte, int>)(void*)p)((float)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, int, short, int>)(void*)p)((float)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, int, int, int>)(void*)p)((float)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, int, float, int>)(void*)p)((float)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, int, long, int>)(void*)p)((float)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, int, double, int>)(void*)p)((float)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, int, decimal, int>)(void*)p)((float)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, int, IntPtr, int>)(void*)p)((float)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke66X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, float, byte, int>)(void*)p)((float)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, float, short, int>)(void*)p)((float)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, float, int, int>)(void*)p)((float)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, float, float, int>)(void*)p)((float)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, float, long, int>)(void*)p)((float)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, float, double, int>)(void*)p)((float)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, float, decimal, int>)(void*)p)((float)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, float, IntPtr, int>)(void*)p)((float)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke63X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, long, byte, int>)(void*)p)((float)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, long, short, int>)(void*)p)((float)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, long, int, int>)(void*)p)((float)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, long, float, int>)(void*)p)((float)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, long, long, int>)(void*)p)((float)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, long, double, int>)(void*)p)((float)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, long, decimal, int>)(void*)p)((float)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, long, IntPtr, int>)(void*)p)((float)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke65X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, double, byte, int>)(void*)p)((float)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, double, short, int>)(void*)p)((float)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, double, int, int>)(void*)p)((float)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, double, float, int>)(void*)p)((float)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, double, long, int>)(void*)p)((float)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, double, double, int>)(void*)p)((float)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, double, decimal, int>)(void*)p)((float)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, double, IntPtr, int>)(void*)p)((float)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke64X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, decimal, byte, int>)(void*)p)((float)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, decimal, short, int>)(void*)p)((float)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, decimal, int, int>)(void*)p)((float)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, decimal, float, int>)(void*)p)((float)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, decimal, long, int>)(void*)p)((float)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, decimal, double, int>)(void*)p)((float)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, decimal, decimal, int>)(void*)p)((float)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, decimal, IntPtr, int>)(void*)p)((float)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke67X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<float, IntPtr, byte, int>)(void*)p)((float)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<float, IntPtr, short, int>)(void*)p)((float)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<float, IntPtr, int, int>)(void*)p)((float)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<float, IntPtr, float, int>)(void*)p)((float)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<float, IntPtr, long, int>)(void*)p)((float)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<float, IntPtr, double, int>)(void*)p)((float)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<float, IntPtr, decimal, int>)(void*)p)((float)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<float, IntPtr, IntPtr, int>)(void*)p)((float)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke3XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke30X(code, p, args),
                '1' => Invoke31X(code, p, args),
                '2' => Invoke32X(code, p, args),
                '6' => Invoke36X(code, p, args),
                '3' => Invoke33X(code, p, args),
                '5' => Invoke35X(code, p, args),
                '4' => Invoke34X(code, p, args),
                '7' => Invoke37X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke30X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, byte, byte, int>)(void*)p)((long)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, byte, short, int>)(void*)p)((long)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, byte, int, int>)(void*)p)((long)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, byte, float, int>)(void*)p)((long)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, byte, long, int>)(void*)p)((long)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, byte, double, int>)(void*)p)((long)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, byte, decimal, int>)(void*)p)((long)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, byte, IntPtr, int>)(void*)p)((long)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke31X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, short, byte, int>)(void*)p)((long)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, short, short, int>)(void*)p)((long)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, short, int, int>)(void*)p)((long)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, short, float, int>)(void*)p)((long)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, short, long, int>)(void*)p)((long)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, short, double, int>)(void*)p)((long)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, short, decimal, int>)(void*)p)((long)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, short, IntPtr, int>)(void*)p)((long)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke32X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, int, byte, int>)(void*)p)((long)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, int, short, int>)(void*)p)((long)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, int, int, int>)(void*)p)((long)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, int, float, int>)(void*)p)((long)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, int, long, int>)(void*)p)((long)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, int, double, int>)(void*)p)((long)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, int, decimal, int>)(void*)p)((long)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, int, IntPtr, int>)(void*)p)((long)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke36X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, float, byte, int>)(void*)p)((long)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, float, short, int>)(void*)p)((long)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, float, int, int>)(void*)p)((long)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, float, float, int>)(void*)p)((long)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, float, long, int>)(void*)p)((long)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, float, double, int>)(void*)p)((long)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, float, decimal, int>)(void*)p)((long)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, float, IntPtr, int>)(void*)p)((long)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke33X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, long, byte, int>)(void*)p)((long)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, long, short, int>)(void*)p)((long)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, long, int, int>)(void*)p)((long)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, long, float, int>)(void*)p)((long)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, long, long, int>)(void*)p)((long)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, long, double, int>)(void*)p)((long)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, long, decimal, int>)(void*)p)((long)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, long, IntPtr, int>)(void*)p)((long)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke35X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, double, byte, int>)(void*)p)((long)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, double, short, int>)(void*)p)((long)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, double, int, int>)(void*)p)((long)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, double, float, int>)(void*)p)((long)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, double, long, int>)(void*)p)((long)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, double, double, int>)(void*)p)((long)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, double, decimal, int>)(void*)p)((long)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, double, IntPtr, int>)(void*)p)((long)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke34X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, decimal, byte, int>)(void*)p)((long)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, decimal, short, int>)(void*)p)((long)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, decimal, int, int>)(void*)p)((long)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, decimal, float, int>)(void*)p)((long)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, decimal, long, int>)(void*)p)((long)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, decimal, double, int>)(void*)p)((long)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, decimal, decimal, int>)(void*)p)((long)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, decimal, IntPtr, int>)(void*)p)((long)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke37X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<long, IntPtr, byte, int>)(void*)p)((long)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<long, IntPtr, short, int>)(void*)p)((long)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<long, IntPtr, int, int>)(void*)p)((long)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<long, IntPtr, float, int>)(void*)p)((long)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<long, IntPtr, long, int>)(void*)p)((long)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<long, IntPtr, double, int>)(void*)p)((long)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<long, IntPtr, decimal, int>)(void*)p)((long)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<long, IntPtr, IntPtr, int>)(void*)p)((long)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke5XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke50X(code, p, args),
                '1' => Invoke51X(code, p, args),
                '2' => Invoke52X(code, p, args),
                '6' => Invoke56X(code, p, args),
                '3' => Invoke53X(code, p, args),
                '5' => Invoke55X(code, p, args),
                '4' => Invoke54X(code, p, args),
                '7' => Invoke57X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke50X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, byte, byte, int>)(void*)p)((double)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, byte, short, int>)(void*)p)((double)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, byte, int, int>)(void*)p)((double)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, byte, float, int>)(void*)p)((double)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, byte, long, int>)(void*)p)((double)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, byte, double, int>)(void*)p)((double)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, byte, decimal, int>)(void*)p)((double)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, byte, IntPtr, int>)(void*)p)((double)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke51X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, short, byte, int>)(void*)p)((double)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, short, short, int>)(void*)p)((double)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, short, int, int>)(void*)p)((double)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, short, float, int>)(void*)p)((double)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, short, long, int>)(void*)p)((double)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, short, double, int>)(void*)p)((double)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, short, decimal, int>)(void*)p)((double)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, short, IntPtr, int>)(void*)p)((double)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke52X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, int, byte, int>)(void*)p)((double)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, int, short, int>)(void*)p)((double)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, int, int, int>)(void*)p)((double)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, int, float, int>)(void*)p)((double)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, int, long, int>)(void*)p)((double)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, int, double, int>)(void*)p)((double)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, int, decimal, int>)(void*)p)((double)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, int, IntPtr, int>)(void*)p)((double)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke56X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, float, byte, int>)(void*)p)((double)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, float, short, int>)(void*)p)((double)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, float, int, int>)(void*)p)((double)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, float, float, int>)(void*)p)((double)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, float, long, int>)(void*)p)((double)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, float, double, int>)(void*)p)((double)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, float, decimal, int>)(void*)p)((double)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, float, IntPtr, int>)(void*)p)((double)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke53X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, long, byte, int>)(void*)p)((double)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, long, short, int>)(void*)p)((double)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, long, int, int>)(void*)p)((double)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, long, float, int>)(void*)p)((double)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, long, long, int>)(void*)p)((double)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, long, double, int>)(void*)p)((double)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, long, decimal, int>)(void*)p)((double)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, long, IntPtr, int>)(void*)p)((double)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke55X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, double, byte, int>)(void*)p)((double)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, double, short, int>)(void*)p)((double)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, double, int, int>)(void*)p)((double)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, double, float, int>)(void*)p)((double)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, double, long, int>)(void*)p)((double)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, double, double, int>)(void*)p)((double)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, double, decimal, int>)(void*)p)((double)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, double, IntPtr, int>)(void*)p)((double)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke54X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, decimal, byte, int>)(void*)p)((double)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, decimal, short, int>)(void*)p)((double)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, decimal, int, int>)(void*)p)((double)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, decimal, float, int>)(void*)p)((double)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, decimal, long, int>)(void*)p)((double)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, decimal, double, int>)(void*)p)((double)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, decimal, decimal, int>)(void*)p)((double)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, decimal, IntPtr, int>)(void*)p)((double)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke57X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<double, IntPtr, byte, int>)(void*)p)((double)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<double, IntPtr, short, int>)(void*)p)((double)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<double, IntPtr, int, int>)(void*)p)((double)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<double, IntPtr, float, int>)(void*)p)((double)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<double, IntPtr, long, int>)(void*)p)((double)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<double, IntPtr, double, int>)(void*)p)((double)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<double, IntPtr, decimal, int>)(void*)p)((double)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<double, IntPtr, IntPtr, int>)(void*)p)((double)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke4XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke40X(code, p, args),
                '1' => Invoke41X(code, p, args),
                '2' => Invoke42X(code, p, args),
                '6' => Invoke46X(code, p, args),
                '3' => Invoke43X(code, p, args),
                '5' => Invoke45X(code, p, args),
                '4' => Invoke44X(code, p, args),
                '7' => Invoke47X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke40X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, byte, byte, int>)(void*)p)((decimal)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, byte, short, int>)(void*)p)((decimal)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, byte, int, int>)(void*)p)((decimal)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, byte, float, int>)(void*)p)((decimal)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, byte, long, int>)(void*)p)((decimal)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, byte, double, int>)(void*)p)((decimal)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, byte, decimal, int>)(void*)p)((decimal)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, byte, IntPtr, int>)(void*)p)((decimal)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke41X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, short, byte, int>)(void*)p)((decimal)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, short, short, int>)(void*)p)((decimal)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, short, int, int>)(void*)p)((decimal)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, short, float, int>)(void*)p)((decimal)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, short, long, int>)(void*)p)((decimal)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, short, double, int>)(void*)p)((decimal)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, short, decimal, int>)(void*)p)((decimal)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, short, IntPtr, int>)(void*)p)((decimal)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke42X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, int, byte, int>)(void*)p)((decimal)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, int, short, int>)(void*)p)((decimal)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, int, int, int>)(void*)p)((decimal)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, int, float, int>)(void*)p)((decimal)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, int, long, int>)(void*)p)((decimal)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, int, double, int>)(void*)p)((decimal)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, int, decimal, int>)(void*)p)((decimal)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, int, IntPtr, int>)(void*)p)((decimal)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke46X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, float, byte, int>)(void*)p)((decimal)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, float, short, int>)(void*)p)((decimal)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, float, int, int>)(void*)p)((decimal)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, float, float, int>)(void*)p)((decimal)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, float, long, int>)(void*)p)((decimal)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, float, double, int>)(void*)p)((decimal)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, float, decimal, int>)(void*)p)((decimal)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, float, IntPtr, int>)(void*)p)((decimal)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke43X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, long, byte, int>)(void*)p)((decimal)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, long, short, int>)(void*)p)((decimal)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, long, int, int>)(void*)p)((decimal)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, long, float, int>)(void*)p)((decimal)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, long, long, int>)(void*)p)((decimal)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, long, double, int>)(void*)p)((decimal)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, long, decimal, int>)(void*)p)((decimal)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, long, IntPtr, int>)(void*)p)((decimal)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke45X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, double, byte, int>)(void*)p)((decimal)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, double, short, int>)(void*)p)((decimal)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, double, int, int>)(void*)p)((decimal)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, double, float, int>)(void*)p)((decimal)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, double, long, int>)(void*)p)((decimal)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, double, double, int>)(void*)p)((decimal)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, double, decimal, int>)(void*)p)((decimal)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, double, IntPtr, int>)(void*)p)((decimal)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke44X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, decimal, byte, int>)(void*)p)((decimal)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, decimal, short, int>)(void*)p)((decimal)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, decimal, int, int>)(void*)p)((decimal)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, decimal, float, int>)(void*)p)((decimal)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, decimal, long, int>)(void*)p)((decimal)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, decimal, double, int>)(void*)p)((decimal)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, decimal, decimal, int>)(void*)p)((decimal)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, decimal, IntPtr, int>)(void*)p)((decimal)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke47X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, byte, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, short, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, int, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, float, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, long, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, double, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, decimal, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<decimal, IntPtr, IntPtr, int>)(void*)p)((decimal)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private static int Invoke7XX(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[1] switch
            {
                '0' => Invoke70X(code, p, args),
                '1' => Invoke71X(code, p, args),
                '2' => Invoke72X(code, p, args),
                '6' => Invoke76X(code, p, args),
                '3' => Invoke73X(code, p, args),
                '5' => Invoke75X(code, p, args),
                '4' => Invoke74X(code, p, args),
                '7' => Invoke77X(code, p, args),
                _ => -1,
            };
        }

        private unsafe static int Invoke70X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, short, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, int, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, float, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, long, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, double, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, decimal, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, int>)(void*)p)((IntPtr)args![0], (byte)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke71X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, short, byte, int>)(void*)p)((IntPtr)args![0], (short)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, short, short, int>)(void*)p)((IntPtr)args![0], (short)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, short, int, int>)(void*)p)((IntPtr)args![0], (short)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, short, float, int>)(void*)p)((IntPtr)args![0], (short)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, short, long, int>)(void*)p)((IntPtr)args![0], (short)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, short, double, int>)(void*)p)((IntPtr)args![0], (short)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, short, decimal, int>)(void*)p)((IntPtr)args![0], (short)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, short, IntPtr, int>)(void*)p)((IntPtr)args![0], (short)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke72X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, int, byte, int>)(void*)p)((IntPtr)args![0], (int)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, int, short, int>)(void*)p)((IntPtr)args![0], (int)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int>)(void*)p)((IntPtr)args![0], (int)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, int, float, int>)(void*)p)((IntPtr)args![0], (int)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, int, long, int>)(void*)p)((IntPtr)args![0], (int)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, int, double, int>)(void*)p)((IntPtr)args![0], (int)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, int, decimal, int>)(void*)p)((IntPtr)args![0], (int)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, int>)(void*)p)((IntPtr)args![0], (int)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke76X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, float, byte, int>)(void*)p)((IntPtr)args![0], (float)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, float, short, int>)(void*)p)((IntPtr)args![0], (float)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, float, int, int>)(void*)p)((IntPtr)args![0], (float)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, float, float, int>)(void*)p)((IntPtr)args![0], (float)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, float, long, int>)(void*)p)((IntPtr)args![0], (float)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, float, double, int>)(void*)p)((IntPtr)args![0], (float)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, float, decimal, int>)(void*)p)((IntPtr)args![0], (float)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, int>)(void*)p)((IntPtr)args![0], (float)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke73X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, long, byte, int>)(void*)p)((IntPtr)args![0], (long)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, long, short, int>)(void*)p)((IntPtr)args![0], (long)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, long, int, int>)(void*)p)((IntPtr)args![0], (long)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, long, float, int>)(void*)p)((IntPtr)args![0], (long)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, long, long, int>)(void*)p)((IntPtr)args![0], (long)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, long, double, int>)(void*)p)((IntPtr)args![0], (long)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, long, decimal, int>)(void*)p)((IntPtr)args![0], (long)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, long, IntPtr, int>)(void*)p)((IntPtr)args![0], (long)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke75X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, double, byte, int>)(void*)p)((IntPtr)args![0], (double)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, double, short, int>)(void*)p)((IntPtr)args![0], (double)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, double, int, int>)(void*)p)((IntPtr)args![0], (double)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, double, float, int>)(void*)p)((IntPtr)args![0], (double)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, double, long, int>)(void*)p)((IntPtr)args![0], (double)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, double, double, int>)(void*)p)((IntPtr)args![0], (double)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, double, decimal, int>)(void*)p)((IntPtr)args![0], (double)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, double, IntPtr, int>)(void*)p)((IntPtr)args![0], (double)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke74X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, byte, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, short, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, int, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, float, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, long, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, double, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, decimal, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, decimal, IntPtr, int>)(void*)p)((IntPtr)args![0], (decimal)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }

        private unsafe static int Invoke77X(string code, IntPtr p, List<object?>? args)
        {
            if (args == null)
            {
                return -1;
            }
            return code[2] switch
            {
                '0' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (byte)args![2]),
                '1' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, short, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (short)args![2]),
                '2' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (int)args![2]),
                '6' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (float)args![2]),
                '3' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (long)args![2]),
                '5' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (double)args![2]),
                '4' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, decimal, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (decimal)args![2]),
                '7' => ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int>)(void*)p)((IntPtr)args![0], (IntPtr)args![1], (IntPtr)args![2]),
                _ => -1,
            };
        }
    }

}


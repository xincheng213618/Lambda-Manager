using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Common.ViewMode
{
    public class MemorySize
    {
        /// <summary>
        /// 内存大小转文本
        /// </summary>
        /// <returns></returns>
        public static string MemorySizeText(ulong memorySize)
        {
            if (memorySize < 1024)
            {
                return memorySize + " Byte";
            }
            if (memorySize < 10240)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0) + " kB";
            }
            if (memorySize < 1048576)
            {
                return memorySize / 1024uL + " kB";
            }
            if (memorySize < 10485760)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0 / 1024.0) + " MB";
            }
            if (memorySize < 1073741824)
            {
                return memorySize / 1024uL / 1024uL + " MB";
            }
            if (memorySize < 10737418240L)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0 / 1024.0 / 1024.0) + " GB";
            }
            if (memorySize < 1099511627776L)
            {
                return memorySize / 1024uL / 1024uL / 1024uL + " GB";
            }
            if (memorySize < 10995116277760L)
            {
                return string.Format("{0:F1}", (double)memorySize / 1024.0 / 1024.0 / 1024.0 / 1024.0) + " TB";
            }
            return memorySize / 1024uL / 1024uL / 1024uL / 1024uL + " TB";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace ConfigBottomView
{
    public static class Extensions
    {

        public static string HistogramMax(this Dictionary<int, int> histogramMaxValue, int histogramMaxIndex)
        {
            string peakHistogram = string.Empty;
            foreach (KeyValuePair<int, int> item in histogramMaxValue)
            {
                if (item.Value == histogramMaxIndex)
                {
                    peakHistogram += item.Key + "，";
                }
            }
            return peakHistogram.Remove(peakHistogram.Length - 1);
        }

        public static BitmapSource GetBitmapSource(Bitmap bitmap)
        {
            return System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

    }
}

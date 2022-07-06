using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

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


        public static void LoadViewFromUri(this FrameworkElement userControl, string baseUri)
        {
            try
            {
                var resourceLocater = new Uri(baseUri, UriKind.Relative);
                var exprCa = (PackagePart)typeof(Application).GetMethod("GetResourceOrContentPart", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, new object[] { resourceLocater });
                var stream = exprCa.GetStream();
                var uri = new Uri((Uri)typeof(BaseUriHelper).GetProperty("PackAppBaseUri", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null, null), resourceLocater);
                var parserContext = new ParserContext
                {
                    BaseUri = uri
                };
                typeof(XamlReader).GetMethod("LoadBaml", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, new object[] { stream, parserContext, userControl, true });
            }
            catch (Exception)
            {
                //log
            }
        }

    }
}

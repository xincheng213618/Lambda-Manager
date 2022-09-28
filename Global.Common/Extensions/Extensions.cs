using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
using System.IO;
using System.Text.Json;

namespace Global.Common.Extensions
{
    /// <summary>
    // 扩展加载，没有特殊标记的丢在这里，反正会自动识别加载
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// 对图标的扩展
        /// </summary>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static ImageSource ToImageSource(this Icon icon)
        {
            ImageSource imageSource = Imaging.CreateBitmapSourceFromHIcon(
                icon.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            return imageSource;
        }

        /// <summary>
        ///  只有中文转换成Uincode
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToUincode(this string str)
        {
            return Converter.String.ToUincode(str);
        }
    }
}

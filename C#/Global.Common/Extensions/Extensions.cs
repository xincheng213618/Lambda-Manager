﻿using System;
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
using System.ComponentModel;
using System.Reflection;

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


        public static string Description(object obj)
        {
            System.Type type = obj.GetType();
            MemberInfo[] infos = type.GetMember(obj.ToString() ?? "");
            if (infos != null && infos.Length != 0)
            {
                object[] attrs = infos[0].GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
                if (attrs != null && attrs.Length != 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return type.ToString();
        }
    }
}

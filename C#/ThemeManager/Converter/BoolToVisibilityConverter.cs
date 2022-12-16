using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ThemeManager.Converter
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public sealed class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// 设定正值
        /// </summary>
        public Visibility TrueValue { get; set; }
        
        /// <summary>
        /// 设定负值
        /// </summary>
        public Visibility FalseValue { get; set; }
        
        /// <summary>
        /// 是否颠倒
        /// </summary>
        public bool Reverse { get; set; }

        public BoolToVisibilityConverter()
        {
            // set defaults
            TrueValue = Visibility.Visible;
            FalseValue = Visibility.Collapsed;
            Reverse = false;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Visibility.Collapsed;
            if (Reverse)
                return (bool)value ? FalseValue : TrueValue;
            else
                return (bool)value ? TrueValue : FalseValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Reverse)
            {
                if (Equals(value, TrueValue))
                    return true;
                if (Equals(value, FalseValue))
                    return false;
            }
            else {
                if (Equals(value, TrueValue))
                    return false;
                if (Equals(value, FalseValue))
                    return true;
            }
            return false;
        }

    }
    public sealed class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool flag = false;
            if (value is bool boolean)
            {
                flag = boolean;
            }
            else if (value is bool?)
            {
                bool? flag2 = (bool?)value;
                flag = flag2.HasValue && flag2.Value;
            }

            return (!flag) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
            {
                return (Visibility)value == Visibility.Visible;
            }

            return false;
        }
    }

    /// <summary>
    /// 红色
    /// </summary>
    public sealed class BoolToSolidColorBrushWarn : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return ThemeManagers.CurrentUITheme == Theme.Dark ? Brushes.White : Brushes.Black;
            return !(bool)value ? Brushes.Red : ThemeManagers.CurrentUITheme == Theme.Dark ? Brushes.White : Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public sealed class BoolToStringConverer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter is string str )
            {
                if (str == "1")
                {
                    return (value is bool boll1) && (boll1) ? "关闭" : "打开";
                }
                else if (str == "2")
                {
                    return (value is bool boll1) && (!boll1) ? "关闭" : "打开";
                }
            }
            return (value is bool boll) && (boll) ? "正常" : "未连接";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }




    public sealed class SolidColorBrushOpacityConverer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is SolidColorBrush solidColorBrush)
            {
                if (double.TryParse(parameter.ToString(), out double reult) && reult>=0 &&reult<=1)
                {
                    solidColorBrush.Color = new Color() { R=solidColorBrush.Color.R, B = solidColorBrush.Color.B, G = solidColorBrush.Color.G, A = System.Convert.ToByte(solidColorBrush.Color.A* reult*255) };
                }
                return solidColorBrush;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

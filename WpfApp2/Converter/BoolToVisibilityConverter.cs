using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfApp2.Converter
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
}

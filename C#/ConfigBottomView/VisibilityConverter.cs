using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ConfigBottomView
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class VisibilityConverter : IValueConverter
    {     
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if ((bool)value)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (Visibility)value == Visibility.Visible;
        }
       

    }
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class VisibilityConverter1 : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if ((bool)value)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (Visibility)value == Visibility.Visible;
        }


    }

    public class ValueToHalfConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value/2+8;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class StringValueToThousands : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double v = double.Parse((string)value) / 1000.0;

            return Math.Round(v, 1).ToString() + "k";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ValueToThousands : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double v = (int)value / 1000.0;

            return Math.Round(v, 1).ToString() + "k";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
   
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
            else
            {
                if (Equals(value, TrueValue))
                    return false;
                if (Equals(value, FalseValue))
                    return true;
            }
            return false;
        }


    }

}

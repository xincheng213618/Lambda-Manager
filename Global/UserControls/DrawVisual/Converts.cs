using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Global
{
    public class ValueClassToUmConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //int val = int.Parse(value.ToString());
            return value + "um";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;

        }
    }

    public class ColorToSolidColorBrushConverter : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Converts a Color to a SolidColorBrush.
        /// </summary>
        /// <param name="value">The Color produced by the binding source.</param>
        /// <param name="targetType">The type of the binding target property.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted SolidColorBrush. If the method returns null, the valid null value is used.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return new SolidColorBrush((Color)value);

            return value;
        }

        /// <summary>
        /// Converts a SolidColorBrush to a Color.
        /// </summary>
        /// <remarks>Currently not used in toolkit, but provided for developer use in their own projects</remarks>
        /// <param name="value">The SolidColorBrush that is produced by the binding target.</param>
        /// <param name="targetType">The type to convert to.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        /// <returns>
        /// A converted value. If the method returns null, the valid null value is used.
        /// </returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
                return ((SolidColorBrush)value).Color;

            return value;
        }
        #endregion
    }




    public class BoolToBoldConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {


            return (bool)value ? FontWeights.Bold : FontWeights.Normal;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class BoolToItalicConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (bool)value ? FontStyles.Italic : FontStyles.Normal;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class BoolToUnderLineConverter : IValueConverter
    {



        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            TextDecoration myUnderline = new TextDecoration();
            myUnderline.PenOffset = 3;
            TextDecorationCollection myCollection = new TextDecorationCollection();
            myCollection.Add(myUnderline);


            return (bool)value ? myCollection : myUnderline;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
    
    public sealed class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool flag = false;
            if (value is bool)
            {
                flag = (bool)value;
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
    public sealed class BooleanToVisibilityConverter1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool flag = false;
            if (value is bool)
            {
                flag = (bool)value;
            }
            else if (value is bool?)
            {
                bool? flag2 = (bool?)value;
                flag = flag2.HasValue && flag2.Value;
            }

            return (!flag) ? Visibility.Hidden: Visibility.Visible;
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

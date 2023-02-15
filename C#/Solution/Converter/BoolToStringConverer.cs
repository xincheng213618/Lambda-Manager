using HotKey;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Solution.Converter
{
    public sealed class BoolToStringConverer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is bool boll) && (boll) ? "正常" : "热键冲突";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

    }


    public sealed class HotKeyToStringConverer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Hotkey hotkey)
                return hotkey.ToString();

            return string.Empty;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();

    }

}

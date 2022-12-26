using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ThemeManager.Converter
{
    /// <summary>
    /// 红色
    /// </summary>
    public sealed class BoolToSolidColorBrushWarn : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return ThemeManagers.CurrentUITheme == Theme.Dark ? Brushes.White : Brushes.Black;
            return !(bool)value ? Brushes.OrangeRed : ThemeManagers.CurrentUITheme == Theme.Dark ? Brushes.White : Brushes.Black;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

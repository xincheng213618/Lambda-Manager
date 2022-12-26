using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ThemeManager.Converter
{
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

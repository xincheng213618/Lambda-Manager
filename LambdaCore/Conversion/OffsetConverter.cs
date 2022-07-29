using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace LambdaManager.Conversion
{
    public class OffsetConverter : MarkupExtension, IValueConverter
    {
        private static PercentageConverter? _instance;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value) + System.Convert.ToInt32(parameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _instance ?? (_instance = new PercentageConverter());
        }
    }
}



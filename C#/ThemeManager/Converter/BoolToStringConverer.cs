using System.Globalization;
using System.Windows.Data;

namespace ThemeManager.Converter
{
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
                    return (value is bool boll1) && (!boll1) ? "不支持" : "支持";
                }
            }
            return (value is bool boll) && (boll) ? "正常" : "未连接";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

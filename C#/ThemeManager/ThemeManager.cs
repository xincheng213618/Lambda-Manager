using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace ThemeManager
{
    public enum Theme
    {
        [Description("黑色")]
        Dark,
        [Description("白色")]
        White,
        [Description("跟随系统")]
        Defaul,
    };

    public static class TypeExtension
    {

        public static string GetDescription(this Theme obj)
        {
            return GetDescription(obj);
        }

        public static string GetDescription(object obj)
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

    public delegate void ThemeChangedEventHandler();


    /// <summary>
    /// 主题管理器
    /// </summary>
    public static class ThemeManagers
    {
        private static Theme _CurrentUITheme = Theme.Dark;

        public static Theme CurrentUITheme
        {
            get { return _CurrentUITheme; }
            set
            { 
                if (value != _CurrentUITheme)
                {
                    _CurrentUITheme = value;
                    ThemeChanged?.Invoke();
                }
            }
        }

        public static event ThemeChangedEventHandler ThemeChanged;

        public static void ApplyTheme(this Application app, Theme theme)
        {
            CurrentUITheme = theme;

            List<string> ResourceDictionary = new();
            if (theme == Theme.Dark)
            {
                ResourceDictionary = ResourceDictionaryDark;
            }
            else if (theme == Theme.White)
            {
                ResourceDictionary = ResourceDictionaryWhite;
            }
            else if (theme == Theme.Defaul) {
                ResourceDictionary = ResourceDictionaryDark;
            }
            foreach (var item in ResourceDictionary)
            {
                ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                app.Resources.MergedDictionaries.Add(dictionary);
            }
        }


        public static List<string> ResourceDictionaryDark { get; set; } = new List<string>()
        {
            "/ThemeManager;component/Styles/Dark.xaml",
            "/ThemeManager;component/Styles/styles.xaml",
            "/ThemeManager;component/Themes/Base/Slider.xaml",
            "/ThemeManager;component/Themes/Base/ButtonStyle.xaml",
            "/ThemeManager;component/themes/Dark/Theme.xaml",
            "/ThemeManager;component/themes/Base/Menu.xaml"
        };

        public static List<string> ResourceDictionaryWhite { get; set; } = new List<string>()
        {
            "/ThemeManager;component/Styles/White.xaml",
            "/ThemeManager;component/Styles/styles.xaml",
            "/ThemeManager;component/Themes/Base/Slider.xaml",
            "/ThemeManager;component/Themes/Base/ButtonStyle.xaml",
            "/ThemeManager;component/themes/White/Theme.xaml",
            "/ThemeManager;component/themes/Base/Menu.xaml"
        };


    }
}

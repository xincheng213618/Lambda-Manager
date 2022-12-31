using System.ComponentModel;
using System.Reflection;
using System.Windows;
using ThemeManager.Util;

namespace ThemeManager
{
    public enum Theme
    {
        [Description("黑色")]
        Dark,
        [Description("白色")]
        Light,
        [Description("跟随系统")]
        Defaul
};


    public static class ThemeExtension
    {
        public static string ToString1(this Theme This)
        {
            return This switch
            {
                Theme.Dark => "黑色",
                Theme.Light => "白色",
                Theme.Defaul => "跟随系统",
                _ => string.Empty,
            };
        }
    }

    public delegate void ThemeChangedEventHandler(Theme theme);


    /// <summary>
    /// 主题管理器
    /// </summary>
    public static class ThemeManagers
    {
        private static bool IsRegister = false ;
        public static Theme CurrentUITheme
        {
            get => _CurrentUITheme; set
            {
                if (value != _CurrentUITheme)
                    _CurrentUITheme = value; Reg.WriteValue(value); ThemeChanged?.Invoke(value);
            }
        }
        private static Theme _CurrentUITheme = Reg.ReadValue(nameof(CurrentUITheme));


        public static event ThemeChangedEventHandler ThemeChanged;

        public static void ApplyTheme(this Application app, Theme theme)
        {
            if (IsRegister && CurrentUITheme == theme) return;

            if (!IsRegister) IsRegister = true;

            List<string> ResourceDictionarys = theme == Theme.Dark ? ResourceDictionaryDark : theme == Theme.Light ? ResourceDictionaryWhite : ResourceDictionaryDark;

            foreach (var item in ResourceDictionarys)
            {
                ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                app.Resources.MergedDictionaries.Add(dictionary);
            }
            CurrentUITheme = theme;
        }


        public static List<string> ResourceDictionaryDark { get; set; } = new List<string>()
        {
            "/ThemeManager;component/Styles/Dark.xaml",
            "/ThemeManager;component/Styles/styles.xaml",
            "/ThemeManager;component/Themes/Base/Slider.xaml",
            "/ThemeManager;component/Themes/Base/ButtonStyle.xaml",
            "/ThemeManager;component/themes/Dark/Theme.xaml",
            "/ThemeManager;component/themes/Base/Menu.xaml",

            //"/HandyControl;component/themes/basic/colors/dark.xaml",
            //"/HandyControl;component/Themes/Theme.xaml",
        };

        public static List<string> ResourceDictionaryWhite { get; set; } = new List<string>()
        {
            "/ThemeManager;component/Styles/White.xaml",
            "/ThemeManager;component/Styles/styles.xaml",
            "/ThemeManager;component/Themes/Base/Slider.xaml",
            "/ThemeManager;component/Themes/Base/ButtonStyle.xaml",
            "/ThemeManager;component/themes/White/Theme.xaml",
            "/ThemeManager;component/themes/Base/Menu.xaml",

            //"/HandyControl;component/themes/basic/colors/light.xaml",
            //"/HandyControl;component/Themes/Theme.xaml",
        };


    }
}

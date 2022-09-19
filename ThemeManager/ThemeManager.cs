using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ThemeManager
{
    public enum Theme
    {
        Dark,
        White
    };
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

            List<string> ResourceDictionary = new List<string>();
            if (theme == Theme.Dark)
            {
                ResourceDictionary = ResourceDictionaryDark;
            }
            else if (theme == Theme.White)
            {
                ResourceDictionary = ResourceDictionaryWhite;
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

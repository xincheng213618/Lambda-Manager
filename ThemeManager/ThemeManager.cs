using System;
using System.Collections.Generic;
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
    public static class ThemeManagers
    {
        public static Theme CurrentUITheme { get; set; } = Theme.Dark;


        public static void ApplyTheme(this Application app, Theme theme)
        {
            if (theme != CurrentUITheme)
            {
                CurrentUITheme = theme;
                if (theme == Theme.Dark)
                {
                    foreach (var item in ResourceDictionaryDark)
                    {
                        ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                        app.Resources.MergedDictionaries.Add(dictionary);
                    }
                }
                else if (theme == Theme.White)
                {
                    foreach (var item in ResourceDictionaryWhite)
                    {
                        ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                        app.Resources.MergedDictionaries.Add(dictionary);
                    }
                }
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

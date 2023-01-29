﻿using HandyControl.Properties.Langs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using ThemeManager.Controls;
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
        Default
    };

    public delegate void ThemeChangedEventHandler(Theme theme);


    /// <summary>
    /// 主题管理器
    /// </summary>
    public static class ThemeManagers
    {
        /// <summary>
        /// 是否是第一次注入样式
        /// </summary>
        private static bool IsRegister = false ;
        /// <summary>
        /// 是否打开清除开关，会影响性能
        /// </summary>
        public static bool IsOpenClear = false ;


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

        public static Dictionary<Theme, ResourceDictionary> ThemeResourceDictionaryCache = new Dictionary<Theme, ResourceDictionary>() { { Theme.Default,new ResourceDictionary()} };

        public static void ApplyTheme(this Application app, Theme theme)
        {
            if (IsRegister && CurrentUITheme == theme) return;

            if (!IsRegister)
            {
                IsRegister = true;
            }

            if (IsOpenClear)
                app.Resources.MergedDictionaries.Clear();
            
            List<string> ResourceDictionarys = theme == Theme.Dark ? ResourceDictionaryDark : theme == Theme.Light ? ResourceDictionaryWhite : ResourceDictionaryDark;
            foreach (var item in ResourceDictionarys)
            {
                ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                app.Resources.MergedDictionaries.Add(dictionary);
            }
            CurrentUITheme = theme;
        }

        public static void ApplyTheme(this Control control, Theme theme)
        {
            if (IsOpenClear)
                control.Resources.MergedDictionaries.Clear();
            List<string> ResourceDictionarys = theme == Theme.Dark ? ResourceDictionaryDark : theme == Theme.Light ? ResourceDictionaryWhite : ResourceDictionaryDark;
            foreach (var item in ResourceDictionarys)
            {
                ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                control.Resources.MergedDictionaries.Add(dictionary);
            }
        }

        public static List<string> ResourceDictionaryDark { get; set; } = new List<string>()
        {
            "/HandyControl;component/themes/basic/colors/dark.xaml",
            "/HandyControl;component/Themes/Theme.xaml",
            "/ThemeManager;component/HandyControl/Style/ThemeColor.xaml",
            "/ThemeManager;component/HandyControl/Lang/Lang.zh-CN.xaml",

            "/ThemeManager;component/Controls/Window/BaseWindow.xaml",
            "/ThemeManager;component/Styles/Dark.xaml",
            "/ThemeManager;component/Styles/styles.xaml",

            "/ThemeManager;component/Themes/Base/Slider.xaml",
            "/ThemeManager;component/Themes/Base/ButtonStyle.xaml",
            "/ThemeManager;component/Themes/Dark/Theme.xaml",
            "/ThemeManager;component/Themes/Base/Menu.xaml",
        };

        public static List<string> ResourceDictionaryWhite { get; set; } = new List<string>()
        {
            "/HandyControl;component/themes/basic/colors/light.xaml",
            "/HandyControl;component/Themes/Theme.xaml",
            "/ThemeManager;component/HandyControl/Style/ThemeColor.xaml",
            "/ThemeManager;component/HandyControl/Lang/Lang.zh-CN.xaml",

            "/ThemeManager;component/Controls/Window/BaseWindow.xaml",
            "/ThemeManager;component/Styles/White.xaml",
            "/ThemeManager;component/Styles/styles.xaml",

            "/ThemeManager;component/Themes/Base/Slider.xaml",
            "/ThemeManager;component/Themes/Base/ButtonStyle.xaml",
            "/ThemeManager;component/Themes/White/Theme.xaml",
            "/ThemeManager;component/Themes/Base/Menu.xaml",


        };
    }
}

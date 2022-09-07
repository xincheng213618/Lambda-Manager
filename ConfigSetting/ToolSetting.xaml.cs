﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConfigSetting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ToolSetting : UserControl
    {
        public ToolSetting()
        {
            InitializeComponent();
        }

        bool IsFirstLoad = true;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (IsFirstLoad && this.Parent is StackPanel stackPanel1 && stackPanel1.Parent is Viewbox viewbox1 && viewbox1.Parent is ScrollViewer scrollViewer1)
            {
                stackPanel1.Children.Remove(this);

                StackPanel stackPanel = new StackPanel() { Name = "acquireView", Margin = new Thickness(2, 2, 2, 0) };
                stackPanel.HorizontalAlignment = HorizontalAlignment.Stretch;
                stackPanel.Children.Add(this);
                Viewbox viewbox = new Viewbox() { VerticalAlignment = VerticalAlignment.Top };
                viewbox.Child = stackPanel;
                scrollViewer1.Content = viewbox;
                IsFirstLoad = false;

                foreach (var item in ResourceDictionaryDark)
                {
                    ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                    Application.Current.Resources.MergedDictionaries.Add(dictionary);
                }
            }
        }

        List<string> ResourceDictionaryDark = new List<string>();
        List<string> ResourceDictionaryWhite = new List<string>();

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            ResourceDictionaryDark.Add("/ThemeManager;component/Styles/Dark.xaml");
            ResourceDictionaryDark.Add("/ThemeManager;component/Styles/styles.xaml");
            ResourceDictionaryDark.Add("/ThemeManager;component/Themes/Base/Slider.xaml");
            ResourceDictionaryDark.Add("/ThemeManager;component/Themes/Base/ButtonStyle.xaml");
            ResourceDictionaryDark.Add("/ThemeManager;component/themes/Dark/Theme.xaml");
            ResourceDictionaryDark.Add("/ThemeManager;component/themes/Base/Menu.xaml");

            ResourceDictionaryWhite.Add("/ThemeManager;component/Styles/White.xaml");
            ResourceDictionaryWhite.Add("/ThemeManager;component/Styles/styles.xaml");
            ResourceDictionaryWhite.Add("/ThemeManager;component/Themes/Base/Slider.xaml");
            ResourceDictionaryWhite.Add("/ThemeManager;component/Themes/Base/ButtonStyle.xaml");
            ResourceDictionaryWhite.Add("/ThemeManager;component/themes/White/Theme.xaml");
            ResourceDictionaryWhite.Add("/ThemeManager;component/themes/Base/Menu.xaml");



        }
        bool IS = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IS = !IS;
            if (IS)
            {
                foreach (var item in ResourceDictionaryWhite)
                {
                    ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                    Application.Current.Resources.MergedDictionaries.Add(dictionary);
                }
            }
            else
            {
                foreach (var item in ResourceDictionaryDark)
                {
                    ResourceDictionary dictionary = Application.LoadComponent(new Uri(item, UriKind.Relative)) as ResourceDictionary;
                    Application.Current.Resources.MergedDictionaries.Add(dictionary);
                }
            }

        }

        private void UserControl_Initialized_1(object sender, EventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Wizard.MainWindow mainWindow = new Wizard.MainWindow("1");
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CalibrationWindow calibrationWindow = new CalibrationWindow();
            calibrationWindow.ShowDialog();
        }
    }
}
using Global.Common;
using Global.Common.Extensions;
using Global.SettingUp;
using Global.SettingUp.Configure;
using Global.SettingUp.PC;
using HotKey;
using Lambda;
using NvAPIWrapper.GPU;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ThemeManager;
using System.IO;
using Global.Common.Util;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ConfigSetting
{
	public partial class ToolSetting : UserControl
	{

		public void InitEmun()
		{
			ThemeCombox.ItemsSource = from e1 in Enum.GetValues(typeof(Theme)).Cast<Theme>()
									  select new KeyValuePair<Theme, string>(e1, e1.ToDescription());
			ThemeCombox.SelectedValuePath = "Key";
			ThemeCombox.DisplayMemberPath = "Value";
			ThemeCombox.SelectedIndex = (int)SoftwareConfig.WindowSetting.PhotoOptions;
			ThemeCombox.SelectionChanged += (s, e) =>
			{
				if (ThemeCombox.SelectedItem is KeyValuePair<Theme, string> KeyValue && KeyValue.Key is Theme theme)
					Application.Current.ApplyTheme(theme);
			};

			ThemeManagers.ThemeChanged += (s) =>
			{
				ThemeCombox.SelectedIndex = (int)s;
			};


			PhotoOptionsCombox.ItemsSource = from e1 in Enum.GetValues(typeof(PhotoOptions)).Cast<PhotoOptions>()
											 select new KeyValuePair<PhotoOptions, string>(e1, e1.ToDescription());
			PhotoOptionsCombox.SelectedValuePath = "Key";
			PhotoOptionsCombox.DisplayMemberPath = "Value";
			PhotoOptionsCombox.SelectedIndex = (int)SoftwareConfig.WindowSetting.PhotoOptions;
			PhotoOptionsCombox.SelectionChanged += (s, e) =>
			{
				if (PhotoOptionsCombox.SelectedItem is KeyValuePair<PhotoOptions, string> KeyValue && KeyValue.Key is PhotoOptions photoOptions)
					SoftwareConfig.WindowSetting.PhotoOptions = photoOptions;
			};
			LambdaControl.Trigger("PhotoOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)SoftwareConfig.WindowSetting.PhotoOptions } });
			SoftwareConfig.WindowSetting.PhotoOptionsChanged += (s) =>
			{
				PhotoOptionsCombox.SelectedIndex = (int)s;
			};



			DrawGraphicsOptionsCombox.ItemsSource = from e1 in Enum.GetValues(typeof(DrawGraphicsOptions)).Cast<DrawGraphicsOptions>()
													select new KeyValuePair<DrawGraphicsOptions, string>(e1, e1.ToDescription());
			DrawGraphicsOptionsCombox.SelectedValuePath = "Key";
			DrawGraphicsOptionsCombox.DisplayMemberPath = "Value";
			DrawGraphicsOptionsCombox.SelectedIndex = (int)SoftwareConfig.WindowSetting.DrawGraphicsOptions;
			DrawGraphicsOptionsCombox.SelectionChanged += (s, e) =>
			{
				if (DrawGraphicsOptionsCombox.SelectedItem is KeyValuePair<DrawGraphicsOptions, string> KeyValue && KeyValue.Key is DrawGraphicsOptions drawGraphicsOptions)
					SoftwareConfig.WindowSetting.DrawGraphicsOptions = drawGraphicsOptions;
			};
			LambdaControl.Trigger("DrawGraphicsOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)SoftwareConfig.WindowSetting.DrawGraphicsOptions } });
			SoftwareConfig.WindowSetting.DrawGraphicsOptionsChanged += (s) =>
			{
				DrawGraphicsOptionsCombox.SelectedIndex = (int)s;
			};



			ImageResolutionShowOptionsCombox.ItemsSource = from e1 in Enum.GetValues(typeof(ImageResolutionOptions)).Cast<ImageResolutionOptions>()
													select new KeyValuePair<ImageResolutionOptions, string>(e1, e1.ToDescription());
			ImageResolutionShowOptionsCombox.SelectedValuePath = "Key";
			ImageResolutionShowOptionsCombox.DisplayMemberPath = "Value";
			ImageResolutionShowOptionsCombox.SelectedIndex = (int)SoftwareConfig.WindowSetting.ImageResolutionShowOptions;
			ImageResolutionShowOptionsCombox.SelectionChanged += (s, e) =>
			{
				if (ImageResolutionShowOptionsCombox.SelectedItem is KeyValuePair<ImageResolutionOptions, string> KeyValue && KeyValue.Key is ImageResolutionOptions drawGraphicsOptions)
					SoftwareConfig.WindowSetting.ImageResolutionShowOptions = drawGraphicsOptions;
			};
			LambdaControl.Trigger("ImageResolutionShowOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)SoftwareConfig.WindowSetting.ImageResolutionShowOptions } });
			SoftwareConfig.WindowSetting.ImageResolutionShowOptionsChanged += (s) =>
			{
				ImageResolutionShowOptionsCombox.SelectedIndex = (int)s;
            };


			ImageResolutionSaveOptionsCombox.ItemsSource = from e1 in Enum.GetValues(typeof(ImageResolutionOptions)).Cast<ImageResolutionOptions>()
														   select new KeyValuePair<ImageResolutionOptions, string>(e1, e1.ToDescription());
			ImageResolutionSaveOptionsCombox.SelectedValuePath = "Key";
			ImageResolutionSaveOptionsCombox.DisplayMemberPath = "Value";
			ImageResolutionSaveOptionsCombox.SelectedIndex = (int)SoftwareConfig.WindowSetting.ImageResolutionSaveOptions;
			ImageResolutionSaveOptionsCombox.SelectionChanged += (s, e) =>
			{
				if (ImageResolutionSaveOptionsCombox.SelectedItem is KeyValuePair<ImageResolutionOptions, string> KeyValue && KeyValue.Key is ImageResolutionOptions drawGraphicsOptions)
					SoftwareConfig.WindowSetting.ImageResolutionSaveOptions = drawGraphicsOptions;
			};
			LambdaControl.Trigger("ImageResolutionSaveOptionsChanged", this, new Dictionary<string, object>() { { "Type", (int)SoftwareConfig.WindowSetting.ImageResolutionSaveOptions } });
			SoftwareConfig.WindowSetting.ImageResolutionSaveOptionsChanged += (s) =>
			{
				ImageResolutionSaveOptionsCombox.SelectedIndex = (int)s;
			};

            //ImageResolutionOptions TempSave = SoftwareConfig.WindowSetting.ImageResolutionShowOptions;
            //ImageResolutionOptions TempSave1 = SoftwareConfig.WindowSetting.ImageResolutionSaveOptions;

            //if (Application.Current.MainWindow.FindName("stageConfig") is Grid stageConfig)
            //{
            //    stageConfig.IsVisibleChanged += (s, e) =>
            //    {
            //        if (stageConfig.Visibility != Visibility.Visible &&( TempSave != SoftwareConfig.WindowSetting.ImageResolutionShowOptions|| TempSave1!= SoftwareConfig.WindowSetting.ImageResolutionSaveOptions))
            //        {
            //            if (MessageBox.Show("更改参数涉及到硬件状态，是否选择重启", "Grid", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            //            {
            //                Process.Start(Application.ResourceAssembly.Location.Replace("dll", "exe"));
            //                Application.Current.Shutdown();
            //            }
            //            else
            //            {
            //                SoftwareConfig.WindowSetting.ImageResolutionShowOptions = TempSave;
            //                SoftwareConfig.WindowSetting.ImageResolutionSaveOptions = TempSave1;


            //            }
            //        }
            //    };

            //}

        }

		public void InitConnect()
		{

			if (Application.Current.MainWindow.FindName("statusBar") is StatusBar statusBar)
			{
				string xaml = @"<ItemsPanelTemplate   xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'>
                        <DockPanel/>
                    </ItemsPanelTemplate>";
				statusBar.ItemsPanel = XamlReader.Parse(xaml) as ItemsPanelTemplate;
				statusBar.Background = Brushes.Transparent;
                Dictionary<string, string> properties1 = new Dictionary<string, string>()
					{
						{ "IsCameraConnection","CameraControlTemplate"},
						{ "IsStageConnection","StageControlTemplate"},
						{ "IsLightConnection","LightSourceControlTemplate"},
					};
				Dictionary<string, string> propertiesTag = new Dictionary<string, string>()
					{
						{ "IsCameraConnection","相机连接情况"},
						{ "IsStageConnection","位移台连接情况"},
						{ "IsLightConnection","光源连接情况"},
					};
				Dictionary<string, double> propertiesHeight = new Dictionary<string, double>()
					{
						{ "IsCameraConnection",15},
						{ "IsStageConnection",15},
						{ "IsLightConnection",18},
					};

				ResourceDictionary resourceDictionary = new ResourceDictionary() { Source = new Uri("/ConfigSetting;component/themes/Button.xaml", UriKind.Relative) };
				DockPanel dockPanel = new DockPanel();
				foreach (var property in properties1)
				{
					Button button = new Button() { Height = propertiesHeight[property.Key], Width = propertiesHeight[property.Key], Background = Brushes.Transparent, DataContext = SoftwareConfig.HardwareSetting, Tag = propertiesTag[property.Key], Margin = new Thickness(4, 0, 2, 0) };
					if (resourceDictionary.Contains(property.Value) && resourceDictionary[property.Value] is ControlTemplate controlTemplate)
					{
						button.Template = controlTemplate;
						button.SetBinding(Button.IsEnabledProperty, new Binding() { Path = new PropertyPath(property.Key) });
					}
					button.Click += (s, e) =>
					{
						MessageBox.Show(property.Key + button.IsEnabled.ToString());
					};
					dockPanel.Children.Add(button);
				}
				StatusBarItem statusBarItem = new StatusBarItem() { Content = dockPanel };
				DockPanel.SetDock(statusBarItem, Dock.Right);
				statusBar.Items.Add(statusBarItem);
				statusBar.Items.Add(new StatusBarItem());
			}

			StageConnectionText.DataContext = SoftwareConfig.HardwareSetting;
			CameraConnectionText.DataContext = SoftwareConfig.HardwareSetting;
			LightConnectionText.DataContext = SoftwareConfig.HardwareSetting;
            CameraCalibrationButton.DataContext = SoftwareConfig.HardwareSetting;
            StageCalibrationButton.DataContext = SoftwareConfig.HardwareSetting;
            LightCalibrationButton.DataContext = SoftwareConfig.HardwareSetting;

            foreach (var item in HotKeyHelper.HotKeysList)
			{

				TextBlock textBlock = new TextBlock() { Text = item.Value.Name };
				TextBlock textBlock1 = new TextBlock() { Text = item.Value.Hotkey.ToString() };

				DockPanel dockPanel = new DockPanel();

				dockPanel.Children.Add(textBlock);
				dockPanel.Children.Add(textBlock1);
				UniformGrifHotKey.Children.Add(dockPanel);
			}
		}




	}
}

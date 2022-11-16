﻿using XSolution;
using System.Windows;
using ThemeManager.Controls;
using Global.Common.Extensions;
using System.Collections.Generic;
using Lambda;
using Microsoft.Win32;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Documents;
using System;
using System.Linq;
using System.Windows.Shell;
using System.IO;
using Global.Common;

namespace Solution
{

    /// <summary>
    /// GrifExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsWindow : BaseWindow
    {
        public SeriesProjectManager SeriesProject;

        public ProjectExportAs ProjectExportAs;
        public SeriesExportAsWindow(SeriesProjectManager seriesProjectManager)
        {
            this.SeriesProject = new SeriesProjectManager(seriesProjectManager.FullName);
            this.SeriesProject.ExportIni();

            ProjectExportAs = new ProjectExportAs() { Kinds = SeriesExportKinds.mp4, FullName = seriesProjectManager.FullName, PhotoTime = false };
            this.DataContext = ProjectExportAs;
            InitializeComponent();


        }
        public SeriesExportAsWindow(SeriesProjectManager seriesProjectManager,SeriesExportKinds seriesExportKinds)
        {
            this.SeriesProject = new SeriesProjectManager(seriesProjectManager.FullName);
            this.SeriesProject.ExportIni();

            ProjectExportAs = new ProjectExportAs() { Kinds = seriesExportKinds, FullName = seriesProjectManager.FullName, PhotoTime = false };
            this.DataContext = ProjectExportAs;
            InitializeComponent();
            DockKind.Visibility = Visibility.Collapsed;
            WindowTitleText.Text += Enum.GetName(seriesExportKinds);
        }
        bool IsIni = false;
        private void BaseWindow_Initialized(object sender, EventArgs e)
        {
            this.DataContext = ProjectExportAs;

            SeriesExportKinds kinds;
            switch (ProjectExportAs.Kinds)
            {
                case SeriesExportKinds.png:
                    kinds = SeriesExportKinds.rar;
                    break;
                case SeriesExportKinds.jpeg:
                    kinds = SeriesExportKinds.rar;
                    break;
                case SeriesExportKinds.tiff:
                    kinds = SeriesExportKinds.rar;
                    break;
                case SeriesExportKinds.bmp:
                    kinds = SeriesExportKinds.rar;
                    break;
                default:
                    kinds = ProjectExportAs.Kinds;
                    break;
            }

            ProjectExportAs.ExportFullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + SeriesProject.Name + "." + kinds;

            combobox.ItemsSource = Enum.GetValues(typeof(SeriesExportKinds)).Cast<SeriesExportKinds>();
            for (int i = 0; i < combobox.Items.Count; i++)
            {
                if ((SeriesExportKinds)combobox.Items[i] == ProjectExportAs.Kinds)
                {
                    IsIni = true;
                    combobox.SelectedIndex = i;
                    break;
                }
            }

            foreach (var item in SeriesProject.Meta.DicPoints.Keys)
            {
                CheckBox checkBox = new CheckBox() { Content = $"{item.X}  {item.Y}" };
                checkBox.Click += (s, e) =>
                {
                    foreach (var item in SeriesProject.Meta.DicPoints[item])
                    {
                        if (checkBox.IsChecked ==true)
                        {
                            SeriesProject.ExportChildren.Add(item);
                        }
                        else
                        {
                            SeriesProject.ExportChildren.Remove(item);
                        }
                    }


                };
                StackPanelPoint.Children.Add(checkBox); 
            }

        }


        private void OK_Click(object sender, RoutedEventArgs e)
        {

            if (File.Exists(ProjectExportAs.ExportFullName))
            {
                if (MessageBox1.Show("此目标已经存在该文件，是否覆盖", "Grid", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                {
                    return;
                }
            }

            List<string> Mode = new();

            ProjectExportAs.Mode = Mode;
            if (ProjectExportAs.ExportAllImages)
            {
                SeriesProject.GetAllExportGrif(SeriesProject);
            }
            
            foreach (var item in SeriesProject.ExportChildren)
            {
                if (item is GrifFile grifFile)
                    ProjectExportAs.FrameList.Add(grifFile.FullName);
            }


            LambdaControl.Trigger("SeriesProjectExportAs", this, ProjectExportAs.ToJson());
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox.SelectedIndex <0 || !IsIni)
                return;
            if (combobox.Items[combobox.SelectedIndex] is SeriesExportKinds seriesExportKindsss)
            {
                ProjectExportAs.Kinds = seriesExportKindsss;


                SeriesExportKinds kinds;
                switch (ProjectExportAs.Kinds)
                {
                    case SeriesExportKinds.png:
                        kinds = SeriesExportKinds.rar;
                        break;
                    case SeriesExportKinds.jpeg:
                        kinds = SeriesExportKinds.rar;
                        break;
                    case SeriesExportKinds.tiff:
                        kinds = SeriesExportKinds.rar;
                        break;
                    case SeriesExportKinds.bmp:
                        kinds = SeriesExportKinds.rar;
                        break;
                    default:
                        kinds = ProjectExportAs.Kinds;
                        break;
                }

                ProjectExportAs.ExportFullName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + SeriesProject.Name + "." + kinds;

            }

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Filter;
            switch (ProjectExportAs.Kinds)
            {
                case SeriesExportKinds.mp4:
                    Filter = "(*.mp4) | *.mp4";
                    break;
                case SeriesExportKinds.avi:
                    Filter = "(*.avi) | *.avi";
                    break;
                case SeriesExportKinds.png:
                    Filter = "(*.rar) | *.rar";
                    break;
                case SeriesExportKinds.jpeg:
                    Filter = "(*.rar) | *.rar";
                    break;
                case SeriesExportKinds.tiff:
                    Filter = "(*.rar) | *.rar";
                    break;
                case SeriesExportKinds.bmp:
                    Filter = "(*.rar) | *.rar";
                    break;
                default:
                    return;
            }
            SaveFileDialog dialog = new()
            {
                Title = "另存为",
                RestoreDirectory = true,
                Filter = Filter,
            };
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                ProjectExportAs.ExportFullName = dialog.FileName;
            };
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            SeriesExportAsSettingWindow baseWindow = new SeriesExportAsSettingWindow(SeriesProject);
            baseWindow.ShowDialog();
        }

    }
}

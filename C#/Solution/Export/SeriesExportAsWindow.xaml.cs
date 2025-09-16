using Global.Common.MVVM;
using Lambda;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using XSolution;

namespace Solution
{

    /// <summary>
    /// GrifExportAsWindow1.xaml 的交互逻辑
    /// </summary>
    public partial class SeriesExportAsWindow : Window
    {
        public SeriesProjectManager SeriesProject;

        public ProjectExportAs ProjectExportAs;
        public SeriesExportAsWindow(SeriesProjectManager seriesProjectManager)
        {
            this.SeriesProject = new SeriesProjectManager(seriesProjectManager.FullName);
            Task.Run(SeriesProject.ExportIni);
            ;
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


        }


        private void OK_Click(object sender, RoutedEventArgs e)
        {

            if (File.Exists(ProjectExportAs.ExportFullName))
            {
                if (MessageBox.Show("\n\r此目标已经存在该文件，是否覆盖\n\r", "Grid", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
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

            WaitGrid.Visibility = Visibility.Visible;
            this.Cursor = Cursors.Wait;
            Thread thread = new Thread(Load);
            thread.Start();
            Thread thread1 = new(()=> Load1((int)ProjectExportAs.FrameList.Count/4));
            thread1.Start();
        }

        public void Load1(int millisecondsTimeout)
        {
            for (int i = 0; i < 99; i++)
            {
                Thread.Sleep(millisecondsTimeout);
                Dispatcher.BeginInvoke(new Action(() => ProgressBar.Value += 1));
            }
             Dispatcher.BeginInvoke(new Action(() => ProgressBarText.Text = "正在压缩"));
        }


        public async void Load()
        {
            LambdaControl.Trigger("SeriesProjectExportAs", this, ProjectExportAs.ToJson());
            await Dispatcher.BeginInvoke(new Action(() => ProgressBar.Value = 100));
            await Task.Delay(100);
            _ = Dispatcher.BeginInvoke(new Action(() => this.Close()));
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

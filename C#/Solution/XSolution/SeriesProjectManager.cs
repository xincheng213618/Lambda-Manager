using Global.Common;
using Microsoft.Win32;
using XSolution;
using Solution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tool;
using System.Collections.ObjectModel;
using System.Windows.Media.Animation;
using XSolution.SeriesProject;

namespace XSolution
{

    public class SeriesProjectManager : ProjectFolder
    {
        public static bool IsThis(string FullName)
        {
            if (!Directory.Exists(FullName))
                return false;
            DirectoryInfo info = new DirectoryInfo(FullName);
            return IsThis(info);
        }

        public static bool IsThis(DirectoryInfo info)
        {
            foreach (var directoryInfo in info.GetDirectories())
            {
                string[] value = directoryInfo.Name.Split("_");
                if (value.Length == 2 && int.TryParse(value[0], out int a) && int.TryParse(value[1], out int b))
                    return true;
            }
            return false;
        }


        /// <summary>
        /// 系列的统计数据
        /// </summary>
        public SeriesProjectMeta Meta;

        public string FolderSize
        {
            get { return _FolderSize; }
            set { _FolderSize = value; NotifyPropertyChanged(); }
        }
        private string _FolderSize;


        private async void CalculSize()
        {
            //加延迟是为了显示效果更好。
            await Task.Delay(1000);
            FolderSize = MemorySize.MemorySizeText(MemorySize.GetDirectoryLength(FullName, "derives"));
        }

        public ObservableCollection<BaseObject> ExportChildren { get; set; }

        public ObservableCollection<GrifFile> AllGrifChildren { get; set; }

        /// <summary>
        /// 导出为
        /// </summary>
        public RelayCommand PoejectExportAs { get; set; }

        public RelayCommand ExportAsMp4Command { get; set; }
        public RelayCommand ExportAsAVICommand { get; set; }

        public RelayCommand ExportAsTiffCommand { get; set; }
        public RelayCommand ExportAsJPEGCommand { get; set; }

        public RelayCommand ExportAsPNGCommand { get; set; }
        public RelayCommand ExportAsBMPCommand { get; set; }


        public SeriesProjectManager(string SeriesFolderPath) : base(SeriesFolderPath)
        {
            CanReName = false;
            Visibility = Visibility.Visible;

            PoejectExportAs = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });

            ExportAsMp4Command = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this,SeriesExportKinds.mp4);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });
            ExportAsAVICommand = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this, SeriesExportKinds.avi);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });
            ExportAsTiffCommand = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this,SeriesExportKinds.tiff);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });
            ExportAsJPEGCommand = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this, SeriesExportKinds.jpeg);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });
            ExportAsPNGCommand = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this, SeriesExportKinds.png);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });
            ExportAsBMPCommand = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this, SeriesExportKinds.bmp);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });


            watcher = new FileSystemWatcher(SeriesFolderPath)
            {
                IncludeSubdirectories = false,
            };
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Changed += Watcher_Changed;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
            Task.Run(CalculSize);
        }
        public void ExportIni()
        {
            foreach (var item in new DirectoryInfo(FullName).GetDirectories())
            {
                BaseObject baseObject = FromDirectories(new ProjectFolder(item.FullName), item);
                AddChild(baseObject);
            }
            ExportChildren = new ObservableCollection<BaseObject>();
            AllGrifChildren = new ObservableCollection<GrifFile>();

            Meta = new SeriesProjectMeta();

            foreach (var item in VisualChildren)
            {
                string FullName = item.Name;
                var point = FullName.Split('_');
                int X = int.Parse(point[0]);
                int Y = int.Parse(point[1]);
                Point point1 = new Point(X, Y); 
                if (!Meta.DicPoints.ContainsKey(point1))
                    Meta.DicPoints.Add(point1, new List<GrifFile>());

                foreach (var zitem in item.VisualChildren)
                {
                    int Zstep = int.Parse(zitem.Name);
                    if (!Meta.DicZ.ContainsKey(Zstep))
                        Meta.DicZ.Add(Zstep, new List<GrifFile>());

                    foreach (var image in zitem.VisualChildren)
                    {
                        if (image is GrifFile grifFile)
                        {
                            AllGrifChildren.Add(grifFile);
                            Meta.DicPoints[point1].Add(grifFile);
                            Meta.DicZ[Zstep].Add(grifFile);

                            if (!Meta.DicOM.ContainsKey(grifFile.OperatingMode))
                                Meta.DicOM.Add(grifFile.OperatingMode, new List<GrifFile>());
                            Meta.DicOM[grifFile.OperatingMode].Add(grifFile);   
                        }
                    }
                }
            }
        }

        public static BaseObject FromDirectories(BaseObject baseObject, DirectoryInfo root)
        {
            foreach (var directoryInfo in root.GetDirectories())
            {
                if (directoryInfo.Name == "Image")
                {
                    foreach (var direc in directoryInfo.GetFiles())
                    {
                        baseObject.AddChild(SolutionGlobal.GetInstance().GetProjectFile(direc.FullName));
                    }
                }
                else
                {
                    ProjectFolder projectFolder = new ProjectFolder(directoryInfo.FullName);
                    baseObject.AddChild(FromDirectories(projectFolder, directoryInfo));
                }
            }
            foreach (var directoryInfo in root.GetFiles())
            {
                baseObject.AddChild(SolutionGlobal.GetInstance().GetProjectFile(directoryInfo.FullName));
            }
            return baseObject;
        }


        public void GetAllExportGrif(BaseObject baseObject)
        {
            foreach (var item in baseObject.VisualChildren)
            {
                if (item is ProjectFolder)
                    GetAllExportGrif(item);
                if (item is GrifFile grifFile)
                    ExportChildren.Add(grifFile);
            }
        }



        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Task.Run(CalculSize);
        }

        public void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (File.Exists(e.FullPath) || Directory.Exists(e.FullPath))
            {
                var baseObject = VisualChildren.ToList().Find(t => t.FullName == e.OldFullPath);
                if (baseObject != null)
                {
                    baseObject.FullName = e.FullPath;
                }
                var baseObject1 = VisualChildrenHidden.ToList().Find(t => t.FullName == e.OldFullPath);
                if (baseObject1 != null)
                {
                    baseObject1.FullName = e.FullPath;
                }

            }
        }

        public void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!(File.Exists(e.FullPath) || Directory.Exists(e.FullPath)))
            {
                var projectFile = VisualChildren.ToList().Find(t => t.FullName == e.FullPath);
                if (projectFile != null)
                {
                    Application.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        RemoveChild(projectFile);
                    }));
                }
            }

        }

        public void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                if (File.Exists(e.FullPath))
                {
                    BaseObject baseObject = SolutionGlobal.GetInstance().GetProjectFile(e.FullPath);
                    baseObject.Visibility = Visibility.Hidden;  
                    AddChild(baseObject);
                }
                else if (Directory.Exists(e.FullPath))
                {
                    AddChild(new ProjectFolder(e.FullPath) { Visibility = Visibility.Hidden });
                }
            });
        }

        public override void AddChildDialog(object obj)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DerivativeSeriesFile derivativeSeriesFile = new DerivativeSeriesFile(dialog.SelectedPath);
                AddChild(derivativeSeriesFile);

            }
        }


        public override void AddChild(BaseObject baseObject)
        {
            base.AddChild(baseObject);
        }


        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null) return;

            base.RemoveChild(baseObject);
            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                VisualChildren.Remove(baseObject);
                baseObject.Delete();
            }
        }


        public override void Delete()
        {
            base.Delete();

            try
            {
                if (Directory.Exists(FullName))
                    Directory.Delete(FullName, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string tempname;
        public override bool IsEditMode
        {
            get { return _IsEditMode; }
            set
            {
                _IsEditMode = value;
                if (!_IsEditMode)
                {
                    string oldpath = FullName;
                    string newpath = oldpath.Substring(0, oldpath.LastIndexOf("\\") + 1) + Name;
                    if (newpath != FullName)
                    {
                        try
                        {
                            Directory.Move(oldpath, newpath);
                            FullName = newpath;
                            tempname = Name;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("文件名冲突" + ex.Message);
                            Name = tempname;
                            _IsEditMode = true;
                        }
                    }
                }
                else
                {
                    tempname = Name;
                }
                NotifyPropertyChanged();
            }
        }

    }


}

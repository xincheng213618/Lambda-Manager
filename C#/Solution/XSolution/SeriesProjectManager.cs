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
using Global.SettingUp.Mode.Hardware;
using Lambda;

namespace XSolution
{

    public class SeriesProjectExport
    {

        public string Name { get; set; }

        

    }



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

        public RelayCommand OpenCommand { get; set; }


        public SeriesProjectManager(string SeriesFolderPath) : base(SeriesFolderPath)
        {
            CanReName = false;
            Visibility = Visibility.Visible;

            PoejectExportAs = new RelayCommand(a=> new SeriesExportAsWindow(this).ShowDialog(), a => CanExport);
            ExportAsMp4Command = new RelayCommand(a => new SeriesExportAsWindow(this, SeriesExportKinds.mp4).ShowDialog(), a => CanExport);
            ExportAsAVICommand = new RelayCommand(a => new SeriesExportAsWindow(this, SeriesExportKinds.avi).ShowDialog(), a => CanExport);
            ExportAsTiffCommand = new RelayCommand(a => new SeriesExportAsWindow(this, SeriesExportKinds.tiff).ShowDialog(), a => CanExport);
            ExportAsJPEGCommand = new RelayCommand(a => new SeriesExportAsWindow(this, SeriesExportKinds.jpeg).ShowDialog(), a => CanExport);
            ExportAsPNGCommand = new RelayCommand(a => new SeriesExportAsWindow(this, SeriesExportKinds.png).ShowDialog(), a => CanExport);
            ExportAsBMPCommand = new RelayCommand(a => new SeriesExportAsWindow(this, SeriesExportKinds.bmp).ShowDialog(), a => CanExport);
            OpenCommand = new RelayCommand(a => Open());
            CanExport = true;

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

        public override async void Open() {

            LambdaControl.Trigger("CLOSE_OPEN_SERIAL", this, new Dictionary<string, object>() { });
            await Task.Delay(300);
            LambdaControl.Trigger("seriesProjectManager", this, FullName);
            LambdaControl.Trigger("PREVIEW_CLOSE", this, new Dictionary<string, object>() { });
        }

        public bool CanExport { get; set; }

        public bool ExportIni()
        {
            if (DirectoryInfo == null) return false;
            try {
                ExportChildren = new ObservableCollection<BaseObject>();
                AllGrifChildren = new ObservableCollection<GrifFile>();

                Meta = new SeriesProjectMeta();

                foreach (var Dpoint in DirectoryInfo.GetDirectories()) {
                    ProjectFolder projectFolderDpoint = new ProjectFolder(Dpoint.FullName);

                    string FullName = Dpoint.Name;
                    var point = FullName.Split('_');
                    int X = int.Parse(point[0]);
                    int Y = int.Parse(point[1]);
                    Point point1 = new Point(X, Y);
                    if (!Meta.DicPoints.ContainsKey(point1))
                        Meta.DicPoints.Add(point1, new List<GrifFile>());

                    foreach (var Dz in Dpoint.GetDirectories()) {
                        ProjectFolder projectFolderDz = new ProjectFolder(Dz.FullName);
                        Dictionary<GrifFileOperatingMode, ProjectFolder> DicOMs = new Dictionary<GrifFileOperatingMode, ProjectFolder>();

                        int Zstep = int.Parse(Dz.Name);
                        if (!Meta.DicZ.ContainsKey(Zstep))
                            Meta.DicZ.Add(Zstep, new List<GrifFile>());

                        foreach (var image in Dz.GetDirectories()) {
                            foreach (var Dmode in image.GetFiles()) {
                                GrifFile grifFile = new GrifFile(Dmode.FullName);
                                if (!DicOMs.ContainsKey(grifFile.OperatingMode))
                                    DicOMs.Add(grifFile.OperatingMode, new ProjectFolder("Virtual") { Name = grifFile.OperatingModeString,CanReName =false });
                                DicOMs[grifFile.OperatingMode].AddChild(grifFile);

                                AllGrifChildren.Add(grifFile);
                                Meta.DicPoints[point1].Add(grifFile);
                                Meta.DicZ[Zstep].Add(grifFile);

                                if (!Meta.DicOM.ContainsKey(grifFile.OperatingMode))
                                    Meta.DicOM.Add(grifFile.OperatingMode, new List<GrifFile>());
                                Meta.DicOM[grifFile.OperatingMode].Add(grifFile);
                            }

                        }
                        foreach (var Dmode1 in DicOMs)
                            projectFolderDz.AddChild(Dmode1.Value);
                        projectFolderDpoint.AddChild(projectFolderDz);
                    }
                    AddChild(projectFolderDpoint);
                }
                return true;
            }
            catch {
                return false;
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

        public override bool IsEditMode
        {
            get { return _IsEditMode; }
            set
            {
                _IsEditMode = value;
                if (!_IsEditMode)
                {
                    string newpath = FullName[..(FullName.LastIndexOf("\\") + 1)] + Name;
                    if (newpath != FullName)
                    {
                        string oldpath = FullName;
                        try {
                            Directory.Move(oldpath, newpath);
                            FullName = newpath;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("文件名冲突" + ex.Message);
                            Name = DirectoryInfo.Name;
                            _IsEditMode = true;
                        }
                    }
                }
                NotifyPropertyChanged();
            }
        }

    }


}

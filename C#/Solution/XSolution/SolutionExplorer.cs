using Global.Common;
using Global.SettingUp;
using HandyControl.Tools.Extension;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace XSolution
{
    public class SolutionConfig {
        public FileInfo FileInfo { get; set; }
        public DirectoryInfo RootDirectoryInfo { get; set; }

        public bool IsExists => FileInfo.Exists;
        public SolutionConfig(string FullPath){
            FileInfo = new FileInfo(FullPath);
            if (FileInfo.Exists) {
                RootDirectoryInfo = new DirectoryInfo(Path.GetDirectoryName(FileInfo.FullName));
            }
        }
    }

    public class SolutionExplorer : BaseObject
    {
        public SolutionConfig Config { get; set; }
        public FileInfo ConfigFileInfo => Config.FileInfo;
        public DirectoryInfo DirectoryInfo => Config.RootDirectoryInfo;
        public bool IsExists => Config.IsExists;

        public RelayCommand AddNewProject { get; set; }
        public RelayCommand OpenExplorer { get; set; }
        public RelayCommand AddExistingProject { get; set; }

        /// <summary>
        /// 打开日志
        /// </summary>
        public RelayCommand OpenLog { get; set; }

        /// <summary>
        /// 打开日志文件夹
        /// </summary>
        public RelayCommand OpenLogExplorer { get; set; }

        public ContextMenu ContextMenu { get; set; }


        public FileSystemWatcher watcher;
        public FileSystemWatcher watcher1;
        public FileSystemWatcher watcher2;


        public SolutionExplorer(string FullPath):base(FullPath)
        {
            Config = new SolutionConfig(FullPath);



            foreach (var item in DirectoryInfo.GetFiles())
            {
                AddChild(SolutionGlobal.GetInstance().GetProjectFile(item.FullName));
            }

            foreach (var dic in DirectoryInfo.GetDirectories())
            {
                if (SeriesProjectManager.IsThis(dic))
                {
                    AddChild(new SeriesProjectManager(dic.FullName));
                    continue;
                }

                else if (dic.Name == "Image")
                {
                    foreach (var item in dic.GetFiles())
                    {
                        AddChild(SolutionGlobal.GetInstance().GetProjectFile(item.FullName));
                    }
                    watcher1 = new FileSystemWatcher(dic.FullName)
                    {
                        IncludeSubdirectories = false
                    };
                    watcher1.Deleted += Watcher_Deleted;
                    watcher1.Created += Watcher_Created;
                    watcher1.Renamed += Watcher_Renamed;
                    watcher1.EnableRaisingEvents = true;
                }
            }


            watcher = new FileSystemWatcher(DirectoryInfo.FullName)
            {
                IncludeSubdirectories = false
            };

            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
           
            AddNewProject = new RelayCommand(OnAddNewProject);
            OpenExplorer = new RelayCommand(a =>System.Diagnostics.Process.Start("explorer.exe", DirectoryInfo.FullName));
            OpenLog = new RelayCommand(a => System.Diagnostics.Process.Start("explorer.exe", $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\LambdaManager\\lambda.log"));
            OpenLogExplorer = new RelayCommand(a => System.Diagnostics.Process.Start("explorer.exe", $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\LambdaManager\\LambdaManager"));

            ContextMenu = new ContextMenu();
            ContextMenu.Items.Add(new MenuItem() { Header = "重命名(_M)", Command = Commands.ReName, CommandParameter = this });
            ContextMenu.Items.Add(new Separator()); 
            //ContextMenu.Items.Add(new MenuItem() { Header = "取消隐藏", Command = VisibilityUnHidden, CommandParameter = this });
            //ContextMenu.Items.Add(new Separator());
            ContextMenu.Items.Add(new MenuItem() { Header = "在文件资源管理器中打开(_X)", Command = OpenExplorer, CommandParameter = this });
            ContextMenu.Items.Add(new MenuItem() { Header = "打开日志文件夹(_D)", Command = OpenLogExplorer, CommandParameter = this });
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
            if (File.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    AddChild(SolutionGlobal.GetInstance().GetProjectFile(e.FullPath));
                }));
            }
            else if (Directory.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    AddChild(new SeriesProjectManager(e.FullPath));
                }));
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
                    string newpath = string.Concat(FullName.AsSpan(0, FullName.LastIndexOf("\\") + 1), Name, ConfigFileInfo.Extension);
                    if (newpath != FullName)
                    {
                        string oldpath = FullName;
                        try {
                            File.Move(oldpath, newpath);
                            FullName = newpath;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("文件名冲突:" + ex.Message);
                             FullName = oldpath;
                            _IsEditMode = true;
                        }
                    }
                }
                NotifyPropertyChanged();
            }
        }


        private void OnAddNewProject(object value)
        {

        }



        public override void AddChild(BaseObject baseObject)
        {
            base.AddChild(baseObject);
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null) return;

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                VisualChildren.Remove(baseObject);
                baseObject.Delete();
            }
        }

    }
}

using Global.Common.Extensions;
using Global.Common.NativeMethods;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace XSolution
{
    public class ProjectFolder : BaseObject
    {
        public virtual bool IsFolder { get; set; } = true;

        public ImageSource Icon { get; set; }

        public SolutionExplorer SolutionExplorer   { get => this.GetAncestor<SolutionExplorer>();   }

        public ProjectFolder()
        {
        }

        public DirectoryInfo DirectoryInfo { get; set; }

        public FileSystemWatcher watcher;

        public ProjectFolder(string FolderPath) :base(FolderPath)
        {
            VisualChildren = new ObservableCollection<BaseObject>();
            Icon = FileIcon.GetDirectoryIcon().ToImageSource();

            if (Directory.Exists(FolderPath))
            {
                DirectoryInfo = new DirectoryInfo(FolderPath);
                VisualChildren.CollectionChanged += (s, e) =>
                {
                    if (e.Action == NotifyCollectionChangedAction.Remove && VisualChildren.Count == 0)
                    {
                        Visibility = Visibility.Hidden;
                    }
                    else if (e.Action == NotifyCollectionChangedAction.Add)
                    {
                        Visibility = Visibility.Visible;
                    }
                };

                watcher = new FileSystemWatcher(FolderPath)
                {
                    IncludeSubdirectories = false,
                };
                watcher.Deleted += Watcher_Deleted;
                watcher.Created += Watcher_Created;
                watcher.Changed += Watcher_Changed;
                watcher.Renamed += Watcher_Renamed;
                watcher.EnableRaisingEvents = true;
            }
        }

        public bool? IsCheck { get => _IsCheck; set { _IsCheck = value; NotifyPropertyChanged(); } }
        private bool? _IsCheck = false;

        private string tempname  =string.Empty;

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

        public override void Delete()
        {
            base.Delete();
            this.watcher.Dispose();
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

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (sender == null)
                throw new NotImplementedException();
            if (File.Exists(e.FullPath) || Directory.Exists(e.FullPath))
            {
                var baseObject = VisualChildren.ToList().Find(t => t.FullName == e.FullPath);
                if (baseObject != null && baseObject is ProjectFile projectFile)
                {
                    Task.Run(projectFile.CalculSize);
                }
            }

        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
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

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
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

                var projectFile1 = SolutionExplorer.VisualChildren.ToList().Find(t => t.FullName == e.FullPath);
                if (projectFile1 != null)
                {
                    Application.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        SolutionExplorer.RemoveChild(projectFile1);
                    }));
                }
            }

        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    AddChild(SolutionGlobal.GetInstance().GetProjectFile(e.FullPath));
                });
            }
            else if (Directory.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    AddChild(new ProjectFolder(e.FullPath));
                });
            }
        }
        

        public string Description { get; set; }


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
                baseObject.Delete();
            }

            VisualChildren.Remove(baseObject);
            base.RemoveChild(baseObject);

        }
        public override int CompareTo(object obj)
        {
            if (obj == null) return -1;
            if (obj == this) return 0;
            if (obj is ProjectFolder projectFolder)
            {
                return Global.Common.NativeMethods.Shlwapi.StrCmpLogicalW(Name, projectFolder.Name);
            }
            if (obj is BaseObject baseObject)
            {
                return -1;
            }
            return 0;
        }


    }
}

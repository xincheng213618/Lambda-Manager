using Global.Common.Extensions;
using Global.Common.Helper;
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

        private SolutionExplorer solutionExplorer = null;

        public ImageSource Icon { get; set; }

        public SolutionExplorer SolutionExplorer
        { 
            get 
            {
                return solutionExplorer ??= (SolutionExplorer)GetAncestor(typeof(SolutionExplorer));
            } 
            protected set { }
        }

        public FileSystemWatcher watcher;

        public ProjectFolder(string FolderPath) :base(FolderPath)
        {
            VisualChildren = new ObservableCollection<BaseObject>();
            if (IsFolder)
            {
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
            }
            Icon = FileIcon.GetDirectoryIcon().ToImageSource();
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

        private bool? isCheck = false;
        public bool? IsCheck
        {
            get { return isCheck; }
            set { isCheck = value; NotifyPropertyChanged(); }
        }

        private string tempname;

        public override bool IsEditMode
        {
            get { return isEditMode; }
            set
            {
                isEditMode = value;
                if (!isEditMode)
                {
                    string oldpath = FullName;
                    string newpath = oldpath.Substring(0, oldpath.LastIndexOf("\\") + 1) + name;
                    if (newpath != FullName)
                    {
                        try
                        {
                            Directory.Move(oldpath, newpath);
                            FullName = newpath;
                            tempname = name;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("文件名冲突" + ex.Message);
                            Name = tempname;
                            isEditMode = true;
                        }
                    }
                }
                else
                {
                    tempname = name;
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
                return Name.CompareTo(projectFolder.Name);
            }
            if (obj is BaseObject baseObject)
            {
                return -1;
            }
            return 0;
        }

    }
}

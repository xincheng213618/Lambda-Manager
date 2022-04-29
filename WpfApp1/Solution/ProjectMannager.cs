using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace NLGSolution
{
    public class ProjectMannager : BaseObject
    {
        FileSystemWatcher watcher;

        public ProjectMannager(string ProjectPath):base(ProjectPath, Type.Directory)
        {
            watcher = new FileSystemWatcher(ProjectPath);
            watcher.IncludeSubdirectories = false;
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
        }
        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            if (File.Exists(e.FullPath) || Directory.Exists(e.FullPath))
            {
                var baseObject = Children.ToList().Find(t => t.FullPath == e.OldFullPath);
                if (baseObject != null)
                {
                    baseObject.FullPath = e.FullPath;
                }
            }
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!(File.Exists(e.FullPath) || Directory.Exists(e.FullPath)))
            {
                var projectFile = Children.ToList().Find(t => t.FullPath == e.FullPath);
                if (projectFile != null)
                {
                    Application.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        RemoveChild(projectFile);
                    }));
                }
            }
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    AddChild(new ProjectFile(e.FullPath));
                }));
            }
            else if (Directory.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    AddChild(new ProjectFolder(e.FullPath));
                }));
            }
        }


        public Guid ConfirmationID { get; set; }

        public ObservableCollection<ProjectFolder> ProjectFolders { get; set; } = new ObservableCollection<ProjectFolder>();
        public ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();
        public virtual void DoubleClick(MouseButtonEventArgs e)
        {
            MessageBox.Show("22222222222222222");
        }


        public ObservableCollection<BaseObject> Children { get; set; } = new ObservableCollection<BaseObject>();



        public override void AddChild(BaseObject baseObject)
        {
            baseObject.Parent = this;
            Children.SortedAdd(baseObject);
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null)
                return;

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                Children.Remove(baseObject);

                baseObject.Delete();
                //NotifyPropertyChanged("Children");
            }
        }
    }
}

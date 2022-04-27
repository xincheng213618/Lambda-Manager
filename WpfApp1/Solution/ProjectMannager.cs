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
            if (File.Exists(e.FullPath))
            {
                var projectFile = ProjectFiles.ToList().Find(t => t.FullPath == e.OldFullPath);
                if (projectFile != null)
                {
                    projectFile.FullPath = e.FullPath;
                }
            }
            if (Directory.Exists(e.FullPath))
            {
                var projectFolder = ProjectFolders.ToList().Find(t => t.FullPath == e.OldFullPath);
                if (projectFolder != null)
                {
                    projectFolder.FullPath = e.FullPath;
                }
            }
        }

        private void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            if (!File.Exists(e.FullPath))
            {
                var projectFile = ProjectFiles.ToList().Find(t => t.FullPath == e.FullPath);
                if (projectFile != null)
                {
                    ProjectFiles.Remove(projectFile);
                    NotifyPropertyChanged("Children");
                }
            }
            if (!Directory.Exists(e.FullPath))
            {
                var projectFolder = ProjectFolders.ToList().Find(t => t.FullPath == e.FullPath);
                if (projectFolder != null)
                {
                    ProjectFolders.Remove(projectFolder);
                    NotifyPropertyChanged("Children");
                }
            }
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(e.FullPath))
            {
                ProjectFile projectFile = new ProjectFile(e.FullPath);
                AddChild(projectFile);
            }
            else if (Directory.Exists(e.FullPath))
            {
                ProjectFolder projectFolder = new ProjectFolder(e.FullPath)
                {
                    Name = e.Name,
                };
                AddChild(projectFolder);
            }

        }


        public Guid ConfirmationID { get; set; }

        public ObservableCollection<ProjectFolder> ProjectFolders { get; set; } = new ObservableCollection<ProjectFolder>();
        public ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();
        public virtual void DoubleClick(MouseButtonEventArgs e)
        {
            MessageBox.Show("22222222222222222");
        }



        public ObservableCollection<object> Children
        {
            get
            {
                ObservableCollection<object> childNodes = new ObservableCollection<object>();
                foreach (var product in ProjectFolders)
                    childNodes.Add(product);
                foreach (var projectFile in ProjectFiles)
                    childNodes.Add(projectFile);
                return childNodes;
            }
        }


        public override void AddChild(BaseObject baseObject)
        {
            baseObject.Parent = this;

            if (baseObject is ProjectFolder folder)
            {
                ProjectFolders.Add(folder);
            }
            else if (baseObject is ProjectFile file)
            {
                ProjectFiles.Add(file);
            }
            NotifyPropertyChanged("Children");
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null)
                return;

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;

                //this.Children.Remove(baseObject);

                baseObject.Delete();
                if (baseObject is ProjectFolder folder)
                    ProjectFolders.Remove(folder);

                else if (baseObject is ProjectFile file)
                    ProjectFiles.Remove(file);
                NotifyPropertyChanged("Children");
            }
        }
    }
}

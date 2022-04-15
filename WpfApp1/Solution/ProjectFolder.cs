using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NLGSolution
{
    public class ProjectFolder : BaseObject
    {
        public ProjectFolder()
        {
            if (FilePath != null)
            {
                FileSystemWatcher watcher = new FileSystemWatcher(FilePath);
                watcher.IncludeSubdirectories = true;
                watcher.Deleted += Watcher_Deleted;
                watcher.Created += Watcher_Created;
                watcher.Renamed += Watcher_Renamed;
                watcher.EnableRaisingEvents = true;
            }
        }

        private void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show(e.FullPath);
        }

        private static void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.FullPath);
        }

        private static void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(e.FullPath);
        }

        public string Description { get; set; }

        public ObservableCollection<ProjectFolder> ProjectFolders { get; set; } = new ObservableCollection<ProjectFolder>();

        public ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();

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


        private void FileWatch()
        {

        }

        public void AddChild(ProjectFolder projectFolder)
        {
            ProjectFolders.Add(projectFolder);
            NotifyPropertyChanged("Children");
        }
        public void AddChild(ProjectFile projectFile)
        {
            ProjectFiles.Add(projectFile);
            NotifyPropertyChanged("Children");
        }

    }
}

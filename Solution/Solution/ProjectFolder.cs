using System;
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

        public FileSystemWatcher watcher;
        public ObservableCollection<BaseObject> Children { get; set; }

        public ProjectFolder(string FolderPath) :base(FolderPath)
        {
            Children = new ObservableCollection<BaseObject>();

            watcher = new FileSystemWatcher(FolderPath)
            {
                IncludeSubdirectories = false
            };
            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
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
                    string oldpath = FullPath;
                    string newpath = oldpath.Substring(0, oldpath.LastIndexOf("\\") + 1) + name;
                    if (newpath != FullPath)
                    {
                        try
                        {
                            Directory.Move(oldpath, newpath);
                            FullPath = newpath;
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
                if (Directory.Exists(FullPath))
                    Directory.Delete(FullPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Watcher_Renamed(object sender, RenamedEventArgs e)
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

        public void Watcher_Deleted(object sender, FileSystemEventArgs e)
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

        public void Watcher_Created(object sender, FileSystemEventArgs e)
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
        

        public string Description { get; set; }


        public override void AddChild(BaseObject baseObject)
        {
            base.AddChild(baseObject);
            baseObject.Parent = this;
            Children.SortedAdd(baseObject);
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            base.RemoveChild(baseObject);   
            if (baseObject == null)
                return;

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                Children.Remove(baseObject);
                baseObject.Delete();
            }
        }

    }
}

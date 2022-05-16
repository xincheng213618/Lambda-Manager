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
    public class SolutionExplorer : BaseObject
    {
        public FileSystemWatcher watcher;


        public SolutionExplorer(string FullPath):base(FullPath)
        {
            SolutionGuid = Guid.NewGuid();
            string rootPath = Path.GetDirectoryName(FullPath);

            watcher = new FileSystemWatcher(rootPath)
            {
                IncludeSubdirectories = false
            };

            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;
            EditCommand = new MyCommand(() =>
            {
                OnDepartmentEdited();
            }, () => { return true; });
            AddNewProject = new MyCommand(() =>
            {
                OnAddNewProject();
            }, () => { return true; });
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
                if (e.Name == "Video" || e.Name == "Image")
                {
                    Application.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        AddChild(new ProjectManager(e.FullPath));
                    }));
                }
                else
                {
                    Application.Current.Dispatcher.Invoke((Action)(() =>
                    {
                        AddChild(new SeriesProjectManager(e.FullPath));

                    }));
                }

            }
        }




        public override bool IsEditMode
        {
            get { return isEditMode; }
            set
            {
                isEditMode = value;
                if (!isEditMode)
                {
                    string oldpath = FullPath;
                    string newpath = string.Concat(oldpath.AsSpan(0, oldpath.LastIndexOf("\\") + 1), Name, Extension);
                    if (newpath != FullPath)
                    {
                        try
                        {
                            File.Move(oldpath, newpath);
                            FullPath = newpath;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("文件名冲突" + ex.Message);
                            isEditMode = true;
                        }
                    }
                }
                NotifyPropertyChanged();
            }
        }


        public string Extension
        {
            get { return Path.GetExtension(FullPath); }
            protected set { }
        }

        private void OnDepartmentEdited()
        {
            MessageBox.Show("22222");
        }

        private void OnAddNewProject()
        {
            //ProjectMannager projectMannager = new ProjectMannager()
            //{
            //    Name = "新建工程2"
            //};

            //AddChild(projectMannager);
        }


        public static MyCommand AddNewProject { get; set; }
        public static MyCommand AddExistingProject { get; set; }
        public MyCommand EditCommand { get; set; }

        public CommandBinding AddExistingProject1;
        private void AddNewProject_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AddNewProject_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //ProjectMannager projectMannager = new ProjectMannager()
            //{
            //    Name = "新建工程2"
            //};

            //AddChild(projectMannager);
        }

        public Guid SolutionGuid { get; set; }

        public string SolutionName { get; set; }
        public string SolutionVersion { get; set; }

        public string SolutionPath { get; set; }

        public SolutionLog SolutionLog { get; set; }
        public SolutionConfig SolutionConfig { get; set; }


        public ObservableCollection<ProjectManager> ProjectMannagers { get; set; } = new ObservableCollection<ProjectManager>();

        public ObservableCollection<SeriesProjectManager> SeriesProjectManagers { get; set; } = new ObservableCollection<SeriesProjectManager>();


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
            }
        }



    }
}

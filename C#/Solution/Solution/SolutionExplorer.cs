﻿using Global.Common;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace XSolution
{
    public class SolutionExplorer : BaseObject
    {
        public FileSystemWatcher watcher;
        public string Rootpath;
        public RelayCommand AddNewProject { get; set; }
        public RelayCommand OpenExplorer { get; set; }
        public RelayCommand AddExistingProject { get; set; }
        public RelayCommand OpenLog { get; set; }


        public SolutionExplorer(string FullPath):base(FullPath)
        {
            SolutionGuid = Guid.NewGuid();
            Rootpath = Path.GetDirectoryName(FullPath);

            watcher = new FileSystemWatcher(Rootpath)
            {
                IncludeSubdirectories = false
            };

            watcher.Deleted += Watcher_Deleted;
            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.EnableRaisingEvents = true;

            AddNewProject = new RelayCommand(OnAddNewProject, (object value) => { return true; });
            OpenExplorer = new RelayCommand(OpenFolder, (object value) => { return true; });
            OpenLog = new RelayCommand(OpenLogFile, (object value) => { return true; });
        }
        private void OpenLogFile(object value)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Chen\AppData\Local\LambdaManager\lambda.log");
        }

        private void OpenFolder(object value)
        {
            System.Diagnostics.Process.Start("explorer.exe", Rootpath);
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
                    string oldpath = FullName;
                    string newpath = string.Concat(oldpath.AsSpan(0, oldpath.LastIndexOf("\\") + 1), Name, Extension);
                    if (newpath != FullName)
                    {
                        try
                        {
                            File.Move(oldpath, newpath);
                            FullName = newpath;
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
            get { return Path.GetExtension(FullName); }
            protected set { }
        }


        private void OnAddNewProject(object value)
        {

        }



        public Guid SolutionGuid { get; set; }

        public string SolutionName { get; set; }

        public string SolutionVersion { get; set; }

        public string SolutionPath { get; set; }


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

﻿using Global.Common;
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

namespace XSolution
{
    public class SeriesProjectManager : BaseObject
    {

        public FileSystemWatcher watcher;

        private string fileSize;
        public string FileSize
        {
            get { return fileSize; }
            set { fileSize = value; NotifyPropertyChanged(); }
        }


        private async void CalculSize()
        {
            //加延迟是为了显示效果更好。
            await Task.Delay(1000);
            FileSize = MemorySize.MemorySizeText(MemorySize.GetDirectoryLength(FullName, "derives"));
        }

        /// <summary>
        /// 导出为
        /// </summary>
        public RelayCommand PoejectExportAs { get; set; }

        public void ExportIni()
        {
            foreach (var item in new DirectoryInfo(FullName).GetDirectories())
            {
                BaseObject baseObject = SolutionGlobal.FromDirectories(this, item);
                AddChild(baseObject);
            }
        }

        public SeriesProjectManager(string SeriesFolderPath) : base(SeriesFolderPath)
        {
            CanReName = false;
            Visibility = Visibility.Visible;

            PoejectExportAs = new RelayCommand(delegate
            {
                SeriesExportAsWindow GrifExportAsWindow = new SeriesExportAsWindow(this);
                GrifExportAsWindow.ShowDialog();
            }, (object value) => { return true; });


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

    }


}

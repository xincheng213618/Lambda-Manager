using Global.Common;
using Microsoft.Win32;
using NLGSolution;
using Solution;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tool;

namespace NLGSolution
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
            try
            {
                FileSize = MemorySize.MemorySizeText(MemorySize.GetDirectoryLength(FullPath, "derives"));
            }
            catch
            {

            }




        }


        /// <summary>
        /// 导出为
        /// </summary>
        public RelayCommand PoejectExportAs { get; set; }

        public SeriesProjectManager(string SeriesFolderPath) : base(SeriesFolderPath)
        {
            CanReName = false;
            PoejectExportAs = new RelayCommand(OnPoejectExportAs, (object value) => { return true; });

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
            if (sender == null)
                throw new NotImplementedException();
            Task.Run(CalculSize);

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
                var baseObject1 = ChildrenHidden.ToList().Find(t => t.FullPath == e.OldFullPath);
                if (baseObject1 != null)
                {
                    baseObject1.FullPath = e.FullPath;
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
                    AddChild(new ProjectFile(e.FullPath) { Visibility = Visibility.Hidden });
                }));
            }
            else if (Directory.Exists(e.FullPath))
            {
                Application.Current.Dispatcher.Invoke((Action)(() =>
                {
                    AddChild(new ProjectFolder(e.FullPath) { Visibility=Visibility.Hidden});
                }));
            }
        }






        public override void AddChild(object obj)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DerivativeSeriesFile derivativeSeriesFile = new DerivativeSeriesFile(dialog.SelectedPath);
                AddChild(derivativeSeriesFile);

            }
        }

        private void OnPoejectExportAs(object value)
        {
            ExportAsWindow exportAsWindow = new ExportAsWindow(this);
            exportAsWindow.ShowDialog();
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null) return;

            base.RemoveChild(baseObject);
            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                Children.Remove(baseObject);
                baseObject.Delete();
            }
        }


        public override void Delete()
        {
            base.Delete();

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

    }


}

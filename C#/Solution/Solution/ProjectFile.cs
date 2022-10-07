using Global.Common;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Tool;

namespace XSolution
{
    public class ProjectFile : BaseObject
    {
        public static ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();


        private string fileSize;
        public string FileSize
        {
            get { return fileSize; }
            set { fileSize = value; NotifyPropertyChanged(); }
        }
        public RelayCommand OpenExplorer { get; set; }

        protected FileInfo FileInfo;
        public ProjectFile(string FullName) :base(FullName)
        {
            ProjectFiles.Add(this);
            FileInfo = new FileInfo(FullName);
            this.Name = Path.GetFileNameWithoutExtension(fullName);
            OpenExplorer = new RelayCommand(OpenFolder, (object value) => { return true; });

            Task.Run(CalculSize);
        }


        public override void AddChild(object obj)
        {
            OpenFileDialog dialog = new()
            {
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf"
            };
            bool? result = dialog.ShowDialog();
            AddChild(new DerivativeFile(dialog.FileName));
        }
        private void OpenFolder(object value)
        {
            System.Diagnostics.Process.Start("explorer.exe", FullName);
        }

        public void CalculSize()
        {
            if (FileInfo.Exists)
            {
                FileSize = MemorySize.MemorySizeText(FileInfo.Length);
            }
        }


        public override bool IsEditMode
        {
            get { return isEditMode; }
            set
            {
                if (value != isEditMode)
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
        }

        public override void Delete()
        {
            base.Delete();
            try
            {
                if (File.Exists(FullName))
                    File.Delete(FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public override void AddChild(BaseObject baseObject)
        {
            base.AddChild(baseObject);
        }

        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null) return;
            baseObject.Parent = this;

            base.RemoveChild(baseObject);

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;
                VisualChildren.Remove(baseObject);
                baseObject.Delete();
            }
        }


        public string Extension
        {
            get { return Path.GetExtension(FullName); }
            protected set { }
        }   

    }
}

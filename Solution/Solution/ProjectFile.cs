using Global.Common;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Tool;

namespace NLGSolution
{
    public class ProjectFile : BaseObject
    {
        private string fileSize;
        public string FileSize
        {
            get { return fileSize; }
            set { fileSize = value; NotifyPropertyChanged(); }
        }
        public RelayCommand OpenExplorer { get; set; }

        public ProjectFile(string FilePath):base(FilePath)
        {
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
            System.Diagnostics.Process.Start("explorer.exe", FullPath);
        }

        public void CalculSize()
        {
            FileInfo fileinfo = new FileInfo(FullPath);
            FileSize = MemorySize.MemorySizeText(fileinfo.Length);
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

        public override void Delete()
        {
            base.Delete();
            try
            {
                if (File.Exists(FullPath))
                    File.Delete(FullPath);
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
                Children.Remove(baseObject);
                baseObject.Delete();
            }
        }


        public string Extension
        {
            get { return Path.GetExtension(FullPath); }
            protected set { }
        }   

    }
}

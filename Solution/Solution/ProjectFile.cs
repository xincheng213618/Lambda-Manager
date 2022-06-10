using System;
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


        public ProjectFile(string FilePath):base(FilePath)
        {
            Task.Run(CalculSize);
        }

        private void CalculSize()
        {
            //await Task.Delay(10000);

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


        public string Extension
        {
            get { return Path.GetExtension(FullPath); }
            protected set { }
        }   

    }
}

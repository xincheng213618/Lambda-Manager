using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NLGSolution
{

    public class BaseObject :INotifyPropertyChanged
    {
        public enum Type
        {
            File, Directory
        }

        public BaseObject(string FullPath, Type type)
        {
            this.FullPath = FullPath;
            this.Types = type;
        }

        public BaseObject Parent = null;


        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public virtual void AddChild(BaseObject baseObject)
        {
        }
        public virtual void RemoveChild(BaseObject baseObject)
        {

        }



        public Type Types { get; set; }

        private bool isEditMode = false;
        public bool IsEditMode
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
                            if (Types == Type.File)
                            {
                                File.Move(oldpath, newpath);
                            }
                            else if (Types == Type.Directory)
                            {
                                Directory.Move(oldpath, newpath);
                            }
                            FullPath = newpath;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("文件名冲突" + ex.Message);
                            isEditMode = true;
                        }
                    }

                }
                NotifyPropertyChanged();
            }
        }
        public void Delete()
        {
            try
            {
                if (Types == Type.File)
                {
                    if (File.Exists(fullPath))
                        File.Delete(FullPath);
                }
                else if (Types == Type.Directory)
                {
                    if (Directory.Exists(FullPath))
                        Directory.Delete(FullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("文件删除失败" + ex.Message);
            }

        }



        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged();
            }
        }

        private string fullPath;

        public string FullPath
        {
            get { return fullPath; }
            set {
                fullPath = value;
                this.Name = Path.GetFileNameWithoutExtension(fullPath);
                NotifyPropertyChanged();
            }
        }

    }
    
}

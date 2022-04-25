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

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
                NotifyPropertyChanged();
            }
        }

    }
    
}

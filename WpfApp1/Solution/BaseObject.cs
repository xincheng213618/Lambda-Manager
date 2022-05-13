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
            File, Directory,
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

        public bool isEditMode = false;
        public virtual bool IsEditMode
        {
            get { return isEditMode; }
            set
            {
                isEditMode = value;
            }
        }

        public virtual void Delete() { }


        public string tempname;
        public string name;
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

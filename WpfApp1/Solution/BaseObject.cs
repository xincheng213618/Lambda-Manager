using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NLGSolution
{

    public abstract class BaseAbstractObject
    {
        public abstract void AddChild(BaseObject baseObject);
        public abstract void RemoveChild(BaseObject baseObject);
    }

    public class BaseObject : INotifyPropertyChanged
    {
        public BaseObject(string FullPath)
        {
            this.FullPath = FullPath;
        }
        public BaseObject Parent = null;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event EventHandler AddChildEventHandler;
        public virtual void AddChild(BaseObject baseObject)
        {
            AddChildEventHandler?.Invoke(this,new EventArgs());
        }

        public event EventHandler RemoveChildEventHandler;
        public virtual void RemoveChild(BaseObject baseObject)
        {
            RemoveChildEventHandler?.Invoke(this, new EventArgs());
        }

        public virtual bool CanReName { get; set; } = true;
        public virtual bool CanCopy  { get; set; } = false;
        public virtual bool CanDelete { get; set; } = true;

        public Type Types { get; set; }

        public bool isEditMode = false;
        public virtual bool IsEditMode { get; set; }

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

        public string fullPath;

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

using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NLGSolution
{
    public class ViewModeBase : INotifyPropertyChanged
    {
        public ViewModeBase(string FullPath)
        {
            this.FullPath = FullPath;
        }

        public ViewModeBase Parent = null;

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event EventHandler AddChildEventHandler;
        public virtual void AddChild(ViewModeBase baseObject)
        {
            AddChildEventHandler?.Invoke(this,new EventArgs());
        }

        public event EventHandler RemoveChildEventHandler;
        public virtual void RemoveChild(ViewModeBase baseObject)
        {
            RemoveChildEventHandler?.Invoke(this, new EventArgs());
        }

        public virtual bool CanReName { get; set; } = true;
        public virtual bool CanCopy  { get; set; } = false;
        public virtual bool CanDelete { get; set; } = true;

        public Type Types { get; set; }

        protected bool isEditMode = false;
        public virtual bool IsEditMode { get; set; }

        public virtual void Delete() { }

        protected string name;


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

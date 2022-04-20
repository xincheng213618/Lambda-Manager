using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace NLGSolution
{
    public class BaseObject :INotifyPropertyChanged
    {
        public BaseObject(string FullPath)
        {
            this.FullPath = FullPath;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool isEditMode = false;
        public bool IsEditMode
        {
            get { return isEditMode; }
            set
            {
                isEditMode = value;
                NotifyPropertyChanged();
            }
        }

        private string name;
        private string oldname;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (oldname != null)
                {
                    try
                    {

                        string oldpath = FullPath;
                        FullPath = FullPath.Replace(oldname, name);
                        File.Move(oldpath, FullPath);
                    }
                    catch { }   
                }
                oldname = name;
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

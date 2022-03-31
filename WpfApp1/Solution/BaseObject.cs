using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace NLGSolution
{
    public class BaseObject :INotifyPropertyChanged
    {
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

                        string oldpath = FilePath;
                        FilePath = FilePath.Replace(oldname, name);
                        File.Move(oldpath, FilePath);
                    }
                    catch { }   
                }
                oldname = name;
                NotifyPropertyChanged();
            }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set {
                filePath = value; 
            }
        }



    }
}

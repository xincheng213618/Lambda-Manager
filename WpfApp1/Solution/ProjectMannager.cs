using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace NLGSolution
{
    public class ProjectMannager : BaseObject
    {

        public Guid ConfirmationID { get; set; }

        public ObservableCollection<ProjectFolder> ProjectFolders { get; set; } = new ObservableCollection<ProjectFolder>();
        public ObservableCollection<ProjectFile> ProjectFiles { get; set; } = new ObservableCollection<ProjectFile>();
        public virtual void DoubleClick(MouseButtonEventArgs e)
        {
            MessageBox.Show("22222222222222222");
        }


        private ObservableCollection<object> childNodes = new ObservableCollection<object>();
        public ObservableCollection<object> Children
        {
            get
            {
                return childNodes;
            }
            set
            {
            }
        }
        public void AddChild(ProjectFolder projectFolder)
        {
            ProjectFolders.Add(projectFolder);
            childNodes.Add(projectFolder);

            NotifyPropertyChanged("Children");
        }
        public void AddChild(ProjectFile projectFile)
        {
            ProjectFiles.Add(projectFile);
            childNodes.Add(projectFile);

            NotifyPropertyChanged("Children");
        }
        public void AddChilds(ProjectFile projectFile)
        {
            ProjectFiles.Add(projectFile);
            childNodes.Add(projectFile);
        }
        public void AddChildsEnd()
        {
            NotifyPropertyChanged("Children");
        }
    }
}

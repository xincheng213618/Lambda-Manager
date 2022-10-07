using Global.Common;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace XSolution
{
    public class ProjectManager : ProjectFolder
    {

        public ProjectManager(string ProjectPath):base(ProjectPath)
        {


        }

        public Guid ConfirmationID { get; set; }

        public ObservableCollection<ProjectFolder> ProjectFolders
        { 
            get { 
                var projectFolders = new ObservableCollection<ProjectFolder>();
                foreach (var item in VisualChildren)
                {
                    if (item is ProjectFolder projectfolder)
                        projectFolders.Add(projectfolder);

                }
                return projectFolders;
            }
            private set { } 
        }

        public ObservableCollection<ProjectFile> ProjectFiles
        {
            get
            {
                var projectFiles = new ObservableCollection<ProjectFile>();
                foreach (var item in VisualChildren)
                {
                    if (item is ProjectFile projectFile)
                        projectFiles.Add(projectFile);

                }
                return projectFiles;
            }
            private set { }
        }
        public override void AddChild(BaseObject baseObject)
        {
            base.AddChild(baseObject);
            if (this.Parent != null)
                if (this.Parent != null)
                {
                    string Extension = System.IO.Path.GetExtension(baseObject.FullName);
                    if (Extension == ".png" || Extension == ".jpg" || Extension == ".tiff" || Extension == ".bmp" || Extension == ".txt"|| Extension == ".grif")
                        this.Parent.AddChild(baseObject);

                }


        }
    }
}

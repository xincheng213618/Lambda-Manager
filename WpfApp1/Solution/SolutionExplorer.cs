using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace NLGSolution
{
    public class SolutionExplorer : BaseObject
    {
        public SolutionExplorer(string FullPath):base(FullPath,Type.Directory)
        {
            //AddExistingProject1 = new CommandBinding(AddExistingProject, AddNewProject_Executed, AddNewProject_CanExecute);
            EditCommand = new MyCommand(() =>
            {
                OnDepartmentEdited();
            }, () => { return true; });
            AddNewProject = new MyCommand(() =>
            {
                OnAddNewProject();
            }, () => { return true; });

        }
        private void OnDepartmentEdited()
        {
            MessageBox.Show("22222");
        }

        private void OnAddNewProject()
        {
            //ProjectMannager projectMannager = new ProjectMannager()
            //{
            //    Name = "新建工程2"
            //};

            //AddChild(projectMannager);
        }


        public static MyCommand AddNewProject { get; set; }
        public static MyCommand AddExistingProject { get; set; }
        public MyCommand EditCommand { get; set; }

        public CommandBinding AddExistingProject1;
        private void AddNewProject_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AddNewProject_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //ProjectMannager projectMannager = new ProjectMannager()
            //{
            //    Name = "新建工程2"
            //};

            //AddChild(projectMannager);
        }

        public Guid SolutionGuid { get; set; }

        public string SolutionName { get; set; }
        public string SolutionVersion { get; set; }

        public string SolutionPath { get; set; }


        public SolutionLog SolutionLog { get; set; }
        public SolutionConfig SolutionConfig { get; set; }

        public ObservableCollection<ProjectMannager> ProjectMannagers { get; set; } = new ObservableCollection<ProjectMannager>();

        public ObservableCollection<SeriesProjectManager> SeriesProjectManagers { get; set; } = new ObservableCollection<SeriesProjectManager>();


        public ObservableCollection<object> Children
        {
            get
            {
                ObservableCollection<object> childNodes = new ObservableCollection<object>();
                ProjectMannagers = new ObservableCollection<ProjectMannager>(ProjectMannagers.OrderBy(item => item.Name));
                foreach (var project in ProjectMannagers)
                    childNodes.Add(project);
                foreach (var series in SeriesProjectManagers)
                    childNodes.Add(series);
                if (SolutionLog != null)
                    childNodes.Add(SolutionLog);
                if (SolutionConfig != null)
                    childNodes.Add(SolutionConfig);
                return childNodes;
            }
            protected set { }
        }

        public override void AddChild(BaseObject baseObject)
        {
            baseObject.Parent = this;

            //if (baseObject is ProjectFolder folder)
            //{
            //    ProjectFolders.Add(folder);
            //}
            //else if (baseObject is ProjectFile file)
            //{
            //    ProjectFiles.Add(file);
            //}
            if (baseObject is ProjectMannager mannager)
            {
                ProjectMannagers.Add(mannager);
            }
            else if (baseObject is SeriesProjectManager series)
            {
                SeriesProjectManagers.Add(series);
            }

            NotifyPropertyChanged("Children");
        }
        public override void RemoveChild(BaseObject baseObject)
        {
            if (baseObject == null)
                return;

            if (baseObject.Parent == this)
            {
                baseObject.Parent = null;

                //this.Children.Remove(baseObject);

                baseObject.Delete();
                if (baseObject is ProjectMannager mannager)
                    ProjectMannagers.Remove(mannager);
                else if (baseObject is SeriesProjectManager series)
                    SeriesProjectManagers.Remove(series);

                NotifyPropertyChanged("Children");
            }
        }

        public void AddChild(ProjectMannager projectMannager)
        {
            ProjectMannagers.Add(projectMannager);
            NotifyPropertyChanged("Children");
        }
        public void AddChild(SeriesProjectManager seriesProjectManager)
        {
            SeriesProjectManagers.Add(seriesProjectManager);
            NotifyPropertyChanged("Children");
        }


    }
}

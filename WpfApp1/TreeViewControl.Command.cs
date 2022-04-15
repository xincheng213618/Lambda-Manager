﻿using NLGSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class TreeViewControl
    {
        private void IniCommand()
        {
            //Commands.ReName.InputGestures.Add(new KeyGesture(Key.M, (ModifierKeys.Control), "F2"));
            CommandBindings.Add(new CommandBinding(AddNewProject, this.AddNewProject_Executed, this.AddNewProject_CanExecute));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Copy, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Delete, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Delete, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(Commands.ReName, this.ExecutedCommand, this.CanExecuteCommand));
        }
        #region 通用命令执行函数

        private void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {

            if (e.Command == ApplicationCommands.SelectAll)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Copy)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Cut)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Paste)
            {
                e.CanExecute = false;
            }
            else if (e.Command == ApplicationCommands.Delete)
            {
                e.CanExecute = true;
            }
            else if (e.Command == Commands.ReName)
            {
                e.CanExecute = true;
            }
        }



        private void ExecutedCommand(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Copy)
            {
                //this.DoCopy();
            }
            else if (e.Command == ApplicationCommands.Cut)
            {
                //this.DoCut();
            }
            else if (e.Command == ApplicationCommands.Paste)
            {
                //this.DoPaste();
            }
            else if (e.Command == ApplicationCommands.Delete)
            {

            }
            else if (e.Command == Commands.ReName)
            {
                if (e.Parameter != null)
                {
                    if (e.Parameter is ProjectFile projectFile)
                        projectFile.IsEditMode = true;
                    else if (e.Parameter is ProjectFolder projectFolder)
                        projectFolder.IsEditMode = true;
                    else if (e.Parameter is ProjectMannager projectMannager)
                        projectMannager.IsEditMode = true;
                }
                else
                {
                    HitTestResult result = VisualTreeHelper.HitTest(TreeView1, SelectPoint);
                    if (result != null)
                    {
                        TreeViewItem item = ViewHelper.FindVisualParent<TreeViewItem>(result.VisualHit);
                        if (item != null)
                        {
                            LastSelectItem = item;
                            if (item.DataContext is ProjectFile projectFile)
                                projectFile.IsEditMode = true;
                            else if (item.DataContext is ProjectFolder projectFolder)
                                projectFolder.IsEditMode = true;
                            else if (item.DataContext is ProjectMannager projectMannager)
                                projectMannager.IsEditMode = true;
                        }

                    }

                }
            }
            else
            {

            }

        }



        #endregion

        private void AddNewProject_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void AddNewProject_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            ProjectMannager projectMannager = new ProjectMannager()
            {
                Name = "新建工程1"
            };
            SolutionExplorers[0].AddChild(projectMannager);
        }

        public static RoutedCommand NewProject = new RoutedCommand();
        public static RoutedCommand OpenProject = new RoutedCommand();
        public static RoutedCommand AddNewProject = new RoutedCommand();
        public static RoutedCommand AddExistingProject = new RoutedCommand();
        public static RoutedCommand CloseSolution = new RoutedCommand();
        public static RoutedCommand Exit = new RoutedCommand();
        public static RoutedCommand OpenLocalFolder = new RoutedCommand();


    }
}
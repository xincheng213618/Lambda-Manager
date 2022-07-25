using NLGSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Solution
{
    public partial class TreeViewControl
    {
        private void IniCommand()
        {
            ApplicationCommands.Delete.InputGestures.Add(new KeyGesture(Key.Delete, ModifierKeys.None, "Del"));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Copy, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(ApplicationCommands.Delete, this.ExecutedCommand, this.CanExecuteCommand));
            this.CommandBindings.Add(new CommandBinding(Commands.ReName, this.ExecutedCommand, this.CanExecuteCommand));
        }

        #region 通用命令执行函数

        private void CanExecuteCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            if (SelectedTreeViewItem != null && SelectedTreeViewItem.DataContext is BaseObject baseObject1)
            {
                if (e.Command == ApplicationCommands.SelectAll)
                {
                    e.CanExecute = false;
                }
                else if (e.Command == ApplicationCommands.Copy)
                {
                    e.CanExecute = baseObject1.CanCopy;
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
                    e.CanExecute = baseObject1.CanDelete;
                }
                else if (e.Command == Commands.ReName)
                {
                    e.CanExecute = baseObject1.CanReName;
                }
            }

            if (e.Parameter is BaseObject baseObject)
            {
                if (e.Command == ApplicationCommands.SelectAll)
                {
                    e.CanExecute = false;
                }
                else if (e.Command == ApplicationCommands.Copy)
                {
                    e.CanExecute = baseObject.CanCopy;
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
                    e.CanExecute = baseObject.CanDelete;
                }
                else if (e.Command == Commands.ReName)
                {
                    e.CanExecute = baseObject.CanReName;
                }
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
                if (e.Parameter != null)
                {
                    if (e.Parameter is BaseObject baseObject)
                    {
                        baseObject.Parent.RemoveChild(baseObject);
                    }
                }
                else
                {
                    if (SelectedTreeViewItem != null)
                    {
                        if (SelectedTreeViewItem.DataContext is BaseObject baseObject)
                        {
                            baseObject.Parent.RemoveChild(baseObject);
                        }
                    }
                }

            }
            
            else if (e.Command == Commands.ReName)
            {
                if (e.Parameter != null)
                {
                    if (e.Parameter is BaseObject baseObject)
                    {
                        LastReNameObject = baseObject;
                        baseObject.IsEditMode = true;
                    }
                }
                else
                {
                    //没有数据的时候通过点击确认
                    if (SelectedTreeViewItem != null)
                    {
                        if (SelectedTreeViewItem.DataContext is BaseObject baseObject)
                        {
                            LastReNameObject = baseObject;
                            baseObject.IsEditMode = true;
                        }
                    }
                }
            }
            else
            {

            }

        }

        #endregion
    }
}
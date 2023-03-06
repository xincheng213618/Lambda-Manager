using Global.Common;
using Global.Common.Extensions;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Xml.Linq;

namespace XSolution
{


    public abstract class BObject: DependencyObject,INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 触发消息通知事件
        /// </summary>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public interface IFileInfo {
        public FileInfo FileInfo { get; protected set; } 

        public string Name { get; set; }
    }


    public interface BObjectOperations {
        public abstract bool CanOpen { get; }
        public abstract void Open();
        public abstract bool CanCopy { get; }
        public abstract void Copy();
        public abstract bool CanReName { get; }
        public abstract void ReName();
        public abstract bool CanDelete { get; }
        public abstract void Delete();
    }

    /// <summary>
    /// 工程文件的基础Object
    /// 继承自ViewModeBase的
    /// </summary>
    public class BaseObject : BObject, IComparable, BObjectOperations {

        /// <summary>
        /// 显示的子集
        /// </summary>
        public virtual ObservableCollection<BaseObject> VisualChildren { get; set; }

        /// <summary>
        /// 被隐藏的子集
        /// </summary>
        public ObservableCollection<BaseObject> VisualChildrenHidden { get; set; }



        protected Visibility _Visibility = Visibility.Visible;

        public Visibility Visibility
        {
            get { return _Visibility; }
            set {
                if (value != _Visibility)
                {
                    _Visibility = value;
                    if (this.Parent is BaseObject baseObject)
                    {
                        if (_Visibility == Visibility.Visible)
                        {
                            baseObject.VisualChildrenHidden.Remove(this);
                            baseObject.VisualChildren.SortedAdd(this);
                        }
                        else
                        {
                            baseObject.VisualChildren.Remove(this);
                            baseObject.VisualChildrenHidden.SortedAdd(this);
                        }
                    }
                    NotifyPropertyChanged();
                }

            }
        }

        public bool IsExpanded { get => _IsExpanded; set { _IsExpanded = value; NotifyPropertyChanged(); } }
        private bool _IsExpanded = false;


        public bool IsSelected { get => _IsSelected; set { _IsSelected = value; NotifyPropertyChanged(); } }
        private bool _IsSelected = false;




        public RelayCommand AddChildren { get; set; }
        public RelayCommand RemoveChildren { get; set; }


        /// <summary>
        /// 隐藏取消
        /// </summary>
        public RelayCommand VisibilityHidden { get; set; }

        /// <summary>
        /// 隐藏一键取消
        /// </summary>
        public RelayCommand VisibilityUnHidden { get; set; }

        public RelayCommand DeleteCommand { get; set; }



        public bool DeleteShowDialog = true;

        public BaseObject(string FullName)
        {
            this.FullName = FullName;
            AddChildren = new RelayCommand(AddChildDialog, (object value) => { return true; });
            VisibilityHidden = new RelayCommand(delegate
            {
                this.Visibility = Visibility.Hidden;

            }, (object value) => { return true; });
            VisibilityUnHidden = new RelayCommand(delegate
            {
                foreach (var item in VisualChildrenHidden.ToList())
                {
                    item.Visibility =Visibility;
                }
                VisualChildrenHidden.Clear();
            }, (object value) => { return true; });

            DeleteCommand = new RelayCommand(delegate
            {
                if (!DeleteShowDialog)
                {
                    Parent.RemoveChild(this);
                    return;
                }

                if (MessageBox1.Show("即将删除文件", "Grid", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Parent.RemoveChild(this);
                };
            }, (object value) => { return CanDelete; });
            VisualChildren = new ObservableCollection<BaseObject>() { };
            VisualChildrenHidden = new ObservableCollection<BaseObject>() { };
        }

        public virtual void AddChildDialog(object obj)
        {
            
        }


        public BaseObject Parent
        {
            get { return _Parent; }
            set
            {
                _Parent = value;
                NotifyPropertyChanged();
            }
        }
        private BaseObject _Parent;


        /// <summary>
        /// 添加对象的时候的触发的触发事件
        /// </summary>
        public event EventHandler AddChildEventHandler;

        public virtual void AddChild(BaseObject baseObject)
        {
            if (baseObject == null) return;
            baseObject.Parent = this;
            AddChildEventHandler?.Invoke(this, new EventArgs());
            if (baseObject.Visibility == Visibility.Visible)
            {
                VisualChildren.SortedAdd(baseObject);
            }
            else
            {
                VisualChildrenHidden.SortedAdd(baseObject);
            }
        }

        /// <summary>
        /// 移除对象的时候的触发的触发事件
        /// </summary>
        public event EventHandler RemoveChildEventHandler;
        public virtual void RemoveChild(BaseObject baseObject)
        {
            RemoveChildEventHandler?.Invoke(this, new EventArgs());
        }



        public bool CanEditMode => CanReName;


        /// <summary>
        /// 现在是否是文件名修改
        /// </summary>
        public virtual bool IsEditMode
        {
            get { return CanEditMode && _IsEditMode; }
            set { if (!CanEditMode) return;  _IsEditMode = value; NotifyPropertyChanged(); }
        }
        protected bool _IsEditMode = false;


        /// <summary>
        /// 删除自己的接口
        /// </summary>
        public virtual void Delete() { }



        /// <summary>
        /// 展示的名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; 
                NotifyPropertyChanged();}
        }

        protected string _Name;


        /// <summary>
        /// 文件地址
        /// </summary>
        public string FullName
        {
            get { return _FullName; }
            set {
                _FullName = value;
                this.Name = Path.GetFileNameWithoutExtension(_FullName);
                NotifyPropertyChanged();
            }
        }


        protected string _FullName;


        public virtual int CompareTo(object obj)
        {
            if (obj == null) return -1;
            else if (obj == this) return 0;
            else if (obj is BaseObject baseObject) return Global.Common.NativeMethods.Shlwapi.StrCmpLogicalW(Name, baseObject.Name);
            else return -1;
        }
        /// <summary>
        /// 是否允许重命名
        /// </summary>
        public virtual bool CanReName { get; set; } = true;

        /// <summary>
        /// 是否允许复制
        /// </summary>
        public virtual bool CanCopy { get; set; } = false;

        /// <summary>
        /// 是否允许删除
        /// </summary>
        public virtual bool CanDelete { get; set; } = true;


        public bool CanOpen { get; set; } = true;


        public virtual void Open() {
            throw new NotImplementedException();
        }

        public virtual void Copy() {
            throw new NotImplementedException();
        }

        public virtual void ReName() {
            throw new NotImplementedException();
        }
    }

}

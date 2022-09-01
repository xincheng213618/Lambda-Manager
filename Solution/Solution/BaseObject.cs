using Global.Common;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Xml.Linq;

namespace XSolution
{

    /// <summary>
    /// 工程文件的基础Object
    /// 继承自ViewModeBase的
    /// </summary>
    public class BaseObject : DependencyObject, INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// 触发消息通知事件
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void Dispose()
        {
            this.Parent = null;
        }


        /// <summary>
        /// 显示的子集
        /// </summary>
        public ObservableCollection<BaseObject> VisualChildren { get; set; }

        /// <summary>
        /// 被隐藏的子集
        /// </summary>
        public ObservableCollection<BaseObject> VisualChildrenHidden { get; set; }


        protected Visibility _visibility = Visibility.Visible;

        public Visibility Visibility
        {
            get { return _visibility; }
            set {
                if (value != _visibility)
                {
                    _visibility = value;

                    if (this.Parent != null && this.Parent is BaseObject baseObject)
                    {
                        if (_visibility == Visibility.Visible)
                        {
                            if (baseObject.VisualChildrenHidden.Contains(this))
                            {
                                baseObject.VisualChildrenHidden.Remove(this);
                                baseObject.VisualChildren.SortedAdd(this);
                            }
                        }
                        else
                        {
                            if (baseObject.VisualChildren.Contains(this))
                            {
                                baseObject.VisualChildren.Remove(this);
                                baseObject.VisualChildrenHidden.SortedAdd(this);
                            }
                        }
                    }
                    NotifyPropertyChanged();
                }

            }
        }


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


        public BaseObject(string FullName)
        {
            this.FullName = FullName;

            AddChildren = new RelayCommand(AddChild, (object value) => { return true; });
            VisibilityHidden = new RelayCommand(delegate
            {
                this.Visibility = Visibility.Hidden;

            }, (object value) => { return true; });
            VisibilityUnHidden = new RelayCommand(delegate
            {
                foreach (var item in VisualChildrenHidden)
                {
                    VisualChildren.SortedAdd(item);
                }
                VisualChildrenHidden.Clear();
            }, (object value) => { return true; });

            DeleteCommand = new RelayCommand(delegate
            {
                if (MessageBox1.Show("即将删除文件", "Grid", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Parent.RemoveChild(this);
                };
            }, (object value) => { return CanDelete; });

            VisualChildren = new ObservableCollection<BaseObject>() { };
            VisualChildrenHidden = new ObservableCollection<BaseObject>() { };
        }
        



        public virtual void AddChild(object obj)
        {

        }


        private BaseObject parent = null;
        public BaseObject Parent
        {
            get { return parent; }
            set
            {
                if (value != parent && value is BaseObject)
                {
                    parent = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        /// <summary>
        /// 是否允许重命名
        /// </summary>
        public virtual bool CanReName { get; set; } = true;

        /// <summary>
        /// 是否允许复制
        /// </summary>
        public virtual bool CanCopy  { get; set; } = false;

        /// <summary>
        /// 是否允许删除
        /// </summary>
        public virtual bool CanDelete { get; set; } = true;



        protected bool isEditMode = false;

        /// <summary>
        /// 现在是否是文件名修改
        /// </summary>
        public virtual bool IsEditMode
        {
            get { return isEditMode; }
            set { isEditMode = value; NotifyPropertyChanged(); }
        }


        /// <summary>
        /// 删除自己的接口
        /// </summary>
        public virtual void Delete() { }


        protected string name;

        /// <summary>
        /// 展示的名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value;  NotifyPropertyChanged();}
        }

        protected string fullName; 
        /// <summary>
        /// 文件地址
        /// </summary>
        public string FullName
        {
            get { return fullName; }
            set {
                fullName = value;
                this.Name = Path.GetFileNameWithoutExtension(fullName);
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// 得到指定数据类型的祖先节点。
        /// </summary>
        public BaseObject GetAncestor(System.Type type)
        {
            if (type == null)
                return null;

            if (type.Equals(this.GetType()))
                return this;
            if (type.IsAssignableFrom(this.GetType()))
                return this;
            if (this.GetType().IsSubclassOf(type))
                return this;

            if (this.Parent == null)
                return null;

            return this.Parent.GetAncestor(type);
        }

    }

}

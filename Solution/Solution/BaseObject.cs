using Global.Common;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NLGSolution
{
    /// <summary>
    /// 工程文件的基础Object
    /// 继承自ViewModeBase的
    /// </summary>
    public class BaseObject : ViewModelBase
    {

        public ObservableCollection<BaseObject> AdllChildren { get; set; }  

        public ObservableCollection<BaseObject> Children { get; set; }
        public ObservableCollection<BaseObject> ChildrenHidden { get; set; }

        protected Visibility visibility = Visibility.Visible;

        public Visibility Visibility
        {
            get { return visibility; }
            set {
                visibility = value;

                if (this.Parent != null && this.Parent is BaseObject baseObject)
                {
                    if (visibility == Visibility.Visible)
                    {
                        if (baseObject.ChildrenHidden.Contains(this))
                        {
                            baseObject.ChildrenHidden.Remove(this);
                            baseObject.Children.SortedAdd(this);
                        }
                    }
                    else
                    {
                        if (baseObject.Children.Contains(this))
                        {
                            baseObject.Children.Remove(this);
                            baseObject.ChildrenHidden.SortedAdd(this);
                        }
                    }
                }
                NotifyPropertyChanged();

            }
        }


        public RelayCommand AddChildren { get; set; }
        public RelayCommand RemoveChildren { get; set; }

        public RelayCommand VisibilityHidden { get; set; }
        public RelayCommand VisibilityUnHidden { get; set; }



        public BaseObject(string FullPath)
        {
            this.FullPath = FullPath;
            AddChildren = new RelayCommand(AddChild, (object value) => { return true; });
            VisibilityHidden = new RelayCommand(VisibilityChanged, (object value) => { return true; });
            VisibilityUnHidden = new RelayCommand(VisibilityUnChanged, (object value) => { return true; });


            Children = new ObservableCollection<BaseObject>() { };
            ChildrenHidden = new ObservableCollection<BaseObject>() { };
        }
        



        public virtual void AddChild(object obj)
        {
            OpenFileDialog dialog = new()
            {
                Title = "请选择文件",
                RestoreDirectory = true,
                Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpeg)|*.jpeg |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff |Wmf Image (.wmf)|*.wmf"
            };
            bool? result = dialog.ShowDialog();
            AddChild(new BaseObject(dialog.FileName));
        }

        public virtual void VisibilityChanged(object obj)
        {
            this.Visibility = Visibility.Hidden;
        }
        public virtual void VisibilityUnChanged(object obj)
        {
            foreach (var item in ChildrenHidden)
            {
                Children.SortedAdd(item);
            }
            ChildrenHidden.Clear(); 
        }



        public BaseObject Parent = null;

        public BaseObject GetParent()
        {
            return Parent;
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
                Children.SortedAdd(baseObject);
            }
            else
            {
                ChildrenHidden.SortedAdd(baseObject);
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

        protected string fullPath;

        /// <summary>
        /// 文件地址
        /// </summary>
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

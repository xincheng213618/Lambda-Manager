using Global.Common;
using System;
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
    public class BaseObject : ViewModeBase
    {
        public BaseObject(string FullPath)
        {
            this.FullPath = FullPath;
        }
        /// <summary>
        /// 父对象
        /// </summary>
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
            AddChildEventHandler?.Invoke(this,new EventArgs());
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

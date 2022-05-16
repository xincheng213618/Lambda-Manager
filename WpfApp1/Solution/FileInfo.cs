using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLGSolution
{
    internal class IFileInfo
    {
        /// <summary>
        /// 本地文件全路径；
        /// </summary>
        string FullName { get; }

        ///// <summary>
        ///// 通过递归查找方式，获取当前文件的相对路径；该路径是相对于Project的一个路径；
        ///// </summary>
        //String ViPath { get; }

        ///// <summary>
        ///// 当前节点所属项目；
        ///// </summary>
        //ProjectManager CurrProject { get; }

        ///// <summary>
        ///// 当前节点所属Solution；
        ///// </summary>
        //SolutionManager TheSolution { get; }

        ///// <summary>
        ///// 当前项目所属根节点；
        ///// </summary>
        //IProjectFactory TheFactory { get; }

        string Key { get; }
    }

    public class CFileInfo
    {
        string FullName ;
        public CFileInfo(String fullName) 
        {
            this.FullName = fullName;
        }
        public virtual String Extension
        {
            get { return String.Empty; }
        }
        public virtual bool CanCopy { get { return false; } }

        public virtual bool CanCut { get { return false; } }

        public virtual bool CanPaste { get { return false; } }


        public virtual void DoCopy()
        {
            if (!File.Exists(this.FullName))
                return;

            // 执行复制操作
        }

        public virtual void DoCut()
        {

        }

        public virtual void DoPaste() { }

    }
}

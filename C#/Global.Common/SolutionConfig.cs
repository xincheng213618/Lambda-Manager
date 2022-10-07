using Global.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global.Common
{
    /// <summary>
    /// 先放这里后面再拆
    /// </summary>
    public static class SolutionConfig
    {
        public static TreeViewSetting treeViewSetting = new TreeViewSetting();
    }

    public class TreeViewSetting : ViewModelBase
    {

        private bool isSupportMultiProject = false;
        public bool IsSupportMultiProject
        {
            get { return isSupportMultiProject; }
            set
            {
                isSupportMultiProject = value;
                NotifyPropertyChanged();
            }
        }
    }
}

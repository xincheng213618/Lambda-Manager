using Global.Common;
using Global.Common.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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

        private bool isSupportMultiProject = Reg.ReadValue("Software\\Grid", "isSupportMultiProject", false);
        public bool IsSupportMultiProject
        {
            get { return isSupportMultiProject; }
            set
            {
                if (isSupportMultiProject!=value) {
                    isSupportMultiProject = value;
                    Reg.WriteValue("Software\\Grid", "isSupportMultiProject", isSupportMultiProject);
                    NotifyPropertyChanged();
                }

            }
        }
    }
}

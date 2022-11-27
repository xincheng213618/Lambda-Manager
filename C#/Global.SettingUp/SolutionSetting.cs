using Global.Common;
using Global.Common.Util;

namespace Global.SettingUp
{
    /// <summary>
    /// Solution环境
    /// </summary>
    public class SolutionSetting : ViewModelBase
    {
        public static string RegPath = "Software\\Grid";

        private bool isSupportMultiProject = Reg.ReadValue(RegPath, nameof(IsSupportMultiProject), false);
        public bool IsSupportMultiProject
        {
            get { return isSupportMultiProject; }
            set
            {
                if (isSupportMultiProject!=value) {
                    isSupportMultiProject = value;
                    Reg.WriteValue(RegPath, nameof(IsSupportMultiProject), isSupportMultiProject);
                    NotifyPropertyChanged();
                }
            }
        }

        private bool isShowLog = Reg.ReadValue(RegPath, nameof(isShowLog), false);
        public bool IsShowLog
        {
            get { return isShowLog; }
            set
            {
                if (isShowLog != value)
                {
                    isShowLog = value;
                    Reg.WriteValue(RegPath, nameof(isShowLog), isShowLog);
                    NotifyPropertyChanged();
                }
            }
        }
    }
}

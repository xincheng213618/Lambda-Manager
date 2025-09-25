using System.Windows.Controls;
using LambdaManager.Mode;

namespace LambdaManager.Controls
{
    /// <summary>
    /// 状态栏UserControl，显示图像和系统状态信息
    /// </summary>
    public partial class StatusBarControl : UserControl
    {
        public StatusBarControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置状态数据上下文
        /// </summary>
        /// <param name="updateStatus">状态更新对象</param>
        public void SetStatusDataContext(UpdateStatus updateStatus)
        {
            statusBar.DataContext = updateStatus;
        }
    }
}
using System.Windows;
using System.Windows.Controls;

namespace LambdaManager.Controls
{
    /// <summary>
    /// 左侧面板UserControl，包含工程和配置视图
    /// </summary>
    public partial class LeftPanelControl : UserControl
    {
        public LeftPanelControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取指定名称的面板
        /// </summary>
        /// <param name="panelName">面板名称</param>
        /// <returns>面板对象</returns>
        public Panel GetPanel(string panelName)
        {
            return panelName switch
            {
                "Project" => projectView,
                "Acquire" => acquireView,
                "Process" => processView,
                "Analysis" => analysisView,
                "Report" => reportView,
                _ => null
            };
        }

        /// <summary>
        /// 设置选中的Tab索引
        /// </summary>
        /// <param name="index">Tab索引</param>
        public void SetSelectedTabIndex(int index)
        {
            if (leftTab != null && index >= 0 && index < leftTab.Items.Count)
            {
                leftTab.SelectedIndex = index;
            }
        }

        /// <summary>
        /// 获取Tab控件引用
        /// </summary>
        public TabControl TabControl => leftTab;
    }
}
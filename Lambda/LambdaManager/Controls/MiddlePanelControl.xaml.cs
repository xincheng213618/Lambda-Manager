using System.Windows;
using System.Windows.Controls;
using Global.Common;

namespace LambdaManager.Controls
{
    /// <summary>
    /// 中间面板UserControl，包含材质视图和工作区
    /// </summary>
    public partial class MiddlePanelControl : UserControl
    {
        public MiddlePanelControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 多模态按钮点击命令
        /// </summary>
        public RelayCommand MultiModeCommand
        {
            get { return (RelayCommand)GetValue(MultiModeCommandProperty); }
            set { SetValue(MultiModeCommandProperty, value); }
        }

        public static readonly DependencyProperty MultiModeCommandProperty =
            DependencyProperty.Register("MultiModeCommand", typeof(RelayCommand), typeof(MiddlePanelControl), new PropertyMetadata(null));

        /// <summary>
        /// 多通道按钮点击命令
        /// </summary>
        public RelayCommand MultiChannelCommand
        {
            get { return (RelayCommand)GetValue(MultiChannelCommandProperty); }
            set { SetValue(MultiChannelCommandProperty, value); }
        }

        public static readonly DependencyProperty MultiChannelCommandProperty =
            DependencyProperty.Register("MultiChannelCommand", typeof(RelayCommand), typeof(MiddlePanelControl), new PropertyMetadata(null));

        /// <summary>
        /// 获取材质视图面板
        /// </summary>
        /// <returns>材质视图面板</returns>
        public Panel GetMaterialPanel()
        {
            return materialView;
        }
    }
}
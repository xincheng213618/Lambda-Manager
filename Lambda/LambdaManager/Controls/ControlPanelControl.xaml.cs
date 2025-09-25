using System.Windows;
using System.Windows.Controls;
using Global.Common;

namespace LambdaManager.Controls
{
    /// <summary>
    /// 控制面板UserControl，包含预览、采集、拍照等控制按钮
    /// </summary>
    public partial class ControlPanelControl : UserControl
    {
        public ControlPanelControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 预览命令
        /// </summary>
        public RelayCommand PreviewCommand
        {
            get { return (RelayCommand)GetValue(PreviewCommandProperty); }
            set { SetValue(PreviewCommandProperty, value); }
        }

        public static readonly DependencyProperty PreviewCommandProperty =
            DependencyProperty.Register("PreviewCommand", typeof(RelayCommand), typeof(ControlPanelControl), new PropertyMetadata(null));

        /// <summary>
        /// 开始采集命令
        /// </summary>
        public RelayCommand StartAcquireCommand
        {
            get { return (RelayCommand)GetValue(StartAcquireCommandProperty); }
            set { SetValue(StartAcquireCommandProperty, value); }
        }

        public static readonly DependencyProperty StartAcquireCommandProperty =
            DependencyProperty.Register("StartAcquireCommand", typeof(RelayCommand), typeof(ControlPanelControl), new PropertyMetadata(null));

        /// <summary>
        /// 拍照命令
        /// </summary>
        public RelayCommand SnapshotCommand
        {
            get { return (RelayCommand)GetValue(SnapshotCommandProperty); }
            set { SetValue(SnapshotCommandProperty, value); }
        }

        public static readonly DependencyProperty SnapshotCommandProperty =
            DependencyProperty.Register("SnapshotCommand", typeof(RelayCommand), typeof(ControlPanelControl), new PropertyMetadata(null));
    }
}
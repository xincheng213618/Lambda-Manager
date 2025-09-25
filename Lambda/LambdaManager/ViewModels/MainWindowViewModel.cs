using Global.Common;
using LambdaManager.Mode;
using LambdaManager.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Lambda;
using LambdaCore;
using LambdaManager.Properties;

namespace LambdaManager.ViewModels
{
    /// <summary>
    /// MainWindow的ViewModel，实现MVVM架构
    /// </summary>
    public class MainWindowViewModel : ViewModelBase
    {
        #region Fields
        private readonly IMessageService _messageService;
        private readonly Severity _logLevel;
        private bool _multiMode;
        private bool _multiChannel;
        private bool _isLeftViewHidden;
        private bool _isMiddleViewHidden;
        private double _leftViewWidth;
        private double _middleViewWidth;
        private bool _maximize;
        #endregion

        #region Properties
        /// <summary>
        /// 多模态状态
        /// </summary>
        public bool MultiMode
        {
            get => _multiMode;
            set => SetProperty1(ref _multiMode, value);
        }

        /// <summary>
        /// 多通道状态
        /// </summary>
        public bool MultiChannel
        {
            get => _multiChannel;
            set => SetProperty1(ref _multiChannel, value);
        }

        /// <summary>
        /// 左侧视图是否隐藏
        /// </summary>
        public bool IsLeftViewHidden
        {
            get => _isLeftViewHidden;
            set => SetProperty1(ref _isLeftViewHidden, value);
        }

        /// <summary>
        /// 中间视图是否隐藏
        /// </summary>
        public bool IsMiddleViewHidden
        {
            get => _isMiddleViewHidden;
            set => SetProperty1(ref _isMiddleViewHidden, value);
        }

        /// <summary>
        /// 左侧视图宽度
        /// </summary>
        public double LeftViewWidth
        {
            get => _leftViewWidth;
            set => SetProperty1(ref _leftViewWidth, value);
        }

        /// <summary>
        /// 中间视图宽度
        /// </summary>
        public double MiddleViewWidth
        {
            get => _middleViewWidth;
            set => SetProperty1(ref _middleViewWidth, value);
        }

        /// <summary>
        /// 是否最大化
        /// </summary>
        public bool Maximize
        {
            get => _maximize;
            set => SetProperty1(ref _maximize, value);
        }

        /// <summary>
        /// 消息集合
        /// </summary>
        public ObservableCollection<Message> Messages => _messageService?.Messages ?? new ObservableCollection<Message>();

        /// <summary>
        /// 状态更新数据
        /// </summary>
        public UpdateStatus UpdateStatus { get; }
        #endregion

        #region Commands
        /// <summary>
        /// 预览命令
        /// </summary>
        public ICommand PreviewCommand { get; }

        /// <summary>
        /// 开始采集命令
        /// </summary>
        public ICommand StartAcquireCommand { get; }

        /// <summary>
        /// 拍照命令
        /// </summary>
        public ICommand SnapshotCommand { get; }

        /// <summary>
        /// 切换多模态命令
        /// </summary>
        public ICommand ToggleMultiModeCommand { get; }

        /// <summary>
        /// 切换多通道命令
        /// </summary>
        public ICommand ToggleMultiChannelCommand { get; }

        /// <summary>
        /// 相位选择命令
        /// </summary>
        public ICommand PhaseSelectionCommand { get; }
        #endregion

        #region Constructor
        public MainWindowViewModel() : this(MessageService.Instance)
        {
        }

        public MainWindowViewModel(IMessageService messageService)
        {
            _messageService = messageService ?? throw new ArgumentNullException(nameof(messageService));
            _logLevel = (Severity)Enum.Parse(typeof(Severity), Settings.Default.LogLevel, ignoreCase: true);
            
            // 初始化状态数据
            UpdateStatus = new UpdateStatus();
            
            // 初始化命令
            PreviewCommand = new RelayCommand(OnPreviewExecute);
            StartAcquireCommand = new RelayCommand(OnStartAcquireExecute);
            SnapshotCommand = new RelayCommand(OnSnapshotExecute);
            ToggleMultiModeCommand = new RelayCommand(OnToggleMultiModeExecute);
            ToggleMultiChannelCommand = new RelayCommand(OnToggleMultiChannelExecute);
            PhaseSelectionCommand = new RelayCommand(OnPhaseSelectionExecute);

            // 设置初始状态
            IsMiddleViewHidden = true;
            
            // 订阅消息服务事件
            if (_messageService != null)
            {
                _messageService.MessageAdded += OnMessageAdded;
            }
        }
        #endregion

        #region Command Handlers
        private void OnPreviewExecute(object parameter)
        {
            if (parameter is bool isChecked)
            {
                LambdaControl.Trigger(isChecked ? "STOP_ALIVE" : "START_ALIVE", this, EventArgs.Empty);
            }
        }

        private void OnStartAcquireExecute(object parameter)
        {
            if (parameter is bool isChecked)
            {
                LambdaControl.Trigger(isChecked ? "STOP_ACQUIRE" : "START_ACQUIRE", this, EventArgs.Empty);
            }
        }

        private void OnSnapshotExecute(object parameter)
        {
            LambdaControl.Trigger("SNAPSHOT", this, EventArgs.Empty);
        }

        private void OnToggleMultiModeExecute(object parameter)
        {
            LambdaControl.Trigger(MultiMode ? "START_MULTI_MODE" : "STOP_MULTI_MODE", this, EventArgs.Empty);
            MultiMode = !MultiMode;
        }

        private void OnToggleMultiChannelExecute(object parameter)
        {
            LambdaControl.Trigger(MultiChannel ? "START_MULTI_CHANNEL" : "START_MULTI_CHANNEL", this, EventArgs.Empty);
            MultiChannel = !MultiChannel;
        }

        private void OnPhaseSelectionExecute(object parameter)
        {
            LambdaControl.Trigger("PHASE_CHECKED", this, EventArgs.Empty);
        }
        #endregion

        #region Message Handling
        private void OnMessageAdded(Message message)
        {
            if (message.Severity >= _logLevel)
            {
                // 通知UI更新消息列表
                NotifyPropertyChanged(nameof(Messages));
            }
        }

        /// <summary>
        /// 添加消息 (兼容性方法)
        /// </summary>
        public void AddMessage(Message message)
        {
            _messageService?.AddMessage(message);
        }
        #endregion

        #region Lifecycle Management
        /// <summary>
        /// 初始化ViewModel
        /// </summary>
        public void Initialize()
        {
            // 初始化菜单管理器
            // 初始化视图管理器
            // 其他初始化逻辑
        }

        /// <summary>
        /// 清理资源
        /// </summary>
        protected override void VerifyAccess()
        {
            base.VerifyAccess();
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Cleanup()
        {
            if (_messageService != null)
            {
                _messageService.MessageAdded -= OnMessageAdded;
            }
        }
        #endregion
    }
}
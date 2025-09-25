using ColorVision.Themes;
using ColorVision.UI.Menus;
using Global.SettingUp.PC;
using Lambda;
using LambdaCore;
using LambdaManager.Core;
using LambdaManager.Features;
using LambdaManager.Properties;
using LambdaManager.Utils;
using LambdaManager.ViewModels;
using LambdaManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace LambdaManager
{
    /// <summary>
    /// 面板位置枚举，用于标识不同的UI面板区域
    /// </summary>
    public enum Side
    {
        TOP,
        LEFT,
        MIDDLE,
        RIGHT,
        BOTTOM,
        MENU,
        CONFIG,
        ACQUIRE,
        PROCESS,
        ANALYSIS,
        REPORT,
        PROJECT
    }

    /// <summary>
    /// MainWindow 主窗口，使用MVVM架构
    /// </summary>
    partial class MainWindow : Window
    {
        #region Fields
        private MainWindowViewModel _viewModel;
        private readonly IMessageService _messageService;
        #endregion

        #region Properties  
        public View[] Views = Common.Views;
        public TabControl tabControl;
        public List<int> ClosingViewIndex = Common.ClosingViewIndex;
        
        /// <summary>
        /// ViewModel属性
        /// </summary>
        public MainWindowViewModel ViewModel 
        { 
            get => _viewModel; 
            private set 
            { 
                _viewModel = value;
                DataContext = _viewModel;
            }
        }
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            
            // 初始化消息服务
            _messageService = MessageService.Instance;
            
            // 初始化ViewModel
            ViewModel = new MainWindowViewModel(_messageService);
            
            // 应用标题栏设置
            this.ApplyCaption();
            
            // 设置初始视图状态
            ChangeMiddleViewVisibility(false);
        }
        #endregion

        #region Window Event Handlers
        /// <summary>
        /// 窗口初始化事件处理
        /// </summary>
        private void Window_Initialized(object sender, EventArgs e)
        {
            // 初始化菜单管理器
            MenuManager.GetInstance().Menu = menu;
            MenuManager.GetInstance().LoadMenuItemFromAssembly();

            // 初始化视图管理器
            ViewManager.GetInstance().ViewChanged += ViewChanged;

            // 设置日志写入到消息服务
            Log.LogWrite += _messageService.AddMessage;
            
            // 设置状态栏数据上下文
            statusBarControl.SetStatusDataContext(ViewModel.UpdateStatus);
            
            // 初始化ViewModel
            ViewModel.Initialize();
        }

        /// <summary>
        /// 视图变更事件处理
        /// </summary>
        public void ViewChanged(object sender, ViewChangedEvent e)
        {
            // 视图变更逻辑保持不变
        }

        /// <summary>
        /// 窗口加载事件处理
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("APPLICATION_LOADED", sender, e);
        }

        /// <summary>
        /// 窗口关闭事件处理
        /// </summary>
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            // 清理ViewModel资源
            ViewModel?.Cleanup();
            
            // 执行通用退出逻辑
            Common.CommonExit();
            for (int i = 0; i < Views.Length; i++)
            {
                View view = Views[i];
                if (view != null)
                {
                    view.State = ViewState.CLOSED;
                }
            }
        }

        /// <summary>
        /// 窗口内容渲染完成事件处理
        /// </summary>
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            LambdaControl.Trigger("APPLICATION_DISPLAYED", sender, e);
            if (ViewModel.Maximize)
            {
                base.WindowState = WindowState.Maximized;
            }
        }

        /// <summary>
        /// 窗口大小变化事件处理
        /// </summary>
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // 窗口大小变化逻辑
        }
        #endregion


        #region Panel Management
        /// <summary>
        /// 获取配置面板
        /// </summary>
        /// <param name="side">面板位置</param>
        /// <returns>面板对象</returns>
        public Panel GetConfigPanel(Side side)
        {
            return side switch
            {
                Side.MIDDLE => middlePanelControl.GetMaterialPanel(),
                Side.ACQUIRE => leftPanelControl.GetPanel("Acquire"),
                Side.PROJECT => leftPanelControl.GetPanel("Project"),
                Side.REPORT => leftPanelControl.GetPanel("Report"),
                Side.ANALYSIS => leftPanelControl.GetPanel("Analysis"),
                Side.PROCESS => leftPanelControl.GetPanel("Process"),
                _ => throw new Exception("Panel not supported"),
            };
        }

        /// <summary>
        /// 添加菜单项
        /// </summary>
        /// <param name="path">菜单路径</param>
        /// <returns>菜单项</returns>
        public MenuItem? AddMenuItem(string path)
        {
            ItemCollection items = menu.Items;
            if (items == null)
            {
                return null;
            }
            MenuItem last = null;
            string[] array = path.Split("/");
            foreach (string name in array)
            {
                bool found = false;
                foreach (MenuItem item in items)
                {
                    if (item.Header.ToString().Contains(name))
                    {
                        found = true;
                        items = item.Items;
                        break;
                    }
                }
                if (!found)
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.Header = name;
                    items.Add(menuItem);
                    items = menuItem.Items;
                    last = menuItem;
                }   
            }
            return last;
        }
        #endregion


        #region View Management
        /// <summary>
        /// 改变左侧视图可见性
        /// </summary>
        /// <param name="visible">是否可见</param>
        public void ChangeLeftViewVisibility(bool visible)
        {
            if (visible)
            {
                if (ViewModel.LeftViewWidth > 0.0)
                {
                    leftView.Width = new GridLength(ViewModel.LeftViewWidth, GridUnitType.Pixel);
                }
            }
            else
            {
                ViewModel.LeftViewWidth = leftView.ActualWidth;
                leftView.Width = new GridLength(0.0, GridUnitType.Auto);
            }
            ChangeColumnVisibility(0, visible);
            ChangeColumnVisibility(1, visible);
            ViewModel.IsLeftViewHidden = !visible;
        }

        /// <summary>
        /// 改变中间视图可见性
        /// </summary>
        /// <param name="visible">是否可见</param>
        public void ChangeMiddleViewVisibility(bool visible)
        {
            if (visible)
            {
                if (ViewModel.MiddleViewWidth > 0.0)
                {
                    middleView.Width = new GridLength(ViewModel.MiddleViewWidth, GridUnitType.Pixel);
                }
            }
            else if (middleView.Width.GridUnitType == GridUnitType.Pixel)
            {
                ViewModel.MiddleViewWidth = middleView.ActualWidth;
                middleView.Width = new GridLength(0.0, GridUnitType.Auto);
            }
            ChangeColumnVisibility(2, visible);
            ChangeColumnVisibility(3, visible);
            ViewModel.IsMiddleViewHidden = !visible;
        }

        /// <summary>
        /// 改变列可见性
        /// </summary>
        /// <param name="col">列索引</param>
        /// <param name="visible">是否可见</param>
        private void ChangeColumnVisibility(int col, bool visible)
        {
            foreach (UIElement item in from UIElement i in stageAcquisition.Children
                                       where System.Windows.Controls.Grid.GetColumn(i) == col
                                       select i)
            {
                item.Visibility = ((!visible) ? Visibility.Collapsed : Visibility.Visible);
            }
        }
        #endregion

        #region Splitter Event Handlers
        /// <summary>
        /// 左侧分割器双击事件
        /// </summary>
        private void LeftSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ViewModel.IsMiddleViewHidden)
            {
                ChangeMiddleViewVisibility(visible: true);
            }
            else
            {
                ChangeLeftViewVisibility(visible: false);
            }
        }

        /// <summary>
        /// 中间分割器双击事件
        /// </summary>
        private void MiddleSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ChangeMiddleViewVisibility(visible: false);
        }
        #endregion

        #region Legacy Support Methods
        /// <summary>
        /// 添加消息 - 保持向后兼容性
        /// </summary>
        /// <param name="message">消息对象</param>
        public void AddMessage(Message message)
        {
            ViewModel?.AddMessage(message);
        }

        /// <summary>
        /// 获取左侧Tab控件的引用 - 用于相位切换
        /// </summary>
        public TabControl LeftTab => leftPanelControl?.TabControl;
        #endregion
    }



}

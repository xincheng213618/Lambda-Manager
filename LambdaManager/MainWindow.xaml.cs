using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Lambda;
using LambdaCore;
using LambdaManager.Config;
using LambdaManager.Core;
using LambdaManager.Features;
using LambdaManager.Mode;
using LambdaManager.Properties;
using LambdaManager.Utils;
using Mode;
using ThemeManager.Controls;

namespace LambdaManager
{
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

    partial class MainWindow : BaseWindow
    {
        private bool multiMode;
        private bool multiChannel;
        public View[] Views = Common.Views;
        public TabControl tabControl;

        public List<int> ClosingViewIndex = Common.ClosingViewIndex;
        public bool Maximize { get; set; }
        public bool IsLeftViewHidden { get; set; }
        public bool IsMiddleViewHidden { get; set; }
        public double LeftViewWidth { get; set; }
        public double MiddleViewWidth { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ChangeMiddleViewVisibility(false);
        }

        StatusBarGlobal statusBarGlobal = new StatusBarGlobal();
        private void Window_Initialized(object sender, EventArgs e)
        {
            ViewManager.GetInstance().ViewChanged += ViewChanged;
            allfpsState.DataContext = ViewManager.GetInstance();
            if (Common.ViewGrid is ViewGrid viewGrid)
            {
                mainView.Children.Clear();
                mainView.Children.Add(viewGrid.mainView);
            }
            Log.LogWrite += AddMessage;
            performDock.DataContext = statusBarGlobal;
            msgList.ItemsSource = Messagess;
            statusBar.DataContext = UIEvents.GetInstance().updateStatus;
        }

        public void ViewChanged(object sender, ViewChangedEvent e)
        {
            if (e.View.Index ==0)
                fpsState.DataContext = e.View;
        }

        private readonly Severity logLevel = (Severity)Enum.Parse(typeof(Severity), Settings.Default.LogLevel, ignoreCase: true);

        public ObservableCollection<Message> Messagess { get; set; } = new ObservableCollection<Message>();

        public void AddMessage(Message message)
        {
            if (message.Severity >= logLevel)
            {
                Messagess.Add(message);
                msgList.SelectedIndex = Messagess.Count - 1;
            }
        }


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



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("APPLICATION_LOADED", sender, e);
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
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

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            LambdaControl.Trigger("APPLICATION_DISPLAYED", sender, e);
            if (Maximize)
            {
                base.WindowState = WindowState.Maximized;
            }
        }

        public Panel GetConfigPanel(Side side)
        {
            return side switch
            {
                Side.MIDDLE => materialView,
                Side.BOTTOM => bottomView,
                Side.ACQUIRE => acquireView,
                Side.PROJECT => projectView,
                Side.REPORT => reportView,
                Side.ANALYSIS => analysisView,
                Side.PROCESS => proessView,
                _ => throw new Exception("top view not supported"),
            };
        }


        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                LambdaControl.Trigger("PHASE_CHECKED", sender, e);

                if (leftTab!=null&& leftTab.SelectedIndex != 0)
                {
                    switch (radioButton.Name)
                    {
                        case "RadioButton1":
                            leftTab.SelectedIndex = 1;
                            break;
                        case "RadioButton2":
                            leftTab.SelectedIndex = 2;
                            break;
                        case "RadioButton3":
                            leftTab.SelectedIndex = 3;
                            break;
                        case "RadioButton4":
                            leftTab.SelectedIndex = 4;
                            break;
                        case "RadioButton5":
                            leftTab.SelectedIndex = 5;
                            break;
                        default:
                            break;
                    }
                }



            }




        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton btn)
            {
                LambdaControl.Trigger(btn.IsChecked.GetValueOrDefault() ? "STOP_ALIVE" : "START_ALIVE", sender, e);
                btn.Content = (btn.IsChecked.GetValueOrDefault() ? "停止预览" : "预览");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleButton btn)
            {
                LambdaControl.Trigger(btn.IsChecked.GetValueOrDefault() ? "STOP_ACQUIRE" : "START_ACQUIRE", sender, e);
                btn.Content = (btn.IsChecked.GetValueOrDefault() ? "停止采集" : "开始采集");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("SNAPSHOT", sender, e);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger(multiMode ? "START_MULTI_MODE" : "STOP_MULTI_MODE", sender, e);
            multiMode = !multiMode;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger(multiChannel ? "START_MULTI_CHANNEL" : "START_MULTI_CHANNEL", sender, e);
            multiChannel = !multiChannel;
        }


        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("DF_CLICKED", sender, e);
        }




        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("SELECT_CLICKED", sender, e);
        }



        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("ZOOM_IN_CLICKED", sender, e);
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("ZOME_OUT_CLICKED", sender, e);
        }




        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            LambdaControl.Trigger("COLORBAR_CLICKED", sender, e);
        }


        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (IsLeftViewHidden)
            {
                ChangeLeftViewVisibility(visible: true);
            }
            if (IsMiddleViewHidden)
            {
                ChangeMiddleViewVisibility(visible: true);
            }
        }

        private void LeftSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (IsMiddleViewHidden)
            {
                ChangeMiddleViewVisibility(visible: true);
            }
            else
            {
                ChangeLeftViewVisibility(visible: false);
            }
        }

        private void MiddleSplitter_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ChangeMiddleViewVisibility(visible: false);
        }

        public void ChangeLeftViewVisibility(bool visible)
        {
            if (visible)
            {
                if (LeftViewWidth > 0.0)
                {
                    leftView.Width = new GridLength(LeftViewWidth, GridUnitType.Pixel);
                }
            }
            else
            {
                LeftViewWidth = leftView.ActualWidth;
                leftView.Width = new GridLength(0.0, GridUnitType.Auto);
            }
            ChangeColumnVisibility(0, visible);
            ChangeColumnVisibility(1, visible);
            IsLeftViewHidden = !visible;
        }

        public void ChangeMiddleViewVisibility(bool visible)
        {
            if (visible)
            {
                if (MiddleViewWidth > 0.0)
                {
                    middleView.Width = new GridLength(MiddleViewWidth, GridUnitType.Pixel);
                }
            }
            else if (middleView.Width.GridUnitType == GridUnitType.Pixel)
            {
                MiddleViewWidth = middleView.ActualWidth;
                middleView.Width = new GridLength(0.0, GridUnitType.Auto);
            }
            ChangeColumnVisibility(2, visible);
            ChangeColumnVisibility(3, visible);
            IsMiddleViewHidden = !visible;
        }

        private void ChangeColumnVisibility(int col, bool visible)
        {
            foreach (UIElement item in from UIElement i in stageAcquisition.Children
                                       where Grid.GetColumn(i) == col
                                       select i)
            {
                item.Visibility = ((!visible) ? Visibility.Collapsed : Visibility.Visible);
            }
        }
    }



}

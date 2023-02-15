using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Lambda.UI.Extension;
using UI.Control.Lib;
using Global.UserControls.DrawVisual;
using Lambda;
using System.IO;

namespace Global
{
    public partial class WindowData1
    {

        private void UIExtension()
        {
            TitleBarExtension();
            UpdateUIElement();
            AddHandleOfflineRegister();
            UpdateAcquireHeader();
        }

        private void TitleBarExtension()
        {
            Grid AncestorGrid = (Grid)mainwin.Content;
            Grid grid1 = (Grid)AncestorGrid.Children[0];
            StackPanel stackPanel = (StackPanel)grid1.Children[1];
            RadioButton config = (RadioButton)stackPanel.Children[0];
            RadioButton acquire = (RadioButton)stackPanel.Children[1];
            RadioButton process = (RadioButton)stackPanel.Children[2];
            RadioButton analysis = (RadioButton)stackPanel.Children[3];
            RadioButton report = (RadioButton)stackPanel.Children[4];
            process.Visibility = Visibility.Hidden;
            analysis.Visibility = Visibility.Hidden;
            report.Visibility = Visibility.Hidden;

            acquire.Checked += (s, e) =>
            {
              WindowData.GetInstance().IsAcquireShow();
            };

        }

        public void CheckProJectDevMode()
        {
            
            if (WindowData.GetInstance().setting.otherMode.DevelopMode == true)
            {
                WindowData.GetInstance().IsAcquireShow();
            }
        }
         
        public void UpdateUIElement()
        {
            VisualHelper.RegisterWindow(mainwin);

            Global.UserControls.DrawVisual.SplitButton splitButton = new Global.UserControls.DrawVisual.SplitButton();
            VisualHelper.ReplaceElement(splitButton, 25,mainwin);
            Global.UserControls.SplitButtonSelect splitButtonSelect = new UserControls.SplitButtonSelect();
            splitButtonSelect.Margin = new Thickness(3, 0, 3, 0);
            VisualHelper.ReplaceElement(splitButtonSelect, 51, mainwin);
            Global.UserControls.SplitButtonEraser splitButtonEraser = new UserControls.SplitButtonEraser();
            splitButtonEraser.Margin= new Thickness(3,0,3,0);
            VisualHelper.ReplaceElement(splitButtonEraser, 52, mainwin);
            
            ChangeControlSize(mainwin);
        }
        private void ChangeControlSize(Window mainwin)
        {
            VisualHelper.ResizeElement(95,25,24, mainwin);  
        }

        public void AddHandleOfflineRegister()
        {
            //Grid AncestorGrid = (Grid)mainwin.Content;
            //Grid grid1 = (Grid)AncestorGrid.Children[0];
            //StackPanel stackPanel = (StackPanel)grid1.Children[2];
            //Menu menu = (Menu)stackPanel.Children[0];
            //MenuItem menuItem1 = (MenuItem)menu.Items[1];
            //ItemCollection menuItems = menuItem1.Items;
            //foreach (MenuItem item in menuItems)
            //{
            //    if (item.Header.ToString() == "离线注册")
            //    {
            //        item.Click += (s, e) =>
            //        {
            //            MessageBox.Show("读取register.pkg文件");
            //            string path = Environment.CurrentDirectory;
            //            string path0 = Path.Combine(path, "register.pkg");
            //            string path1 = Path.Combine(path, "register");
            //            UserRegister.OffLineRegister.Registering(path,path0, path1);
            //        };
            //    }

            //}
        }

        private void UpdateAcquireHeader()
        {
            try
            {
                TabControl tabControl = (TabControl)mainwin.FindName("leftTab");    //采集配置 改为 采集设置
                TabItem tabItem = (TabItem)tabControl.Items[1];
                tabItem.Header = "采集设置";
            }
            catch
            {

            }
        }





        public void AddDevelopMode()
        {
            Grid AncestorGrid = (Grid)mainwin.Content;
            Grid grid1 = (Grid)AncestorGrid.Children[0];
            StackPanel stackPanel = (StackPanel)grid1.Children[2];
            Menu menu = (Menu)stackPanel.Children[0];
            MenuItem menuItem1 = (MenuItem)menu.Items[0];
            bool AddDevelopMode = false;
            ItemCollection menuItems = menuItem1.Items;



            foreach (var item in menuItems)
            {
                if (item is MenuItem menu1) 
                {
                    if (menu1.Header.ToString() == "开发模式")
                    {
                        menu1.Click += (s, e) =>
                        {
                            WindowData.GetInstance().setting.otherMode.DevelopMode = !WindowData.GetInstance().setting.otherMode.DevelopMode;
                            bool? isDevMode = WindowData.GetInstance().setting.otherMode.DevelopMode;
                            if (isDevMode == true)
                            {
                                WindowData.GetInstance().AcquireModule(true);
                            }
                            else
                            {
                                WindowData.GetInstance().AcquireModule(false);
                            }

                        };
                    }
                }
               

            }


        }

    }
}

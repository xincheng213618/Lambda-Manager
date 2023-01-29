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

namespace Global
{
    public partial class WindowData1
    {

        private void UIExtension()
        {
            TitleBarExtension();
            UpdateUIElement();
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
            ChangeControlSize(mainwin);
        }
        private void ChangeControlSize(Window mainwin)
        {
            VisualHelper.ResizeElement(95,25,24, mainwin);
        }
    }
}

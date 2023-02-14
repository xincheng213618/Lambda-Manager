using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Global
{
    public partial class WindowData1
    {


        public void ToolBarTopAddEvent()
        {

            ToolBarTopZoomAddEvent();

        }


        public void ToolBarTopZoomAddEvent()
        {
            WrapPanel topToolbar = (WrapPanel)mainwin.FindName("topToolbar");
            if (topToolbar == null)
                return;
            Button ButtonZoomOut = ((Button)topToolbar.Children[4]);
            Button ButtonZoomIn = ((Button)topToolbar.Children[5]);
            Button ScaleButton = (Button)topToolbar.Children[6];
            ButtonZoomOut.Click += (s, e) =>
            {
                inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ZoomOut();
            };
            ButtonZoomIn.Click += (s, e) =>
            {
                inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].ZoomIn();
            };
            ScaleButton.Click += (s, e) =>
            {
                WindowData.GetInstance().updateStatus.Ratio = 100;
            };

        }





        






    }
}

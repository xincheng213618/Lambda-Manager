using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Resources;

namespace Global.UserControls
{
    /// <summary>
    /// 定制鼠标图片
    /// </summary>
    public static class CusCursors
    {
        public static Cursor Ruler 
        { 
            get {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/cursor/Ruler.cur", UriKind.Relative));
                return new Cursor(sri.Stream,true);
            } 
        }

        public static Cursor Hold
        {
            get
            {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/cursor/hold.cur", UriKind.Relative));
                return new Cursor(sri.Stream, true);
            }
        }

        public static Cursor Eraser
        {
            get
            {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/cursor/Eraser.cur", UriKind.Relative));
                return new Cursor(sri.Stream, true);
            }
        }
        public static Cursor ZoomIn
        {
            get
            {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/cursor/zoomIn.cur", UriKind.Relative));
                return new Cursor(sri.Stream, true);
            }
        }
        public static Cursor ZoomOut
        {
            get
            {
                StreamResourceInfo sri = Application.GetResourceStream(new Uri("/Global;component/usercontrols/cursor/zoomOut.cur", UriKind.Relative));
                return new Cursor(sri.Stream, true);
            }
        }



    }
}

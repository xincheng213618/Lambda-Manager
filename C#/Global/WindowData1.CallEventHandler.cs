using ConfigBottomView;
using Lambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Global.UserControls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.IO;
using Global.UserControls.DrawVisual;

namespace Global
{
    /// <summary>
    /// 监听CallEventHandler事件
    /// </summary>
    /// 
    public class ContextMenuPar
    {
        public int status { get; set; }
        public int count { get; set; }
        public int mode { get; set; }
        public int mode1 { get; set; }
        public List<int> modes { get; set; }
    }
    public partial class WindowData1
    {
        public bool ACQUIRE { get; set; } = false;
        public bool ALIVE { get; set; } = false;
        public DrawInkMethod inkMethod = new DrawInkMethod();
        public Window mainwin = Application.Current.MainWindow;
        public  InkVisual[] inkVisuals = new InkVisual[6];
        public static ContextMenuPar contextMenuPar = new ContextMenuPar();
        public void AddImageConfident(Image image1, int viewindex)
        {
            
            InkVisual inkVisual = new InkVisual(viewindex, image1, ImageViewState.toolTop,profileModel);
            if (image1.Parent is Grid grid0)
            {
                try
                {
                    inkVisuals[viewindex] = inkVisual;
                    if (image1.Parent is Grid grid1)
                    {
                        Binding bindingW = new Binding();
                        bindingW.Source = image1;
                        bindingW.Path = new PropertyPath("ActualWidth");
                        inkVisual.SetBinding(Image.WidthProperty, bindingW);
                        Binding bindingH = new Binding();
                        bindingH.Source = image1;
                        bindingH.Path = new PropertyPath("ActualHeight");
                        inkVisual.SetBinding(Image.HeightProperty, bindingH);
                        grid1.Children.Add(inkVisual);
                        Grid.SetRow(inkVisual, 0);

                        
                    }
                    if (image1.Parent is Grid grid2)
                    {
                       
                        if (!(bool)ImageViewState.toolTop.DimensionChecked)
                        {
                            inkVisual.defaultDim.Visibility = Visibility.Hidden;
                        };


                   }
                }
                catch (Exception ex)
                {
                    LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
                }

            }

        }
    }
}

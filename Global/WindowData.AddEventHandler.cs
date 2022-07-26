using Global.Controls;
using Global.Mode;
using Lambda;
using Mode;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Global
{

    /// <summary>
    /// 注册AddEventHandler事件
    /// </summary>
    public partial class WindowData
    {
        private void AddEventHandler()
        {

            LambdaControl.AddLambdaEventHandler("UPDATE_STATUS1", OnUpdateStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_STAGE_MOVE", UPDATE_STAGE_MOVE, false);

            LambdaControl.AddLambdaEventHandler("UPDATE_WINDOWSTATUS", OnUpdateWindowStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_MULMSG", UpdateMulSummary, false);
            LambdaControl.AddLambdaEventHandler("ZOOM_IN_CLICKED", ZOOM_IN_CLICKED, false);
            LambdaControl.AddLambdaEventHandler("ZOME_OUT_CLICKED", ZOME_OUT_CLICKED, false);
            LambdaControl.AddLambdaEventHandler("SELECT_CLICKED", SELECT_CLICKED, false);

           
            //LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
            LambdaControl.AddLambdaEventHandler("TestDataEvent2", TestDataEvent2, false);

            LambdaControl.AddLambdaEventHandler("UpdateMulSummary", UpdateMulSummary, false);
            LambdaControl.AddLambdaEventHandler("IMAGE_VIEW_CREATED", IMAGE_VIEW_CREATED, false);

            LambdaControl.AddLambdaEventHandler("STOP_ALIVE", STOP_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("START_ALIVE", START_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
            LambdaControl.AddLambdaEventHandler("START_ACQUIRE", START_ACQUIRE, false);

            //控制直方图显示和隐藏
            LambdaControl.AddLambdaEventHandler("HistogramImageShow", HistogramImageShow, false);
            LambdaControl.AddLambdaEventHandler("seriesProjectManager111", seriesProjectManager, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_HISTOGRAM", UpdateHistogramModel, false);
        }

        private bool seriesProjectManager(object sender, EventArgs e)
        {
            Window mainwin = Application.Current.MainWindow;
            if (mainwin == null) return false;
            Grid grid = (Grid)mainwin.FindName("stageAcquisition");
            if (grid == null) return false;
            DockPanel dockPanel = (DockPanel)grid.Children[1];
            ToggleButton toggleButton = (ToggleButton)dockPanel.Children[0];
            if (toggleButton != null&& toggleButton.IsChecked == true)
            {
                toggleButton.IsChecked =false;
                toggleButton.Content = "预览";
                EventArgs eventArgs = new EventArgs();
                //LambdaControl.Trigger("STOP_ALIVE",this, eventArgs);

                // toggleButton.PerformClick();
            }
           
            return true;
   
        }

        //private void ToggleButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("1111");

        //}


        /// <summary>
        /// 更新位移台坐标
        /// </summary>
        private bool HistogramImageShow(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            int window = (int)eventData["window"];
            int flag = (int)eventData["flag"];

            if (window>=0&&window<= LambdaBottomViews.Length)
            {
                if (LambdaBottomViews[window] != null)
                {
                    if (flag == 1)
                    {
                        LambdaBottomViews[window].Visibility = Visibility.Visible;
                    }
                    else
                    {
                        LambdaBottomViews[window].Visibility = Visibility.Collapsed;
                    }
                }
            }



            return true;
        }

        public bool IsSelectImageView = true;
        public int SelectImageView = -1;

        private bool SELECT_CLICKED(object sender, EventArgs e)
        {
            IsSelectImageView = true;
            return true;
        }

        private bool ZOOM_IN_CLICKED(object sender, EventArgs e)
        {

            return true;
        }

        private bool ZOME_OUT_CLICKED(object sender, EventArgs e)
        {


            return true;
        }


        ConfigBottomView.BottomView[] LambdaBottomViews = new ConfigBottomView.BottomView[100];

        private bool TestDataEvent2(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
                if (eventData != null)
                {
                    int size = (int)eventData["size"];
                    IntPtr intPtr = (IntPtr)eventData["data"];
                    int[] aaa = new int[256];
                    Marshal.Copy(intPtr, aaa, 0, 256);
                    if (size >=0 && size < 100)
                    {
                        if (LambdaBottomViews[size] != null)
                            LambdaBottomViews[size].SetHistogram(aaa);
                    }
                }
            });

            return true;
        }

        /// <summary>
        /// 更新位移台坐标
        /// </summary>
        private bool UPDATE_STAGE_MOVE(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            mapModel.StageX = double.Parse(GetStringValue(eventData, "x"));
            mapModel.StageY = double.Parse(GetStringValue(eventData, "y"));
            return true;
        }



        private bool STOP_ALIVE(object sender, EventArgs e)
        {
            ALIVE = false;
            return true;
        }
        private bool START_ALIVE(object sender, EventArgs e)
        {
            ALIVE = true;
            return true;
        }

        private bool STOP_ACQUIRE(object sender, EventArgs e)
        {
            ACQUIRE = true;
            return true;
        }
        private bool START_ACQUIRE(object sender, EventArgs e)
        {
            ACQUIRE = false;
            return true;
        }

        private bool IMAGE_VIEW_CREATED(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            int viewdex = (int)eventData["view"];
            View view = LambdaControl.GetImageView(viewdex);
            if (view == null)
                return true;
            if (viewdex == 0&& FirstImage != null)
            {
                if (FirstImage.Parent is Grid gird)
                {
                    gird.Children.Remove(FirstImage);
                    FirstImage = null;
                }
            }
            AddImageConfident(view.Image,viewdex);

            return true;
        }

        public HistogramModel histogramModel = new HistogramModel();

        private bool UpdateHistogramModel(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            histogramModel.Max= GetStringValue(eventData, "Max");
            histogramModel.Min = GetStringValue(eventData, "Min");
            histogramModel.Mean = GetStringValue(eventData, "Mean");  
            histogramModel.Variance = GetStringValue(eventData, "Variance");       
            histogramModel.Gamma= GetStringValue(eventData, "Gamma");
            histogramModel.Outlier = GetStringValue(eventData, "Outlier");
            histogramModel.RangeMin =int.Parse(GetStringValue(eventData, "RangeMin")); 
            histogramModel.RangeMax = int.Parse(GetStringValue(eventData, "RangeMax"));

            return true;
        }







        public MulSummary mulSummary = new();


        private bool UpdateMulSummary(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            mulSummary.CollectionTimes = GetStringValue(eventData, "CollectionTimes");
            mulSummary.CollectionLayers = GetStringValue(eventData, "CollectionLayers");
            mulSummary.CollectionPoints = GetStringValue(eventData, "CollectionPoints");
            mulSummary.FluorescenceChannels = GetStringValue(eventData, "FluorescenceChannels");
            mulSummary.ViewModeCounts = GetStringValue(eventData, "ViewModeCounts");

            mulSummary.ImageSize = GetStringValue(eventData, "ImageSize");
            mulSummary.ImageNums = GetStringValue(eventData, "ImageNums");
            mulSummary.Storage = GetStringValue(eventData, "Storage");
            mulSummary.AllCollectionTime = GetStringValue(eventData, "AllCollectionTime");
            mulSummary.CameraWorkingTime = GetStringValue(eventData, "CameraWorkingTime");
            return true;
        }



        public UpdateStatus updateStatus = new();

        private bool OnUpdateStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);

            if (eventData == null)
                return false;
            updateStatus.ImageX = GetStringValue(eventData, "x");
            WindowMsg.StageX = int.Parse(updateStatus.ImageX[2..]);
            //mapModel.StageX = WindowMsg.StageX / 150;

            updateStatus.ImageY = GetStringValue(eventData, "y");
            WindowMsg.StageY = int.Parse(updateStatus.ImageY[2..]);
            //mapModel.StageY = WindowMsg.StageY / 150;

            updateStatus.ImageZ = GetStringValue(eventData, "z");
            WindowMsg.StageZ = int.Parse(updateStatus.ImageZ[2..]);

            updateStatus.ImageSize = GetStringValue(eventData, "size");
            updateStatus.imageFocus = GetStringValue(eventData, "focus");
            updateStatus.CreateTime = GetStringValue(eventData, "createTime");
            string frameIndex = GetStringValue(eventData, "frameIndex");
            if (frameIndex != null)
            {
                updateStatus.FrameIndex = int.Parse(frameIndex);

            }

            string totalFrame = GetStringValue(eventData, "totalFrame");
            if (totalFrame != null)
            {
                try
                {
                    updateStatus.TotalFrame = int.Parse(totalFrame);
                }
                catch
                {
                    updateStatus.TotalFrame = 0;
                }
            }

            updateStatus.TimeElapsed = GetStringValue(eventData, "timeElapsed");
            updateStatus.TotalTime = GetStringValue(eventData, "totalTime");
            string sliceIndex = GetStringValue(eventData, "sliceIndex");
            if (sliceIndex != null)
            {
                updateStatus.SliceIndex = int.Parse(sliceIndex);
            }
            string totalSlice = GetStringValue(eventData, "totalSlice");
            if (totalSlice != null)
            {
                updateStatus.TotalSlice = int.Parse(totalSlice);
            }
            updateStatus.ZTop = GetStringValue(eventData, "zTop");
            updateStatus.ZCurrent = GetStringValue(eventData, "zCurrent");
            updateStatus.ZBottom = GetStringValue(eventData, "zBottom");
            updateStatus.Ratio = GetStringValue(eventData, "ratio");
            updateStatus.FpsState = GetStringValue(eventData, "fps");

            return true;
        }


        private bool OnUpdateWindowStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            updateStatus.Window = GetStringValue(eventData, "windowstatus");
            List<int> ints = new List<int> { };
            for (int j = 0; j < updateStatus.Window.Length; j++)
            {
                ints.Add(int.Parse(updateStatus.Window.Substring(j, 1)));
            }
            try
            {
                asyncAdd(ints);
            }
            catch(Exception ex)
            {


                Lambda.LambdaControl.Log(new Message { Severity = Severity.INFO, Text = ex.Message });
            }
           
            return true;
        }

        private async void asyncAdd(List<int> ints)
        {
            for (int i = 1; i < ints.Count; i++)
            {
                await Task.Delay(800);
                var image = drawingCanvass[i];
                if (image != null)
                {
                    ContextMenu menu = new ContextMenu();
                    menu = MenuItemAdd(menu, i, ints[i]);
                    image.ContextMenu = menu;
                }
            }
        }
        private ContextMenu MenuItemAdd(ContextMenu contextMenu, int a, int check)
        {
            RadioMenuItem menuItem1 = new RadioMenuItem() { Header = "明场" };
            RadioMenuItem menuItem2 = new RadioMenuItem() { Header = "暗场" };
            RadioMenuItem menuItem3 = new RadioMenuItem() { Header = "莱茵伯格" };
            RadioMenuItem menuItem4 = new RadioMenuItem() { Header = "相差" };
            RadioMenuItem menuItem5 = new RadioMenuItem() { Header = "差分" };
            RadioMenuItem menuItem6 = new RadioMenuItem() { Header = "定量相位" };

            List<RadioMenuItem> menuItem1s = new List<RadioMenuItem> { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6 };
            for (int i = 0; i < menuItem1s.Count; i++)
            {
                if (check == i)
                    menuItem1s[i].IsChecked = true;
            }

            menuItem1.Click += delegate
            {
                menuItem1.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 0 } });
            };
            menuItem2.Click += delegate
            {
                menuItem2.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 1 } });
            };

            menuItem3.Click += delegate
            {
                menuItem3.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 2 } });

            };
            menuItem4.Click += delegate
            {
                menuItem4.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 3 } });
            };
            menuItem5.Click += delegate
            {
                menuItem5.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 4 } });
            };
            menuItem6.Click += delegate
            {
                menuItem6.IsChecked = true;
                LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "window", a }, { "mode", 5 } });

            };

            for (int i = 0; i < menuItem1s.Count; i++)
            {
                contextMenu.Items.Add(menuItem1s[i]);
            }
            return contextMenu;
        }


        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        public static extern void RtlMoveMemory(IntPtr Destination, IntPtr Source, uint Length);

        public Image image = new Image();

        private bool TestDataEvent(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
                if (eventData != null)
                {
                    int size = (int)eventData["size"];

                    IntPtr intPtr = (IntPtr)eventData["data"];
                    //byte[] aaa = new byte[size];
                    //Marshal.Copy(intPtr, aaa, 0, size);
                    //GCHandle pinnedArray = GCHandle.Alloc(aaa, GCHandleType.Pinned);
                    //IntPtr pointer = pinnedArray.AddrOfPinnedObject();
                    //pinnedArray.Free();

                    if (image.Source is WriteableBitmap writeableBitmap1)
                    {
                        Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap1.Width, (int)writeableBitmap1.Height);
                        writeableBitmap1.WritePixels(sourceRect, intPtr, (int)size, (int)writeableBitmap1.Width * writeableBitmap1.Format.BitsPerPixel / 8);

                    }
                    else
                    {
                        WriteableBitmap writeableBitmap = new WriteableBitmap(300, 300, 96.0, 96.0, PixelFormats.Bgr24, null);
                        RtlMoveMemory(writeableBitmap.BackBuffer, intPtr, (uint)size);
                        writeableBitmap.Lock();
                        writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
                        writeableBitmap.Unlock();
                        image.Source = writeableBitmap;
                    }



                }
            });

            return true;
        }




        private static string? GetStringValue(Dictionary<string, object>? data, string key)
        {
            if (data == null)
            {
                return null;
            }
            if (data!.TryGetValue(key, out var value) && value is string str)
            {
                return str;
            }
            return null;
        }




    }
}

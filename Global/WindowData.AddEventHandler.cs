using Global.Controls;
using Global.Mode;
using Lambda;
using Mode;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
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
            //LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
            LambdaControl.AddLambdaEventHandler("UpdateMulSummary", UpdateMulSummary, false);
            LambdaControl.AddLambdaEventHandler("IMAGE_VIEW_CREATED", IMAGE_VIEW_CREATED, false);

            LambdaControl.AddLambdaEventHandler("STOP_ALIVE", STOP_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("START_ALIVE", START_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
            LambdaControl.AddLambdaEventHandler("START_ACQUIRE", START_ACQUIRE, false);  
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


        public static Grid[] gridsList = new Grid[100];

        private static Grid GetNewGrid(Image image)
        {
            Grid grid = new Grid()
            {
                Margin = new Thickness(2, 2, 2, 2),
            };

            grid.Children.Add(image);
            return grid;
        }
        private static readonly int[] defaultViewIndexMap = new int[100]
{
        0, 1, 4, 9, 16, 25, 36, 49, 64, 81,
        2, 3, 5, 10, 17, 26, 37, 50, 65, 82,
        6, 7, 8, 11, 18, 27, 38, 51, 66, 83,
        12, 13, 14, 15, 19, 28, 39, 52, 67, 84,
        20, 21, 22, 23, 24, 29, 40, 53, 68, 85,
        30, 31, 32, 33, 34, 35, 41, 54, 69, 86,
        42, 43, 44, 45, 46, 47, 48, 55, 70, 87,
        56, 57, 58, 59, 60, 61, 62, 63, 71, 88,
        72, 73, 74, 75, 76, 77, 78, 79, 80, 89,
        90, 91, 92, 93, 94, 95, 96, 97, 98, 99
};

        private static void GridSort(Grid[] GridLists)
        {
            Window mainwin = Application.Current.MainWindow;

            Grid mainView = (Grid)mainwin.FindName("mainView");

            mainView.Children.Clear();
            mainView.ColumnDefinitions.Clear();
            mainView.RowDefinitions.Clear();

            int newlist = 0;
            for (int i = 0; i < GridLists.Length; i++)
            {
                if (GridLists[i] != null)
                {
                    Grid grid = GridLists[i];
                    int location = Array.IndexOf(defaultViewIndexMap, newlist);
                    int row = (location / 10);
                    int col = (location % 10);
                    if (mainView.ColumnDefinitions.Count <= col)
                    {
                        ColumnDefinition columnDefinition = new ColumnDefinition() { Width = (GridLength)gridLengthConverter.ConvertFrom("*") };
                        mainView.ColumnDefinitions.Add(columnDefinition);
                    }
                    if (mainView.RowDefinitions.Count <= row)
                    {
                        RowDefinition rowDefinition = new RowDefinition() { Height = (GridLength)gridLengthConverter.ConvertFrom("*") };
                        mainView.RowDefinitions.Add(rowDefinition);
                    }

                    grid.SetValue(Grid.RowProperty, row);
                    grid.SetValue(Grid.ColumnProperty, col);
                    mainView.Children.Add(grid);
                    newlist++;
                }
            }
        }



        private bool IMAGE_VIEW_CREATED(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            int viewdex = (int)eventData["view"];
            View view = LambdaControl.GetImageView(viewdex);
            if (view.Image.Parent is Grid grid)
            {
                grid.Children.Remove(view.Image);
                gridsList[viewdex] = GetNewGrid(view.Image);
            }

            GridSort(gridsList);
            AddImageConfident(view.Image);

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
            asyncAdd(ints);
            return true;
        }

        private async void asyncAdd(List<int> ints)
        {
            for (int i = 1; i < ints.Count; i++)
            {
                await Task.Delay(800);
                Image image = LambdaControl.GetImageView(i).Image;
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
            MenuItem1 menuItem1 = new MenuItem1() { Header = "明场" };
            MenuItem1 menuItem2 = new MenuItem1() { Header = "暗场" };
            MenuItem1 menuItem3 = new MenuItem1() { Header = "莱茵伯格" };
            MenuItem1 menuItem4 = new MenuItem1() { Header = "相差" };
            MenuItem1 menuItem5 = new MenuItem1() { Header = "差分" };
            MenuItem1 menuItem6 = new MenuItem1() { Header = "定量相位" };
            List<MenuItem1> menuItem1s = new List<MenuItem1> { menuItem1, menuItem2, menuItem3, menuItem4, menuItem5, menuItem6 };
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



                    //Window window = new Window();
                    //window.Content = image;
                    //window.Show();

                    //using (System.IO.MemoryStream ms = new System.IO.MemoryStream(aaa))
                    //{
                    //    BitmapImage image = new BitmapImage();
                    //    image.BeginInit();
                    //    image.StreamSource = ms;
                    //    image.EndInit();

                    //    BitmapEncoder encoder = new PngBitmapEncoder();
                    //    encoder.Frames.Add(BitmapFrame.Create(image));

                    //    using (var fileStream = new System.IO.FileStream("1.jpg", System.IO.FileMode.Create))
                    //    {
                    //        encoder.Save(fileStream);
                    //    }
                    //}
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

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
    public partial class WindowData
    {
        private void AddEventHandler()
        {
            LambdaControl.AddLambdaEventHandler("UPDATE_STATUS1", OnUpdateStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_WINDOWSTATUS", OnUpdateWindowStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_MULMSG", OnUpdateWindowStatus, false);
            LambdaControl.AddLambdaEventHandler("TestDataEvent", TestDataEvent, false);
            LambdaControl.AddLambdaEventHandler("UpdateMulSummary", UpdateMulSummary, false);
            LambdaControl.AddLambdaEventHandler("IMAGE_VIEW_CREATED", IMAGE_VIEW_CREATED, false);

            LambdaControl.AddLambdaEventHandler("STOP_ALIVE", STOP_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("START_ALIVE", START_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
            LambdaControl.AddLambdaEventHandler("START_ACQUIRE", START_ACQUIRE, false);  
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
            updateStatus.ImageY = GetStringValue(eventData, "y");
            WindowMsg.StageY = int.Parse(updateStatus.ImageY[2..]);
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

        public ImageBrush image = new ImageBrush();

        private bool TestDataEvent(object sender, EventArgs e)
        {
            //MessageBox.Show("TestDataEvent Acvtive");
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            //MessageBox.Show(eventData.Count.ToString());
            if (eventData != null)
            {
                int size = (int)eventData["size"];
                //MessageBox.Show(size.ToString());

                IntPtr intPtr = (IntPtr)eventData["data"];
                //byte[] aaa = new byte[size];
                //Marshal.Copy(intPtr, aaa, 0, size);

                //GCHandle pinnedArray = GCHandle.Alloc(aaa, GCHandleType.Pinned);
                //IntPtr pointer = pinnedArray.AddrOfPinnedObject();
                //pinnedArray.Free();

                if (image.ImageSource is WriteableBitmap writeableBitmap1)
                {
                    Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap1.Width, (int)writeableBitmap1.Height);
                    writeableBitmap1.WritePixels(sourceRect, intPtr, (int)size, (int)writeableBitmap1.Width * writeableBitmap1.Format.BitsPerPixel / 8);

                }
                else
                {
                    WriteableBitmap writeableBitmap = new WriteableBitmap(64, 48, 96.0, 96.0, PixelFormats.Bgr24, null);
                    RtlMoveMemory(writeableBitmap.BackBuffer, intPtr, (uint)size);
                    writeableBitmap.Lock();
                    writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
                    writeableBitmap.Unlock();
                    image.ImageSource = writeableBitmap;
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

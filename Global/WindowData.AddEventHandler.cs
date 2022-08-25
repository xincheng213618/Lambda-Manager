using Global.Controls;
using Global.Mode;
using Lambda;
using Mode;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Global.Common.Extensions;
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
            LambdaControl.AddLambdaEventHandler("STAGE_INI_CLOSE", StaheIniClose, false);

            LambdaControl.AddLambdaEventHandler("UPDATE_WINDOWSTATUS", OnUpdateWindowStatus, false);
            LambdaControl.AddLambdaEventHandler("ZOOM_IN_CLICKED", ZOOM_IN_CLICKED, false);
            LambdaControl.AddLambdaEventHandler("ZOME_OUT_CLICKED", ZOME_OUT_CLICKED, false);
            LambdaControl.AddLambdaEventHandler("SELECT_CLICKED", SELECT_CLICKED, false);

            LambdaControl.AddLambdaEventHandler("UPDATE_MUL_SUMMARY", UpdateMulSummary, false);

            LambdaControl.AddLambdaEventHandler("IMAGE_VIEW_CREATED", IMAGE_VIEW_CREATED, false);

            LambdaControl.AddLambdaEventHandler("MUL_ZSTEP", Mul_ZStep, false);
            LambdaControl.AddLambdaEventHandler("MUL_ZSTART", Mul_ZStart, false);
            LambdaControl.AddLambdaEventHandler("MUL_ZEND", Mul_ZEnd, false);
            LambdaControl.AddLambdaEventHandler("MUL_TIME_INTERVAL", Mul_TInterval, false);

            LambdaControl.AddLambdaEventHandler("STOP_ALIVE", STOP_ALIVE, false);
            
            LambdaControl.AddLambdaEventHandler("START_ALIVE", START_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
            LambdaControl.AddLambdaEventHandler("START_ACQUIRE", START_ACQUIRE, false);


            //预览关闭
            LambdaControl.AddLambdaEventHandler("PREVIEW_CLOSE", seriesProjectManager, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_HISTOGRAM", UpdateHistogramModel, false);

            //采集关闭
            LambdaControl.AddLambdaEventHandler("COLLECTION_COMPLETED", CollectionCompleted, false);
        }

        private bool StaheIniClose(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                WaitContorl.GetInstance().Hidden();
            });
            return true;
        }

        private bool CollectionCompleted(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Window mainwin = Application.Current.MainWindow;
                if (mainwin != null)
                {
                    Grid grid = (Grid)mainwin.FindName("stageAcquisition");
                    if (grid != null)
                    {
                        DockPanel dockPanel = (DockPanel)grid.Children[1];
                        StackPanel stackPanel = (StackPanel)dockPanel.Children[1];
                        ToggleButton toggleButton = (ToggleButton)stackPanel.Children[0];

                        if (toggleButton != null && toggleButton.IsChecked == true)
                        {
                            toggleButton.IsChecked = false;
                            toggleButton.Content = "开始采集";
                        }
                    }

                }

                ACQUIRE = false;

            });
            return true;
        }


       

        private bool seriesProjectManager(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                Window mainwin = Application.Current.MainWindow;
                if (mainwin != null)
                {
                    Grid grid = (Grid)mainwin.FindName("stageAcquisition");
                    if (grid != null)
                    {
                        DockPanel dockPanel = (DockPanel)grid.Children[1];
                        ToggleButton toggleButton = (ToggleButton)dockPanel.Children[0];
                        if (toggleButton != null && toggleButton.IsChecked == true)
                        {
                            toggleButton.IsChecked = false;
                            toggleButton.Content = "预览";
                            EventArgs eventArgs = new EventArgs();
                        }
                    }
                }

            });

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

        /// <summary>
        /// 更新位移台坐标
        /// </summary>
        private bool UPDATE_STAGE_MOVE(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            mapModel.StageX = double.Parse(eventData.GetString("x"));
            mapModel.StageY = double.Parse(eventData.GetString("y"));
            return true;
        }



        private bool STOP_ALIVE(object sender, EventArgs e)
        {
            ALIVE = false;
            return true;
        }
        private bool Mul_ZStep(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            MulDimensional.Zstep = int.Parse(eventData.GetString("mulZstep"));
            return true;

        }
        private bool Mul_ZStart(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            MulDimensional.ZStart = int.Parse(eventData.GetString("mulZStart"));
            return true;

        }
        private bool Mul_ZEnd(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            MulDimensional.ZEnd = int.Parse(eventData.GetString("mulZEnd"));
            return true;

        }
        private bool Mul_TInterval(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            int time = int.Parse(eventData.GetString("value"));
            string mode = eventData.GetString("mode");

            //MessageBox.Show("循环间隔预计" + time.ToString()+"秒","信息提示",MessageBoxButton.OK,MessageBoxImage.Information);
            string message = "循环间隔预计" + time.ToString() + mode;


            var r = Global.UserControls.MessageBox1.ShowDialog(message);
            if (r.IsYes)
            { 
                LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 1 } });
            }
            else
            {
                LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 0 } });
            }
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
            AddImageConfident(view.Image, viewdex);
            return true;
        }

        public HistogramModel histogramModel = new HistogramModel();
        public ProfileModel profileModel = new ProfileModel();

        private bool UpdateHistogramModel(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;


            histogramModel.Max = eventData.GetString("Max");
            histogramModel.HalfMax = int.Parse(eventData.GetString("Max")) / 2;
            histogramModel.Min = eventData.GetString("Min");
            histogramModel.Mean = eventData.GetString("Mean");
            histogramModel.Variance = eventData.GetString("Variance");
            //histogramModel.Gamma= eventData.GetString("Gamma");
            histogramModel.Outlier = eventData.GetString("Outlier");
            histogramModel.RangeMin = int.Parse(eventData.GetString("RangeMin"));
            histogramModel.RangeMax = int.Parse(eventData.GetString("RangeMax"));
            
            return true;
        }







        public MulSummary mulSummary = new();


        private bool UpdateMulSummary(object sender, EventArgs e)
        {

            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            Application.Current.Dispatcher.Invoke(delegate
            {
                mulSummary.CollectionTimes = eventData.GetString("CollectionTimes"); 
                mulSummary.CollectionLayers = eventData.GetString("CollectionLayers");
                mulSummary.CollectionPoints = eventData.GetString("CollectionPoints");
                mulSummary.FluorescenceChannels = eventData.GetString("FluorescenceChannels");
                mulSummary.ViewModeCounts = eventData.GetString("ViewModeCounts");

                mulSummary.ImageSize = eventData.GetString("ImageSize");
                mulSummary.ImageNums = eventData.GetString("ImageNums");
                mulSummary.Storage = eventData.GetString("Storage");
                mulSummary.AllCollectionTime = eventData.GetString("AllCollectionTime");
                mulSummary.CameraWorkingTime = eventData.GetString("CameraWorkingTime");
            });

            return true;
        }



        public UpdateStatus updateStatus = new();

        private bool OnUpdateStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);

            if (eventData == null)
                return false;
            updateStatus.ImageX = eventData.GetString("x");
            WindowMsg.StageX = int.Parse(updateStatus.ImageX[2..]);

            updateStatus.ImageY = eventData.GetString("y");
            WindowMsg.StageY = int.Parse(updateStatus.ImageY[2..]);

            updateStatus.ImageZ = eventData.GetString("z");
            WindowMsg.StageZ = int.Parse(updateStatus.ImageZ[2..]);

            updateStatus.ImageSize = eventData.GetString("size");
            updateStatus.imageFocus = eventData.GetString("focus");
            updateStatus.CreateTime = eventData.GetString("createTime");
            string frameIndex = eventData.GetString("frameIndex");
            if (frameIndex != null)
            {
                updateStatus.FrameIndex = int.Parse(frameIndex);

            }

            string totalFrame = eventData.GetString("totalFrame");
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

            updateStatus.TimeElapsed = eventData.GetString("timeElapsed");
            updateStatus.TotalTime = eventData.GetString("totalTime");
            string sliceIndex = eventData.GetString("sliceIndex");
            if (sliceIndex != null)
            {
                updateStatus.SliceIndex = int.Parse(sliceIndex);
            }
            string totalSlice = eventData.GetString("totalSlice");
            if (totalSlice != null)
            {
                updateStatus.TotalSlice = int.Parse(totalSlice);
            }
            updateStatus.ZTop = eventData.GetString("zTop");
            updateStatus.ZCurrent = eventData.GetString("zCurrent");
            updateStatus.ZBottom = eventData.GetString("zBottom");
            updateStatus.Ratio = eventData.GetString("ratio");
            updateStatus.FpsState = eventData.GetString("fps");

            return true;
        }


        private bool OnUpdateWindowStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            updateStatus.Window = eventData.GetString("windowstatus");

            try
            {
                foreach (var item in updateStatus.Window.Split(";"))
                {
                    string[] views = item.Split(",");
                    if (views.Length == 2)
                    {
                        if (int.TryParse(views[0], out int value))
                        {
                            List<int> ints = new List<int> { };
                            for (int j = 0; j < views[1].Length; j++)
                                ints.Add(int.Parse(views[1].Substring(j, 1)));


                            if (ViewContentMenuCache.ContainsKey(value))
                                ViewContentMenuCache[value] = ints;
                            else
                                ViewContentMenuCache.Add(value, ints);

                            Application.Current.Dispatcher.Invoke(delegate
                            {
                                AddViewContentMenu(value, ints);
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }




        Dictionary<int, List<int>> ViewContentMenuCache = new Dictionary<int, List<int>>();
        List<string> ViewContentMenuContent = new List<string>() { "明场", "暗场", "莱茵伯格", "差分", "相位", "相差" };

        private void AddViewContentMenu(int view, List<int> ints)
        {
            if (view >= 0 && view <= inkVisuals.Length && inkVisuals[view] != null)
            {
                ContextMenu contextMenu = new ContextMenu();
                List<RadioMenuItem> menuItem1s = new List<RadioMenuItem>();

                bool IsLeft = true;
                for (int i = 0; i < ViewContentMenuContent.Count; i++)
                {
                    RadioMenuItem radioMenuItem = new RadioMenuItem() { Header = ViewContentMenuContent[i] };
                    int mode = i;
                    radioMenuItem.Click += delegate
                    {
                        radioMenuItem.IsChecked = true;
                        if (ints.Count == 1)
                        {
                            LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "type", 0 }, { "window", view }, { "mode1", mode }, { "mode2", -1 } });
                        }
                        else if (ints.Count == 2)
                        {
                            ints[IsLeft ? 0 : 1] = mode;
                            LambdaControl.Trigger("VIEW_WINDOW", this, new Dictionary<string, object>() { { "type", (int)ViewWindowMode.DOUBLE_WINDOW }, { "window", view }, { "mode1", ints[0] }, { "mode2", ints[1] } });
                        }
                    };

                    contextMenu.Items.Add(radioMenuItem);
                    menuItem1s.Add(radioMenuItem);
                }

                InkCanvas drawingInkCanvas = inkVisuals[view].inkCanvas;
                drawingInkCanvas.ContextMenu = contextMenu;
                if (ints.Count == 1)
                {
                    menuItem1s[ints[0]].IsChecked = true;
                }
                else if (ints.Count == 2)
                {
                    drawingInkCanvas.PreviewMouseMove += delegate
                    {
                        if (Mouse.GetPosition(drawingInkCanvas).X < drawingInkCanvas.ActualWidth / 2)
                        {
                            IsLeft = true;
                            menuItem1s[ints[0]].IsChecked = true;
                        }
                        else
                        {
                            IsLeft = false;
                            menuItem1s[ints[1]].IsChecked = true;
                        }
                    };
                }
            }
        }





    }
}

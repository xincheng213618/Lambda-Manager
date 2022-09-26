using Global.Common.Controls;
using Global.Common.Extensions;
using Global.Mode;
using Global.Mode.Config;
using Global.UserControls.SeriesMap;
using Lambda;
using Mode;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

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
            //加载进度
            LambdaControl.AddLambdaEventHandler("UPDATE_PROGRESSBAR", UpdateProgressBarModel, false);
            // AUTO camera setting
            LambdaControl.AddLambdaEventHandler("UPDATE_AUTO_CAMERA", UpdateAutoCameraSetting, false);
            // multiPointsReback
            LambdaControl.AddLambdaEventHandler("MULTI_COLLECTION_POINT", MultiCollectionP, false);

           

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
            updateStatus.FpsEnable = true;
            histogramModel.MoveEnable = true;
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
            string message = "循环间隔预计" + time.ToString() + mode+"大于设定循环间隔,是否启动无间隔循环采集";
            if (!MulDimensional.TIntervalEnable)
            {
                int i = (int)System.Windows.MessageBox.Show(message, "信息提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);

                if (i == 1)
                {
                    MulDimensional.TInterval = ">>";
                    MulDimensional.TIntervalEnable = true;
                    LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 1 } });
                }
                else
                {
                    LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 0 } });
                }

            }
            else
            {
                LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 1 } });
            }



            return true;


            //var r = Global.UserControls.MessageBox1.ShowDialog(message);
            //if (r.IsYes)
            //{

            //    MulDimensional.TInterval = ">>";
            //    MulDimensional.TIntervalEnable = true;
            //    LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 1 } });

            //}
            //else
            //{
            //    LambdaControl.Trigger("MUL_TIME_INTERVAL_STATE", this, new Dictionary<string, object> { { "mode", 0 } });
            //}
            //return true;

        }







        private bool START_ALIVE(object sender, EventArgs e)
        {
            ALIVE = true;
            updateStatus.FpsEnable = false;
            histogramModel.MoveEnable = false;
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
        public ProgressBarModel progressBarModel = new ProgressBarModel();
       // MapWindow mapWindow = new MapWindow();

        private bool UpdateProgressBarModel(object sender, EventArgs e)
        {
           
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
          
            if (eventData == null)
                return false;

            if (!string.IsNullOrEmpty(eventData.GetString("Min")))
                progressBarModel.MiniMum = double.Parse(eventData.GetString("Min"));
            if (!string.IsNullOrEmpty(eventData.GetString("Max")))
                progressBarModel.MaxMum = double.Parse(eventData.GetString("Max"));
            if (!string.IsNullOrEmpty(eventData.GetString("Current")))
                progressBarModel.Current = double.Parse(eventData.GetString("Current"));
            if (!string.IsNullOrEmpty(eventData.GetString("LoadingMax")))
                progressBarModel.LoadingMax = double.Parse(eventData.GetString("LoadingMax"));
            if (!string.IsNullOrEmpty(eventData.GetString("MinZ")))
                progressBarModel.MiniMumZ = double.Parse(eventData.GetString("MinZ"));
            if (!string.IsNullOrEmpty(eventData.GetString("MaxZ")))
                progressBarModel.MaxMumZ = double.Parse(eventData.GetString("MaxZ"));
            if (!string.IsNullOrEmpty(eventData.GetString("CurrentZ")))
                progressBarModel.CurrentZ = double.Parse(eventData.GetString("CurrentZ"));
            if (!string.IsNullOrEmpty(eventData.GetString("LoadingMaxZ")))
                progressBarModel.LoadingMaxZ = double.Parse(eventData.GetString("LoadingMaxZ"));


            return true;
        }

        // UPDATE AUTO CAMERA SETTING

        private bool UpdateAutoCameraSetting(object sender, EventArgs e)
        {

            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            int Mode;
            if (eventData == null)
                return false;
            // Mode = eventData.GetString("mode");
            Mode = OperatingMode.SelectViewMode;


            switch (Mode)
            {
                
                case 0: 
                   
                    OperatingMode.BrightField.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")),1);

                    break;
                case 1:
                    OperatingMode.DarkField.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")), 1);
                    break;
                case 3:
                    OperatingMode.ReliefContrast.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")), 1);
                    break;

                case 5:
                    OperatingMode.PhaseContrast.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")), 1);
                    break;
                case 4:
                    OperatingMode.QuantitativePhase.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")), 1);
                    break;
                case 2:
                    OperatingMode.Reinberg.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")), 1);
                    break;

            }

            return true;
        }



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

            //other mode
            if (!string.IsNullOrEmpty(eventData.GetString("RangeMin")))
            {
                histogramModel.RangeMin = int.Parse(eventData.GetString("RangeMin"));
            }
            if (!string.IsNullOrEmpty(eventData.GetString("RangeMax")))
            {
                histogramModel.RangeMax = int.Parse(eventData.GetString("RangeMax"));
            }
          

            // phase histogram
            if (!string.IsNullOrEmpty(eventData.GetString("RangeMinP")))
                {
                int rangeMinP = int.Parse(eventData.GetString("RangeMinP"));
                histogramModel.RangeMinP = (double)(rangeMinP - 127);
               }
            if (!string.IsNullOrEmpty(eventData.GetString("RangeMaxP")))
            {
                int rangeMaxP = int.Parse(eventData.GetString("RangeMaxP"));

                histogramModel.RangeMaxP = (double)(rangeMaxP - 128);
            }
               
           
            return true;
        }







        public MulSummary mulSummary = new();
        // public MapWindow mapWindow = new MapWindow();
        

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
        public class MultiPoints
        {
            public List<List<int>> Points { get; set; } = new List<List<int>>();
        }

        private bool MultiCollectionP(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            Application.Current.Dispatcher.Invoke(delegate
            {
                string multiCollectJson = eventData.GetString("MultiCollectionP");
                if (multiCollectJson != null)
                {
                    MultiPoints testMean = JsonSerializer.Deserialize<MultiPoints>(multiCollectJson);
                    List<List<int>> points = testMean.Points;
                   // MessageBox.Show(points.Count.ToString());
                    MapWindow.SeriesPoints.Clear();
                   // List<Point> points2 = new List<Point>();
                    foreach (var point in points)
                    {
                        Point point1 = new Point { X = point[0], Y = point[1] };

                        int x = (int)Math.Floor(point1.X / 8);
                        int y = (int)Math.Floor(point1.Y / 6);

                        Point selectedPoint = new Point(x * 8, y * 6);


                        MapWindow.SeriesPoints.Add(selectedPoint);
                    }
                   // MessageBox.Show(MapWindow.SeriesPoints.Count.ToString());
                    foreach (Window w in Application.Current.Windows)
                    {
                        if (w is MapWindow  mapWindow)
                        {

                            mapWindow.MapUpdate();
                        }
                    
                    }
                    
                };
            });



            return true;
        }

       









        public UpdateStatus updateStatus = new();

        private bool OnUpdateStatus(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);

                if (eventData == null)
                    return false;

                if (!string.IsNullOrEmpty(eventData.GetString("BF")))
                {
                    updateStatus.BFToggEnable = bool.Parse(eventData.GetString("BF"));
                }
                if (!string.IsNullOrEmpty(eventData.GetString("DF")))
                {
                    updateStatus.DFToggEnable = bool.Parse(eventData.GetString("DF"));
                }
                if (!string.IsNullOrEmpty(eventData.GetString("RI")))
                {
                    updateStatus.RIToggEnable = bool.Parse(eventData.GetString("RI"));
                }
                if (!string.IsNullOrEmpty(eventData.GetString("DP")))
                {
                    updateStatus.DPToggEnable = bool.Parse(eventData.GetString("DP"));
                }
                if (!string.IsNullOrEmpty(eventData.GetString("QP")))
                {
                    updateStatus.QPToggEnable = bool.Parse(eventData.GetString("QP"));
                }
                if (!string.IsNullOrEmpty(eventData.GetString("PC")))
                {
                    updateStatus.PCToggEnable = bool.Parse(eventData.GetString("PC"));
                }
                //MessageBox.Show("1111");

                updateStatus.ImageX = eventData.GetString("x");
                updateStatus.ImageY = eventData.GetString("y");
                updateStatus.ImageZ = eventData.GetString("z");
                if (!string.IsNullOrEmpty(updateStatus.ImageX))
                {
                    WindowMsg.StageX = int.Parse(updateStatus.ImageX[2..]);
                }
                if (!string.IsNullOrEmpty(updateStatus.ImageY))
                {
                    WindowMsg.StageY = int.Parse(updateStatus.ImageY[2..]);
                }
                if (!string.IsNullOrEmpty(updateStatus.ImageZ))
                {
                    WindowMsg.StageZ = int.Parse(updateStatus.ImageZ[2..]);
                }

                updateStatus.ImageSize = eventData.GetString("size");
                updateStatus.imageFocus = eventData.GetString("focus");
                updateStatus.CreateTime = eventData.GetString("createTime");
               
                string frameIndex = eventData.GetString("frameIndex");
                if (!string.IsNullOrEmpty(frameIndex))
                {
                    updateStatus.FrameIndex = int.Parse(frameIndex);
                }

                string totalFrame = eventData.GetString("totalFrame");
                if (!string.IsNullOrEmpty(totalFrame))
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
                if (!string.IsNullOrEmpty(sliceIndex))
                {
                    updateStatus.SliceIndex = int.Parse(sliceIndex);
                }
                string totalSlice = eventData.GetString("totalSlice");
                if (!string.IsNullOrEmpty(totalSlice))
                {
                    updateStatus.TotalSlice = int.Parse(totalSlice);
                }
                updateStatus.ZTop = eventData.GetString("zTop");
                updateStatus.ZCurrent = eventData.GetString("zCurrent");
                updateStatus.ZBottom = eventData.GetString("zBottom");
                updateStatus.Ratio = eventData.GetString("ratio");
                updateStatus.FpsState = eventData.GetString("fps"); 
                //OperatingMode.BrightField.CameraSetting.Gain = 1;

                //OperatingMode.SelectViewMode 
            }
            catch(Exception ex)
            {
                LambdaControl.Log(new Message() { Severity = Severity.ERROR, Text = ex.Message });
            }
          

            return true;
        }


        private bool OnUpdateWindowStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            string windowstatus = eventData.GetString("windowstatus");

            try
            {
                foreach (var item in windowstatus.Split(";"))
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

﻿using Global.Common.Controls;
using Global.Common.Extensions;
using Global.Mode;
using Global.Mode.Config;
using Global.UserControls.SeriesMap;
using Lambda;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ConfigBottomView;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing;
using Microsoft.Win32;
using System.Text;
using ExportProcessing;
using System.Text.Json.Nodes;

namespace Global
{

    /// <summary>
    /// 注册AddEventHandler事件
    /// </summary>
    public partial class WindowData1
    {
        public HistogramModel histogramModel = new HistogramModel();
        public ProfileModel profileModel = new ProfileModel();
        public ProfileChart profile = new ProfileChart();
        public ProgressBarModel progressBarModel = new ProgressBarModel();

        private void AddEventHandler()
        {

            LambdaControl.AddLambdaEventHandler("UPDATE_STATUS1", OnUpdateStatus, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_STAGE_MOVE", UPDATE_STAGE_MOVE, false);
            LambdaControl.AddLambdaEventHandler("STAGE_INI_CLOSE", StaheIniClose, false);

           //LambdaControl.AddLambdaEventHandler("UPDATE_WINDOWSTATUS", OnUpdateWindowStatus, false);

            LambdaControl.AddLambdaEventHandler("SELECT_CLICKED", SELECT_CLICKED, false);

            LambdaControl.AddLambdaEventHandler("UPDATE_MUL_SUMMARY", UpdateMulSummary, false);

            LambdaControl.AddLambdaEventHandler("IMAGE_VIEW_CREATED", IMAGE_VIEW_CREATED, false);

            LambdaControl.AddLambdaEventHandler("MUL_ZSTEP", Mul_ZStep, false);
            LambdaControl.AddLambdaEventHandler("MUL_ZSTART", Mul_ZStart, false);
            LambdaControl.AddLambdaEventHandler("MUL_ZEND", Mul_ZEnd, false);
            LambdaControl.AddLambdaEventHandler("MUL_TIME_INTERVAL", Mul_TInterval, false);

            LambdaControl.AddLambdaEventHandler("STOP_ALIVE", STOP_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ALIVE1", StopPreview, false);
            LambdaControl.AddLambdaEventHandler("START_ALIVE", START_ALIVE, false);
            LambdaControl.AddLambdaEventHandler("STOP_ACQUIRE", STOP_ACQUIRE, false);
            LambdaControl.AddLambdaEventHandler("START_ACQUIRE", START_ACQUIRE, false);

            //预览关闭
            LambdaControl.AddLambdaEventHandler("PREVIEW_CLOSE", StopPreview, false);
            LambdaControl.AddLambdaEventHandler("UPDATE_HISTOGRAM", UpdateHistogramModel, false);

            //采集关闭
            LambdaControl.AddLambdaEventHandler("COLLECTION_COMPLETED", CollectionCompleted, false);
            //加载进度
            LambdaControl.AddLambdaEventHandler("UPDATE_PROGRESSBAR", UpdateProgressBarModel, false);
            // AUTO camera setting
            LambdaControl.AddLambdaEventHandler("UPDATE_AUTO_CAMERA", UpdateAutoCameraSetting, false);
            // multiPointsReback
            LambdaControl.AddLambdaEventHandler("MULTI_COLLECTION_POINT", MultiCollectionP, false);
            //multiCurrentP
            LambdaControl.AddLambdaEventHandler("MULTI_CURRENT_POINT", MultiCollectionCurrentP, false);
            // ProfilePointsReback
            LambdaControl.AddLambdaEventHandler("PROFILE_COLLECTION_POINT",ProfileCollectionP, false);
            LambdaControl.AddLambdaEventHandler("PROFILE_COLLECTION_POINT1", ReProfileCollectionP, false);

            // QUICK_EXPORT 
            
            LambdaControl.AddLambdaEventHandler("QUICK_EXPORT_PATHBACK", ImageExportAs, false);
            //ContextMenu
            LambdaControl.AddLambdaEventHandler("VIEW_CONTEXTMENU_BACK", UpdateContextMenu, false);
            LambdaControl.AddLambdaEventHandler("VIEW_CONTEXTMENU_BACK1", UpdateContextMenu1, false);
          
        }


        private bool StaheIniClose(object sender, EventArgs e)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                WaitContorl.GetInstance().Hidden();
            });
            return true;
        }

       
        private bool UpdateContextMenu(object sender, EventArgs e)
        {
           
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
          
            if (eventData == null)
                return false;
           
                if (!string.IsNullOrEmpty(eventData.GetString("status")))
                contextMenuPar.status = int.Parse(eventData.GetString("status"));
                if (!string.IsNullOrEmpty(eventData.GetString("count")))
                contextMenuPar.count = int.Parse(eventData.GetString("count"));
                if (!string.IsNullOrEmpty(eventData.GetString("mode")))
                contextMenuPar.mode = int.Parse(eventData.GetString("mode"));
                if (!string.IsNullOrEmpty(eventData.GetString("mode1")))
                contextMenuPar.mode1 = int.Parse(eventData.GetString("mode1"));

            return true;
        }
        // 读图模式下，右键模态切换只支持系列文件中已有的模态
        private bool UpdateContextMenu1(object sender, EventArgs e)
        {

            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);

            if (eventData == null)
                return false;
            string modeList = eventData.GetString("modes");
            if (modeList != null)
            {
                Modes List = JsonSerializer.Deserialize<Modes>(modeList);
                contextMenuPar.modes = List.modes;

            }

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

       



        private bool StopPreview(object sender, EventArgs e)
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

                PlayerEnable();

                UpdateActiveWindowMode();

            });

            return true;

        }

       private void UpdateActiveWindowMode()
        {
            LambdaControl.Trigger("VIEW_CONTEXTMENU", this, new Dictionary<string, object>() { { "view", DrawInkMethod.ActiveViews.ActiveWin } });
            if (WindowData1.contextMenuPar.status == 3&& RepoTogg.IsChecked==true)
            {
                LambdaControl.Trigger("ZSTACK_GALLERYPATH_TRIGGER", this, new Dictionary<string, object>() { { "mode", WindowData1.contextMenuPar.mode } });
            }
            if(WindowData1.contextMenuPar.status == 3)
            {
                int mode = WindowData1.contextMenuPar.mode;
                switch (mode)
                {

                    case 0:
                        updateStatus.BFCheckEnable = true;
                        break;
                    case 1:
                        updateStatus.DFCheckEnable = true; break;
                    case 2:
                        updateStatus.RICheckEnable = true; break;
                    case 3:
                        updateStatus.DPToggEnable = true; break;
                    case 4:
                        updateStatus.QPCheckEnable = true; break;
                    case 5:
                        updateStatus.PCCheckEnable = true; break;

                }
            }


        }








        private bool StartPreview(object sender, EventArgs e)
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
                        if (toggleButton != null && toggleButton.IsChecked == false)
                        {
                            toggleButton.IsChecked = true;
                            toggleButton.Content = "停止预览";
                            EventArgs eventArgs = new EventArgs();
                        }
                    }
                }

            });

            return true;

        }

        private  void PlayerEnable()
        {
            updateStatus.StartEnable = true;
            updateStatus.StopEnable = true;
            updateStatus.ForwardEnbale = true;
            updateStatus.BackwardEnbale = true;
        }

        private void ReadModeUpdate()
        {
            updateStatus.BFCheckEnable = false;
            updateStatus.DFCheckEnable = false;
            updateStatus.RICheckEnable = false;
            updateStatus.DPCheckEnable = false;
            updateStatus.QPCheckEnable = false;
            updateStatus.PCCheckEnable = false;

            updateStatus.BFToggEnable = false;
            updateStatus.DFToggEnable = false; 
            updateStatus.RIToggEnable = false;
            updateStatus.DPToggEnable = false;
            updateStatus.QPToggEnable = false;
            updateStatus.PCToggEnable = false;
        }
        



        private void PlayerDisable()
        {
            updateStatus.StartEnable = false;
            updateStatus.StopEnable = false;
            updateStatus.ForwardEnbale = false;
            updateStatus.BackwardEnbale = false;
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


        // START ALIVE
        private bool STOP_ALIVE(object sender, EventArgs e)
        {
            updateStatus.FpsEnable = true;
            histogramModel.MoveEnable = true;
            ALIVE = false;
            PlayerDisable();
            ReadModeUpdate();
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

         
        }







        private bool START_ALIVE(object sender, EventArgs e)
        {
            ALIVE = true;
            updateStatus.FpsEnable = false;
            histogramModel.MoveEnable = false;
            return true;
            
        }



        // start acquire
        private bool STOP_ACQUIRE(object sender, EventArgs e)
        {
            ACQUIRE = true;
            // SaveToPng(inkVisuals[0], "C:\\1\\File.PNG");
            PlayerDisable();
            ReadModeUpdate();
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

       
      

        private bool UpdateProgressBarModel(object sender, EventArgs e)
        {
           
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
          
            if (eventData == null)
                return false;
            Application.Current.Dispatcher.Invoke(delegate
            {

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
                if (!string.IsNullOrEmpty(eventData.GetString("SliderValueH")))
                    progressBarModel.SliderValueH = double.Parse(eventData.GetString("SliderValueH"));
                if (!string.IsNullOrEmpty(eventData.GetString("SliderValueV")))
                    progressBarModel.SliderValueV = double.Parse(eventData.GetString("SliderValueV"));

            });

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
            if (!string.IsNullOrEmpty(eventData.GetString("exposure")))
            {
                double esposure = Math.Round(double.Parse(eventData.GetString("exposure")), 3);
                WindowData.GetInstance().ExposureViewMode.SetValue(esposure);
            }
           if (!string.IsNullOrEmpty(eventData.GetString("Gain")))
            {
                switch (Mode)
                {

                    case 0:
                        OperatingMode.BrightField.CameraSetting.Gain = Math.Round(double.Parse(eventData.GetString("Gain")), 1);
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
            }
           

            return true;
        }



        private bool UpdateHistogramModel(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
           

                if (!string.IsNullOrEmpty(eventData.GetString("Max")))
            {
                histogramModel.Max = eventData.GetString("Max");
                histogramModel.HalfMax = int.Parse(eventData.GetString("Max")) / 2;

            }
            if (!string.IsNullOrEmpty(eventData.GetString("Min")))
            {
                histogramModel.Min = eventData.GetString("Min");
            }
            if (!string.IsNullOrEmpty(eventData.GetString("Mean")))
            {
                histogramModel.Mean = eventData.GetString("Mean");
            }
            if (!string.IsNullOrEmpty(eventData.GetString("Variance")))
            {
                histogramModel.Variance = eventData.GetString("Variance");
            }
            if (!string.IsNullOrEmpty(eventData.GetString("Outlier")))
            {
                histogramModel.Outlier= eventData.GetString("Outlier");
            }
           

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
               
                
                
                histogramModel.RangeMinP = ((rangeMinP - 255)/255.0)*(2* histogramModel.XAxisMaxP)+ histogramModel.XAxisMaxP;
              
               }
            if (!string.IsNullOrEmpty(eventData.GetString("RangeMaxP")))
            {
                int rangeMaxP = int.Parse(eventData.GetString("RangeMaxP"));

                histogramModel.RangeMaxP = (double)((rangeMaxP - 255) / 255.0 * 2 * histogramModel.XAxisMaxP +  histogramModel.XAxisMaxP); ;
            }
               
           
            return true;
        }







        // public MapWindow mapWindow = new MapWindow();
        

        private bool UpdateMulSummary(object sender, EventArgs e)
        {

            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            Application.Current.Dispatcher.Invoke(delegate
            {
                if (eventData.GetString("CollectionTimes") == "-1")
                {
                    mulSummary.CollectionTimes = "0";
                }
                else
                {
                   mulSummary.CollectionTimes = eventData.GetString("CollectionTimes");
                }; 
                mulSummary.CollectionLayers = eventData.GetString("CollectionLayers");
                mulSummary.CollectionPoints = eventData.GetString("CollectionPoints");
                mulSummary.FluorescenceChannels = eventData.GetString("FluorescenceChannels");
                mulSummary.ViewModeCounts = eventData.GetString("ViewModeCounts");
                mulSummary.ImageSize = eventData.GetString("ImageSize");
                if (eventData.GetString("ImageNums") == "-1")
                {
                    mulSummary.ImageNums = "0";
                }
                else
                {
                    mulSummary.ImageNums = eventData.GetString("ImageNums");
                };
                if (eventData.GetString("Storage") == "-1")
                {
                    mulSummary.ImageNums = "0";
                }
                else
                {
                    mulSummary.Storage = eventData.GetString("Storage");
                };
                mulSummary.AllCollectionTime = eventData.GetString("AllCollectionTime");
                mulSummary.CameraWorkingTime = eventData.GetString("CameraWorkingTime");
            });

            return true;
        }
        public class MultiPoints
        {
            public List<List<int>> Points { get; set; } = new List<List<int>>();
        }

        public class Modes
        {
            public List<int> modes { get; set; } = new List<int>();
        }


 
        private bool ProfileCollectionP(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            Application.Current.Dispatcher.Invoke(delegate
            {
                int size = (int)eventData["size"];

                IntPtr intPtr = (IntPtr)eventData["data"];
                double[] points = new double[size];
                Marshal.Copy(intPtr, points, 0, size);
               // MessageBox.Show(points.Length.ToString());
                profile.ReadPointsArry(points);
            });
            return true;

           

        }

        private bool ReProfileCollectionP(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;

            Application.Current.Dispatcher.Invoke(delegate
            {
                int size = (int)eventData["size"];

                IntPtr intPtr = (IntPtr)eventData["data"];
                double[] points = new double[size];
                Marshal.Copy(intPtr, points, 0, size);
                // MessageBox.Show(points.Length.ToString());
                profile.RefreshPointsArry(points);
            });
            return true;

           

        }




        private bool MultiCollectionP(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            MapWindow.ReverseTrans = true;
            Application.Current.Dispatcher.Invoke(delegate
            {
                string multiCollectJson = eventData.GetString("MultiCollectionP");
                if (multiCollectJson != null)
                {
                    MultiPoints testMean = JsonSerializer.Deserialize<MultiPoints>(multiCollectJson);
                    List<List<int>> points = testMean.Points;
                    // MessageBox.Show(points.Count.ToString());
                    if (MapWindow.ListViewP!=null)
                    { MapWindow.ListViewP.SelectedItem = null; }
                   
                    MapWindow.SeriesPoints.Clear();
                    
                   // List<Point> points2 = new List<Point>();
                    foreach (var point in points)
                    {
                        System.Windows.Point point1 = new System.Windows.Point { X = point[0], Y = point[1] };

                        int x = (int)Math.Floor(point1.X / 8);
                        int y = (int)Math.Floor(point1.Y / 6);

                        System.Windows.Point selectedPoint = new System.Windows.Point(x * 8, y * 6);
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
                    MapWindow.ReverseTrans = false;

                };
            });

            return true;
        }




        private bool MultiCollectionCurrentP(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            MapWindow.ReverseTrans = true;
            // MessageBox.Show(eventData.Count.ToString());
            Application.Current.Dispatcher.Invoke(delegate
            {
                   
                   System.Windows.Point point1 = new System.Windows.Point() {X= 0,Y=0};
                if (!string.IsNullOrEmpty(eventData.GetString("CurrentPX")))
                {
                    point1.X = int.Parse(eventData.GetString("CurrentPX"));
                   // MessageBox.Show(point1.X.ToString());
                   }
                if (!string.IsNullOrEmpty(eventData.GetString("CurrentPY")))
                {
                    point1.Y = int.Parse(eventData.GetString("CurrentPY"));
                  //  MessageBox.Show(point1.Y.ToString());
                }
                if(MapWindow.ListViewP != null)
                {
                    MapWindow.ReverseTransCurrentP(point1);
                }
                MapWindow.ReverseTrans = false;
            });
          
            return true;
        }






             

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
                if (!string.IsNullOrEmpty(eventData.GetString("BF")))
                {
                    updateStatus.BFToggEnable = bool.Parse(eventData.GetString("BF"));
                }
                // isChecked 
                if (!string.IsNullOrEmpty(eventData.GetString("BFC")))
                {
                    if (updateStatus.BFToggEnable)
                    {
                        updateStatus.BFCheckEnable = bool.Parse(eventData.GetString("BFC"));
                    }
                   
                }
                if (!string.IsNullOrEmpty(eventData.GetString("DFC")))
                {
                    if (updateStatus.DFToggEnable)
                    {
                        updateStatus.DFCheckEnable = bool.Parse(eventData.GetString("DFC"));
                    }
                   
                }
                if (!string.IsNullOrEmpty(eventData.GetString("RIC")))
                {
                    if (updateStatus.RIToggEnable)
                    {
                        updateStatus.RICheckEnable = bool.Parse(eventData.GetString("RIC"));
                    }
                   
                }
                if (!string.IsNullOrEmpty(eventData.GetString("DPC")))
                {
                    if (updateStatus.DPToggEnable)
                    {
                        updateStatus.DPCheckEnable = bool.Parse(eventData.GetString("DPC"));
                    }
                   
                }
                if (!string.IsNullOrEmpty(eventData.GetString("QPC")))
                {
                    if (updateStatus.QPToggEnable)
                    {
                        updateStatus.QPCheckEnable = bool.Parse(eventData.GetString("QPC"));
                    }
                   
                }
                if (!string.IsNullOrEmpty(eventData.GetString("PCC")))
                {
                    if (updateStatus.PCToggEnable)
                    {
                        updateStatus.PCCheckEnable = bool.Parse(eventData.GetString("PCC"));
                    }
                   
                }

                //MessageBox.Show("1111");

                updateStatus.ImageX = eventData.GetString("x");
                updateStatus.ImageY = eventData.GetString("y");
                updateStatus.ImageZ = eventData.GetString("z");


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
               // updateStatus.Ratio = eventData.GetString("ratio");
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


        //private void intToMode(UpdateStatus update, int i)
        //{

        //    switch (i)
        //    {

        //        case 0:
        //            MessageBox.Show("1");
        //            update.BFCheckEnable = true;
        //            break;
        //        case 1:
        //            update.DFCheckEnable = true;
        //            break;
        //        case 2:
        //            update.RICheckEnable = true;
        //            break;

        //        case 3:
        //            update.DPCheckEnable = true;
        //            break;
        //        case 4:
        //            update.QPCheckEnable = true;
        //            break;
        //        case 5:
        //            update.PCCheckEnable = true;
        //            break;

        //    }



        //}
        private static bool CheckIsMutiView()
        {
            Grid grid  = (Grid)Application.Current.MainWindow.FindName("mainView");
            if (grid.Children.Count == 1)
            {
                return false;
            }
            else if(grid.Children.Count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }



        //private void WindowModeUpdate(string windowMode )
        //{

        //    foreach (var item in windowMode.Split(";"))
        //    {
        //        string[] views = item.Split(",");
        //        if (views.Length == 2)
        //        {
        //            int windowN = int.Parse(views[0]);
        //            int windowM = int.Parse(views[1]);

        //            if (int.TryParse(views[0], out int value))
        //            {
        //                if (inkVisuals[value] != null)
        //                {
        //                    inkVisuals[value].ActiveMode = windowM;
        //                } 
        //            }
        //        }
        //    }

        //    int m = DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].ActiveMode;

        //    intToMode(updateStatus, m);


        //}





        private bool OnUpdateWindowStatus(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
            if (eventData == null)
                return false;
            string windowstatus = eventData.GetString("windowstatus");
            MessageBox.Show(windowstatus);
            return true;

        }

        //    string windowstatus = eventData.GetString("windowstatus");

            //    try
            //    {
            //        foreach (var item in windowstatus.Split(";"))
            //        {
            //            string[] views = item.Split(",");
            //            if (views.Length == 2)
            //            {
            //                if (int.TryParse(views[0], out int value))
            //                {
            //                    List<int> ints = new List<int> { };
            //                    for (int j = 0; j < views[1].Length; j++)
            //                        ints.Add(int.Parse(views[1].Substring(j, 1)));


            //                    if (ViewContentMenuCache.ContainsKey(value))
            //                        ViewContentMenuCache[value] = ints;
            //                    else
            //                        ViewContentMenuCache.Add(value, ints);

            //                    Application.Current.Dispatcher.Invoke(delegate
            //                    {
            //                      //  AddViewContentMenu(value, ints);
            //                    });
            //                }
            //            }
            //        }
            //       // WindowModeUpdate(windowstatus);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    return true;
            //}
       public class ImageType
        {
         public string Type { get; set; }
 
        }
        public static int ExportNameIndex = 1;
        public static int ExportNameIndex1 = 1;
        public static int ExportNameIndex2 = 1;
        public static ImageType ImageExportType = new ImageType();
        public static string ExportPath =Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)+"\\";
        public static void ImageExportAsPath(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                int i = DrawInkMethod.ActiveViews.ActiveWin;
                ImageExportType.Type = menuItem.Header.ToString();
                LambdaControl.Trigger("QUICK_EXPORT_FULLPATH", null, new Dictionary<string, object> { { "view", i } });

            }
           
        }
        public static void LiveImageExportAsPath(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                int i = DrawInkMethod.ActiveViews.ActiveWin;
                ImageExportType.Type = menuItem.Header.ToString();
                string type = ImageExportType.Type;
                string json = DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].drawingVisualJson;
                ExportAsWindow exportAsWindow = new ExportAsWindow(ExportNameIndex2, i, type, ExportPath, json);
                exportAsWindow.Closing += (s, e) =>
                {
                    ExportNameIndex2 = exportAsWindow.NameIndex2;
                    ExportPath = exportAsWindow.ExportFullName;
                };
                exportAsWindow.ShowDialog();
            }

        }
        public static void AllImageExportAsPath(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                int i = DrawInkMethod.ActiveViews.ActiveWin;
                ImageExportType.Type = menuItem.Header.ToString();
            }
            string TYPE = ImageExportType.Type;
            string json =JsonSerializer.Serialize(DrawInkMethod.Visuals, new JsonSerializerOptions());
            ExportAsWindow exportAsWindow = new ExportAsWindow( TYPE,1, ExportNameIndex, ExportPath,json);
            exportAsWindow.Closing += (s, e) =>
            {
                ExportNameIndex = exportAsWindow.NameIndex;
                ExportPath = exportAsWindow.ExportFullName;
            };
           
            exportAsWindow.ShowDialog();
           
        }

        public static void AllImageMosaic(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                ImageExportType.Type = menuItem.Header.ToString();
               // LambdaControl.Trigger("QUICK_EXPORT_All", null, new Dictionary<string, object> { });

            }
            string TYPE = ImageExportType.Type;
            //string json = DrawInkMethod.InkAll[DrawInkMethod.ActiveViews.ActiveWin].drawingVisualJson;
            string json = JsonSerializer.Serialize(DrawInkMethod.Visuals, new JsonSerializerOptions());
            ExportAsWindow exportAsWindow = new ExportAsWindow(TYPE, 2, ExportNameIndex1, ExportPath,json);
            exportAsWindow.Closing += (s, e) =>
            {
                ExportNameIndex1 = exportAsWindow.NameIndex1;
                ExportPath = exportAsWindow.ExportFullName;
            };
            exportAsWindow.ShowDialog();
           
        }



        private  bool ImageExportAs(object sender, EventArgs e)
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
           
            if (eventData == null)
                return false;
            string type = ImageExportType.Type;
            if (!string.IsNullOrEmpty(eventData.GetString("path")))
            {
                string path = eventData.GetString("path");
                string json = inkVisuals[DrawInkMethod.ActiveViews.ActiveWin].drawingVisualJson;
                int i = DrawInkMethod.ActiveViews.ActiveWin;
                ExportAsWindow exportAsWindow = new ExportAsWindow(path,i, type, ExportPath, json);
                exportAsWindow.Closing += (s, e) =>
                {
                    ExportPath = exportAsWindow.ExportFullName;
                };
                exportAsWindow.ShowDialog();
                return true;

            }

            return false;


        }
        Dictionary<int, List<int>> ViewContentMenuCache = new Dictionary<int, List<int>>();
        List<string> ViewContentMenuContent = new List<string>() { "明场", "暗场", "莱茵伯格", "差分", "相位", "相差" };
        static  List<string> ImageExportAsString = new List<string>() { "导出PNG...", "导出BMP...",  "导出JPEG...", "导出TIFF..."};
        
       static List<string> ContextMenuItemMode = new List<string>() { "明场", "暗场", "莱茵伯格", "差分", "相位", "相差" };
        //预览右键菜单
        public static ContextMenu UpdateContextMenu(int m, int view)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem1 = new MenuItem() { Header = "切换成像模式", FontSize = 14 };
            MenuItem menuItem2 = new MenuItem() { Header = "导出", FontSize = 14 };
            MenuItem menuItem3 = new MenuItem() { Header = "全部导出", FontSize = 14 };
            MenuItem menuItem4 = new MenuItem() { Header = "全部合成导出", FontSize = 14 };
            for (int i = 0; i < ContextMenuItemMode.Count; i++)
            {
                int mode = i;
                MenuItem menuItem = new MenuItem() { Header = ContextMenuItemMode[i], IsCheckable = true };
                if (m == i)
                {
                    menuItem.IsChecked = true;
                }
                menuItem.Click += (s, e) =>
                {
                    if (contextMenu.Items.Count == 6)
                    {
                        foreach (MenuItem item in contextMenu.Items)
                        {
                            if (item.IsChecked == true && item != menuItem)
                                item.IsChecked = false;
                        }
                    }
                    menuItem.IsChecked = true;

                    LambdaControl.Trigger("VIEW_WINDOW", null, new Dictionary<string, object>() { { "type", 0 }, { "window", view }, { "mode1", mode }, { "mode2", -1 } });
                };
                menuItem1.Items.Add(menuItem);

            }
            for (int i = 0; i < ImageExportAsString.Count; i++)
            {
                MenuItem menuItem = new MenuItem() { Header = ImageExportAsString[i], FontSize = 14 };
                menuItem.Click += (s, e) => { LiveImageExportAsPath(s, e); };
                menuItem2.Items.Add(menuItem);
            }
            ExportMenuAdd(menuItem3, menuItem4);
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);
            bool isMulti = CheckIsMutiView();
            if (isMulti)
            {
                contextMenu.Items.Add(menuItem3);
                contextMenu.Items.Add(menuItem4);
            }
            return contextMenu;
        }
        //预览 双拼
        public static ContextMenu UpdateContextMenu( int view,int modeL,int modeR,int where)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem1 = new MenuItem() { Header = "切换成像模式", FontSize = 14 };
            MenuItem menuItem2 = new MenuItem() { Header = "导出", FontSize = 14 };
            int ModeL = modeL;
            int ModeR = modeR;
            for (int i = 0; i < ContextMenuItemMode.Count; i++)
            {
                int mode = i;
                MenuItem menuItem = new MenuItem() { Header = ContextMenuItemMode[i], IsCheckable = true };
                if (where == 0&& modeL==i)
                {
                    menuItem.IsChecked = true;
                }
                else if(where == 1 && modeR == i)
                {
                    menuItem.IsChecked = true;
                }
                menuItem.Click += (s, e) =>
                {
                    if (menuItem1.Items.Count == 6)
                    {
                        foreach (MenuItem item in menuItem1.Items)
                        {
                            if (item.IsChecked == true && item != menuItem)
                                item.IsChecked = false;
                        }
                    }
                    menuItem.IsChecked = true;


                    if (where == 0)
                    {
                        ModeL = mode;

                        LambdaControl.Trigger("VIEW_WINDOW", null, new Dictionary<string, object>() { { "type", (int)ViewWindowMode.DOUBLE_WINDOW }, { "window", view }, { "mode1", ModeL }, { "mode2", ModeR } });
                    }
                    if (where == 1)
                    {
                        ModeR = mode;

                        LambdaControl.Trigger("VIEW_WINDOW", null, new Dictionary<string, object>() { { "type", (int)ViewWindowMode.DOUBLE_WINDOW }, { "window", view }, { "mode1", ModeL }, { "mode2", ModeR } });
                    }

                };
                menuItem1.Items.Add(menuItem);

            }
            for (int i = 0; i < ImageExportAsString.Count; i++)
            {
                MenuItem menuItem = new MenuItem() { Header = ImageExportAsString[i], FontSize = 14 };
                menuItem.Click += (s, e) => { LiveImageExportAsPath(s, e); };
                menuItem2.Items.Add(menuItem);
            }
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);
            return contextMenu;
        }
       private static void ExportMenuAdd( MenuItem menuItem3, MenuItem menuItem4)
        {
           
            for (int i = 0; i < ImageExportAsString.Count; i++)
            {
                MenuItem menuItem = new MenuItem() { Header = ImageExportAsString[i], FontSize = 14 };
                menuItem.Click += (s, e) => { AllImageExportAsPath(s, e); };
                menuItem3.Items.Add(menuItem);

            }
            for (int i = 0; i < ImageExportAsString.Count; i++)
            {
                MenuItem menuItem = new MenuItem() { Header = ImageExportAsString[i], FontSize = 14 };
                menuItem.Click += (s, e) => { AllImageMosaic(s, e); };
                menuItem4.Items.Add(menuItem);

            }


        }




        private static void UpdateInkvisualMode(int CurrentMode,int ActiveWinMode )
        {
            ActiveWinMode = CurrentMode;
        }
        // 读图右键菜单
        public static ContextMenu UpdateContextMenu1(int m, int view, int count,List<int> modes)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem1 = new MenuItem() { Header = "切换成像模式", FontSize = 14 };
            MenuItem menuItem2 = new MenuItem() { Header = "导出", FontSize = 14 };
            MenuItem menuItem3 = new MenuItem() { Header = "全部导出", FontSize = 14 };
            MenuItem menuItem4 = new MenuItem() { Header = "全部合成导出", FontSize = 14 };
            for (int i = 0; i < modes.Count; i++)
            {
                int mode = modes[i];
                MenuItem menuItem = new MenuItem() { Header = ContextMenuItemMode[modes[i]], IsCheckable = true };
                if (m == modes[i])
                {
                    menuItem.IsChecked = true;
                }
                menuItem.Click += (s, e) =>
                {
                    if (menuItem1.Items.Count == modes.Count)
                    {
                        foreach (MenuItem item in menuItem1.Items)
                        {
                            if (item.IsChecked == true && item != menuItem)
                                item.IsChecked = false;
                        }
                    }
                    menuItem.IsChecked = true;
                    //同步读图模态
                    updateToolBarMode(mode);

                    LambdaControl.Trigger("VIEW_WINDOW", null, new Dictionary<string, object>() { { "type", 0 }, { "window", view }, { "mode1", mode }, { "mode2", -1 } });
                    if (RepoTogg.IsChecked == true)
                    {
                        LambdaControl.Trigger("ZSTACK_GALLERYPATH_TRIGGER", null, new Dictionary<string, object>() { { "mode", mode } });
                       // MessageBox.Show(mode.ToString());
                    }




                };
                menuItem1.Items.Add(menuItem);

            }
            for (int i = 0; i < ImageExportAsString.Count; i++)
            {
                MenuItem menuItem = new MenuItem() { Header = ImageExportAsString[i], FontSize = 14 };
                menuItem.Click += (s, e) => { ImageExportAsPath(s, e); };
                menuItem2.Items.Add(menuItem);
            }
            ExportMenuAdd(menuItem3, menuItem4);
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);
            if (count == 1)
            {
                contextMenu.Items.Add(menuItem3);
                contextMenu.Items.Add(menuItem4);
            }
            return contextMenu;
        }

        private static void updateToolBarMode(int mode)
        {
            switch (mode)
            {

                case 0:
                    updateStatus.BFCheckEnable = true;
                    break;
                case 1:
                    updateStatus.DFCheckEnable = true; break;
                case 2:
                    updateStatus.RICheckEnable = true; break;
                case 3:
                    updateStatus.DPToggEnable = true; break;
                case 4:
                    updateStatus.QPCheckEnable = true; break;
                case 5:
                    updateStatus.PCCheckEnable = true; break;

            }


        }





        //读图双拼
        public static ContextMenu UpdateContextMenu1(int view, int modeL, int modeR, int where,List<int> modes)
        {
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItem1 = new MenuItem() { Header = "切换成像模式", FontSize = 14 };
            MenuItem menuItem2 = new MenuItem() { Header = "导出", FontSize = 14 };
            int ModeL = modeL;
            int ModeR = modeR;
            for (int i = 0; i < modes.Count; i++)
            {
                int mode = modes[i];
                MenuItem menuItem = new MenuItem() { Header = ContextMenuItemMode[modes[i]], IsCheckable = true };
                if (where == 0 && modeL == i)
                {
                    menuItem.IsChecked = true;
                }
                else if (where == 1 && modeR == i)
                {
                    menuItem.IsChecked = true;
                }
                menuItem.Click += (s, e) =>
                {
                    if (menuItem1.Items.Count == modes.Count)
                    {
                        foreach (MenuItem item in menuItem1.Items)
                        {
                            if (item.IsChecked == true && item != menuItem)
                                item.IsChecked = false;
                        }
                    }
                    menuItem.IsChecked = true;
                    if (where == 0)
                    {
                        ModeL = mode;

                        LambdaControl.Trigger("VIEW_WINDOW", null, new Dictionary<string, object>() { { "type", (int)ViewWindowMode.DOUBLE_WINDOW }, { "window", view }, { "mode1", ModeL }, { "mode2", ModeR } });
                    }
                    if (where == 1)
                    {
                        ModeR = mode;

                        LambdaControl.Trigger("VIEW_WINDOW", null, new Dictionary<string, object>() { { "type", (int)ViewWindowMode.DOUBLE_WINDOW }, { "window", view }, { "mode1", ModeL }, { "mode2", ModeR } });
                    }
                };
                menuItem1.Items.Add(menuItem);

            }
            for (int i = 0; i < ImageExportAsString.Count; i++)
            {
                MenuItem menuItem = new MenuItem() { Header = ImageExportAsString[i], FontSize = 14 };
                menuItem.Click += (s, e) => { ImageExportAsPath(s, e); };
                menuItem2.Items.Add(menuItem);
            }
            contextMenu.Items.Add(menuItem1);
            contextMenu.Items.Add(menuItem2);
            return contextMenu;
        }

        public static void AllInkStrokeClear()
        {
            foreach(var item in DrawInkMethod.InkAll)
            {
                if (item!= null)
                {
                    item.inkCanvas.Strokes.Clear();
                }        
            }

        }




    }
}

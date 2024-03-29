﻿using System;
using System.Collections.Generic;
using System.Windows;
using Lambda;
using LambdaManager.Core;
using LambdaManager.Mode;
using Global.Common.Extensions;
using System.Windows.Forms;

namespace LambdaManager.Features;

public class UIEvents {

    private static UIEvents instance;
    private static readonly object locker = new();

    public static UIEvents GetInstance() {
        lock (locker) { return instance ??= new UIEvents(); }
    }
    private UIEvents() {
        Common.AddEventHandler("UPDATE_STATUS", OnUpdateStatus, once: false);
        Common.AddEventHandler("FPS_INDEX_CHANNGED", FPS_INDEX_CHANNGED, once: false);
    }

    private bool FPS_INDEX_CHANNGED(object sender, EventArgs e) {
        int? index = LambdaArgs.GetEventData(e).GetInt("index");
        if (index.HasValue) {
            //对窗口的FPS操作置于0
            //Common.Views[index.Value].FPS = index.Value;
            //a3.i.b(0);
        }


        return true;
    }


    public UpdateStatus updateStatus = new UpdateStatus();

    private  bool OnUpdateStatus(object sender, EventArgs e)
    {
        Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
        if (eventData == null)
            return false;
        updateStatus.ImageX = eventData.GetString("x");
        updateStatus.ImageY = eventData.GetString("y");
        updateStatus.ImageZ = eventData.GetString("z");
        updateStatus.ImageSize = eventData.GetString("size");
        updateStatus.ImageFocus = eventData.GetString("focus");
        updateStatus.CreateTime = eventData.GetString("createTime");
        string frameIndex = eventData.GetString("frameIndex");
        if (frameIndex != string.Empty)
        {
            updateStatus.FrameIndex = int.Parse(frameIndex);

        }

        updateStatus.TotalFrame = eventData.GetInt("totalFrame") ?? 0;
        updateStatus.TimeElapsed = eventData.GetString("timeElapsed");
        updateStatus.TotalTime = eventData.GetString("totalTime");

        updateStatus.SliceIndex = eventData.GetInt("sliceIndex") ?? 0;

        updateStatus.TotalSlice = eventData.GetInt("totalSlice") ?? 0;

        updateStatus.ZTop = eventData.GetString("zTop");
        updateStatus.ZCurrent = eventData.GetString("zCurrent");
        updateStatus.ZBottom = eventData.GetString("zBottom");
        updateStatus.Ratio = eventData.GetString("ratio");
        return true;
    }


    private static bool OnUpdatePanelState(object sender, EventArgs e)
    {
        Dictionary<string, object> dict = LambdaArgs.GetEventData(e);
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        string side = dict.GetString("side");
        if (side == null)
        {
            return false;
        }
        bool? visible = dict.GetValue("visible")!=null && (bool)dict.GetValue("visible");
        if (!visible.HasValue)
        {
            return false;
        }
        string[] array = side.Split(',');
        foreach (string s in array)
        {
            if (!OnUpdateSpecificPanelState(main, s, visible))
            {
                Side side2 = (Side)Enum.Parse(typeof(Side), s, ignoreCase: true);
                Visibility visibility = (main.GetConfigPanel(side2).Visibility = ((!visible.Value) ? Visibility.Collapsed : Visibility.Visible));
                switch (side2)
                {
                    case Side.LEFT:
                        main.LeftSplitter.Visibility = visibility;
                        break;
                    case Side.MIDDLE:
                        main.MiddleSplitter.Visibility = visibility;
                        break;
                }
            }
        }
        return true;
    }

    private static bool OnUpdateSpecificPanelState(MainWindow main, string s, bool? visible)
    {
        if (!(s == "LEFT"))
        {
            if (s == "MIDDLE")
            {
                main.ChangeMiddleViewVisibility(visible.GetValueOrDefault());
                return true;
            }
            return false;
        }
        main.ChangeLeftViewVisibility(visible.GetValueOrDefault());
        return true;
    }
}
using System;
using System.Collections.Generic;
using System.Windows;
using Lambda;
using LambdaManager.Core;
using LambdaManager.Mode;

namespace LambdaManager.Features;

public class UIEvents
{

    private static UIEvents instance;
    private static readonly object locker = new();

    public static UIEvents GetInstance()
    {
        lock (locker) { if (instance == null) { instance = new UIEvents(); } }
        return instance;
    }
    private UIEvents()
    {
        Common.AddEventHandler("UPDATE_STATUS", OnUpdateStatus, once: false);
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

    private static int? GetIntValue(Dictionary<string, object>? data, string key)
    {
        if (data == null)
        {
            return null;
        }
        if (data!.TryGetValue(key, out var value) && value is string str)
        {
            return int.Parse(str);
        }
        return null;
    }

    private static bool? GetBoolValue(Dictionary<string, object>? data, string key)
    {
        if (data == null)
        {
            return null;
        }
        if (data!.TryGetValue(key, out var value) && value is string b)
        {
            return bool.Parse(b);
        }
        return null;
    }
    public UpdateStatusMode updateStatus = new UpdateStatusMode();

    private  bool OnUpdateStatus(object sender, EventArgs e)
    {
        Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);
        if (eventData == null)
            return false;
        updateStatus.ImageX = GetStringValue(eventData, "x");
        updateStatus.ImageY = GetStringValue(eventData, "y");
        updateStatus.ImageZ = GetStringValue(eventData, "z");
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
        return true;
    }


    private static bool OnUpdatePanelState(object sender, EventArgs e)
    {
        Dictionary<string, object> dict = LambdaArgs.GetEventData(e);
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        string side = GetStringValue(dict, "side");
        if (side == null)
        {
            return false;
        }
        bool? visible = GetBoolValue(dict, "visible");
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
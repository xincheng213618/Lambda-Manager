using System;
using System.Collections.Generic;
using System.Windows;
using Lambda;
using LambdaManager.Core;
using LambdaManager.Mode;
using Global.Common.Extensions;
namespace LambdaManager.Features;

public class UIEvents
{

    private static UIEvents instance;
    private static readonly object locker = new();

    public static UIEvents GetInstance()
    {
        lock (locker) { instance ??= new UIEvents(); }
        return instance;
    }
    private UIEvents()
    {
        Common.AddEventHandler("UPDATE_STATUS", OnUpdateStatus, once: false);
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
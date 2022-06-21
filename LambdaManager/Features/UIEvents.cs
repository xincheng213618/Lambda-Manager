using System;
using System.Collections.Generic;
using System.Windows;
using Lambda;
using LambdaManager.Core;
using LambdaManager.Properties;
using Microsoft.Win32;

namespace LambdaManager.Features;

internal class UIEvents
{
	private static Dictionary<string, LambdaHandler> handlers = new Dictionary<string, LambdaHandler>
	{
		{ "OPEN_FILE_DIALOG", OnOpenFileDialog },
		{ "SAVE_FILE_DIALOG", OnSaveFileDialog },
        { "UPDATE_STATUS", OnUpdateStatus },
        { "UPDATE_PANEL_STATE", OnUpdatePanelState }
	};

	public static void Initialze()
	{
		foreach (KeyValuePair<string, LambdaHandler> handler in handlers)
		{
			Common.AddEventHandler(handler.Key, handler.Value, once: false);
		}
	}

	private static bool OnOpenFileDialog(object sender, EventArgs e)
	{
		Dictionary<string, object> dict = LambdaArgs.GetEventData(e);
		OpenFileDialog dialog = new OpenFileDialog();
		dialog.InitialDirectory = GetStringValue(dict, "InitialDirectory") ?? "D:\\";
		dialog.Filter = GetStringValue(dict, "Filter") ?? "所有文件(*.*)|*.*";
		dialog.FilterIndex = GetIntValue(dict, "FilterIndex").GetValueOrDefault();
		dialog.DereferenceLinks = GetBoolValue(dict, "DereferenceLinks").GetValueOrDefault();
		dialog.Title = GetStringValue(dict, "Title") ?? Resources.OpenFiles;
		dialog.ShowReadOnly = GetBoolValue(dict, "ShowReadOnly") ?? true;
		dialog.ReadOnlyChecked = GetBoolValue(dict, "ReadOnlyChecked") ?? true;
		dialog.Multiselect = GetBoolValue(dict, "Multiselect") ?? true;
		if (dialog.ShowDialog().GetValueOrDefault())
		{
			string fileName = dialog.SafeFileName;
			string[] fileNames = dialog.FileNames;
			if (fileName == null || fileNames == null)
			{
				return false;
			}
			dict = new Dictionary<string, object>
			{
				{ "fileName", fileName },
				{ "fileNames", fileNames }
			};
			LambdaControl.Trigger("FILE_SELECTED", "", new LambdaArgs
			{
				Data = dict
			});
		}
		return true;
	}

	private static bool OnSaveFileDialog(object sender, EventArgs e)
	{
		Dictionary<string, object> dict = LambdaArgs.GetEventData(e);
		SaveFileDialog dialog = new SaveFileDialog();
		dialog.Filter = GetStringValue(dict, "Filter") ?? "所有文件(*.*)|*.*";
		dialog.FilterIndex = GetIntValue(dict, "FilterIndex").GetValueOrDefault();
		dialog.Title = GetStringValue(dict, "Title") ?? Resources.OpenFiles;
		dialog.FileName = GetStringValue(dict, "FileName");
		dialog.AddExtension = GetBoolValue(dict, "AddExtension").GetValueOrDefault();
		dialog.RestoreDirectory = GetBoolValue(dict, "RestoreDirectory").GetValueOrDefault();
		dialog.CheckFileExists = GetBoolValue(dict, "CheckFileExists").GetValueOrDefault();
		dialog.CheckPathExists = GetBoolValue(dict, "CheckPathExists").GetValueOrDefault();
		dialog.ValidateNames = GetBoolValue(dict, "ValidateNames") ?? true;
		dialog.OverwritePrompt = GetBoolValue(dict, "OverwritePrompt") ?? true;
		if (dialog.ShowDialog().GetValueOrDefault())
		{
			string fileName = dialog.SafeFileName;
			if (fileName == null)
			{
				return false;
			}
			dict = new Dictionary<string, object> { { "fileName", fileName } };
			LambdaControl.Trigger("FILE_SAVED", "", new LambdaArgs
			{
				Data = dict
			});
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

	private static bool OnUpdateStatus(object sender, EventArgs e)
	{
        EventArgs e2 = e;
        Application.Current.Dispatcher.Invoke(delegate
        {
            Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e2);
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            string stringValue = GetStringValue(eventData, "x");
            if (stringValue != null)
            {
                mainWindow.imageX.Text = stringValue;
            }
            string stringValue2 = GetStringValue(eventData, "y");
            if (stringValue2 != null)
            {
                mainWindow.imageY.Text = stringValue2;
            }
            string stringValue3 = GetStringValue(eventData, "z");
            if (stringValue3 != null)
            {
                mainWindow.imageZ.Text = stringValue3;
            }
            string stringValue4 = GetStringValue(eventData, "size");
            if (stringValue4 != null)
            {
                mainWindow.imageSize.Text = stringValue4;
            }
            string stringValue5 = GetStringValue(eventData, "focus");
            if (stringValue5 != null)
            {
                mainWindow.imageFocus.Text = stringValue5;
            }
            string stringValue6 = GetStringValue(eventData, "createTime");
            if (stringValue6 != null)
            {
                mainWindow.imageCreateTime.Text = stringValue6;
            }
            string stringValue7 = GetStringValue(eventData, "frameIndex");
            if (stringValue7 != null)
            {
                mainWindow.frameIndex.Text = stringValue7;
            }
            string stringValue8 = GetStringValue(eventData, "totalFrame");
            if (stringValue8 != null)
            {
                mainWindow.totalFrame.Text = stringValue8;
            }
            string stringValue9 = GetStringValue(eventData, "timeElapsed");
            if (stringValue9 != null)
            {
                mainWindow.timeElapsed.Text = stringValue9;
            }
            string stringValue10 = GetStringValue(eventData, "totalTime");
            if (stringValue10 != null)
            {
                mainWindow.totalTime.Text = stringValue10;
            }
            string stringValue11 = GetStringValue(eventData, "sliceIndex");
            if (stringValue11 != null)
            {
                mainWindow.sliceIndex.Text = stringValue11;
            }
            string stringValue12 = GetStringValue(eventData, "totalSlice");
            if (stringValue12 != null)
            {
                mainWindow.totalSlice.Text = stringValue12;
            }
            string stringValue13 = GetStringValue(eventData, "zTop");
            if (stringValue13 != null)
            {
                mainWindow.zTop.Text = stringValue13;
            }
            string stringValue14 = GetStringValue(eventData, "zCurrent");
            if (stringValue14 != null)
            {
                mainWindow.zCurrent.Text = stringValue14;
            }
            string stringValue15 = GetStringValue(eventData, "zBottom");
            if (stringValue15 != null)
            {
                mainWindow.zBottom.Text = stringValue15;
            }
            string stringValue16 = GetStringValue(eventData, "ratio");
            if (stringValue16 != null)
            {
                mainWindow.ratio.Text = stringValue16;
            }
            string stringValue17 = GetStringValue(eventData, "fps");
            if (stringValue17 != null)
            {
                mainWindow.fpsState.Text = stringValue17;
            }
        });

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

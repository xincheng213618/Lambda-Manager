using System;
using System.Collections.Generic;
using System.Windows;
using Lambda;
using LambdaManager;
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
		Dictionary<string, object> eventData = LambdaArgs.GetEventData(e);
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = GetStringValue(eventData, "InitialDirectory") ?? "D:\\";
		openFileDialog.Filter = GetStringValue(eventData, "Filter") ?? "所有文件(*.*)|*.*";
		openFileDialog.FilterIndex = GetIntValue(eventData, "FilterIndex").GetValueOrDefault();
		openFileDialog.DereferenceLinks = GetBoolValue(eventData, "DereferenceLinks").GetValueOrDefault();
		openFileDialog.Title = GetStringValue(eventData, "Title") ?? Resources.OpenFiles;
		openFileDialog.ShowReadOnly = GetBoolValue(eventData, "ShowReadOnly") ?? true;
		openFileDialog.ReadOnlyChecked = GetBoolValue(eventData, "ReadOnlyChecked") ?? true;
		openFileDialog.Multiselect = GetBoolValue(eventData, "Multiselect") ?? true;
		if (openFileDialog.ShowDialog().GetValueOrDefault())
		{
			string safeFileName = openFileDialog.SafeFileName;
			string[] fileNames = openFileDialog.FileNames;
			if (safeFileName == null || fileNames == null)
			{
				return false;
			}
			eventData = new Dictionary<string, object>
			{
				{ "fileName", safeFileName },
				{ "fileNames", fileNames }
			};
			LambdaControl.Trigger("FILE_SELECTED", "", new LambdaArgs
			{
				Data = eventData
			});
		}
		return true;
	}

	private static bool OnSaveFileDialog(object sender, EventArgs e)
	{
		Dictionary<string, object> eventData = LambdaArgs.GetEventData(e);
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		saveFileDialog.Filter = GetStringValue(eventData, "Filter") ?? "所有文件(*.*)|*.*";
		saveFileDialog.FilterIndex = GetIntValue(eventData, "FilterIndex").GetValueOrDefault();
		saveFileDialog.Title = GetStringValue(eventData, "Title") ?? Resources.OpenFiles;
		saveFileDialog.FileName = GetStringValue(eventData, "FileName");
		saveFileDialog.AddExtension = GetBoolValue(eventData, "AddExtension").GetValueOrDefault();
		saveFileDialog.RestoreDirectory = GetBoolValue(eventData, "RestoreDirectory").GetValueOrDefault();
		saveFileDialog.CheckFileExists = GetBoolValue(eventData, "CheckFileExists").GetValueOrDefault();
		saveFileDialog.CheckPathExists = GetBoolValue(eventData, "CheckPathExists").GetValueOrDefault();
		saveFileDialog.ValidateNames = GetBoolValue(eventData, "ValidateNames") ?? true;
		saveFileDialog.OverwritePrompt = GetBoolValue(eventData, "OverwritePrompt") ?? true;
		if (saveFileDialog.ShowDialog().GetValueOrDefault())
		{
			string safeFileName = saveFileDialog.SafeFileName;
			if (safeFileName == null)
			{
				return false;
			}
			eventData = new Dictionary<string, object> { { "fileName", safeFileName } };
			LambdaControl.Trigger("FILE_SAVED", "", new LambdaArgs
			{
				Data = eventData
			});
		}
		return true;
	}

	private static string? GetStringValue(Dictionary<string, object>? data, string key)
	{
		if (data == null)
		{
			return "";
		}
		if (data!.TryGetValue(key, out var value) && value is string result)
		{
			return result;
		}
		return "";
	}

	private static int? GetIntValue(Dictionary<string, object>? data, string key)
	{
		if (data == null)
		{
			return null;
		}
		if (data!.TryGetValue(key, out var value) && value is string s)
		{
			return int.Parse(s);
		}
		return null;
	}

	private static bool? GetBoolValue(Dictionary<string, object>? data, string key)
	{
		if (data == null)
		{
			return null;
		}
		if (data!.TryGetValue(key, out var value) && value is string value2)
		{
			return bool.Parse(value2);
		}
		return null;
	}

	private static bool OnUpdateStatus(object sender, EventArgs e)
	{
		Dictionary<string, object>? eventData = LambdaArgs.GetEventData(e);

		Mode.UpdateStatus UpdateStatus = Global.GetInstance().updateStatus;
		UpdateStatus.ImageX = GetStringValue(eventData, "x");
		UpdateStatus.ImageX = GetStringValue(eventData, "x");
		UpdateStatus.ImageY = GetStringValue(eventData, "y");
		UpdateStatus.ImageZ = GetStringValue(eventData, "z");
		UpdateStatus.ImageSize = GetStringValue(eventData, "size");
		UpdateStatus.imageFocus = GetStringValue(eventData, "focus");
		UpdateStatus.CreateTime = GetStringValue(eventData, "createTime");
		UpdateStatus.FrameIndex = GetStringValue(eventData, "frameIndex");
		UpdateStatus.TotalFrame = GetStringValue(eventData, "totalFrame");
		UpdateStatus.TimeElapsed = GetStringValue(eventData, "timeElapsed");
		UpdateStatus.TotalTime = GetStringValue(eventData, "totalTime");
		UpdateStatus.SliceIndex = GetStringValue(eventData, "sliceIndex");
		UpdateStatus.TotalSlice = GetStringValue(eventData, "totalSlice");
		UpdateStatus.ZTop = GetStringValue(eventData, "zTop");
		UpdateStatus.ZCurrent = GetStringValue(eventData, "zCurrent");
		UpdateStatus.ZBottom = GetStringValue(eventData, "zBottom");
		UpdateStatus.Ratio = GetStringValue(eventData, "ratio");
		UpdateStatus.FpsState = GetStringValue(eventData, "fps");
		return true;
	}

	private static bool OnUpdatePanelState(object sender, EventArgs e)
	{
		Dictionary<string, object> eventData = LambdaArgs.GetEventData(e);
		MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
		string stringValue = GetStringValue(eventData, "side");
		if (stringValue == null)
		{
			return false;
		}
		bool? boolValue = GetBoolValue(eventData, "visible");
		if (!boolValue.HasValue)
		{
			return false;
		}
		string[] array = stringValue.Split(',');
		foreach (string text in array)
		{
			if (!OnUpdateSpecificPanelState(mainWindow, text, boolValue))
			{
				Side side = (Side)Enum.Parse(typeof(Side), text, ignoreCase: true);
				Visibility visibility2 = (mainWindow.GetConfigPanel(side).Visibility = ((!boolValue.Value) ? Visibility.Collapsed : Visibility.Visible));
				switch (side)
				{
					case Side.LEFT:
						mainWindow.LeftSplitter.Visibility = visibility2;
						break;
					case Side.MIDDLE:
						mainWindow.MiddleSplitter.Visibility = visibility2;
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
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
			return null;
		}
		if (data!.TryGetValue(key, out var value) && value is string result)
		{
			return result;
		}
		return null;
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
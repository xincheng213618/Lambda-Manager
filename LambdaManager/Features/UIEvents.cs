using System;
using System.Collections.Generic;
using Lambda;
using LambdaManager.Core;
using LambdaManager.Properties;
using Microsoft.Win32;

namespace LambdaManager.Features;

internal class UIEvents
{
	private static Dictionary<string, LambdaHandler> handlers = new Dictionary<string, LambdaHandler> { { "OPEN_FILE_DIALOG", OnOpenFileDialog } };

	public static void Initialze()
	{
		foreach (KeyValuePair<string, LambdaHandler> handler in handlers)
		{
			//Common.AddEventHandlert(handler.Key, handler.Value, once: false);
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
}

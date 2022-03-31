using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using LambdaManager.Properties;

namespace LambdaManager.Config;

internal class ConfigUILibrary
{
	private readonly Dictionary<Control, int> leftOrder = new Dictionary<Control, int>();

	private MainWindow Main { get; set; }

	public ConfigUILibrary(MainWindow Main)
	{
		this.Main = Main;
		Main.acquireView.Children.Clear();
	}

	internal bool ResolveControl(Component component, ConfigValidate validate)
	{
		string mount = component.Mount;
		string lib = component.Lib;
		if (mount == null || lib == null)
		{
			return false;
		}
		LoadControl(component, validate, lib, mount);
		return true;
	}

	private void LoadControl(Component component, ConfigValidate validate, string lib, string mount)
	{
		Assembly assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "/" + lib);
		string name = component.Name;
		if (name != null)
		{
			string fullName = lib.Replace(".dll", "") + "." + name;
			Side side = GetConfigSide(mount);
			if (side == Side.MENU)
			{
				string menuPath = GetMenuPath(mount);
				LoadMenuDialog(assembly, fullName, menuPath, validate);
			}
			else
			{
				int order = GetConfigPanelOrder(mount);
				LoadConfigPanel(assembly, fullName, order, validate, side);
			}
		}
	}

	private void LoadConfigPanel(Assembly assembly, string name, int order, ConfigValidate validate, Side side)
	{
		if (!(assembly.CreateInstance(name) is Control control))
		{
			validate.ReportNotExist(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Component, name, Resources.Class, null);
			return;
		}
		UIElementCollection list = Main.GetConfigPanel(side).Children;
		bool found = false;

		//for (int i = 0; i < list.Count; i++)
		//{
		//    if (list[i] is Control c && order < leftOrder[c])
		//    {
		//        list.Insert(i, control);
		//        found = true;
		//        break;
		//    }
		//}

		list.Clear();
		if (!found)
		{
			list.Add(control);
		}
		leftOrder[control] = order;
	}

	private void LoadMenuDialog(Assembly assembly, string name, string path, ConfigValidate validate)
	{
		Assembly assembly2 = assembly;
		string name2 = name;
		ConfigValidate validate2 = validate;
		MenuItem menu = Main.AddMenuItem(path);
		if (menu != null)
		{
			menu.Click += delegate
			{
				if (!(assembly2.CreateInstance(name2) is Window window))
				{
					validate2.ReportNotExist(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Component, name2, Resources.Class, null);
				}
				else
				{
					window.Owner = Main;
					window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
					window.ShowDialog();
				}
			};
		}
		else
		{
			validate2.Report(Severity.ERROR, LambdaManager.DataType.Type.Component, name2, Resources.Menu, null, Resources.CreateFailed);
		}
	}

	internal void LoadMenuCommand(Command command, ConfigValidate validate)
	{
		string name = command.Name;
		List<string> raises = command.Raise;
		if (name == null || raises == null)
		{
			return;
		}
		MenuItem menu = Main.AddMenuItem(name);
		if (menu != null)
		{
			menu.Click += delegate
			{
				foreach (string item in raises)
				{
					Common.CallEvent(item, IntPtr.Zero);
				}
			};
		}
		else
		{
			validate.Report(Severity.ERROR, LambdaManager.DataType.Type.Component, name, Resources.Menu, null, Resources.CreateFailed);
		}
	}

	private static Side GetConfigSide(string mount)
	{
		string[] tokens = mount.Split(':');
		if (tokens[0].StartsWith("top"))
		{
			return Side.TOP;
		}
		if (tokens[0].StartsWith("left"))
		{
			return Side.LEFT;
		}
		if (tokens[0].StartsWith("right"))
		{
			return Side.MIDDLE;
		}
		if (tokens[0].StartsWith("bottom"))
		{
			return Side.BOTTOM;
		}
		if (tokens[0].StartsWith("menu"))
		{
			return Side.MENU;
		}
		if (tokens[0].StartsWith("acquire"))
		{
			return Side.ACQUIRE;
		}
		if (tokens[0].StartsWith("project"))
		{
			return Side.PROJECT;
		}
		return Side.LEFT;
	}

	private static int GetConfigPanelOrder(string mount)
	{
		return int.Parse(mount.Split(':')[1].Trim());
	}

	private static string GetMenuPath(string mount)
	{
		return mount.Split(':')[1].Trim();
	}
}

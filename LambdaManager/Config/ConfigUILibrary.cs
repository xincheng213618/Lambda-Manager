using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Lambda;
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
		Main.leftView.Children.Clear();
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
			string name2 = lib.Replace(".dll", "") + "." + name;
			Side configSide = GetConfigSide(mount);
			if (configSide == Side.MENU)
			{
				string menuPath = GetMenuPath(mount);
				LoadMenuDialog(assembly, name2, menuPath, validate);
			}
			else
			{
				int configPanelOrder = GetConfigPanelOrder(mount);
				LoadConfigPanel(assembly, name2, configPanelOrder, validate, configSide);
			}
		}
	}

	private void LoadConfigPanel(Assembly assembly, string name, int order, ConfigValidate validate, Side side)
	{
		if (!(assembly.CreateInstance(name) is Control control))
		{
			validate.ReportNotExist(Severity.FATAL_ERROR, Type.Component, name, Resources.Class, null);
			return;
		}
		UIElementCollection children = Main.GetConfigPanel(side).Children;
		bool flag = false;
		for (int i = 0; i < children.Count; i++)
		{
			if (children[i] is Control key && order < leftOrder[key])
			{
				children.Insert(i, control);
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			children.Add(control);
		}
		leftOrder[control] = order;
	}

	private void LoadMenuDialog(Assembly assembly, string name, string path, ConfigValidate validate)
	{
		Assembly assembly2 = assembly;
		string name2 = name;
		ConfigValidate validate2 = validate;
		MenuItem menuItem = Main.AddMenuItem(path);
		if (menuItem != null)
		{
			menuItem.Click += delegate
			{
				if (!(assembly2.CreateInstance(name2) is Window window))
				{
					validate2.ReportNotExist(Severity.FATAL_ERROR, Type.Component, name2, Resources.Class, null);
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
			validate2.Report(Severity.ERROR, Type.Component, name2, Resources.Menu, null, Resources.CreateFailed);
		}
	}

	private static Side GetConfigSide(string mount)
	{
		string[] array = mount.Split(':');
		if (array[0].StartsWith("top"))
		{
			return Side.TOP;
		}
		if (array[0].StartsWith("left"))
		{
			return Side.LEFT;
		}
		if (array[0].StartsWith("right"))
		{
			return Side.RIGHT;
		}
		if (array[0].StartsWith("bottom"))
		{
			return Side.BOTTOM;
		}
		if (array[0].StartsWith("menu"))
		{
			return Side.MENU;
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

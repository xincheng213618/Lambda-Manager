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
	private Dictionary<Control, int> leftOrder = new Dictionary<Control, int>();

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
			string fullName = lib.Replace(".dll", "") + "." + name;
			if (IsConfigLeftView(mount))
			{
				int order = GetConfigPanelOrder(mount);
				LoadConfigPanel(assembly, fullName, order, validate);
			}
			else if (IsConfigMenu(mount))
			{
				string menuPath = GetMenuPath(mount);
				LoadMenuDialog(assembly, fullName, menuPath, validate);
			}
		}
	}

	private void LoadConfigPanel(Assembly assembly, string name, int order, ConfigValidate validate)
	{
		if (!(assembly.CreateInstance(name) is Control control))
		{
			validate.ReportNotExist(Severity.FATAL_ERROR, Type.Component, name, Resources.Class, null);
			return;
		}
		UIElementCollection list = Main.leftView.Children;
		bool found = false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] is Control c && order < leftOrder[c])
			{
				list.Insert(i, control);
				found = true;
				break;
			}
		}
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

	private static bool IsConfigLeftView(string mount)
	{
		return mount.Split(':')[0].StartsWith("config");
	}

	private static int GetConfigPanelOrder(string mount)
	{
		return int.Parse(mount.Split(':')[1].Trim());
	}

	private static bool IsConfigMenu(string mount)
	{
		return mount.Split(':')[0].StartsWith("menu");
	}

	private static string GetMenuPath(string mount)
	{
		return mount.Split(':')[1].Trim();
	}
}

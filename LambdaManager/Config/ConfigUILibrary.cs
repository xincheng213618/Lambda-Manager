using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using LambdaManager.Core;
using LambdaManager.DataType;

namespace LambdaManager.Config;

public class ConfigUILibrary: ILambdaUI
{
	private readonly Dictionary<Control, int> leftOrder = new Dictionary<Control, int>();

    public MainWindow Main { get; set; }

	public ConfigUILibrary(MainWindow Main)
	{
		this.Main = Main;
    }

    public void LoadControl(string name, string lib, string mount)
	{
		Assembly assembly = Assembly.LoadFile(Directory.GetCurrentDirectory() + "/" + lib);
		if (name != null)
		{
			string fullName = lib.Replace(".dll", "") + "." + name;     
			Side side = GetConfigSide(mount);
			if (side == Side.MENU)
			{
				string menuPath = GetMenuPath(mount);
				LoadMenuDialog(assembly, fullName, menuPath);
			}
			else
			{
				int order = GetConfigPanelOrder(mount);
				LoadConfigPanel(assembly, fullName, order, side);
			}
		}
	}

	private void LoadConfigPanel(Assembly assembly, string name, int order, Side side)
    {
        if (!(assembly.CreateInstance(name) is Control control))
        {
            return;
        }

		UIElementCollection list = Main.GetConfigPanel(side).Children;
        bool found = false;
		if (!found)
		{
			list.Add(control);
		}
		leftOrder[control] = order;
	}

	private void LoadMenuDialog(Assembly assembly, string name, string path)
	{
		Assembly assembly2 = assembly;
		string name2 = name;
		MenuItem menu = Main.AddMenuItem(path);
		if (menu != null)
		{
			menu.Click += delegate
			{
				if (!(assembly2.CreateInstance(name2) is Window window))
				{

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

		}
	}

	public void LoadMenuCommand(Command command)
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
		}
	}

	private static Side GetConfigSide(string mount)
	{
		string[] tokens = mount.Split(':');
		return (Side)Enum.Parse(typeof(Side), tokens[0].Trim(), ignoreCase: true);
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

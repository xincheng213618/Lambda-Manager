using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Global;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using LambdaManager.Properties;

namespace LambdaManager.Config;

public class ConfigUILibrary
{
	private readonly Dictionary<Control, int> leftOrder = new Dictionary<Control, int>();

    private static ConfigUILibrary instance;
    private static readonly object locker = new();

    public static ConfigUILibrary GetInstance()
    {
        lock (locker) { if (instance == null) { instance = new ConfigUILibrary(); } }
        return instance;
    }

    public MainWindow Main { get; set; }

	private ConfigUILibrary()
	{

	}

	internal bool ResolveControl(Component component, ConfigValidate validate)
	{
		string mount = component.Mount;
		string lib = component.Lib;
		if (mount == null || lib == null)
		{
			return false;
		}
        Application.Current.Dispatcher.Invoke(delegate
        {
            LoadControl(component, validate, lib, mount);
        });
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
        if (Main.GetConfigPanel(side) is StackPanel stackPanel)
            if (stackPanel.Parent is Viewbox viewbox)
                if (viewbox.Parent is ScrollViewer scrollViewer)
                    if (scrollViewer.Parent is TabItem tabItem)
                        tabItem.Visibility = Visibility.Visible;

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

		//list.Clear();
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

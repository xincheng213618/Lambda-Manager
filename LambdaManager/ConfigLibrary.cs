using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Xml.Linq;
using Lambda;
using LambdaManager.Config;
using LambdaManager.Core;
using LambdaManager.DataType;
using LambdaManager.Properties;
using LambdaManager.Utils;
using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using Swifter.Json;

namespace LambdaManager;

internal class ConfigLibrary
{
	private readonly Solution solution = FunctionExecutor.Solution;

	public ConfigLibrary()
	{
		Common.Init();
	}

	public bool Load(string path)
	{
		XElement root = XDocument.Load(path).Root;
		if (root == null)
		{
			return false;
		}
		ResolveMain(root);
		List<Component> list = (from c in root.Descendants("component")
			select new Component
			{
				Name = c.Attribute((XName?)"name")?.Value,
				Lib = c.Attribute((XName?)"lib")?.Value,
				Init = Split(c.Attribute((XName?)"init")?.Value, ','),
				Mount = c.Attribute((XName?)"mount")?.Value,
				Depend = Split(c.Attribute((XName?)"depend")?.Value, ','),
				Procedures = (from p in c.Elements("procedure")
					select new Procedure
					{
						Name = p.Attribute((XName?)"name")?.Value,
						Icon = p.Attribute((XName?)"icon")?.Value,
						Event = Split(p.Attribute((XName?)"event")?.Value, '|'),
						Key = Split(p.Attribute((XName?)"key")?.Value, ','),
						Arg = Split(p.Attribute((XName?)"arg")?.Value, ','),
						Timer = p.Attribute((XName?)"timer")?.Value,
						Aysnc = p.Attribute((XName?)"async")?.Value,
						Exports = Split(p.Attribute((XName?)"export")?.Value, ','),
						Actions = (from a in p.Elements("action")
							select new LambdaManager.DataType.Action
							{
								Name = a.Attribute((XName?)"name")?.Value,
								Raise = Split(a.Attribute((XName?)"raise")?.Value, '|'),
								Key = Split(a.Attribute((XName?)"key")?.Value, ','),
								Arg = Split(a.Attribute((XName?)"arg")?.Value, ','),
								Value = a.Attribute((XName?)"value")?.Value,
								Component = a.Attribute((XName?)"component")?.Value,
								Times = Convert.ToInt32(a.Attribute((XName?)"times")?.Value ?? "1"),
								Inputs = (from i in a.Elements("input")
									select new Input
									{
										Name = i.Attribute((XName?)"name")?.Value,
										Type = i.Attribute((XName?)"type")?.Value,
										Value = i.Attribute((XName?)"value")?.Value,
										For = i.Attribute((XName?)"for")?.Value
									}).ToList(),
								Outputs = (from o in a.Elements("output")
									select new Output
									{
										Name = o.Attribute((XName?)"name")?.Value,
										Type = o.Attribute((XName?)"type")?.Value,
										Value = o.Attribute((XName?)"value")?.Value
									}).ToList(),
								Aysnc = a.Attribute((XName?)"async")?.Value
							}).ToList()
					}).ToList()
			}).ToList();
		ConfigValidate configValidate = ValidateConfiguration(list);
		LoadComponents(list, configValidate);
		LoadProcedures(list, configValidate);
		DeferProcessing(configValidate);
		ResolveAsync(list, configValidate);
		ResolveProcedureExports(configValidate);
		ResolveActionImports(configValidate);
		ResolveVariables(list, configValidate);
		ResolveProcudureEvents(list, configValidate);
		ResolveActionRaise(list, configValidate);
		RegisterEventCallbacks(configValidate);
		ResolveFunctionArgument(configValidate);
		InitializeLibrary();
		InitializeScheduler();
		return configValidate.Severity < Severity.FATAL_ERROR;
	}

	private static void ResolveMain(XElement root)
	{
		MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
		string text = root.Attribute((XName?)"title")?.Value;
		if (text != null)
		{
			mainWindow.Title = text;
		}
		string text2 = root.Attribute((XName?)"left")?.Value;
		if (text2 != null)
		{
			int num = int.Parse(text2);
			if (num > 50)
			{
				mainWindow.leftView.Width = num;
			}
		}
		string text3 = root.Attribute((XName?)"right")?.Value;
		if (text3 != null)
		{
			int num2 = int.Parse(text3);
			if (num2 > 20)
			{
				mainWindow.rightView.Width = num2;
			}
		}
		mainWindow.Notice = root.Attribute((XName?)"notice")?.Value;
		if (root.Attribute((XName?)"maximize")?.Value == "true")
		{
			mainWindow.Maximize = true;
		}
	}

	private static List<string>? Split(string? text, char delimeter)
	{
		if (text == null)
		{
			return null;
		}
		List<string> list = new List<string>();
		string[] array = text!.Split(delimeter);
		foreach (string text2 in array)
		{
			list.Add(text2.Trim());
		}
		return list;
	}

	private static ConfigValidate ValidateConfiguration(List<Component> components)
	{
		ConfigValidate configValidate = new ConfigValidate();
		configValidate.CheckLibShortName(components);
		foreach (Component component in components)
		{
			configValidate.Check(component);
			List<Procedure> procedures = component.Procedures;
			if (procedures == null)
			{
				continue;
			}
			foreach (Procedure item in procedures)
			{
				configValidate.Check(item);
				List<LambdaManager.DataType.Action> actions = item.Actions;
				if (actions == null)
				{
					continue;
				}
				int num = 0;
				foreach (LambdaManager.DataType.Action item2 in actions)
				{
					item2.Index = num++;
					configValidate.Check(item2, item, component, components);
					List<Input> inputs = item2.Inputs;
					int num2 = 0;
					if (inputs != null)
					{
						foreach (Input item3 in inputs)
						{
							configValidate.Check(item3, num2++, item2, item, component);
						}
					}
					List<Output> outputs = item2.Outputs;
					if (outputs == null)
					{
						continue;
					}
					foreach (Output item4 in outputs)
					{
						configValidate.Check(item4, num2++, item2, item, component);
					}
				}
			}
		}
		return configValidate;
	}

	private void LoadComponents(List<Component> components, ConfigValidate validate)
	{
		validate.CheckLocalActions();
		ConfigUILibrary configUILibrary = new ConfigUILibrary((MainWindow)Application.Current.MainWindow);
		foreach (Component component in components)
		{
			string lib = component.Lib;
			if (lib != null && !validate.Libs.Contains(lib))
			{
				if (!configUILibrary.ResolveControl(component, validate))
				{
					LoadLibrary(component, validate);
				}
				validate.Libs.Add(lib);
			}
		}
	}

	private void LoadLibrary(Component component, ConfigValidate validate)
	{
		string lib = component.Lib;
		if (lib == null)
		{
			return;
		}
		IntPtr addr = NativeLibrary.Load(lib);
		Lib lib2 = new Lib
		{
			Addr = addr,
			Path = lib
		};
		solution.Libs.Add(lib2);
		List<LambdaManager.DataType.Action> localActions = validate.GetLocalActions(component);
		if (localActions == null)
		{
			return;
		}
		for (int i = 0; i < localActions.Count; i++)
		{
			LambdaManager.DataType.Action action = localActions[i];
			string sigName = action.GetSigName(component);
			EntryPoint entryPoint = validate.GetEntryPoint(sigName);
			if (entryPoint == null)
			{
				EntryPoint entryPoint2 = ResolveFunction(action, component, lib2, validate);
				if (entryPoint2 != null)
				{
					validate.AddEntryPoint(sigName, entryPoint2, action);
				}
			}
			else
			{
				SetFunction(action, entryPoint);
			}
		}
	}

	private static EntryPoint? ResolveFunction(LambdaManager.DataType.Action action, Component component, Lib lib, ConfigValidate validate)
	{
		FunctionResolver functionResolver = new FunctionResolver(lib);
		IntPtr address = functionResolver.GetAddress(action, component);
		if (address == IntPtr.Zero)
		{
			validate.ReportNotExist(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.Signature, action.ToString());
			return null;
		}
		string signatureCodes = functionResolver.GetSignatureCodes();
		List<TypeInfo> typeInfos = functionResolver.TypeInfos;
		EntryPoint entryPoint = new EntryPoint
		{
			FuncAddr = address,
			Code = signatureCodes,
			Paremeters = typeInfos,
			InputCount = (action.Inputs?.Count ?? 0)
		};
		List<EntryPoint> list = lib.EntryPoints;
		if (list == null)
		{
			list = (lib.EntryPoints = new List<EntryPoint>());
		}
		list.Add(entryPoint);
		List<object> defaultValues = functionResolver.DefaultValues;
		Function function2 = (action.Function = new Function
		{
			EntryPoint = entryPoint,
			Values = defaultValues,
			Times = action.Times
		});
		return entryPoint;
	}

	private static Function SetFunction(LambdaManager.DataType.Action action, EntryPoint entryPoint)
	{
		FunctionResolver functionResolver = new FunctionResolver(null);
		functionResolver.Parse(action);
		List<object> defaultValues = functionResolver.DefaultValues;
		return action.Function = new Function
		{
			EntryPoint = entryPoint,
			Values = defaultValues,
			Times = action.Times
		};
	}

	private void LoadProcedures(List<Component> components, ConfigValidate validate)
	{
		foreach (Component component in components)
		{
			LoadProcedure(component, validate);
		}
	}

	private void LoadProcedure(Component component, ConfigValidate validate)
	{
		List<Procedure> procedures = component.Procedures;
		if (procedures == null)
		{
			return;
		}
		foreach (Procedure item in procedures)
		{
			List<string> @event = item.Event;
			Routine routine = new Routine();
			validate.AddRoutineProcedure(routine, item);
			item.Routine = routine;
			item.IsGUIProcedure = component.IsGUIComponent();
			ResolveRotine(routine, item, component, validate);
			bool flag = IsInitialRotine(component, item);
			if (flag)
			{
				RegisterCallbackRoutine(solution.InitEvent, routine);
			}
			if (@event == null)
			{
				if (!flag)
				{
					RegisterCallbackRoutine(solution.UndefinedEvent, routine);
				}
			}
			else
			{
				List<Event> list = new List<Event>();
				foreach (string item2 in @event)
				{
					solution.Events.TryGetValue(item2, out var value);
					if (value == null)
					{
						value = new Event
						{
							Type = item2
						};
						solution.Events.Add(item2, value);
					}
					RegisterCallbackRoutine(value, routine);
					list.Add(value);
				}
				validate.AddDeferEvents(item, list);
			}
			string timer = item.Timer;
			if (timer != null)
			{
				FunctionJob.AddSchedule(new Scheduler
				{
					Name = item.Name,
					Timer = timer,
					Routine = routine
				});
			}
			if (item.Aysnc == "true")
			{
				routine.Async = true;
			}
		}
	}

	private static bool IsInitialRotine(Component component, Procedure procedure)
	{
		string name = procedure.Name;
		List<string> init = component.Init;
		if (name != null && init != null)
		{
			return init.IndexOf(name) != -1;
		}
		return false;
	}

	private static void ResolveRotine(Routine routine, Procedure procedure, Component component, ConfigValidate validate)
	{
		List<LambdaManager.DataType.Action> actions = procedure.Actions;
		if (actions == null)
		{
			return;
		}
		foreach (LambdaManager.DataType.Action item in actions)
		{
			List<Function> list = routine.Functions;
			if (list == null)
			{
				list = (routine.Functions = new List<Function>());
			}
			Function function = ResolveActionFunction(item, procedure, component, validate);
			if (function != null)
			{
				list.Add(function);
				validate.AddFunctionRoutine(function, routine);
				validate.AddFunctionAction(function, item);
				continue;
			}
			string fullName = FunctionResolver.GetFullName(component, procedure, item.ToString());
			string value = item.Name;
			if (item.Component != null)
			{
				value = item.Component + "::" + item.Name;
			}
			validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, fullName, Resources.Referring, value);
		}
	}

	private void RegisterCallbackRoutine(Event evt, Routine routine)
	{
		solution.Routines.TryGetValue(evt, out var value);
		if (value == null)
		{
			value = new List<Routine>();
			solution.Routines.Add(evt, value);
		}
		value.Add(routine);
	}

	private static Function? ResolveActionFunction(LambdaManager.DataType.Action action, Procedure procedure, Component? component, ConfigValidate validate)
	{
		Function function = action.Function;
		if (function == null)
		{
			string component2 = action.Component;
			if (component2 == null)
			{
				if (component != null)
				{
					function = ResolveActionToFunction(component, action, validate);
					if (function != null)
					{
						return function;
					}
					function = ResolveActionToProcedure(component, action, validate);
					if (function != null)
					{
						return function;
					}
				}
				string fullName = FunctionResolver.GetFullName(component, procedure, action.Name);
				validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, fullName, Resources.EntryPoint, null);
			}
			else
			{
				function = ResolveActionToExternalFunction(component2, action, validate);
				if (function != null)
				{
					return function;
				}
				component = validate.GetComponentOfLocalActions(component2);
				if (component == null)
				{
					throw new Exception("system error: 101");
				}
				function = ResolveActionToProcedure(component, action, validate);
				if (function != null)
				{
					return function;
				}
			}
			return null;
		}
		return function;
	}

	private static Function? ResolveActionToFunction(Component component, LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		List<LambdaManager.DataType.Action> localActions = validate.GetLocalActions(component);
		if (localActions != null)
		{
			string sigName = action.GetSigName(component);
			foreach (LambdaManager.DataType.Action item in localActions)
			{
				if (item.GetSigName(component) == sigName)
				{
					EntryPoint entryPoint = item.Function?.EntryPoint;
					if (entryPoint != null)
					{
						return SetFunction(action, entryPoint);
					}
				}
			}
		}
		return null;
	}

	private static Function? ResolveActionToExternalFunction(string componentName, LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		Component componentOfLocalActions = validate.GetComponentOfLocalActions(componentName);
		if (componentOfLocalActions == null)
		{
			validate.Report(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Component, componentName, Resources.Action, action.Name, Resources.Undefined);
			return null;
		}
		string sigName = action.GetSigName(componentOfLocalActions);
		if (sigName != null)
		{
			EntryPoint entryPoint = validate.GetEntryPoint(sigName);
			if (entryPoint == null)
			{
				string sigNameWithoutParameters = new Regex("@0$").Replace(sigName, "");
				List<KeyValuePair<string, EntryPoint>> similarEntryPoints = validate.GetSimilarEntryPoints(sigNameWithoutParameters);
				if (similarEntryPoints.Count != 1)
				{
					return null;
				}
				entryPoint = similarEntryPoints.First().Value;
			}
			List<object> defaultValues = validate.GetDefaultValues(action, entryPoint);
			return action.Function = new Function
			{
				EntryPoint = entryPoint,
				Values = defaultValues,
				Times = action.Times
			};
		}
		return null;
	}

	private static Function? ResolveActionToProcedure(Component component, LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		List<Procedure> procedures = component.Procedures;
		if (procedures != null)
		{
			Procedure procedure = null;
			foreach (Procedure item in procedures)
			{
				if (!(item.Name == action.Name))
				{
					continue;
				}
				Function function = ResolveProcedureToFunction(action, item);
				if (function != null)
				{
					List<Input>? inputs = action.Inputs;
					if (inputs != null && inputs!.Count > 0)
					{
						ResolveFunctionExports(action, function, item, validate);
					}
					return function;
				}
				procedure = item;
			}
			if (procedure != null)
			{
				validate.AddDeferResolvedAction(action, procedure);
			}
		}
		return null;
	}

	private static Function? ResolveProcedureToFunction(LambdaManager.DataType.Action action, Procedure procedure)
	{
		Routine routine = procedure.Routine;
		if (routine == null)
		{
			return null;
		}
		Function function = new Function
		{
			Values = new List<object>(),
			Times = action.Times
		};
		function.Routine = routine;
		action.Function = function;
		return function;
	}

	private static List<Link>? ResolveProcedureInput(Procedure procedure, LambdaManager.DataType.Action source, ConfigValidate validate)
	{
		List<Input> inputs = source.Inputs;
		List<LambdaManager.DataType.Action> actions = procedure.Actions;
		if (actions == null || inputs == null)
		{
			return null;
		}
		bool sourceTimes = source.Times > 1;
		List<Link> list = new List<Link>();
		for (int i = 0; i < inputs.Count; i++)
		{
			List<Link> list2 = TraverseLinkTarget(actions, inputs[i], sourceTimes, validate);
			if (list2 != null && list2.Count > 0)
			{
				Link link = CheckLinkedSource(list2, source, i, validate);
				if (link != null)
				{
					list.Add(link);
				}
			}
		}
		return list;
	}

	private static List<Link>? TraverseLinkTarget(List<LambdaManager.DataType.Action> actions, IO source, bool sourceTimes, ConfigValidate validate)
	{
		List<Link> list = new List<Link>();
		foreach (LambdaManager.DataType.Action action in actions)
		{
			if (action != null && action.Component != null)
			{
				CheckActionOrigin(action, validate);
			}
			if (action == null)
			{
				continue;
			}
			Routine routine = action.Function?.Routine;
			List<LambdaManager.DataType.Action> list2 = validate.GetProcedure(routine)?.Actions;
			if (list2 != null)
			{
				List<Link> list3 = TraverseLinkTarget(list2, source, sourceTimes, validate);
				if (list3 != null && list3.Count > 0)
				{
					list.AddRange(list3);
				}
				continue;
			}
			int num = 0;
			foreach (IO item in action.IoRange)
			{
				string text = source.Type;
				if (sourceTimes)
				{
					text = FunctionResolver.CleanSuffix(text, "[]");
				}
				List<CastType> castTypes = FunctionResolver.ResolveLinkCastType(item.Name, item.Type, source.Name, text);
				Link link = new Link
				{
					Target = action,
					CastTypes = castTypes,
					TargetIndex = num
				};
				if (CheckLinkCastType(link))
				{
					list.Add(link);
				}
				num++;
			}
		}
		return list;
	}

	private static bool CheckLinkCastType(Link link)
	{
		CastType castType = link.CastTypes[0];
		if ((uint)(castType - 19) <= 1u)
		{
			return false;
		}
		return true;
	}

	private static Link? CheckLinkedSource(List<Link> links, LambdaManager.DataType.Action source, int index, ConfigValidate validate)
	{
		if (links == null)
		{
			return null;
		}
		links.Sort((Link x, Link y) => CompareTo(x.CastTypes, y.CastTypes));
		Link link = links[0];
		link.Source = source;
		link.SourceIndex = index;
		return link;
	}

	private static void DeferProcessing(ConfigValidate validate)
	{
		Dictionary<LambdaManager.DataType.Action, Procedure> dictionary = ResolveDeferActions(validate.GetDeferResolvedActions());
		int num = 0;
		while (dictionary.Count > 0)
		{
			dictionary = ResolveDeferActions(dictionary);
			num++;
			if (num != 100)
			{
				continue;
			}
			{
				foreach (KeyValuePair<LambdaManager.DataType.Action, Procedure> item in dictionary)
				{
					validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, item.Key.Name, Resources.EntryPoint, null);
				}
				break;
			}
		}
	}

	private static Dictionary<LambdaManager.DataType.Action, Procedure> ResolveDeferActions(Dictionary<LambdaManager.DataType.Action, Procedure> defers)
	{
		Dictionary<LambdaManager.DataType.Action, Procedure> dictionary = new Dictionary<LambdaManager.DataType.Action, Procedure>();
		foreach (KeyValuePair<LambdaManager.DataType.Action, Procedure> defer in defers)
		{
			LambdaManager.DataType.Action key = defer.Key;
			Procedure value = defer.Value;
			Function function = ResolveProcedureToFunction(key, value);
			if (function == null)
			{
				dictionary.Add(key, value);
				continue;
			}
			List<LambdaManager.DataType.Action> actions = value.Actions;
			if (actions != null)
			{
				int num = actions.IndexOf(key);
				if (num >= 0)
				{
					value.Routine?.Functions?.Insert(num, function);
				}
			}
			throw new Exception("system error: 100");
		}
		return dictionary;
	}

	private static void ResolveAsync(List<Component> components, ConfigValidate validate)
	{
		foreach (Component component in components)
		{
			List<Procedure> procedures = component.Procedures;
			if (procedures == null)
			{
				continue;
			}
			foreach (Procedure item in procedures)
			{
				List<LambdaManager.DataType.Action> actions = item.Actions;
				if (actions == null)
				{
					continue;
				}
				foreach (LambdaManager.DataType.Action item2 in actions)
				{
					ResolveActionAsync(item2, validate);
				}
			}
		}
	}

	private static bool ResolveActionAsync(LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		Function function = action.Function;
		if (function == null)
		{
			return false;
		}
		if (function.Async)
		{
			return true;
		}
		if (action.Aysnc == "true")
		{
			function.Async = true;
			return true;
		}
		if (function.Routine != null)
		{
			return false;
		}
		EntryPoint entryPoint = function.EntryPoint;
		if (entryPoint == null)
		{
			return false;
		}
		LambdaManager.DataType.Action action2 = validate.GetAction(entryPoint);
		if (action2 == null || action2 == action)
		{
			return false;
		}
		if (ResolveActionAsync(action2, validate))
		{
			function.Async = true;
			return true;
		}
		return false;
	}

	private static void ResolveProcedureExports(ConfigValidate validate)
	{
		foreach (KeyValuePair<Procedure, List<ExportInfo>> procedureExport in validate.GetProcedureExports())
		{
			foreach (ExportInfo item in procedureExport.Value)
			{
				EntryPoint entryPoint = item.Action.Function?.EntryPoint;
				if (entryPoint != null)
				{
					Dictionary<int, int> dictionary = entryPoint.Exports;
					if (dictionary == null)
					{
						dictionary = (entryPoint.Exports = new Dictionary<int, int>());
					}
					dictionary[item.ArgumentIndex] = item.ExportIndex;
				}
			}
		}
	}

	private static void ResolveFunctionExports(LambdaManager.DataType.Action action, Function function, Procedure procedure, ConfigValidate validate)
	{
		FunctionResolver functionResolver = new FunctionResolver(null);
		functionResolver.Parse(action);
		function.Values = functionResolver.DefaultValues;
		List<Link> list = ResolveProcedureInput(procedure, action, validate);
		if (list == null)
		{
			return;
		}
		Routine routine = new Routine();
		foreach (Link item in list)
		{
			ResolveVariable(routine, item, byVariable: true, validate);
		}
		function.Exports = routine.Referring;
	}

	private static void ResolveActionImports(ConfigValidate validate)
	{
		foreach (KeyValuePair<LambdaManager.DataType.Action, List<ImportInfo>> actionImport in validate.GetActionImports())
		{
			LambdaManager.DataType.Action key = actionImport.Key;
			List<ImportInfo> value = actionImport.Value;
			Routine routine = key.Function?.Routine;
			if (routine == null)
			{
				if (validate.CheckActionImports(value, key).Count > 0)
				{
					validate.ReportActionImportNotSupported(key, value);
				}
				continue;
			}
			List<string> list = validate.GetProcedure(routine)?.Exports;
			if (list == null)
			{
				validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, key.Name, Resources.Export, null);
				continue;
			}
			Function function = key.Function;
			if (function == null)
			{
				continue;
			}
			foreach (ImportInfo item in value)
			{
				int num = list.IndexOf(item.Name);
				if (num == -1)
				{
					validate.ReportNotFound(Severity.ERROR, LambdaManager.DataType.Type.Action, key.Name, Resources.Import, item.Name);
					continue;
				}
				Dictionary<int, int> dictionary = function.Imports;
				if (dictionary == null)
				{
					dictionary = (function.Imports = new Dictionary<int, int>());
				}
				dictionary.Add(num, item.ArgumentIndex);
			}
		}
	}

	private static void ResolveVariables(List<Component> components, ConfigValidate validate)
	{
		foreach (Component component in components)
		{
			List<Procedure> procedures = component.Procedures;
			if (procedures == null)
			{
				continue;
			}
			foreach (Procedure item in procedures)
			{
				ResolveProcedureVariables(item, validate);
			}
		}
	}

	private static void ResolveProcedureVariables(Procedure procedure, ConfigValidate validate)
	{
		List<LambdaManager.DataType.Action> actions = procedure.Actions;
		if (actions == null)
		{
			return;
		}
		List<Link> list = new List<Link>();
		for (int i = 0; i < actions.Count; i++)
		{
			int num = 0;
			LambdaManager.DataType.Action action = actions[i];
			foreach (IO item in action.IoRange)
			{
				List<Link> list2 = TraverseLinkSource(actions, item, i, validate);
				if (list2 != null && list2.Count > 0)
				{
					Link link = CheckLinkedTarget(list2, action, num, validate);
					if (link != null)
					{
						list.Add(link);
					}
				}
				num++;
			}
		}
		foreach (Link item2 in list)
		{
			ResolveVariable(procedure.Routine, item2, byVariable: true, validate);
		}
	}

	private static List<Link>? TraverseLinkSource(List<LambdaManager.DataType.Action> actions, IO target, int targetIndex, ConfigValidate validate)
	{
		if (target.Value != null || target.Name == null)
		{
			return null;
		}
		List<Link> list = new List<Link>();
		for (int num = targetIndex - 1; num >= 0; num--)
		{
			LambdaManager.DataType.Action action = actions[num];
			if (action != null && action.Component != null)
			{
				CheckActionOrigin(action, validate);
			}
			if (action != null)
			{
				int num2 = action.GetArgsCount() - 1;
				foreach (IO item in action.IoReverseRange)
				{
					List<CastType> castTypes = FunctionResolver.ResolveLinkCastType(target.Name, target.Type, item.Name, item.Type);
					Link link = new Link
					{
						Source = action,
						CastTypes = castTypes,
						SourceIndex = num2
					};
					if (CheckLinkCastType(list, link))
					{
						return list;
					}
					num2--;
				}
			}
		}
		return list;
	}

	private static LambdaManager.DataType.Action? CheckActionOrigin(LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		Function function = action.Function;
		if (function == null)
		{
			return null;
		}
		LambdaManager.DataType.Action action2 = null;
		Routine routine = function.Routine;
		if (routine == null)
		{
			action2 = validate.GetOriginalAction(function);
		}
		else
		{
			List<LambdaManager.DataType.Action> list = validate.GetProcedure(routine)?.Actions;
			if (list != null && list.Count > 0)
			{
				action2 = list[0];
			}
		}
		if (action2 != null)
		{
			CopyOriginInputs(action, action2.Inputs, validate);
			action.Outputs = action2.Outputs;
		}
		return action2;
	}

	private static void CopyOriginInputs(LambdaManager.DataType.Action action, List<Input>? inputs, ConfigValidate validate)
	{
		List<Input> inputs2 = action.Inputs;
		if (inputs2 == null)
		{
			action.Inputs = inputs;
		}
		else
		{
			if (inputs == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			int num = 0;
			for (int i = 0; i < inputs2.Count; i++)
			{
				bool flag = false;
				for (int j = num; j < inputs!.Count; j++)
				{
					if (inputs![j].Name == inputs2[i].Name || inputs![j].Type == inputs2[i].Type)
					{
						dictionary.Add(j, i);
						num = j + 1;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					validate.Report(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, action.Name, LambdaManager.DataType.Type.Input.Description(), inputs2[i].Name ?? ("index at " + i), Resources.OriginInputsNotMatch);
				}
			}
			for (int k = 0; k < inputs!.Count; k++)
			{
				if (dictionary.TryGetValue(k, out var value))
				{
					if (inputs2[value].Name == null)
					{
						inputs2[value].Name = inputs![k].Name;
					}
					inputs2[value].Type = inputs![k].Type;
					if (inputs2[value].Value == null)
					{
						inputs2[value].Value = inputs![k].Value;
					}
				}
				else if (k < inputs2.Count)
				{
					inputs2.Insert(k, inputs![k]);
				}
				else
				{
					inputs2.Add(inputs![k]);
				}
			}
		}
	}

	private static Link? CheckLinkedTarget(List<Link> links, LambdaManager.DataType.Action target, int index, ConfigValidate validate)
	{
		if (links == null)
		{
			return null;
		}
		links.Sort((Link x, Link y) => CompareTo(x.CastTypes, y.CastTypes));
		Link link = links[0];
		if (link.CastTypes[0] == CastType.TYPE_NOT_MATCH)
		{
			validate.ReportLinkNotMatch(link, target, index);
			return null;
		}
		link.Target = target;
		link.TargetIndex = index;
		return link;
	}

	private static int CompareTo(List<CastType> l1, List<CastType> l2)
	{
		int num = l1[0].CompareTo(l2[0]);
		if (num == 0)
		{
			int count = l1.Count;
			int count2 = l2.Count;
			if (count == 1 && count2 > 1)
			{
				return -1;
			}
			if (count2 == 1 && count > 1)
			{
				return 1;
			}
			if (count == 1 && count2 == 1)
			{
				return 0;
			}
			num = l1[1].CompareTo(l2[1]);
			if (num == 0)
			{
				if (count == 2 && count2 > 2)
				{
					return -1;
				}
				if (count2 == 2 && count > 2)
				{
					return 1;
				}
				if (count == 2 && count2 == 2)
				{
					return 0;
				}
				return l1[2].CompareTo(l2[2]);
			}
		}
		return num;
	}

	private static bool CheckLinkCastType(List<Link> matches, Link link)
	{
		switch (link.CastTypes[0])
		{
		case CastType.NAME_NOT_MATCH:
			return false;
		case CastType.NO_CAST:
			matches.Clear();
			matches.Add(link);
			return true;
		default:
			matches.Add(link);
			return false;
		}
	}

	private static void ResolveVariable(Routine? routine, Link link, bool byVariable, ConfigValidate validate)
	{
		Function function = link.Target.Function;
		Function function2 = link.Source.Function;
		if (function2 != null)
		{
			function2.IsReferred = true;
			if (function2.Async && link.SourceIndex >= function2.EntryPoint?.InputCount)
			{
				validate.Report(Severity.ERROR, LambdaManager.DataType.Type.Action, validate.GetAction(function2)?.Name, Resources.Async, null, Resources.AsyncWithOutputReferredNotSupport);
			}
		}
		if (routine == null)
		{
			return;
		}
		Location location = null;
		if (byVariable)
		{
			location = ResolveVariableReferred(link, routine, function2);
		}
		else if (function2 != null)
		{
			location = new Location
			{
				Function = function2,
				Index = link.SourceIndex
			};
			if (link is VirtualLink virtualLink)
			{
				location.Function = virtualLink.SourceFunction;
			}
		}
		ResolveVariableReferring(link, routine, function, location);
	}

	private static Location? ResolveVariableReferred(Link link, Routine routine, Function? source)
	{
		if (source == null)
		{
			return null;
		}
		Dictionary<Function, List<Location>> dictionary = routine.Referred;
		if (dictionary == null)
		{
			dictionary = (routine.Referred = new Dictionary<Function, List<Location>>());
		}
		dictionary.TryGetValue(source, out var value);
		if (value == null)
		{
			value = new List<Location>();
			dictionary.Add(source, value);
		}
		Location location = new Location
		{
			Function = source,
			Index = link.SourceIndex
		};
		if (link is VirtualLink virtualLink)
		{
			location.Function = virtualLink.SourceFunction;
		}
		if (value.IndexOf(location) == -1)
		{
			value.Add(location);
		}
		return location;
	}

	private static void ResolveVariableReferring(Link link, Routine routine, Function? target, Location? source)
	{
		if (source != null && target != null)
		{
			Dictionary<Location, LocationConverter> dictionary = routine.Referring;
			if (dictionary == null)
			{
				dictionary = (routine.Referring = new Dictionary<Location, LocationConverter>());
			}
			TypeInfo sourceType = link.GetSourceType();
			List<CastType> castTypes = link.CastTypes;
			Converter converter = null;
			if (sourceType != null)
			{
				converter = sourceType.GetConverter(castTypes);
			}
			bool isGetAddress = castTypes[0] == CastType.CAST_ADDRESS;
			LocationConverter value = new LocationConverter
			{
				Location = source,
				Converter = converter,
				IsGetAddress = isGetAddress
			};
			Location location = new Location
			{
				Function = target,
				Index = link.TargetIndex
			};
			if (link is VirtualLink virtualLink)
			{
				location.Group = virtualLink.TargetGroup;
			}
			target!.MarkVariable(location.Index);
			dictionary.Add(location, value);
		}
	}

	private static void ResolveProcudureEvents(List<Component> components, ConfigValidate validate)
	{
		int num = 1;
		foreach (Component component in components)
		{
			List<Procedure> procedures = component.Procedures;
			if (procedures == null)
			{
				break;
			}
			foreach (Procedure item in procedures)
			{
				List<Event> deferEvents = validate.GetDeferEvents(item);
				if (deferEvents != null)
				{
					validate.AddEventGroup(item, num);
					ResolveEventKeysAndArgs(deferEvents, item, validate, null, num);
					num++;
				}
			}
		}
	}

	private static bool ResolveEventKeysAndArgs(List<Event> events, Procedure procedure, ConfigValidate validate, IntialFunction? initial, int group)
	{
		Routine routine = procedure.Routine;
		if (routine == null)
		{
			return false;
		}
		List<LambdaManager.DataType.Action> actions = procedure.Actions;
		List<string> list = initial?.Keys ?? procedure.Key ?? procedure.Arg;
		if (actions == null || list == null)
		{
			return false;
		}
		list = StringUtils.Copy(list);
		bool result = false;
		foreach (LambdaManager.DataType.Action item in actions)
		{
			Function function = item.Function;
			if (function == null)
			{
				continue;
			}
			Routine routine2 = function.Routine;
			if (routine2 != null)
			{
				Procedure procedure2 = validate.GetProcedure(routine2);
				if (procedure2 != null)
				{
					if (initial == null)
					{
						initial = new IntialFunction
						{
							Routine = routine,
							Function = function,
							Keys = list
						};
					}
					if (ResolveEventKeysAndArgs(events, procedure2, validate, initial, group))
					{
						return true;
					}
				}
			}
			else
			{
				LambdaManager.DataType.Action action = CheckActionOrigin(item, validate) ?? item;
				Dictionary<int, IO> dictionary = action.GetArgIndice(list);
				Function function2 = null;
				LambdaManager.DataType.Action action2 = null;
				if (initial != null)
				{
					function2 = initial!.Function;
					action2 = ((function.Routine == null) ? item : action);
				}
				else
				{
					function2 = function;
					action2 = item;
				}
				Routine routine3 = initial?.Routine ?? routine;
				if (function2 != null && action2 != null)
				{
					dictionary = ResolveVariables(function2, action2, dictionary, validate, group);
				}
				foreach (KeyValuePair<int, IO> item2 in dictionary)
				{
					string name = item2.Value.Name;
					if (name == null)
					{
						continue;
					}
					foreach (Event @event in events)
					{
						@event.AddEventMap(routine3, name, item2.Key);
						list.Remove(name);
					}
				}
				if (dictionary.Count > 0)
				{
					result = true;
				}
			}
			if (list.Count == 0)
			{
				return result;
			}
		}
		return result;
	}

	private static Dictionary<int, IO> ResolveVariables(Function source, LambdaManager.DataType.Action target, Dictionary<int, IO> indexArgs, ConfigValidate validate, int group)
	{
		Routine routine = validate.GetRoutine(source);
		LambdaManager.DataType.Action action = ((source.Routine == null) ? validate.GetVirtualAction(routine) : validate.GetAction(source));
		Function function = ((source.Routine != null) ? source : action?.Function);
		if (action == null || function == null)
		{
			return indexArgs;
		}
		Dictionary<int, IO> dictionary = new Dictionary<int, IO>();
		foreach (KeyValuePair<int, IO> indexArg in indexArgs)
		{
			int num = function.Values?.Count ?? 0;
			function.AddValue(function);
			action.AddIO(indexArg.Value);
			VirtualLink virtualLink = new VirtualLink(source, group)
			{
				Source = action,
				SourceIndex = num,
				Target = target,
				TargetIndex = indexArg.Key
			};
			virtualLink.CastTypes.Add(CastType.NO_CAST);
			ResolveVariable(routine, virtualLink, byVariable: false, validate);
			dictionary.Add(num, indexArg.Value);
		}
		return dictionary;
	}

	private static void ResolveActionRaise(List<Component> all, ConfigValidate validate)
	{
		foreach (Component item in all)
		{
			List<Procedure> procedures = item.Procedures;
			if (procedures == null)
			{
				continue;
			}
			foreach (Procedure item2 in procedures)
			{
				List<LambdaManager.DataType.Action> actions = item2.Actions;
				if (actions == null)
				{
					continue;
				}
				foreach (LambdaManager.DataType.Action item3 in actions)
				{
					ResolveEventRaise(item3, validate);
				}
			}
		}
	}

	private static void ResolveEventRaise(LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		List<string> raise = action.Raise;
		if (raise == null)
		{
			return;
		}
		Function function = action.Function;
		if (function == null)
		{
			return;
		}
		foreach (string item in raise)
		{
			Event @event = new Event();
			if (item.StartsWith('{') && item.EndsWith('}'))
			{
				Dictionary<string, object> dictionary = JsonFormatter.DeserializeObject<Dictionary<string, object>>(item);
				@event.Type = (string)dictionary["type"];
				if (@event.Type == null)
				{
					App.Report(new Message
					{
						Severity = Severity.FATAL_ERROR,
						Text = item + Resources.EventTypeNotSpecified
					});
				}
				@event.Data = item;
				@event.SetArgType(hasKey: false, allJsonValue: false, hasBracket: true);
			}
			else
			{
				@event.Type = item;
				List<string> key = action.Key;
				if (key != null && key.Count > 0)
				{
					@event.Keys = ResolveRaiseKeys(key, isKey: true, action, null, out var isJsonString, validate);
					@event.SetArgType(hasKey: true, isJsonString, hasBracket: false);
				}
				List<string> arg = action.Arg;
				if (arg != null && arg.Count > 0)
				{
					@event.Keys = ResolveRaiseKeys(arg, isKey: false, action, null, out var _, validate);
					@event.ArgType = GetArgumentType(arg);
				}
			}
			List<Event> list = function.Raise;
			if (list == null)
			{
				list = (function.Raise = new List<Event>());
			}
			list.Add(@event);
		}
	}

	private static Dictionary<string, int>? ResolveRaiseKeys(List<string> keys, bool isKey, LambdaManager.DataType.Action action, LambdaManager.DataType.Action? action0, out bool isJsonString, ConfigValidate validate)
	{
		isJsonString = true;
		Function function = action.Function;
		if (function == null)
		{
			return null;
		}
		LambdaManager.DataType.Action action2 = validate.GetOriginalAction(function) ?? action;
		Dictionary<int, IO> argIndice = action2.GetArgIndice(keys);
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (KeyValuePair<int, IO> item in argIndice)
		{
			IO value = item.Value;
			dictionary[value.Name ?? ""] = item.Key;
			if (isKey && value.Type != null)
			{
				TypeInfo typeInfo = TypesInterop.GetTypeInfo(value.Type);
				if (typeInfo == null || !typeInfo.IsJsonType())
				{
					isJsonString = false;
				}
			}
		}
		List<string> list = keys.Except(dictionary.Keys).ToList();
		if (list.Count > 0)
		{
			List<LambdaManager.DataType.Action> list2 = validate.GetProcedure(action2.Function?.Routine)?.Actions;
			if (list2 == null)
			{
				validate.ReportNotFound(Severity.ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.RaiseKeys, list.ToString());
				return null;
			}
			{
				foreach (LambdaManager.DataType.Action item2 in list2)
				{
					Dictionary<string, int> dictionary2 = ResolveRaiseKeys(list, isKey, item2, action0 ?? action, out isJsonString, validate);
					if (dictionary2 != null)
					{
						dictionary = dictionary.Concat(dictionary2).ToDictionary((KeyValuePair<string, int> k) => k.Key, (KeyValuePair<string, int> v) => v.Value);
						if (dictionary.Count == keys.Count)
						{
							return dictionary;
						}
					}
				}
				return dictionary;
			}
		}
		return dictionary;
	}

	private static void RegisterEventCallbacks(ConfigValidate validate)
	{
		foreach (KeyValuePair<string, List<Procedure>> item in validate.GetEventProcedure())
		{
			string key = item.Key;
			foreach (Procedure item2 in item.Value)
			{
				Routine routine = item2.Routine;
				List<Function> list = routine?.Functions;
				if (list == null || list.Count == 0)
				{
					continue;
				}
				List<string> key2 = item2.Key;
				List<string> arg = item2.Arg;
				if (list.Count > 1 || key2 != null)
				{
					ArgumentType argType = ((key2 != null) ? ArgumentType.JSON_STRING : ((arg != null) ? GetArgumentType(arg) : ArgumentType.NO_ARGS));
					int eventGroup = validate.GetEventGroup(item2);
					if (eventGroup == -1)
					{
						throw new Exception("referring group error");
					}
					Common.AddEventHandler(key, argType, routine, once: false, eventGroup);
					continue;
				}
				Function function = list[0];
				if (function != null)
				{
					LambdaManager.DataType.Action action = item2.Actions?[0];
					ArgumentType? argumentType = ((arg == null) ? FunctionResolver.GetEventArgType(action) : new ArgumentType?(GetArgumentType(arg)));
					if (argumentType.HasValue)
					{
						Common.AddEventHandler(callback: function.EntryPoint?.FuncAddr ?? IntPtr.Zero, type: key, argType: argumentType.GetValueOrDefault(), once: false);
					}
				}
			}
		}
	}

	private static ArgumentType GetArgumentType(List<string> arg)
	{
		return arg.Count switch
		{
			1 => ArgumentType.POINTER, 
			2 => ArgumentType.POINTER2, 
			4 => ArgumentType.POINTER4, 
			_ => ArgumentType.NO_ARGS, 
		};
	}

	private static void ResolveFunctionArgument(ConfigValidate validate)
	{
		foreach (KeyValuePair<LambdaManager.DataType.Action, List<int>> functionArgument in validate.GetFunctionArguments())
		{
			LambdaManager.DataType.Action key = functionArgument.Key;
			foreach (int item in functionArgument.Value)
			{
				Input input = key.Inputs?[item];
				if (input == null)
				{
					continue;
				}
				LambdaManager.DataType.Action action = validate.FindComponentAction(input.Name, input.Value);
				if (action == null)
				{
					validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, key.Name, Resources.ReferredAction, input.Value);
					continue;
				}
				EntryPoint entryPoint = action.Function?.EntryPoint;
				if (entryPoint == null)
				{
					continue;
				}
				Function function = key.Function;
				if (function != null)
				{
					List<object> list = function.Values;
					if (list == null)
					{
						list = (function.Values = new List<object>());
					}
					CollectionUtils.Insert(list, item, entryPoint.FuncAddr);
				}
			}
		}
	}

	private void InitializeLibrary()
	{
		foreach (Routine item in solution.Routines[solution.InitEvent])
		{
			FunctionExecutor.Evaluate(new ExecInfo
			{
				Routine = item
			});
		}
	}

	private static async void InitializeScheduler()
	{
		LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());
		IScheduler scheduler = await new StdSchedulerFactory().GetScheduler();
		await scheduler.Start();
		int i = 0;
		foreach (Scheduler schedule in FunctionJob.GetSchedules())
		{
			if (schedule.Timer == null)
			{
				return;
			}
			JobBuilder jobBuilder = JobBuilder.Create<FunctionJob>();
			IJobDetail job = jobBuilder.WithIdentity($"Job{i}", "group1").Build();
			TriggerBuilder triggerBuilder = TriggerBuilder.Create();
			ITrigger trigger = triggerBuilder.WithIdentity($"Trigger{i}", "group1").StartNow().WithCronSchedule(schedule.Timer).Build();
			await scheduler.ScheduleJob(job, trigger);
			i++;
		}
	}
}

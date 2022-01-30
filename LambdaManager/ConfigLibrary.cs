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
		List<Command> commands = (from c in root.Descendants("commands").Descendants("command")
			select new Command
			{
				Name = c.Attribute((XName?)"name")?.Value,
				Icon = c.Attribute((XName?)"icon")?.Value,
				Raise = Split(c.Attribute((XName?)"raise")?.Value, '|')
			}).ToList();
		List<Component> all = (from c in root.Descendants("component")
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
		ConfigValidate validate = ValidateConfiguration(all);
		LoadComponents(all, commands, validate);
		LoadProcedures(all, validate);
		DeferProcessing(validate);
		ResolveAsync(all, validate);
		ResolveProcedureExports(validate);
		ResolveActionImports(validate);
		ResolveVariables(all, validate);
		ResolveProcudureEvents(all, validate);
		ResolveActionRaise(all, validate);
		RegisterEventCallbacks(validate);
		ResolveFunctionArgument(validate);
		InitializeScheduler();
		InitializeLibrary();
		return validate.Severity < Severity.FATAL_ERROR;
	}

	private static void ResolveMain(XElement root)
	{
		MainWindow main = (MainWindow)Application.Current.MainWindow;
		string title = root.Attribute((XName?)"title")?.Value;
		if (title != null)
		{
			main.Title = title;
		}
		string left = root.Attribute((XName?)"left")?.Value;
		if (left != null)
		{
			int width2 = int.Parse(left);
			if (width2 > 50)
			{
				main.leftView.Width = width2;
			}
		}
		string right = root.Attribute((XName?)"right")?.Value;
		if (right != null)
		{
			int width = int.Parse(right);
			if (width > 20)
			{
				main.rightView.Width = width;
			}
		}
		main.Notice = root.Attribute((XName?)"notice")?.Value;
		if (root.Attribute((XName?)"maximize")?.Value == "true")
		{
			main.Maximize = true;
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
		foreach (string e in array)
		{
			list.Add(e.Trim());
		}
		return list;
	}

	private static ConfigValidate ValidateConfiguration(List<Component> components)
	{
		ConfigValidate validate = new ConfigValidate();
		validate.CheckLibShortName(components);
		foreach (Component component in components)
		{
			validate.Check(component);
			List<Procedure> procedures = component.Procedures;
			if (procedures == null)
			{
				continue;
			}
			foreach (Procedure procedure in procedures)
			{
				validate.Check(procedure);
				List<LambdaManager.DataType.Action> actions = procedure.Actions;
				if (actions == null)
				{
					continue;
				}
				int pos = 0;
				foreach (LambdaManager.DataType.Action action in actions)
				{
					action.Index = pos++;
					validate.Check(action, procedure, component, components);
					List<Input> inputs = action.Inputs;
					int index = 0;
					if (inputs != null)
					{
						foreach (Input input in inputs)
						{
							validate.Check(input, index++, action, procedure, component);
						}
					}
					List<Output> outputs = action.Outputs;
					if (outputs == null)
					{
						continue;
					}
					foreach (Output output in outputs)
					{
						validate.Check(output, index++, action, procedure, component);
					}
				}
			}
		}
		return validate;
	}

	private void LoadComponents(List<Component> components, List<Command> commands, ConfigValidate validate)
	{
		validate.CheckLocalActions();
		ConfigUILibrary controlConfig = new ConfigUILibrary((MainWindow)Application.Current.MainWindow);
		foreach (Component component in components)
		{
			string lib = component.Lib;
			if (lib != null && !validate.Libs.Contains(lib))
			{
				if (!controlConfig.ResolveControl(component, validate))
				{
					LoadLibrary(component, validate);
				}
				validate.Libs.Add(lib);
			}
		}
		foreach (Command command in commands)
		{
			controlConfig.LoadMenuCommand(command, validate);
		}
	}

	private void LoadLibrary(Component component, ConfigValidate validate)
	{
		string path = component.Lib;
		if (path == null)
		{
			return;
		}
		IntPtr address = NativeLibrary.Load(path);
		Lib lib = new Lib
		{
			Addr = address,
			Path = path
		};
		solution.Libs.Add(lib);
		List<LambdaManager.DataType.Action> actions = validate.GetLocalActions(component);
		if (actions == null)
		{
			return;
		}
		for (int i = 0; i < actions.Count; i++)
		{
			LambdaManager.DataType.Action action = actions[i];
			string sigName = action.GetSigName(component);
			EntryPoint entryPoint = validate.GetEntryPoint(sigName);
			if (entryPoint == null)
			{
				EntryPoint entry = ResolveFunction(action, component, lib, validate);
				if (entry != null)
				{
					validate.AddEntryPoint(sigName, entry, action);
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
		FunctionResolver resolver = new FunctionResolver(lib);
		IntPtr addr = resolver.GetAddress(action, component);
		if (addr == IntPtr.Zero)
		{
			validate.ReportNotExist(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.Signature, action.ToString());
			return null;
		}
		string code = resolver.GetSignatureCodes();
		List<TypeInfo> parameters = resolver.TypeInfos;
		EntryPoint entry = new EntryPoint
		{
			FuncAddr = addr,
			Code = code,
			Paremeters = parameters,
			InputCount = (action.Inputs?.Count ?? 0)
		};
		List<EntryPoint> entrypoints = lib.EntryPoints;
		if (entrypoints == null)
		{
			entrypoints = (lib.EntryPoints = new List<EntryPoint>());
		}
		entrypoints.Add(entry);
		List<object> defaultValues = resolver.DefaultValues;
		Function function = (action.Function = new Function
		{
			EntryPoint = entry,
			Values = defaultValues,
			Times = action.Times
		});
		return entry;
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
		foreach (Procedure procedure in procedures)
		{
			List<string> events = procedure.Event;
			Routine routine = new Routine();
			validate.AddRoutineProcedure(routine, procedure);
			procedure.Routine = routine;
			procedure.IsGUIProcedure = component.IsGUIComponent();
			ResolveRotine(routine, procedure, component, validate);
			bool isInitial = IsInitialRotine(component, procedure);
			if (isInitial)
			{
				RegisterCallbackRoutine(solution.InitEvent, routine);
			}
			if (events == null)
			{
				if (!isInitial)
				{
					RegisterCallbackRoutine(solution.UndefinedEvent, routine);
				}
			}
			else
			{
				List<Event> list = new List<Event>();
				foreach (string type in events)
				{
					solution.Events.TryGetValue(type, out var evt);
					if (evt == null)
					{
						evt = new Event
						{
							Type = type
						};
						solution.Events.Add(type, evt);
					}
					RegisterCallbackRoutine(evt, routine);
					list.Add(evt);
				}
				validate.AddDeferEvents(procedure, list);
			}
			string timer = procedure.Timer;
			if (timer != null)
			{
				FunctionJob.AddSchedule(new Scheduler
				{
					Name = procedure.Name,
					Timer = timer,
					Routine = routine
				});
			}
			if (procedure.Aysnc == "true")
			{
				routine.Async = true;
			}
		}
	}

	private static bool IsInitialRotine(Component component, Procedure procedure)
	{
		string name = procedure.Name;
		List<string> inits = component.Init;
		if (name != null && inits != null)
		{
			return inits.IndexOf(name) != -1;
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
		foreach (LambdaManager.DataType.Action action in actions)
		{
			List<Function> functions = routine.Functions;
			if (functions == null)
			{
				functions = (routine.Functions = new List<Function>());
			}
			Function function = ResolveActionFunction(action, procedure, component, validate);
			if (function != null)
			{
				functions.Add(function);
				validate.AddFunctionRoutine(function, routine);
				validate.AddFunctionAction(function, action);
				continue;
			}
			string referring = FunctionResolver.GetFullName(component, procedure, action.ToString());
			string referred = action.Name;
			if (action.Component != null)
			{
				referred = action.Component + "::" + action.Name;
			}
			validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, referring, Resources.Referring, referred);
		}
	}

	private void RegisterCallbackRoutine(Event evt, Routine routine)
	{
		solution.Routines.TryGetValue(evt, out var rountines);
		if (rountines == null)
		{
			rountines = new List<Routine>();
			solution.Routines.Add(evt, rountines);
		}
		rountines.Add(routine);
	}

	private static Function? ResolveActionFunction(LambdaManager.DataType.Action action, Procedure procedure, Component? component, ConfigValidate validate)
	{
		Function function = action.Function;
		if (function == null)
		{
			string componentName = action.Component;
			if (componentName == null)
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
				function = ResolveActionToExternalFunction(componentName, action, validate);
				if (function != null)
				{
					return function;
				}
				component = validate.GetComponentOfLocalActions(componentName);
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
		List<LambdaManager.DataType.Action> actions = validate.GetLocalActions(component);
		if (actions != null)
		{
			string sigName = action.GetSigName(component);
			foreach (LambdaManager.DataType.Action action2 in actions)
			{
				if (action2.GetSigName(component) == sigName)
				{
					EntryPoint entry = action2.Function?.EntryPoint;
					if (entry != null)
					{
						return SetFunction(action, entry);
					}
				}
			}
		}
		return null;
	}

	private static Function? ResolveActionToExternalFunction(string componentName, LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		Component component = validate.GetComponentOfLocalActions(componentName);
		if (component == null)
		{
			validate.Report(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Component, componentName, Resources.Action, action.Name, Resources.Undefined);
			return null;
		}
		string sigName = action.GetSigName(component);
		if (sigName != null)
		{
			EntryPoint entry = validate.GetEntryPoint(sigName);
			if (entry == null)
			{
				string sigNameWithoutParameter = new Regex("@0$").Replace(sigName, "");
				List<KeyValuePair<string, EntryPoint>> entries = validate.GetSimilarEntryPoints(sigNameWithoutParameter);
				if (entries.Count != 1)
				{
					return null;
				}
				entry = entries.First().Value;
			}
			List<object> defultValues = validate.GetDefaultValues(action, entry);
			return action.Function = new Function
			{
				EntryPoint = entry,
				Values = defultValues,
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
			Procedure unresolved = null;
			foreach (Procedure procedure in procedures)
			{
				if (!(procedure.Name == action.Name))
				{
					continue;
				}
				Function function = ResolveProcedureToFunction(action, procedure);
				if (function != null)
				{
					List<Input>? inputs = action.Inputs;
					if (inputs != null && inputs!.Count > 0)
					{
						ResolveFunctionExports(action, function, procedure, validate);
					}
					return function;
				}
				unresolved = procedure;
			}
			if (unresolved != null)
			{
				validate.AddDeferResolvedAction(action, unresolved);
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
		List<Link> links = new List<Link>();
		for (int i = 0; i < inputs.Count; i++)
		{
			List<Link> matches = TraverseLinkTarget(actions, inputs[i], sourceTimes, validate);
			if (matches != null && matches.Count > 0)
			{
				Link linked = CheckLinkedSource(matches, source, i, validate);
				if (linked != null)
				{
					links.Add(linked);
				}
			}
		}
		return links;
	}

	private static List<Link>? TraverseLinkTarget(List<LambdaManager.DataType.Action> actions, IO source, bool sourceTimes, ConfigValidate validate)
	{
		List<Link> matches = new List<Link>();
		foreach (LambdaManager.DataType.Action target in actions)
		{
			if (target != null && target.Component != null)
			{
				CheckActionOrigin(target, validate);
			}
			if (target == null)
			{
				continue;
			}
			Routine routine = target.Function?.Routine;
			List<LambdaManager.DataType.Action> actions2 = validate.GetProcedure(routine)?.Actions;
			if (actions2 != null)
			{
				List<Link> matches2 = TraverseLinkTarget(actions2, source, sourceTimes, validate);
				if (matches2 != null && matches2.Count > 0)
				{
					matches.AddRange(matches2);
				}
				continue;
			}
			int i = 0;
			foreach (IO io in target.IoRange)
			{
				string sourceType = source.Type;
				if (sourceTimes)
				{
					sourceType = FunctionResolver.CleanSuffix(sourceType, "[]");
				}
				List<CastType> castTypes = FunctionResolver.ResolveLinkCastType(io.Name, io.Type, source.Name, sourceType);
				Link link = new Link
				{
					Target = target,
					CastTypes = castTypes,
					TargetIndex = i
				};
				if (CheckLinkCastType(link))
				{
					matches.Add(link);
				}
				i++;
			}
		}
		return matches;
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
		Dictionary<LambdaManager.DataType.Action, Procedure> remains = ResolveDeferActions(validate.GetDeferResolvedActions());
		int count = 0;
		while (remains.Count > 0)
		{
			remains = ResolveDeferActions(remains);
			count++;
			if (count != 100)
			{
				continue;
			}
			{
				foreach (KeyValuePair<LambdaManager.DataType.Action, Procedure> item in remains)
				{
					validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, item.Key.Name, Resources.EntryPoint, null);
				}
				break;
			}
		}
	}

	private static Dictionary<LambdaManager.DataType.Action, Procedure> ResolveDeferActions(Dictionary<LambdaManager.DataType.Action, Procedure> defers)
	{
		Dictionary<LambdaManager.DataType.Action, Procedure> remains = new Dictionary<LambdaManager.DataType.Action, Procedure>();
		foreach (KeyValuePair<LambdaManager.DataType.Action, Procedure> defer in defers)
		{
			LambdaManager.DataType.Action action = defer.Key;
			Procedure procedure = defer.Value;
			Function function = ResolveProcedureToFunction(action, procedure);
			if (function == null)
			{
				remains.Add(action, procedure);
				continue;
			}
			List<LambdaManager.DataType.Action> actions = procedure.Actions;
			if (actions != null)
			{
				int index = actions.IndexOf(action);
				if (index >= 0)
				{
					procedure.Routine?.Functions?.Insert(index, function);
				}
			}
			throw new Exception("system error: 100");
		}
		return remains;
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
		EntryPoint entry = function.EntryPoint;
		if (entry == null)
		{
			return false;
		}
		LambdaManager.DataType.Action origin = validate.GetAction(entry);
		if (origin == null || origin == action)
		{
			return false;
		}
		if (ResolveActionAsync(origin, validate))
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
			foreach (ExportInfo exportInfo in procedureExport.Value)
			{
				EntryPoint entry = exportInfo.Action.Function?.EntryPoint;
				if (entry != null)
				{
					Dictionary<int, int> exports = entry.Exports;
					if (exports == null)
					{
						exports = (entry.Exports = new Dictionary<int, int>());
					}
					exports[exportInfo.ArgumentIndex] = exportInfo.ExportIndex;
				}
			}
		}
	}

	private static void ResolveFunctionExports(LambdaManager.DataType.Action action, Function function, Procedure procedure, ConfigValidate validate)
	{
		FunctionResolver resolver = new FunctionResolver(null);
		resolver.Parse(action);
		function.Values = resolver.DefaultValues;
		List<Link> links = ResolveProcedureInput(procedure, action, validate);
		if (links == null)
		{
			return;
		}
		Routine temp = new Routine();
		foreach (Link link in links)
		{
			ResolveVariable(temp, link, byVariable: true, validate);
		}
		function.Exports = temp.Referring;
	}

	private static void ResolveActionImports(ConfigValidate validate)
	{
		foreach (KeyValuePair<LambdaManager.DataType.Action, List<ImportInfo>> pair in validate.GetActionImports())
		{
			LambdaManager.DataType.Action action = pair.Key;
			List<ImportInfo> infos = pair.Value;
			Routine routine = action.Function?.Routine;
			if (routine == null)
			{
				if (validate.CheckActionImports(infos, action).Count > 0)
				{
					validate.ReportActionImportNotSupported(action, infos);
				}
				continue;
			}
			List<string> exports = validate.GetProcedure(routine)?.Exports;
			if (exports == null)
			{
				validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.Export, null);
				continue;
			}
			Function function = action.Function;
			if (function == null)
			{
				continue;
			}
			foreach (ImportInfo info in infos)
			{
				int exportIndex = exports.IndexOf(info.Name);
				if (exportIndex == -1)
				{
					validate.ReportNotFound(Severity.ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.Import, info.Name);
					continue;
				}
				Dictionary<int, int> imports = function.Imports;
				if (imports == null)
				{
					imports = (function.Imports = new Dictionary<int, int>());
				}
				imports.Add(exportIndex, info.ArgumentIndex);
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
		List<Link> links = new List<Link>();
		for (int i = 0; i < actions.Count; i++)
		{
			int j = 0;
			LambdaManager.DataType.Action target = actions[i];
			foreach (IO io in target.IoRange)
			{
				List<Link> matches = TraverseLinkSource(actions, io, i, validate);
				if (matches != null && matches.Count > 0)
				{
					Link linked = CheckLinkedTarget(matches, target, j, validate);
					if (linked != null)
					{
						links.Add(linked);
					}
				}
				j++;
			}
		}
		foreach (Link link in links)
		{
			ResolveVariable(procedure.Routine, link, byVariable: true, validate);
		}
	}

	private static List<Link>? TraverseLinkSource(List<LambdaManager.DataType.Action> actions, IO target, int targetIndex, ConfigValidate validate)
	{
		if (target.Value != null || target.Name == null)
		{
			return null;
		}
		List<Link> matches = new List<Link>();
		for (int i = targetIndex - 1; i >= 0; i--)
		{
			LambdaManager.DataType.Action source = actions[i];
			if (source != null && source.Component != null)
			{
				CheckActionOrigin(source, validate);
			}
			if (source != null)
			{
				int j = source.GetArgsCount() - 1;
				foreach (IO io in source.IoReverseRange)
				{
					List<CastType> castTypes = FunctionResolver.ResolveLinkCastType(target.Name, target.Type, io.Name, io.Type);
					Link link = new Link
					{
						Source = source,
						CastTypes = castTypes,
						SourceIndex = j
					};
					if (CheckLinkCastType(matches, link))
					{
						return matches;
					}
					j--;
				}
			}
		}
		return matches;
	}

	private static LambdaManager.DataType.Action? CheckActionOrigin(LambdaManager.DataType.Action action, ConfigValidate validate)
	{
		Function function = action.Function;
		if (function == null)
		{
			return null;
		}
		LambdaManager.DataType.Action origin = null;
		Routine routine = function.Routine;
		if (routine == null)
		{
			origin = validate.GetOriginalAction(function);
		}
		else
		{
			List<LambdaManager.DataType.Action> actions2 = validate.GetProcedure(routine)?.Actions;
			if (actions2 != null && actions2.Count > 0)
			{
				origin = actions2[0];
			}
		}
		if (origin != null)
		{
			CopyOriginInputs(action, origin.Inputs, validate);
			action.Outputs = origin.Outputs;
		}
		return origin;
	}

	private static void CopyOriginInputs(LambdaManager.DataType.Action action, List<Input>? inputs, ConfigValidate validate)
	{
		List<Input> target = action.Inputs;
		if (target == null)
		{
			action.Inputs = inputs;
		}
		else
		{
			if (inputs == null)
			{
				return;
			}
			Dictionary<int, int> exists = new Dictionary<int, int>();
			int raw = 0;
			for (int l = 0; l < target.Count; l++)
			{
				bool found = false;
				for (int i = raw; i < inputs!.Count; i++)
				{
					if (inputs![i].Name == target[l].Name || inputs![i].Type == target[l].Type)
					{
						exists.Add(i, l);
						raw = i + 1;
						found = true;
						break;
					}
				}
				if (!found)
				{
					validate.Report(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, action.Name, LambdaManager.DataType.Type.Input.Description(), target[l].Name ?? ("index at " + l), Resources.OriginInputsNotMatch);
				}
			}
			for (int j = 0; j < inputs!.Count; j++)
			{
				if (exists.TryGetValue(j, out var k))
				{
					if (target[k].Name == null)
					{
						target[k].Name = inputs![j].Name;
					}
					target[k].Type = inputs![j].Type;
					if (target[k].Value == null)
					{
						target[k].Value = inputs![j].Value;
					}
				}
				else if (j < target.Count)
				{
					target.Insert(j, inputs![j]);
				}
				else
				{
					target.Add(inputs![j]);
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
		Link best = links[0];
		if (best.CastTypes[0] == CastType.TYPE_NOT_MATCH)
		{
			validate.ReportLinkNotMatch(best, target, index);
			return null;
		}
		best.Target = target;
		best.TargetIndex = index;
		return best;
	}

	private static int CompareTo(List<CastType> l1, List<CastType> l2)
	{
		int x = l1[0].CompareTo(l2[0]);
		if (x == 0)
		{
			int c1 = l1.Count;
			int c2 = l2.Count;
			if (c1 == 1 && c2 > 1)
			{
				return -1;
			}
			if (c2 == 1 && c1 > 1)
			{
				return 1;
			}
			if (c1 == 1 && c2 == 1)
			{
				return 0;
			}
			x = l1[1].CompareTo(l2[1]);
			if (x == 0)
			{
				if (c1 == 2 && c2 > 2)
				{
					return -1;
				}
				if (c2 == 2 && c1 > 2)
				{
					return 1;
				}
				if (c1 == 2 && c2 == 2)
				{
					return 0;
				}
				return l1[2].CompareTo(l2[2]);
			}
		}
		return x;
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
		Function target = link.Target.Function;
		Function source = link.Source.Function;
		if (source != null)
		{
			source.IsReferred = true;
			if (source.Async && link.SourceIndex >= source.EntryPoint?.InputCount)
			{
				validate.Report(Severity.ERROR, LambdaManager.DataType.Type.Action, validate.GetAction(source)?.Name, Resources.Async, null, Resources.AsyncWithOutputReferredNotSupport);
			}
		}
		if (routine == null)
		{
			return;
		}
		Location location = null;
		if (byVariable)
		{
			location = ResolveVariableReferred(link, routine, source);
		}
		else if (source != null)
		{
			location = new Location
			{
				Function = source,
				Index = link.SourceIndex
			};
			if (link is VirtualLink vlink)
			{
				location.Function = vlink.SourceFunction;
			}
		}
		ResolveVariableReferring(link, routine, target, location);
	}

	private static Location? ResolveVariableReferred(Link link, Routine routine, Function? source)
	{
		if (source == null)
		{
			return null;
		}
		Dictionary<Function, List<Location>> referred = routine.Referred;
		if (referred == null)
		{
			referred = (routine.Referred = new Dictionary<Function, List<Location>>());
		}
		referred.TryGetValue(source, out var locations);
		if (locations == null)
		{
			locations = new List<Location>();
			referred.Add(source, locations);
		}
		Location location = new Location
		{
			Function = source,
			Index = link.SourceIndex
		};
		if (link is VirtualLink vlink)
		{
			location.Function = vlink.SourceFunction;
		}
		if (locations.IndexOf(location) == -1)
		{
			locations.Add(location);
		}
		return location;
	}

	private static void ResolveVariableReferring(Link link, Routine routine, Function? target, Location? source)
	{
		if (source != null && target != null)
		{
			Dictionary<Location, LocationConverter> referring = routine.Referring;
			if (referring == null)
			{
				referring = (routine.Referring = new Dictionary<Location, LocationConverter>());
			}
			TypeInfo typeInfo = link.GetSourceType();
			List<CastType> castTypes = link.CastTypes;
			Converter converter = null;
			if (typeInfo != null)
			{
				converter = typeInfo.GetConverter(castTypes);
			}
			bool isGetAddress = castTypes[0] == CastType.CAST_ADDRESS;
			LocationConverter locationConverter = new LocationConverter
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
			if (link is VirtualLink vlink)
			{
				location.Group = vlink.TargetGroup;
			}
			target!.MarkVariable(location.Index);
			referring.Add(location, locationConverter);
		}
	}

	private static void ResolveProcudureEvents(List<Component> components, ConfigValidate validate)
	{
		int group = 1;
		foreach (Component component in components)
		{
			List<Procedure> procedures = component.Procedures;
			if (procedures == null)
			{
				break;
			}
			foreach (Procedure procedure in procedures)
			{
				List<Event> events = validate.GetDeferEvents(procedure);
				if (events != null)
				{
					validate.AddEventGroup(procedure, group);
					ResolveEventKeysAndArgs(events, procedure, validate, null, group);
					group++;
				}
			}
		}
	}

	private static bool ResolveEventKeysAndArgs(List<Event> events, Procedure procedure, ConfigValidate validate, IntialFunction? initial, int group)
	{
		Routine pRoutine = procedure.Routine;
		if (pRoutine == null)
		{
			return false;
		}
		List<LambdaManager.DataType.Action> actions = procedure.Actions;
		List<string> keys = initial?.Keys ?? procedure.Key ?? procedure.Arg;
		if (actions == null || keys == null)
		{
			return false;
		}
		keys = StringUtils.Copy(keys);
		bool result = false;
		foreach (LambdaManager.DataType.Action action in actions)
		{
			Function function = action.Function;
			if (function == null)
			{
				continue;
			}
			Routine routine = function.Routine;
			if (routine != null)
			{
				Procedure procedure2 = validate.GetProcedure(routine);
				if (procedure2 != null)
				{
					if (initial == null)
					{
						initial = new IntialFunction
						{
							Routine = pRoutine,
							Function = function,
							Keys = keys
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
				LambdaManager.DataType.Action action2 = CheckActionOrigin(action, validate) ?? action;
				Dictionary<int, IO> indexArgs = action2.GetArgIndice(keys);
				Function source = null;
				LambdaManager.DataType.Action target = null;
				if (initial != null)
				{
					source = initial!.Function;
					target = ((function.Routine == null) ? action : action2);
				}
				else
				{
					source = function;
					target = action;
				}
				Routine entryRoutine = initial?.Routine ?? pRoutine;
				if (source != null && target != null)
				{
					indexArgs = ResolveVariables(source, target, indexArgs, validate, group);
				}
				foreach (KeyValuePair<int, IO> indexArg in indexArgs)
				{
					string key = indexArg.Value.Name;
					if (key == null)
					{
						continue;
					}
					foreach (Event @event in events)
					{
						@event.AddEventMap(entryRoutine, key, indexArg.Key);
						keys.Remove(key);
					}
				}
				if (indexArgs.Count > 0)
				{
					result = true;
				}
			}
			if (keys.Count == 0)
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
		Dictionary<int, IO> indexArgs2 = new Dictionary<int, IO>();
		foreach (KeyValuePair<int, IO> indexArg in indexArgs)
		{
			int sourceIndex = function.Values?.Count ?? 0;
			function.AddValue(function);
			action.AddIO(indexArg.Value);
			VirtualLink link = new VirtualLink(source, group)
			{
				Source = action,
				SourceIndex = sourceIndex,
				Target = target,
				TargetIndex = indexArg.Key
			};
			link.CastTypes.Add(CastType.NO_CAST);
			ResolveVariable(routine, link, byVariable: false, validate);
			indexArgs2.Add(sourceIndex, indexArg.Value);
		}
		return indexArgs2;
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
		List<string> raises = action.Raise;
		if (raises == null)
		{
			return;
		}
		Function function = action.Function;
		if (function == null)
		{
			return;
		}
		foreach (string raise in raises)
		{
			Event evt = new Event();
			if (raise.StartsWith('{') && raise.EndsWith('}'))
			{
				Dictionary<string, object> eventObject = JsonFormatter.DeserializeObject<Dictionary<string, object>>(raise);
				evt.Type = (string)eventObject["type"];
				if (evt.Type == null)
				{
					App.Report(new Message
					{
						Severity = Severity.FATAL_ERROR,
						Text = raise + Resources.EventTypeNotSpecified
					});
				}
				evt.Data = raise;
				evt.SetArgType(hasKey: false, allJsonValue: false, hasBracket: true);
			}
			else
			{
				evt.Type = raise;
				List<string> keys = action.Key;
				if (keys != null && keys.Count > 0)
				{
					evt.Keys = ResolveRaiseKeys(keys, isKey: true, action, null, out var isJsonString, validate);
					evt.SetArgType(hasKey: true, isJsonString, hasBracket: false);
				}
				List<string> args = action.Arg;
				if (args != null && args.Count > 0)
				{
					evt.Keys = ResolveRaiseKeys(args, isKey: false, action, null, out var _, validate);
					evt.ArgType = GetArgumentType(args);
				}
			}
			List<Event> events = function.Raise;
			if (events == null)
			{
				events = (function.Raise = new List<Event>());
			}
			events.Add(evt);
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
		Dictionary<string, int> keyIndice = new Dictionary<string, int>();
		foreach (KeyValuePair<int, IO> pair in argIndice)
		{
			IO io = pair.Value;
			keyIndice[io.Name ?? ""] = pair.Key;
			if (isKey && io.Type != null)
			{
				TypeInfo info = TypesInterop.GetTypeInfo(io.Type);
				if (info == null || !info.IsJsonType())
				{
					isJsonString = false;
				}
			}
		}
		List<string> remains = keys.Except(keyIndice.Keys).ToList();
		if (remains.Count > 0)
		{
			List<LambdaManager.DataType.Action> actions = validate.GetProcedure(action2.Function?.Routine)?.Actions;
			if (actions == null)
			{
				validate.ReportNotFound(Severity.ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.RaiseKeys, remains.ToString());
				return null;
			}
			{
				foreach (LambdaManager.DataType.Action action3 in actions)
				{
					Dictionary<string, int> keyIndice2 = ResolveRaiseKeys(remains, isKey, action3, action0 ?? action, out isJsonString, validate);
					if (keyIndice2 != null)
					{
						keyIndice = keyIndice.Concat(keyIndice2).ToDictionary((KeyValuePair<string, int> k) => k.Key, (KeyValuePair<string, int> v) => v.Value);
						if (keyIndice.Count == keys.Count)
						{
							return keyIndice;
						}
					}
				}
				return keyIndice;
			}
		}
		return keyIndice;
	}

	private static void RegisterEventCallbacks(ConfigValidate validate)
	{
		foreach (KeyValuePair<string, List<Procedure>> pair in validate.GetEventProcedure())
		{
			string type = pair.Key;
			foreach (Procedure procedure in pair.Value)
			{
				Routine routine = procedure.Routine;
				List<Function> functions = routine?.Functions;
				if (functions == null || functions.Count == 0)
				{
					continue;
				}
				List<string> key = procedure.Key;
				List<string> arg = procedure.Arg;
				if (functions.Count > 1 || key != null)
				{
					ArgumentType argType = ((key != null) ? ArgumentType.JSON_STRING : ((arg != null) ? GetArgumentType(arg) : ArgumentType.NO_ARGS));
					int group = validate.GetEventGroup(procedure);
					if (group == -1)
					{
						throw new Exception("referring group error");
					}
					Common.AddEventHandler(type, argType, routine, once: false, group);
					continue;
				}
				Function function = functions[0];
				if (function != null)
				{
					LambdaManager.DataType.Action action = procedure.Actions?[0];
					ArgumentType? argType2 = ((arg == null) ? FunctionResolver.GetEventArgType(action) : new ArgumentType?(GetArgumentType(arg)));
					if (argType2.HasValue)
					{
						Common.AddEventHandler(callback: function.EntryPoint?.FuncAddr ?? IntPtr.Zero, type: type, argType: argType2.GetValueOrDefault(), once: false);
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
		foreach (KeyValuePair<LambdaManager.DataType.Action, List<int>> pair in validate.GetFunctionArguments())
		{
			LambdaManager.DataType.Action action = pair.Key;
			foreach (int index in pair.Value)
			{
				Input input = action.Inputs?[index];
				if (input == null)
				{
					continue;
				}
				LambdaManager.DataType.Action refAction = validate.FindComponentAction(input.Name, input.Value);
				if (refAction == null)
				{
					validate.ReportNotFound(Severity.FATAL_ERROR, LambdaManager.DataType.Type.Action, action.Name, Resources.ReferredAction, input.Value);
					continue;
				}
				EntryPoint entry = refAction.Function?.EntryPoint;
				if (entry == null)
				{
					continue;
				}
				Function function = action.Function;
				if (function != null)
				{
					List<object> values = function.Values;
					if (values == null)
					{
						values = (function.Values = new List<object>());
					}
					CollectionUtils.Insert(values, index, entry.FuncAddr);
				}
			}
		}
	}

	private void InitializeLibrary()
	{
		foreach (Routine routine in solution.Routines[solution.InitEvent])
		{
			FunctionExecutor.Evaluate(new ExecInfo
			{
				Routine = routine
			});
		}
	}

	private static async void InitializeScheduler()
	{
		LogProvider.SetCurrentLogProvider(new ConsoleLogProvider());
		IScheduler scheduler = (Common.Scheduler = await new StdSchedulerFactory().GetScheduler());
		await scheduler.Start();
		int i = 0;
		foreach (Scheduler info in FunctionJob.GetSchedules())
		{
			if (info.Timer == null)
			{
				return;
			}
			JobBuilder jobBuilder = JobBuilder.Create<FunctionJob>();
			IJobDetail job = jobBuilder.WithIdentity($"Job{i}", "group1").Build();
			TriggerBuilder triggerBuilder = TriggerBuilder.Create();
			ITrigger trigger = triggerBuilder.WithIdentity($"Trigger{i}", "group1").StartNow().Build();
			await scheduler.ScheduleJob(job, trigger);
			i++;
		}
	}
}

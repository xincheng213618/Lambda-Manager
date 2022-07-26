using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Lambda;
using LambdaManager.Core;
using LambdaManager.DataType;
using LambdaManager.Properties;

namespace LambdaManager.Config;

internal class ConfigValidate
{
	private readonly Dictionary<string, List<Action>> lib_actions = new Dictionary<string, List<Action>>();

	private readonly Dictionary<Component, List<Action>> component_actions = new Dictionary<Component, List<Action>>();

	private readonly Dictionary<string, EntryPoint> sigName_entrypoints = new Dictionary<string, EntryPoint>();

	private readonly Dictionary<EntryPoint, Action> entry_actions = new Dictionary<EntryPoint, Action>();

	private readonly Dictionary<Function, Routine> function_routines = new Dictionary<Function, Routine>();

	private readonly Dictionary<Function, Action> function_actions = new Dictionary<Function, Action>();

	private readonly Dictionary<Routine, Procedure> routine_procedures = new Dictionary<Routine, Procedure>();

	private readonly Dictionary<Routine, Action> virtual_actions = new Dictionary<Routine, Action>();

	private readonly Dictionary<string, List<Procedure>> event_procedure = new Dictionary<string, List<Procedure>>();

	private readonly Dictionary<Action, Procedure> defer_resolved_actions = new Dictionary<Action, Procedure>();

	private readonly Dictionary<Procedure, List<Event>> defer_events = new Dictionary<Procedure, List<Event>>();

	private readonly Dictionary<Procedure, int> procedure_event_groups = new Dictionary<Procedure, int>();

	private readonly Dictionary<string, string> export_types = new Dictionary<string, string>();

	private readonly Dictionary<Procedure, List<ExportInfo>> procedure_exports = new Dictionary<Procedure, List<ExportInfo>>();

	private readonly Dictionary<Action, List<ImportInfo>> action_imports = new Dictionary<Action, List<ImportInfo>>();

	private readonly Dictionary<Action, List<int>> action_inputFor = new Dictionary<Action, List<int>>();

	private readonly Dictionary<Action, List<int>> action_functionArgument = new Dictionary<Action, List<int>>();

	internal Severity Severity { get; set; }  

	internal HashSet<string> Libs { get; } = new HashSet<string>();


	internal void Report(Severity severity, Type type, string? name, string attr, string? value, string err)
	{
		Log.Report(severity, type.Description(), name, attr, value, err);
		if (Severity < severity)
		{
			Severity = severity;
		}
	}

	internal void ReportEmpty(Severity severity, Type type, string? name, string attr)
	{
		Report(severity, type, name, attr, null, Resources.Empty);
	}

	internal void ReportNotExist(Severity severity, Type type, string? name, string attr, string? value)
	{
		Report(severity, type, name, attr, value, Resources.NotExist);
	}

	internal void ReportNotFound(Severity severity, Type type, string? name, string attr, string? value)
	{
		Report(severity, type, name, attr, value, Resources.NotFound);
	}

	internal void ReportFunctionReferenceNotFound(Component component, Procedure procedure, string? actionName, string referring)
	{
		string fullName = FunctionResolver.GetFullName(component, procedure, actionName);
		ReportNotExist(Severity.FATAL_ERROR, Type.Action, fullName, Resources.Referring + Resources.Component, referring);
	}

	internal void ReportNotSupported(Severity severity, Type type, string? name, string attr, string? value)
	{
		Report(severity, type, name, attr, value, Resources.NotSupported);
	}

	internal void ReportArgTypeAsPointer(Component component, Procedure procedure, Action action, string attr, string? value)
	{
		string fullName = FunctionResolver.GetFullName(component, procedure, action.Name);
		Report(Severity.WARNING, Type.Action, fullName, attr, value, Resources.AsPointer);
	}

	internal void ReportLinkNotMatch(Link best, Action action, int index)
	{
		string attr = (action.IsInputIO(index) ? Resources.InputType : Resources.OutputType);
		string refering = Resources.Referring;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 2);
		defaultInterpolatedStringHandler.AppendFormatted(Type.Action);
		defaultInterpolatedStringHandler.AppendLiteral("[");
		defaultInterpolatedStringHandler.AppendFormatted(best.Source.Name);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		string obj = defaultInterpolatedStringHandler.ToStringAndClear();
		string attr2 = (best.IsInputSource() ? Resources.InputType : Resources.OutputType);
		string value2 = best.GetSourceIO()?.Type;
		string error = Resources.NotMatched;
		string type = action.GetIO(index)?.Type;
		string? name = action.Name;
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 5);
		defaultInterpolatedStringHandler.AppendFormatted(refering);
		defaultInterpolatedStringHandler.AppendFormatted(obj);
		defaultInterpolatedStringHandler.AppendFormatted(attr2);
		defaultInterpolatedStringHandler.AppendLiteral("[");
		defaultInterpolatedStringHandler.AppendFormatted(value2);
		defaultInterpolatedStringHandler.AppendLiteral("]");
		defaultInterpolatedStringHandler.AppendFormatted(error);
		Report(Severity.FATAL_ERROR, Type.Action, name, attr, type, defaultInterpolatedStringHandler.ToStringAndClear());
	}

	internal void ReportActionImportNotSupported(Action action, List<ImportInfo> infos)
	{
		string s = "";
		foreach (ImportInfo info in infos)
		{
			s = s + info.Name + ",";
		}
		s = s[0..^1];
		Report(Severity.WARNING, Type.Action, action.Name, Resources.Import, s, Resources.NotExportProc);
	}

	internal void Check(Component component)
	{
		Type type = Type.Component;
		string name = component.Name;
		if (name == null)
		{
			ReportEmpty(Severity.FATAL_ERROR, type, name, Resources.Name);
		}
		if (component.Lib == null)
		{
			ReportEmpty(Severity.FATAL_ERROR, type, name, Resources.Lib);
		}
		if (!File.Exists(component.Lib))
		{
			ReportNotExist(Severity.FATAL_ERROR, type, name, Resources.Lib + Resources.File, component.Lib);
			component.Lib = null;
		}
	}

	internal void CheckLibShortName(List<Component> components)
	{
		Dictionary<string, string> names = new Dictionary<string, string>();
		foreach (Component component in components)
		{
			string lib = component.Lib;
			string shortName = component.GetLibShortName();
			if (lib == null || shortName == null)
			{
				continue;
			}
			if (names.ContainsKey(shortName))
			{
				if (names[shortName].ToLower() != lib.ToLower())
				{
					Report(Severity.WARNING, Type.Component, component.Name, Resources.Lib, lib, Resources.DuplicateLib);
				}
			}
			else
			{
				names.Add(shortName, lib);
			}
		}
	}

	internal void Check(Procedure procedure)
	{
		Type type = Type.Procedure;
		string name = procedure.Name;
		if (name == null)
		{
			ReportEmpty(Severity.WARNING, type, name, Resources.Name);
		}
		int? count = procedure.Actions?.Count;
		if (count == 0)
		{
			ReportNotExist(Severity.WARNING, Type.Procedure, name, Resources.Action, null);
		}
		List<string> evt = procedure.Event;
		if (evt == null)
		{
			return;
		}
		foreach (string e in evt)
		{
			event_procedure.TryGetValue(e, out var procedures);
			if (procedures == null)
			{
				procedures = new List<Procedure>();
				event_procedure.Add(e, procedures);
			}
			procedures.Add(procedure);
		}
		if (count == 1 && procedure.Key == null)
		{
			Action action = procedure.Actions?[0];
			if (action != null)
			{
				List<Output>? outputs = action.Outputs;
				if (outputs == null || outputs!.Count <= 0)
				{
					List<Input>? inputs = action.Inputs;
					if (inputs == null || inputs!.Count <= 1)
					{
						goto IL_0156;
					}
				}
				Report(Severity.ERROR, Type.Action, action.Name, Resources.Arguments, null, Resources.EventArgTypeNotMatch);
			}
		}
		goto IL_0156;
		IL_0156:
		if (procedure.Aysnc == "true" && procedure.Key != null)
		{
			Report(Severity.ERROR, Type.Procedure, procedure.Name, Resources.Async, null, Resources.AsyncWithEventDataNotSupport);
		}
	}

	internal void Check(Action action, Procedure procedure, Component component, List<Component> components)
	{
		Procedure procedure2 = procedure;
		action.Parent = procedure2;
		string name = action.Name;
		if (name == null)
		{
			ReportEmpty(Severity.FATAL_ERROR, Type.Procedure, name, Resources.Name);
		}
		if (action.GetArgsCount() > 6)
		{
			ReportNotSupported(Severity.FATAL_ERROR, Type.Action, action.Name, Resources.SystemNotSupport2, null);
		}
		List<Procedure>? procedures = component.Procedures;
		if (procedures != null && procedures!.Exists((Procedure p) => p != procedure2 && p.Name == name))
		{
			return;
		}
		string componentName = action.Component;
		if (componentName == null || componentName == component.Name)
		{
			component_actions.TryGetValue(component, out var actions);
			if (actions == null)
			{
				actions = new List<Action>();
				actions.Add(action);
				component_actions.Add(component, actions);
			}
			else if (!actions.Contains(action))
			{
				actions.Add(action);
			}
		}
		else if (!components.Exists((Component c) => c.Name == componentName))
		{
			string fullName = FunctionResolver.GetFullName(component, procedure2, name);
			ReportNotExist(Severity.FATAL_ERROR, Type.Action, fullName, Resources.Referring + Resources.Component, componentName);
		}
	}

	internal void CheckLocalActions()
	{
		foreach (KeyValuePair<Component, List<Action>> item in component_actions)
		{
			Component component = item.Key;
			string libShortName = component.GetLibShortName();
			if (libShortName == null)
			{
				continue;
			}
			lib_actions.TryGetValue(libShortName, out var actions);
			if (actions == null)
			{
				actions = new List<Action>();
				lib_actions.Add(libShortName, actions);
			}
			foreach (Action action in item.Value)
			{
				string sigName = action.GetSigName(component);
				if (!actions.Exists((Action a) => a.GetSigName(component) == sigName))
				{
					actions.Add(action);
				}
			}
		}
	}

	internal List<Action>? GetLocalActions(Component component)
	{
		string libShortName = component.GetLibShortName();
		if (libShortName == null)
		{
			return null;
		}
		lib_actions.TryGetValue(libShortName, out var actions);
		return actions;
	}

	internal void Check(Input input, int index, Action action, Procedure procedure, Component component)
	{
		if (input.Type == "action")
		{
			if (!action_functionArgument.TryGetValue(action, out var list))
			{
				list = new List<int>();
				action_functionArgument[action] = list;
			}
			if (input.Name == null)
			{
				input.Name = component.Name;
			}
			list.Add(index);
			return;
		}
		CheckIO(input, index, action, procedure, component);
		if (input.For != null)
		{
			if (!action_inputFor.TryGetValue(action, out var inputFor))
			{
				inputFor = new List<int>();
				action_inputFor[action] = inputFor;
			}
			inputFor.Add(index);
		}
	}

	internal void Check(Output output, int index, Action action, Procedure procedure, Component component)
	{
		CheckIO(output, index, action, procedure, component);
	}

	internal void CheckIO(IO io, int index, Action action, Procedure procedure, Component component)
	{
		Type clazz = ((io is Input) ? Type.Input : Type.Output);
		if (io.Name != null)
		{
			CheckExport(io, index, action, procedure);
		}
		CheckImport(io, index, action);

		int num = CheckArgType(io.Type ?? "string");
		if (num == -1)
		{
			string name2 = ((io is Input) ? Resources.InputType : Resources.OutputType);
			ReportArgTypeAsPointer(component, procedure, action, name2, io.Type);
		}
		if (num < 4 && action.GetArgsCount() > 4)
		{
			string name = action.Name ?? ((io is Input) ? new int?(index) : (index - action.Inputs?.Count)).ToString();
			Report(Severity.FATAL_ERROR, Type.Action, name, clazz.Description(), io.Name, Resources.SystemNotSupport1);
		}
	}

	private void CheckExport(IO io, int index, Action action, Procedure procedure)
	{
		List<string> exports = procedure.Exports;
		string name = io.Name;
		if (exports == null || name == null)
		{
			return;
		}
		int index2 = exports.IndexOf(name);
		if (index2 != -1)
		{
			export_types.Add(name, io.Type ?? "string");
			if (!procedure_exports.TryGetValue(procedure, out var list))
			{
				list = new List<ExportInfo>();
				procedure_exports[procedure] = list;
			}
			list.Add(new ExportInfo
			{
				Action = action,
				ExportIndex = index2,
				ArgumentIndex = index
			});
		}
	}

	private void CheckImport(IO io, int argIndex, Action action)
	{
		string type = io.Type ?? "string";
		if (export_types.TryGetValue(type, out var type2))
		{
			io.Type = type2;
			AddImport(action, new ImportInfo
			{
				Name = type,
				ArgumentIndex = argIndex
			});
			return;
		}
		string cleanType = FunctionResolver.GetCleanType(type);
		if (type != cleanType && export_types.TryGetValue(cleanType, out var type3))
		{
			io.Type = type.Replace(cleanType, type3);
			AddImport(action, new ImportInfo
			{
				Name = cleanType,
				ArgumentIndex = argIndex
			});
		}
	}

	private void AddImport(Action action, ImportInfo info)
	{
		if (!action_imports.TryGetValue(action, out var imports))
		{
			imports = new List<ImportInfo>();
			action_imports[action] = imports;
		}
		imports.Add(info);
	}

	internal List<string> CheckActionImports(List<ImportInfo>? infos, Action action)
	{
		List<string> imports = new List<string>();
		if (infos == null)
		{
			return imports;
		}
		int? inputCount = action.Inputs?.Count;
		foreach (ImportInfo info in infos!)
		{
			if (!(info.ArgumentIndex >= inputCount))
			{
				string name = action.GetIO(info.ArgumentIndex)?.Name;
				if (name == null)
				{
					imports.Add(info.Name);
				}
				else if (!action.HasPreviousArgName(name))
				{
					imports.Add(info.Name);
				}
			}
		}
		return imports;
	}

	private static int CheckArgType(string type)
	{
		int size = TypesInterop.GetValueTypeSize(type);
		if (size == -1)
		{
			return TypesInterop.GetRefTypeSize(type);
		}
		return size;
	}

	internal EntryPoint? GetEntryPoint(string sigName)
	{
		if (!sigName_entrypoints.TryGetValue(sigName, out var entrypoint))
		{
			return null;
		}
		return entrypoint;
	}

	internal List<KeyValuePair<string, EntryPoint>> GetSimilarEntryPoints(string sigNameWithoutParameters)
	{
		string sigNameWithoutParameters2 = sigNameWithoutParameters;
		return sigName_entrypoints.Where<KeyValuePair<string, EntryPoint>>((KeyValuePair<string, EntryPoint> prop) => prop.Key.StartsWith(sigNameWithoutParameters2)).ToList();
	}

	internal void AddEntryPoint(string sigName, EntryPoint entry, Action action)
	{
		sigName_entrypoints.Add(sigName, entry);
		entry_actions.Add(entry, action);
	}

	internal List<object?>? GetDefaultValues(EntryPoint entry)
	{
		entry_actions.TryGetValue(entry, out var action);
		if (action == null)
		{
			return null;
		}
		FunctionResolver functionResolver = new FunctionResolver(null);
		functionResolver.Parse(action);
		return functionResolver.DefaultValues;
	}

	internal void AddFunctionAction(Function function, Action action)
	{
		function_actions.Add(function, action);
	}

	internal Action? GetAction(Function function)
	{
		return function_actions[function];
	}

	internal Action? GetAction(EntryPoint entry)
	{
		return entry_actions[entry];
	}

	internal Action? GetOriginalAction(Function function)
	{
		EntryPoint entry = function.EntryPoint;
		if (entry == null)
		{
			return null;
		}
		return entry_actions[entry];
	}

	internal List<object?>? GetDefaultValues(Action action, EntryPoint entry)
	{
		FunctionResolver functionResolver = new FunctionResolver(null);
		functionResolver.Parse(action);
		List<object> defultValues = functionResolver.DefaultValues;
		List<object> defultValues2 = GetDefaultValues(entry);
		if (defultValues == null)
		{
			return defultValues2;
		}
		if (defultValues2 == null)
		{
			return defultValues;
		}
		if (defultValues.Count < defultValues2.Count)
		{
			return defultValues2;
		}
		return defultValues;
	}

	internal void AddRoutineProcedure(Routine routine, Procedure procedure)
	{
		routine_procedures.Add(routine, procedure);
	}

	internal Procedure? GetProcedure(Routine? routine)
	{
		if (routine == null)
		{
			return null;
		}
		if (!routine_procedures.TryGetValue(routine, out var procedure))
		{
			return null;
		}
		return procedure;
	}

	internal Dictionary<Action, Procedure> GetDeferResolvedActions()
	{
		return defer_resolved_actions;
	}

	internal void AddDeferResolvedAction(Action action, Procedure procedure)
	{
		defer_resolved_actions.Add(action, procedure);
	}

	internal Component? GetComponentOfLocalActions(string name)
	{
		foreach (Component component in component_actions.Keys)
		{
			if (component.Name == name)
			{
				return component;
			}
		}
		return null;
	}

	internal Dictionary<string, List<Procedure>> GetEventProcedure()
	{
		return event_procedure;
	}

	internal void AddDeferEvents(Procedure procedure, List<Event> events)
	{
		defer_events.Add(procedure, events);
	}

	internal List<Event>? GetDeferEvents(Procedure procedure)
	{
		if (!defer_events.TryGetValue(procedure, out var events))
		{
			return null;
		}
		return events;
	}

	internal void AddEventGroup(Procedure procedure, int groupId)
	{
		procedure_event_groups.Add(procedure, groupId);
	}

	internal int GetEventGroup(Procedure procedure)
	{
		if (!procedure_event_groups.TryGetValue(procedure, out var id))
		{
			return -1;
		}
		return id;
	}

	internal void AddFunctionRoutine(Function function, Routine routine)
	{
		function_routines.Add(function, routine);
	}

	internal Routine GetRoutine(Function function)
	{
		return function_routines[function];
	}

	internal Dictionary<Procedure, List<ExportInfo>> GetProcedureExports()
	{
		return procedure_exports;
	}

	internal Dictionary<Action, List<ImportInfo>> GetActionImports()
	{
		return action_imports;
	}

	internal Dictionary<Action, List<int>> GetActionInputFor()
	{
		return action_inputFor;
	}

	internal Dictionary<Action, List<int>> GetFunctionArguments()
	{
		return action_functionArgument;
	}

	internal Action? FindComponentAction(string? componentName, string? actionName)
	{
		string actionName2 = actionName;
		if (componentName == null || actionName2 == null)
		{
			return null;
		}
		foreach (KeyValuePair<Component, List<Action>> pair in component_actions)
		{
			if (pair.Key.Name == componentName)
			{
				return pair.Value.Find((Action action) => action.Name == actionName2);
			}
		}
		return null;
	}

	internal Action GetVirtualAction(Routine entryRoutine)
	{
		if (virtual_actions.TryGetValue(entryRoutine, out var action))
		{
			return action;
		}
		action = new Action
		{
			Name = "virtual action"
		};
		virtual_actions.Add(entryRoutine, action);
		Function function = (action.Function = new Function
		{
			Routine = entryRoutine
		});
		return action;
	}
}

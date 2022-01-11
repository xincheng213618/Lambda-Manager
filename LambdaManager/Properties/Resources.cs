using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace LambdaManager.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				resourceMan = new ResourceManager("LambdaManager.Properties.Resources", typeof(Resources).Assembly);
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static string Action => ResourceManager.GetString("Action", resourceCulture);

	internal static string ActionTimesInputCountNotMatch => ResourceManager.GetString("ActionTimesInputCountNotMatch", resourceCulture);

	internal static string ActionTimesInputTypeNotMatch => ResourceManager.GetString("ActionTimesInputTypeNotMatch", resourceCulture);

	internal static string ArgType => ResourceManager.GetString("ArgType", resourceCulture);

	internal static string Arguments => ResourceManager.GetString("Arguments", resourceCulture);

	internal static string AsPointer => ResourceManager.GetString("AsPointer", resourceCulture);

	internal static string Async => ResourceManager.GetString("Async", resourceCulture);

	internal static string AsyncWithEventDataNotSupport => ResourceManager.GetString("AsyncWithEventDataNotSupport", resourceCulture);

	internal static string AsyncWithOutputReferredNotSupport => ResourceManager.GetString("AsyncWithOutputReferredNotSupport", resourceCulture);

	internal static string Class => ResourceManager.GetString("Class", resourceCulture);

	internal static string ClassNameWanted => ResourceManager.GetString("ClassNameWanted", resourceCulture);

	internal static string Comma => ResourceManager.GetString("Comma", resourceCulture);

	internal static string Component => ResourceManager.GetString("Component", resourceCulture);

	internal static string ConfigLoaded => ResourceManager.GetString("ConfigLoaded", resourceCulture);

	internal static string ConfigLoading => ResourceManager.GetString("ConfigLoading", resourceCulture);

	internal static string CreateFailed => ResourceManager.GetString("CreateFailed", resourceCulture);

	internal static string DuplicateLib => ResourceManager.GetString("DuplicateLib", resourceCulture);

	internal static string Empty => ResourceManager.GetString("Empty", resourceCulture);

	internal static string EntryPoint => ResourceManager.GetString("EntryPoint", resourceCulture);

	internal static string Error => ResourceManager.GetString("Error", resourceCulture);

	internal static string EventArgTypeNotMatch => ResourceManager.GetString("EventArgTypeNotMatch", resourceCulture);

	internal static string EventDataNotSupport => ResourceManager.GetString("EventDataNotSupport", resourceCulture);

	internal static string EventTypeNotSpecified => ResourceManager.GetString("EventTypeNotSpecified", resourceCulture);

	internal static string Execute => ResourceManager.GetString("Execute", resourceCulture);

	internal static string Expired => ResourceManager.GetString("Expired", resourceCulture);

	internal static string Export => ResourceManager.GetString("Export", resourceCulture);

	internal static string File => ResourceManager.GetString("File", resourceCulture);

	internal static string Import => ResourceManager.GetString("Import", resourceCulture);

	internal static string Init => ResourceManager.GetString("Init", resourceCulture);

	internal static string InputType => ResourceManager.GetString("InputType", resourceCulture);

	internal static string Lib => ResourceManager.GetString("Lib", resourceCulture);

	internal static string Menu => ResourceManager.GetString("Menu", resourceCulture);

	internal static string Name => ResourceManager.GetString("Name", resourceCulture);

	internal static string NotExist => ResourceManager.GetString("NotExist", resourceCulture);

	internal static string NotExportProc => ResourceManager.GetString("NotExportProc", resourceCulture);

	internal static string NotFound => ResourceManager.GetString("NotFound", resourceCulture);

	internal static string Notice => ResourceManager.GetString("Notice", resourceCulture);

	internal static string NotMatched => ResourceManager.GetString("NotMatched", resourceCulture);

	internal static string NotSupported => ResourceManager.GetString("NotSupported", resourceCulture);

	internal static string of => ResourceManager.GetString("of", resourceCulture);

	internal static string OpenFiles => ResourceManager.GetString("OpenFiles", resourceCulture);

	internal static string or => ResourceManager.GetString("or", resourceCulture);

	internal static string OutputType => ResourceManager.GetString("OutputType", resourceCulture);

	internal static string PleaseCheck => ResourceManager.GetString("PleaseCheck", resourceCulture);

	internal static string Procedure => ResourceManager.GetString("Procedure", resourceCulture);

	internal static string RaiseKeys => ResourceManager.GetString("RaiseKeys", resourceCulture);

	internal static string Reference => ResourceManager.GetString("Reference", resourceCulture);

	internal static string ReferredAction => ResourceManager.GetString("ReferredAction", resourceCulture);

	internal static string ReferredArgsNotSpecified => ResourceManager.GetString("ReferredArgsNotSpecified", resourceCulture);

	internal static string Referring => ResourceManager.GetString("Referring", resourceCulture);

	internal static string ScheduleEnd => ResourceManager.GetString("ScheduleEnd", resourceCulture);

	internal static string ScheduleStart => ResourceManager.GetString("ScheduleStart", resourceCulture);

	internal static string Signature => ResourceManager.GetString("Signature", resourceCulture);

	internal static string StartFatalError => ResourceManager.GetString("StartFatalError", resourceCulture);

	internal static string StartUp => ResourceManager.GetString("StartUp", resourceCulture);

	internal static string STLMapNotSupport => ResourceManager.GetString("STLMapNotSupport", resourceCulture);

	internal static string SystemNotSupport1 => ResourceManager.GetString("SystemNotSupport1", resourceCulture);

	internal static string SystemNotSupport2 => ResourceManager.GetString("SystemNotSupport2", resourceCulture);

	internal static string Undefined => ResourceManager.GetString("Undefined", resourceCulture);

	internal Resources()
	{
	}
}

using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LambdaManager.Properties
{
	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00005ECF File Offset: 0x000040CF
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005ED6 File Offset: 0x000040D6
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ExitIfLoadFatalError
		{
			get
			{
				return (bool)this["ExitIfLoadFatalError"];
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00005EE8 File Offset: 0x000040E8
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("INFO")]
		public string LogLevel
		{
			get
			{
				return (string)this["LogLevel"];
			}
		}

		// Token: 0x0400002C RID: 44
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}

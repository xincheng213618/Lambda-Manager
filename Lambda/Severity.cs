using System.ComponentModel;

namespace Lambda;

public enum Severity
{
	[Description("调试：")]
	DEBUG,
	[Description("信息：")]
	INFO,
	[Description("告警：")]
	WARNING,
	[Description("错误：")]
	ERROR,
	[Description("严重错误：")]
	FATAL_ERROR
}

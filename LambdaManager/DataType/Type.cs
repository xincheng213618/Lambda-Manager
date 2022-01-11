using System.ComponentModel;

namespace LambdaManager.DataType;

internal enum Type
{
	[Description("模块")]
	Component,
	[Description("流程")]
	Procedure,
	[Description("函数")]
	Action,
	[Description("输入参数")]
	Input,
	[Description("输出参数")]
	Output
}

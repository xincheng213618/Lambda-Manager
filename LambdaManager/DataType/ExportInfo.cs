namespace LambdaManager.DataType;

internal class ExportInfo
{
	internal Action Action { get; set; } = new Action();


	internal int ExportIndex { get; set; }

	internal int ArgumentIndex { get; set; }
}

namespace LambdaManager.DataType;

internal class VirtualLink : Link
{
	internal Function SourceFunction { get; set; }

	internal int TargetGroup { get; set; }

	internal VirtualLink(Function srcFunction, int group)
	{
		SourceFunction = srcFunction;
		TargetGroup = group;
	}
}

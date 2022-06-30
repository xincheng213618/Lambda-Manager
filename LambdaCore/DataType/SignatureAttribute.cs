using System;

namespace LambdaManager.DataType;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
internal class SignatureAttribute : Attribute
{
	public string Signature { get; set; }

	public int Index { get; set; }

	public SignatureAttribute(int index, string signature)
	{
		Signature = signature;
		Index = index;
	}
}

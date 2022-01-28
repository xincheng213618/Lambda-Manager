using System;
using System.ComponentModel;
using System.Reflection;
using Lambda;

namespace LambdaManager.DataType;

internal static class TypeExtension
{
	internal static string Description(this Type obj)
	{
		return GetDescription(obj);
	}

	internal static string Description(this Severity obj)
	{
		return GetDescription(obj);
	}

	private static string GetDescription(object obj)
	{
		System.Type type = obj.GetType();
		MemberInfo[] member = type.GetMember(obj.ToString() ?? "");
		if (member != null && member.Length != 0)
		{
			object[] customAttributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
			if (customAttributes != null && customAttributes.Length != 0)
			{
				return ((DescriptionAttribute)customAttributes[0]).Description;
			}
		}
		return type.ToString();
	}
}

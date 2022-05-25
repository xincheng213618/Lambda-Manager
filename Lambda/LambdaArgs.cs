using System;
using System.Collections.Generic;
using LambdaUtils;

namespace Lambda;

public class LambdaArgs : EventArgs
{
	public object? Data { get; set; }

	public static Dictionary<string, object>? GetEventData(EventArgs e)
	{
		if (e is LambdaArgs lambdaArgs)
		{
			object data = lambdaArgs.Data;
			if (data == null)
			{
				return null;
			}
			if (data is string json)
			{
				return (Dictionary<string, object>)JSON.Parse(json);
			}
			if (data is Dictionary<string, object> result)
			{
				return result;
			}
			return null;
		}
		return null;
	}
}

using System;
using Quartz.Logging;

namespace LambdaManager.Utils;

internal class ConsoleLogProvider : ILogProvider
{
	public Logger GetLogger(string name)
	{
		return delegate(LogLevel level, Func<string> func, Exception exception, object[] parameters)
		{
			if (level >= LogLevel.Info && func != null)
			{
				Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level.ToString() + "] " + func(), parameters);	
			}
			return true;
		};
	}

	public IDisposable OpenNestedContext(string message)
	{
		throw new NotImplementedException();
	}

	public IDisposable OpenMappedContext(string key, object value, bool destructure = false)
	{
		throw new NotImplementedException();
	}
}

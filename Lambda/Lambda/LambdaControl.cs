using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Lambda;

public class LambdaControl : Control
{
	public static LogHandler? LogHandler { get; set; }

	public static AddEventHandler? AddEventHandler { get; set; }

	public static CallEventHandler? CallEventHandler { get; set; }

	public static void Log(Message message)
	{
		LogHandler?.Invoke(message);
	}

	public void Trigger(string type, Dictionary<string, object>? json)
	{
		CallEventHandler?.Invoke(type, this, new LambdaArgs
		{
			Data = json
		});
	}

	public void Trigger(string type, string? json)
	{
		CallEventHandler?.Invoke(type, this, new LambdaArgs
		{
			Data = json
		});
	}

	public void Trigger(string type, EventArgs e)
	{
		CallEventHandler?.Invoke(type, this, e);
	}

	public static void Trigger(string type, object sender, Dictionary<string, object>? json)
	{
		CallEventHandler?.Invoke(type, sender, new LambdaArgs
		{
			Data = json
		});
	}

	public static void Trigger(string type, object sender, string? json)
	{
		CallEventHandler?.Invoke(type, sender, new LambdaArgs
		{
			Data = json
		});
	}

	public static void Trigger(string type, object sender, EventArgs e)
	{
		CallEventHandler?.Invoke(type, sender, e);
	}

	public static void AddLambdaEventHandler(string type, LambdaHandler handler, bool once)
	{
		AddEventHandler?.Invoke(type, handler, once);
	}
}

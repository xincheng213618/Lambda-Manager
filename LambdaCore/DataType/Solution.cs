using System.Collections.Generic;
using System.IO;
using Quartz;

namespace LambdaManager.DataType;

public class Solution
{
	public List<Lib> Libs { get; set; } = new List<Lib>();


	internal Dictionary<Event, List<Routine>> Routines { get; set; } = new Dictionary<Event, List<Routine>>();


	internal Dictionary<string, Event> Events { get; set; } = new Dictionary<string, Event>();


	internal List<Function> Functions { get; set; } = new List<Function>();


	internal Event UndefinedEvent { get; set; } = new Event
	{
		Type = "UNDEFINED"
	};


	internal Event InitEvent { get; set; } = new Event
	{
		Type = "INIT"
	};


	internal StreamWriter? Writer { get; set; }

	internal IScheduler? Scheduler { get; set; }
}

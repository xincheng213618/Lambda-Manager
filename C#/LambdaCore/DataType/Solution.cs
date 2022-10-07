using System.Collections.Generic;
using System.IO;
using Quartz;

namespace LambdaManager.DataType
{

    public class Solution
    {
        public List<Lib> Libs { get; set; } = new List<Lib>();


        public Dictionary<Event, List<Routine>> Routines { get; set; } = new Dictionary<Event, List<Routine>>();


        public Dictionary<string, Event> Events { get; set; } = new Dictionary<string, Event>();


        public List<Function> Functions { get; set; } = new List<Function>();


        public Event UndefinedEvent { get; set; } = new Event
        {
            Type = "UNDEFINED"
        };


        public Event InitEvent { get; set; } = new Event
        {
            Type = "INIT"
        };


        public IScheduler? Scheduler { get; set; }
    }

}

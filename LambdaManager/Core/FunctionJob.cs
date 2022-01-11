using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Lambda;
using LambdaManager.DataType;
using LambdaManager.Properties;
using Quartz;

namespace LambdaManager.Core;

internal class FunctionJob : IJob
{
	private static readonly List<Scheduler> schedules = new List<Scheduler>();

	public static void AddSchedule(Scheduler schedule)
	{
		schedules.Add(schedule);
	}

	public static List<Scheduler> GetSchedules()
	{
		return schedules;
	}
    public async Task Execute(IJobExecutionContext context)
    {
        JobKey key = context.JobDetail.Key;
        await Task.Delay(1);
        if (key != null)
        {
            string name = key.Name;
            int index = int.Parse(name[new Range(end: name.Length, start: 3)]);
            Scheduler scheduler = schedules[index];
            Routine routine = scheduler.Routine;
            if (routine != null)
            {
                DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 4);
                defaultInterpolatedStringHandler.AppendFormatted(Resources.ScheduleStart);
                defaultInterpolatedStringHandler.AppendLiteral("\"");
                defaultInterpolatedStringHandler.AppendFormatted(scheduler.Name);
                defaultInterpolatedStringHandler.AppendLiteral("\"");
                defaultInterpolatedStringHandler.AppendFormatted(Resources.Comma);
                defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
                string text = defaultInterpolatedStringHandler.ToStringAndClear();
                App.Report(new Message
                {
                    Severity = Severity.INFO,
                    Text = text
                });
                FunctionExecutor.Evaluate(new ExecInfo
                {
                    Routine = routine
                });
                defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 4);
                defaultInterpolatedStringHandler.AppendFormatted(Resources.ScheduleEnd);
                defaultInterpolatedStringHandler.AppendLiteral("\"");
                defaultInterpolatedStringHandler.AppendFormatted(scheduler.Name);
                defaultInterpolatedStringHandler.AppendLiteral("\"");
                defaultInterpolatedStringHandler.AppendFormatted(Resources.Comma);
                defaultInterpolatedStringHandler.AppendFormatted(DateTime.Now);
                text = defaultInterpolatedStringHandler.ToStringAndClear();
                await Report(new Message
                {
                    Severity = Severity.INFO,
                    Text = text
                });
            }
        }
    }

    public static async Task Report(Message message)
	{
		Message message2 = message;
		Task task = new Task(delegate
		{
			App.Report(message2);
		});
		task.Start();
		await task;
	}
}

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

	public static int AddSchedule(Scheduler schedule)
	{
		int count = schedules.Count;
		schedules.Add(schedule);
		return count;
	}

	public static List<Scheduler> GetSchedules()
	{
		return schedules;
	}

	public async Task Execute(IJobExecutionContext context)
	{
		JobKey key = context.JobDetail.Key;
		if (key == null)
		{
			return;
		}
		string name2 = key.Name;
		int index = int.Parse(name2[new Range(end: name2.Length, start: 3)]);
		Scheduler scheduler = schedules[index];
		Routine routine = scheduler.Routine;
		if (routine == null)
		{
			string name = scheduler.Name;
			if (name != null)
			{
				ReportBegin(scheduler, routine: false);
				string json = scheduler.EventObject;
				if (json == null)
				{
					Common.CallEvent(name, IntPtr.Zero);
				}
				else
				{
					Common.CallEvent(name, json, IntPtr.Zero);
				}
				await ReportEnd(scheduler);
			}
		}
		else
		{
			ReportBegin(scheduler, routine: true);
			FunctionExecutor.Evaluate(new ExecInfo
			{
				Routine = routine
			});
			await ReportEnd(scheduler);
		}
	}

	private static void ReportBegin(Scheduler scheduler, bool routine)
	{
		string begin = (routine ? Resources.ScheduleStart : Resources.ScheduleTrigger);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 4);
		defaultInterpolatedStringHandler.AppendFormatted(begin);
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
	}

	private static async Task ReportEnd(Scheduler scheduler)
	{

		string text = $"{Resources.ScheduleEnd}\\{scheduler.Name}\\{Resources.Comma}DateTime.Now";


		await Report(new Message
		{
			Severity = Severity.INFO,
			Text = text
		});
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

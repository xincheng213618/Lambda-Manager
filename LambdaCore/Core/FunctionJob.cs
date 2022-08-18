using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Lambda;
using LambdaManager.DataType;
using Quartz;

namespace LambdaManager.Core
{
    public class FunctionJob : IJob
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
            int index = int.Parse(name2.Substring(3, name2.Length - 3));
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
            Log.Report(new Message
            {
                Severity = Severity.INFO,
                Text = $"{(routine ? "定时执行" : "定时触发")}\\{scheduler.Name}\\:{DateTime.Now}"
            });
        }

        private static async Task ReportEnd(Scheduler scheduler)
        {
            await Report(new Message
            {
                Severity = Severity.INFO,
                Text = $"定时完成:{scheduler.Name} : {DateTime.Now}"
            });
        }

        public static async Task Report(Message message)
        {
            Message message2 = message;
            Task task = new Task(delegate
            {
                Log.Report(message2);
            });
            task.Start();
            await task;
        }
    }
    public class FunctionJob1 : IJob
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


        public Task Execute(IJobExecutionContext context)
        {
            if (context.JobDetail.JobDataMap.TryGetValue("callback", out var callback))
            {
                if (context.Trigger.JobDataMap.TryGetValue("times", out var times))
                {
                    int n = (int)times;
                    if (n == 0)
                    {
                        context.Scheduler.UnscheduleJob(context.Trigger.Key);
                        return Task.CompletedTask;
                    }
                    else
                    {
                        n--;
                        context.Trigger.JobDataMap.Put("times", n);
                        return Task.Run(() => { Common.InvokeCallback((IntPtr)callback); });
                    }
                }
            }
            return Task.CompletedTask;
        }

        public static Task Dealy(int times, IntPtr callback)
        {
            return Task.Run(async delegate
            {
                await Task.Delay(times);
                Common.InvokeCallback((IntPtr)callback);
            });
        }
    }


    public class FunctionJob2 : IJob
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


        public Task Execute(IJobExecutionContext context)
        {
            if (context.JobDetail.JobDataMap.TryGetValue("id", out var callback))
            {
                if (context.Trigger.JobDataMap.TryGetValue("times", out var times))
                {
                    int n = (int)times;
                    if (n == 0)
                    {
                        context.Scheduler.UnscheduleJob(context.Trigger.Key);
                        return Task.CompletedTask;
                    }
                    else
                    {
                        n--;
                        context.Trigger.JobDataMap.Put("times",n);
                        return Task.Run(() => { Common.InvokeLambdaCallback((int)callback); });
                    }
                }
            }
            return Task.CompletedTask;
        }

        public static Task Dealy(int times, int callback)
        {
            return Task.Run( async delegate
            {
                await Task.Delay(times);
                Common.InvokeLambdaCallback((int)callback);
            });
        }
    }

}


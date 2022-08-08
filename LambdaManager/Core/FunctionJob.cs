using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Lambda;
using LambdaManager.DataType;
using LambdaManager.Properties;
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
                Text = $"{(routine ? Resources.ScheduleStart : Resources.ScheduleTrigger)}\\{scheduler.Name}\\{Resources.Comma} {DateTime.Now}"
            });
        }

        private static async Task ReportEnd(Scheduler scheduler)
        {
            await Report(new Message
            {
                Severity = Severity.INFO,
                Text = $"{Resources.ScheduleEnd}:{scheduler.Name} {Resources.Comma} {DateTime.Now}"
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

        private sealed class Schedule
        {
            public object callback;
            public void Invoke()
            {
                Common.InvokeCallback((IntPtr)callback);
            }
        }
        private sealed class Schedule1
        {
            public int times;
            public IntPtr callback;

            public Task Invoke()
            {
                Schedule schedule = new Schedule() { callback = callback };
                Task.Delay(times);
                return Task.Run(delegate
                {
                    schedule.Invoke();
                });
            }
        }

        public  Task Execute(IJobExecutionContext context)
        {
            Schedule schedule = new Schedule();
            context.JobDetail.JobDataMap.TryGetValue("callback", out schedule.callback);
            if (schedule.callback!=null)
                return Task.Run(schedule.Invoke);
            else
                return null;
        }

        public static Task Dealy(int times, IntPtr callback)
        {
            Schedule1 schedule1 = new Schedule1() { times = times, callback = callback };
            return Task.Run(delegate
            {
                schedule1.Invoke();
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

        private sealed class Schedule
        {
            public object callback;
            public void Invoke()
            {
                Common.InvokeLambdaCallback((int)callback);
            }
        }
        private sealed class Schedule1
        {
            public int times;
            public int callback;

            public Task Invoke()
            {
                Schedule schedule = new Schedule() { callback = callback };
                Task.Delay(times);
                return Task.Run(delegate
                {
                    schedule.Invoke();
                });
            }
        }

        public Task Execute(IJobExecutionContext context)
        {
            Schedule schedule = new Schedule();
            context.JobDetail.JobDataMap.TryGetValue("id", out schedule.callback);
            return Task.Factory.StartNew(schedule.Invoke);
        }

        public static Task Dealy(int times, int callback)
        {
            Schedule1 schedule = new Schedule1() { times = times, callback = callback };
            return Task.Run(delegate
            {
                schedule.Invoke();
            });
        }
    }

}


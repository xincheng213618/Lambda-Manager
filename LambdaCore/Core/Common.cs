using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Lambda;
using LambdaManager.Conversion;
using LambdaManager.DataType;
using LambdaManager.Utils;
using LambdaUtils;
using Quartz;

namespace LambdaManager.Core
{
    public  class Common
    {
        public static View[] Views { get; } = new View[100];

        public static List<int> ClosingViewIndex { get; } = new List<int>();

        public static List<View> RegisterImageViews = new List<View>();

        public static readonly FPSCounter fps = new FPSCounter();

        private static readonly int RESERVED_EVENT_RESULT = 2147400000;

        private static readonly List<string> events = new List<string>();

        private static readonly List<ExecInfo> callbacks = new List<ExecInfo>();

        private static readonly List<LambdaHandler> ui_handlers = new List<LambdaHandler>();

        internal static IScheduler? Scheduler;



        internal unsafe static void Init()
        {

            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, sbyte*, void>)(&AddMessage1), 0);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, char*, void>)(&AddMessage2), 1);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<nint, int>)(&GetArraySize), 2);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, int, IntPtr, int, int, int, int>)(&InitialFrame), 3);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, int, IntPtr, uint, int, int>)(&UpdateFrame), 4);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, void>)(&CloseImageView), 9);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<sbyte*, void>)(&StartService), 5);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<sbyte*, void>)(&StopService), 6);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<sbyte*, sbyte*, sbyte*, void>)(&ScheduleEvent), 7);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<nint, void>)(&CallHandlerRaise), 8);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, int>)(&CallBack1), 0);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack2), 2);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack3), 1);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack4), 3);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack5), 4);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, nint, int>)(&CallBack6), 5);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, nint, nint, nint, int>)(&CallBack7), 6);
            SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, int, nint, int>)(&CallBack8), 7);

            SetHandler((nint)(delegate* unmanaged[Cdecl]<sbyte*, int, nint, nint>)(&Schedule), 10);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<sbyte*, int, int, nint>)(&Schedule2), 12);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, int, nint, nint>)(&Delay), 11);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<int, int, int, nint>)(&Delay2), 13);
            SetHandler((nint)(delegate* unmanaged[Cdecl]<sbyte*, void>)(&StopSchedule), 14);

            GetCppSizeInfo((delegate* unmanaged[Cdecl]<sbyte*, void>)(&SetCppSize));
            LambdaControl.Initialize(Log.Report, Log.Report2, AddEventHandler, CallEvent, RegisterImage, StopRegisterImage, Views);
            Initialize();

        }



        private static void StopRegisterImage(int index)
        {
            foreach (var item in RegisterImageViews)
            {
                if (item.Index == index)
                    RegisterImageViews.Remove(item);
            }
        }
        private static int RegisterImage(Image image)
        {
            View view = new View(image, -RegisterImageViews.Count - 1);
            RegisterImageViews.Add(view);
            return view.Index;
        }


        [DllImport("lib\\common.dll")]
        public static extern void Initialize();

        [DllImport("lib\\common.dll")]
        public static extern void SetHandler(nint pRoutineHandler, int handlerType);

        [DllImport("lib\\common.dll")]
        public unsafe static extern void SetMessageHandler1(delegate* unmanaged[Cdecl]<int, sbyte*, void> pMessageHandler);

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static void AddMessage1(int severity, sbyte* message)
        {
            LambdaControl.Log(new Message
            {
                Severity = (Severity)severity,
                Text = new string(message)
            });

        }



        [DllImport("lib\\common.dll")]
        public unsafe static extern void SetMessageHandler2(delegate* unmanaged[Cdecl]<int, char*, void> pMessageHandler);

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static void AddMessage2(int severity, char* message)
        {
            LambdaControl.Log2(new Message
            {
                Severity = (Severity)severity,
                Text = new string(message)
            });
        }

        [DllImport("lib\\common.dll", EntryPoint = "CallFunction")]
        public unsafe static extern int RaiseEvent(sbyte* type, int argType, nint eventObject, nint sender);

        public unsafe static int CallEvent(string type, nint sender)
        {
            fixed (sbyte* p = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
            {
                return RaiseEvent(p, 0, IntPtr.Zero, sender);
            }
        }
        public unsafe static int CallEvent(string type, Array arry, nint sender)
        {
            sbyte[] obj = (sbyte[])(object)Encoding.UTF8.GetBytes(type);

            fixed (sbyte* p = obj)
            {
                if (arry is int[] i)
                {
                    fixed (int* pData = i)
                    {
                        return RaiseEvent(p, 1, (nint)pData, sender);
                    }
                }
                else if (arry is double[] dou)
                {
                    fixed (double* pData = dou)
                    {
                        return RaiseEvent(p, 1, (nint)pData, sender);
                    }
                }
                else if (arry is float[] fl)
                {
                    fixed (float* pData = fl)
                    {
                        return RaiseEvent(p, 1, (nint)pData, sender);
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public unsafe static int CallEvent(string type, string json, nint sender)
        {
            sbyte[] obj = (sbyte[])(object)Encoding.UTF8.GetBytes(type);
            sbyte[] pStr = (sbyte[])(object)Encoding.UTF8.GetBytes(json);
            fixed (sbyte* p = obj)
            {
                fixed (sbyte* pData = pStr)
                {
                    return RaiseEvent(p, 1, (nint)pData, sender);
                }
            }
        }

        public unsafe static int CallEvent(string type, nint handle, nint sender)
        {
            fixed (sbyte* p = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
            {
                return RaiseEvent(p, 1, handle, sender);
            }
        }

        public unsafe static int CallEvent(string type, List<object?>? arguments, nint sender)
        {
            if (arguments == null || arguments!.Count == 0)
            {
                return CallEvent(type, sender);
            }
            int count = arguments!.Count;
            fixed (sbyte* p = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
            {
                switch (count)
                {
                    case 3:
                        break;
                    case 1:
                        {
                            object obj = arguments?[0];
                            nint handle = ((obj == null) ? IntPtr.Zero : ((IntPtr)obj));
                            return RaiseEvent(p, 4, handle, sender);
                        }
                    case 2:
                    case 4:
                        {
                            IntPtr[] handles = List2Array(arguments);
                            ArgumentType argType = ((count == 2) ? ArgumentType.POINTER2 : ArgumentType.POINTER4);
                            return RaiseEvent(p, (int)argType, handles[0], sender);
                        }
                }
            }
            return -1;
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        public unsafe static void ScheduleEvent(sbyte* type, sbyte* cron, sbyte* json)
        {
            if (Scheduler != null)
            {
                Scheduler info = new Scheduler
                {
                    Name = new string(type),
                    Timer = new string(cron)
                };
                if (json != null)
                {
                    info.EventObject = new string(json);
                }
                int index = FunctionJob.AddSchedule(info);

                JobBuilder jobBuilder = JobBuilder.Create<FunctionJob>();
                IJobDetail job = jobBuilder.WithIdentity($"Job{index}", "group2").Build();
                TriggerBuilder triggerBuilder = TriggerBuilder.Create();
                ITrigger trigger = triggerBuilder.WithIdentity($"Trigger{index}", "group2").StartNow().WithCronSchedule(info.Timer)
                    .Build();

                Scheduler!.ScheduleJob(job, trigger);

            }
        }

        [DllImport("lib\\common.dll", EntryPoint = "SetHandlerRaise")]
        public static extern void MarkHandlerRaise(nint handler);

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static void CallHandlerRaise(nint fp)
        {
            Function function = FunctionExecutor.Solution.Functions.Find(delegate (Function f)
            {
                EntryPoint? entryPoint = f.EntryPoint;
                return entryPoint != null && entryPoint!.FuncAddr == fp;
            });
            if (function != null)
            {
                List<Event> raise = function.Raise;
                if (raise != null)
                {
                    FunctionExecutor.RaiseEvents(raise, null, function.EntryPoint);
                }
            }
        }

        private static nint[] List2Array(List<object?> arguments)
        {
            int count = arguments.Count;
            IntPtr[] array = new IntPtr[count];
            for (int i = 0; i < count; i++)
            {
                object obj = arguments[i];
                IntPtr handle = (array[i] = ((obj == null) ? IntPtr.Zero : ((IntPtr)obj)));
            }
            return array;
        }

        [DllImport("lib\\common.dll")]
        public static extern void SetRoutineHandler(nint pRoutineHandler, int argType);

        private static ExecInfo Clone(ExecInfo info)
        {
            return new ExecInfo
            {
                Routine = info.Routine,
                Group = info.Group
            };
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int CallBack1(int index, nint sender)
        {
            int? result = UICallback(index, null, sender);
            if (result.HasValue)
            {
                return result.Value;
            }
            return FunctionExecutor.Evaluate(Clone(callbacks[index]));
        }


        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static int CallBack2(int index, nint pEventData, nint sender)
        {
            ExecInfo info = callbacks[index];
            info = Clone(info);
            if (pEventData != IntPtr.Zero)
            {
                info.RoutineArguments = new List<object> { pEventData };
            }
            return FunctionExecutor.Evaluate(info);
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static int CallBack3(int index, nint pEventData, nint sender)
        {
            string json = null;
            if (pEventData != IntPtr.Zero)
            {
                int length = default(int);
                sbyte* p2 = default(sbyte*);
                p2 = (sbyte*)pEventData;
                while (*(p2++) != 0)
                    length++;

                json = new string((sbyte*)pEventData, 0, length, Encoding.UTF8);
            }
            int? result = UICallback(index, json, sender);
            if (result.HasValue)
            {
                return result.Value;
            }
            ExecInfo info = callbacks[index];
            info = Clone(info);
            if (json != null)
            {
                Dictionary<string, object> eventObject = (Dictionary<string, object>)JSON.Parse(json);
                if (eventObject != null)
                {
                    info.RoutineArguments = PrepareArguments(info.Routine, index, eventObject);
                }
            }
            return FunctionExecutor.Evaluate(info);
        }

        private static List<object?>? PrepareArguments(Routine routine, int index, Dictionary<string, object> eventObject)
        {
            Dictionary<string, int> dataMap = FunctionExecutor.Solution?.Events?[events[index]].GetEventMap(routine);
            if (dataMap == null)
            {
                return null;
            }
            List<object> args = new List<object>();
            foreach (KeyValuePair<string, int> pair in dataMap)
            {
                eventObject.TryGetValue(pair.Key, out var value);
                CollectionUtils.Insert(args, pair.Value, value);
            }
            return args;
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int CallBack4(int index, nint pEventData, nint sender)
        {
            ExecInfo info = callbacks[index];
            info = Clone(info);
            if (pEventData != IntPtr.Zero)
            {
                info.RoutineArguments = new List<object> { pEventData };
            }
            return FunctionExecutor.Evaluate(info);
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int CallBack5(int index, nint handle, nint sender)
        {
            ExecInfo info = callbacks[index];
            info = Clone(info);
            if (handle != IntPtr.Zero)
            {
                info.RoutineArguments = new List<object> { handle };
            }
            return FunctionExecutor.Evaluate(info);
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int CallBack6(int index, nint handle1, nint handle2, nint sender)
        {
            ExecInfo info = callbacks[index];
            info = Clone(info);
            if (handle1 != IntPtr.Zero)
            {
                info.RoutineArguments = new List<object> { handle1, handle2 };
            }
            return FunctionExecutor.Evaluate(info);
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int CallBack7(int index, nint handle1, nint handle2, nint handle3, nint handle4, nint sender)
        {
            ExecInfo info = callbacks[index];
            info = Clone(info);
            if (handle1 != IntPtr.Zero)
            {
                info.RoutineArguments = new List<object> { handle1, handle2, handle3, handle4 };
            }
            return FunctionExecutor.Evaluate(info);
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int CallBack8(int index, nint handle1, int handle2, nint handle3)
        {
            if (index >= RESERVED_EVENT_RESULT)
            {
                LambdaHandler lambdaHandler = ui_handlers[index - RESERVED_EVENT_RESULT];
                Dictionary<string, object> eventObject = new Dictionary<string, object>
        {
            { "data", handle1 },
            { "size", handle2 }
        };
                LambdaArgs e = new LambdaArgs
                {
                    Data = eventObject
                };
                object obj = null;
                if (handle3 != IntPtr.Zero)
                {
                    obj = GetObjectFromAddress<object>(handle3);
                }
                return (!lambdaHandler(obj ?? "Unknown", e)) ? (-1) : 0;
            }
            return -1;

        }


        [DllImport("lib\\common.dll")]
        public unsafe static extern void RegisterFunctionEvent(sbyte* type, IntPtr fn1, ArgumentType handlerType, int once);

        public unsafe static void AddEventHandler(string type, ArgumentType argType, IntPtr callback, bool once)
        {
            if (!(callback == IntPtr.Zero))
            {
                fixed (sbyte* p = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
                {
                    RegisterFunctionEvent(p, callback, argType, once ? 1 : 0);
                }
            }
        }

        [DllImport("lib\\common.dll")]
        public unsafe static extern void RegisterRoutineEvent(sbyte* type, int rotineId, ArgumentType handlerType, int once);

        public unsafe static void AddEventHandler(string type, ArgumentType argType, Routine? routine, bool once, int group)
        {
            if (routine != null)
            {
                int index = callbacks.Count;
                callbacks.Add(new ExecInfo
                {
                    Routine = routine,
                    Group = group
                });
                events.Add(type);
                fixed (sbyte* p = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
                {
                    RegisterRoutineEvent(p, index, argType, once ? 1 : 0);
                }
            }
        }



        public unsafe static void AddEventHandler(string type, LambdaHandler handler, bool once)
        {
            int index = ui_handlers.Count;
            ui_handlers.Add(handler);
            fixed (sbyte* p = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
            {
                RegisterRoutineEvent(p, RESERVED_EVENT_RESULT + index, ArgumentType.JSON_STRING, once ? 1 : 0);
            }
        }

        public static int CallEvent(string type, object sender, EventArgs e)
        {
            GCHandle handle = GCHandle.Alloc(sender);
            try
            {

                int result = CallEvent(type, handle, e);

                if (result >= RESERVED_EVENT_RESULT)
                {
                    return (!ui_handlers[result - RESERVED_EVENT_RESULT](sender, e)) ? (-1) : 0;
                }
                return result;
            }
            finally
            {
                handle.Free();
            }
        }

        private static int CallEvent(string type, GCHandle handle, EventArgs e)
        {
            type = type.Trim();
            if (e == EventArgs.Empty)
            {
                return CallEvent(type, GCHandle.ToIntPtr(handle));
            }
            if (e is LambdaArgs e2)
            {
                object data = e2.Data;
                if (data == null)
                {
                    return CallEvent(type, GCHandle.ToIntPtr(handle));
                }
                if (data is string s)
                {
                    return CallEvent(type, s, GCHandle.ToIntPtr(handle));
                }
                if (data is Dictionary<string, object> dic)
                {
                    string json = JSON.Stringify(dic);
                    return CallEvent(type, json, GCHandle.ToIntPtr(handle));
                }
                if (data is Array array)
                {
                    return CallEvent(type, array, GCHandle.ToIntPtr(handle));
                }
                Log.Report(new Message
                {
                    Severity = Severity.FATAL_ERROR,
                    Text = "事件传递的数据类型不支持"
                });
                return -1;
            }
            return CallEvent(type, GCHandle.ToIntPtr(handle));
        }

        private static T? GetObjectFromAddress<T>(IntPtr addr)
        {
            return (T)GCHandle.FromIntPtr(addr).Target;
        }

        private static int? UICallback(int index, string? json, IntPtr pSender)
        {
            if (index >= RESERVED_EVENT_RESULT)
            {
                LambdaHandler lambdaHandler = ui_handlers[index - RESERVED_EVENT_RESULT];
                Dictionary<string, object> eventObject = ((json == null) ? null : ((Dictionary<string, object>)JSON.Parse(json)));
                LambdaArgs e = new LambdaArgs
                {
                    Data = eventObject
                };
                object obj = null;
                if (pSender != IntPtr.Zero)
                {
                    obj = GetObjectFromAddress<object>(pSender);
                }
                return (!lambdaHandler(obj ?? "Unknown", e)) ? (-1) : 0;
            }
            return null;
        }

        [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
        public static extern void CopyMemory(IntPtr Destination, IntPtr Source, uint Length);

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int InitialFrame(int index, int index2, IntPtr buff, int rows, int cols, int type)
        {
            PixelFormat format = type switch
            {
                1 => PixelFormats.Gray8,
                3 => PixelFormats.Bgr24,
                4 => PixelFormats.Bgr32,
                _ => PixelFormats.Default,
            };

            Application.Current.Dispatcher.Invoke(delegate
            {

                WriteableBitmap writeableBitmap = new WriteableBitmap(cols, rows, 96.0, 96.0, format, null);
                CopyMemory(writeableBitmap.BackBuffer, buff, (uint)(cols * rows * type));
                writeableBitmap.Lock();
                writeableBitmap.AddDirtyRect(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
                writeableBitmap.Unlock();
                Image image = GetImage(index, index2, initial: true);
                if (image != null)
                {
                    image.Source = writeableBitmap;
                    if (index2 == 0)
                    {
                        Views[index].State = ViewState.RUNING;
                    }
                    else
                    {
                        //Views[index2].State = ViewState.RUNING;
                    }
                }
            });
            return 2;
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int UpdateFrame(int index, int index2, IntPtr buffer, uint len, int stride)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                if (GetImage(index, index2, initial: false)?.Source is WriteableBitmap writeableBitmap)
                {
                    Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap.Width, (int)writeableBitmap.Height);
                    writeableBitmap.WritePixels(sourceRect, buffer, (int)len, stride);
                    fps.Inc();
                }
            });
            if (index2 == 0)
            {
                return (int)(Views[index]?.State ?? ((ViewState)(-1)));
            }
            else
            {
                return 2;
            }
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static void CloseImageView(int index)
        {
            Application.Current.Dispatcher.Invoke(delegate
            {
                ViewGrid.CloseVieW(index);
            });
        }

        private static Image? GetImage(int index, int index2, bool initial)
        {
            if (index2 == 0)
            {
                Image image = Views[index]?.Image;
                if (image == null && (initial || ClosingViewIndex.IndexOf(index) == -1))
                {
                    image = ViewGrid.GetIdleOrNewView(index)?.Image;
                }
                return image;

            }
            else
            {
                int i = -index2 - 1;
                if (RegisterImageViews.Count > i)
                {
                    View view2 = RegisterImageViews[-index2 - 1];
                    return view2.Image;
                }
                return null;
            }
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private static int GetArraySize(nint p)
        {
            return T0.GetArraySize(p);
        }

        [DllImport("lib\\common.dll")]
        public unsafe static extern char* GetCppSizeInfo(delegate* unmanaged[Cdecl]<sbyte*, void> fn);

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static void SetCppSize(sbyte* p)
        {
            string[] array = new string(p).Split(',');
            for (int j = 0; j < array.Length; j++)
            {
                string[] tokens = array[j].Split(':');
                for (int i = 0; i < tokens.Length / 2; i += 2)
                {
                    TypesInterop.SetCppSize(tokens[i], int.Parse(tokens[i + 1]));
                }
            }
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static void StartService(sbyte* serviceName)
        {
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static void StopService(sbyte* serviceName)
        {
        }

        [DllImport("lib\\common.dll", EntryPoint = "ApplicationExit")]
        public static extern void Exit();

        public static void AppClose()
        {
            foreach (Lib lib in FunctionExecutor.Solution.Libs)
            {
                NativeLibrary.Free(lib.Addr);
            }
            StreamWriter writer = FunctionExecutor.Solution.Writer;
            if (writer != null)
            {
                try
                {
                    writer.Flush();
                    writer.Close();
                }
                catch
                {

                }

            }
            IScheduler scheduler = FunctionExecutor.Solution.Scheduler;
            if (scheduler != null)
            {
                scheduler.Shutdown();
            }
            Exit();
        }



        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static IntPtr Schedule(sbyte* cron, int times, nint callback)
        {
            return AddSchedule(JobBuilder.Create<FunctionJob1>().Build(), cron, times, "callback", callback);
        }
        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static IntPtr Schedule2(sbyte* cron, int times, int callback)
        {
            return AddSchedule(JobBuilder.Create<FunctionJob2>().Build(), cron, times, "id", callback);
        }

        private unsafe static IntPtr AddSchedule(IJobDetail job, sbyte* cron, int times, string kinds, object callback)
        {

            job.JobDataMap.Add(kinds, callback);

            TriggerBuilder triggerBuilder = TriggerBuilder.Create();
            ITrigger trigger = TriggerBuilder.Create().StartNow().WithCronSchedule(new string(cron)).Build();
            Scheduler!.ScheduleJob(job, trigger);

            return Marshal.StringToHGlobalAnsi(trigger.Key.Name);
        }


        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static IntPtr Delay(int seconds, int times, nint callback)
        {
            if (times != 1)
            {
                return AddSchedule1(JobBuilder.Create<FunctionJob1>().Build(), seconds, times, "callback", callback);

            }
            else
            {
                FunctionJob1.Dealy(seconds * 1000, callback);
                return IntPtr.Zero;
            }

        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static IntPtr Delay2(int seconds, int times, int callback)
        {
            if (times != 1)
            {
                return AddSchedule1(JobBuilder.Create<FunctionJob1>().Build(), seconds, times, "id", callback);
            }
            else
            {
                FunctionJob2.Dealy(seconds * 1000, callback);
                return IntPtr.Zero;
            }
        }

        private unsafe static IntPtr AddSchedule1(IJobDetail job, int seconds, int times, string kinds, object callback)
        {
            job.JobDataMap.Add(kinds, callback);
            TriggerBuilder triggerBuilder = TriggerBuilder.Create();
            ITrigger trigger = TriggerBuilder.Create().StartNow().WithSimpleSchedule(x => x.WithIntervalInSeconds(seconds).WithRepeatCount(times)).Build();
            Scheduler!.ScheduleJob(job, trigger);

            return Marshal.StringToHGlobalAnsi(trigger.Key.Name);
        }

        [UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
        [SuppressGCTransition]
        private unsafe static void StopSchedule(sbyte* scheduleName)
        {
            if (Scheduler != null)
            {
                TriggerKey triggerKey = new TriggerKey(new string(scheduleName));
                Scheduler.UnscheduleJob(triggerKey);
                Marshal.FreeHGlobal((nint)scheduleName);
            }
        }

        [DllImport("lib\\common.dll")]
        public static extern void InvokeCallback(IntPtr callback);

        [DllImport("lib\\common.dll")]
        public static extern void InvokeLambdaCallback(int callback);

    }

}


using LambdaUtils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Controls;

namespace Lambda
{
    public delegate void AddEventHandler(string type, LambdaHandler handler, bool once);
    public delegate int CallEventHandler(string type, object sender, EventArgs e);
    public delegate bool LambdaHandler(object sender, EventArgs e);
    public delegate void LogHandler(Message message);
    public delegate int RegisterImageViewHandler(Image image);
    public delegate void StopRegisteredImageViewHandler(int index);

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


    public class LambdaControl : Control
    {
        public static event LogHandler? LogHandler;

        public static event LogHandler? LogHandler2;

        public static event AddEventHandler? AddEventHandler;

        public static event CallEventHandler? CallEventHandler;

        public static event RegisterImageViewHandler? RegisterImageViewHandler;

        public static event StopRegisteredImageViewHandler? StopRegisteredImageViewHandler;

        private static View[]? Views { get; set; }

        public static void Initialize(LogHandler logHandler, LogHandler logHandler2, AddEventHandler addEventHandler, CallEventHandler callEventHandler, RegisterImageViewHandler registerImageViewHandler, StopRegisteredImageViewHandler stopRegisteredImageViewHandler, View[] views)
        {
            if (logHandler != null)
                LogHandler += logHandler;

            if (logHandler2 != null)
                LogHandler2 += logHandler2;

            if (addEventHandler != null)
                AddEventHandler += addEventHandler;

            if (callEventHandler != null)
                CallEventHandler += callEventHandler;

            if (registerImageViewHandler != null)
                RegisterImageViewHandler+= registerImageViewHandler;

            if (stopRegisteredImageViewHandler != null)
                StopRegisteredImageViewHandler += stopRegisteredImageViewHandler;
            if (views != null)
                Views = views;

        }

        public static void Log(Message message)
        {
            LogHandler?.Invoke(message);
        }

        public static void Log2(Message message)
        {
            LogHandler2?.Invoke(message);
        }


        public static async void Dispatch(string type, Dictionary<string, object>? json)
        {
            string type2 = type;
            Dictionary<string, object> json2 = json;
            await Task.Run(() => CallEventHandler?.Invoke(type2, null, new LambdaArgs
            {
                Data = json2
            }));
        }
        public void Dispatch(string type, Dictionary<string, object>? json, int millis)
        {
            AddEventTimer(type, millis, delegate
            {
                lock (_locker) { timers.Remove(type); }
                CallEventHandler?.Invoke(type, this, new LambdaArgs
                {
                    Data = json
                });
            });
        }


        public void Trigger(string type, string? json)
        {
            CallEventHandler?.Invoke(type, this, new LambdaArgs() { Data = json });
        }

        public async void Dispatch(string type, string? json)
        {
            string type2 = type;
            string json2 = json;
            await Task.Run(() => CallEventHandler?.Invoke(type2, this, new LambdaArgs
            {
                Data = json2
            }));
        }


        public void Dispatch(string type, string? json, int millis)
        {
            AddEventTimer(type, millis, delegate
            {
                lock (_locker) { timers.Remove(type); }
                CallEventHandler?.Invoke(type, this, new LambdaArgs
                {
                    Data = json
                });
            });
        }



        public void Trigger(string type, EventArgs e)
        {
            CallEventHandler?.Invoke(type, this, e);
        }

        public async void Dispatch(string type, EventArgs e)
        {
            string type2 = type;
            EventArgs e2 = e;
            await Task.Run(() => CallEventHandler?.Invoke(type2, this, e2));
        }
        public void Dispatch(string type, EventArgs e, int millis)
        {

            AddEventTimer(type, millis, delegate
            {
                lock (_locker) { timers.Remove(type); }
                CallEventHandler?.Invoke(type, this, e);
            });
        }


        /// <summary>
        /// 字典传参
        /// </summary>
        public static void Trigger(string type, object sender, Dictionary<string, object>? json)
        {
            if (json != null)
            {
                Log(new Message { Text = type + JSON.Stringify(json) });
            }
            else
            {
                Log(new Message { Severity = Severity.INFO, Text = type });
            }
            CallEventHandler?.Invoke(type, sender, new LambdaArgs
            {
                Data = json
            });
        }
        /// <summary>
        /// 数组传参
        /// </summary>
        public static void Trigger(string type, object sender, Array? array)
        {
            Log(new Message { Severity = Severity.INFO, Text = type  });
            CallEventHandler?.Invoke(type, sender, new LambdaArgs
            {
                Data = array
            });
        }
        private static readonly object _locker = new();

        public static void Dispatch(string type, object sender, Array? array, int millis)
        {
            AddEventTimer(type, millis, delegate
            {
                lock (_locker) {  timers.Remove(type);  }
                Trigger(type, sender, array);
            });
        }



        public static async void Dispatch(string type, object sender, Dictionary<string, object>? json)
        {
            await Task.Run(() => CallEventHandler?.Invoke(type, sender, new LambdaArgs
            {
                Data = json
            }));
        }

        public static void Dispatch(string type, object sender, Dictionary<string, object>? json, int millis)
        {
            AddEventTimer(type, millis, delegate
            {
                lock (_locker) { timers.Remove(type); }
                Trigger(type, sender, json);
            });
        }

        public static void Trigger(string type, object sender, string? json)
        {
            Log(new Message { Severity = Severity.INFO, Text = type + json });
            CallEventHandler?.Invoke(type, sender, new LambdaArgs
            {
                Data = json
            });


        }

        public static async void Dispatch(string type, object sender, string? json)
        {
            await Task.Run(() => CallEventHandler?.Invoke(type, sender, new LambdaArgs
            {
                Data = json
            }));
        }

        public static void Dispatch(string type, object sender, string? json, int millis)
        {
            AddEventTimer(type, millis, delegate
            {
                timers.Remove(type);
                Trigger(type, sender, json);
            });
        }
        public static void Trigger(string type, object sender, EventArgs e)
        {
            Log(new Message { Severity = Severity.INFO, Text = type  });
            CallEventHandler?.Invoke(type, sender, e);
        }

        public  async void Dispatch(string type, object sender, EventArgs e)
        {
            await Task.Run(() => CallEventHandler?.Invoke(type, sender, e));
        }
        public static void Dispatch(string type, object sender, EventArgs e, int millis)
        {
            AddEventTimer(type, millis, delegate
            {
                lock (_locker) { timers.Remove(type); }
                Trigger(type, sender, e);
            });
        }
        public static void AddLambdaEventHandler(string type, LambdaHandler handler, bool once)
        {
            AddEventHandler?.Invoke(type, handler, once);
        }

        private static Dictionary<string, Timer> timers = new Dictionary<string, Timer>();
        //延时触发实现
        private static void AddEventTimer(string type, int millis, ElapsedEventHandler callback)
        {
            if (timers.TryGetValue(type, out var value))
            {
                value.Enabled = false;
                timers.Remove(type);
            }
            Timer timer = new Timer(millis);
            timer.Elapsed += callback;
            timer.AutoReset = false;
            timer.Enabled = true;
            timer.Start();
            timers.Add(type, timer);
        }




        public static View GetImageView(int index)
        {
            if (Views == null)
            {
                throw new Exception("error!");
            }
            return Views[index];
        }

        public static int RegisterImageView(Image image)
        {
            return RegisterImageViewHandler?.Invoke(image) ?? 0;
        }
        public static void StopRegisteredImageView(int index)
        {
            StopRegisteredImageViewHandler?.Invoke(index);
        }
    }

}


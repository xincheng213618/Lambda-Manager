using System;
using System.Collections.Generic;
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
using LambdaManager.Properties;
using LambdaManager.Utils;
using Swifter.Json;

namespace LambdaManager.Core;

internal class Common
{
	private static readonly FPSCounter fps = new FPSCounter(((MainWindow)Application.Current.MainWindow).cameraState);

	private static readonly int RESERVED_EVENT_RESULT = 2147400000;

	private static readonly List<string> events = new List<string>();

	private static readonly List<ExecInfo> callbacks = new List<ExecInfo>();

	private static readonly List<LambdaHandler> ui_handlers = new List<LambdaHandler>();

	private static View[] Views { get; } = ((MainWindow)Application.Current.MainWindow).Views;


	internal unsafe static void Init()
	{
        SetMessageHandler1((delegate* unmanaged[Cdecl]<int, sbyte*, void>)(&AddMessage1));
        SetMessageHandler2((delegate* unmanaged[Cdecl]<int, char*, void>)(&AddMessage2));
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, int>)(&CallBack1), 0);
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack2), 2);
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack3), 1);
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack4), 3);
		SetGetArraySizeHandler((delegate* unmanaged[Cdecl]<nint, int>)(&GetArraySize));
        GetCppSizeInfo((delegate* unmanaged[Cdecl]<sbyte*, void>)(&SetCppSize));
        LambdaControl.LogHandler = new LogHandler(App.Report);
		LambdaControl.AddEventHandler = new AddEventHandler(AddEventHandler);
		LambdaControl.CallEventHandler = new CallEventHandler(CallEvent);
        SetImageInitialHandler((delegate* unmanaged[Cdecl]<int, nint, int, int, int, int>)(&InitialFrame));
        SetImageHandler((delegate* unmanaged[Cdecl]<int, nint, uint, int, int>)&UpdateFrame);
    }

	[DllImport("lib\\common.dll")]
	public unsafe static extern void SetMessageHandler1(delegate* unmanaged[Cdecl]<int, sbyte*, void> pMessageHandler);

	[UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
	[SuppressGCTransition]
	private unsafe static void AddMessage1(int severity, sbyte* message)
	{
		App.Report2(new Message
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
		App.Report2(new Message
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

	[DllImport("lib\\common.dll")]
	public static extern void SetRoutineHandler(nint pRoutineHandler, int argType);

	private static ExecInfo Clone(ExecInfo info)
	{
		return new ExecInfo
		{
			Routine = info.Routine
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
	private static int CallBack2(int index, nint pEventData, nint sender)
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
			json = new string((sbyte*)pEventData);
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
			Dictionary<string, object> eventObject = JsonFormatter.DeserializeObject<Dictionary<string, object>>(json);
			info.RoutineArguments = PrepareArguments(info.Routine, index, eventObject);
		}
		return FunctionExecutor.Evaluate(info);
	}

	private static List<object?>? PrepareArguments(Routine routine, int index, Dictionary<string, object> eventObject)
	{
		Dictionary<string, int> dataMap = App.GetResolvedEvents()?[events[index]].GetEventMap(routine);
		if (dataMap == null)
		{
			return null;
		}
		List<object> args = new List<object>();
		foreach (KeyValuePair<string, int> pair in dataMap)
		{
			object value = eventObject[pair.Key];
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

	public unsafe static void AddEventHandler(string type, ArgumentType argType, Routine? routine, bool once)
	{
		if (routine != null)
		{
			int index = callbacks.Count;
			callbacks.Add(new ExecInfo
			{
				Routine = routine
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
				string json = JsonFormatter.SerializeObject(dic);
				return CallEvent(type, json, GCHandle.ToIntPtr(handle));
			}
			App.Report(new Message
			{
				Severity = Severity.FATAL_ERROR,
				Text = Resources.EventDataNotSupport
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
			Dictionary<string, object> eventObject = ((json == null) ? null : JsonFormatter.DeserializeObject<Dictionary<string, object>>(json));
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

	[DllImport("lib\\common.dll")]
	public unsafe static extern void SetImageInitialHandler(delegate* unmanaged[Cdecl]<int, nint, int, int, int, int> InitFrame);

	[DllImport("lib\\common.dll")]
	public unsafe static extern void SetImageHandler(delegate* unmanaged[Cdecl]<int, nint, uint, int, int> ShowFrame);

	[DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
	public static extern void CopyMemory(IntPtr Destination, IntPtr Source, uint Length);

	[UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
	[SuppressGCTransition]
	private static int InitialFrame(int index, IntPtr buff, int rows, int cols, int type)
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
			MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
			Image image = GetImage(index);
			if (image != null)
			{
				image.Source = writeableBitmap;
				Views[index].State = ViewState.RUNING;
				if (index == 0)
				{
					string text = Application.Current.Resources["CameraRunning"] as string;
					mainWindow.cameraState.Text = text;
				}
				FunctionExecutor.Solution.Writer?.Flush();
			}
		});
		return 2;
	}

	[UnmanagedCallersOnly(CallConvs = new System.Type[] { typeof(CallConvCdecl) })]
	[SuppressGCTransition]
	private static int UpdateFrame(int index, IntPtr buffer, uint len, int stride)
	{
		Application.Current.Dispatcher.Invoke(delegate
		{
			if (GetImage(index)?.Source is WriteableBitmap writeableBitmap)
			{
				Int32Rect sourceRect = new Int32Rect(0, 0, (int)writeableBitmap.Width, (int)writeableBitmap.Height);
				writeableBitmap.WritePixels(sourceRect, buffer, (int)len, stride);
				if (index == 0)
				{
					fps.Inc();
				}
			}
		});
		return (int)(Views[index]?.State ?? ((ViewState)(-1)));
	}

	private static Image? GetImage(int index)
	{
		MainWindow main = (MainWindow)Application.Current.MainWindow;
		if (main == null)
		{
			return null;
		}
		Image image = main.Views[index]?.Image;
		if (image == null)
		{
			image = ViewGrid.GetIdleOrNewView(index)?.Image;
		}
		return image;
	}

	[DllImport("lib\\common.dll")]
	public unsafe static extern void SetGetArraySizeHandler(delegate* unmanaged[Cdecl]<nint, int> pGetArraySizeHandler);

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
}

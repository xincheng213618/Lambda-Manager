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
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, int>)(&CallBack5), 4);
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, nint, int>)(&CallBack6), 5);
		SetRoutineHandler((nint)(delegate* unmanaged[Cdecl]<int, nint, nint, nint, nint, nint, int>)(&CallBack7), 6);
		SetGetArraySizeHandler((delegate* unmanaged[Cdecl]<nint, int>)(&GetArraySize));
		GetCppSizeInfo((delegate* unmanaged[Cdecl]<sbyte*, void>)(&SetCppSize));
		LambdaControl.LogHandler = new LogHandler(App.Report);
		LambdaControl.LogHandler2 = new LogHandler(App.Report2);
		LambdaControl.AddEventHandler = new AddEventHandler(AddEventHandler);
		LambdaControl.CallEventHandler = new CallEventHandler(CallEvent);
		SetImageInitialHandler((delegate* unmanaged[Cdecl]<int, nint, int, int, int, int>)(&InitialFrame));
		SetImageHandler((delegate* unmanaged[Cdecl]<int, nint, uint, int, int>)(&UpdateFrame));
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
		fixed (sbyte* type2 = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
		{
			return RaiseEvent(type2, 0, IntPtr.Zero, sender);
		}
	}

	public unsafe static int CallEvent(string type, string json, nint sender)
	{
		sbyte[] obj = (sbyte[])(object)Encoding.UTF8.GetBytes(type);
		sbyte[] array = (sbyte[])(object)Encoding.UTF8.GetBytes(json);
		fixed (sbyte* type2 = obj)
		{
			fixed (sbyte* eventObject = array)
			{
				return RaiseEvent(type2, 1, (nint)eventObject, sender);
			}
		}
	}

	public unsafe static int CallEvent(string type, nint handle, nint sender)
	{
		fixed (sbyte* type2 = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
		{
			return RaiseEvent(type2, 1, handle, sender);
		}
	}

	public unsafe static int CallEvent(string type, List<object?>? arguments, nint sender)
	{
		if (arguments == null || arguments!.Count == 0)
		{
			return CallEvent(type, sender);
		}
		int count = arguments!.Count;
		fixed (sbyte* type2 = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
		{
			switch (count)
			{
			case 3:
				break;
			case 1:
			{
				object obj = arguments?[0];
				nint eventObject = ((obj == null) ? IntPtr.Zero : ((IntPtr)obj));
				return RaiseEvent(type2, 4, eventObject, sender);
			}
			case 2:
			case 4:
			{
				IntPtr[] array = List2Array(arguments);
				ArgumentType argType = ((count == 2) ? ArgumentType.POINTER2 : ArgumentType.POINTER4);
				return RaiseEvent(type2, (int)argType, array[0], sender);
			}
			}
		}
		return -1;
	}

	private static nint[] List2Array(List<object?> arguments)
	{
		int count = arguments.Count;
		IntPtr[] array = new IntPtr[count];
		for (int i = 0; i < count; i++)
		{
			object obj = arguments[i];
			IntPtr intPtr = (array[i] = ((obj == null) ? IntPtr.Zero : ((IntPtr)obj)));
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
		int? num = UICallback(index, null, sender);
		if (num.HasValue)
		{
			return num.Value;
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
		string text = null;
		if (pEventData != IntPtr.Zero)
		{
			text = new string((sbyte*)pEventData);
		}
		int? num = UICallback(index, text, sender);
		if (num.HasValue)
		{
			return num.Value;
		}
		ExecInfo info = callbacks[index];
		info = Clone(info);
		if (text != null)
		{
			Dictionary<string, object> eventObject = JsonFormatter.DeserializeObject<Dictionary<string, object>>(text);
			info.RoutineArguments = PrepareArguments(info.Routine, index, eventObject);
		}
		return FunctionExecutor.Evaluate(info);
	}

	private static List<object?>? PrepareArguments(Routine routine, int index, Dictionary<string, object> eventObject)
	{
		Dictionary<string, int> dictionary = App.GetResolvedEvents()?[events[index]].GetEventMap(routine);
		if (dictionary == null)
		{
			return null;
		}
		List<object> list = new List<object>();
		foreach (KeyValuePair<string, int> item in dictionary)
		{
			eventObject.TryGetValue(item.Key, out var value);
			CollectionUtils.Insert(list, item.Value, value);
		}
		return list;
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

	[DllImport("lib\\common.dll")]
	public unsafe static extern void RegisterFunctionEvent(sbyte* type, IntPtr fn1, ArgumentType handlerType, int once);

	public unsafe static void AddEventHandler(string type, ArgumentType argType, IntPtr callback, bool once)
	{
		if (!(callback == IntPtr.Zero))
		{
			fixed (sbyte* type2 = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
			{
				RegisterFunctionEvent(type2, callback, argType, once ? 1 : 0);
			}
		}
	}

	[DllImport("lib\\common.dll")]
	public unsafe static extern void RegisterRoutineEvent(sbyte* type, int rotineId, ArgumentType handlerType, int once);

	public unsafe static void AddEventHandler(string type, ArgumentType argType, Routine? routine, bool once, int group)
	{
		if (routine != null)
		{
			int count = callbacks.Count;
			callbacks.Add(new ExecInfo
			{
				Routine = routine,
				Group = group
			});
			events.Add(type);
			fixed (sbyte* type2 = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
			{
				RegisterRoutineEvent(type2, count, argType, once ? 1 : 0);
			}
		}
	}

	public unsafe static void AddEventHandler(string type, LambdaHandler handler, bool once)
	{
		int count = ui_handlers.Count;
		ui_handlers.Add(handler);
		fixed (sbyte* type2 = (sbyte[])(object)Encoding.UTF8.GetBytes(type))
		{
			RegisterRoutineEvent(type2, RESERVED_EVENT_RESULT + count, ArgumentType.JSON_STRING, once ? 1 : 0);
		}
	}

	public static int CallEvent(string type, object sender, EventArgs e)
	{
		GCHandle handle = GCHandle.Alloc(sender);
		try
		{
			int num = CallEvent(type, handle, e);
			if (num >= RESERVED_EVENT_RESULT)
			{
				return (!ui_handlers[num - RESERVED_EVENT_RESULT](sender, e)) ? (-1) : 0;
			}
			return num;
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
		if (e is LambdaArgs lambdaArgs)
		{
			object data = lambdaArgs.Data;
			if (data == null)
			{
				return CallEvent(type, GCHandle.ToIntPtr(handle));
			}
			if (data is string json)
			{
				return CallEvent(type, json, GCHandle.ToIntPtr(handle));
			}
			if (data is Dictionary<string, object> value)
			{
				string json2 = JsonFormatter.SerializeObject(value);
				return CallEvent(type, json2, GCHandle.ToIntPtr(handle));
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
			Dictionary<string, object> data = ((json == null) ? null : JsonFormatter.DeserializeObject<Dictionary<string, object>>(json));
			LambdaArgs e = new LambdaArgs
			{
				Data = data
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
		MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
		if (mainWindow == null)
		{
			return null;
		}
		Image image = mainWindow.Views[index]?.Image;
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
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(':');
			for (int j = 0; j < array2.Length / 2; j += 2)
			{
				TypesInterop.SetCppSize(array2[j], int.Parse(array2[j + 1]));
			}
		}
	}

	[DllImport("lib\\common.dll", EntryPoint = "ApplicationExit")]
	public static extern void Exit();
}

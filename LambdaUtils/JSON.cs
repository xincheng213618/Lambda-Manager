using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace LambdaUtils;

public class JSON
{
	public static object? Parse(string json)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(json);
		Utf8JsonReader utf8JsonReader = new Utf8JsonReader((ReadOnlySpan<byte>)bytes, isFinalBlock: true, default(JsonReaderState));
		Stack<object> stack = new Stack<object>();
		string key = "N/A";
		object result = null;
		while (utf8JsonReader.Read())
		{
			switch (utf8JsonReader.TokenType)
			{
			case JsonTokenType.PropertyName:
				key = utf8JsonReader.GetString() ?? "N/A";
				break;
			case JsonTokenType.String:
			{
				string @string = utf8JsonReader.GetString();
				Collect(stack.Peek(), key, @string);
				break;
			}
			case JsonTokenType.Number:
			{
				double value2;
				decimal value3;
				if (utf8JsonReader.TryGetInt32(out var value))
				{
					Collect(stack.Peek(), key, value);
				}
				else if (utf8JsonReader.TryGetDouble(out value2))
				{
					Collect(stack.Peek(), key, value2);
				}
				else if (utf8JsonReader.TryGetDecimal(out value3))
				{
					Collect(stack.Peek(), key, value3);
				}
				break;
			}
			case JsonTokenType.True:
			case JsonTokenType.False:
				Collect(stack.Peek(), key, utf8JsonReader.GetBoolean());
				break;
			case JsonTokenType.StartArray:
			{
				List<object> list = new List<object>();
				Collect(stack.Peek(), key, list);
				stack.Push(list);
				break;
			}
			case JsonTokenType.StartObject:
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				if (stack.Count > 0)
				{
					Collect(stack.Peek(), key, dictionary);
				}
				stack.Push(dictionary);
				break;
			}
			case JsonTokenType.EndObject:
			case JsonTokenType.EndArray:
				result = stack.Pop();
				break;
			}
		}
		return result;
	}

	public static string Stringify(object value)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using (Utf8JsonWriter writer = new Utf8JsonWriter((Stream)memoryStream, default(JsonWriterOptions)))
		{
			Format(writer, null, value);
		}
		return Encoding.UTF8.GetString(memoryStream.ToArray());
	}

	private static void Format(Utf8JsonWriter writer, string? key, object value)
	{
		if (value is string value2)
		{
			if (key == null)
			{
				writer.WriteStringValue(value2);
			}
			else
			{
				writer.WriteString(key, value2);
			}
			return;
		}
		if (value is int value3)
		{
			if (key == null)
			{
				writer.WriteNumberValue(value3);
			}
			else
			{
				writer.WriteNumber(key, value3);
			}
			return;
		}
		if (value is double num)
		{
			string text = num.ToString("0.######");
			if (!text.Contains('.'))
			{
				text += ".0";
			}
			if (key != null)
			{
				writer.WritePropertyName(key);
			}
			writer.WriteRawValue(text);
			return;
		}
		if (value is bool value4)
		{
			if (key == null)
			{
				writer.WriteBooleanValue(value4);
			}
			else
			{
				writer.WriteBoolean(key, value4);
			}
			return;
		}
		if (value is Dictionary<string, object> dictionary)
		{
			if (key != null)
			{
				writer.WritePropertyName(key);
			}
			writer.WriteStartObject();
			foreach (KeyValuePair<string, object> item in dictionary)
			{
				Format(writer, item.Key, item.Value);
			}
			writer.WriteEndObject();
			return;
		}
		if (value is List<object> list)
		{
			if (key != null)
			{
				writer.WritePropertyName(key);
			}
			writer.WriteStartArray();
			foreach (object item2 in list)
			{
				Format(writer, null, item2);
			}
			writer.WriteEndArray();
			return;
		}
		if (value is float num2)
		{
			string text2 = num2.ToString();
			if (!text2.Contains('.'))
			{
				text2 += ".0";
			}
			if (key != null)
			{
				writer.WritePropertyName(key);
			}
			writer.WriteRawValue(text2);
			return;
		}
		throw new InvalidOperationException("Stringify error");
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void Collect(object container, string key, object? value)
	{
		if (value == null)
		{
			return;
		}
		if (container is Dictionary<string, object> dictionary)
		{
			dictionary.Add(key, value);
			return;
		}
		if (container is List<object> list)
		{
			list.Add(value);
			return;
		}
		throw new Exception("JSON format error");
	}
}

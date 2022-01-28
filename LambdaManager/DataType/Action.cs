using System.Collections.Generic;

namespace LambdaManager.DataType;

internal class Action
{
	internal Procedure? Parent { get; set; }

	internal string? Name { get; set; }

	internal int Times { get; set; } = 1;


	internal List<string>? Raise { get; set; }

	internal List<string>? Key { get; set; }

	internal List<string>? Arg { get; set; }

	internal string? Value { get; set; }

	internal string? Component { get; set; }

	internal List<Input>? Inputs { get; set; }

	internal List<Output>? Outputs { get; set; }

	internal string? Aysnc { get; set; }

	internal Function? Function { get; set; }

	internal int Index { get; set; }

	internal IEnumerable<IO> IoRange
	{
		get
		{
			if (Inputs != null)
			{
				foreach (Input item in Inputs!)
				{
					yield return item;
				}
			}
			if (Outputs == null)
			{
				yield break;
			}
			foreach (Output item2 in Outputs!)
			{
				yield return item2;
			}
		}
	}

	internal IEnumerable<IO> IoReverseRange
	{
		get
		{
			if (Outputs != null)
			{
				for (int j = Outputs!.Count - 1; j >= 0; j--)
				{
					yield return Outputs![j];
				}
			}
			if (Inputs != null)
			{
				for (int j = Inputs!.Count - 1; j >= 0; j--)
				{
					yield return Inputs![j];
				}
			}
		}
	}

	internal IO? GetIO(int index)
	{
		if (Inputs == null)
		{
			return Outputs?[index];
		}
		if (Outputs == null)
		{
			return Inputs![index];
		}
		if (index < Inputs!.Count)
		{
			return Inputs![index];
		}
		return Outputs![index - Inputs!.Count];
	}

	internal bool IsInputIO(int index)
	{
		return GetIO(index) is Input;
	}

	internal int GetArgsCount()
	{
		return (Inputs?.Count ?? 0) + (Outputs?.Count ?? 0);
	}

	internal Dictionary<int, IO> GetArgIndice(List<string> keys)
	{
		Dictionary<int, IO> dictionary = new Dictionary<int, IO>();
		int num = 0;
		foreach (IO item in IoRange)
		{
			string name = item.Name;
			if (name != null && keys.Contains(name))
			{
				dictionary.Add(num, item);
			}
			num++;
		}
		return dictionary;
	}

	internal bool HasArgName(string name)
	{
		foreach (IO item in IoRange)
		{
			if (item.Name == name)
			{
				return true;
			}
		}
		return false;
	}

	internal bool HasPreviousArgName(string name)
	{
		List<Action> list = Parent?.Actions;
		if (list == null)
		{
			return false;
		}
		for (int num = Index - 1; num >= 0; num--)
		{
			if (list[num].HasArgName(name))
			{
				return true;
			}
		}
		return false;
	}

	internal void AddInput(Input? input)
	{
		if (input != null)
		{
			if (Inputs == null)
			{
				Inputs = new List<Input>();
			}
			Inputs!.Add(input);
		}
	}

	internal void AddOutput(Output? output)
	{
		if (output != null)
		{
			if (Outputs == null)
			{
				Outputs = new List<Output>();
			}
			Outputs!.Add(output);
		}
	}

	internal void AddIO(IO? io)
	{
		if (io != null)
		{
			if (io is Input input)
			{
				AddInput(input);
			}
			else
			{
				AddOutput(io as Output);
			}
		}
	}

	internal string GetSigName(Component? component)
	{
		string text = component?.GetLibShortName();
		int num = (Inputs?.Count ?? 0) + (Outputs?.Count ?? 0);
		return (text ?? "N/A") + "::" + (Name ?? "N/A") + "@@" + num;
	}

	public override string ToString()
	{
		if (Name == null)
		{
			return "null";
		}
		string text = "int " + Name + "(";
		int num = 0;
		if (Inputs != null)
		{
			foreach (Input item in Inputs!)
			{
				text += "IN ";
				text = text + (item.Type ?? "string") + " ";
				text += item.Name;
				if (item.Value != null)
				{
					text = text + "=\"" + item.Value + "\"";
				}
				text += ", ";
				num++;
			}
		}
		if (Outputs != null)
		{
			foreach (Output item2 in Outputs!)
			{
				text += "OUT ";
				text = text + (item2.Type ?? "string") + " ";
				text += item2.Name;
				if (item2.Value != null)
				{
					text = text + "=\"" + item2.Value + "\"";
				}
				text += ", ";
				num++;
			}
		}
		if (num > 0)
		{
			text = text[0..^2];
		}
		return text + ")";
	}
}

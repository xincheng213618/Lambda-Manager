using System.Collections.Generic;

namespace LambdaManager.DataType;

internal class Action
{
	internal Procedure? Parent { get; set; }

	internal string? Name { get; set; }

	internal int Times { get; set; } = 1;


	internal List<string>? Raise { get; set; }

	internal List<string>? Key { get; set; }

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
		Dictionary<int, IO> list = new Dictionary<int, IO>();
		int i = 0;
		foreach (IO io in IoRange)
		{
			string name = io.Name;
			if (name != null && keys.Contains(name))
			{
				list.Add(i, io);
			}
			i++;
		}
		return list;
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
		List<Action> actions = Parent?.Actions;
		if (actions == null)
		{
			return false;
		}
		for (int i = Index - 1; i >= 0; i--)
		{
			if (actions[i].HasArgName(name))
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

	internal string GetSigName(Component? component)
	{
		string libShortName = component?.GetLibShortName();
		int count = (Inputs?.Count ?? 0) + (Outputs?.Count ?? 0);
		return (libShortName ?? "N/A") + "::" + (Name ?? "N/A") + "@@" + count;
	}

	public override string ToString()
	{
		if (Name == null)
		{
			return "null";
		}
		string signature = "int " + Name + "(";
		int count = 0;
		if (Inputs != null)
		{
			foreach (Input input in Inputs!)
			{
				signature += "IN ";
				signature = signature + (input.Type ?? "string") + " ";
				signature += input.Name;
				if (input.Value != null)
				{
					signature = signature + "=\"" + input.Value + "\"";
				}
				signature += ", ";
				count++;
			}
		}
		if (Outputs != null)
		{
			foreach (Output output in Outputs!)
			{
				signature += "OUT ";
				signature = signature + (output.Type ?? "string") + " ";
				signature += output.Name;
				if (output.Value != null)
				{
					signature = signature + "=\"" + output.Value + "\"";
				}
				signature += ", ";
				count++;
			}
		}
		if (count > 0)
		{
			signature = signature[0..^2];
		}
		return signature + ")";
	}
}

using System.Collections.Generic;

namespace LambdaManager.DataType
{
    public class Input : IO
    {
        public string? For { get; set; }
    }

    public class Action
    {
        public Procedure? Parent { get; set; }

        public string? Name { get; set; }

        public int Times { get; set; } = 1;


        public List<string>? Raise { get; set; }

        public List<string>? Key { get; set; }

        public List<string>? Arg { get; set; }

        public string? Value { get; set; }

        public string? Component { get; set; }

        public List<Input>? Inputs { get; set; }

        public List<Output>? Outputs { get; set; }

        public string? Aysnc { get; set; }

        public Function? Function { get; set; }

        public int Index { get; set; }

        public IEnumerable<IO> IoRange
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

        public IEnumerable<IO> IoReverseRange
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

        public IO? GetIO(int index)
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

        public bool IsInputIO(int index)
        {
            return GetIO(index) is Input;
        }

        public int GetArgsCount()
        {
            return (Inputs?.Count ?? 0) + (Outputs?.Count ?? 0);
        }

        public Dictionary<int, IO> GetArgIndice(List<string> keys)
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

        public bool HasArgName(string name)
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

        public bool HasPreviousArgName(string name)
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

        public void AddInput(Input? input)
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

        public void AddOutput(Output? output)
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

        public void AddIO(IO? io)
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

        public string GetSigName(Component? component)
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
                string text = signature;
                signature = text.Substring(0, text.Length - 2);
            }
            return signature + ")";
        }
    }

}


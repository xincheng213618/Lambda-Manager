using System.Collections.Generic;

namespace LambdaManager.DataType
{
    public class Procedure
    {
        public Component? Parent { get; set; }

        public string? Name { get; set; }

        public string? Icon { get; set; }

        public List<string>? Event { get; set; }

        public List<string>? Key { get; set; }

        public List<string>? Arg { get; set; }

        public string? Timer { get; set; }

        public List<Action>? Actions { get; set; }

        public List<string>? Exports { get; set; }

        public string? Aysnc { get; set; }

        public Routine? Routine { get; set; }

        public bool IsGUIProcedure { get; set; }
    }

}


namespace LambdaManager.DataType
{
    public class VirtualLink : Link
    {
        public Function SourceFunction { get; set; }

        public int TargetGroup { get; set; }

        public VirtualLink(Function srcFunction, int group)
        {
            SourceFunction = srcFunction;
            TargetGroup = group;
        }
    }
}



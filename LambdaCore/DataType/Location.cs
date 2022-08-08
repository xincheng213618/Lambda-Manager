namespace LambdaManager.DataType
{
    public class Location
    {
        public Function Function { get; set; } = new Function();


        public int Index { get; set; }

        public int Group { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Location location))
            {
                return false;
            }
            if (Function == location.Function && Index == location.Index)
            {
                return Group == location.Group;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int hashCode = Function.GetHashCode();
            int hash2 = Index << 16;
            int hash3 = Group.GetHashCode();
            return hashCode ^ (hash2 + hash3);
        }
    }
}



namespace XSolution
{
    public static class BaseObjectExtensions
    {
        /// <summary>
        /// 得到指定数据类型的祖先节点。
        /// </summary>
        public static BaseObject GetAncestor(this BaseObject This,System.Type type)
        {
            if (type == null)
                return null;

            if (type.Equals(This.GetType()))
                return This;
            if (type.IsAssignableFrom(This.GetType()))
                return This;
            if (This.GetType().IsSubclassOf(type))
                return This;

            if (This.Parent == null)
                return null;

            return This.Parent.GetAncestor(type);
        }

        /// <summary>
        /// 得到指定数据类型的祖先节点。
        /// </summary>
        public static T GetAncestor<T>(this BaseObject This) where T : BaseObject
        {
            if (This is T t)
                return t;

            if (This.Parent == null)
                return null;

            return This.Parent.GetAncestor<T>();
        }
    }

}

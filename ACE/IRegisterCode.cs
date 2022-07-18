namespace ACE
{
    /// <summary>
    /// 注册码接口
    /// </summary>
    public interface IRegisterCode
    {
        /// <summary>
        /// 设置注册码
        /// </summary>
        void SetRegisterCode(string Code);

        /// <summary>
        /// 获取注册码
        /// </summary>
        string GetRegisterCode();
    }
}

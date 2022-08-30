using ACE.Global;

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
        public void SetRegisterCode(string registerCode);

        /// <summary>
        /// 获取注册码
        /// </summary>
        string? GetRegisterCode();
    }
}

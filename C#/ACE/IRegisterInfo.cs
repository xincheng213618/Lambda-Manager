using ACE.Global;

namespace ACE
{
    /// <summary>
    /// 获取注册信息
    /// </summary>
    public interface IRegisterInfo
    {

        public void Set(RegisterInfo registerInfo);


        RegisterInfo? Get();
    }
}

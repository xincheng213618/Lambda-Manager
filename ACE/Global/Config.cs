using System;

namespace ACE.Global
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class Config : ViewModelBase
    {
        public RegisterInfo RegisterInfo { get; set; } = new RegisterInfo();
    }
}

using System;
using System.Text.Json.Serialization;

namespace ACE.Global
{
    /// <summary>
    /// 本软件配置文件实体类
    /// </summary>
    [Serializable]
    public class Config : ViewModelBase
    {
        [JsonPropertyName("register-info")]
        public RegisterInfo RegisterInfo { get; set; } = new RegisterInfo();
    }
}

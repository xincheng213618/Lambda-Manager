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
        public string RegisterInfo { get; set; } = string.Empty;
    }
}

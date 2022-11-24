using Global.Common;

namespace Global.SettingUp.Configure
{
    /// <summary>
    /// DLL更新
    /// </summary>
    public class FirmwareUpdate : ViewModelBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public string UpdateTime { get; set; }

        /// <summary>
        /// 更新日大小
        /// </summary>
        public string UpdateSize { get; set; }

        /// <summary>
        /// 更新连接
        /// </summary>
        public string UpdateUrl { get; set; }


    }

}

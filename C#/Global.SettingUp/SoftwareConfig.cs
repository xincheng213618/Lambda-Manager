using Global.SettingUp.Hardware;
using Global.SettingUp.PC;

namespace Global.SettingUp
{
    /// <summary>
    /// 先放这里后面再拆
    /// </summary>
    public static class SoftwareConfig
    {

        /// <summary>
        ///工程配置
        /// </summary>
        public static SolutionSetting SolutionSetting = new SolutionSetting();

        /// <summary>
        /// 硬件配置，在线获取
        /// </summary>
        public static HardwareSetting HardwareSetting = new HardwareSetting(); 

        /// <summary>
        /// 硬件配置参数，读取的
        /// </summary>
        public static HardwareConfig HardwareConfig = new HardwareConfig();

        /// <summary>
        /// 性能配置
        /// </summary>
        public static PerformanceSetting PerformanceSetting = new PerformanceSetting();
    }
}

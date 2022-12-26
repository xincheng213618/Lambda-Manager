using Global.SettingUp.Hardware;
using Global.SettingUp.PC;

namespace Global.SettingUp
{
    /// <summary>
    /// 软件配置
    /// </summary>
    public static class SoftwareConfig
    {
        /// <summary>
        ///工程设置
        /// </summary>
        public static SolutionSetting SolutionSetting = new();


        /// <summary>
        /// 硬件设置，可修改的
        /// </summary>
        public static HardwareSetting HardwareSetting = new(); 

        /// <summary>
        /// 硬件配置，不可修改
        /// </summary>
        public static HardwareConfig HardwareConfig = new();

        /// <summary>
        /// 性能设置
        /// </summary>
        public static PerformanceSetting PerformanceSetting = new();

        public static WindowSetting WindowSetting = new();



        public static LambdaSettingUp LambdaSettingUp = LambdaSettingUp.GetInstance();
    }
}

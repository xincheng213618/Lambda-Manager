namespace Global.SettingUp.Hardware
{
    /// <summary>
    /// 相机状态
    /// </summary>
    public enum CameraStatus
    {
        /// <summary>
        /// 正常连接
        /// </summary>
        Ok,
        /// <summary>
        /// 未连接
        /// </summary>
        DisConnection =-1 ,
    }

    /// <summary>
    /// 位移台状态
    /// </summary>
    public enum StageStatus
    {
        /// <summary>
        /// 正常连接
        /// </summary>
        Ok,
        /// <summary>
        /// 未连接
        /// </summary>
        DisConnection = -1,
    }

    /// <summary>
    /// 灯光状态
    /// </summary>
    public enum LightStatus
    {
        /// <summary>
        /// 正常连接
        /// </summary>
        Ok,
        /// <summary>
        /// 未连接
        /// </summary>
        DisConnection = -1,
    }
}

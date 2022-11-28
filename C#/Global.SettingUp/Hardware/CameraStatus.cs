using System.ComponentModel;

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
    /// 串口状态
    /// </summary>
    public enum SerialPortStatus
    {
        /// <summary>
        /// system error (如空指针、内存访问异常等)
        /// </summary>
        SystemError = -1,
        /// <summary>
        ///  No error occurred 没有错误
        /// </summary>
        [Description("No error occurred 没有错误")]
        NoError = 0,
        /// <summary>
        /// device not found 未找到设备
        /// </summary>
        DeviceNotFoundError,
        /// <summary>
        /// permission error 权限错误
        /// </summary>
        PermissionError,
        /// <summary>
        /// open error 打开串口错误
        /// </summary>
        OpenError,
        /// <summary>
        /// parity error 校验位错误
        /// </summary>
        ParityError,
        FramingError,
        BreakConditionError,
        /// <summary>
        /// write error 写数据错误
        /// </summary>
        WriteError,
        /// <summary>
        ///  read error 读数据错误
        /// </summary>
        ReadError, 
        ResourceError, 
        UnsupportedOperationError,
        /// <summary>
        /// unknown error 未知错误
        /// </summary>
        UnknownError,
        /// <summary>
        /// time out error 超时
        /// </summary>
        TimeoutError,
        /// <summary>
        /// not open serial port error 串口未打开
        /// </summary>
        NotOpenError,
        /// <summary>
        ///  invalid parameter error 无效的参数
        /// </summary>
        InvalidParameterError
    }
}

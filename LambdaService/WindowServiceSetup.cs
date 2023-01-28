using System;
using System.Configuration.Install;
using System.ServiceProcess;

namespace LambdaService
{
    public class WindowServiceSetup
    {
        /// <summary>
        /// 安装服务
        /// </summary>
        /// <param name="serverName"></param>
        public void WindowServiceInstall(string serviceName)
        {
            string[] args = new string[1];
            args[0] = serviceName;
            try
            {
                ManagedInstallerClass.InstallHelper(args);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 卸载服务
        /// </summary>
        /// <param name="serviceName"></param>
        public void WindowServiceUnInstall(string serviceName)
        {
            string[] args = new string[2];
            args[0] = "/u";
            args[1] = serviceName;
            try
            {
                ManagedInstallerClass.InstallHelper(args);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 检查服务是否存在
        /// </summary>
        /// <param name="svcName"></param>
        /// <returns></returns>
        public bool ServiceIsExisted(string svcName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController s in services)
            {
                if (s.ServiceName == svcName)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="serviceName">服务名</param>
        /// <returns>是否启动成功</returns>
        public bool StartService(string serviceName)
        {
            ServiceController sc = new ServiceController(serviceName);

            if (sc.Status != ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);  // 等待执行完成
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <param name="serviceName">服务名</param>
        /// <returns>是否停止服务成功，如果服务启动后不可以停止，则抛异常</returns>
        public bool StopService(string serviceName)
        {
            ServiceController sc = new ServiceController(serviceName);

            if (!sc.CanStop)
            {
                throw new Exception(string.Format("服务:{0}无法停止.", serviceName));
            }

            if (sc.Status != ServiceControllerStatus.Stopped)
            {
                try
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);  // 等待执行完成
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}

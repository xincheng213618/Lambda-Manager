using System;
using System.Collections.ObjectModel;
using LambdaCore;

namespace LambdaManager.Services
{
    /// <summary>
    /// 消息服务接口，用于解耦消息管理
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        /// 消息集合
        /// </summary>
        ObservableCollection<Message> Messages { get; }

        /// <summary>
        /// 消息添加事件
        /// </summary>
        event Action<Message> MessageAdded;

        /// <summary>
        /// 添加消息
        /// </summary>
        /// <param name="message">消息对象</param>
        void AddMessage(Message message);

        /// <summary>
        /// 清空消息
        /// </summary>
        void ClearMessages();

        /// <summary>
        /// 获取消息数量
        /// </summary>
        int MessageCount { get; }
    }
}
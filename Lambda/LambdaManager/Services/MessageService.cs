using System;
using System.Collections.ObjectModel;
using System.Windows;
using LambdaCore;

namespace LambdaManager.Services
{
    /// <summary>
    /// 消息服务实现，集中管理消息通知和分发
    /// </summary>
    public class MessageService : IMessageService
    {
        private static readonly Lazy<MessageService> _instance = new Lazy<MessageService>(() => new MessageService());
        private readonly ObservableCollection<Message> _messages;

        /// <summary>
        /// 单例实例
        /// </summary>
        public static MessageService Instance => _instance.Value;

        /// <summary>
        /// 消息集合
        /// </summary>
        public ObservableCollection<Message> Messages => _messages;

        /// <summary>
        /// 消息添加事件
        /// </summary>
        public event Action<Message> MessageAdded;

        /// <summary>
        /// 消息数量
        /// </summary>
        public int MessageCount => _messages.Count;

        private MessageService()
        {
            _messages = new ObservableCollection<Message>();
        }

        /// <summary>
        /// 添加消息
        /// </summary>
        /// <param name="message">消息对象</param>
        public void AddMessage(Message message)
        {
            if (message == null) return;

            // 确保在UI线程上更新集合
            if (Application.Current?.Dispatcher != null)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    _messages.Add(message);
                    MessageAdded?.Invoke(message);
                });
            }
            else
            {
                _messages.Add(message);
                MessageAdded?.Invoke(message);
            }
        }

        /// <summary>
        /// 清空消息
        /// </summary>
        public void ClearMessages()
        {
            if (Application.Current?.Dispatcher != null)
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    _messages.Clear();
                });
            }
            else
            {
                _messages.Clear();
            }
        }
    }
}
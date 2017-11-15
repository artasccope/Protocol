using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// C/S通信的消息体
    /// </summary>
    public class SocketModel
    {
        /// <summary>
        /// 一级协议 区分消息所属模块(登录、战斗、etc)
        /// </summary>
        public byte type { get; set; }
        /// <summary>
        /// 二级协议 区分消息的区域
        /// </summary>
        public int area { get; set; }
        /// <summary>
        /// 三级协议 命令的具体类型
        /// </summary>
        public int command { get; set; }
        /// <summary>
        /// 消息体
        /// </summary>
        public object message { get; set; }

        public SocketModel() { }

        public SocketModel(byte type, int area, int command, object message)
        {
            this.type = type;
            this.area = area;
            this.command = command;
            this.message = message;
        }

        public T GetMessage<T>()
        {
            return (T)message;
        }

    }
}

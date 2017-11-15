using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// 角色选择协议
    /// </summary>
    public class SelectProtocol
    {
        /// <summary>
        /// 申请进入选择界面
        /// </summary>
        public const int ENTER_CREQ = 0;
        /// <summary>
        /// 回复允许进入
        /// </summary>
        public const int ENTER_SRES = 1;
        /// <summary>
        /// 向除了此玩家之外的玩家群发
        /// </summary>
        public const int ENTER_EXBRO = 2;
        /// <summary>
        /// 申请选择角色
        /// </summary>
        public const int SELECT_CREQ = 3;
        /// <summary>
        /// 回复允许选择角色
        /// </summary>
        public const int SELECT_SRES = 4;
        /// <summary>
        /// 选择群发
        /// </summary>
        public const int SELECT_BRO = 5;
        /// <summary>
        /// 申请发送消息
        /// </summary>
        public const int TALK_CREQ = 6;
        /// <summary>
        /// 群发消息
        /// </summary>
        public const int TALK_BRO = 7;
        /// <summary>
        /// 申请准备就绪
        /// </summary>
        public const int READY_CREQ = 8;
        /// <summary>
        /// 群发准备就绪
        /// </summary>
        public const int READY_BRO = 9;
        /// <summary>
        /// 群发取消这次战斗匹配的消息
        /// </summary>
        public const int DESTORY_BRO = 10;
        /// <summary>
        /// 群发开始战斗
        /// </summary>
        public const int FIGHT_BRO = 11;
    }
}

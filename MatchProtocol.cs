using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// 匹配协议
    /// </summary>
    public class MatchProtocol
    {
        /// <summary>
        /// 申请进入匹配
        /// </summary>
        public const int ENTER_CREQ = 0;
        /// <summary>
        /// 返回申请结果
        /// </summary>
        public const int ENTER_SRES = 1;
        /// <summary>
        /// 申请离开匹配
        /// </summary>
        public const int LEAVE_CREQ = 2;
        /// <summary>
        /// 返回离开结果
        /// </summary>
        public const int LEAVE_SRES = 3;
        /// <summary>
        /// 匹配完毕，通知进入 选择广播界面
        /// </summary>
        public const int ENTER_SELECT_BRO = 4;
    }
}

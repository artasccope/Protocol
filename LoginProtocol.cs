using System;
using System.Collections.Generic;
using System.Text;

namespace Protocol
{
    /// <summary>
    /// 登录协议
    /// </summary>
    public class LoginProtocol
    {
        /// <summary>
        /// 客户端申请登录
        /// </summary>
        public const int LOGIN_CREQ = 0;
        /// <summary>
        /// 服务器反馈给客户端 登录结果 
        /// </summary>
        public const int LOGIN_SRES = 1;
        /// <summary>
        /// 客户端申请注册 
        /// </summary>
        public const int REG_CREQ = 2;
        /// <summary>
        /// 服务器反馈给客户端 注册结果
        /// </summary>
        public const int REG_SRES = 3;
    }
}

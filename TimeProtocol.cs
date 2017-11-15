using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol
{
    public class TimeProtocol
    {
        /// <summary>
        /// 客户端发起检查网络延迟请求
        /// </summary>
        public const int CHECK_CREQ = 0;
        /// <summary>
        /// 服务器回应请求
        /// </summary>
        public const int CHECK_SRES = 1;
        /// <summary>
        /// 服务器向客户端请求对时
        /// </summary>
        public const int CHECK_SREQ = 3;
        /// <summary>
        /// 客户端回答对时
        /// </summary>
        public const int CHECK_CRES = 4;
    }
}

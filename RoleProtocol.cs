using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol
{
    public class RoleProtocol
    {
        public const int INFO_CREQ = 0;//获得用户数据
        public const int INFO_SRES = 1;//返回用户数据
        public const int CREATE_CREQ = 2;//申请创建角色
        public const int CREATE_SRES = 3;//返回创建结果
        public const int ONLINE_CREQ = 4;//申请上线
        public const int ONLINE_SRES = 5;//返回用户上线
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Protocol.Result
{
    public enum AccountResult
    {
        HasAccountCantCreate,
        CreateSuccess,
        AccountNotExistedCantLogin,
        AccountPwdNotMatch,
        LoginSuccess,
        AlreadyOnlineCantLogin,
    }
}

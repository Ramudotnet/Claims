using System;
using System.Collections.Generic;
using System.Text;

namespace Claims.Core.Domain
{
  

    public enum SignInStatus
    {
        LoginFailed=424,
        Success=200,
        LockedOut=300,
        RequiresVerification=301,
        UserInactive=0

    }
}


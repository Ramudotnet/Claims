using Claims.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Claims.Services.Login
{
    public interface ILoginService
    {
        LoginUserResult ValidateUser(LoginUser loginUser);
    }
}

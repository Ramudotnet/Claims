using Claims.Core.Domain;
using ClaimSolution.DBContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClaimSolution.Services.Login
{
    public interface ILoginService
    {
        LoginUserResult ValidateUser(LoginUser loginUser);
    }
}

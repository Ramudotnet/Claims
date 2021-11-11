using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Claims.Core.Domain;
using Dapper;

namespace Claims.Services.Login
{
    public class LoginService : ILoginService
    {
        public LoginUserResult ValidateUser(LoginUser loginUser)
        {

            LoginUserResult objReturnResult;

            using (var db = new SqlConnection(CommonUtils.ConnectionString))
            {
                var mars = db.QueryMultiple("Sec_AppCheckLoginUser", new //The stored proc returns multiple active result set (mars) five result sets
                {
                    @username = loginUser.UserName,
                    @password = loginUser.Password
                }, commandType: CommandType.StoredProcedure, commandTimeout: 300);
                objReturnResult = mars.Read<LoginUserResult>().FirstOrDefault(); //mars Result 1
            }
            return objReturnResult;
        }
    }
}

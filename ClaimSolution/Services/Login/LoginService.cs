using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Claims.Core.Domain;
using ClaimSolution.DBContext;

namespace ClaimSolution.Services.Login
{
    public class LoginService : ILoginService
    {

        public LoginUserResult ValidateUser(LoginUser loginUser)
        {

            try
            {
                LoginUserResult objReturnResult = new LoginUserResult();

                //We have reader access not able to use the SQL dapper 
                //using (var db = new SqlConnection(CommonUtils.ConnectionString))
                //{
                //    var mars = db.QueryMultiple("Sec_AppCheckLoginUser", new //The stored proc returns multiple active result set (mars) five result sets
                //    {
                //        @username = loginUser.UserName,
                //        @password = loginUser.Password
                //    }, commandType: CommandType.StoredProcedure, commandTimeout: 300);
                //    objReturnResult = mars.Read<LoginUserResult>().FirstOrDefault(); //mars Result 1
                //}


                InterviewEntities obj = new InterviewEntities();

                var ValidUser = obj.Users.Where(x => x.UserName == loginUser.UserName && x.Password == loginUser.Password).FirstOrDefault();

                //Is User is active user or not 

                if (ValidUser == null)
                {
                    objReturnResult.ErrorMessage = "Login Failed please check credentials which was provied";
                    objReturnResult.Status = SignInStatus.LoginFailed;
                }
                else if (!ValidUser.Active)
                {
                    objReturnResult.ErrorMessage = "Given user name is inactive, please reach out administrator for activate";
                    objReturnResult.Status = SignInStatus.UserInactive;
                }
                else
                {
                    objReturnResult.LoginDateTime = DateTime.Now.ToLongDateString();
                    objReturnResult.UserId = ValidUser.UserId;
                    objReturnResult.UserFullName = ValidUser.DisplayName;
                    objReturnResult.Status = SignInStatus.Success;
                }

                return objReturnResult;
            }
            catch (Exception objLoginUserException)
            {
                throw objLoginUserException;
            }
        }
    }
}

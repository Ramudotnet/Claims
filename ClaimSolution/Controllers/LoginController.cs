using Claims.Core.Domain;
using ClaimSolution.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClaimSolution.Controllers
{
    [Route("api/v1/Login")]
    public class LoginController : ApiController
    {
        private readonly ILoginService _objLoginService;

        LoginController()
        {
            this._objLoginService = new LoginService();
        }



        [AllowAnonymous]
        [HttpPost]
        [ActionName("ValidateUser")]
        public HttpResponseMessage LoginUserValidation(LoginUser schUserLogin)
        {
            //need to verify the modelvalidation 

            try
            {
                if (ModelState.IsValid)
                {
                    var LoginResult = _objLoginService.ValidateUser(schUserLogin);

                    return Request.CreateResponse(HttpStatusCode.OK, new ResponseMessage { Status = "200", Message = LoginResult.ErrorMessage });
                }

                return Request.CreateResponse(HttpStatusCode.OK, new ResponseMessage { Status = "401", Message = "Model Validation failed " });

            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.ExpectationFailed, new ResponseMessage { Status = "500", Message = "UserName/Password In correct or Choose Correct Role" });
            }

        }
    }

}

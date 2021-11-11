using Claims.Core.Domain;
using ClaimSolution.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClaimSolution.Controllers
{
    public class AccountController : Controller
    {

        private readonly ILoginService _objLoginService;

        public AccountController()
        {
            this._objLoginService = new LoginService();
        }

        [AllowAnonymous]
        public ActionResult SmartLogin(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        public ActionResult SmartLogOut()
        {
            Session.RemoveAll();

            return View("SmartLogOut");
        }
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SmartLogin(LoginUser schUserLogin, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(schUserLogin);
            }

            try
            {
                var LoginResult = _objLoginService.ValidateUser(schUserLogin);

                Session["userInfo"] = LoginResult;

                switch (LoginResult.Status)
                {
                    case SignInStatus.Success:
                        return RedirectToAction("index", "ClaimProcess");
                    case SignInStatus.UserInactive:
                        ModelState.AddModelError("", LoginResult.ErrorMessage);
                        return View("SmartLogin");
                    case SignInStatus.LoginFailed:
                    default:
                        ModelState.AddModelError("", "Invalid login attempt.");
                        return View("SmartLogin");
                }
            }
            catch (Exception objLoginUserException)
            {
                //need to log the exception for tracability

                ModelState.AddModelError("", "Exception Occured while processing" + Convert.ToString(objLoginUserException.InnerException.Message));

                return View("SmartLogin");
            }


        }


    }
}
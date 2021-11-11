using ClaimSolution.Services.LossType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClaimSolution.Controllers
{

    public class ClaimProcessController : Controller
    {
        private readonly ILossTypeService _objILossTypeService;

        public ClaimProcessController()
        {
            this._objILossTypeService = new LossTypeService();
        }

        // GET: ClaimProcess
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllLossTypes()
        {
            try
            {
                var AllLossTypes = _objILossTypeService.GetAllLossTypes();

                return Json(_objILossTypeService.GetAllLossTypes(), JsonRequestBehavior.AllowGet);
            }
            catch (Exception objLosstypeException)
            { 
                return Json("Exception occured while getting details:" + Convert.ToString(objLosstypeException.InnerException.Message));
            }


        }

        [HttpGet]
        public ActionResult GetAllClaimTypesUI()
        {
            return View("AllClaimTypesUI");
        }


    }
}
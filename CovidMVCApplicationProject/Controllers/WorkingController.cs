using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CovidMVCApplicationProject.CustomFilters;
using CovidMVCApplicationProject.DBOperation;

namespace CovidMVCApplicationProject.Controllers
{
    public class WorkingController : Controller
    {
        BussinessLogic objBussinessLogic = new BussinessLogic();
        [UserAuthenticateFilter]
        public ActionResult Index()
        {
            // TempData["validUser"] = Session["username"].ToString();
            if (Session["username"] != null)
            {
                TempData["validUser"] = objBussinessLogic.GetUsernameFromLoginTable(Session["username"].ToString());
            }
            return View();
        }
    }
}
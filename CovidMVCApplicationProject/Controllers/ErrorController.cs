using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CovidMVCApplicationProject.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult error401()
        {
            return View();
        }
        public ActionResult error404()
        {
            return View();
        }
        public ActionResult error500()
        {
            return View();
        }
    }
}
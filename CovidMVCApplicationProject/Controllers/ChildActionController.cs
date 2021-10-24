using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CovidMVCApplicationProject.Controllers
{
    [HandleError]
    public class ChildActionController : Controller
    {
      
        public ActionResult Index()
        {
            return View();
        }
        // [NonAction] If be mark an action with non action attribute then we can not directly access that action with URL.It can only be acccessed by another action.
       [ChildActionOnly]
        public ActionResult CountryList(List<string> countryName)
        {
            return View(countryName);
        }
    }
}
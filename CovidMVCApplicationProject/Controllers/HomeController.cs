using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CovidMVCApplicationProject.DBOperation;
using CovidMVCApplicationProject.Models;

namespace CovidMVCApplicationProject.Controllers
{
    [RoutePrefix("Home")]
    [HandleError]
    public class HomeController : Controller
    {
        BussinessLogic objBussinessLogic = new BussinessLogic();
        [HttpGet]
        [Route("login")]

        public ActionResult Login()
        {
            ViewBag.invalidUserResponse = TempData["invalidUser"];
            ViewBag.GoodResponse = TempData["GoodResponse"];
            return View();
        }
        [HttpPost]

        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                bool response = objBussinessLogic.isValidUser(loginModel);
                if (response == true)
                {
                    Session["username"] = loginModel.email;
                    FormsAuthentication.SetAuthCookie(loginModel.email, false);
                    return RedirectToAction("Index", "Working");
                }
                else
                {
                    TempData["invalidUser"] = "Invalid login credintials";
                    return RedirectToAction("Login");
                }
            }
            else
            {
                return View("Login");
            }

            //if (response == false)
            //{
            //    TempData["invalidUser"] = "Invalid login credintials";
            //    return RedirectToAction("Login");
            //}
            //else
            //{
            //    TempData["validUser"] = "Welcome to CowinSite  " + loginModel.email;
            //    return RedirectToAction("Index", "Working");
            //}



        }
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserRegisterModel userRegisterModel)
        {
            if (ModelState.IsValid)
            {
                bool response = objBussinessLogic.isValidRequest(userRegisterModel);
                if (response == true)
                {
                    Session["username"] = userRegisterModel.email;
                    TempData["GoodResponse"] = "User registered successfully";
                    //FormsAuthentication.SetAuthCookie(loginModel.email, false);
                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    TempData["invalidRequest"] = "Email id already registered.";
                    return RedirectToAction("RegisterUser");
                }
            }
            else
            {
                return View();
            }

        }



        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Route("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("CustomErrorCheck")]
        public ActionResult CustomErrorCheck()
        {
            throw new Exception("things went wrong while executionn");
        }
        [HandleError]
        public ActionResult ErrorCheck()
        {
            return View();
        }


    }
}
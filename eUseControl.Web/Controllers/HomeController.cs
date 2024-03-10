using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.Username = "Customer";
            
            return View(u);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
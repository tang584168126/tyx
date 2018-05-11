using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //ViewData["Test"] = "Hello World";
            //ViewBag.Data = "Hello World";
            TempData["Test"] = "Hello World";
            //return Redirect("~/Home/Details");
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}

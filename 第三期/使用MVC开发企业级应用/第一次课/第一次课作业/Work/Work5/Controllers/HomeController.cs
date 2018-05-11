using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Work5.Models;

namespace Work5.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Sure()
        {
            string name = Request.Form["name"];
            string one = Request.Form["one"];
            string two = Request.Form["two"];
            string school = Request.Form["school"];

            Globle sc = new Globle() { Name = name, One = one, Two = two, School = school };

            Session["sc"] = sc;
            return View("Sure");
            //return RedirectToAction("Sure", "Home");
        }
    }
}

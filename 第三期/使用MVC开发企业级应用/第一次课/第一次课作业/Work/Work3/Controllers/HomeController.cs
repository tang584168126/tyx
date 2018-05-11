using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            string user = "";
            if (Request.Form["user"] != null)
            {
                user = Request.Form["user"].ToString();
            }
            int age = Convert.ToInt32(Request.Form["age"]);
            if (age >= 18 && age <= 100)
            {
                Session["user"] = user;
            }
            return View();
        }

    }
}

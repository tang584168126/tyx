using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShopMvc.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Admin/Account/

        public ActionResult Index()
        {
            return View("Edit");
        }

        [ValidateInput(false)]
        public ActionResult Edit(string content)
        {
            return View();
        }
    }
}

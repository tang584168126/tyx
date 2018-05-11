using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDemo.Models;
namespace MvcDemo.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LogInModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "bobo" && model.Password == "123")//简单模拟验证
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Pay");
                }
            }
            return View();
        }
    }
}

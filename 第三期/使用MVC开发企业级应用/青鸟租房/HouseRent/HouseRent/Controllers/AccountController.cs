using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using HouseRent.BLL;
using HouseRent.Model;

namespace HouseRent.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View("LoginIn");
        }

        public ActionResult LoginIn(string LoginName, string Password)
        {         
            if(ModelState.IsValid)
            {
                UserManager userManager = new UserManager();
                User user;
                if(userManager.LoginIn(LoginName,Password,out user))
                {
                    //登录成功，保存user的值到Session
                    Session["CurrentValid"] = user;
                    return RedirectToAction("", "");
                }
                else
                {
                    ModelState.AddModelError("userable","用户名已注册，请重新输入！");
                    return View("LoginIn");
                }
            }
            else
            {
                return View("user");
            }
        }
    }
}

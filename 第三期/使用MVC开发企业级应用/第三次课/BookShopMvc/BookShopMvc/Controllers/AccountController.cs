using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookShop.Models;
using BookShop.BLL;

namespace BookShopMvc.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View("LogIn");
        }
        public ActionResult LogIn()
        {
            string loginId = Request.Form["username"].ToString();
            string password = Request.Form["password"].ToString();

            //登录
            User user;
            if (new UserManager().LogIn(loginId, password, out user))
            {
                //登录成功，保存Session
                Session["CurrentUser"] = user;

                //保存用户名和密码
                if (!string.IsNullOrEmpty(Request.Form["isSave"]))
                {
                    HttpCookie loginCookie = new HttpCookie("loginId", loginId);
                    loginCookie.Expires = DateTime.MaxValue;

                    HttpCookie passwordCookie = new HttpCookie("password", password);
                    passwordCookie.Expires = DateTime.MaxValue;

                    Response.Cookies.Add(loginCookie);
                    Response.Cookies.Add(passwordCookie);
                }
                else
                {
                    Request.Cookies["LoginId"].Expires = DateTime.Now.AddDays(-1);
                    Request.Cookies["password"].Expires = DateTime.Now.AddDays(-1);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("LogIn");
            }
        }

        public ActionResult LogOut()
        {
            Session["CurrentUser"] = null;
            return RedirectToAction("Index", "Account");
        }

        public ActionResult Register()
        {
            User user = new User()
            {
                LoginId = "Test" + new Random().Next(1,100),
                LoginPwd = "123",
                Name = "张" + new Random().Next(1,100),
                Address = "成都",
                Phone = "12345678",
                Mail = "Test" + new Random().Next(1, 100) + "@qq.com"
            };

            bool isSuccess = new UserManager().Register(user);
            Session["Success"] = isSuccess;
            return View();
        }
    }
}

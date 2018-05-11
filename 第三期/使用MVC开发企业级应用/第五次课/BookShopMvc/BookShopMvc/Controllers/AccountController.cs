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
        public ActionResult LogIn(string username, string password)
        {
            //string loginId = Request.Form["username"].ToString();
            //string password = Request.Form["password"].ToString();

            //登录
            User user;
            if (new UserManager().LogIn(username, password, out user))
            {
                //登录成功，保存Session
                Session["CurrentUser"] = user;

                //保存用户名和密码
                if (!string.IsNullOrEmpty(Request.Form["isSave"]))
                {
                    HttpCookie loginCookie = new HttpCookie("loginId", username);
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

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                UserManager manager = new UserManager();
                if (!manager.Register(user))
                {
                    ModelState.AddModelError("userDouble", "用户名已注册，请重新输入！");
                    return View(user);
                }
                else
                {
                    Session["CurrentUser"] = user;
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View(user);
            }            
        }
    }
}

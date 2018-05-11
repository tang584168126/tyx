using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Friends.Model;

namespace Friends.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            return View("LoginIn");
        }

        public ActionResult LoginIn(string username, string key)
        {
            using(FriendsEntities entities = new FriendsEntities())
            {
                User user = entities.Users.SingleOrDefault(u => u.Mail == username);
                if(user!=null)
                {
                    if(user.Password == key)
                    {
                        return RedirectToAction("Register", "Account");
                    }
                }
            }
            return View("LoginIn");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string email)
        {
            using(FriendsEntities entities = new FriendsEntities())
            {
                entities.Users.Add(new User()
                {
                    Mail = email

                });
            }
            return View();
        }
    }
}

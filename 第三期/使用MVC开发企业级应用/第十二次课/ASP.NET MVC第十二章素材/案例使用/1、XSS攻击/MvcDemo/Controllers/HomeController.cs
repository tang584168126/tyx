using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcDemo.Models;
namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Comment> comments = this.HttpContext.Cache["comments"] as List<Comment>;
            ViewData["comments"] = comments;
            return View();
        }

        [ValidateInput(false)]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(Comment comment)
        {            
            List<Comment> comments = this.HttpContext.Cache["comments"] as List<Comment>;
            if (this.ModelState.IsValid)
            {
                if (comments == null)
                {
                    this.HttpContext.Cache["comments"] = comments = new List<Comment>();
                }
                comments.Add(comment);
            }

            ViewData["comments"] = comments;
            return View();
        }
    }
}

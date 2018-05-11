using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookShop.Models;
using BookShop.BLL;

namespace BookShopMvc.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/

        public ActionResult Details(int id)
        {
            Book book = new BookManager().GetBookById(id);
            return View(book);
        }

    }
}

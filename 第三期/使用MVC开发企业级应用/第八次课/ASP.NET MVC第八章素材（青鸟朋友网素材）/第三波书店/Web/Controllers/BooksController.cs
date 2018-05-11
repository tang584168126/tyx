using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookShop.BLL;
using BookShop.Models;

namespace Web.Controllers
{
    public class BooksController : Controller
    {

        private int PageSize = 5;

        //
        // GET: /Book/

        public ActionResult Detail()
        {
           
            int id = RouteData.Values["id"] != null?Convert.ToInt32(RouteData.Values["id"]):0;
            if (id>0)
            {
                BookManager manager = new BookManager();
                manager.AddClick(id);
                Book book = manager.GetBookById(id);
                return View(book);
            }
            return View();
        }

        public ActionResult List()
        {
           
            int pageCount = 0;//总页数
            int categoryId = RouteData.Values["categoryId"] != null ? Convert.ToInt32(RouteData.Values["categoryId"]) : 1;//总页数
            int pageIndex = RouteData.Values["pageIndex"] != null ? Convert.ToInt32(RouteData.Values["pageIndex"]) : 1;//页序号
            string order = RouteData.Values["order"] != null ? Convert.ToString(RouteData.Values["order"]) : "PublishDate";//排序字段

            BookManager manager = new BookManager();
            List<Book> list = manager.GetBooks(categoryId, this.PageSize, pageIndex, ref pageCount, order);

            ViewData["categoryId"] = categoryId;
            ViewData["pageIndex"] = pageIndex;
            ViewData["order"] = order;
            ViewData["pageCount"] = pageCount;

            return View(list);
        }


    }
}

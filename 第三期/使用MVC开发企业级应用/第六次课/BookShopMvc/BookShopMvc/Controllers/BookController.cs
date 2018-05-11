using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using BookShop.Models;
using BookShop.BLL;
using BookShopMvc.Helpers;

namespace BookShopMvc.Controllers
{
    public class BookController : Controller
    {
        //页总量
        private readonly int PageSize = Convert.ToInt32(ConfigurationManager.AppSettings["BookListPageSize"]);
        //
        // GET: /Book/

        public ActionResult Details(int? id)
        {
            Book book = new BookManager().GetBookById(id);
            return View(book);
        }

        public ActionResult List(int categoryId = 1, int pageIndex = 1, string order = "PublishDate")
        {
            //获取搜索条件
            //int categoryId = Request.QueryString["categoryId"] != null ? Convert.ToInt32(Request.QueryString["categoryId"]) : 1;
            //int pageIndex = Request.QueryString["pageIndex"] != null ? Convert.ToInt32(Request.QueryString["pageIndex"]) : 1;
            //string order = Request.QueryString["order"] != null ? Convert.ToString(Request.QueryString["order"]) : "PublishDate";
            //页总数
            int pageCount = 0;
            BookManager manager = new BookManager();
            List<Book> BookList = manager.GetBooks(categoryId, this.PageSize, pageIndex, ref pageCount, order);

            //控制器传值给View
            ViewData["pageIndex"] = pageIndex;
            ViewData["pageCount"] = pageCount;
            ViewData["categoryId"] = categoryId;
            ViewData["order"] = order;

            //调用视图时，传递的模型参数
            return View(BookList);
        }
    }
}

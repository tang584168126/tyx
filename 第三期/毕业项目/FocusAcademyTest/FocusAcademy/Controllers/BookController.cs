using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FocusAcademy.Models;

namespace FocusAcademy.Controllers
{
    public class BookController : Controller
    {
        /// <summary>
        /// 书籍
        /// </summary>

        FocusBookEntities entities = new FocusBookEntities();
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 书籍
        /// </summary>
        /// <returns></returns>
        public ActionResult Book(int bookId = 3)
        {
            //根据书籍编号获取评论对象
            var common = entities.UserComments.SingleOrDefault(m => m.BookId.Equals(bookId));
            if(common.BookId == null)
            {
                //实体书编号为空，说明传过来的编号为电子书编号
                //根据电子书编号获取电子书信息
                EBookInfo eBook = new EBookInfo();
                BookBasicInfo bookBasic = new BookBasicInfo();
            }
            else
            {
                //实体书编号不为空，说明传过来的编号为实体书编号
            }
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.BLL;
using BookShop.Helpers;
using BookShop.Models;

namespace Web.Areas.Admin.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        const int pageSize = 10;
        //
        // GET: /Admin/Book/

        public ActionResult List(string category, string keyWord, int pageIndex = 1)
        {
            List<Book> books = null;
            if (!string.IsNullOrEmpty(category))
            {
                BookQueryCategories cate = (BookQueryCategories)Enum.Parse(typeof(BookQueryCategories), category);
                books = new BookManager().GetBooks(cate, keyWord);
            }
            else
            {
                books = new BookManager().GetBooks();
            }
            PagedList<Book> pagedBooks = new PagedList<Book>(books, pageIndex, pageSize);

            SetDropDownList(category);

            ViewData["keyWord"] = keyWord;

            return View("List", pagedBooks);
        }

        public ActionResult Detail(int? id)
        {
            Book book = null;
            if (id.HasValue)
            {
                book = new BookManager().GetBookById(id.Value);
            }
            return View(book);
        }

        public ActionResult Delete(int? id)
        {
            BookManager manager = new BookManager();
            if (id.HasValue)
            {
                if (manager.DeleteBookById(id.Value))
                {
                    return Content("<script>alert('删除书籍成功！');location.href='" + UrlHelper.GenerateContentUrl("~/Admin/Books/List", this.HttpContext) + "'</script>");

                }
            }
            return RedirectToAction("List");
        }

        #region "练习4——维护图书信息（使用定制模板）"
        public ActionResult Edit(int? id)
        {
            Book book = null;
            if (id.HasValue)
            {
                book = new BookManager().GetBookById(id.Value);
            }

            SetDropDownList();

            return View(book);
        }


        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            BookManager manger = new BookManager();
            if (ModelState.IsValid)
            {
                if (book.Id > 0)//修改
                {
                    manger.ModifyBook(book);
                }

                else//添加
                {
                    manger.AddBook(book);

                }

                if (Request.Files["imgISBN"] != null && Request.Files["imgISBN"].FileName.Length > 0)
                {
                    string strpath = Server.MapPath("~/images/BookCovers/" + book.ISBN + ".jpg");
                    Request.Files["imgISBN"].SaveAs(strpath);//把图片保存在此路径中
                }
            }
            else
            {
                this.SetDropDownList();
                return View("Edit", book);//返回原页面
            }
            return RedirectToAction("List");
        }
        #endregion

        #region "练习2——维护图书信息（不使用定制模板）"
        public ActionResult Edit1(int? id)
        {
            Book book = null;
            if (id.HasValue)
            {
                book = new BookManager().GetBookById(id.Value);
            }

            SetDropDownList();

            return View("Edit1",book);
        }


        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Edit1(Book book)
        {
            BookManager manger = new BookManager();
            if (ModelState.IsValid)
            {
                if (book.Id > 0)//修改
                {
                    manger.ModifyBook(book);
                }

                else//添加
                {
                    manger.AddBook(book);

                }

                if (Request.Files["imgISBN"] != null && Request.Files["imgISBN"].FileName.Length>0)
                {
                    string strpath = Server.MapPath("~/images/BookCovers/" + book.ISBN + ".jpg");
                    Request.Files["imgISBN"].SaveAs(strpath);//把图片保存在此路径中
                }
            }
            else
            {
                this.SetDropDownList();
                return View("Edit1", book);//返回原页面
            }
            return RedirectToAction("List");
        }
        #endregion



        /// <summary>
        /// 提供编辑页面下拉框的数据
        /// </summary>
        private void SetDropDownList()
        {
            //使用两种不同的方式提供下拉框数据
            List<Category> categories = new CategoryManager().GetCategories();

            List<Publisher> publishers = new PublisherManager().GetPublishers();

            var itemPublishers = new List<SelectListItem>();
            foreach (Publisher item in publishers)
            {
                itemPublishers.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString(), Selected = false });
            }
            ViewData["publishers"] = new SelectList(publishers, "Id", "Name");

            var itemCategories = new List<SelectListItem>();
            foreach (Category item in categories)
            {
                itemCategories.Add(new SelectListItem() { Text = item.Name, Value = item.Id.ToString(), Selected = false });
            }
            ViewData["categories"] = itemCategories;
        }


        /// <summary>
        /// 提供书籍查询方式下拉框数据
        /// </summary>
        /// <param name="selectCategory"></param>
        private void SetDropDownList(string selectCategory)
        {

            var itemCategories = new List<SelectListItem>();

            Array items = Enum.GetValues(typeof(BookQueryCategories));
            for (int i = 0; i < items.Length; i++)
            {
                string selectItem = items.GetValue(i).ToString();
                if (selectCategory != selectItem)
                {
                    itemCategories.Add(new SelectListItem() { Text = selectItem, Value = selectItem });
                }
                else
                {
                    itemCategories.Add(new SelectListItem() { Text = selectItem, Value = selectItem, Selected = true });
                }
            }

            ViewData["category"] = itemCategories;
        }


     
    }

 
}

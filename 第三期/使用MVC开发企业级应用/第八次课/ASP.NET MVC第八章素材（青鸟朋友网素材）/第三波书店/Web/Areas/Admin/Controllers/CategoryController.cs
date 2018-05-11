using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.BLL;
using BookShop.Models;

namespace Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Admin/Category/

        public ActionResult List()
        {
            List<Category> cates = new CategoryManager().GetCategories();
            return View(cates);
        }

        [HttpPost]
        public ActionResult Add(string categoryName)
        {
            CategoryManager manager = new CategoryManager();
            if (!string.IsNullOrEmpty(categoryName))
            {
                Category catagory = new Category();

                catagory.Name = categoryName;
                manager.AddCategory(catagory);
            }
            else
            {
                return Content("<script>alert('请输入分类名称！');location.href='"+UrlHelper.GenerateContentUrl("~/Admin/Category/List",this.HttpContext)+"'</script>");
            }

            List<Category> cates = manager.GetCategories();
            return View("List", cates);
        }

    }
}

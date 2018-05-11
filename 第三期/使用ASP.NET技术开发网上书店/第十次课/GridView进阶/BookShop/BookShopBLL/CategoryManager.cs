using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class CategoryManager
    {
        CategoryService service = new CategoryService();

        //获取所有的书籍类型
        public List<Category> GetAllCategories()
        {
            return new CategoryService().GetAllCategories();
        }
    }
}
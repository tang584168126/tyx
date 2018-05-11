using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.Models;
using BookShop.DAL;

namespace BookShop.BLL
{
    public class CategoryManager
    {
        CategoryService categoryService = new CategoryService();

        //获取所有的书籍类型
        public List<Category> GetCategories()
        {
            return categoryService.GetCategories();
        }
    }
}

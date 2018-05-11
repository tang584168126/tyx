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
        /// <summary>
        /// 获取Category数据
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            return new CategoryService().GetCategories();
        }
    }
}

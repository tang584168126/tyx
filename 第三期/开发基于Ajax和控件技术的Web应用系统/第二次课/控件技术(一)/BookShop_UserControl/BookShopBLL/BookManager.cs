using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.Models;
using BookShop.DAL;

namespace BookShop.BLL
{
    public class BookManager
    {
         /// <summary>
        /// 获取所有书籍
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks()
        {
            return new BookService().GetBooks();
        }

        public List<Book> GetRankings(int count)
        {
            return new BookService().GetRankings(count);
        }
    }
}

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
        public List<Book> GetAllBook()
        {
            return new BookService().GetAllBook();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class BookManager
    {
        BookService service = new BookService();

        //根据书籍类型查询对应的书籍
        public List<Book> GetBookByCategory(int categoryId)
        {
            return service.GetBookByCategory(categoryId);
        }

        //获取所有的书籍信息
        public List<Book> GetBooks()
        {
            return service.GetBooks();
        }

        //根据查询类别和关键字查询符合条件的书籍
        public List<Book> GetBooks(BookQueryCategories category, string keyword)
        {
            return service.GetBooks(category, keyword);
        }

        public bool DeleteBookById(int id)
        {
            return new BookService().DeleteBookById(id);
        }
    }
}
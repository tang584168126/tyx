using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSet.DAL;
using BookSet.Models;

namespace BookSet.BLL
{
    public class BookManager
    {
        /// <summary>
        /// 获取全部书籍
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            return new BookService().GetAllBooks();
        }

        /// <summary>
        /// 根据用户输入的字符串搜索书籍对象
        /// </summary>
        /// <param name="str">用户输入的字符串</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByAuthorORName(string str)
        {
            return new BookService().GetBooksByAuthorORName(str);
        }

        /// <summary>
        /// 根据书籍类型,书籍点击率获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByClick(int moldId)
        {
            return new BookService().GetBooksByClick(moldId);
        }

        /// <summary>
        /// 根据书籍类型,书籍上架时间获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByDate(int moldId)
        {
            return new BookService().GetBooksByDate(moldId);
        }

        /// <summary>
        /// 根据书籍类型,书籍字数获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByWordCount(int moldId)
        {
            return new BookService().GetBooksByDate(moldId);
        }

        /// <summary>
        /// 根据书籍类型,书籍状态获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByBookState(int moldId)
        {
            return new BookService().GetBooksByBookState(moldId);
        }

        /// <summary>
        /// 根据点击率获取书籍热门推荐
        /// </summary>
        /// <returns>书籍热门推荐</returns>
        public List<Book> GetBookByClicks()
        {
            return new BookService().GetBookByClicks();
        }
    }
}

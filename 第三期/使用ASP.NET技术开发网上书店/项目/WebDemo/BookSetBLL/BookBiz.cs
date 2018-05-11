using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSet.Models;
using BookSet.DAL;
namespace BookSet.BLL
{
    public class BookBiz
    {

        /// <summary>
        /// 获取书籍信息
        /// </summary>
        /// <param name="booksIsbn"></param>
        /// <returns></returns>
        public IList<Books> GetItems(string booksIsbn) 
        {

            return new BookService().GetItems(booksIsbn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BookSet.Models;

namespace BookSet.DAL
{
    public class BookService
    {
        /// <summary>
        /// 根据SQL语句,类型编号获取对应的书籍对象
        /// </summary>
        /// <param name="sqlText">SQL语句</param>
        /// <param name="moldId">类型编号</param>
        /// <returns>对应的书籍对象</returns>
        private List<Book> GetBooks(string sqlText,int moldId = 1,int publisherId = 1)
        {
            List<Book> list = new List<Book>();
            Book book = null;
            
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                while (reader.Read())
                {
                    book = new Book();
                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Author = reader["Author"].ToString();
                    book.BookName = reader["BookName"].ToString();
                    book.BookState = Convert.ToBoolean(reader["BookState"]);
                    book.BuyDate = Convert.ToDateTime(reader["BuyDate"]);
                    book.ISBN = reader["ISBN"].ToString();

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"] == null ? 1 : 0);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime(reader["PublisherDate"]);
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        /// <summary>
        /// 获取全部书籍
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAllBooks()
        {
            string sqlText = "select * from Books";
            return GetBooks(sqlText);
        }

        /// <summary>
        /// 根据用户输入的字符串搜索书籍对象
        /// </summary>
        /// <param name="str">用户输入的字符串</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByAuthorORName(string str)
        {
            string sqlText = "select * from Books where Author like %" + str + "% or BookName like %" + str + "%";
            return GetBooks(sqlText);
        }

        /// <summary>
        /// 根据书籍类型,书籍点击率获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByClick(int moldId)
        {
            string sqlText = "select TOP 10 * from Books where MoldId = " + moldId + " order by Clicks desc";
            return GetBooks(sqlText);
        }

        /// <summary>
        /// 根据书籍类型,书籍上架时间获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByDate(int moldId)
        {
            string sqlText = "select TOP 10 * from Books where MoldId = " + moldId + " order by BuyDate desc";
            return GetBooks(sqlText, moldId);
        }

        /// <summary>
        /// 根据书籍类型,书籍字数获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByWordCount(int moldId)
        {
            string sqlText = "select TOP 10 * from Books where MoldId = " + moldId + " order by WordCount desc";
            return GetBooks(sqlText, moldId);
        }

        /// <summary>
        /// 根据书籍类型,书籍状态获取书籍对象
        /// </summary>
        /// <param name="moldId">书籍类型</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByBookState(int moldId)
        {
            string sqlText = "select TOP 10 * from Books where MoldId = " + moldId + " and BookState = 1 order by Id desc";
            return GetBooks(sqlText, moldId);
        }

        /// <summary>
        /// 根据点击率获取书籍热门推荐
        /// </summary>
        /// <returns>书籍热门推荐</returns>
        public List<Book> GetBookByClicks()
        {
            string sqlText = "select TOP 6 * from Books order by Clicks desc";
            return GetBooks(sqlText);
        }
    }
}

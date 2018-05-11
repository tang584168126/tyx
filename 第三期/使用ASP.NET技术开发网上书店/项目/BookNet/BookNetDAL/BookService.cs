using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using BookNet.Models;

namespace BookNet.DAL
{
    public class BookService
    {
        /// <summary>
        /// 获取所有的书籍
        /// </summary>
        /// <returns>书籍集合</returns>
        public List<Book> GetAllBooks()
        {
            string sqlText = "select * from [Books] order by Id";
            List<Book> list = new List<Book>();
            Book book = null;

            int publisherId = 1;
            int moldId = 1;
            int commentId = 1;

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

                    commentId = Convert.ToInt32(reader["CommentId"]);
                    book.Comment = new CommentService().getCommentById(commentId);

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"]);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime("PublisherDate");
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        /// <summary>
        /// 根据类型编号查询相对应的书籍
        /// </summary>
        /// <param name="moldId">类型编号</param>
        /// <returns>书籍对象</returns>
        public List<Book> GetBooksByMoldId(int moldId = 1)
        {
            string sqlText = "select * from [Books] where MoldId = " + moldId;

            List<Book> list = new List<Book>();
            Book book = null;

            int publisherId = 1;
            int commentId = 1;

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

                    commentId = Convert.ToInt32(reader["CommentId"]);
                    book.Comment = new CommentService().getCommentById(commentId);

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"]);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime("PublisherDate");
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        /// <summary>
        /// 根据点击率来查询相对应的书籍
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooksByClicks()
        {
            string sqlText = "select * from [Books] order by Clicks desc";
            List<Book> list = new List<Book>();
            Book book = null;

            int publisherId = 1;
            int moldId = 1;
            int commentId = 1;

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

                    commentId = Convert.ToInt32(reader["CommentId"]);
                    book.Comment = new CommentService().getCommentById(commentId);

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"]);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime("PublisherDate");
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        public List<Book> GetAllBooks(string sortField)
        {
            string sqlText = "select * from [Books] order by " + sortField;
            List<Book> list = new List<Book>();
            Book book = null;

            int publisherId = 1;
            int moldId = 1;
            int commentId = 1;

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

                    commentId = Convert.ToInt32(reader["CommentId"]);
                    book.Comment = new CommentService().getCommentById(commentId);

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"]);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime("PublisherDate");
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        public List<Book> GetAllBooks(int pageSize, int pageIndex)
        {
            string sqlStr = "select * from [Books]";
            List<Book> list = new List<Book>();
            Book book = null;

            string key = "Id";
            string sortField = "Id";
            int publisherId = 1;
            int moldId = 1;
            int commentId = 1;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, "usp_divPage", sqlStr, pageSize, pageIndex, key, sortField))
            {
                while (reader.Read())
                {
                    book = new Book();
                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Author = reader["Author"].ToString();
                    book.BookName = reader["BookName"].ToString();
                    book.BookState = Convert.ToBoolean(reader["BookState"]);
                    book.BuyDate = Convert.ToDateTime(reader["BuyDate"]);

                    commentId = Convert.ToInt32(reader["CommentId"]);
                    book.Comment = new CommentService().getCommentById(commentId);

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"]);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime("PublisherDate");
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        public List<Book> GetAllBooks(int pageSize, int pageIndex, string sortField)
        {
            string sqlStr = "select * from [Books]";
            List<Book> list = new List<Book>();
            Book book = null;

            string key = "Id";
            int publisherId = 1;
            int moldId = 1;
            int commentId = 1;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, "usp_divPage", sqlStr, pageSize, pageIndex, key, sortField))
            {
                while (reader.Read())
                {
                    book = new Book();
                    book.Id = Convert.ToInt32(reader["Id"]);
                    book.Author = reader["Author"].ToString();
                    book.BookName = reader["BookName"].ToString();
                    book.BookState = Convert.ToBoolean(reader["BookState"]);
                    book.BuyDate = Convert.ToDateTime(reader["BuyDate"]);

                    commentId = Convert.ToInt32(reader["CommentId"]);
                    book.Comment = new CommentService().getCommentById(commentId);

                    moldId = Convert.ToInt32(reader["MoldId"]);
                    book.Mold = new MoldService().GetMoldById(moldId);

                    publisherId = Convert.ToInt32(reader["PublisherId"]);
                    book.Publisher = new PublisherService().GetPublisherById(publisherId);

                    book.Number = Convert.ToInt32(reader["Number"]);
                    book.Picture = reader["Picture"].ToString();
                    book.SellMoney = Convert.ToDecimal(reader["SellMoney"]);
                    book.WordCount = Convert.ToInt32(reader["WordCount"]);
                    book.PublisherDate = Convert.ToDateTime("PublisherDate");
                    book.Content = reader["Content"].ToString();

                    list.Add(book);
                }
            }
            return list;
        }

        /// <summary>
        /// 获取总记录数
        /// </summary>
        /// <returns></returns>
        public int GetItemCount()
        {
            string sqlText = "select count(1) from [Books]";

            try
            {
                return Convert.ToInt32(SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, CommandType.Text, sqlText));
            }
            catch
            {

                return -1;
            }
        }
    }
}

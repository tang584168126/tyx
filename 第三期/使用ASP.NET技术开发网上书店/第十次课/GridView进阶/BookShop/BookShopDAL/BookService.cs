using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.DAL
{
    public class BookService
    {
        //根据书籍类型查询对应的书籍
        public List<Book> GetBookByCategory(int categoryId)
        {
            string sqlText = "";
            if (categoryId == -1)
            {
                //查询所有
                sqlText = "select Id,Title from Books";
                
            }
            else 
            {
                //查询指定类型的书籍
                sqlText = "select Id,Title from Books where categoryId=" + categoryId;
            }

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString,CommandType.Text,sqlText);
            List<Book> list = null;
            if (ds.Tables.Count > 0)
            {
                list = new List<Book>();
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    Book book = new Book();
                    book.Id = (int)row["Id"];
                    book.Title = (string)row["Title"];
                    list.Add(book);
                }
            }
            return list;
        }

        //查询所有书籍
        public List<Book> GetBooks()
        {
            string sqlText = "select * from Books";

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            List<Book> list = null;
            if (ds.Tables.Count > 0)
            {
                list = new List<Book>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Book book = new Book();
                    book.Id = (int)row["Id"];
                    book.Title = (string)row["Title"];
                    book.Author = (string)row["Author"];
                    book.PublishDate = (DateTime)row["PublishDate"];
                    book.ISBN = (string)row["ISBN"];
                    book.UnitPrice = (decimal)row["UnitPrice"];
                    book.ContentDescription = (string)row["ContentDescription"];
                    book.TOC = (string)row["TOC"];
                    book.Clicks = (int)row["Clicks"];

                    book.Publisher = new PublisherService().GetPublisherById((int)row["PublisherId"]); //FK
                    book.Category = new CategoryService().GetCategoryById((int)row["CategoryId"]); //FK
                    list.Add(book);
                }
            }
            return list;
        }

        //根据查询类别和关键字查询符合条件的书籍
        public List<Book> GetBooks(BookQueryCategories category, string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@QueryCategory",""),
                new SqlParameter("@KeyWord","")
            };

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.StoredProcedure, "sp_QueryBooks", para);
            List<Book> list = null;
            if (ds.Tables.Count > 0)
            {
                list = new List<Book>();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    Book book = new Book();
                    book.Id = (int)row["Id"];
                    book.Title = (string)row["Title"];
                    book.Author = (string)row["Author"];
                    book.PublishDate = (DateTime)row["PublishDate"];
                    book.ISBN = (string)row["ISBN"];
                    book.UnitPrice = (decimal)row["UnitPrice"];
                    book.ContentDescription = (string)row["ContentDescription"];
                    book.TOC = (string)row["TOC"];
                    book.Clicks = (int)row["Clicks"];

                    book.Publisher = new PublisherService().GetPublisherById((int)row["PublisherId"]); //FK
                    book.Category = new CategoryService().GetCategoryById((int)row["CategoryId"]); //FK
                    list.Add(book);
                }
            }
            return list;
        }

        //根据编号删除书籍
        public bool DeleteBookById(int id)
        {
            string sql = "delete Books where Id = @Id";
            SqlParameter[] para = new SqlParameter[]
				{
					new SqlParameter("@Id", id)
				};

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sql, para) > 0;
        }
    }
}
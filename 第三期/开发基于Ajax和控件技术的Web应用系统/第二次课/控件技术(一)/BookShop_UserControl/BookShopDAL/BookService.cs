using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using BookShop.Models;

namespace BookShop.DAL
{
    public class BookService
    {
        /// <summary>
        /// 获取所有书籍
        /// </summary>
        /// <returns></returns>
        public List<Book> GetBooks()
        {
            string sqlText = "SELECT * FROM Books";
            List<Book> list = new List<Book>();
            DataSet set = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            if (set.Tables.Count > 0)
            {
                DataTable table = set.Tables[0];
                foreach (DataRow row in table.Rows)
                {
                    Book item = new Book
                    {
                        Id = (int)row["Id"],
                        Title = (string)row["Title"],
                        Author = (string)row["Author"],
                        PublishDate = (DateTime)row["PublishDate"],
                        ISBN = (string)row["ISBN"],
                        UnitPrice = (decimal)row["UnitPrice"],
                        ContentDescription = (string)row["ContentDescription"],
                        TOC = (string)row["TOC"],
                        Clicks = (int)row["Clicks"],
                        Publisher = new PublisherService().GetPublisherById((int)row["PublisherId"]),
                        Category = new CategoryService().GetCategoryById((int)row["CategoryId"])
                    };
                    list.Add(item);
                }
            }
            return list;
        }

        public List<Book> GetRankings(int count)
        {
            List<Book> list = new List<Book>();

            string sqlText = "SELECT TOP " + count + " * FROM Books ORDER BY  Clicks DESC ";

            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText, null);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
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
    }
}

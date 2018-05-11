using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using BookShop.Models;
using System.Data.SqlClient;

namespace BookShop.DAL
{
    public class BookService
    {
        public List<Book> GetAllBook()
        {
            List<Book> books = new List<Book>();
            string sqlText = "select * from Books";

            int publisherId = 1;
            int categoryId = 1;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text, sqlText))
            {
                while (reader.Read())
                {
                    Book book = new Book();
                    book.Id = (int)reader["Id"];
                    book.Title = (string)reader["Title"];
                    book.Author = (string)reader["Author"];
                    book.PublishDate = (DateTime)reader["PublishDate"];
                    book.ISBN = (string)reader["ISBN"];
                    book.UnitPrice = (decimal)reader["UnitPrice"];
                    book.ContentDescription = (string)reader["ContentDescription"];
                    book.TOC = (string)reader["TOC"];
                    book.Clicks = (int)reader["Clicks"];

                    publisherId = (int)reader["PublisherId"];
                    categoryId = (int)reader["CategoryId"];

                    book.Publisher = new PublisherService().GetPublisherById(publisherId);
                    book.Category = new CategoryService().GetCategoryById(categoryId);

                    books.Add(book);
                }
            }
            return books;
        }
    }
}

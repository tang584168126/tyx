using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSet.Models;
using System.Data.SqlClient;
using System.Data;


namespace BookSet.DAL
{
   public class BookService
    {
       //根据书籍的ISBN查找书籍
       public IList<Books> GetItems(string isbn) 
       {
          IList<Books> items=new List<Books>();
          string sqltext = "select * from Books where ISBN = @ISBN" ;
          SqlParameter pater = new SqlParameter("@ISBN", isbn);

          SqlDataReader reder = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqltext, pater);
         while(reder.Read())
         {
             Books book = new Books();
             book.Id = Int32.Parse(reder["Id"].ToString());
             book.BookName = reder["BookName"].ToString();
             book.Author = reder["Author"].ToString();
             book.SellMoney = Convert.ToInt32(reder["SellMoney"]);
             book.PublisherDate =Convert.ToDateTime(reder["PublisherDate"]);
             book.Isbn = reder["ISBN"].ToString();
             book.Content = reder["Content"].ToString();
             book.Clicks = Convert.ToInt32(reder["Clicks"].ToString());
             items.Add(book);
         }
           return items;
       }
    }
}

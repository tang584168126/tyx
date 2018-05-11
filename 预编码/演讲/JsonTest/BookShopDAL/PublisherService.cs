using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;

using BookShop.Models;
using System.Data;

namespace BookShop.DAL
{
    public class PublisherService
    {
        /// <summary>
        /// 根据公布Id获取公布的对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Publisher GetPublisherById(int Id)
        {
            string sqlText = "select * from [Publishers] where Id = " + Id;
            Publisher publisher = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    publisher = new Publisher();
                    publisher.Id = Id;
                    publisher.Name = reader["Name"].ToString();                    
                }               
            }
            return publisher;
        }
    }
}

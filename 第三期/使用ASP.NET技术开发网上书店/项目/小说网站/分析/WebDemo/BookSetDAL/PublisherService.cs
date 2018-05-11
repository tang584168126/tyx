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
    public class PublisherService
    {
        /// <summary>
        /// 根据出版社编号查找出版社对象
        /// </summary>
        /// <param name="id">出版社编号</param>
        /// <returns>出版社对象</returns>
        public Publisher GetPublisherById(int id)
        {
            string sqlText = "select * from [Publishers] where Id = " + id;

            Publisher publisher = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    publisher = new Publisher();

                    publisher.Id = Convert.ToInt32(reader["Id"]);
                    publisher.Name = reader["Name"].ToString();
                }
            }
            return publisher;
        }
        
    }
}

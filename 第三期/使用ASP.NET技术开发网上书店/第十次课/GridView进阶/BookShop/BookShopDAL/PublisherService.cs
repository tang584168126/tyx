using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.DAL
{
    public class PublisherService
    {
        /// <summary>
        /// 根据出版社编号获取出版社名称
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Publisher GetPublisherById(int id)
        {
            string sqlText = "SELECT * FROM Publishers WHERE Id = @Id";
            Publisher publisher = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, new SqlParameter("@Id", id)))
            {
                if (reader.Read())
                {
                    publisher = new Publisher();
                    publisher.Id = (int)reader["Id"];
                    publisher.Name = (string)reader["Name"];
                    return publisher;
                }
            }
            return publisher;
        }

        /// <summary>
        /// 获取所有的publisher
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetAllPublisher()
        {
            string sqlText = "select * from Publishers";
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            List<Publisher> list = null;
            if (ds.Tables.Count > 0)
            {
                list = new List<Publisher>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Publisher publisher = new Publisher();
                    publisher.Id = (int)dr["Id"];
                    publisher.Name = dr["Name"].ToString();

                    list.Add(publisher);
                }
            }
            return list;
        }
    }
}
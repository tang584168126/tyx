using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BookShop.Models;

namespace BookShop.DAL
{
    public class PublisherService
    {
        /// <summary>
        /// 获取所有的出版社信息
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetPublishers()
        {
            List<Publisher> list = new List<Publisher>();

            string sqlText = "SELECT * FROM Publishers";
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            if (ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    Publisher publisher = new Publisher();

                    publisher.Id = (int)row["Id"];
                    publisher.Name = (string)row["Name"];

                    list.Add(publisher);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据出版社编号获取出版社
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Publisher GetPublisherById(int id)
        {
            string commandText = "SELECT * FROM Publishers WHERE Id = @Id";
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, commandText, new SqlParameter[] { new SqlParameter("@Id", id) }))
            {
                if (reader.Read())
                {
                    return new Publisher { Id = (int)reader["Id"], Name = (string)reader["Name"] };
                }
            }
            return null;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BookShop.Models;

namespace BookShop.DAL
{
    public class CategoryService
    {
        public List<Category> GetCategories()
        {
            List<Category> list = new List<Category>();

            string sqlText = "select * from Categories";
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Category item = new Category();
                item.Id = Convert.ToInt32(row["Id"]);
                item.Name = row["Name"].ToString();
                item.SortNum = Convert.ToInt32(row["SortNum"]);
                item.PId = Convert.ToInt32(row["PId"]);

                list.Add(item);
            }
            return list;
        }

        public Category GetCategoryById(int id)
        {
            string commandText = "SELECT * FROM Categories WHERE Id = @Id";
            Category category = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, commandText, new SqlParameter[] { new SqlParameter("@Id", id) }))
            {
                if (reader.Read())
                {
                    category = new Category
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        PId = (int)reader["PId"]
                    };
                }
            }
            return category;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using BookShop.Models;
using System.Data.SqlClient;

namespace BookShop.DAL
{
    public class CategoryService
    {
        /// <summary>
        /// 获取所有类型
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 根据类型Id获取类型对象
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Category GetCategoryById(int Id)
        {
            string sqlText = "select * from [Categories] where Id = " + Id;
            Category category = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    category = new Category();
                    category.Id = Id;
                    category.Name = reader["Name"].ToString();
                    category.SortNum = Convert.ToInt32(reader["SortNum"]);
                    category.PId = Convert.ToInt32(reader["PId"]);
                }
            }
            return category;
        }
    }  
}

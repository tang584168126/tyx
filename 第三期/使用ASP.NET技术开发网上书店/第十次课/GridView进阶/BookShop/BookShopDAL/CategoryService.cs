using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.DAL
{
    public class CategoryService
    {
        //获取所有的书本类型
        public List<Category> GetAllCategories()
        {
            string sqlText = "select * from Categories";
            List<Category> list = null;
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString,CommandType.Text,sqlText);
            if (ds.Tables.Count > 0)
            {
                list = new List<Category>();
                //每循环一次，生成一个Category对象，并添加到集合中
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    Category category = new Category();
                    category.Id = (int)row["Id"];
                    category.Name = (string)row["Name"];
                    category.PId = (int)row["PId"];
                    category.SortNum = (int)row["SortNum"];

                    list.Add(category);
                }
            }
            return list;
        }

        //根据类型编号获取类型对象
        public Category GetCategoryById(int id)
        {
            string sqlText = "SELECT * FROM Categories WHERE Id = @Id";
            Category category = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, new SqlParameter("@Id", id)))
            {
                if (reader.Read())
                {
                    category = new Category();
                    category.Id = (int)reader["Id"];
                    category.Name = (string)reader["Name"];
                    category.PId = (int)reader["PId"];
                    category.SortNum = (int)reader["SortNum"];
                    return category;
                }
            }
            return category;
        }
    }
}
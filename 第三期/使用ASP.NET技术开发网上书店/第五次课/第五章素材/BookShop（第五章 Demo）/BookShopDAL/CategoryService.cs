using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.Models;
using System.Data;

namespace BookShop.DAL
{
    public class CategoryService
    {
        public List<Category> GetCategories()
        {
            string sqlText = "select * from Categories";

            List<Category> list = new List<Category>();
            
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Category catagory = new Category();
                catagory.Id = Convert.ToInt32(dr["Id"]);
                catagory.Name = dr["Name"].ToString();
                catagory.PId = Convert.ToInt32(dr["PId"]);
                catagory.SortNum = Convert.ToInt32(dr["SortNum"]);

                list.Add(catagory);
            }
            return list;
        }
    }
}

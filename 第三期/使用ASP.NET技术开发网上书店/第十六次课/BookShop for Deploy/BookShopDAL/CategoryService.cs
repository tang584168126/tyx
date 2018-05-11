using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using BookShop.Models;

namespace BookShop.DAL
{
    public class CategoryService
    {
        //获取所有的书籍类型
        public List<Category> GetCategories()
        {
            string sqlText = "select * from Categories order by SortNum asc";
            List<Category> list = new List<Category>();
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
            //表示查询出了结构并以表的形式添加到了DataSet中
            if (ds.Tables.Count > 0)
            {
                //循环读取表中数据并放入列表集合中
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    //每次循环从表中读取一行数据并实例化为对应的对象。
                    Category category = new Category();

                    category.Id = (int)row["Id"];
                    category.Name = row["Name"].ToString();
                    category.PId = (int)row["PId"];
                    category.SortNum = (int)row["SortNum"];
                    list.Add(category);
                }
            }
            return list;
        }
    }
}

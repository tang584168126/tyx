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
    public class MoldService
    {
        /// <summary>
        /// 根据书籍类型编号查找书籍类型
        /// </summary>
        /// <param name="id">书籍类型编号</param>
        /// <returns>书籍</returns>
        public Mold GetMoldById(int id)
        {
            string sqlText = "select * from [Molds] where Id = " + id;
            Mold mold = null;
            using(SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text,sqlText))
            {
                if (reader.Read())
                {
                    mold = new Mold();
                    mold.Id = Convert.ToInt32(reader["Id"]);
                    mold.Name = reader["Name"].ToString();
                }
            }
            return mold;
        }
    }
}

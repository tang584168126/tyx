using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserStateService
    {
        /// <summary>
        /// 根据用户状态编号获得用户状态对象
        /// </summary>
        /// <param name="id">用户状态编号</param>
        /// <returns>用户状态对象</returns>
        public UserState getUserState(int id)
        {
            string sqlText = "select * from [UserState] where Id =" + id;

            UserState userState = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    userState = new UserState();
                    userState.Id = Convert.ToInt32(reader["Id"]);
                    userState.Name = reader["Name"].ToString();
                }
            }
            return userState;
        }
    }
}

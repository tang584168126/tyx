using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using BookShop.Models;

namespace BookShop.DAL
{
    public class UserStateService
    {
        /// <summary>
        /// 根据状态编号获取状态对象
        /// </summary>
        /// <param name="loginId">状态编号</param>
        /// <returns>状态对象</returns>
        public UserState GetUserStateById(int id)
        {
            string sqlText = "select * from UserStates where Id = @Id";
            SqlParameter para = new SqlParameter("@Id", id);

            UserState userState = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, para))
            {
                if (reader.Read())
                {
                    userState = new UserState();
                    userState.Id = id;
                    userState.Name = reader["Name"].ToString();
                }
            }
            return userState;
        }   
    }
}

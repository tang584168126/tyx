using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserStateService
    {
        /// <summary>
        /// 根据UserStateId获取UserState
        /// </summary>
        /// <param name="userStateId">用户状态编号</param>
        /// <returns>用户状态对象</returns>
        public UserState GetUserStateById(int userStateId)
        {
            string sqlText = "select * from UserStates where Id = @UserStateId";
            SqlParameter para = new SqlParameter("@UserStateId", userStateId);

            UserState userState = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, para))
            {
                if (reader.Read())
                {
                    userState = new UserState();
                    userState.Id = userStateId;
                    userState.Name = reader["Name"].ToString();
                }
            }
            return userState;
        }
    }
}

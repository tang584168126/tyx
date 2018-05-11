using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserStateService
    {
        /// <summary>
        /// 根据用户状态查询状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserState GetUserStateById(int id)
        {
            string sqlText = "select * from UserRoles where Id = @Id";
            UserState userState = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, new SqlParameter("@Id", id)))
            {
                if (reader.Read())
                {
                    userState = new UserState();
                    userState.Id = (int)reader["Id"];
                    userState.Name = (string)reader["Name"];
                }
            }
            return userState;
        }
    }
}
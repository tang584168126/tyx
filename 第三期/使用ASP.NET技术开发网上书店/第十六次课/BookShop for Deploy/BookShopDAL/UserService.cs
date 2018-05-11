using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserService
    { 
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">封装的一个User对象</param>
        /// <returns>受影响的行数，1表示插入成功，0表示插入失败</returns>
        public int AddUser(User user)
        {
            //SqlParameter[] paramValues = new SqlParameter[]
            //{
            //    new SqlParameter("@LoginId", user.LoginId),
            //    new SqlParameter("@LoginPwd", user.LoginPwd),
            //    new SqlParameter("@Name", user.Name),
            //    new SqlParameter("@Address", user.Address),
            //    new SqlParameter("@Phone", user.Phone),
            //    new SqlParameter("@Mail", user.Mail),
            //    new SqlParameter("@UserStateId", user.UserState.Id),    //FK
            //    new SqlParameter("@UserRoleId", user.UserRole.Id)       //FK
            //};


            //return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, "usp_InsertRegistUser", paramValues);

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, "usp_InsertRegistUser", user.LoginId, user.LoginPwd, user.Name, user.Address, user.Phone, user.Mail, user.UserState.Id, user.UserRole.Id);
        }

        /// <summary>
        /// 根据loginId获取User
        /// </summary>
        /// <param name="loginId">登陆名</param>
        /// <returns>用户</returns>
        public User GetUserByLoginId(string loginId)
        {
            string sqlText = "select * from Users where LoginId = @LoginId";
            SqlParameter para = new SqlParameter("@LoginId",loginId);

            int userRoleId = 0;
            int userStateId = 0;
            User user = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, para))
            {
                user = new User();

                user.LoginId = reader["LoginId"].ToString();
                user.LoginPwd = reader["LoginPwd"].ToString();
                user.Name = reader["Name"].ToString();
                user.Address = reader["Address"].ToString();
                user.Phone = reader["Phone"].ToString();

                userRoleId = (int)reader["UserRoleId"];
                userStateId = (int)reader["UserStateId"];

                user.UserRole = new UserRoleService().GetUserRoleById(userRoleId);
                user.UserState = new UserStateService().GetUserStateById(userStateId);                
            }

            return user;
        }

        /// <summary>
        /// 判定用户是否已存在
        /// </summary>
        /// <returns>true表示存在，false表示不存在</returns>
        public bool LoginIdExists(string loginId)
        {
            string sqlText = "select count(*) from Users where LoginId = @LoginId";
            SqlParameter para = new SqlParameter("@LoginId",loginId);

            object result = SqlHelper.ExecuteScalar(SqlHelper.ConnectionString,CommandType.Text,sqlText,para);

            return (int)result > 0;
        }
    }
}

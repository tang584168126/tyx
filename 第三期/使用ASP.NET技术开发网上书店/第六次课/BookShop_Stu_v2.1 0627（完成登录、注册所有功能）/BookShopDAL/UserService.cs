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
        /// <param name="user">用户对象</param>
        /// <returns>true:插入成功；false:插入失败</returns>
        public bool AddUser(User user)
        {
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@LoginId",user.LoginId),
                new SqlParameter("@LoginPwd",user.LoginPwd),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Address",user.Address),
                new SqlParameter("@Phone",user.Phone),
                new SqlParameter("@Mail",user.Mail),
                new SqlParameter("@UserRoleId",user.UserRole.Id),
                new SqlParameter("@UserStateId",user.UserState.Id)
            };

            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "usp_InsertRegisterUser", paras);

            return result > 0;

          //  return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.StoredProcedure, "usp_InsertRegisterUser", user.LoginId, user.LoginPwd, user.Name, user.Address, user.Mail, user.Phone, user.UserRole.Id, user.UserState.Id) > 0;
        } 

        /// <summary>
        /// 根据用户账号获取用户对象
        /// </summary>
        /// <param name="loginId">账户名</param>
        /// <returns>用户对象</returns>
        public User GetUserByLoginId(string loginId)
        {
            string sqlText = "select * from Users where LoginId = @LoginId";
            SqlParameter para = new SqlParameter("@LoginId",loginId);

            User user = null;
            int userRoleId = 1;
            int userStateId = 1;
            using(SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text,sqlText,para))
            {
                if (reader.Read())
                {
                    user = new User();
                    user.LoginId = reader["LoginId"].ToString();
                    user.LoginPwd = reader["LoginPwd"].ToString();
                    user.Name = reader["Name"].ToString();
                    user.Address = reader["Address"].ToString();
                    user.Mail = reader["Mail"].ToString();
                    user.Phone = reader["Phone"].ToString();

                    userRoleId = Convert.ToInt32(reader["UserRoleId"]);
                    userStateId = Convert.ToInt32(reader["UserStateId"]);

                    user.UserRole = new UserRoleService().GetUserRoleById(userRoleId);
                    user.UserState = new UserStateService().GetUserStateById(userStateId);
                }
            }
            return user;
        }
    }
}

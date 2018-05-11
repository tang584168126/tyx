using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserService
    {
        /// <summary>
        /// 根据登陆名查询用户
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public User GetUserByLoginId(string loginId)
        {
            string sqlText = "select * from Users where LoginId = @LoginId";
            User user = null;
            int userRoleId = 0;
            int userStateId = 0;
            using(SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text,sqlText,new SqlParameter("@LoginId",loginId)))
            {
                if (reader.Read())
                {
                    user = new User();
                    user.Id = (int)reader["Id"];
                    user.LoginId = (string)reader["LoginId"];
                    user.LoginPwd = (string)reader["LoginPwd"];
                    user.Name = (string)reader["Name"];
                    user.Phone = (string)reader["Phone"];
                    user.Address = (string)reader["Address"];
                    user.Mail = (string)reader["Mail"];

                    //获取UserRole属性
                    userRoleId = (int)reader["UserRoleId"];
                    user.UserRole = new UserRoleService().GetUserRoleById(userRoleId);

                    //获取UserState属性
                    userStateId = (int)reader["UserStateId"];
                    user.UserState = new UserStateService().GetUserStateById(userStateId);
                }
            }
            return user;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>注册成功与否</returns>
        public bool AddUser(User user)
        {
            string sqlText = "insert Users(LoginId,LoginPwd,Name,Address,Phone,Mail,UserRoleId,UserStateId)" +
                              "values(@LoginId,@LoginPwd,@Name,@Address,@Phone,@Mail,@UserRoleId,@UserStateId)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LoginId",user.LoginId),
                new SqlParameter("@LoginPwd",user.LoginPwd),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Address",user.Address),
                new SqlParameter("@Phone",user.Phone),
                new SqlParameter("@Mail",user.Mail),
                new SqlParameter("@UserRoleId",user.UserRole.Id),
                new SqlParameter("@UserStateId",user.UserState.Id)
            };

            int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString,CommandType.Text,sqlText,para);

            if (result > 0)
            {
                return true;   //注册成功
            }
            else
            {
                return false;  //注册失败
            }
        }
    }
}
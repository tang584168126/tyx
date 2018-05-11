using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookNet.Models;
using System.Data.SqlClient;
using System.Data;

namespace BookNet.DAL
{
    public class UserSerice
    {
        /// <summary>
        /// 根据权限编号获取用户对象
        /// </summary>
        /// <param name="roleId">权限编号</param>
        /// <returns>用户对象</returns>
        public List<User> GetAllUsers(int roleId)
        {
            List<User> list = new List<User>();
            string sqlText = "select * from [Users] where UserRoleId = " + roleId;
            int userRoleId = 1;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.UserId = reader["UserId"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Name = reader["Name"].ToString();
                    user.Integral = Convert.ToInt32(reader["Integral"]);
                    user.Date = Convert.ToDateTime(reader["Date"]);
                    user.Phone = reader["Phone"].ToString();
                    user.Address = reader["Address"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.HeadPortrait = reader["HeadPortrait"].ToString();
                    userRoleId = Convert.ToInt32(reader["UserRoleId"]);

                    user.UserRole = new UserRoleService().GetUserRoleById(userRoleId);

                    list.Add(user);
                }
            }

            return list;
        }

        /// <summary>
        /// 根据用户账号获得用户信息
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public User GetUserById(string loginId)
        {
            string sqlText = "select * from [Users] where LoginId = " + loginId;
            User user = null;
            int userRoleId = 1;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    user = new User();
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.UserId = reader["UserId"].ToString();
                    user.Password = reader["Password"].ToString();
                    user.Name = reader["Name"].ToString();
                    user.Integral = Convert.ToInt32(reader["Integral"]);
                    user.Date = Convert.ToDateTime(reader["Date"]);
                    user.Phone = reader["Phone"].ToString();
                    user.Address = reader["Address"].ToString();
                    user.Email = reader["Email"].ToString();
                    user.HeadPortrait = reader["HeadPortrait"].ToString();
                    userRoleId = Convert.ToInt32(reader["UserRoleId"]);

                    user.UserRole = new UserRoleService().GetUserRoleById(userRoleId);
                }
            }
            return user;
        }

        public int AddUser(User user)
        {
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@UserId",user.UserId),
                new SqlParameter("@Password",user.Password),
                new SqlParameter("@Name",user.Name),
                new SqlParameter("@Date",user.Date),
                new SqlParameter("@Phone",user.Phone),
                new SqlParameter("@Address",user.Address),
                new SqlParameter("@Email",user.Email),
                new SqlParameter("@Integral",user.Integral),
                new SqlParameter("@UserRoleId",user.UserRole.Id),
                new SqlParameter("@HeadPortrait",user.HeadPortrait)
            };

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString,CommandType.StoredProcedure,"usp_InsertUser",paras);
        }
    }
}

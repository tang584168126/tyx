using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookShop.Models;
using System.Data.SqlClient;
using System.Data;

namespace BookShop.DAL
{
    public class UserService
    {
        /// <summary>
        /// 获取用户对象
        /// </summary>
        /// <returns></returns>
        public List<User> getUsers()
        {
            string sqlText = "select * from Users";

            List<User> list = new List<User>();

            User user = null;

            int userRole = 1;
            int userState = 1;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text, sqlText))
            {
                while (dr.Read())
                {
                    user = new User();
                    user.Id = Convert.ToInt32(dr["Id"]);
                    user.LoginId = dr["LoginId"].ToString();
                    user.Address = dr["Address"].ToString();
                    user.Mail = dr["Mail"].ToString();
                    user.Name = dr["Name"].ToString();
                    user.Phone = dr["Phone"].ToString();
                    user.LoginPwd = dr["LoginPwd"].ToString();

                    userRole = Convert.ToInt32(dr["UserRoleId"]);
                    userState = Convert.ToInt32(dr["UserState"]);

                    user.UserRole = new UserRoleService().getUserRole(userRole);
                    user.UserState = new UserStateService().getUserState(userState);

                    list.Add(user);
                }
            }
            return list;
        }

        /// <summary>
        /// 根据用户账号获取用户对象
        /// </summary>
        /// <param name="loginId">用户账号</param>
        /// <returns>用户对象</returns>
        public User GetUserByLoginId(string loginId)
        {
            string sqlText = "select * from [Users] where LoginId = " + loginId;
            User user = null;

            int userRole = 1;
            int userState = 1;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (dr.Read())
                {
                    user = new User();
                    user.Id = Convert.ToInt32(dr["Id"]);
                    user.LoginId = dr["LoginId"].ToString();
                    user.Address = dr["Address"].ToString();
                    user.Mail = dr["Mail"].ToString();
                    user.Name = dr["Name"].ToString();
                    user.Phone = dr["Phone"].ToString();
                    user.LoginPwd = dr["LoginPwd"].ToString();

                    userRole = Convert.ToInt32(dr["UserRoleId"]);
                    userState = Convert.ToInt32(dr["UserState"]);

                    user.UserRole = new UserRoleService().getUserRole(userRole);
                    user.UserState = new UserStateService().getUserState(userState);
                }
            }
            return user;
        }

        /// <summary>
        /// 根据用户编号获取相对应的用户对象
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>用户对象</returns>
        public List<User> GetUsersById(int id)
        {
            string sqlText = "select * from [Users] where Id = " + id;
            List<User> list = new List<User>();

            User user = null;

            int userRole = 1;
            int userState = 1;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                while (dr.Read())
                {
                    user = new User();
                    user.Id = Convert.ToInt32(dr["Id"]);
                    user.LoginId = dr["LoginId"].ToString();
                    user.Address = dr["Address"].ToString();
                    user.Mail = dr["Mail"].ToString();
                    user.Name = dr["Name"].ToString();
                    user.Phone = dr["Phone"].ToString();
                    user.LoginPwd = dr["LoginPwd"].ToString();

                    userRole = Convert.ToInt32(dr["UserRoleId"]);
                    userState = Convert.ToInt32(dr["UserState"]);

                    user.UserRole = new UserRoleService().getUserRole(userRole);
                    user.UserState = new UserStateService().getUserState(userState);

                    list.Add(user);
                }
            }
            return list;
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(User user)
        {
            string sqlText = "insert into [Users] (LoginId,LoginPwd,Name,Address,Phone,Mail,UserRoleId,UserStateId) "
                + " values ('{0}','{1}','{2}','{3}','{4}','{5}',{6},{7})" + user.LoginId + "," + user.LoginPwd + "," + user.Name + "," + user.Address + "," + user.Phone + "," + user.Mail + "," + user.UserRole.Id + "," + user.UserState.Id;

            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRent.Model;
using System.Data.SqlClient;

namespace HouseRent.DAL
{
    public class UserService
    {
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<User> GetAll()
        {
            string sqlText = "select * from [User]";
            List<User> list = new List<User>();
            User user = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, sqlText))
            {
                user = new User();
                user.LoginId = Convert.ToInt32(reader["LognId"]);
                user.LoginName = reader["LoginName"].ToString();
                user.Password = reader["Password"].ToString();
                user.Telephone = reader["Telephone"].ToString();
                list.Add(user);
            }
            return list;
        }

        /// <summary>
        /// 根据用户名获取用户
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <returns>用户</returns>
        public User GetUserByName(string loginName)
        {
            string sqlText = "select * from [User] where LoginName = " + loginName;
            User user = null;
            using(SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,sqlText))
            {
                user = new User();
                user.LoginId = Convert.ToInt32(reader["LognId"]);
                user.LoginName = reader["LoginName"].ToString();
                user.Password = reader["Password"].ToString();
                user.Telephone = reader["Telephone"].ToString();
            }
            return user;
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>true:新增成功 false:新增失败</returns>
        public bool AddUser(User user)
        {
            string sqlText = "insert into [User] (LoginName,UserName,Password,Telephone)"
                + " values ('{0}','{1}','{2}','{3}')," + user.LoginName + "," + user.UserName + "," + user.Password + "," + user.Telephone;
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString, sqlText) > 0;
        }
    }
}

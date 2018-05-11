using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QnRenting.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace QnRenting.DAL
{
    public class UserService
    {
        /// <summary>
        /// 根据用户登录账号获取用户对象
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public User GetUserByLoginId(string loginName)
        {
            string sqlText = "select * from [User] where LoginName = " + loginName;

            User user = null;

            using(SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text,sqlText))
            {
                if(reader.Read())
                {
                    user = new User();
                    user.LoginId = Convert.ToInt32(reader["LoginId"]);
                    user.LoginName = reader["LoginName"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Telephone = reader["Telephone"].ToString();
                    user.UserName = reader["UserName"].ToString();
                }
            }
            return user;
        }

    }
}

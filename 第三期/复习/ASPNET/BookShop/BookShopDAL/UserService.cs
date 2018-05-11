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
        public List<User> getUsers()
        {
            string sqlText = "select * from Users";

            List<User> list = new List<User>();

            User user = null;

            using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text, sqlText))
            {
                while (dr.Read())
                {
                    user = new User();
                    user.Id = Convert.ToInt32(dr["Id"]);
                    user.LoginId = dr["LoginId"].ToString();
                }
            }
        }
    }
}

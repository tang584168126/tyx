using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserRoleService
    {
        /// <summary>
        /// 根据用户角色编号获得用户角色对象
        /// </summary>
        /// <param name="id">用户角色编号</param>
        /// <returns>用户角色对象</returns>
        public UserRole getUserRole(int id)
        {
            string sqlText = "select * from [UserRoles] where Id =" + id;

            UserRole userRole = null;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText))
            {
                if (reader.Read())
                {
                    userRole = new UserRole();
                    userRole.Id = Convert.ToInt32(reader["Id"]);
                    userRole.Name = reader["Name"].ToString();
                } 
            }
            return userRole;
        }
    }
}

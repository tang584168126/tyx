using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserRoleService
    {
        /// <summary>
        /// 根据角色编号查询角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UserRole GetUserRoleById(int id)
        {
            string sqlText = "select * from UserRoles where Id = @Id";
            UserRole userRole = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, new SqlParameter("@Id", id)))
            {
                if (reader.Read())
                {
                    userRole = new UserRole();
                    userRole.Id = (int)reader["Id"];
                    userRole.Name = (string)reader["Name"];
                }
            }
            return userRole;
        }
    }   
}
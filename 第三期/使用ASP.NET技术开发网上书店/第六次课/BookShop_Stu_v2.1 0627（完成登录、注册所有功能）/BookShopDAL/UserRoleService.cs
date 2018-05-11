using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserRoleService
    {
        /// <summary>
        /// 根据角色编号获取角色对象
        /// </summary>
        /// <param name="loginId">角色编号</param>
        /// <returns>角色对象</returns>
        public UserRole GetUserRoleById(int id)
        {
            string sqlText = "select * from UserRoles where Id = @Id";
            SqlParameter para = new SqlParameter("@Id", id);

            UserRole userRole = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, para))
            { 
                if(reader.Read())
                {
                    userRole = new UserRole();
                    userRole.Id = id;
                    userRole.Name = reader["Name"].ToString();
                }
            }
            return userRole;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using BookShop.Models;

namespace BookShop.DAL
{
    public class UserRoleService
    {
        /// <summary>
        /// 根据UserRoleId获取UserRole
        /// </summary>
        /// <param name="userRoleId">用户角色编号</param>
        /// <returns>用户角色对象</returns>
        public UserRole GetUserRoleById(int userRoleId)
        {
            string sqlText = "select * from UserRoles where Id = @UserRoleId";
            SqlParameter para = new SqlParameter("@UserRoleId",userRoleId);

            UserRole userRole = null;
            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString, CommandType.Text, sqlText, para))
            {
                if (reader.Read())
                {
                    userRole = new UserRole();
                    userRole.Id = userRoleId;
                    userRole.Name = reader["Name"].ToString();
                }     
            }
            return userRole;
        }
    }
}

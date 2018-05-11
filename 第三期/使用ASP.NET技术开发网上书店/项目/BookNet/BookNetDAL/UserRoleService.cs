using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookNet.Models;
using System.Data;
using System.Data.SqlClient;

namespace BookNet.DAL
{
    public class UserRoleService
    {
        /// <summary>
        /// 根据权限编号查询权限对象
        /// </summary>
        /// <param name="id">权限编号</param>
        /// <returns>权限对象</returns>
        public UserRole GetUserRoleById(int id)
        {
            string sqlText = "select * from [UserRoles] where Id = " + id;

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

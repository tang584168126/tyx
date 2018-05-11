using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusAcademy.Models;
using System.Data;
using System.Data.SqlClient;

namespace FocusAcademy.DAL
{
    public class FocusAdminService
    {
        /// <summary>
        /// 根据管理员账号获取管理员对象
        /// </summary>
        /// <param name="adminId">管理员账号</param>
        /// <returns>管理员对象</returns>
        public FocusAdmin GetAdminById(string adminId)
        {
            FocusAdmin admin = null;
            string sqlText = "select * from [FocusAdmin] where AdminId = " + adminId;

            using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.ConnectionString,CommandType.Text, sqlText))
            {
                admin = new FocusAdmin();
                if(reader.Read())
                {
                    admin.AdminId = Convert.ToInt32(adminId);
                    admin.AdminPassword = reader["AdminPassword"].ToString();
                    admin.AdminName = reader["AdminName"].ToString();
                }
                
            }
            return admin;
        }
    }
}

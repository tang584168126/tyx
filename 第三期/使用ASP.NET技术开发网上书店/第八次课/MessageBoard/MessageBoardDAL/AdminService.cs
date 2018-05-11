using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageBoard.Models;

namespace MessageBoard.DAL
{
    public class AdminService
    {
        /// <summary>
        /// 验证登录
        /// </summary>
        /// <param name="adminName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>true 登录成功；false,登录失败</returns>
        public bool AdminLogin(string adminName, string password)
        {
            string sql = "SELECT COUNT(0) FROM TBL_ADMIN WHERE adminName=@adminName AND password=@password";
            SqlParameter[] values = new SqlParameter[]
			{
				new SqlParameter("@adminName", adminName), 
				new SqlParameter("@password", password)
            };
            int result = (int)SqlHelper.ExecuteScalar(SqlHelper.ConnectionString, sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}

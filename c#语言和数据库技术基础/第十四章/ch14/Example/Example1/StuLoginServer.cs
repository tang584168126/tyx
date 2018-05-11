using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Example1
{
    /// <summary>
    /// 登录操作类
    /// </summary>
    public class StuLoginServer
    {
        #region 字段

        #endregion

        #region 属性
       
        #endregion

        #region 方法
        /// <summary>
        /// 登录系统
        /// </summary>
        /// <returns>登录结果(true:登录成功 false:登录失败)</returns>
        public bool LoginServer()
        {
            #region 设置变量
            bool result = false;
            string stuName = string.Empty;      //登录名
            string stuPwd = string.Empty;       //登录密码
            #endregion

            #region  登录操作
            Console.Write("请输入用户名：");
            stuName = Console.ReadLine();
            Console.Write("请输入密码：");
            stuPwd = Console.ReadLine();
           
            //连接数据库
            string sql = @"Data Source = TANG;Initial Catalog = MySchool182;User ID = sa ; Pwd = 123";
            
            SqlConnection objSqlConn = new SqlConnection(sql);
            //记录SQL语句
            string SqlText = string.Format("select count(*) from Student where StudentNo = {0} AND LoginPwd = '{1}'",stuName,stuPwd );
            SqlCommand objSqlComm = new SqlCommand(SqlText,objSqlConn);
            try
            {
                objSqlConn.Open();
                //记录SQL返回值
                int count = (int)objSqlComm.ExecuteScalar();
                if (count == 1)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch
            {
                Console.WriteLine("未能连接数据库，请联系管理员！");
            }
            finally
            {
                objSqlConn.Close();
            }
            #endregion
            return result;
        }
        #endregion
    }
}

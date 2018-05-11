using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Configuration;

//引用命名空间
using System.Data.Sql;
using System.Data.SqlClient;

namespace MySchoolDAL
{
    /// <summary>
    /// 数据交互工具类
    /// </summary>
    public class Sql_Helper
    {
        static Sql_Helper()
        {
            //判断App.config中是否有数据库连接字符串
            if (ConfigurationManager.ConnectionStrings["connString"] != null)
            {
                //从App.config中读取数据库连接字符串
                sql = ConfigurationManager.ConnectionStrings["connString"].ToString();
            }
            else
            {
                sql = @"Data Source = TANG;Initial Catalog = MySchool182;User ID=sa;Pwd=123";
            }
        }
        #region 字段
        //数据库连接字符串
        private static string sql = string.Empty;

        //连接对象
        private static SqlConnection objSqlConn;

        //执行对象
        private static SqlCommand objSqlComm;

        //数据集
        private static SqlDataAdapter dataAdapter = new SqlDataAdapter();
        #endregion

        #region 属性

        #endregion

        #region 方法
        #region 数据库打开与关闭
        /// <summary>
        /// 数据库打开
        /// </summary>
        private static void OpenConn()
        {
            try
            {
                objSqlConn = new SqlConnection(sql);

                objSqlConn.Open();
            }
            catch(Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
        }

        /// <summary>
        /// 数据库关闭
        /// </summary>
        private static void CloseConn()
        {
            objSqlConn.Close();
        }
        #endregion

        #region 查询数据
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sqlTest">SQL命令</param>
        /// <returns>数据集</returns>
        public static DataSet GetDataSet(string sqlText)
        {
            DataSet objDS = new DataSet();

            try
            {
                //打开数据库连接
                OpenConn();

                //创建执行对象
                objSqlComm = new SqlCommand(sqlText, objSqlConn);

                //创建数据适配器
                dataAdapter.SelectCommand = objSqlComm;

                //填充DataSet
                dataAdapter.Fill(objDS);
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
            finally
            { 
                //关闭数据库连接
                CloseConn();
            }
            return objDS;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sqlText">SQL命令</param>
        /// <param name="paras">SQL参数</param>
        /// <returns>数据集</returns>
        public static DataSet GetDataSet(String sqlText, SqlParameter[] paras)
        {
            DataSet objDS = new DataSet();

            try
            {
                //打开数据库连接
                OpenConn();

                //创建执行对象
                objSqlComm = new SqlCommand(sqlText,objSqlConn);
                if(paras != null && paras.Length > 0)
                {
                    for (int i = 0; i < paras.Length; i++ )
                    {
                        objSqlComm.Parameters.AddWithValue(paras[i].ParameterName,paras[i].Value);
                    }
                }

                //创建数据适配器
                dataAdapter.SelectCommand = objSqlComm;

                //填充DataSet
                dataAdapter.Fill(objDS);
            }
            catch(Exception Exp)
            {
                throw new Exception(Exp.Message);
            }

            return objDS;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="sqlText">存储过程名称</param>
        /// <returns>数据集</returns>
        public static DataSet GetDataSetByProce(String sqlText)
        {
            DataSet objDS = new DataSet();

            try
            {
                //打开数据库连接
                OpenConn();

                //创建执行对象
                objSqlComm = new SqlCommand(sqlText, objSqlConn);

                //设置执行对象名称
                objSqlComm.CommandType = CommandType.StoredProcedure;

                //填充DataSet
                dataAdapter.Fill(objDS);
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
            finally
            { 
                //关闭数据库连接
                CloseConn();
            }

            return objDS;
        }

        /// <summary>
        /// 数据查询
        /// </summary>
        /// <param name="sqlText">存储过程名称</param>
        /// <param name="paras">存储过程参数</param>
        /// <returns>数据集</returns>
        public static DataSet GetDataSetByProce(String sqlText, SqlParameter[] paras)
        {
            DataSet objDS = new DataSet();

            try
            {
                //打开数据库连接
                OpenConn();

                //创建执行对象
                objSqlComm = new SqlCommand(sqlText, objSqlConn);

                //设置执行对象类别
                objSqlComm.CommandType = CommandType.StoredProcedure;

                if(paras != null && paras.Length >0)
                {
                    objSqlComm.Parameters.AddRange(paras);
                }

                //创建数据适配器
                dataAdapter.SelectCommand = objSqlComm;

                //填充DataSet
                dataAdapter.Fill(objDS);
            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
            finally
            {
                //关闭数据库连接
                CloseConn();
            }

            return objDS;
        }
        #endregion

        #region 数据操作
        /// <summary>
        /// 操作数据
        /// </summary>
        /// <param name="sqlText">SQL命令</param>
        public static void ExecuteData(string sqlText)
        { 
        
        }

        /// <summary>
        /// 操作数据
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="paras"></param>
        public static void ExecuteData(string sqlText, SqlParameter[] paras)
        { 
        
        }

        /// <summary>
        /// 操作数据
        /// </summary>
        /// <param name="sqlText">存储过程名称</param>
        public static void ExecuteDataByProce(string sqlText)
        { 
            SqlTransaction objSqlTran = null;
            //开始事物
            objSqlTran = objSqlConn.BeginTransaction();

            //创建执行对象
            objSqlComm = new SqlCommand(sqlText, objSqlConn);

        }

        /// <summary>
        /// 操作数据
        /// </summary>
        /// <param name="sqlText">存储过程名称</param>
        /// <param name="paras">存储过程参数</param>
        public static void ExecuteDataByProce(string sqlText, SqlParameter[] paras)
        {

        }
        #endregion
        #endregion
    }
}

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
    /// 学生操作类
    /// </summary>
    public class StuManageServer
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 展示学生信息
        /// </summary>
        public void ShowStu()
        {
            string sql = @"Data Source = TANG ; Initial Catalog = MySchool182 ; User ID = sa ;Pwd = 123";

            SqlConnection objSqlConn = new SqlConnection(sql);

            string sqlText = "select StudentNO ,StudentName,Sex,GradeId,Phone,BornDate,Address,Email from Student";

            SqlCommand objSqlComm = new SqlCommand(sqlText, objSqlConn);

            try
            {
                objSqlConn.Open();

                SqlDataReader dataReader = objSqlComm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        #region 设置变量
                        string stuStudentNO = string.Empty;
                        string stuStudentName = string.Empty;
                        string stuSex = string.Empty;
                        string stuGradeId = string.Empty;
                        string stuPhone = string.Empty;
                        string stuBornDate = string.Empty;
                        string stuAddress = string.Empty;
                        string stuEmail = string.Empty;
                        #endregion

                        #region 读取数据
                        stuStudentNO = dataReader[0].ToString();
                        stuStudentName = dataReader[1].ToString();
                        stuSex = dataReader[2].ToString();
                        stuGradeId = dataReader[3].ToString();
                        stuPhone = dataReader[4].ToString();
                        stuBornDate = dataReader[5].ToString();
                        stuAddress = dataReader[6].ToString();
                        stuEmail = dataReader[7].ToString();
                        #endregion

                        Console.WriteLine(stuStudentNO + "\t" + stuStudentName + "\t" + stuSex + "\t" + stuGradeId + "\t" + stuPhone + "\t" + stuBornDate + "\t" + stuAddress + "\t" + stuEmail);

                        
                    }
                }

                dataReader.Close();
                objSqlConn.Close();

            }
            catch
            {
                Console.WriteLine("连接数据库失败，请联系管理员！");
            }
            finally
            {
                
                objSqlConn.Close();
            }

        }

        /// <summary>
        /// 新增学生信息
        /// </summary>
        public void InsertStu()
        {
            #region 设置变量
            int strStudentNO = 0;
            string strLoginPwd = string.Empty;
            string strStudentName = string.Empty;
            string strSex = string.Empty;
            int intGradeId = 0;
            string strPhone = string.Empty;
            string strBornDate = string.Empty;
            string strAddress = string.Empty;
            string strEmail = string.Empty;
            string strIDENTITYCard = string.Empty;

            Console.Write("请输入学号：");
            strStudentNO = int.Parse(Console.ReadLine());

            Console.Write("请输入密码：");
            strLoginPwd = Console.ReadLine();

            Console.Write("请输入姓名：");
            strStudentName = Console.ReadLine();

            Console.Write("请输入性别：(0/1)");
            strSex = Console.ReadLine();

            Console.Write("请输入年级：");
            intGradeId = int.Parse(Console.ReadLine());

            Console.Write("请输入电话号码：");
            strPhone = Console.ReadLine();

            Console.Write("请输入出生日期：(yyyy-mm-dd)");
            strBornDate = Console.ReadLine();

            Console.Write("请输入地址：");
            strAddress = Console.ReadLine();

            Console.Write("请输入Email：");
            strEmail = Console.ReadLine();
            #endregion

            #region 数据验证

            #endregion

            #region 新增操作
            string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

            SqlConnection objSqlConn = new SqlConnection(sql);

            StringBuilder sqlText = new StringBuilder();
            sqlText.AppendFormat(" insert into Student");
            sqlText.AppendFormat(" (StudentNO,LoginPwd,StudentName,Sex,GradeId,Phone,BornDate,Address,Email,IDENTITYCard)");
            sqlText.AppendFormat(" values ({0},'{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}','{9}')",strStudentNO, strLoginPwd, strStudentName, strSex, intGradeId, strPhone, Convert.ToDateTime(strBornDate), strAddress, strEmail, strStudentNO);

            SqlCommand objSqlComm = new SqlCommand(sqlText.ToString(),objSqlConn);

            try
            {
                objSqlConn.Open();
                //记录SQL返回值
                int count = objSqlComm.ExecuteNonQuery();
                if (count == 1)
                {
                    Console.WriteLine("新增成功！");
                }
                else
                {
                    Console.WriteLine("新增失败！");
                    
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

        }

        /// <summary>
        /// 更新学生信息
        /// </summary>
        public void UpdateStu()
        {
            #region 设置变量
            int strStudentNO = 0;
            string strLoginPwd = string.Empty;
            string strStudentName = string.Empty;
            string strSex = string.Empty;
            int intGradeId = 0;
            string strPhone = string.Empty;
            string strBornDate = string.Empty;
            string strAddress = string.Empty;
            string strEmail = string.Empty;
            string strIDENTITYCard = string.Empty;

            Console.Write("请输入学号：");
            strStudentNO = int.Parse(Console.ReadLine());

            Console.Write("请输入密码：");
            strLoginPwd = Console.ReadLine();

            Console.Write("请输入姓名：");
            strStudentName = Console.ReadLine();

            Console.Write("请输入性别：(0/1)");
            strSex = Console.ReadLine();

            Console.Write("请输入年级：");
            intGradeId = int.Parse(Console.ReadLine());

            Console.Write("请输入电话号码：");
            strPhone = Console.ReadLine();

            Console.Write("请输入出生日期：(yyyy-mm-dd)");
            strBornDate = Console.ReadLine();

            Console.Write("请输入地址：");
            strAddress = Console.ReadLine();

            Console.Write("请输入Email：");
            strEmail = Console.ReadLine();
            #endregion

            #region 数据验证

            #endregion

            #region 更新操作
            string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

            SqlConnection objSqlConn = new SqlConnection(sql);

            StringBuilder sqlText = new StringBuilder();
            sqlText.AppendFormat(" update Student into");
            sqlText.AppendFormat(" LoginPwd = {0},StudentName = {1},Sex = {2},GradeId = {3},Phone = {4},BornDate = {5},Address = {6},Email = {7}", strLoginPwd, strStudentName, strSex, intGradeId, strPhone,Convert.ToDateTime(strBornDate),strAddress,strEmail);
            sqlText.AppendFormat(" where StudentNO = {0}", strStudentNO);

            SqlCommand objSqlComm = new SqlCommand(sqlText.ToString(), objSqlConn);

            try
            {
                objSqlConn.Open();
                //记录SQL返回值
                int count = objSqlComm.ExecuteNonQuery();
                if (count == 1)
                {
                    Console.WriteLine("更新成功！");
                }
                else
                {
                    Console.WriteLine("更新失败！");

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

        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        public void DeleteStu()
        {
            #region 设置变量
            int strStudentNO = 0;
            /*string strLoginPwd = string.Empty;
            string strStudentName = string.Empty;
            string strSex = string.Empty;
            int intGradeId = 0;
            string strPhone = string.Empty;
            string strBornDate = string.Empty;
            string strAddress = string.Empty;
            string strEmail = string.Empty;
            string strIDENTITYCard = string.Empty;*/

            Console.Write("请输入学号：");
            strStudentNO = int.Parse(Console.ReadLine());

           /* Console.Write("请输入密码：");
            strLoginPwd = Console.ReadLine();

            Console.Write("请输入姓名：");
            strStudentName = Console.ReadLine();

            Console.Write("请输入性别：(0/1)");
            strSex = Console.ReadLine();

            Console.Write("请输入年级：");
            intGradeId = int.Parse(Console.ReadLine());

            Console.Write("请输入电话号码：");
            strPhone = Console.ReadLine();

            Console.Write("请输入出生日期：(yyyy-mm-dd)");
            strBornDate = Console.ReadLine();

            Console.Write("请输入地址：");
            strAddress = Console.ReadLine();

            Console.Write("请输入Email：");
            strEmail = Console.ReadLine();*/
            #endregion

            #region 数据验证

            #endregion

            #region 删除操作
            string sql = @"Data Source = TANG; Initial Catalog = MySchool182; User ID = sa; Pwd = 123";

            SqlConnection objSqlConn = new SqlConnection(sql);

            StringBuilder sqlText = new StringBuilder();
            sqlText.AppendFormat(" select from student where StudentNO = {0}", strStudentNO);
            
            SqlCommand objSqlComm = new SqlCommand(sqlText.ToString(), objSqlConn);

            try
            {
                objSqlConn.Open();
                //记录SQL返回值
                int count = objSqlComm.ExecuteNonQuery();
                if (count == 1)
                {
                    Console.WriteLine("删除成功！");
                }
                else
                {
                    Console.WriteLine("删除失败！");

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

        }
        #endregion
    }
}

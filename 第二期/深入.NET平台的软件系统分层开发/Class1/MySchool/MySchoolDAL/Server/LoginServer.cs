using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using MySchoolModel;

namespace MySchoolDAL
{
    /// <summary>
    /// 登陆数据交互层
    /// </summary>
    public class LoginServer
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 登陆系统
        /// </summary>
        /// <param name="objStuEntity">学生实体类对象</param>
        /// <returns>登陸是否成功</returns>
        public bool LoginSys(StudentEntity objStuEntity)
        {
            bool result = false;

            try
            {
                #region SQL命令
                ////SQL命令
                //string sqlText = " select count(*) from Student where StudentNo = @StudentNo and LoginPwd = @LoginPwd";
                //SqlParameter[] paras = new SqlParameter[2];
                //paras[0] = new SqlParameter("@StudentNo", SqlDbType.Int);
                //paras[0].Value = objStuEntity.StudentNo;
                //paras[1] = new SqlParameter("@LoginPwd", SqlDbType.NVarChar);
                //paras[1].Value = objStuEntity.LoginPwd;

                //DataSet objDS = Sql_Helper.GetDataSet(sqlText,paras);

                ////判断数据集是否为空
                //if(objDS != null)
                //{
                //    //判断登陆是否成功
                //    if(int.Parse(objDS.Tables[0].Rows[0][0].ToString()) > 0)
                //    {
                //        result = true;
                //    }
                //}
                #endregion

                #region 存储过程
                //存储过程名
                string sqlText = "usp_SysLogin";

                //存储过程参数
                SqlParameter[] paras = new SqlParameter[3];
                paras[0] = new SqlParameter["@StuNo", SqlDbType.Int];
                paras[0].Value = objStuEntity.StudentNo;
                paras[1] = new SqlParameter["@LoginPwd",SqlDbType.NVarChar];
                paras[1].Value = objStuEntity.LoginPwd;
                paras[2] = new SqlParameter["@Count",SqlDbType.Int];
                paras[2].Direction = ParameterDirection.Output;

                //执行存储过程
                Sql_Helper.ExecuteDataByProce(sqlText, paras);

                //判断登陆是否成功
                if(int.Parse(paras[2].Value.ToString()) > 0 )
                {
                    result = true;
                }
                #endregion
            }
            catch(Exception EXP)
            {
                throw new Exception(EXP.Message);
            }

            return result;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MySchoolModel;

namespace MySchoolDAL.Server
{
    /// <summary>
    /// 学生业务逻辑类
    /// </summary>
    public class StudentServer
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 新增学员信息
        /// </summary>
        /// <param name="objStuEnity">学生学生类对象</param>
        /// <returns>是否新增成功（false:失败；true:成功）</returns>
        public bool InsertStudent(StudentEntity objStuEnity)
        {
            bool result = false;

            try
            {
                //SQL命令
                string sqlText = " insert into Student (StudentNo,LoginPwd,StudentName,Sex,GradeId,Phone,BornDate,Address,Email,IDENTITYCard ) values ({})";
                                

                //SQL参数
                SqlParameter[] paras = new SqlParameter[10];
                paras[0] = new SqlParameter("@StudentNo",SqlDbType.Int);
                paras[0].Value = objStuEnity.StudentNo;
                paras[1] = new SqlParameter("@LoginPwd",SqlDbType.NVarChar);
                paras[1].Value = objStuEnity.LoginPwd;
                paras[2] = new SqlParameter("@StudentName",SqlDbType.NVarChar);
                paras[2].Value = objStuEnity.StudentName;
                paras[3] = new SqlParameter("@Sex", SqlDbType.Bit);
                paras[3].Value = objStuEnity.Sex;
                paras[4] = new SqlParameter("@GradeId",SqlDbType.Int);
                paras[4].Value = objStuEnity.GradeId;
                paras[5] = new SqlParameter("@Phone",SqlDbType.NVarChar);
                paras[5].Value = objStuEnity.Phone;
                paras[6] = new SqlParameter("@BornDate",SqlDbType.DateTime);
                paras[6].Value = objStuEnity.BornDate;
                paras[7] = new SqlParameter("@Address",SqlDbType.NVarChar);
                paras[7].Value =objStuEnity.Adress;
                paras[8] = new SqlParameter("@Email",SqlDbType.NVarChar);
                paras[8].Value = objStuEnity.Email;
                paras[9] = new SqlParameter("@IDENTITYCard",SqlDbType.NVarChar);
                paras[9].Value = objStuEnity.IndentityCard;

                //执行SQL命令
                Sql_Helper.GetDataSet(sqlText, paras);

                result = true;
            }
            catch(Exception Exp)
            {
                throw new Exception(Exp.Message);
            }
            return result;
        }
        #endregion
    }

    
}

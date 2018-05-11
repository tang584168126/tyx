using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySchoolDAL.Server;
using MySchoolModel;
using MySchoolTool;

namespace MySchoolBLL
{
    /// <summary>
    /// 学生数据交互类
    /// </summary>
    public class StudentBLL
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
                //密码加密
                objStuEnity.LoginPwd = Encrypt_Helper.GetPwdMD5(objStuEnity.LoginPwd);

                result = new StudentServer().InsertStudent(objStuEnity);
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

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
    /// 学生业务逻辑类
    /// </summary>
    public class StudentBLL
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 新增学生信息
        /// </summary>
        /// <param name="objStuEntity">学生实体类对象</param>
        /// <returns>是否新增成功(true:成功 false:失败)</returns>
        public bool InsertStudent(StudentEntity objStuEntity)
        {
            bool result = false;

            try
            {
                //密码加密
                objStuEntity.LoginPwd = Encrypt_Helper.GetPwdByMD5(objStuEntity.LoginPwd);

                result = new StudentServer().InsertStudent(objStuEntity);

            }
            catch (Exception Exp)
            {
                throw new Exception(Exp.Message);
            }

            return result;
        }
        #endregion
    }
}

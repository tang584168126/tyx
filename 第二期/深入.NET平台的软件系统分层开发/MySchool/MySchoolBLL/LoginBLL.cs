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
    /// 登录逻辑类
    /// </summary>
    public class LoginBLL
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 登录系统
        /// </summary>
        /// <param name="objStuEntity">学生实体类对象</param>
        /// <returns>登录是否成功</returns>
        public bool LoginSys(StudentEntity objStuEntity)
        {
            bool result = false;

            try
            {
                //密码加密
                objStuEntity.LoginPwd = Encrypt_Helper.GetPwdByMD5(objStuEntity.LoginPwd);

                result = new LoginServer().LoginSys(objStuEntity);
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

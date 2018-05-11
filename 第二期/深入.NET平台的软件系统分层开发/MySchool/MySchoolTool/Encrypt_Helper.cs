using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace MySchoolTool
{
    /// <summary>
    /// 加密类
    /// </summary>
    public class Encrypt_Helper
    {
        #region 字段

        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// MD5加密方式
        /// </summary>
        /// <param name="strPwd">需要加密的密码</param>
        /// <returns>加密后的密码</returns>
        public static string GetPwdByMD5(string strPwd)
        {
            StringBuilder objBuilder = new StringBuilder();

            //创建MD5类对象
            MD5 objMD5 = new MD5CryptoServiceProvider();

            byte[] data = System.Text.Encoding.Default.GetBytes(strPwd);

            byte[] md5Data = objMD5.ComputeHash(data);

            //组建加密后密码
            for (int i = 0; i < md5Data.Length - 1; i++)
            {
                objBuilder.Append(md5Data[i].ToString("X2"));
            }

            return objBuilder.ToString();
        }
        #endregion
    }
}

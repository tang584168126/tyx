using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystem
{
    /// <summary>
    /// 登录操作类
    /// </summary>
    public class LoginServer
    {
        #region 字段
        //超市用户列表
        private UserInfo[] objUserInfoList = new UserInfo[30];
        #endregion

        #region 属性

        #endregion

        #region 方法
        /// <summary>
        /// 初始化用户
        /// </summary>
        public void InitialUser()
        {
            objUserInfoList[0] = new UserInfo();
            objUserInfoList[0].Name = "10001";
            objUserInfoList[0].Password = "0000";
            objUserInfoList[0].Type = "1";

            objUserInfoList[1] = new UserInfo();
            objUserInfoList[1].Name = "10011";
            objUserInfoList[1].Password = "1111";
            objUserInfoList[1].Type = "2";
        }

        /// <summary>
        /// 登录操作
        /// </summary>
        /// <returns>超市用户的用户类别</returns>
        public string LoginSys()
        {
            string result = string.Empty;

            //登录状态(true为登录成功,false为登录失败)
            bool isLogin = false;

            do
            {
                #region 设置变量
                //用户名称
                string strName = string.Empty;

                //用户密码
                string strPassWord = string.Empty;

                Console.Write("请输入用户名称:");
                strName = Console.ReadLine();
                Console.Write("请输入用户密码:");
                strPassWord = Console.ReadLine();
                #endregion

                #region 登录操作
                for (int i = 0; i < this.objUserInfoList.Length; i++)
                {
                    //判断数组元素是否存在
                    if (this.objUserInfoList[i] != null && this.objUserInfoList[i].Name.Equals(strName) && this.objUserInfoList[i].Password.Equals(strPassWord))
                    {
                        //登录成功，记录用户类别
                        result = this.objUserInfoList[i].Type;

                        //更改登录状态
                        isLogin = true;

                        //结束登录操作
                        break;
                    }
                }

                if (!isLogin)
                {
                    Console.WriteLine("不存在此用户,请确认后重新输入!");
                }
                #endregion

            } while (!isLogin);

            return result;
        }
        #endregion
    }
}

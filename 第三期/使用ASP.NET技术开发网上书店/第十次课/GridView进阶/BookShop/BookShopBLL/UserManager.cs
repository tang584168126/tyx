using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class UserManager
    {
        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="loginId">登陆名</param>
        /// <param name="loginPwd">登陆密码</param>
        /// <param name="validUser">输出用户</param>
        /// <returns>返回bool值表示登陆成功与否</returns>
        public bool Login(string loginId,string loginPwd,out User validUser)
        {
            User user = new UserService().GetUserByLoginId(loginId);
            //判断User是否为空
            if (user == null)
            {
                validUser = null;    //登陆用户不存在
                return false;
            }

            //用户存在后，密码是否正确
            if (user.LoginPwd == loginPwd)
            {
                validUser = user;
                return true;
            }
            else
            {
                validUser = null;   //密码错误
                return false;
            }



        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user">要注册的用户对象</param>
        /// <returns>整数，不同的值表示不同的情况</returns>
        public int Register(User user)
        {
            if (LoginIdExists(user.LoginId))
            {
                return 1;       //注册用户已存在
            }
            else
            {
                if (new UserService().AddUser(user))
                {
                    return 0;   //注册成功
                }
                else
                {
                    return 2;   //注册失败
                }
            }
        }

        /// <summary>
        /// 判定要注册的用户是否已存在
        /// </summary>
        /// <param name="loginId">注册的账户</param>
        /// <returns>True为已存在</returns>
        public bool LoginIdExists(string loginId)
        { 
            if(new UserService().GetUserByLoginId(loginId) == null)
            {
                return false;    //不存在
            }

            return true;
        }
    }
}
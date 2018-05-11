using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class UserManager
    {
        UserService userService = new UserService();

        /// <summary>
        /// 登陆验证
        /// </summary>
        /// <param name="loginId">登陆账号</param>
        /// <param name="loginPwd">密码</param>
        /// <param name="user">输出用户</param>
        /// <returns>true:登陆成功 ; false: 登陆失败</returns>
        public bool Login(string loginId,string loginPwd,out User user)
        {
            User tempUser = userService.GetUserByLoginId(loginId);

            if (tempUser == null)
            {
                user = null;        //用户名不存在
                return false;
            }

            if (tempUser.LoginPwd == loginPwd)
            {
                user = tempUser;
                return true;
            }
            else
            {
                user = null;        //密码错误
                return false;
            }
        }

        /// <summary>
        /// 注册新用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>0表示注册失败，1表示注册成功，2表示用户已经存在</returns>
        public int Register(User user)
        {
            //这里的代码可以改进
            //让用户输入LoginId后立马通过Ajax异步提交验证这个账号是否已经注册
            //现在还没有学，下一本书改进

            if (!userService.LoginIdExists(user.LoginId))
            {
                int result = AddUser(user);

                if (result > 0)
                {
                    return 1;   //注册成功
                }

                return 0;       //注册失败
            }

            return 2;           //用户已存在
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user">添加的用户对象</param>
        /// <returns>受影响的行数</returns>
        public int AddUser(User user)
        {
            //获取用户角色（默认）
            if (user.UserRole == null)
            {
                user.UserRole = new UserRoleManager().GetDefaultUserRole();
            }
            //获取用户状态（默认）
            if (user.UserState == null)
            {
                user.UserState = new UserStateManagercs().GetDefaultUserState();
            }

            return userService.AddUser(user);
        }
    }
}

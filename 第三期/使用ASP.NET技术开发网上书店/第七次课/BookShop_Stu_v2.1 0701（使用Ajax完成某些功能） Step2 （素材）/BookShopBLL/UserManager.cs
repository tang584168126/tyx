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
        public bool Login(string loginId,string loginPwd,out User validUser)
        {
            User user = new UserService().GetUserByLoginId(loginId);
            if(user == null)   //账号不存在
            {
                validUser = null;
                return false;
            }

            //账号存在
            if (user.LoginPwd.Trim().Equals(loginPwd))     //密码正确
            {
                validUser = user;
                return true;
            }
            else
            {
                validUser = null;
                return false;
            }
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user">要注册用户信息</param>
        /// <returns>0:注册失败，1:注册成功, 2:用户已存在</returns>
        public int Register(User user)
        {
            //判定用户是否存在
            if (!LoginIdExist(user.LoginId))     //用户不存在
            {
                if (AddUser(user))
                {
                    return 1;                   //注册成功
                }
                return 0;                       //注册失败
            }

            return 2;     //用户已存在
        }

        /// <summary>
        /// 判定用户是否存在
        /// </summary>
        /// <param name="loginId">账户名</param>
        /// <returns>true:账户名存在；false:账户名不存在</returns>
        public bool LoginIdExist(string loginId)
        {
            User user = new UserService().GetUserByLoginId(loginId);
            if (user == null)        //不存在
            {
                return false;
            }

            return true;
        }

        //添加用户
        private bool AddUser(User user)
        {
            //为这个用户指定默认的角色和状态
            user.UserRole = new UserRoleManager().GetDefaultUserRole();
            user.UserState = new UserStateManager().GetDefaultUserState();

            return new UserService().AddUser(user);
        }

        /// <summary>
        /// 根据用户账号获取用户对象
        /// </summary>
        /// <param name="loginId">账户名</param>
        /// <returns>用户对象</returns>
        public User GetUserByLoginId(string loginId)
        {
            return new UserService().GetUserByLoginId(loginId);
        }

        /// <summary>
        /// 根据角色获取对应的所有
        /// </summary>
        /// <param name="RoleId"></param>
        /// <returns></returns>
        public List<User> GetUsersByRoleId(int roleId)
        {
            return new UserService().GetUsersByRoleId(roleId);
        }
    }
}

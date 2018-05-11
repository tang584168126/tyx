using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class UserRoleManager
    {
        /// <summary>
        /// 根据UserRoleId获取UserRole
        /// </summary>
        /// <param name="userRoleId">用户角色编号</param>
        /// <returns>用户角色对象</returns>
        public UserRole GetUserRoleById(int userRoleId)
        {
            return new UserRoleService().GetUserRoleById(userRoleId);
        }

        /// <summary>
        /// 获取默认用户角色（普通用户）
        /// </summary>
        /// <returns>用户角色对象</returns>
        public UserRole GetDefaultUserRole()
        {
            return GetUserRoleById(1);
        }
    }
}

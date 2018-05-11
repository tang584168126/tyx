using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BookShop.DAL;
using BookShop.Models;

namespace BookShop.BLL
{
    public class UserStateManagercs
    {
        /// <summary>
        /// 根据UserStateId获取UserState
        /// </summary>
        /// <param name="userStateId">用户状态编号</param>
        /// <returns>用户状态对象</returns>
        public UserState GetUserStateById(int userStateId)
        {
            return new UserStateService().GetUserStateById(userStateId);
        }

        /// <summary>
        /// 获取默认用户状态（正常）
        /// </summary>用户状态
        /// <returns>用户状态对象</returns>
        public UserState GetDefaultUserState()
        {
            return GetUserStateById(1);
        }
    }
}

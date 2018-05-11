using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseRent.Model;
using HouseRent.DAL;

namespace HouseRent.BLL
{
    public class UserManager
    {
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<User> GetAll()
        {
            return new UserService().GetAll();
        }

        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="validUser">返回用户信息</param>
        /// <returns>用户</returns>
        public bool LoginIn(string loginName,string password,out User validUser)
        {
            User user = new UserService().GetUserByName(loginName);
            if(user == null)
            {
                validUser = null;
                return false;
            }
            if(user.Password == password)
            {
                //密码错误
                validUser = null;
                return false;
            }
            else
            {
                validUser = user;
                return true;
            }
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>true:新增成功 false:新增失败</returns>
        public bool AddUser(User user)
        {
            if(new UserService().AddUser(user))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

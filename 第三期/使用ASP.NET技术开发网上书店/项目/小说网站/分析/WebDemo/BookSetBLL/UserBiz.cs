using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSet.Models;
using BookSet.DAL;
namespace BookSet.BLL
{
    public class UserBiz
    {
        public bool Login(string userId,string pasWord ,out User viter) 
        {
            User user = new UserSevice().CheckLogin(userId);
            //判断值是否为空;
            if(user==null)
            {
                viter = null;
                return false;
            }
            //验证密码
            if (user.Password.Equals(pasWord))
            {
                viter = user;
                return true;
            }
            //值为空或密码错误
            else 
            {
                viter = null;
                return false;
            }
            
        }


        /// <summary>
        /// 经过验证的注册
        /// </summary>
        /// <returns>0:注册失败 1：注册成功  2:用户名已存在</returns>
        public int Regist(User user) 
        {
            if (!LoginExsit(user.UserId)) //用户名不存在
          {
              if (AddUser(user))
              {
                  return 1;     //注册成功
              }         
                  return 0;
          }
            return 2;
        }

        /// <summary>
        ///判断用户是否存在
        /// </summary>
        /// <param name="loginId">用户名</param>
        /// <returns>true 存在</returns>
        public bool LoginExsit(string loginId) 
        {
            User user = new UserSevice().CheckLogin(loginId);
            if (user == null)  //不存在
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        
        
        
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>true 注册成功</returns>
       private bool AddUser(User user)
       {
           return new UserSevice().AddUsr(user);
       }

       
    }
}

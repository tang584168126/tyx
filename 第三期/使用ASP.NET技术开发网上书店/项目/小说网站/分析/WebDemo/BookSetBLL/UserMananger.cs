using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookSet.DAL;
using BookSet.Models;
namespace BookSet.BLL
{
  public  class UserMananger
    {
      /// <summary>
      /// 判断登录是否成功
      /// </summary>
      /// <returns></returns>
      public bool Login(string loginId, string loginPwd, out User validUser) 
      {
          User user = new UserService().GetUserByLoginId(loginId);
          //帐号不存在
          if (user == null)
          {
              validUser = null;
              return false;
          }
          //判断密码
          if (user.LoginPwd.Trim().Equals(loginPwd.Trim()))
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
    }
}

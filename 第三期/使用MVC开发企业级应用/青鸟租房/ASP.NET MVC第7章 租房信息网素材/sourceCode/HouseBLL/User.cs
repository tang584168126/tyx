using System;
using System.Data;
using System.Collections.Generic;
using bdqn.houses.DAL;
using bdqn.houses.Model;
namespace bdqn.houses.BLL
{
  
	/// <summary>
	/// User
	/// </summary>
	public partial class UserManager
	{
        static object userLock=new object();
        private readonly bdqn.houses.DAL.UserService dal = new bdqn.houses.DAL.UserService();
        public UserManager()
		{}
		#region  Method

        public bool Login(User user, out User gettedUser)
        {
             gettedUser = dal.GetModel(user.LoginName);
            if (gettedUser != null && gettedUser.Password == user.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Register(User user)
        {
            lock(userLock)
            {
                if (dal.Exists(user.LoginName))//用户是否存在
                {
                    return false;

                }
                else
                {
                    if (dal.Add(user) > 0)//添加用户成功
                        return true;
                }
            }
            return false;
        }

		#endregion  Method
	}
}


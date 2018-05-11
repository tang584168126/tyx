using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusAcademy.Models;
using FocusAcademy.DAL;

namespace FocusAcademy.BLL
{
    public class FocusAdminManager
    {
        /// <summary>
        /// 管理员登录验证
        /// </summary>
        /// <param name="adminId">用户输入的账号</param>
        /// <param name="adminPassword">用户输入的密码</param>
        /// <returns></returns>
        public bool AdminLogin(string adminId, string adminPassword, out FocusAdmin admin)
        {
            FocusAdmin focusAdmin = new FocusAdminService().GetAdminById(adminId);

            if(focusAdmin == null)
            {
                //账户不存在
                admin = null;
                return false;
            }

            if(focusAdmin.AdminPassword.Equals(adminPassword))
            {
                //登录成功
                admin = focusAdmin;
                return true;               
            }
            else
            {
                //登录失败
                admin = null;
                return false;
            }
        }
    }
}

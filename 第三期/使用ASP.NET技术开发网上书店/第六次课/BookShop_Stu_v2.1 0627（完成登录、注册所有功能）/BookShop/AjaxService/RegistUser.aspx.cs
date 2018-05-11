using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.BLL;
using BookShop.Models;

namespace BookShop.AjaxService
{
    public partial class RegistUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = new User();
            user.LoginId = this.Request.Form["loginId"].ToString();
            user.LoginPwd = this.Request.Form["loginPwd"].ToString();
            user.Name = this.Request.Form["name"].ToString();
            user.Mail = this.Request.Form["mail"].ToString();
            user.Address = this.Request.Form["address"].ToString();
            user.Phone = this.Request.Form["phone"].ToString();

            int result = new UserManager().Register(user);

            if (result == 1)
            {
                this.Response.Write("注册成功！");
            }
            else if (result == 0)
            {
                this.Response.Write("注册失败！");
            }
        }
    }
}
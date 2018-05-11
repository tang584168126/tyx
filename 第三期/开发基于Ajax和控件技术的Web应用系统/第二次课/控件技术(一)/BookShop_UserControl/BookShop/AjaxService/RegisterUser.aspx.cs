using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.Models;
using BookShop.BLL;

namespace BookShop.AjaxService
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.ContentType = "text/plain";

            User user = new User();
            user.LoginId = Context.Request.Form["loginId"].ToString();
            user.LoginPwd = Context.Request.Form["loginPwd"].ToString();
            user.Name = Context.Request.Form["name"].ToString();
            user.Mail = Context.Request.Form["mail"].ToString();
            user.Address = Context.Request.Form["address"].ToString();
            user.Phone = Context.Request.Form["phone"].ToString();

            int result = new UserManager().Register(user);

            if (result == 1)   //注册成功
            {
                this.Response.Write("注册成功");
            }
            else if (result == 0)
            {
                this.Response.Write("注册失败");
            }
        }
    }
}
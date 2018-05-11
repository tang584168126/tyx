using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.BLL;
using BookShop.Models;

namespace BookShop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.snCode.Create();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.snCode.CheckSN(this.txtCode.Text.Trim()))
            {
                this.snCode.Create();
                //注册验证码不正确的提示脚本
                Response.Write("<script>alert('验证码错误！')</script>");
                return;
            }

            User user = null;
            UserManager userManager = new UserManager();
            bool isSuccess = userManager.Login(this.txtLoginId.Text.Trim(),this.txtPassword.Text.Trim(),out user);
            if (isSuccess)
            {
                //直接跳转到主页面
            }
            else
            {
                Session["User"] = user;
                //提示用户名或密码错误
                Response.Write("<script>alert('用户名或密码错误!')</script>");
            }
        }
    }
}
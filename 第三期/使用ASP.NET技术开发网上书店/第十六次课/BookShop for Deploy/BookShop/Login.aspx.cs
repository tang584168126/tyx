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
        const string strErrorUser = "用户名或密码不正确，请重新填写!";

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
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script type='text/javascript'>alert('验证码错误！');</script>");
                return;
            }

            User user = null;
            UserManager manager = new UserManager();
            if (manager.Login(this.txtLoginId.Text.Trim(), this.txtPassword.Text.Trim(), out user))
            {
                Session["CurrentUser"] = user;
                System.Web.Security.FormsAuthentication.SetAuthCookie(user.Name,false);

                Response.Redirect("~/Home.aspx");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('" + strErrorUser + "')</script>");
            }
        }
    }
}
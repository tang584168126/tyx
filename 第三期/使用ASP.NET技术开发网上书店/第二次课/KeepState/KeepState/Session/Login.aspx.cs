using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState.Session
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtLoginName.Text.Trim() == "")
            {
                Response.Write("<p>登录名不能为空！</p>");
                return;
            }
            if (this.txtLoginPwd.Text.Trim() == "")
            {
                Response.Write("<p>密码不能为空！</p>");
                return;
            }
            if (this.txtLoginName.Text.Trim() == "jbit" && this.txtLoginPwd.Text.Trim() == "bdqn")
            {
                Session["name"] = this.txtLoginName.Text.Trim();
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("<p>用户名和密码有误！</p>");
            }
        }
    }
}
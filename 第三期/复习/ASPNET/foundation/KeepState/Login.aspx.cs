using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                Response.Write("<p>登录名不能为空！</p>");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                Response.Write("<p>密码不能为空！</p>");
                return;
            }
            if (this.txtName.Text.Trim() == "jbit" && this.txtPassword.Text.Trim() == "bdqn")
            {
                Response.Redirect("Home.aspx?name=" + this.txtName.Text.Trim());
            }
            else
            {
                Response.Write("<p>用户名和密码有误！</p>");
            }
        }
    }
}
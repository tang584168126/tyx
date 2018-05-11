using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if(this.txtUser.Text.Trim().Length == 0)
            {
                this.lblMessage.Text = "请输入用户名！";
                return;
            }
            if (this.txtPwd.Text.Length == 0)
            {
                this.lblMessage.Text = "请输入密码！";
                return;
            }
            if (this.txtUser.Text.Equals("jbit") && this.txtPwd.Text.Equals("bdqn"))
            {
                Response.Redirect("Welcome.aspx?name=" + this.txtUser.Text.Trim());
            }
            else
            {
                Response.Write("用户名/密码错误！");
            }

        }
    }
}
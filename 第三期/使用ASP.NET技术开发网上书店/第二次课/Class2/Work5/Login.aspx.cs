using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                Response.Write("用户名不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(this.txtPwd.Text.Trim()))
            {
                Response.Write("密码不能为空！");
                return;
            }
            Session["name"] = this.txtName.Text.Trim();
            Response.Redirect("Home.aspx");
        }
    }
}
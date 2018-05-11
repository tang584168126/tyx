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
            if (this.txtName.Text.Equals("administrator") && this.txtPwd.Text.Equals("password"))
            {
                Response.Write("用户名或密码错误！");
            }
            Session["name"] = this.txtName.Text.Trim();
            Response.Redirect("Home.aspx");
        }
    }
}
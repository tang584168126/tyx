using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work5
{
    public partial class Work5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text.Equals("admin") && this.txtPwd.Text.Equals("password"))
            {
                this.lblResult.Text = this.txtUser.Text + "恭喜你，你已经通过验证！";
            }
        }
    }
}
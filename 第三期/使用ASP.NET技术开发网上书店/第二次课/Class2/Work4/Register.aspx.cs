using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work3
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {  
            Session["name"] = this.txtName.Text.Trim();
            Session["enrol"] = this.txtEnrol.Text.Trim();
            Session["graduate"] = this.txtGraduate.Text.Trim();
            Session["school"] = this.txtSchool.Text.Trim();
            Session["time"] = this.txtTime.Text.Trim();
            Response.Redirect("Verify.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work3
{
    public partial class Verify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Session["name"].ToString();
            this.lblEnrol.Text = Session["enrol"].ToString();
            this.lblGraduate.Text = Session["graduate"].ToString();
            this.lblSchool.Text = Session["school"].ToString();
            this.lbltxtTime.Text = Session["time"].ToString();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
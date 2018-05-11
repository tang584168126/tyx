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
            this.lblPwd.Text = Session["pwd"].ToString();
            this.lblEmail.Text = Session["email"].ToString();
            this.lblQuestion.Text = Session["question"].ToString();
            this.lblAnswer.Text = Session["answer"].ToString();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
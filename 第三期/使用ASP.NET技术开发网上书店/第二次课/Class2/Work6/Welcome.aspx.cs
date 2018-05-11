using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work6
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTitle.Text = "";
            this.txtContent.Text = "";
        }
    }
}
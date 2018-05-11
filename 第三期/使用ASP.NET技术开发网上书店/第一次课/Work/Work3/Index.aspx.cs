using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work3
{
    public partial class Work3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInline_Click(object sender, EventArgs e)
        {
            this.lblInline.Visible = true;
        }

        protected void btnBehind_Click(object sender, EventArgs e)
        {
            this.lblBehind.Text = DateTime.Now.ToString();
        }
    }
}
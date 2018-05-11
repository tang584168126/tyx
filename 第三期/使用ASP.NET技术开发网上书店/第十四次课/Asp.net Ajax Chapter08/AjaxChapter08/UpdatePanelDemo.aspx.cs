using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxChapter08
{
    public partial class UpdatePanelDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.lblTime.Text = DateTime.Now.ToString();
                this.lblTime2.Text = DateTime.Now.ToString();
                this.lblTime4.Text = DateTime.Now.ToString();
                this.lblTime3.Text = DateTime.Now.ToString();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.lblTime2.Text = DateTime.Now.ToString();
        }

        protected void btnSubmit3_Click(object sender, EventArgs e)
        {
            this.lblTime3.Text = DateTime.Now.ToString();
        }

        protected void btnSubmit4_Click(object sender, EventArgs e)
        {
            this.lblTime4.Text = DateTime.Now.ToString();
        }
    }
}
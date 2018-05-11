using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxChapter08
{
    public partial class TimerDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.lblTime.Text = DateTime.Now.ToString();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerDemo
{
    public partial class PageTwo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lbtShow.Text = this.Request.QueryString["name"].ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string name = Request.QueryString["name"];
                this.lblName.Text = name;
                this.lblContent.Text = Request.ServerVariables["HTTP_USER_AGENT"].ToString();
                this.lblLan.Text = Request.ServerVariables["HTTP_ACCEPT_LANGUAGE"].ToString();
            }
        }
    }
}
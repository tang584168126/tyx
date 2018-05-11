using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerDemo
{
    public partial class PageOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            string str = this.Server.UrlEncode("4&5");

            this.Response.Redirect("PageTwo.aspx?name=Redirect" + str);
        }

        protected void btnTranser_Click(object sender, EventArgs e)
        {
            this.Server.Transfer("PageTwo.aspx?name=Transfer");
        }

        protected void btnExecute_Click(object sender, EventArgs e)
        {
            this.Server.Execute("PageTwo.aspx?name=Execute");
        }
    }
}
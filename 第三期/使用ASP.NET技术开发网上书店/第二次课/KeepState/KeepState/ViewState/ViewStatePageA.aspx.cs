using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState.ViewState
{
    public partial class ViewStatePageA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["name"] = "Jack";

            Response.Redirect("ViewStatePageB.aspx");
        }
    }
}
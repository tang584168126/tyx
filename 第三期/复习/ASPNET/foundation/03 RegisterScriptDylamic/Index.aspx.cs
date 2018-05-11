using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_RegisterScriptDylamic
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.ClientScript.IsClientScriptBlockRegistered(this.GetType(), "scriptKey"))
            {
                string scriptKey = "<script>document.getElementById('txtName').focus();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", scriptKey);
            }
        }
    }
}
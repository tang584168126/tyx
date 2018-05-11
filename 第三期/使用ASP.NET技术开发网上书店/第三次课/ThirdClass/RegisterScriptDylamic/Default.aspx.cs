using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterScriptDylamic
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断要注册的脚本是否已经注册了
            if (!Page.ClientScript.IsClientScriptBlockRegistered(this.GetType(), "scriptKey"))
            {
                string scriptText = "<script type='text/javascript'>document.getElementById('txtUserName').focus();</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "script", scriptText);
            } 
        }
    }
}
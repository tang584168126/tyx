using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KeepState.App_Code;

namespace KeepState.Application
{
    public partial class ApplicationPageB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo user = Application["user"] as UserInfo;
            if (!string.IsNullOrEmpty("user"))
            {
                Response.Write("用户名为："+user.LoginName);
            }
        }
    }
}
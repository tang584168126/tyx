using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState.Cookies
{
    public partial class CookiesPageB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["name"] != null)
            {
                Response.Write("用户名：" + Request.Cookies["name"].Value);
            }
        }
    }
}
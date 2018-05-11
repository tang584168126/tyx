using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState.Cookies
{
    public partial class CookiesPageA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //第一种方式
            Response.Cookies["name"].Value = "Jack";

            //第二种方式
            HttpCookie hc = new HttpCookie("name","Jack");
            hc.Expires = DateTime.Now;
            Response.Cookies.Add(hc);

            Response.Redirect("CookiesPageB.aspx");
        }
    }
}
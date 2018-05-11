using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _08_jQuery之AjaxEvent
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"].ToString();
            string content = Request.QueryString["content"].ToString();

            Response.Write("<div class='comment'><h6>" + username + ":</h6><p class='para'>" + content + "</p></div>");
        }
    }
}
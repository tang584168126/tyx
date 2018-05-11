using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_jQuery之get__
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.Form["username"].ToString();
            string content = Request.Form["content"].ToString();

            Response.Write("<div class='comment'><h6>" + username + ":</h6><p class='para'>" + content + "</p></div>");
        }
    }
}
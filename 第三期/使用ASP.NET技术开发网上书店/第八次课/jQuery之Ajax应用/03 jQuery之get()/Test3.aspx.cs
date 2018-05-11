using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_jQuery之get__
{
    public partial class Test3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"].ToString();
            string content = Request.QueryString["content"].ToString();

            Response.Write("{\"username\":\""+username+"\",\"content\":\""+content+"\"}");
        }
    }
}
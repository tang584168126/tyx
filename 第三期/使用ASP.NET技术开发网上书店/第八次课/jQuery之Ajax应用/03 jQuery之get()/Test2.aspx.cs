using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03_jQuery之get__
{
    public partial class Test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"].ToString();
            string content = Request.QueryString["content"].ToString();

            Response.ContentType="application/xml";
            Response.Charset="utf-8";
            Response.Write("<?xml version='1.0' encoding='utf-8'?>");
            Response.Write("<comments>");
            Response.Write("<comment username='" + username + "'>");
            Response.Write("<content>" + content + "</content>");
            Response.Write("</comment>");
            Response.Write("</comments>");
        }
    }
}
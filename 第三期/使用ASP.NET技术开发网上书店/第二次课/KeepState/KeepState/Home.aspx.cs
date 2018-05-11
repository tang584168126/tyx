using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Page.Request.QueryString["name"];
            Response.Write("Welcome" + name);
            Response.Write("<br/><br/>");
            Response.Write("浏览器信息："+Page.Request.UserAgent);
            Response.Write("<br/>浏览器主机IP："+Page.Request.UserHostAddress);

            Response.Write("<br/><br/>你是本网站的第" + Application["Count"].ToString() + "个访问用户！");
        }
    }
}
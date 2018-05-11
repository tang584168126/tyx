using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work5
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Session["name"] + "欢迎你来到后台程序代码！");
            Response.Write("<br/><br/>客户端信息:<br/><br/>");
            Response.Write("<p>浏览器类型："+Request.Browser+"</p>");
        }
    }
}
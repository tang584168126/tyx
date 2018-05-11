using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState.Session
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //首次加载并且Session["name"]不为空时，获取登录名并显示
            if (!Page.IsPostBack && Session["name"] != null)
            {
                Response.Write("Welcome " + Session["name"].ToString());
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}
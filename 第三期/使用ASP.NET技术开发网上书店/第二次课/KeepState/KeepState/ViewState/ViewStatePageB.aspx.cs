using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KeepState.ViewState
{
    public partial class ViewStatePageB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ViewState["name"] != null)
            {
                Response.Write("登录名为：" + ViewState["name"].ToString());
            }
        }
    }
}
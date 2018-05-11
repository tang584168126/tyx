using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageLifeCycle
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("<p>页面的生命周期：Page_PreInit预初始化。。。</p>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("<p>页面的生命周期：Page_Init初始化。。。</p>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("<p>页面生命周期：Page_Load首次加载</p>");
            }
            else
            {
                Response.Write("<p>页面生命周期：Page_Load回发</p>");
            }
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("<p>页面的生命周期：Page_PreRender预呈现。。。</p>");
        }
        protected void Page_Render(object sender, EventArgs e)
        {
            Response.Write("<p>页面的生命周期：Page_Render呈现。。。</p>");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            //Response.Write("<p>页面的生命周期：Page_Unload释放资源。。。</p>");
        }
        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            Response.Write("<p>页面生命周期：btnPostBack_Click单击事件</p>");
        }
    }
}
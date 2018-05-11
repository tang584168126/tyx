using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TransferDataInPage
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //页面中有一个GridView控件，存储表格数据，数据从数据库中提取
            //页面加载时，要为这个控件获取数据
            if (!Page.IsPostBack)
            {
                //页面首次加载时要做的事情
            }
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            this.txtAccept.Text = this.txtSend.Text;
        }
    }
}
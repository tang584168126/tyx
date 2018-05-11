using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CallService.ProdutServiceAsyn;

namespace CallService
{
    public partial class CallServiceAsyn : System.Web.UI.Page
    {
        ProdutsAmountServiceSoapClient service = new ProdutsAmountServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                service.ExecuteDatasetByIDCompleted = new EventHandler<ExecuteDatasetByIDCompletedEventArgs>(service_ExecuteDatasetByIDCompleted);
            }
        }
        private void service_ExecuteDatasetByIDCompleted(object sender, ExecuteDatasetByIDCompletedEventArgs e)
        {
            this.gvBooks.DataSource = e.Result.Tables[0];
            this.gvBooks.DataBind();
            Response.Write("<br/>调用Web Sevice执行完毕的时间：" + DateTime.Now.ToLongTimeString());
        }
        protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Write("调用Web Sevice时的时间：" + DateTime.Now.ToLongTimeString());
            service.ExecuteDatasetByIDAsync(this.txtName.Text.Trim());
            Response.Write("<br/>调用Web Sevice后的时间：" + DateTime.Now.ToLongTimeString());
        }
    }
}
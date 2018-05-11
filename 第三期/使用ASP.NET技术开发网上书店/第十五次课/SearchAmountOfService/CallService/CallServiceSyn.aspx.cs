using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CallService.ProductsService;
using System.Data;

namespace CallService
{
    public partial class CallService : System.Web.UI.Page
    {
        ProductsAmountServiceSoapClient service = new ProductsAmountServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            DataSet ds = service.ExecuteDatasetByID(this.txtName.Text.Trim());
            this.gvBooks.DataSource = ds.Tables[0];
            this.gvBooks.DataBind();
        }
    }
}
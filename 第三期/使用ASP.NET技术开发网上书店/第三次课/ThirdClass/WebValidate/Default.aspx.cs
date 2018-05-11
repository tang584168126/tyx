using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebValidate
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.snCode.Create();
            } 
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.snCode.CheckSN(this.txtCode.Text.Trim()))
            {
                //提示验证通过
                this.lblMsg.Text = "验证通过";
            }
            else
            {
                //提示验证失败
                this.lblMsg.Text = "验证失败";
            }
        }
    }
}
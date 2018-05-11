using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_WebValidate
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.snCode.Create();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.snCode.CheckSN(this.txtCode.Text.Trim()))
            {
                this.lblMsg.Text = "验证通过！";
            }
            else
            {
                this.lblMsg.Text = "验证失败！";
            }
        }
    }
}
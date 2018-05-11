using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work4
{
    public partial class Work4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.txtAge.Text) > 18 && Convert.ToInt32(this.txtAge.Text) < 100)
            {
                this.lblResult.Text = this.txtUser + "欢迎你！";
            }
            else
            {
                this.lblResult.Text = null;
            }
        }
    }
}
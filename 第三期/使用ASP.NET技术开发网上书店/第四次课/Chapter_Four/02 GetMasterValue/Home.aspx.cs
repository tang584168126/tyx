using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_GetMasterValue
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string value = this.Master.MasterValue;

            RadioButtonList rblControl = this.Master.FindControl("rblRole") as RadioButtonList;

            string value = rblControl.SelectedValue;

            if (value.Equals("0"))
            {
                this.lblMessage.Text = "高校BBS招聘！";
            }
            else if (value.Equals("1"))
            {
                this.lblMessage.Text = "3~5年职业规划！";
            }
        }
    }
}
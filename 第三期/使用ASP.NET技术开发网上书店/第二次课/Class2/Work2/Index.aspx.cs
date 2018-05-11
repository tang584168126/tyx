using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Application.Lock();
            Application["Count"] = 0;
            if (IsPostBack)
            {
                Application["Count"] = (int)Application["Count"] + 1;
                Response.Write(Application["Count"]);
            }
            Application.UnLock();
        }
    }
}
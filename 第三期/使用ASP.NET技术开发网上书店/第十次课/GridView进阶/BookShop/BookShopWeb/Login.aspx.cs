using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShop.BLL;
using BookShop.Models;

namespace BookShopWeb
{
    public partial class Login : System.Web.UI.Page
    {
        const string strErrorUser = "用户名或密码不正确，请重新填写!";

        User user = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager manager = new UserManager();
            if (manager.Login(this.txtLoginId.Text.Trim(),this.txtPwd.Text.Trim(),out user))
            {
                Session["CurrentUser"] = user;

                Response.Redirect("~/Default.aspx");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('" + strErrorUser + "')</script>");
            }
        }
    }
}
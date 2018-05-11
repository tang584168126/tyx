using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.BLL;


namespace BookShop.AjaxService
{
    public partial class UserExists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Context.Response.ContentType = "text/plain";   //相应的数据类型

            if (this.Context.Request.QueryString["loginId"] != null)
            {
                string loginId = this.Context.Request.QueryString["loginId"].ToString();
                if (loginId.Length > 0)
                {
                    if (new UserManager().LoginIdExist(loginId))
                    {
                        this.Response.Write("true");    //已注册
                    }
                    else
                    {
                        this.Response.Write("false");   //未注册
                    }
                }
            }
            else
            {
                this.Response.Write("other");   //账户名为空
            }
        }
    }
}
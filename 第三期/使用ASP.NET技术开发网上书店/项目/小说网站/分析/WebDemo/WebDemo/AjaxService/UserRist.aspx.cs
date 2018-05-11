using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookSet.BLL;
using BookSet.Models;

namespace WebDemo.AjaxService
{
    public partial class UserRist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //接收Ajax请求传递过来的数据
            string loginId = this.Request.QueryString["loginId"].ToString();
            if(loginId.Length>0)
            {
                bool isExist = new UserManager().LoginExsit(loginId);
                if (isExist)
                {
                    this.Response.Write("true");
                }
                else 
                {
                    this.Response.Write("false");
                }
            }
        }
    }
}
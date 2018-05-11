using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KeepState.App_Code;

namespace KeepState.Application
{
    public partial class ApplicationPageA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //添加简单数据
            //Application["name"] = "Jack";
            Application.Add("name", "Jack");

            //添加复合数据
            UserInfo user = new UserInfo();
            user.LoginName = "jbit";
            user.Password = "bdqn";
            Application["user"] = user;

            //对已有对象赋值会覆盖其数据
            UserInfo user1 = new UserInfo();
            user1.LoginName = "Jack";
            user1.Password = "123456";
            Application["user"] = user1;
            Response.Redirect("ApplicationPageB.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookSet.BLL;
using BookSet.Models;


namespace WebDemo
{
    public partial class Login : System.Web.UI.Page
    {
        const string strErrorUser = "用户名或密码不正确,请重新填写";

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string userName = Request.Form["username"].ToString();
            string password = Request.Form["password"].ToString();
            User user = null;
            UserBiz manger = new UserBiz();
            if (manger.Login(userName, password, out user))
            {
                //保存用户名
               
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType()
                    , "scriptKey", "<script>alert('登录成功')</script>");
                Session["UserIdCount"] = user.UserId;
                //跳转主页
                Response.Redirect("");
            }
            else 
            {

                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType()
                    , "scriptKey", "<script>alert('登录失败')</script>");
                //登录失败后显示登录失败的原因

                return;
            }

        }
    }
}
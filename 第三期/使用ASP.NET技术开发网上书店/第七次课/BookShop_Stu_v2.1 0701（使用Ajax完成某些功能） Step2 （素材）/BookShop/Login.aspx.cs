using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.Models;
using BookShop.BLL;

namespace BookShop
{
    public partial class Login : System.Web.UI.Page
    {
        const string strErrorUser = "用户名或密码不正确，请重新填写！";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                this.snCode.Create();
                //this.btnSubmit.Attributes.Add("onclick","if(!confirm('确定提交吗?')){return false;}");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(!this.snCode.CheckSN(this.txtCode.Text.Trim()))
            {
                this.snCode.Create();
                //注册验证码不正确的提示脚本
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "scriptSNCodeKey", "<script>alert('验证码有误！')</script>");

                return;
            }

            User user = null;
            UserManager userManager = new UserManager();
            bool isSuccess = userManager.Login(this.txtLoginId.Text.Trim(),this.txtPassword.Text.Trim(), out user);

            if (isSuccess)
            {
                //保存用户信息
                Session["CurrentUser"] = user;

                //写入身份票据，后边学完再添加

                //ReturnUrl，后边学完再添加，用于登陆后返回用户初始想访问的页面

                //跳转到主页面
                Response.Redirect("~/Home.aspx");
            }
            else
            {                
                //提示用户名或密码不正确
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "scriptLoginKey", "<script>alert('" + strErrorUser + "')</script>");
            }
        }
    }
}
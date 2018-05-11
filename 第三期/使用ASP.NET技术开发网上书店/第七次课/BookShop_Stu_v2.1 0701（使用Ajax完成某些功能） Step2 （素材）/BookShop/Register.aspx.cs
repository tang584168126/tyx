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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.snCode.Create();
                //this.btnSubmit.Attributes.Add("onclick", "if(!confirm('确定提交吗?')){return false;}");

                this.txtLoginId.Text = "adfad123456";
                this.txtPassword.Text = "123456";
                this.txtRePassword.Text = "123456";
                this.txtMail.Text = "6234507415@qq.com";
                this.txtName.Text = "你好";
                this.txtAddress.Text = "测试";
                this.txtPhone.Text = "12345678911";
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!this.snCode.CheckSN(this.txtCode.Text.Trim()))
            {
                this.snCode.Create();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script type='text/javascript'>alert('验证码错误！');</script>");
                return;
            }

            User user = new User();
            user.LoginId = this.txtLoginId.Text;
            user.LoginPwd = this.txtPassword.Text;
            user.Name = this.txtName.Text;
            user.Mail = this.txtMail.Text;
            user.Address = this.txtAddress.Text;
            user.Phone = this.txtPhone.Text;

            UserManager userManager = new UserManager();
            int result = userManager.Register(user);

            string scriptText = "";
            switch (result)
            {
                case 0:
                    scriptText = "<script type='text/javascript'>alert('注册失败！');</script>";
                    break;
                case 1:
                    scriptText = "<script type='text/javascript'>alert('注册成功！');</script>";
                    break;
                case 2:
                    scriptText = "<script type='text/javascript'>alert('用户名已被注册！');</script>";
                    break;
            }
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "scriptKey", scriptText);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShop.Models;
using BookShop.BLL;

namespace BookShopWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                snCode.Create();
                this.txtCode.Attributes.Add("onkeydown", "SubmitClick()");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!CheckCode())
            {
                //this.litSnCode.Text = "<script>alert('验证码输入错误！')</script>";
                return;
            }
            if (Page.IsValid)
            {
                User user = new User();
                user.LoginId = this.txtLoginId.Text;
                user.LoginPwd = this.txtLoginPwd.Text;
                user.Name = this.txtName.Text;
                user.Address = this.txtAddress.Text;
                user.Phone = this.txtTele.Text;
                user.Mail = this.txtEmail.Text;
                UserManager manager = new UserManager();

                int result = manager.Register(user);
                if (result == 1)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('用户名已使用，请重新输入！')</script>");
                }
                else if (result == 2)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('注册失败，请联系管理员！')</script>");
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "<script>alert('注册成功，请继续购物！');window.location='Default.aspx'</script>");
                }
            }
        }

        protected bool CheckCode()
        {
            if (snCode.CheckSN(txtCode.Text.Trim()))
            {
                return true;
            }
            else
            {
                snCode.Create();
                return false;
            }
        }
    }
}
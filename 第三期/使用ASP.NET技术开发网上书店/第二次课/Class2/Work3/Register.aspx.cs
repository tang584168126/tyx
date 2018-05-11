using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Work3
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(this.txtPwd.Text.Trim() != this.txtSurePwd.Text.Trim())
            {
                Response.Write("两次输入的密码不一致！");
                return;
            }
                
            Session["name"] = this.txtName.Text.Trim();
            Session["pwd"] = this.txtPwd.Text.Trim();
            Session["email"] = this.txtEmail.Text.Trim();
            Session["question"] = this.txtQuestion.Text.Trim();
            Session["answer"] = this.txtAnswer.Text.Trim();
            Response.Redirect("Verify.aspx");
        }
    }
}
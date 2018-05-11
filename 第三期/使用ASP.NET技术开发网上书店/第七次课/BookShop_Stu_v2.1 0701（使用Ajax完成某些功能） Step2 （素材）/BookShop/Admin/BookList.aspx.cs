using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.BLL;
using BookShop.Models;

namespace BookShop.Admin
{
    public partial class BookList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRoles();
                this.ddlUser.Enabled = false;
                this.ddlUser.Items.Insert(0, new ListItem("=== 请选择 ===", "-1"));

                
            }
            this.BindGrid();
        }

        /// <summary>
        /// 为下拉框ddlRole绑定下拉选项
        /// </summary>
        private void BindRoles()
        {
            this.ddlRole.DataSource = new UserRoleManager().GetUserRoles();
            this.ddlRole.DataValueField = "Id";
            this.ddlRole.DataTextField = "Name";
            this.ddlRole.DataBind();

            this.ddlRole.Items.Insert(0, new ListItem("=== 请选择 ===", "-1"));
            
        }

        private void BindUser(int roleId)
        {
            this.ddlUser.DataSource = new UserManager().GetUsersByRoleId(roleId);
            this.ddlUser.DataValueField = "Id";
            this.ddlUser.DataTextField = "LoginId";
            this.ddlUser.DataBind();
        }

        protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取选中项的roleId
            int roleId = Convert.ToInt32(this.ddlRole.SelectedItem.Value);

            BindUser(roleId);
            this.ddlUser.Enabled = true;
        }

        private void BindGrid()
        {
            this.gvBooks.DataSource = new BookManager().GetAllBook();
            this.gvBooks.DataBind();
        }

        protected void gvBooks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvBooks.PageIndex = e.NewPageIndex;
        }
    }
}
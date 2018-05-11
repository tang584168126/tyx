using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.Models;
using BookShop.BLL;

namespace BookShopWeb.Admin
{
    public partial class BookEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPublisher();
                BindCategory();
            }
        }

        /// <summary>
        /// 为ddlPblisher绑定下拉框
        /// </summary>
        protected void BindPublisher()
        {
            this.ddlPublisher.DataSource = new PublisherManager().GetAllPublisher();
            this.ddlPublisher.DataValueField = "Id";
            this.ddlPublisher.DataTextField = "Name";
            this.ddlPublisher.DataBind();
            this.ddlPublisher.Items.Insert(0, new ListItem("请选择", "0"));
        }

        /// <summary>
        /// 为ddlCategory绑定下拉框
        /// </summary>
        protected void BindCategory()
        {
            this.ddlCategory.DataSource = new CategoryManager().GetAllCategories();
            this.ddlPublisher.DataValueField = "Id";
            this.ddlPublisher.DataTextField = "Name";
            this.ddlPublisher.DataBind();
            this.ddlPublisher.Items.Insert(0, new ListItem("请选择", "0"));
        }
    }
}
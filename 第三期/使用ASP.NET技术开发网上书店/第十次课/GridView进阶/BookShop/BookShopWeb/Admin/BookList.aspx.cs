using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookShop.BLL;
using BookShop.Models;

namespace BookShopWeb.Admin
{
    public partial class BookList : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager();
        BookManager bookManager = new BookManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            //首次加载
            if (!IsPostBack)
            {
                BooksDataBind();
            }
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            BookQueryCategories category = (BookQueryCategories)Enum.Parse(typeof(BookQueryCategories), this.ddlCategories.SelectedValue);
            this.gvBooks.DataSource = new BookManager().GetBooks(category, txtKeyWord.Text);
            this.gvBooks.DataBind();
        }

        protected void gvBooks_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.gvBooks.PageIndex = e.NewPageIndex;
            this.gvBooks.DataSource = new BookManager().GetBooks();
            this.gvBooks.DataBind();
        }

        protected void gvBooks_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#6699ff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor");
            }
        }

        //为ddlCategories下拉列表绑定数据
        protected void BindCategory()
        {
            this.ddlCategories.DataSource = new CategoryManager().GetAllCategories();
            this.ddlCategories.DataTextField = "Name";//用于显示的字段
            this.ddlCategories.DataValueField = "Id";//用于存值的字段
            this.ddlCategories.DataBind();
            this.ddlCategories.Items.Insert(0, new ListItem("===请选择===", "0"));
        }

        //获取数据并绑定到GridView
        private void BooksDataBind()
        {
            this.gvBooks.DataSource = new BookManager().GetBooks();
            this.gvBooks.DataBind();
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gr in this.gvBooks.Rows)//循环每一行
            {
                //获取模板列中的CheckBox控件对象
                CheckBox chk = gr.FindControl("chkSelect") as CheckBox;
                if (chk.Checked)
                {
                    //获取主键
                    string key = this.gvBooks.DataKeys[gr.RowIndex].Value.ToString();

                    BookManager manager = new BookManager();
                    OrderManager order = new OrderManager();
                    //执行删除操作
                    order.DeleteOrderBookByBookId(Convert.ToInt16(key));
                    manager.DeleteBookById(Convert.ToInt16(key));
                    BooksDataBind();
                }
            }
        }
    }
}
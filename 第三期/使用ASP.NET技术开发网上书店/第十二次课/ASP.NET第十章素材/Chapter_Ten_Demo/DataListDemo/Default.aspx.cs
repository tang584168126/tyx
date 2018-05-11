using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataListDemo
{
    public partial class Default : System.Web.UI.Page
    {
        private int pageSize = 2;
        public int PageIndex
        {
            get 
            {
                if (ViewState["PageIndex"] != null)
                {
                    return Convert.ToInt32(ViewState["PageIndex"]);
                }
                return 1;
            }
            set
            {
                ViewState["PageIndex"] = value;
            }
        }
        public int PageCount
        {
            get
            {
                if (ViewState["PageCount"] != null)
                {
                    return Convert.ToInt32(ViewState["PageCount"]);
                }
                return 1;
            }
            set
            {
                ViewState["PageCount"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindList();
            }
        }

        private void BindList()
        {
            //获取选项值
            string value = this.ddlSort.SelectedItem.Value;
            //根据选择值获取对应的排序字段
            string sortField = GetSortFieldBySelectedValue(value);
            //根据排序字段获取排序后的商品项 pageSize,pageIndex
            IList<Item> items = new ItemService().GetItems(pageSize,PageIndex,sortField);
            //总记录数
            int total = new ItemService().GetItemCount();
            //总页数
            PageCount = total / pageSize + ((total % pageSize) == 0 ? 0 : 1);
            this.lblMsg.Text = "当前第" + PageIndex + "页，总共" + PageCount + "页";
            this.dlItems.DataSource = items;
            this.dlItems.DataBind();
        }

        protected void dlItems_ItemCommand(object source, DataListCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;       //单击的按钮所在项的下标
            //删除项的主键值
            int itemId = Convert.ToInt32(this.dlItems.DataKeys[index]);

            try
            {
                new ItemService().DeleteItem(itemId);
            }
            catch (Exception)
            {

                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "DeleteTip", "<script>alert('删除失败！')</script>");
            }
        }

        private string GetSortFieldBySelectedValue(string value)
        {
            string sortField = "";
            switch (value)
            {
                case "1":
                    sortField = " categoryId";
                    break;
                case "2":
                    sortField = "price";
                    break;
                default:
                    sortField = "itemId";
                    break;
            }
            return sortField;
        }

        protected void ddlSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        private void SetButtonStatus()
        {
            //当第一页时，"上一页"按钮不可用
            if (PageIndex == 1)
            {
                this.btnPre.Enabled = false;
            }
            else
            {
                this.btnPre.Enabled = true;
            }
            //当最后一页时,"下一页"按钮不可用
            if (PageIndex == PageCount)
            {
                this.btnNext.Enabled = false;
            }
            else
            {
                this.btnNext.Enabled = true;
            }
        }

        protected void btnPre_Click(object sender, EventArgs e)
        {
            this.PageIndex--;
            BindList();
            SetButtonStatus();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            this.PageIndex++;
            BindList();
            SetButtonStatus();
        }
    }
}
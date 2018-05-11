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
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        CategoryManager categoryManager = new CategoryManager();
        List<Category> categoryList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            categoryList = categoryManager.GetCategories();

            InitTreeByList(this.tvCategory.Nodes,"0");
        }

        public void InitTreeByList(TreeNodeCollection tnc, string parentId)
        {
            TreeNode tnNode;
            foreach (Category category in categoryList)
            {
                tnNode = new TreeNode();
                if (category.PId.ToString().Equals(parentId))
                {
                    tnNode = new TreeNode();
                    tnNode.Value = category.Id.ToString();
                    tnNode.Text = "&nbsp;" + category.Name;
                    tnNode.ImageUrl = this.ResolveUrl("~/Images/arrow.gif");
                    tnNode.NavigateUrl = "#";

                    tnc.Add(tnNode);

                    InitTreeByList(tnNode.ChildNodes, tnNode.Value);
                }
            }
        }
    }
}
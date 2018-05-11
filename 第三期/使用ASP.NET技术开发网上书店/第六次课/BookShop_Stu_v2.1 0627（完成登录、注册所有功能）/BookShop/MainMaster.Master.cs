using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BookShop.BLL;
using BookShop.Models;

namespace BookShop
{
    public partial class MainMaster : System.Web.UI.MasterPage
    {
        CategoryManager categoryManager = new CategoryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            InitTree(this.tvNav.Nodes,"0");
        }

        private void InitTree(TreeNodeCollection tnc, string pId)
        {
            List<Category> categoryList = categoryManager.GetCategories();

            TreeNode tnNode = null;
            foreach (Category item in categoryList)
            {
                if (item.PId.ToString().Equals(pId))
                {
                    tnNode = new TreeNode();
                    tnNode.Value = item.Id.ToString();
                    tnNode.Text = "&nbsp;" + item.Name;
                    tnNode.ImageUrl = "~/Images/arrow.gif";
                    tnNode.NavigateUrl = "#";

                    tnc.Add(tnNode);

                    InitTree(tnNode.ChildNodes, tnNode.Value);
                }
            }
        }
    }
}
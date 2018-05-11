using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BookShopWeb
{
    public partial class Common : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //动态加载
            LoadCategories();
        }

        //从数据库读取数据并自动为TreeView生成节点
        private void LoadCategories()
        { 
            //从数据库获取数据
            List<Category> items = GetCategories();
            //绑定前先清空节点
            if (items.Count > 0)
                tvCategory.Nodes.Clear();

            //将PID=0的节点绑定到TreeView
            foreach(Category item in items)
            {
                if (item.PId == 0)
                {
                    TreeNode node = new TreeNode("&nbsp;" +item.Name,item.Id.ToString(),this.ResolveUrl("~/Images/Common/arrow.gif"));
                    node.NavigateUrl = "#";
                    this.tvCategory.Nodes.Add(node);
                    //递归绑定这个节点的所有子节点
                    BindNode(items, node);
                }                
            }
        }

        private void BindNode(List<Category> items,TreeNode pNode)
        { 
            foreach(Category item in items)
            {
                if (item.PId == int.Parse(pNode.Value))
                {
                    TreeNode node = new TreeNode("&nbsp;" + item.Name, item.Id.ToString(), this.ResolveUrl("~/Images/Common/arrow.gif"));
                    node.NavigateUrl = "#";
                    pNode.ChildNodes.Add(node);

                    //递归绑定这个节点的所有子节点
                    BindNode(items,node);
                }
            }
        }

        //获取所有的书籍类型
        private List<Category> GetCategories()
        {
            string sqlText = "select * from categories order by sortnum asc";
            List<Category> list = new List<Category>();
            DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConnectionString,CommandType.Text,sqlText);
            //表示查询出了结构并以表的形式添加到了DataSet中
            if (ds.Tables.Count > 0)
            { 
                //循环读取表中数据并放入列表集合中
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    //每次循环从表中读取一行数据并实例化为对应的对象。
                    Category category = new Category();

                    category.Id = (int)row["Id"];
                    category.Name = row["name"].ToString();
                    category.PId = (int)row["PId"];
                    category.SortNum = (int)row["SortNum"];
                    list.Add(category);
                }
            }
            return list;
        }
    }
}
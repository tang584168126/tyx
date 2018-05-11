using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06_TreeViewByRecursion
{
    public partial class Home : System.Web.UI.Page
    {
        DataSet ds = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.tvNav.Dispose();
                //将数据库中数据保存到DataSet中
                ds = this.GetDataToTable();
                //用递归的方法动态添加节点
                InitTree("0", this.tvNav.Nodes);
            }
        }

        /// <summary>
        /// 将数据库中数据保存到DataSet中
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataToTable()
        {
            String sqlText = "select * from [SysFunction]";

            return SqlHelper.ExecuteDataset(SqlHelper.ConnectionString, CommandType.Text, sqlText);
        }

        /// <summary>
        /// 用递归的方法动态添加节点
        /// </summary>
        /// <param name="parentId">父节点的值</param>
        /// <param name="tnc">节点对象的集合</param>
        public void InitTree(string parentId, TreeNodeCollection tnc)
        {
            DataView dv = new DataView();
            TreeNode treeNode = null;
            dv.Table = ds.Tables[0];
            dv.RowFilter = "ParentNodeId = " + parentId;

            foreach (DataRowView drv in dv)
            {
                treeNode = new TreeNode();
                treeNode.Value = drv["NodeId"].ToString();
                treeNode.Text = drv["DisplayName"].ToString();
                treeNode.NavigateUrl = drv["NavigateURL"].ToString();
                tnc.Add(treeNode);
                InitTree(treeNode.Value, treeNode.ChildNodes);
            }
        }
    }
}
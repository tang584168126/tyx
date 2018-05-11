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
            this.tvNav.Dispose();

            ds = GetDataToTable();

            InitTree(this.tvNav.Nodes,"0");
        }

        public DataSet GetDataToTable()
        {
            string sqlText ="select * from SysFunction";
            return SqlHelper.ExecuteDataset(SqlHelper.ConnectionString,CommandType.Text, sqlText);
        }

        public void InitTree(TreeNodeCollection tnc , string parentId)
        {
            DataView dv = new DataView();
            dv.Table = ds.Tables[0];
            dv.RowFilter = "ParentNodeId = " + parentId;
            TreeNode tn = null;

            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode();
                tn.Value = drv["NodeId"].ToString();
                tn.Text = drv["DisplayName"].ToString();
                tn.NavigateUrl = drv["NavigateURL"].ToString();
                tnc.Add(tn);
                InitTree(tn.ChildNodes, tn.Value);
            }
        }
    }
}